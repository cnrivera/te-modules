using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    public class UserInfo
    {
<<<<<<< HEAD
        public string Username { get; set; }

        [Range(1, 5)]
        public int NumberOfRounds { get; set; }

        public int NumberOfWins { get; set; }





=======
        public string UserName { get; set; }

        [Range(1,5) ]
        public int NumberOfRounds { get; set; }

        public int NumWins { get; set; }
>>>>>>> 27326b891d53b28be8e0d3e9b3e9262dcda7dac7
    }
}
