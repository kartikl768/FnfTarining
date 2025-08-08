//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace SampleConApp
//{
//    internal class ex26ReadingConfig
//    {
//        public static IConfigurationRoot Appconfig { get; set; }
//        static void Main(string[] args)
//        {
//            //var config = new ConfigurationBuilder()
//            //    .SetBasePath(Directory.GetCurrentDirectory())
//            //    .AddJsonFile("appsettings.json", optional: false,
//            //    reloadOnChange: true)
//            //    .Build();
//            //var appname = config["AppSetting:Name"];
//            //var title = config["AppSetting:title"];
//            //Console.WriteLine($"```````````{appname}`````````");
//            //Console.WriteLine($"```````````{title}````````````");
//            //Console.ReadKey();
//            Appconfig = config;// getting error here 

//            // poco class
//            var appsettings = new AppSettings();
//            config.GetSection("AppSettings").Bind( appsettings );
//            Console.WriteLine(appsettings.AppTitle);

//        }
//        class AppSettings
//        {
//            public string AppName { get; set; } = string.Empty;
//            public string AppTitle { get; set; } = string.Empty ;
//        }
//    }
//}


using Microsoft.Extensions.Configuration;
using System;
using System.IO; // Required for Directory.GetCurrentDirectory()

namespace SampleConApp
{
    internal class ex26ReadingConfig
    {
        public static IConfigurationRoot Appconfig { get; set; }

        static void Main(string[] args)
        {
            // Initialize Appconfig by building the configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            Appconfig = config; // Assign the built configuration to the static property

            var appsettings = new AppSettings();
            Appconfig.GetSection("AppSetting").Bind(appsettings); // Ensure "AppSetting" matches your JSON top-level element
            Console.WriteLine($"App Name (POCO): {appsettings.Name}");
            Console.WriteLine($"App Title (POCO): {appsettings.Title}");

            Console.ReadKey();
        }

        class AppSettings
        {
            public string Name { get; set; } = "kartik";  // "Name" matches JSON property
            public string Title { get; set; } = "this is kartik's file"; // "Title" matches JSON property
        }
    }
}



// Create and build the configuration
//var config = new ConfigurationBuilder()
//    .SetBasePath(Directory.GetCurrentDirectory())
//    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//    .Build();

// Assign the built configuration to the static property
//Appconfig = config;

// Example of directly reading values
//var appname = Appconfig["AppSetting:Name"]; // Use Appconfig instead of config
//var title = Appconfig["AppSetting:title"];  // Use Appconfig instead of config
//Console.WriteLine($"Name: {appname}");
//Console.WriteLine($"Title: {title}");

// Poco class binding