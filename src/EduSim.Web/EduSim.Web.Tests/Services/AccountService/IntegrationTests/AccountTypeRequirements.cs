using EduSim.Core.Constants;
using EduSim.Core.Services.Abstractions;
using EduSim.Core.Models;
using EduSim.Core.ModelInterfaces;
using EduSim.Web.Services;
using System;
using System.Collections;
using System.Linq;
using NUnit;
using NUnit.Framework;

namespace EduSim.Web.Tests
{
	[TestFixture]
	[Category("All")]
	[Category("BusinessRequirements")]
	public class AccountTypeRequirements
	{
		private IAccountService SUT;

		[SetUp]
		public void Setup()
		{
			SUT = new AccountService();
		}

		[TearDown]
		public void TearDown()
		{
			SUT = null;
		}

		[Test]
		public void AccountService_GetAccountTypes_HasDistrict()
		{
			AccountType account = SUT.GetAccountTypes()
									 .Where(t => t.AccountTypeId == Core.Constants.AccountTypes.District.Id)
									 .FirstOrDefault();
			Assert.NotNull(account);
		}
	}
}
