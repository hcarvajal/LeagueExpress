using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Security.Claims;
using LeagueExpress.Models;

[assembly: OwinStartupAttribute(typeof(LeagueExpress.Startup))]
namespace LeagueExpress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Here we create a Admin super user who will maintain the website				
            // In Startup iam creating first Admin Role and creating a default Admin User 
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Administrator";
                roleManager.Create(role);


            }


            var user = new ApplicationUser();
            user.UserName = "rjea7748@bellsouth.net";
            user.Email = "rjea7748@bellsouth.net";

            string userPWD = "08_212003";

            var chkUser = UserManager.Create(user, userPWD);

            //Add default User to Role Admin
            if (chkUser.Succeeded)
            {
                var result1 = UserManager.AddToRole(user.Id, "Administrator");

            }


            // creating Creating Manager role 
            if (!roleManager.RoleExists("Coach"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Coach";
                roleManager.Create(role);

            }

            // creating Creating Employee role 
            if (!roleManager.RoleExists("Player"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Player";
                roleManager.Create(role);

            }



        }

    }
}
