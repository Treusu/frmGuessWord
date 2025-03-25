using System.Text;

namespace frmGuessWord
{
    public partial class Form1 : Form
    {
        private string wordToGuess = "computer";
        private StringBuilder wrongGuesses = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            Word.Text = MaskWord(wordToGuess);
        }

        private string MaskWord(string word)
        {
            if (word.Length > 2)
            {
                return word[0] + new string('?', word.Length - 2) + word[word.Length - 1];
            }
            return word;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Guesses = Guess.Text.Trim();

            if (string.IsNullOrEmpty(Guesses))
            {
                MessageBox.Show("Please enter a word!", "Error");
                return;
            }

            if (Guesses.Equals(wordToGuess, StringComparison.OrdinalIgnoreCase))
            {
                Word.Text = wordToGuess;
                MessageBox.Show("Correct guess!");
            }
            else
            {
                if (!wrongGuesses.ToString().Contains(Guesses))
                {
                    wrongGuesses.AppendLine(Guesses);
                    WrongGuesses.Text = wrongGuesses.ToString();
                }

                MessageBox.Show("Wrong guess!\nTry again.");
                Guess.Clear();
                Guess.Focus();
            }
        }
    }
}
