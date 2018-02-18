using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promowork
{
    using System.ComponentModel;
    using System.Globalization;
    using System.Reflection;

    public class CustomEnumConverter : EnumConverter
    {
        private readonly Type enumType;

        /// Initializing instance
        /// type Enum
        ///this is only one function, that you must
        ///to change. All another functions for enums
        ///you can use by Ctrl+C/Ctrl+V
        public CustomEnumConverter(Type type)
            : base(type)
        {
            this.enumType = type;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType)
        {
            return destType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destType)
        {
            var fi = this.enumType.GetField(Enum.GetName(this.enumType, value));
            var dna = (DescriptionAttribute)Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));
            return dna != null ? dna.Descripcion : value.ToString();
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType)
        {
            return srcType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            foreach (var fi in this.enumType.GetFields())
            {
                var dna = (DescriptionAttribute)Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));
                if ((dna != null) && ((string)value == dna.Descripcion))
                    return Enum.Parse(this.enumType, fi.Name);
            }
            return Enum.Parse(this.enumType, (string)value);
        }

        /// <summary>
        /// Obte una llista claus-valors d'un enum.
        /// </summary>
        /// <typeparam name="T">Enum</typeparam>
        /// <returns>Llista valors</returns>
        public static IList<KeyValuePair<int, string>> ConvertToKeyValuePair<T>() where T : struct
        {
            if (!typeof(T).IsEnum)
            {
                return null;
            }

            var resultat = new List<KeyValuePair<int, string>>();
            var valors = Enum.GetValues(typeof(T));
            foreach (var valor in valors)
            {
                resultat.Add(new KeyValuePair<int, string>((int)valor, ((Enum)valor).GetDescription()));
            }
            return resultat;
        }

    }
}
