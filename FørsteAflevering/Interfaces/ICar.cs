using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment.Interfaces
{
    internal interface ICar
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public DateOnly CarYear { get; set; }
        public DateOnly CarRegistrationYear { get; set; }
        public DateOnly CarLastInspection { get; set; }
    }
}
