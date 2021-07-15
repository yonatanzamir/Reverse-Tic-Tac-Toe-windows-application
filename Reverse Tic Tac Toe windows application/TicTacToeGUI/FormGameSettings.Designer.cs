
namespace TicTacToeGUI
{
    partial class FormGameSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelPlayers = new System.Windows.Forms.Label();
            this.LabelPlayer1 = new System.Windows.Forms.Label();
            this.LabelBoardSize = new System.Windows.Forms.Label();
            this.LabelRows = new System.Windows.Forms.Label();
            this.LabelCols = new System.Windows.Forms.Label();
            this.NumericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPlayers
            // 
            this.LabelPlayers.AutoSize = true;
            this.LabelPlayers.Location = new System.Drawing.Point(21, 17);
            this.LabelPlayers.Name = "LabelPlayers";
            this.LabelPlayers.Size = new System.Drawing.Size(44, 13);
            this.LabelPlayers.TabIndex = 0;
            this.LabelPlayers.Text = "Players:";
            // 
            // LabelPlayer1
            // 
            this.LabelPlayer1.AutoSize = true;
            this.LabelPlayer1.Location = new System.Drawing.Point(41, 54);
            this.LabelPlayer1.Name = "LabelPlayer1";
            this.LabelPlayer1.Size = new System.Drawing.Size(48, 13);
            this.LabelPlayer1.TabIndex = 1;
            this.LabelPlayer1.Text = "Player 1:";
            // 
            // LabelBoardSize
            // 
            this.LabelBoardSize.AutoSize = true;
            this.LabelBoardSize.Location = new System.Drawing.Point(21, 112);
            this.LabelBoardSize.Name = "LabelBoardSize";
            this.LabelBoardSize.Size = new System.Drawing.Size(61, 13);
            this.LabelBoardSize.TabIndex = 3;
            this.LabelBoardSize.Text = "Board Size:";
            // 
            // LabelRows
            // 
            this.LabelRows.AutoSize = true;
            this.LabelRows.Location = new System.Drawing.Point(21, 143);
            this.LabelRows.Name = "LabelRows";
            this.LabelRows.Size = new System.Drawing.Size(37, 13);
            this.LabelRows.TabIndex = 4;
            this.LabelRows.Text = "Rows:";
            // 
            // LabelCols
            // 
            this.LabelCols.AutoSize = true;
            this.LabelCols.Location = new System.Drawing.Point(130, 143);
            this.LabelCols.Name = "LabelCols";
            this.LabelCols.Size = new System.Drawing.Size(30, 13);
            this.LabelCols.TabIndex = 5;
            this.LabelCols.Text = "Cols:";
            // 
            // NumericUpDownCols
            // 
            this.NumericUpDownCols.Location = new System.Drawing.Point(167, 141);
            this.NumericUpDownCols.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumericUpDownCols.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericUpDownCols.Name = "NumericUpDownCols";
            this.NumericUpDownCols.Size = new System.Drawing.Size(39, 20);
            this.NumericUpDownCols.TabIndex = 6;
            this.NumericUpDownCols.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumericUpDownRows
            // 
            this.NumericUpDownRows.Location = new System.Drawing.Point(66, 141);
            this.NumericUpDownRows.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumericUpDownRows.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericUpDownRows.Name = "NumericUpDownRows";
            this.NumericUpDownRows.Size = new System.Drawing.Size(39, 20);
            this.NumericUpDownRows.TabIndex = 7;
            this.NumericUpDownRows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // TextBoxPlayer2
            // 
            this.TextBoxPlayer2.Enabled = false;
            this.TextBoxPlayer2.Location = new System.Drawing.Point(105, 78);
            this.TextBoxPlayer2.Name = "TextBoxPlayer2";
            this.TextBoxPlayer2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPlayer2.TabIndex = 8;
            this.TextBoxPlayer2.Text = "[Computer]";
            // 
            // TextBoxPlayer1
            // 
            this.TextBoxPlayer1.Location = new System.Drawing.Point(105, 51);
            this.TextBoxPlayer1.Name = "TextBoxPlayer1";
            this.TextBoxPlayer1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPlayer1.TabIndex = 9;
            // 
            // CheckBoxPlayer2
            // 
            this.CheckBoxPlayer2.AutoSize = true;
            this.CheckBoxPlayer2.Location = new System.Drawing.Point(24, 80);
            this.CheckBoxPlayer2.Name = "CheckBoxPlayer2";
            this.CheckBoxPlayer2.Size = new System.Drawing.Size(67, 17);
            this.CheckBoxPlayer2.TabIndex = 10;
            this.CheckBoxPlayer2.Text = "Player 2:";
            this.CheckBoxPlayer2.UseVisualStyleBackColor = true;
            // 
            // ButtonStart
            // 
            this.ButtonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonStart.Location = new System.Drawing.Point(24, 180);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(206, 23);
            this.ButtonStart.TabIndex = 11;
            this.ButtonStart.Text = "Start!";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // FormGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 226);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.CheckBoxPlayer2);
            this.Controls.Add(this.TextBoxPlayer1);
            this.Controls.Add(this.TextBoxPlayer2);
            this.Controls.Add(this.NumericUpDownRows);
            this.Controls.Add(this.NumericUpDownCols);
            this.Controls.Add(this.LabelCols);
            this.Controls.Add(this.LabelRows);
            this.Controls.Add(this.LabelBoardSize);
            this.Controls.Add(this.LabelPlayer1);
            this.Controls.Add(this.LabelPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameSettings";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownCols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPlayers;
        private System.Windows.Forms.Label LabelPlayer1;
        private System.Windows.Forms.Label LabelBoardSize;
        private System.Windows.Forms.Label LabelRows;
        private System.Windows.Forms.Label LabelCols;
        private System.Windows.Forms.NumericUpDown NumericUpDownCols;
        private System.Windows.Forms.NumericUpDown NumericUpDownRows;
        private System.Windows.Forms.TextBox TextBoxPlayer2;
        private System.Windows.Forms.TextBox TextBoxPlayer1;
        private System.Windows.Forms.CheckBox CheckBoxPlayer2;
        private System.Windows.Forms.Button ButtonStart;
    }
}