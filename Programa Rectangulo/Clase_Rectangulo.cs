using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Rectangulo
{
    class Clase_Rectangulo : MainWindow
    {
        private int x;
        private int y;
        private int result;

        public Clase_Rectangulo()
        {
            x = 0;
            y = 0;
            result = 2(x) + 2(y);
            result = 0;
        }

       public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public int Result
        {
            get
            {
                return result;
            }
            set
            {
                result = y;
            }
        }

        public override Int32 ToString()
        {
            Console.WriteLine("El Area del cuadrado es: {0}", Result);
        }
    }
}
