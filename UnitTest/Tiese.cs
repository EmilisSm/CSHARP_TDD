using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Tiese
    {
        int _x1;
        int _y1;
        int _x2;
        int _y2;

        public Tiese(int x1, int y1, int x2, int y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public int KryptiesKof()
        {
            int y = _y2 - _y1;
            int x = _x2 - _x1;

            int k = y / x;

            Console.WriteLine("Krypties koeficientas: {0} ", k);

            return k;


        }

        public int TiesesIlgis()
        {
            int y = _y2 - _y1;
            int x = _x2 - _x1;

            int i = y + x;


            Console.WriteLine("Tieses ilgis: {0} ", i);

            return i;

        }



    }
}
