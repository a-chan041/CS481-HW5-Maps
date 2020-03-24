using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;


namespace CS481HW5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //Map maps;

        public MainPage () {

            /*maps = new Map();
            Content = maps; */
            InitializeComponent();

            //Position position = new Position(33.1392, -117.1695);
            //MapSpan mapSpan = new MapSpan(position, 3.0, 3.0);
            //maps = new MapSpan(mapSpan);
        }

        

        void OnSatClicked(object sender, EventArgs e) //changes map to satellite view
        { HomeMap.MapType = MapType.Satellite; }

        void BacktoStreet (object sender, EventArgs e) //changes map back to street view, bc default is street view
        { HomeMap.MapType = MapType.Street; }

        void AddPins(object sender, EventArgs e) //function adds all the pins to the map
        {
            Pin pin = new Pin //declaring pins 
            {
                Type = PinType.Place,
                Address = "555 Grand Ave, San Marcos, CA 92078, United States",
                Label = "Winco Foods",
                Position= new Position (33.135040, -117.176830)
            };

            HomeMap.Pins.Add(pin);

            Pin pin2 = new Pin //declaring pins
            {
                Type = PinType.Place,
                Address = "641 S Rancho Santa Fe Rd, San Marcos, CA 92069, United States",
                Label = "24 Hour Fitness",
                Position = new Position(33.133180, -117.206660)
            };

            HomeMap.Pins.Add(pin2);

            Pin pin3 = new Pin //declaring pins
            {
                Type = PinType.Place,
                Address = "1943 C Ave, National City, CA 91950, United States",
                Label = "Mom's House",
                Position = new Position(32.666570, -117.099840)
            };

            HomeMap.Pins.Add(pin3);

            Pin pin4 = new Pin //declaring pins
            {
                Type = PinType.Place,
                Address = "353 W San Marcos Blvd, San Marcos, CA 92069, United States",
                Label = "Self Quarantine",
                Position = new Position(33.138550, -117.168890)
            };

            HomeMap.Pins.Add(pin4);
        }




    }
}
