using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernGUI_V3
{
    public class shareddata
    {
        private static shareddata instance = null;
        public double activo1;
        public double activo2;
        public double pasivo1;
        public double pasivo2;
        public double capital1;
        public double capital2;
        public double pascap1;
        public double pascap2;

        public double bancos;
        public double instrumentos_financieros;
        public double cyddiversos;
        public double almacen;
        public double pagos_anticipados;
        public double edificios;
        public double softysis;

        public double bancos2;
        public double instrumentos_financieros2;
        public double cyddiversos2;
        public double almacen2;
        public double pagos_anticipados2;
        public double edificios2;
        public double softysis2;

        public double proovedores;
        public double acreedores;
        public double retencion;
        public double impuestos;
        public double provisiones;
        public double otros;
        public double credito;

        public double proovedores2;
        public double acreedores2;
        public double retencion2;
        public double impuestos2;
        public double provisiones2;
        public double otros2;
        public double credito2;

        public double capital_social;
        public double aportacion;
        public double reservas;
        public double utilidads;

        public double capital_social2;
        public double aportacion2;
        public double reservas2;
        public double utilidads2;
        protected shareddata() { }

        public static shareddata Instance
        {
            get
            {
                if (instance == null)
                    instance = new shareddata();

                return instance;
            }
        }
    }
}
