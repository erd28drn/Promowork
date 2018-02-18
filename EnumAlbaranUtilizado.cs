using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace Promowork
{
     [TypeConverter(typeof(CustomEnumConverter))]
    public enum EnumUtilizadoAlbaran
    {
        [Description("Utilizado en Partes")]
        utilizadoParte = 1,
        [Description("Utilizado en Presupuestos")]
        utuluzadoPresupuesto = 2,
        [Description("Ne se Utilizará")]
        noUtilizara = 3
    }

}
