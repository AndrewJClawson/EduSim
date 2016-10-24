using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using EduSim.Core.Identity;

namespace EduSim.Core
{
	public class ApplicationUserManager : UserManager<IdentityUser, int>
	{
		public ApplicationUserManager(IUserStore<IdentityUser, int> store)
			: base(store)
		{
		}

		public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
		{
			var manager = new ApplicationUserManager(new UserStore<ApplicationUser, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>(context.Get<ApplicationDbContext>()));
			// Configure validation logic for usernames
			manager.UserValidator = new UserValidator<ApplicationUser, int>(manager)
			{
				AllowOnlyAlphanumericUserNames = false,
				RequireUniqueEmail = false
			};

			// Configure validation logic for passwords
			if (EnvironmentHelper.CurrentEnvironment == CalPeats.Constants.Environment.Production)
			{
				manager.PasswordValidator = new PasswordValidator
				{
					RequiredLength = 8,
					RequireNonLetterOrDigit = true,
					RequireDigit = true,
					RequireLowercase = true,
					RequireUppercase = true,
				};
			}
			else
			{
				manager.PasswordValidator = new PasswordValidator
				{
					RequiredLength = 3,
					RequireNonLetterOrDigit = false,
					RequireDigit = false,
					RequireLowercase = false,
					RequireUppercase = false,
				};
			}

			// Configure user lockout defaults
			manager.UserLockoutEnabledByDefault = true;
			manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(1440);
			manager.MaxFailedAccessAttemptsBeforeLockout = 100;

			// Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
			// You can write your own provider and plug it in here.
			//manager.RegisterTwoFactorProvider("Phone Code", new PhoneNumberTokenProvider<ApplicationUser, int>
			//{
			//    MessageFormat = "Your security code is {0}"
			//});
			//manager.RegisterTwoFactorProvider("Email Code", new EmailTokenProvider<ApplicationUser, int>
			//{
			//    Subject = "Security Code",
			//    BodyFormat = "Your security code is {0}"
			//});
			//manager.EmailService = new EmailService();
			//manager.SmsService = new SmsService();
			var dataProtectionProvider = options.DataProtectionProvider;
			if (dataProtectionProvider != null)
			{
				manager.UserTokenProvider =
					new DataProtectorTokenProvider<ApplicationUser, int>(dataProtectionProvider.Create("ASP.NET Identity"));
			}
			return manager;
		}
}
