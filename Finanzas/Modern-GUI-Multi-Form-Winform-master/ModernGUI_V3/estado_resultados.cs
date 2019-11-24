using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernGUI_V3
{
    class estado_resultados
    {
        private static estado_resultados instance = null;
        public double ventas;
        public double costos_ventas;
        public double utilidad_bruta;
        public double gastos_operacion;
        public double utilidad_de_operacion;
        public double otros_productos;
        public double otros_gastos;
        public double utilidad_antes;
        public double ISR;
        public double PTU;

        public double ventas2;
        public double costos_ventas2;
        public double utilidad_bruta2;
        public double gastos_operacion2;
        public double utilidad_de_operacion2;
        public double otros_productos2;
        public double otros_gastos2;
        public double utilidad_antes2;
        public double ISR2;
        public double PTU2;

        protected estado_resultados() { }

        public static estado_resultados Instance
        {
            get
            {
                if (instance == null)
                    instance = new estado_resultados();

                return instance;
            }
        }
    }
}
