using Microsoft.AspNetCore.Mvc;
using System;

namespace MathProgramm.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(string left, string right)
        {
            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int sum = leftop + rightop;

            ViewData["Message"] = $"{left} plus {right} equals {sum}";


            return View();

        }

        public IActionResult Subtract(string left, string right)
        {
            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int sum = leftop - rightop;

            ViewData["Message"] = $"{left} minus {right} equals {sum}";


            return View();

        }

        public IActionResult Division(string left, string right)
        {
            decimal leftop = Convert.ToInt32(left);
            decimal rightop = Convert.ToInt32(right);
            decimal sum = leftop / rightop;

            if (rightop == 0 || leftop == 0)
            {
                ViewData["Message"] = @"You cannot divide by zero";
            }
            else
            {
                ViewData["Message"] = $"{left} divided by {right} equals {sum}";
            }

            return View();

        }

        public IActionResult Multiply(string left, string right)
        {
            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int sum = leftop - rightop;

            ViewData["Message"] = $"{left} minus {right} equals {sum}";


            return View();

        }

        public IActionResult Modulus(string left, string right)
        {
            decimal leftop = Convert.ToInt32(left);
            decimal rightop = Convert.ToInt32(right);
            decimal sum = leftop % rightop;

            if (rightop == 0 || leftop == 0)
            {
                ViewData["Message"] = @"You cannot divide by zero";
            }
            else
            {
                ViewData["Message"] = $"{left} divided by {right} equals {sum}";
            }

            return View();

        }

        

    }
}