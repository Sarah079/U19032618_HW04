using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U19032618_HW04.Models
{
    public class Birthdata:AllApplicants 
    {

        public string _Birthdescription;


        public Birthdata()
        {

        }

        public Birthdata(int ID, string FName, string LName, int Contactcell, string ContactEmail,string Birthdescription) : base(ID,FName,LName,Contactcell,ContactEmail  )
        {
            _Birthdescription = Birthdescription;
        }

        public override string ApplicationDetails()
        {
            return this._Birthdescription;
        }

        public string Birthdescription { get { return _Birthdescription; } set { _Birthdescription = value; } }


    }
}