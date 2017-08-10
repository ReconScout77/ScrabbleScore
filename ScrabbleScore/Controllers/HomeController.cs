
using Microsoft.AspNetCore.Mvc;
using ScrabbleScore.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScore.Controllers
{
  public class HomeController : Controller
  {

     [HttpGet("/")]
     public ActionResult Index()
     {
       return View();
     }

     [HttpPost("/scrabbleScore")]
     public ActionResult GetScrabbleScore()
     {
       string userWord = Request.Form["userWord"];
       Scrabble scrabble = new Scrabble(userWord);
       return View(scrabble);
     }

    // [HttpPost("/find")]
    //  public ActionResult Find()
    //  {
    //     string find = Request.Form["find"];
    //     findReplace = new FindReplace(find, "");
    //     return View(findReplace);
    //  }


    //  [HttpPost("/replace")]
    //  public ActionResult FindReplace()
    //  {
    //    string replace = Request.Form["replace"];
       
    //    findReplace.SetToBeReplace(replace);
    //    return View(findReplace);
    //  }

    //  public new void Dispose()
    //  {
    //    findReplace.ClearArticleWordList();
    //  }
  }
}