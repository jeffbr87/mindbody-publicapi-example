using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace PublicApiApp.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static bool IsValidEmailAddress(this string str)
        {
            try
            {
                var mailAddress = new MailAddress(str);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(this string str)
        {
            const string regexStr = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            return new Regex(regexStr).IsMatch(str);
        }
    }
}
