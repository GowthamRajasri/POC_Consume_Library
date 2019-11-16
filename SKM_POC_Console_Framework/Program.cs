using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM_POC_Console_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            MakeNetworkCall();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        async static void MakeNetworkCall()
        {
            try
            {
                setLableMgs("Framework Library Call:");
                SKM_POC_Framework_Library.Program p1 = new SKM_POC_Framework_Library.Program();
                setLableMgs(await p1.MakeHttpCall());
            }
            catch (Exception ex)
            {
                setLableMgs(ex.Message + Environment.NewLine + ex.StackTrace);
            }

            try
            {
                setLableMgs("Standard Library Call:");
                SKM_POC_Standard_Library.Program p2 = new SKM_POC_Standard_Library.Program();
                setLableMgs(await p2.MakeHttpCall());
            }
            catch (Exception ex)
            {
                setLableMgs(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        static void setLableMgs(string mgs)
        {
            Console.WriteLine($"{DateTime.Now.ToString()} : {mgs}");
            Console.WriteLine();
        }
    }
}
