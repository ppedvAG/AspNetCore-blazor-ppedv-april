using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_MVC_EF.Models
{
    public class LargerThanValidation : ValidationAttribute
    {
        int minimumValue { get; set; }

        public LargerThanValidation(int MinimumValue)
        {
            minimumValue = MinimumValue;
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            int? intValue = (int)value;

            if (!intValue.HasValue)
                return false;

            if (intValue < minimumValue)
                return false;

            return true;
        }
    }
}
