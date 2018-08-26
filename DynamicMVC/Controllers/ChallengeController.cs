using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DynamicMVC.Models;
namespace DynamicMVC.Controllers
{
    public class ChallengeController : Controller
    {
        public async Task<IActionResult> One(bool id)
        {
            if (id)
            {
                Guid guid = new Guid();
                guid = Guid.NewGuid();
                ChallengeOneModel model = new ChallengeOneModel() { Str = $"This came from the server! {guid.ToString()}" };
                return View(model);
            }
            return View();
        }
        public async Task<IActionResult> Two(ChallengeTwoModel model)
        {
            if(model == null || model.Str == null)
            {
                model = new ChallengeTwoModel() { Str = "This Is A Test." };
            }
            else
            {

            }

            return View(model);
        }
        public async Task<IActionResult> Three()
        {
            return View();
        }
        public async Task<IActionResult> Four()
        {
            return View();
        }
        public async Task<IActionResult> Five()
        {
            return View();
        }
    }
}