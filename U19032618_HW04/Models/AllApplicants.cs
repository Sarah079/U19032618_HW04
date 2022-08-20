using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U19032618_HW04.Models
{
    public abstract class AllApplicants
    {

        //Data Members
        public int _ID;
        public string _FName;
        public string _LName;
        public int _Contactcell;
        public string _ContactEmail;


        //Default Constructors
        public AllApplicants() //Parameterless constructor
        {

        }

        public AllApplicants(int ID, string FName, string LName, int Contactcell, string ContactEmail)
        {
            _ID = ID;
            _FName = FName;
            _LName = LName;
            _Contactcell = Contactcell;
            _ContactEmail = ContactEmail;
        }

        //Methods

        public virtual void WritingToConsole()
        {
            //Write this in a seperate text file
            Console.WriteLine(ID);
        }

        public abstract string ApplicationDetails();


        //Properties

        public int ID { get {  return _ID; } set { _ID = value; } }
        public string FName { get { return _FName; } set {  _FName = value; } }
        public string LName { get { return _LName; } set { _LName = value; } }
        public int Contactcell { get { return _Contactcell; } set { _Contactcell = value; } }
        public string ContactEmail { get { return _ContactEmail; } set { _ContactEmail = value; } }

    }
}