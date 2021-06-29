using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace GDCConsoleApp.Services
{
	public class EmailService : IEmailService
	{
        private readonly string RegExp1 = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        private readonly  string RegExp = @"/^([w-]+(?:.[w-]+)*)@((?:[w-]+.)*w[w-]{0,66}).([com net org]{3}(?:.[a-z]{6})?)$/i";

        public bool ValidateEmail(string email)
		{
            bool isValidEmail = false;

            try
            {
                var mail = new MailAddress(email);
                isValidEmail = mail.Host.Contains(".");

                //if (!isValidEmail)
                //{
                //    Console.WriteLine($"The email is invalid");
                //}
                //else
                //{
                //    Console.WriteLine($"The email is valid");
                //}
            }

            catch (Exception)
            {
                Console.WriteLine($"The email is invalid");
            }

            return isValidEmail;
        }


        public bool ValidateEmailRegex(string email)
        {
            bool isValidEmail = false;

            try
            {
              
                Regex regex = new Regex(RegExp); //RegexOptions.CultureInvariant | RegexOptions.Singleline
                isValidEmail = regex.IsMatch(email);
               
                //if (!isValidEmail)
                //{
                //    Console.WriteLine($"The email is invalid");
                //}
                //else
                //{
                //    Console.WriteLine($"The email is valid");
                //}
            }

            catch (Exception)
            {
                Console.WriteLine($"The email is invalid");
            }

            return isValidEmail;
        }
    }
}
