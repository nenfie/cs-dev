using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Principal;
using System.Security.Permissions;

namespace SecurityPrincipalPermissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

            try
            {
                ShowMessage();
            }
            catch (SecurityException exception)
            {
                Console.WriteLine("Security exception caught (" + exception.Message + ")");
                Console.WriteLine("The current principal must be in local Users group");
            }

            Console.ReadLine();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "BUILTIN\\Users")]
        static void ShowMessage()
        {
            Console.WriteLine("The current principal is logged in locally ");
            Console.WriteLine("(member of the local Users group)");
        }
    }
}
