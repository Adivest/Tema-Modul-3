using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_modul_3_partea_2_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string PrimaMetoda = "FirstMethod";
            Console.WriteLine("String  : " + PrimaMetoda.Substring(5));
            

            string nou = "E interesanta";
            string MetodaDoi = string.Concat("MetodaDoi", nou);
            Console.WriteLine("Noul string este:  " + MetodaDoi);

            string MetodaTrei = "Metodatrei";
            Console.WriteLine(MetodaTrei.ToUpper());

            string MetodaPatru = "MetodaPatru";
            Console.WriteLine("Noul string este: " + MetodaPatru.Replace('M', 'R'));

            string MetodaCinci = "MetodaCinci";
            bool b1 = string.IsNullOrEmpty(MetodaCinci);
            Console.WriteLine(b1);

            string MetodaSase = "MetodaSase";
            int index1 = MetodaSase.IndexOf('t');
            Console.WriteLine("Indexul caracterului 't' este:  " + index1);

            string MetodaSapte = "MetodaSapte";
            string Sapte = "Sapte";
            Console.WriteLine(MetodaSapte.Contains(Sapte));

            Console.ReadLine();
;         }
    }
}
