using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize] //all below is only accesible to logged in users!
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        { 
            var model = new NoteListItems[0];
            return View(model);
        }
        //Get: Note/Create/////
        //making a request to get the view below!//
        
        public ActionResult Create()
        {
            return View();
        }

        //post: Note/Create//
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if(ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}