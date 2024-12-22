using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQBALNAFIS
{
    internal class Tugas
    {
        public void Pattern()
        {
            Console.Write("Inputkan angka: ");
            string masukanAngka = Console.ReadLine();

            if (double.TryParse(masukanAngka, out double angka))
            {
                int bagianBulat = (int)Math.Floor(angka);
                double bagianDesimal = angka - bagianBulat;

                // Pola menaik
                for (int baris = 1; baris <= bagianBulat; baris++)
                {
                    for (int kolom = 1; kolom <= baris; kolom++)
                    {
                        //batas untuk baris 20 baris
                        if (baris <= 20)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            break;
                        }
                    }
                    //batas pattern cuman 20 baris
                    if (baris <= 20)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        break;
                    }
                }

                if (bagianBulat >= 99 && bagianDesimal > 0)
                {
                    int batas = (int)Math.Ceiling(bagianDesimal * 10);
                    if(bagianDesimal >=0.10)
                    {
                        batas *=10;
                        Console.WriteLine("batas = " + batas);
                    }
                    for (int baris = batas; baris >= 1; baris--)
                    {
                        for (int kolom = 1; kolom <= baris; kolom++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Periksa Inputan!!");
            }
        }
    }
}
