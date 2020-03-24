using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using CS481HW5.Model;
using CS481HW5.ViewModel;


namespace CS481HW5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //Map maps;

        public MainPage()
        {
            /* REFERENCES
             * https://docs.microsoft.com/en-us/samples/xamarin/xamarin-forms-samples/userinterface-monkeyapppicker/
             * https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/map/pins
             * https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/map/map
             * https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.picker?view=xamarin-forms
             */
            InitializeComponent();
            BindingContext = new StoresViewModel();

        }
        void OnSatClicked(object button, EventArgs e) //changes map to satellite view
        { HomeMap.MapType = MapType.Satellite; }

        void BacktoStreet(object sender, EventArgs e) //changes map back to street view, because default is street view
        { HomeMap.MapType = MapType.Street; }

        void AddPins(object sender, EventArgs e) //function adds all the pins to the map
        {
            Dictionary<string, Pin> pickerplaces = new Dictionary<string, Pin> //treating pins as a Dictionary of strings in order to access pin locations for picker
           {
                { "Winco", new Pin //declaring pins , relevant bc this is where I go to get food
                    {
                    Type = PinType.Place,
                    Address = "555 Grand Ave, San Marcos, CA 92078, United States",
                    Label = "Winco Foods",
                    Position= new Position (33.135040, -117.176830)}
                    //HomeMap.Pins.Add(Pin)
                },
                {"24 Hour Fitness",new Pin //declaring pins, relevant bc I (used to) love going to the gym
                 {
                    Type = PinType.Place,
                    Address = "641 S Rancho Santa Fe Rd, San Marcos, CA 92069, United States",
                    Label = "24 Hour Fitness",
                    Position = new Position(33.133180, -117.206660)}
                },

                //HomeMap.Pins.Add(pin2);

                { "Mom's House", new Pin //declaring pins, relevant bc my dog is there and so are my parents
                {
                    Type = PinType.Place,
                    Address = "1943 C Ave, National City, CA 91950, United States",
                    Label = "Mom's House",
                    Position = new Position(32.666570, -117.099840) }
                },

                //HomeMap.Pins.Add(pin3);

                { "Self Quarantine aka home", new Pin //declaring pin, relevant bc it's my house
                    { Type = PinType.Place,
                    Address = "353 W San Marcos Blvd, San Marcos, CA 92069, United States",
                    Label = "Self Quarantine aka home",
                    Position = new Position(33.138550, -117.168890) }
                },

                { "Discovery Lake", new Pin //declaring pin, relevant to me bc I (used to) go hiking there a lot
                    { Type = PinType.Place,
                    Address = "3650 Foxhall Dr, San Marcos, CA 92078, United States",
                    Label = "Discovery Lake",
                    Position = new Position(33.126600, -117.177300) }
                },

            };

            foreach (Pin pin in pickerplaces.Values) //adding all pins to the map
            {
                HomeMap.Pins.Add(pin);

            };
            // HomeMap.Pins.Add(pin4)

            Picker.SelectedIndexChanged += (button, args) => //if the selected instance of the picker is changed
            {
                    string location = Picker.Items[Picker.SelectedIndex]; //location is based off of the picker index selected
                    var NewLocation = pickerplaces[location].Position; //the new location of the map will be based on the pin position of the picker index selected
                    HomeMap.MoveToRegion(MapSpan.FromCenterAndRadius(NewLocation, Distance.FromMiles(.50))); //moves to region based on picker
                
            };
        }
    }
}