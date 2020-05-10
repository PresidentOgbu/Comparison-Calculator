using System;
using Microsoft.AspNetCore.Mvc;

namespace C_TASK4.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Sqrt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sqrt(string firstNumber, string secondNumber)
        {
                try
                {
                    if (Convert.ToInt32(firstNumber) < 0 || Convert.ToInt32(secondNumber) < 0)
                    {
                        string ErrorMessage = "Please Enter A Positive Number!!";

                        ViewBag.ErrorMessageValue = ErrorMessage;
                    }
                    else
                    {
                        int numberOne = int.Parse(firstNumber);
                        int numberTwo = int.Parse(secondNumber);
                        double firstSqrt = Math.Sqrt(numberOne);
                        double secondSqrt = Math.Sqrt(numberTwo);
                        double highSqrt = 0;

                        if (firstSqrt > secondSqrt)
                        {
                            highSqrt = firstSqrt;
                        }
                        else
                        {
                            highSqrt = secondSqrt;
                        }
                        
                        ViewBag.Result = highSqrt;
                        ViewBag.numberOneValue = numberOne;
                        ViewBag.numberTwoValue = numberTwo;
                        ViewBag.firstSqrtValue = firstSqrt;                    
                        ViewBag.secondSqrtValue = secondSqrt;
                    }
                }
                catch (FormatException ex)
                {
                    var exceptionValue = ex.Message;
                    ViewBag.FormatError = "Enter a Number And Try Again ";
                }
                catch (ArgumentNullException ex)
                {
                    var exceptionValueNullException = ex.Message;
                    ViewBag.FormatErrorNullException = "Insert a value And Try Again";
                }
            return View();
            


        }
    }
}

           