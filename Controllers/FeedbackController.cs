using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prac7.Models;

namespace prac7.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>()
        {
            new Feedback 
            { 
                EnrollmentNo = "92400120523", 
                StudentName = "Akshar Parekh", 
                Subject = ".NET Technologies", 
                Rating = 5, 
                Comments = "Excellent curriculum with comprehensive practical exposure." 
            }
        };

        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                return RedirectToAction("List");
            }

            return View(feedback);
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}