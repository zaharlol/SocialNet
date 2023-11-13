﻿
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SocialNet.ViewModels.Account
{
	public class LoginViewModel
	{
        public string Login { get; set; }
		public string ReturnUrl { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string Email { get; set; }
	}
}

