using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace GerenciamentoEstoque.Dominio.Enumeradores
{
    [ExcludeFromCodeCoverage]
    public static class EnumExtension
    {
        /// <summary>
        /// Recuperar valor de anotação Description de um valor de enum
        /// </summary>
        /// <param name="value">Enumerador</param>
        /// <returns></returns>
        public static string GetDescription(this Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());

            var attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        /// <summary>
        /// Recuperar EnumValue correspondente ao enum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EnumValue GetValue(this Enum value)
        {
            return new EnumValue() { Value = value.ToString(), Description = value.GetDescription() };
        }

        /// <summary>
        /// Recuperar lista com valores e identificadores de 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<EnumValue> GetValues<T>()
        {
            var values = new List<EnumValue>();
            var type = typeof(T);

            foreach (var item in Enum.GetNames(type))
            {
                var enun = (Enum)Enum.Parse(type, item);

                values.Add(new EnumValue()
                {
                    Value = enun.ToString(),
                    Description = enun.GetDescription()
                });
            }

            return values.OrderBy(x => x.Description).ToList();
        }
    }
}
