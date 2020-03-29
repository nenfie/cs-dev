﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Principal;

namespace SecurityPrincipalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            WindowsPrincipal principal = (WindowsPrincipal)Thread.CurrentPrincipal;
            WindowsIdentity identity = (WindowsIdentity)principal.Identity;

            Console.WriteLine("IdentityType: " + identity.ToString());
            Console.WriteLine("Name: {0}", identity.Name);
            Console.WriteLine("'Users'?: {0}",principal.IsInRole("BUILTIN\\Users"));
            Console.WriteLine("'Administrators'?: {0}",principal.IsInRole(WindowsBuiltInRole.Administrator));
            Console.WriteLine("Authenticated: {0}", identity.IsAuthenticated);
            Console.WriteLine("AuthType: {0}", identity.AuthenticationType);
            Console.WriteLine("Anonymous?: {0}", identity.IsAnonymous);
            Console.WriteLine("Token: {0}", identity.Token);

            Console.ReadLine();
        }
    }
}
