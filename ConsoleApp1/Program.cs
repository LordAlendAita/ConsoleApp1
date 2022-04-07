using System;

namespace Methoden_HoteCheckIn
{
    class Program
    {
        static void Main()
        {
            do
            {
                                            // zn[0]        zn[1]       zn[2]       zn[3]        
                short[] zimmernummer =      { 45,           23,            3,       32 };
                                            // vn[0]        vn[1]       vn[2]       vn[3]                                              
                string[] vorname =          { "John",    "Paul",    "George",   "Ringo" };
                                            // nn[0]        nn[1]       nn[2]       nn[3]   
                string[] Nachname =         { "Lennon", "McCartney", "Harrison", "Starr" };
                short[] übernachtung =      { 1,        4,                  12,         3 };
                double[] rechnungsbetrag =  { 82.46,    329.84,         989.52,     247.38 };

                Console.WriteLine("Bitte geben Sie Nachnamen oder Zimmernummer ein");
                string eingabe_str = Console.ReadLine();
                short eingabe_short;

                bool flag = short.TryParse(eingabe_str, out eingabe_short);

                if (flag == false)
                {
                    var data = GetData(eingabe_str, zimmernummer, vorname, Nachname, übernachtung, rechnungsbetrag);
                }
                else
                {
                    var data = GetData(eingabe_short, zimmernummer, vorname, Nachname, übernachtung, rechnungsbetrag);

                    if (data.Item1 == true)
                    {
                        Console.WriteLine("Willkommen\n Vorname (0) ");
                    }
                    else
                    {
                        Console.WriteLine("Nicht verfügbar");
                    }

                }
            } while (true);


        }

        static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {
            bool EI = false;
            int index = 0;
            for (int i = 0; i< zn.Length;i++)
            {   
                if(zn[i] == diff)
                {
                    EI = true;
                    index = i;
                }

            }

            return (EI,zn[index],vn[index],nn[index],ue[index],rb[index]);
        }

        static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ue, double[] rb)
        {

            return (,,,,);

            // Alend Ibrahim, Andi Sojeva
        }
    }
}