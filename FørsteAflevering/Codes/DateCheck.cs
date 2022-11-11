using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment.Codes
{
    internal struct DateCheck
    {
        public bool IsStringInDateFormat(string dateAsString)
        {
            try
            {
                DateOnly.Parse(dateAsString);
            }
            catch (Exception)
            {
                return false;
            }

            string[] dateAsStringSplit = dateAsString.Split("-");
            if (dateAsStringSplit.Length != 3)
            {
                return false;
            }

            return true;
        }
    }
}
