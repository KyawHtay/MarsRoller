using MarsRoverTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MarsRoverTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalculateMove(FormCollection form)
        {
            try
            {
                Directions dir = (Directions)Enum.Parse(typeof(Directions), form["txtDirection"].ToString(), true);
                Position position = new Position()
                {
                    X = Convert.ToInt32(form["txtX"].ToString()),
                    Y = 2,
                    Direction = dir
                };

                var maxPoints = new List<int>() { 5, 5 };
                var moves = form["txtMove"].ToString();

                position.StartMoving(maxPoints, moves);
                StringBuilder sbText = new StringBuilder();
                sbText.Append("<b>Position X:</b>" + position.X + "</br>");
                sbText.Append("<b>Position Y:</b>" + position.Y + "</br>");
                sbText.Append("<b>Direction:</b>" + position.Direction.ToString() + "</br>");
                return Content(sbText.ToString());
            }
            catch
            {

                return Content("<b>check your input data</b>");
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}