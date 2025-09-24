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
                    (double)x.Attribute("lon"), // xattribute va chercher les attributs qui sont dans le <trkpt>, donc "lon" et "lat"
                    (double)x.Element(ns + "ele") // xelement va chercher l'élément enfant qui se trouve aussi dans <trkpt> mais, celui là est le "ele"
                )).ToList();
        } //regarder la doc sur https://weblogs.asp.net/jimjackson/using-linq-to-xml-with-c-to-read-gpx-files/

        public Rando()
        {
            InitializeComponent();
            // emplacement du fichier gpx
            trackpoints = ReadGpx("../../../../../../gpx/gemmikandersteg.gpx");

            foreach(Trackpoint trackpoint in trackpoints)
            {
                Debug.WriteLine(trackpoint);
            }
        }

        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            Point[] points = new Point[4] { new Point(30,50), new Point(50,10), new Point(80,50), new Point(111,400) };
            this.CreateGraphics().DrawLines(myPen, points);
        }
    }
}
