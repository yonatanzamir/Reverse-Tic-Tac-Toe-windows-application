using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLogic
{
    public class Player
    {
        private int m_NumberOfWins;
        private readonly ePlayerType r_PlayerType;
        private readonly char r_SignInGame;
        private string m_PlayerName;
        private static readonly Random sr_RandomComputerStep=new Random();

        public Player(ePlayerType i_Player, char i_Sign, string i_PlayerName = "Computer")
        {
            m_NumberOfWins = 0;
            r_PlayerType = i_Player;
            r_SignInGame = i_Sign;
            m_PlayerName = i_PlayerName;
        }
        
        public GameBoard.Position MakeComputerMove(GameBoard i_Board)
        {
            int copmuterChoice = sr_RandomComputerStep.Next(i_Board.EmptyCellsPositions.Count);
            GameBoard.Position playerCurrentMove = i_Board.EmptyCellsPositions[copmuterChoice];

            return playerCurrentMove;
        }

        public char Sign
        {
            get
            {
                return r_SignInGame;
            }
        }

        public int NumberOfWins
        {
            get
            {
                return m_NumberOfWins;
            }

            set
            {
                m_NumberOfWins = value;
            }
        }

        public string PlayerName
        {
            get
            {
                return m_PlayerName;
            }

            set
            {
                m_PlayerName = value;
            }
        }

        public ePlayerType PlayerType
        {
            get
            {
                return r_PlayerType;
            }
        }

        public enum ePlayerType
        {
            HumanPlayer,
            Computer
        }
    }
}
