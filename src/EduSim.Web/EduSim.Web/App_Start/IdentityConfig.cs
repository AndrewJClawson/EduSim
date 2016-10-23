using EduSim.Core.Models;
using EduSim.Core.Contexts;

public class ApplicationUserStore : UserStore<ApplicationUser>
{
	public ApplicationUserStore(ApplicationDbContext context) : base(context)
	{
	}
}