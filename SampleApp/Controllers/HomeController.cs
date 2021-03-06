using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using SampleApp.Data;

namespace SampleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IConfiguration Configg;
        private ApplicationDbContext Context;

        public HomeController(ILogger<HomeController> logger,IConfiguration Conff, ApplicationDbContext Contextt)
        {
            _logger = logger;
            Configg = Conff;
            Context = Contextt;
        }

        public IActionResult Index()
        {
            ForUser sa = new() { UserName="saa",Password="saa"};
            Context.UserDetails.Add(sa);
            return View();
        }
        //[HttpPost]
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public string sa()
        {
            SqlConnection Con = new SqlConnection(Configg.GetConnectionString("MyConnection"));
            string hh = "create table UserDetails (ID int primary key identity(1,1),Name varchar(250) null,Pass varchar(250) null)";
            Con.Open();
            SqlCommand cmd = new SqlCommand(hh,Con);
            cmd.ExecuteNonQuery();
            
            return "succ";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
