using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousNumberStorageProjekt.validation
{
    class HouseNumberStorage
    {
        //házszám: legfeljebb háromjegyű pozitív szám amit egy pont zár le
        //hibás házszámok: "", "12","a.", "9999."
        //jó házszámok: "9.", "12.","123."


        private string housenumber;

        public HouseNumberStorage(string housenumber)
        {
            this.housenumber = housenumber;
        }

        public bool isValid()
        {
            return true;
        }
    }
}
