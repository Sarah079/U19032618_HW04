using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U19032618_HW04.Models
{
    public class Educationdata : AllApplicants
    {
        public string _Educationdescription;


        public Educationdata()
        {

        }

        public Educationdata(int ID, string FName, string LName, int Contactcell, string ContactEmail, string Educationdescription) : base(ID, FName, LName, Contactcell, ContactEmail)
        {
            _Educationdescription = Educationdescription;
        }

        public override string ApplicationDetails()
        {
            return this._Educationdescription;
        }

        public string Educationdescription { get { return _Educationdescription; } set { _Educationdescription = value; } }
    }
}