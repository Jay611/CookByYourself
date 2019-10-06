using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CookByYourself.Models;

namespace CookByYourself.Controllers
{
    public class RecipeController : Controller
    {
        public ViewResult Home() => View();

        public ViewResult DisplayPage() => View();

        public ViewResult DataPage() => View();

        public ViewResult InsertPage() => View();

        public ViewResult UserPage() => View();
    }
    
}