using System.Diagnostics.CodeAnalysis;

namespace GerenciamentoEstoque.Dominio.Enumeradores
{
    [ExcludeFromCodeCoverage]
    public class EnumValue
    {
        public string Value { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            var value = obj as EnumValue;
            return value != null &&
                   Value == value.Value &&
                   Description == value.Description;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
