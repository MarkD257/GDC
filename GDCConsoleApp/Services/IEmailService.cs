using System;
using System.Collections.Generic;
using System.Text;

namespace GDCConsoleApp.Services
{
	interface IEmailService
	{
		bool ValidateEmail(string email);
		bool ValidateEmailRegex(string email);
	}
}
