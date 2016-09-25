using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Data.Linq.Mapping;
using EduSim.ModelInterfaces;
namespace EduSim.ModelInterfaces
{
	public interface IAccount : ISyncColumns
	{
		int AccountId { get; set; }
		string AccountName { get; set; }
		int AccountTypeId { get; set; }
	}
}

