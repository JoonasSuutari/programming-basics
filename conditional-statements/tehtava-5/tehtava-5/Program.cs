using System;

namespace tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int hinta = 16;

            int ika;
            Console.Write("Syötä ikä: \n");
            ika = Convert.ToInt32(Console.ReadLine());

            string mtk;
            Console.Write("Oletko mtk jäsen? Kyllä tai ei : \n");
            mtk = Console.ReadLine();
            mtk.ToLower();
            bool mtkMember;
            if (mtk.Equals("kyllä"))
            {
                mtkMember = true;
            }
            else
            {
                mtkMember = false;
            }

            string varus;
            Console.Write("Oletko varusmies? Kyllä tai ei : \n");
            varus = Console.ReadLine();
            varus.ToLower();
            bool varusMember;
            if (varus.Equals("kyllä"))
            {
                varusMember = true;
            }
            else
            {
                varusMember = false;
            }

            string opi;
            Console.Write("Oletko opiskelija? Kyllä tai ei : \n");
            opi = Console.ReadLine();
            opi.ToLower();
            bool opiMember;
            if (opi.Equals("kyllä"))
            {
                opiMember = true;
            }
            else
            {
                opiMember = false;
            }
            Console.WriteLine("\n");

            if (ika < 7)
            {
                Console.WriteLine("Alle 7 vuotiaat ilmaiseksi.\n");
            }

            else if (opiMember == true && mtkMember == true)
            {
                Console.WriteLine("60% alennus\n");
                Console.WriteLine("Lippu maksaa {0} euroa", hinta * 0.40);
            }

            else if (ika >= 65)
            {
                Console.WriteLine("50% alennus\n");
                Console.WriteLine("Lippu maksaa {0} euroa", hinta / 2);
            }

            else if (ika >= 7 && ika <= 15)
            {
                Console.WriteLine("50% alennus\n");
                Console.WriteLine("Lippu maksaa {0} euroa", hinta / 2);
            }

            else if (varusMember == true)
            {
                Console.WriteLine("50% alennus\n");
                Console.WriteLine("Lippu maksaa {0} euroa", hinta / 2);
            }

            else if (opiMember == true)
            {
                Console.WriteLine("45% alennus\n");
                Console.WriteLine("Lippu maksaa {0} euroa", hinta * 0.55);
            } 

            else if (mtkMember == true)
            {
                Console.WriteLine("15% alennus\n");
                Console.WriteLine("Lippu maksaa {0} euroa", hinta * 0.85);
            }

            else
            {
                Console.WriteLine("Lippu maksaa {0} euroa", hinta);
            }

            Console.ReadKey();
        }
    }
}
