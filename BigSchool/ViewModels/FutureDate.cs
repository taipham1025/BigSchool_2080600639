﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isvalid = DateTime.TryParseExact(Convert.ToString(value),
                    "dd/M/yyyy",
                    CultureInfo.CurrentCulture,
                    DateTimeStyles.None,
                    out dateTime);

            return (isvalid && dateTime > DateTime.Now);
        }
    }
}