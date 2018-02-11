// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnumEnhanced.cs" company="ICF">
//   © Copyright 2014 Institut Català de Finances
// </copyright>
// <summary>
//   The enum enhanced.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Promowork
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The enum enhanced.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
    public static partial class EnumEnhanced
    {
        /// <summary>
        /// The get description.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetDescription(this Enum value)
        {
            return value == null ? String.Empty : GetEnumDescription(value);
        }

        /// <summary>
        /// The get enum description.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here."), SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1627:DocumentationTextMustNotBeEmpty", Justification = "Reviewed. Suppression is OK here.")]
        private static string GetEnumDescription(Enum value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var tipo = value.GetType();
            if (!tipo.IsEnum)
            {
                throw new Exception("It wasn't a enum...");
            }

            var fieldInfo = tipo.GetField(value.ToString());
            if (fieldInfo == null)
                return string.Empty;
            var atributos = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return atributos.Length == 0 ? string.Empty : atributos[0].ToString();
        }
    }
}
