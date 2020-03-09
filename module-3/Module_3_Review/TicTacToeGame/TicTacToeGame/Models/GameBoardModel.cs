using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToeGame.Models
{
    public class GameBoardModel
    {

        public char[] Squares { get; set; } = new char[9];

        public GameBoardModel()
        {
            if (Squares==null)
            {
                ClearTheBoard();
            }
        }

        bool AreSpacesLeft()
        {
            if (DetermineWinner !=)
            for (int i=0; i<9; i++)
            {
                if (Squares[i] == '\x0000')
                    return true;
            }
            return false;
        }

        char DetermineWinner()
        {
            if (Squares[0] == Squares[1]&& Squares[1]==Squares[2]) && Squares[0]!= '\x0000')

            {
                return Squares[0];

            }
            if (Squares[3] == Squares[4] && Squares[5] == Squares[2]) && Squares[0] != '\x0000')
        }

        private void ClearTheBoard()
        {
            Squares = new List<char>();
            for (int i=0; i<9; i++)
            {
               
                Squares.Add(' ');
            }
        }

        
        public bool ComputerPlay()
        {
            /*To do: replace with AI*/
            //if them middle is open, pick that
            if (Squares[4]=='\x0000')
            {
                Squares[4] = 'O';

            }
            else
            {
                for (int i=0; i <9; i++)
                {
                    if (Squares[i]== '\x0000')
                    {
                        Squares[i] = 'O';
                        return true;
                    }
                }
            }
            return false;
        }



        //public char UpperLeft { get; set; } = ' ';
        //public char UpperMid { get; set; } = ' ';
        //public char UpperRight { get; set; } = ' ';
        //public char MidLeft { get; set; } = ' ';
        //public char MidMid { get; set; } = ' ';
        //public char MidRight { get; set; } = ' ';
        //public char BottomLeft { get; set; } = ' ';
        //public char BottomMid { get; set; } = ' ';
        //public char BottomRight { get; set; } = ' ';

    }
}
