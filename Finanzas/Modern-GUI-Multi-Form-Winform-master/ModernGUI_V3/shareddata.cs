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
