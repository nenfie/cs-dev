using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // TRY : Execute Code
            try
            {
                int a = 3;
                int b = 0;
                int c = a / b;
            }

            // CATCH : Handle Error
            catch (Exception er)
            {
                Console.WriteLine("Error : " + er.Message);
            }

            // FINALLY : Finish Code Execution
            finally
            {
                Console.WriteLine("Program selesai");
            }

            Console.ReadLine();

        }
    }
}
