namespace Rando
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.




            ApplicationConfiguration.Initialize();
            Application.Run(new Rando());



        }
        public class Trackpoint
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public double Elevation { get; set; }

            public Trackpoint(double lat, double lon, double ele)
            {
                Latitude = lat;
                Longitude = lon;
                Elevation = ele;
            }
        }

    }
}