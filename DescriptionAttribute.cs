// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DescriptionAttribute .cs" company="ICF">
//   © Copyright 2014 Institut Català de Finances
// </copyright>
// <summary>
//   The description attribute.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Promowork
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The description attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class DescriptionAttribute : Attribute
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionAttribute"/> class.
        /// </summary>
        public DescriptionAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescriptionAttribute"/> class.
        /// </summary>
        /// <param name="descripcion">
        /// The descripcion.
        /// </param>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public DescriptionAttribute(string descripcion)
        {
            this.Descripcion = descripcion;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the descripcion.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        public string Descripcion { get; set; }

        #endregion

        #region Private Properties

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return this.Descripcion ?? string.Empty;
        }

        #endregion
    }
}
