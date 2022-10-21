using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1.Validation
{
    public class MailValidation : ValidationRule
    {
        public string poruka { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                if (Regex.IsMatch(s, @"^[a-zA-Z0-9\.]+@[a-zA-Z0-9\.]+\.[a-zA-Z]+$"))
                {
                    return new ValidationResult(true, null);
                  
                }
                else
                {
                    return new ValidationResult(false,"Not Valid Email");
                    poruka = "Nevalidna mail adresa!";

                }
            }
            catch
            {
                return new ValidationResult(false, "exepcion");
            }
        }
    }
}
