using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TicTacToeGUI
{
    public class FormTicTacToe : Form
    {
        private readonly CellButton[,] r_GameBoard = null;
        private Label m_LabelPlayer1;
        private Label m_LabelPlayer1Score;
        private Label m_LabelPlayer2;
        private Label m_LabelPlayer2Score;
        private const int k_SpaceBetweenButtons = 5;
        private const int k_SpaceFromMargins = 12;

        public FormTicTacToe(int i_BoardSize, GameManager i_GameManager)
        {
            r_GameBoard = new CellButton[i_BoardSize, i_BoardSize];
            initializeForm(i_BoardSize, i_GameManager);
        }

        private void initializeLabels(int i_BoardSize, GameManager i_GameManager)
        {
            addLabelsToControls(i_GameManager);
            locateLabelsOnTheForm(i_BoardSize, i_GameManager);
            MakeCurrentPlayerLabelBold(m_LabelPlayer1, m_LabelPlayer1Score, m_LabelPlayer2, m_LabelPlayer2Score);
        }

        private void locateLabelsOnTheForm(int i_BoardSize, GameManager i_GameManager)
        {
            m_LabelPlayer1.AutoSize = true;
            m_LabelPlayer1Score.AutoSize = true;
            m_LabelPlayer2.AutoSize = true;
            m_LabelPlayer2Score.AutoSize = true;
            m_LabelPlayer1.Top = this.ClientSize.Height - ((this.ClientSize.Height - r_GameBoard[i_BoardSize - 1, i_BoardSize - 1].Bottom) / 2) - (m_LabelPlayer1.Height - 8) / 2;
            m_LabelPlayer1Score.Top = m_LabelPlayer1.Top;
            m_LabelPlayer2.Top = m_LabelPlayer1.Top;
            m_LabelPlayer2Score.Top = m_LabelPlayer1.Top;
            m_LabelPlayer2.Left = this.Width / 2 - 8;
            m_LabelPlayer2Score.Left = m_LabelPlayer2.Right;
            m_LabelPlayer1Score.Left = m_LabelPlayer2.Left - 20;
            m_LabelPlayer1.Left = m_LabelPlayer1Score.Left - 7 * i_GameManager.Player1.PlayerName.Length;
            m_LabelPlayer1Score.Left = m_LabelPlayer1.Right;
        }

        private void addLabelsToControls(GameManager i_GameManager)
        {
            m_LabelPlayer1 = new Label();
            m_LabelPlayer1Score = new Label();
            m_LabelPlayer2 = new Label();
            m_LabelPlayer2Score = new Label();
            m_LabelPlayer1.Text = i_GameManager.Player1.PlayerName + ":";
            m_LabelPlayer1Score.Text = "0";
            m_LabelPlayer2.Text = i_GameManager.Player2.PlayerName + ":";
            m_LabelPlayer2Score.Text = "0";
            this.Controls.Add(m_LabelPlayer1);
            this.Controls.Add(m_LabelPlayer1Score);
            this.Controls.Add(m_LabelPlayer2);
            this.Controls.Add(m_LabelPlayer2Score);
        }

        private void initializeCellButtons(int i_BoardSize, GameManager i_GameManager)
        {
            for(int i = 0; i < i_BoardSize; i++)
            {
                for(int j = 0; j < i_BoardSize; j++)
                {
                    r_GameBoard[i,j] = new CellButton(i,j);
                    r_GameBoard[i, j].Location = new Point(i * (CellButton.ButtonSize + k_SpaceBetweenButtons) + k_SpaceBetweenButtons + k_SpaceFromMargins, j * (CellButton.ButtonSize + k_SpaceBetweenButtons) + k_SpaceBetweenButtons);
                    r_GameBoard[i, j].Click += i_GameManager.CellButton_Click;
                    this.Controls.Add(r_GameBoard[i, j]);
                }
            }
        }

        private void initializeForm(int i_BoardSize, GameManager i_GameManager)
        {
            this.ClientSize = new Size(i_BoardSize * CellButton.ButtonSize + (i_BoardSize + 1) * k_SpaceBetweenButtons+ 2*k_SpaceFromMargins, i_BoardSize * CellButton.ButtonSize + (i_BoardSize + 1) * k_SpaceBetweenButtons+ 2 * k_SpaceFromMargins);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            initializeCellButtons(i_BoardSize, i_GameManager);
            initializeLabels(i_BoardSize, i_GameManager);
        }

        public void RestartBoard(GameManager i_GameManager)
        {
            for(int i = 0; i < r_GameBoard.GetLength(0); i++)
            {
                for(int j = 0; j < r_GameBoard.GetLength(1); j++)
                {
                    r_GameBoard[i, j].Text = String.Empty;
                    r_GameBoard[i, j].Enabled = true;
                    r_GameBoard[i, j].UseVisualStyleBackColor = true;
                }
            }

            LabelPlayer1Score.Text= i_GameManager.Player1.NumberOfWins.ToString();
            LabelPlayer2Score.Text = i_GameManager.Player2.NumberOfWins.ToString();
            MakeCurrentPlayerLabelBold(m_LabelPlayer1, m_LabelPlayer1Score, m_LabelPlayer2, m_LabelPlayer2Score);
        }

        public void MakeCurrentPlayerLabelBold(Label i_CurrentPlayerName, Label i_CurrentPlayerScore, Label i_PreviousPlayerName, Label i_PreviousPlayerScore)
        {
            i_CurrentPlayerName.Font = new Font(i_CurrentPlayerName.Font, FontStyle.Bold);
            i_CurrentPlayerScore.Font = new Font(i_CurrentPlayerScore.Font, FontStyle.Bold);
            i_PreviousPlayerName.Font = new Font(i_PreviousPlayerName.Font, FontStyle.Regular);
            i_PreviousPlayerScore.Font = new Font(i_PreviousPlayerScore.Font, FontStyle.Regular);
        }

        public Label LabelPlayer1
        {
            get
            {
                return m_LabelPlayer1;
            }
        }

        public Label LabelPlayer2
        {
            get
            {
                return m_LabelPlayer2;
            }
        }

        public Label LabelPlayer1Score
        {
            get
            {
                return m_LabelPlayer1Score;
            }
        }

        public Label LabelPlayer2Score
        {
            get
            {
                return m_LabelPlayer2Score;
            }
        }

        public CellButton[,] GameBoard
        {
            get
            {
                return r_GameBoard;
            }
        }
    }
}
