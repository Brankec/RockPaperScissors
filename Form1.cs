using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        int opponentChoice = 0;
        string[] opponentAnswers = new string[3] {
            "Rock", "Paper", "Scissors"
        };

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void RockBtn_Click(object sender, EventArgs e)
        {
            opponentChoice = random.Next(0, 3);

            ProgramAnswerTxt.Text = opponentAnswers[opponentChoice];
            if (opponentAnswers[opponentChoice] == "Rock")
            {
                ResultTxt.ForeColor = Color.White;
                ResultTxt.Text = "Stalemate!";
            }
            if (opponentAnswers[opponentChoice] == "Paper")
            {
                ResultTxt.ForeColor = Color.Red;
                ResultTxt.Text = "You Lost!";
            }
            if (opponentAnswers[opponentChoice] == "Scissors")
            {
                ResultTxt.ForeColor = Color.Green;
                ResultTxt.Text = "You Win!";
            }
        }

        private void PaperBtn_Click(object sender, EventArgs e)
        {
            opponentChoice = random.Next(0, 3);

            ProgramAnswerTxt.Text = opponentAnswers[opponentChoice];
            if (opponentAnswers[opponentChoice] == "Rock")
            {
                ResultTxt.ForeColor = Color.Green;
                ResultTxt.Text = "You Win!";
            }
            if (opponentAnswers[opponentChoice] == "Paper")
            {
                ResultTxt.ForeColor = Color.White;
                ResultTxt.Text = "Stalemate!";
            }
            if (opponentAnswers[opponentChoice] == "Scissors")
            {
                ResultTxt.ForeColor = Color.Red;
                ResultTxt.Text = "You Lost!";
            }
        }

        private void ScissorsBtn_Click(object sender, EventArgs e)
        {
            opponentChoice = random.Next(0, 3);

            ProgramAnswerTxt.Text = opponentAnswers[opponentChoice];
            if (opponentAnswers[opponentChoice] == "Rock")
            {
                ResultTxt.ForeColor = Color.Red;
                ResultTxt.Text = "You Lost!";
            }
            if (opponentAnswers[opponentChoice] == "Paper")
            {
                ResultTxt.ForeColor = Color.Green;
                ResultTxt.Text = "You Win!";
            }
            if (opponentAnswers[opponentChoice] == "Scissors")
            {
                ResultTxt.ForeColor = Color.White;
                ResultTxt.Text = "Stalemate!";
            }
        }
    }

}
