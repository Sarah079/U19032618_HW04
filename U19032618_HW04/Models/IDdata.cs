using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U19032618_HW04.Models
{
    public class IDdata: AllApplicants
    {
        public string _IDdescription;


        public IDdata()
        {

        }

        public IDdata(int ID, string FName, string LName, int Contactcell, string ContactEmail, string IDdescription) : base(ID, FName, LName, Contactcell, ContactEmail)
        {
            _IDdescription = IDdescription;
        }

        public override string ApplicationDetails()
        {
            return this._IDdescription;
        }

        public string IDdescription { get { return _IDdescription; } set { _IDdescription = value; } }
    }
}