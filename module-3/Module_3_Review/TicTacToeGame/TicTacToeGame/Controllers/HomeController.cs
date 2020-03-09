using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionCart.Web.Extensions;
using TicTacToeGame.Models;

namespace TicTacToeGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(UserInfo user)
        {
            return View(user);
        }

        [HttpPost]
        public IActionResult RegisterUser(UserInfo user)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", user);
            }
            HttpContext.Session.Set("User_Info", user);
            HttpContext.Session.Set("Num_Games_Played", 0);
            GameBoardModel board = new GameBoardModel();
            HttpContext.Session.Set("board", board);

            ViewData["name"] = user.Username;

            return View("GameBoard", board);
        }

        [HttpPost]
        public IActionResult MakePlay(int index)
        {
            GameBoardModel board = HttpContext.Session.Get<GameBoardModel>("board");
            if (board ==null)
            {
                board = new GameBoardModel();
            }
            board.Squares[index] = 'X';
            board.ComputerPlay();
            HttpContext.Session.Set("board", board);

            UserInfo info = HttpContext.Session.Get<UserInfo>("User_Info");
            ViewData["name"] = info == null ? "Unknown Player" : info.Username;
            return View("GameBoard", board);
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
