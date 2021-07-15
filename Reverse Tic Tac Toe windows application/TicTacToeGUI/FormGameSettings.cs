using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGUI
{
    public partial class FormGameSettings : Form
    {
        public FormGameSettings()
        {
            InitializeComponent();
            addEventsHandler();
        }

        private void addEventsHandler()
        {
            NumericUpDownRows.ValueChanged += numericUpDown_ValueChanged;
            NumericUpDownCols.ValueChanged += numericUpDown_ValueChanged;
            CheckBoxPlayer2.CheckedChanged += checkBoxPlayer2_CheckedChanged;
            ButtonStart.Click += buttonStart_Click;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox theSender = sender as CheckBox;
            if (theSender.Checked == true)
            {
                TextBoxPlayer2.Enabled = true;
                TextBoxPlayer2.Clear();
            }
            else
            {
                TextBoxPlayer2.Enabled = false;
                TextBoxPlayer2.Text = "[Computer]";
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown theSender = sender as NumericUpDown;
            if (theSender == NumericUpDownRows)
            {
                NumericUpDownCols.Value = theSender.Value;
            }
            else
            {
                NumericUpDownRows.Value = theSender.Value;
            }
        }

        public bool IsPlayerComputer
        {
            get
            {
                return CheckBoxPlayer2.Checked==false;
            }
        }

        public int ColsSize
        {
            get
            {
                return (int)NumericUpDownCols.Value;
            }
        }

        public int RowssSize
        {
            get
            {
                return (int)NumericUpDownRows.Value;
            }
        }

        public string Player2Name
        {
            get
            {
                return TextBoxPlayer2.Text;
            }
        }

        public string Player1Name
        {
            get
            {
                return TextBoxPlayer1.Text;
            }
        }
    }
}
