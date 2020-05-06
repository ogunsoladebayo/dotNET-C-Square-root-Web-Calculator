using Microsoft.AspNetCore.Mvc;
using System;

namespace Task4.Controllers
{
    public class SquareRootController : Controller
    {
        [HttpGet]
        public ActionResult Sqroot()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Sqroot(string firstNumber, string secondNumber)
        {
            // string result = "";
            int FirstNumber = int.Parse(firstNumber);
            int SecondNumber = int.Parse(secondNumber);
            double rootFirstNum = Math.Sqrt(FirstNumber);
            double rootSecondNum = Math.Sqrt(SecondNumber);
            // if(rootFirstNum > rootSecondNum){
            //     string result = ("The number " + FirstNumber + " with Square root " + rootFirstNum + " has a higher square root than the number " + SecondNumber + " with square root " + rootSecondNum);
            //     return result;
            // }
            // if(rootFirstNum < rootSecondNum){
            //     string result = ("The number " + SecondNumber + " with Square root " + rootSecondNum + " has a higher square root than the number " + FirstNumber + " with square root " + rootFirstNum);
            //     return result;
            // }
            ViewBag.firstNum = FirstNumber;
            ViewBag.secondNum = SecondNumber;
            ViewBag.firstRoot = rootFirstNum;
            ViewBag.secondRoot = rootSecondNum;
            return View();
        }

    }
}