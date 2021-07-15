using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLogic
{
    public class GameBoard
    {
        private readonly char[,] r_Board = null;
        private const char k_EmptyCell = '0';
        private int m_NumberOfEmptyCells;
        private readonly List<Position> r_EmptyCellsPositions;

        public GameBoard(int i_BoardSize)
        {
            r_Board = new char[i_BoardSize, i_BoardSize];
            r_EmptyCellsPositions = new List<Position>();
            MakeEmptyBoard();
        }

        public void MakeEmptyBoard()
        {
            r_EmptyCellsPositions.RemoveRange(0, r_EmptyCellsPositions.Count);
            for (int i = 0; i < r_Board.GetLength(0); i++)
            {
                for (int j = 0; j < r_Board.GetLength(1); j++)
                {
                    r_Board[i, j] = k_EmptyCell;
                    r_EmptyCellsPositions.Add(new Position(i, j));
                }
            }

            m_NumberOfEmptyCells = r_Board.GetLength(0) * r_Board.GetLength(1);
        }

        public eGameResult CurrentGameResult(ref Position io_LastMove)
        {
            eGameResult gameResult;

            if (IsWinner(ref io_LastMove))
            {
                gameResult = eGameResult.Win;
            }
            else if (IsTie(ref io_LastMove))
            {
                gameResult = eGameResult.Tie;
            }
            else
            {
                gameResult = eGameResult.NotOver;
            }

            return gameResult;
        }

        public bool IsTie(ref Position io_LastMove)
        {
            bool isTie = !IsWinner(ref io_LastMove) && IsFullBoard();

            return isTie;
        }

        public bool IsFullBoard()
        {
            return m_NumberOfEmptyCells == 0;
        }

        public bool IsWinner(ref Position io_LastMove)
        {
            bool isWin = IsWinnerByLine(io_LastMove.Row) || IsWinnerByColumn(io_LastMove.Column);

            if (!isWin)
            {
                isWin = IsWinnerByLeftDiagonal() || IsWinnerByRightDiagonal();
            }

            return isWin;
        }

        public bool IsWinnerByRightDiagonal()
        {
            char rightDiagonalSign = r_Board[0, 0];
            bool isWin = true;

            if (rightDiagonalSign != k_EmptyCell)
            {
                for (int i = 0; i < r_Board.GetLength(0); i++)
                {
                    if (r_Board[i, i] != rightDiagonalSign)
                    {
                        isWin = false;
                        break;
                    }
                }
            }
            else
            {
                isWin = false;
            }

            return isWin;
        }

        public bool IsWinnerByLeftDiagonal()
        {
            char leftDiagonalSign = r_Board[0, r_Board.GetLength(1) - 1];
            bool isWin = true;

            if (leftDiagonalSign != k_EmptyCell)
            {
                for (int i = 0; i < r_Board.GetLength(0); i++)
                {
                    if (r_Board[i, r_Board.GetLength(1) - 1 - i] != leftDiagonalSign)
                    {
                        isWin = false;
                        break;
                    }
                }
            }
            else
            {
                isWin = false;
            }

            return isWin;
        }

        public bool IsWinnerByLine(int i_Line)
        {
            char sign = r_Board[i_Line, 0];
            bool isWin = true;

            if (sign != k_EmptyCell)
            {
                for (int i = 0; i < r_Board.GetLength(1); i++)
                {
                    if (r_Board[i_Line, i] != sign)
                    {
                        isWin = false;
                        break;
                    }
                }
            }
            else
            {
                isWin = false;
            }

            return isWin;
        }

        public bool IsWinnerByColumn(int i_Column)
        {
            char sign = r_Board[0, i_Column];
            bool isWin = true;

            if (sign != k_EmptyCell)
            {
                for (int i = 0; i < r_Board.GetLength(0); i++)
                {
                    if (r_Board[i, i_Column] != sign)
                    {
                        isWin = false;
                        break;
                    }
                }
            }
            else
            {
                isWin = false;
            }

            return isWin;
        }

        public char[,] Board
        {
            get
            {
                return r_Board;
            }
        }

        public char EmptyCell
        {
            get
            {
                return k_EmptyCell;
            }
        }

        public char this[int i_RowIdx, int i_ColumnIdx]
        {
            get
            {
                return r_Board[i_RowIdx, i_ColumnIdx];
            }

            set
            {
                if (r_Board[i_RowIdx, i_ColumnIdx] == k_EmptyCell)
                {
                    m_NumberOfEmptyCells--;
                    r_EmptyCellsPositions.Remove(ToDeleteFromEmptyPositions(i_RowIdx, i_ColumnIdx));
                }

                r_Board[i_RowIdx, i_ColumnIdx] = value;
            }
        }

        public Position ToDeleteFromEmptyPositions(int i_RowIdx, int i_ColumnIdx)
        {
            Position posToDelete = new Position();
            foreach (Position pos in r_EmptyCellsPositions)
            {
                if (pos.Row == i_RowIdx && pos.Column == i_ColumnIdx)
                {
                    posToDelete = pos;
                }
            }

            return posToDelete;
        }

        public List<Position> EmptyCellsPositions
        {
            get
            {
                return r_EmptyCellsPositions;
            }
        }

        public bool IsInRange(int i_RowIdx, int i_ColumnIdx)
        {
            return (i_RowIdx >= 0 && i_RowIdx < r_Board.GetLength(0) && i_ColumnIdx >= 0 && i_ColumnIdx < r_Board.GetLength(1));
        }

        public struct Position
        {
            private int m_Row;
            private int m_Column;

            public Position(int i_Row, int i_Column)
            {
                m_Row = i_Row;
                m_Column = i_Column;
            }

            public int Row
            {
                get
                {
                    return m_Row;
                }

                set
                {
                    m_Row = value;
                }
            }

            public int Column
            {
                get
                {
                    return m_Column;
                }

                set
                {
                    m_Column = value;
                }
            }
        }

        public enum eGameResult
        {
            NotOver,
            Win,
            Tie,
        }
    }
}
