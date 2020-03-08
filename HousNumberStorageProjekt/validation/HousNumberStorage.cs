using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousNumberStorageProjekt.validation
{
    class HousNumberStorage
    {
        //házszám: legfeljebb háromjegyű pozitív szám amit egy pont zár le
        //hibás házszámok: "", "12","a.", "9999."
        //jó házszámok: "9.", "12.","123."


        private string housnumber;

        public HousNumberStorage(string housnumber)
        {
            this.housnumber = housnumber;
        }

        public bool isValid()
        {
            return true;
        }
    }
}
