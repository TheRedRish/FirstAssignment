using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstAssignment.Models;

namespace FirstAssignment.Codes
{
    internal class Intro
    {

        public void InitiateIntro()
        {
            DateCheck checkDate = new();
            Console.Clear();

            Console.WriteLine("Indtast bilens mærke: ");
            string carMake = Console.ReadLine();

            Console.WriteLine("Indtast bilens model: ");
            string carModel = Console.ReadLine();

            // date in format xx-xx-xxxx
            Console.WriteLine("Brug datoformatet: dd-mm-yyyy");
            Console.WriteLine("Indtast bilens årgang: ");
            string carYearAsString = checkDate.CheckIfStringIsDateFormat(Console.ReadLine());
            DateOnly carYear = DateOnly.FromDateTime(Convert.ToDateTime(carYearAsString));

            // date in format xx-xx-xxxx
            Console.WriteLine("Indtast bilens registreringsdato: ");
            string carRegistrationYearAsString = checkDate.CheckIfStringIsDateFormat(Console.ReadLine());
            DateOnly carRegitrationYear = DateOnly.FromDateTime(Convert.ToDateTime(carRegistrationYearAsString));

            // date in format xx-xx-xxxx
            Console.WriteLine("Tip: Hvis bilen ikke er blevet synet indtast samme dato som registreringsdatoen");
            Console.WriteLine("Indtast bilens sidste syns dato: ");
            string carLastInspectionAsString = checkDate.CheckIfStringIsDateFormat(Console.ReadLine());
            DateOnly carLastInspection = DateOnly.FromDateTime(Convert.ToDateTime(carLastInspectionAsString));

            CarModels CarModels = new()
            {
                CarMake = carMake,
                CarModel = carModel,
                CarYear = carYear,
                CarRegistrationYear = carRegitrationYear,
                CarLastInspection = carLastInspection
            };
        }
    }
}
