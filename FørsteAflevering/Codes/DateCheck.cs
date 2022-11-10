using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment.Codes
{
    internal struct DateCheck
    {
        public string CheckIfStringIsDateFormat(string dateAsString)
        {
            Intro initiateIntro = new();

            try
            {
                DateOnly.FromDateTime(Convert.ToDateTime(dateAsString));
            }
            catch (Exception)
            {
                Console.WriteLine("Du har indtastet noget forkert");
                Console.Write("Prøv igen");
                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }
                initiateIntro.InitiateIntro();
            }

            string[] dateAsStringSplit = dateAsString.Split("-");
            if (dateAsStringSplit.Length != 3 && dateAsStringSplit[0].Length == 2 && dateAsStringSplit[1].Length == 2 && dateAsStringSplit[2].Length == 4)
            {
                Console.Write("Dato indtastet i forkert format. Prøv igen med formattet dd-mm-yyyy");
                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }
                initiateIntro.InitiateIntro();
            }

            return dateAsString;
        }
    }
}
