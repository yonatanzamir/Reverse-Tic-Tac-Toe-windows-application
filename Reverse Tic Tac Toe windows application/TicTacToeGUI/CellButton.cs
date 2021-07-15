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
    public class CellButton : Button
    {
        private readonly GameBoard.Position r_ButtonPosition;
        private const int k_ButtonSize = 60;

        public CellButton(int i_Row, int i_Col)
        {
            r_ButtonPosition = new GameBoard.Position(i_Row, i_Col);
            this.Size = new Size(k_ButtonSize, k_ButtonSize);
        }

        public static int ButtonSize
        {
            get
            {
                return k_ButtonSize;
            }
        }

        public GameBoard.Position ButtonPosition
        {
            get
            {
                return r_ButtonPosition;
            }
        }
    }
}