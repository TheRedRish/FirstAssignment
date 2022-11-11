using FirstAssignment.Models;
using FirstAssignment.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment.Codes
{
    internal struct CheckIfCarShouldGetInspection
    {
        private CarModels CarModels { get; set; }
        public CheckIfCarShouldGetInspection(CarModels carModels)
        {
            CarModels = carModels;
            if (ShouldCarGetInspection())
            {
                Console.WriteLine("Bilen skal til syn");
            }
            else
            {
                Console.WriteLine("Bilen skal ikke synes");
            }
        }

        public bool ShouldCarGetInspection()
        {
            DateOnly currentTime = DateOnly.FromDateTime(DateTime.Now);

            int inspectionTimeAfterRegistrationInYears = (int)CarInspectionEnum.inspectionTimeAfterRegistrationInYears;
            int inspectionTimeAfterLastEnspectionInYears = (int)CarInspectionEnum.inspectionTimeAfterLastInspecionInYears;

            if (currentTime.CompareTo(CarModels.CarRegistrationYear.AddYears(inspectionTimeAfterRegistrationInYears)) > 0)
            {
                return true;
            }
            else if (currentTime.CompareTo(CarModels.CarLastInspection.AddYears(inspectionTimeAfterLastEnspectionInYears)) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
