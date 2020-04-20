using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_Sample.Pages.Modul03
{
    public class Calc1Model : PageModel
    {

        public int Ergebnis { get; set; }

        public void OnGet()
        {
            Ergebnis = 0;
        }

        public void OnPost()
        {
            //Ergebnis = int.Parse(Request.Form["eins"].FirstOrDefault()) + int.Parse(Request.Form["zwei"].FirstOrDefault());
            try
            {
                //Die Daten wurden von Browser an WebServer gesendet und werden ausgewertet

                int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
                int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());
                Ergebnis = eins + zwei;
            }
            catch (Exception ex)
            {

            }
        }

    }
}