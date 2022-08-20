using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using U19032618_HW04.Models;


namespace U19032618_HW04.Controllers
{
    public class HomeController : Controller
    {
        //declare birthcertificate list
        public static List<Birthdata> BCertificateList = new List<Birthdata>();
        //declare ID list
        public static List<IDdata> IDcardList = new List<IDdata>();
        //declare Education list
        public static List<Educationdata> EdList = new List<Educationdata>();
        //declare all aplicants list
        public static List<AllApplicants> ApplicantDB = new List<AllApplicants>();


        public ActionResult Index()
        {
            string path = "~/Content/Images/Usecases";
            List<string> Images = new List<string>();
            var ImageDirectory = Directory.EnumerateFiles(Server.MapPath(path)).Select(img => path + "/" + Path.GetFileName(img)).ToList();  
            for(var i =0; i < ImageDirectory.Count(); i++ )
            {
                Images.Add(ImageDirectory[i]);
            }
            return View(Images);
        }

        [HttpGet]
        public ActionResult BirthCertificate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BirthCertificate(Birthdata Birthform)
        {
            //Add form data to list 
            BCertificateList.Add(Birthform);

            //Viewbag to show notification
            ViewBag.Message = "Form Submitted! A consultant will contact you in 2-3 business days";
            return View();

        }

        public ActionResult Education(Educationdata Educationform)
        {
            //Add form data to list 
            EdList.Add(Educationform);

            //Viewbag to show notification
            ViewBag.Message = "Form Submitted! A consultant will contact you in 2-3 business days";
            return View();
        }
        public ActionResult IDregistration(IDdata IDfrom)
        {
            //Add form data to list 
            IDcardList.Add(IDfrom);

            //Viewbag to show notification
            ViewBag.Message = "Form Submitted! A consultant will contact you in 2-3 business days";
            return View();
        }

        //Display applicants on page 
        public ActionResult Applicants()
        {
                if (ApplicantDB.Count() == 0)
                {
                    ViewBag.Message = "There are no current Applicants";
                    return View();
                }
                else
                {
                    ApplicantDB.Clear();
                    ApplicantDB.AddRange(BCertificateList);
                    ApplicantDB.AddRange(IDcardList);
                    ApplicantDB.AddRange(EdList);
                    return View(ApplicantDB);
                }

            
        }


    }
}