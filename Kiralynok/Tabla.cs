using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    class Tabla
    {
        private char[,] T;

        private char UresCella;

        public int UresOszlopokSzama
        {
            get
            {
                int oszlopok = 0;
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    if (UresOszlop(oszlop))
                    {
                        oszlopok++;
                    }
                }
                return oszlopok;
            }
        }

        public int UresSorokSzama
        {
            get
            {
                int sorok = 0;
                for (int sor = 0; sor < 8; sor++)
                {
                    if (UresSor(sor))
                    {
                        sorok++;
                    }
                }
                return sorok;
            }
        }

        public Tabla(char uresCella)
        {
            T = new char[8,8];
            UresCella = uresCella;

            for (int sor = 0; sor < 8; sor++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    T[sor, oszlop] = UresCella;
                }
            }
        }

        public string Megjelenit()
        {
            StringBuilder sb = new StringBuilder();
            for (int sor = 0; sor < 8; sor++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    sb.Append(T[sor, oszlop]);
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public void Elhelyez(int N)
        {
            Random rnd = new Random();
            while (N > 0)
            {
                int sor = rnd.Next(8);
                int oszlop = rnd.Next(8);
                if (T[sor, oszlop] == UresCella)
                {
                    T[sor, oszlop] = 'K';
                    N--;
                }
            }

        }

        public bool UresOszlop(int oszlop)
        {
            for (int sor = 0; sor < 8; sor++)
            {
                if (T[sor, oszlop] == 'K')
                {
                    return false;
                }
            }
            return true;
        }

        public bool UresSor(int sor)
        {
            for (int oszlop = 0; oszlop < 8; oszlop++)
            {
                if (T[sor, oszlop] == 'K')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
