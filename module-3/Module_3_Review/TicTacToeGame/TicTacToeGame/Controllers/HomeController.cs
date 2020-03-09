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

<<<<<<< HEAD
        public IActionResult Index(UserInfo user)
        {
            return View(user);
=======
        public IActionResult Index()
        {
            return View();
>>>>>>> 27326b891d53b28be8e0d3e9b3e9262dcda7dac7
        }

        [HttpPost]
        public IActionResult RegisterUser(UserInfo user)
        {
            if (!ModelState.IsValid)
            {
<<<<<<< HEAD
                return View("Index", user);
            }
            HttpContext.Session.Set("User_Info", user);
            HttpContext.Session.Set("Num_Games_Played", 0);
            GameBoardModel board = new GameBoardModel();
            HttpContext.Session.Set("board", board);

            ViewData["name"] = user.Username;

            return View("GameBoard", board);
=======
                return View("Index");
            }
            HttpContext.Session.Set("User_Info", user);
            HttpContext.Session.Set("Num_Games_Played", 0);
            TicTacToeBoard board = new TicTacToeBoard();
            HttpContext.Session.Set("board", board);

            ViewData["name"] = user.UserName;

            return View("GameBoard",board);
>>>>>>> 27326b891d53b28be8e0d3e9b3e9262dcda7dac7
        }

        [HttpPost]
        public IActionResult MakePlay(int index)
        {
<<<<<<< HEAD
            GameBoardModel board = HttpContext.Session.Get<GameBoardModel>("board");
            if (board ==null)
            {
                board = new GameBoardModel();
=======
            TicTacToeBoard board = HttpContext.Session.Get<TicTacToeBoard>("board"); 
            if (board==null)
            {
                board = new TicTacToeBoard();
>>>>>>> 27326b891d53b28be8e0d3e9b3e9262dcda7dac7
            }
            board.Squares[index] = 'X';
            board.ComputerPlay();
            HttpContext.Session.Set("board", board);

            UserInfo info = HttpContext.Session.Get<UserInfo>("User_Info");
<<<<<<< HEAD
            ViewData["name"] = info == null ? "Unknown Player" : info.Username;
            return View("GameBoard", board);
        }
=======
            ViewData["name"] = info == null ? "Unknown Player" : info.UserName;

            return View("GameBoard", board);
        }
       
        //TO DO - add GameBaord and then always redirect to action
        //check in there if there's a winner or if the game is over
>>>>>>> 27326b891d53b28be8e0d3e9b3e9262dcda7dac7

        public IActionResult Privacy()
        {
            return View();
        }
<<<<<<< HEAD
=======
        
>>>>>>> 27326b891d53b28be8e0d3e9b3e9262dcda7dac7

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
