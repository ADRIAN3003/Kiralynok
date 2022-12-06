using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kiralynok
{
    class Program
    {
        static Tabla tabla;
        static void Main(string[] args)
        {
            NegyedikFeladat();
            HatodikFeladat();
            KilencedikFeladat();
            TizedikFeladat();

            Console.ReadKey();
        }

        private static void TizedikFeladat()
        {
            if (File.Exists("tablak64.txt"))
            {
                File.Delete("tablak64.txt");
            }


            using (StreamWriter sw = new StreamWriter("tablak64.txt"))
            {
                for (int i = 1; i <= 64; i++)
                {
                    Tabla newTabla = new Tabla('*');
                    newTabla.Elhelyez(i);
                    sw.WriteLine(newTabla.Megjelenit());
                }
            }
        }

        private static void KilencedikFeladat()
        {
            Console.WriteLine("\n9. feladat: Üres oszlopok és sorok száma:");
            Console.WriteLine("Oszlopok: " + tabla.UresOszlopokSzama);
            Console.WriteLine("Sorok: " + tabla.UresSorokSzama);
        }

        private static void HatodikFeladat()
        {
            Console.WriteLine("\n5. feladat: A feltöltött tábla:");
            tabla.Elhelyez(8);
            Console.WriteLine(tabla.Megjelenit());
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine("4. feladat: Az üres tábla:");
            tabla = new Tabla('#');
            Console.WriteLine(tabla.Megjelenit());
        }
    }
}
