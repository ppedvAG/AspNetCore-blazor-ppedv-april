using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_Razor_WithMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_Razor_WithMVC.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowList ()
        {
            ToDo aufgabe1 = new ToDo();
            aufgabe1.Title = "Gassi gehen";
            aufgabe1.Beschreibung = "Bitte gehe eine Stunde mit dem Hund raus";
            aufgabe1.BisWann = DateTime.Now;
            aufgabe1.IstAktiv = false;

            ToDo aufgabe2 = new ToDo();
            aufgabe2.Title = "Essen kochen";
            aufgabe2.Beschreibung = "Bitte nur vegetarisch";
            aufgabe2.BisWann = DateTime.Now;
            aufgabe2.IstAktiv = true;

            ToDo aufgabe3 = new ToDo();
            aufgabe3.Title = "Programmieren";
            aufgabe3.Beschreibung = "Bug behebeb";
            aufgabe3.BisWann = DateTime.Now;
            aufgabe3.IstAktiv = true;

            IList<ToDo> aufgabenListe = new List<ToDo>();
            aufgabenListe.Add(aufgabe1);
            aufgabenListe.Add(aufgabe2);
            aufgabenListe.Add(aufgabe3);


            return View(aufgabenListe);
        }

        public IActionResult ShowToDoWithRazor()
        {
            ToDo aufgabe1 = new ToDo();
            aufgabe1.Title = "Gassi gehen";
            aufgabe1.Beschreibung = "Bitte gehe eine Stunde mit dem Hund raus";
            aufgabe1.BisWann = DateTime.Now;
            aufgabe1.IstAktiv = false;

            return View(aufgabe1);
        }
    }
}