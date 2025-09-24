using System.Xml.Linq;
using System.Globalization;
using System.Diagnostics;

namespace Rando
{
    public partial class Rando : Form
    {
        private List<Trackpoint> trackpoints;

        private List<Trackpoint> ReadGpx(string path)
        {
            //le namespace utilisé qui se trouve aussi dans le fichier gpx
            XNamespace ns = "http://www.topografix.com/GPX/1/1";
            //Xdocument est une classe qui represente un document XML (system.xml.linq)
            return XDocument.Load(path)
                .Descendants(ns + "trkpt") //descendant va retourner une collection filtré avec la balise "trkpt" qui se trouve dans les fichiers gpx
                .Select(x => new Trackpoint(
                    (double)x.Attribute("lat"), // le (double) est une conversion explicite que nous pouvons faire avec LinQ à XML (xattribute, xelement)
                    (double)x.Attribute("lon"),// xattribute va chercher les attributs qui sont dans le <trkpt>, donc "lon" et "lat"
                    (double)x.Element(ns + "ele") // xelement va chercher l'élément enfant qui se trouve aussi dans <trkpt> mais, celui là est le "ele"
                )).ToList();
        } //regarder la doc sur https://weblogs.asp.net/jimjackson/using-linq-to-xml-with-c-to-read-gpx-files/

        public Rando()
        {
            InitializeComponent();
        }

        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            // emplacement du fichier gpx
            trackpoints = ReadGpx("../../../../../../gpx/gemmikandersteg.gpx");

            List<Point> filteredTrackpoints = trackpoints.Select(trackpoint => new Point((int)((trackpoint.Latitude-46.39)*6500), (int)((trackpoint.Longitude-7.61)*6500))).ToList();

            foreach (Point point in filteredTrackpoints)
            {
                Debug.WriteLine(point.ToString());
            }
            // dessiner
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;
            Point[] filteredPoints = filteredTrackpoints.ToArray();
            this.CreateGraphics().DrawLines(myPen, filteredPoints);
        }
    }
}
