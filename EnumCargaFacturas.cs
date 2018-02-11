using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace Promowork
{
     [TypeConverter(typeof(CustomEnumConverter))]
    public enum EnumCargaFacturas
    {
        [Description("Pendientes de Pago")]
        pendientesPago = 1,
        [Description("Pagadas")]
        pagadas = 2,
        [Description("Todas")]
        todas = 3
    }

}
