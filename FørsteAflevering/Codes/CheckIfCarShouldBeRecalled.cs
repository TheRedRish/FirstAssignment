using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstAssignment.Models;

namespace FirstAssignment.Codes
{
    internal struct CheckIfCarShouldBeRecalled
    {
        private CarModels CarModels { get; set; }
        public bool shouldBeRecalled { get; set; }
        public string recallReason { get; set; }
        public CheckIfCarShouldBeRecalled(CarModels carModels)
        {
            CarModels = carModels;
            shouldBeRecalled = false;
            recallReason = "";
            ShouldCarBeRecalled();
            if (shouldBeRecalled)
            {
                Console.WriteLine("Bilen har følgende fabriksfejl: " + recallReason);
            }
        }
        public void ShouldCarBeRecalled()
        {
            string[,] carsWithDefects =
            {
                { "Mærke", "Model", "Ældre end følgende dato", "Fabriksfejl" },
                { "Fiat", "Ponto", "01-01-2010", "Udstødning" },
                { "Alfa Romeo", "Giulia", "01-08-2019", "Styrtøjet" }
            };

            for (int i = 1; i < carsWithDefects.GetLength(0); i++)
            {
                if (carsWithDefects[i, 0].ToLower() == CarModels.CarMake.ToLower() &&
                    carsWithDefects[i, 1].ToLower() == CarModels.CarModel.ToLower() &&
                    CarModels.CarYear.CompareTo(DateOnly.Parse(carsWithDefects[i, 2])) < 0)
                {
                    shouldBeRecalled = true;
                    recallReason = carsWithDefects[i, 3];
                }
            }

        }
    }
}

