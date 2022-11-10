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
        public bool ShouldCarGetInspection()
        {
            DateOnly currentTime = DateOnly.FromDateTime(DateTime.Now);

            CarModels CarModels = new();

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
