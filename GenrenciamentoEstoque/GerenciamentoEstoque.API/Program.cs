using System.Reflection;
using System.Text.Json.Serialization;
using GerenciamentoEstoque.Aplicacao.Produtos.Profiles;
using GerenciamentoEstoque.Aplicacao.Produtos.Servicos;
using GerenciamentoEstoque.Dominio.Produtos.Servicos;
using GerenciamentoEstoque.Infra.Produtos.Mapeamentos;
using GerenciamentoEstoque.Infra.Produtos.Repositorios;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.OpenApi.Models;
using NHibernate;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddJsonOptions(op =>

{
    op.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    op.JsonSerializerOptions.PropertyNamingPolicy = null;
});

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "GerenciamentoEstoque", Version = "v1" });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    c.IncludeXmlComments(xmlPath);


});


builder.Services.AddSingleton<ISessionFactory>(factory =>
{
    string connectionString = builder.Configuration.GetConnectionString("MySql");
    return Fluently.Configure()
    .Database((MySQLConfiguration.Standard.ConnectionString(connectionString)
    .FormatSql()
    .ShowSql()))
    .Mappings(x => x.FluentMappings.AddFromAssemblyOf<ProdutosMap>())
    .BuildSessionFactory();
});

builder.Services.AddScoped<NHibernate.ISession>(factory => factory.GetService<ISessionFactory>()!.OpenSession());
builder.Services.AddScoped<ITransaction>(factory => factory.GetService<NHibernate.ISession>()!.BeginTransaction());

builder.Services.AddAutoMapper(typeof(ProdutosProfile));
builder.Services.Scan(scan => scan
    .FromAssemblyOf<ProdutosAppServico>()
        .AddClasses()
            .AsImplementedInterfaces()
                .WithScopedLifetime());

builder.Services.Scan(scan => scan
    .FromAssemblyOf<ProdutosServico>()
        .AddClasses()
            .AsImplementedInterfaces()
                .WithScopedLifetime());

builder.Services.Scan(scan => scan
    .FromAssemblyOf<ProdutosRepositorio>()
        .AddClasses()
            .AsImplementedInterfaces()
                .WithScopedLifetime());

var app = builder.Build();
app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "GerenciamentoEstoque.xml");
                c.DisplayRequestDuration();
            });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();