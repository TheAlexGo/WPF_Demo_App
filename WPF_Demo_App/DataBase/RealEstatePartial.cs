using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Demo_App.DataBase
{
    public partial class RealEstateSet
    {
        public string Info
        {
            get
            {
                return Type + ", " + Address_City + ", " + Address_Street + ", " + Address_House + ", " + Address_Number;
            }
        }

        public string Type
        {
            get
            {
                if(RealEstateSet_Apartment != null)
                {
                    return "Apartment";
                }
                if (RealEstateSet_House != null)
                {
                    return "House";
                }
                if (RealEstateSet_Land != null)
                {
                    return "Land";
                }
                return "Unknown";
            }
        }
    }
}
