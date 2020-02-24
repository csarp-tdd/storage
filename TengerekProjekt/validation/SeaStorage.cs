using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TengerekProjekt.validation
{
    class SeaStorage
    {
        //Hibát dobó eset: ""
        //Jó tesztesetek: Bering-tenger, Karib-tenger (tengerre végződik), Aral-tó (beltenger), Nagy-sóstó, Mexikói-öböl, Nagy-Ausztráliai-öböl
        //Hibát dobó esetek: adriai-tenger, Adriai tenger, Adriai-folyó
        private string seaName;

        public bool isValid()
        {
            if (isEmpty())
                throw
            if (!isFirstLetterUperCase())
                throw


            return true;
        }


    }
}
