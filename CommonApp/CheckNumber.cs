using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PhoneNumbers;

namespace CommonApp
{
    public class CheckNumber
    {
        public static bool IsPhoneNumber(string str)
        {
            PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance("VN");
            PhoneNumber number;
            try
            {
                number = phoneUtil.Parse(str, "VN");
            }
            catch (NumberParseException)
            {
                return false;
            }
            return phoneUtil.IsValidNumber(number);
        }
        public static bool IsValidCurrency(string str)
        {
            return Regex.IsMatch(str, @"^([0-9]{1,3}(\.[0-9]{3})*)(\.[0-9]{2})?$");
        }
    }
}

