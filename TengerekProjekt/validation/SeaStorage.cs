using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TengerekProjekt.validation
{
    class SeaStorage
    {
        //Jó tesztesetek: Bering-tenger, Karib-tenger, Aral-tó (beltenger), Nagy-sóstó, Mexikói-öböl, Nagy-Ausztráliai-öböl
        //Hibát dobó esetek: adriai-tenger, Adriai tenger, Adriai-folyó
        private string seaName;

        public bool isValid()
        {
            if (!isFirstLetterUperCase())
            {
                throw 
            }

            return true;
        }


    }
}
