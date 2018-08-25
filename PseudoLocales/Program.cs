using System;
using System.Globalization;

namespace PseudoLocales
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            var culture =
                args.Length == 1 ?
                CultureInfo.GetCultureInfo(args[0]) :
                CultureInfo.CurrentUICulture;

            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Console.WriteLine(Strings.Greeting);
            Console.WriteLine(DateTime.UtcNow.ToString("dddd", culture));

            Console.ReadKey();
        }
    }
}
