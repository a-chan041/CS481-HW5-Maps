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
        
    }
}
