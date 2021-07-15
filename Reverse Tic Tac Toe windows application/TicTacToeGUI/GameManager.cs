using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLogic;


namespace TicTacToeGUI
{
    public class GameManager
    {
        private Player m_Player1;
        private Player m_Player2;
        private GameBoard m_GameMap;
        private Player m_CurrentPlayer;
        private FormGameSettings m_FormGameSettings;
        private FormTicTacToe m_GameForm;
        private const char k_Player1Sign='X';
        private const char k_Player2Sign = 'O';

        public GameManager()
        {
            if (runFormGameSettings() == true)
            {
                runFormTicTacToe();
            }
        }

        private void runFormTicTacToe()
        {
            m_GameForm = new FormTicTacToe(m_FormGameSettings.RowssSize, this);
            m_GameForm.ShowDialog();
        }

        private bool runFormGameSettings()
        {
            m_FormGameSettings = new FormGameSettings();
            m_FormGameSettings.ShowDialog();
            bool isStartGame = false;
            if (m_FormGameSettings.DialogResult == DialogResult.OK)
            {
                initializeGameDetails();
                isStartGame = true;
            }

            return isStartGame;
        }

        private void initializeGameDetails()
        {
            m_Player1 = new Player(Player.ePlayerType.HumanPlayer, k_Player1Sign, m_FormGameSettings.Player1Name);
            if (m_FormGameSettings.IsPlayerComputer)
            {
                m_Player2 = new Player(Player.ePlayerType.Computer, k_Player2Sign);
            }
            else
            {
                m_Player2 = new Player(Player.ePlayerType.HumanPlayer, k_Player2Sign, m_FormGameSettings.Player2Name);
            }

            m_GameMap = new GameBoard(m_FormGameSettings.RowssSize); // assuming that board dimension is square (n*n)
            m_CurrentPlayer = m_Player1;
        }

        internal void CellButton_Click(object sender, EventArgs e)
        {
            CellButton theSender = sender as CellButton;
            updateMove(theSender, theSender.ButtonPosition.Row, theSender.ButtonPosition.Column);
        }

        private void updateResult(GameBoard.Position i_LastMove)
        {
            GameBoard.eGameResult currentGameResult = m_GameMap.CurrentGameResult(ref i_LastMove);
            if (currentGameResult == GameBoard.eGameResult.Win)
            {
                Player winningPlayer;
                if (m_CurrentPlayer == m_Player1)
                {
                    winningPlayer = m_Player2;
                    m_Player2.NumberOfWins++;
                    //m_GameForm.LabelPlayer2Score.Text = m_Player2.NumberOfWins.ToString();
                }
                else
                {
                    winningPlayer = m_Player1;
                    m_Player1.NumberOfWins++;
                    //m_GameForm.LabelPlayer1Score.Text = m_Player1.NumberOfWins.ToString();
                }

                showWinMessageBox(winningPlayer);
                m_CurrentPlayer = m_Player1;
            }
            else if (currentGameResult == GameBoard.eGameResult.Tie)
            {
                showTieMessageBox();
                m_CurrentPlayer = m_Player1;
            }
            else
            {
                switchTurns();
            }
        }

        private void switchTurns()
        {
            if (m_CurrentPlayer == m_Player1)
            {
                m_CurrentPlayer = m_Player2;
                if (m_Player1.PlayerType != Player.ePlayerType.Computer && m_Player2.PlayerType != Player.ePlayerType.Computer)
                {
                    m_GameForm.MakeCurrentPlayerLabelBold(m_GameForm.LabelPlayer2, m_GameForm.LabelPlayer2Score, m_GameForm.LabelPlayer1, m_GameForm.LabelPlayer1Score);
                }
            }
            else
            {
                m_CurrentPlayer = m_Player1;
                if (m_Player1.PlayerType != Player.ePlayerType.Computer && m_Player2.PlayerType != Player.ePlayerType.Computer)
                {
                    m_GameForm.MakeCurrentPlayerLabelBold(m_GameForm.LabelPlayer1, m_GameForm.LabelPlayer1Score, m_GameForm.LabelPlayer2, m_GameForm.LabelPlayer2Score);
                }
            }

            if (m_CurrentPlayer.PlayerType == Player.ePlayerType.Computer)
            {
                computerMove();
            }
        }

        private void updateMove(CellButton i_CellButton, int i_Row, int i_Col)
        {
            m_GameMap[i_Row, i_Col] = m_CurrentPlayer.Sign;
            i_CellButton.Text = m_CurrentPlayer.Sign.ToString();
            i_CellButton.Enabled = false;
            i_CellButton.BackColor = Color.LightGray;
            i_CellButton.Font = new Font(i_CellButton.Font, FontStyle.Bold);
            updateResult(new GameBoard.Position(i_Row, i_Col));
        }

        private void computerMove()
        {
            GameBoard.Position chosenPosition = m_CurrentPlayer.MakeComputerMove(m_GameMap);
            updateMove(m_GameForm.GameBoard[chosenPosition.Row, chosenPosition.Column], chosenPosition.Row, chosenPosition.Column);
        }

        private void showWinMessageBox(Player i_WinningPlayer)
        {
            string winMessage = string.Format(
                @"The winner is {0}! 
Would you like to play another round?", i_WinningPlayer.PlayerName);
            if (MessageBox.Show(winMessage, "A Win!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                initializeGame();
            }
            else
            {
                m_GameForm.Close();
            }
        }

        private void showTieMessageBox()
        {
            string tieMessage = string.Format(
                @"Tie! 
Would you like to play another round?");
            if (MessageBox.Show(tieMessage, "A Tie!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                initializeGame();
            }
            else
            {
                m_GameForm.Close();
            }
        }

        private void initializeGame()
        {
            m_GameMap.MakeEmptyBoard();
            m_GameForm.RestartBoard(this);
        }

        public Player Player1
        {
            get
            {
                return m_Player1;
            }
        }

        public Player Player2
        {
            get
            {
                return m_Player2;
            }
        }
    }
}
