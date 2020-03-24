using System;
using CS481HW5.Model;
using System.Collections.Generic;
using Xamarin.Forms.Maps;

namespace CS481HW5.ViewModel
{
    public class StoresViewModel
    {
        public IList<Places> Store { get; set; }

        public StoresViewModel()
        {
            Store = new List<Places>(); //list for picker

            Store.Add(new Places
            { 
                Name = "Winco",
                Location = "555 Grand Ave, San Marcos, CA 92078, United States"

            });

            Store.Add(new Places
            {
                Name = "24 Hour Fitness",
                Location = "641 S Rancho Santa Fe Rd, San Marcos, CA 92069, United States"

            });

            Store.Add(new Places
            {
                Name = "Mom's House",
                Location = "641 S Rancho Santa Fe Rd, San Marcos, CA 92069, United States",
                //maps= new Position (32.666570, -117.099840),

            });

            Store.Add(new Places
            {
                Name = "Self Quarantine aka home",
                Location = "353 W San Marcos Blvd, San Marcos, CA 92069, United States",
                //maps= new Position (32.666570, -117.099840),

            });

            Store.Add(new Places
            {
                Name = "Discovery Lake",
                Location = "3650 Foxhall Dr, San Marcos, CA 92078, United States",
                //maps= new Position (32.666570, -117.099840),

            });

        }
    }
}
