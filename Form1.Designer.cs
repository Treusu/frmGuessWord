namespace frmGuessWord
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Word = new Label();
            label2 = new Label();
            Guess = new TextBox();
            BTNGuess = new Button();
            WrongGuesses = new Label();
            SuspendLayout();
            // 
            // Word
            // 
            Word.BackColor = Color.DarkSeaGreen;
            Word.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Word.ForeColor = Color.White;
            Word.Location = new Point(12, 9);
            Word.Name = "Word";
            Word.Size = new Size(346, 92);
            Word.TabIndex = 0;
            Word.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(364, 9);
            label2.Name = "label2";
            label2.Size = new Size(172, 24);
            label2.TabIndex = 1;
            label2.Text = "Wrong guess";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Guess
            // 
            Guess.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Guess.Location = new Point(69, 104);
            Guess.Name = "Guess";
            Guess.Size = new Size(221, 32);
            Guess.TabIndex = 2;
            Guess.TextAlign = HorizontalAlignment.Center;
            // 
            // BTNGuess
            // 
            BTNGuess.BackColor = Color.DarkSeaGreen;
            BTNGuess.Font = new Font("Segoe UI", 12F);
            BTNGuess.ForeColor = Color.White;
            BTNGuess.Location = new Point(130, 138);
            BTNGuess.Name = "BTNGuess";
            BTNGuess.Size = new Size(101, 31);
            BTNGuess.TabIndex = 3;
            BTNGuess.Text = "Guess";
            BTNGuess.UseVisualStyleBackColor = false;
            BTNGuess.Click += button1_Click;
            // 
            // WrongGuesses
            // 
            WrongGuesses.BackColor = SystemColors.Window;
            WrongGuesses.Font = new Font("Segoe UI", 12F);
            WrongGuesses.Location = new Point(364, 38);
            WrongGuesses.Name = "WrongGuesses";
            WrongGuesses.Size = new Size(172, 136);
            WrongGuesses.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 182);
            Controls.Add(WrongGuesses);
            Controls.Add(BTNGuess);
            Controls.Add(Guess);
            Controls.Add(label2);
            Controls.Add(Word);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Word;
        private Label label2;
        private TextBox Guess;
        private Button BTNGuess;
        private Label WrongGuesses;
    }
}
