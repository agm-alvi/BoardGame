using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChorPoliceGame
{
    public partial class GameForm : UserControl
    {
        public const int NumberOfPlayers = 4;

        MainForm mainForm;
        int playerNo;
        int chitBtnClicked = 0;
        int[] chitSelect = { 0, 0, 0, 0 };
        int whomToSearch;
        int pointDistribution; //1 = police 0, 2=chor 0, 3=dakat 0;

        int[,] playersSl = { { 1, 2, 3, 4 }, { 2, 3, 4, 1 }, { 3, 4, 1, 2 }, { 4, 1, 2, 3 } };

        int rnd;//randomizer
        int findingRnd;

        string[] ch = { "Chor", "Dakat", "Police", "Daroga" };
        string[] chBn = { "চোর", "ডাকাত", "পুলিশ", "দারোগা" };

        int[] roundPoints = { 0, 0, 0, 0 };

        int policeChoice;
        public enum characters
        {
            Chor, Dakat, Police, Daroga
        }

        public GameForm()
        {
            InitializeComponent();
        }   
        public GameForm(MainForm form)
        {
            InitializeComponent();
            randomGenerator();
            mainForm = form;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            policeChoice1.Visible = false;
            policeChoice2.Visible = false;
            btnNextRound.Visible = false;
            headFoundLabel.Text = " ";
            policeGuessLabel.Text = " ";
            findBetweenLabel.Text = " ";
            answerLabel.Text = " ";

            roundNoLabel.Text = "Round " + (mainForm.rounds+1);
            guessingPart();
        }

        private void chit1_Click(object sender, EventArgs e)
        {
            switch (playerNo)
            {

            }
            chit1.Enabled = false;
            chit1.Text = mainForm.names[chitBtnClicked];
            chitSelect[MainForm.global.chitSl[rnd, 0]] = 1;

            chitBtnClicked++;
            guessingPart();

            //ClickedChitBtn(1);
        }

        private void chit2_Click(object sender, EventArgs e)
        {
            switch (playerNo)
            {

            }
            chit2.Enabled = false;
            chit2.Text = mainForm.names[chitBtnClicked];
            chitSelect[MainForm.global.chitSl[rnd, 1]] = 2;
            chitBtnClicked++;
            guessingPart();
        }

        private void chit3_Click(object sender, EventArgs e)
        {
            switch (playerNo)
            {

            }
            chit3.Enabled = false;
            chit3.Text = mainForm.names[chitBtnClicked];
            chitSelect[MainForm.global.chitSl[rnd, 2]] = 3;
            chitBtnClicked++;
            guessingPart();
        }

        private void chit4_Click(object sender, EventArgs e)
        {
            switch (playerNo)
            {

            }
            chit4.Enabled = false;
            chit4.Text = mainForm.names[chitBtnClicked];
            chitSelect[MainForm.global.chitSl[rnd, 3]] = 4;
            chitBtnClicked++;
            guessingPart();
        }

        private void ClickedChitBtn(int chitno)
        {
            switch (chitno)
            {
                case 1:
                    chit1.Enabled = false;
                    break;
            }

            chitBtnClicked++;
            guessingPart();

        }

        void randomGenerator()
        {
            Random rand = new Random();
            rnd = rand.Next(0,24);
            findingRnd = rnd % 2;
        }

        void guessingPart()
        {
            if (chitBtnClicked < 4)
            {
                string labelText = mainForm.names[chitBtnClicked] + " Select a chit";
                chitCHoosingLabel.Text = labelText;
                return;
            }
            else if (chitBtnClicked == 4)
            {
                chitCHoosingLabel.Text = " ";
            }
            whomToSearch = mainForm.rounds % 2;

            headFoundLabel.Text = mainForm.names[chitSelect[0]-1] + " is The "+ch[3];
            policeGuessLabel.Text = mainForm.names[chitSelect[1]-1] + " is "+ch[2];
            findBetweenLabel.Text = "Please find " + ch[whomToSearch] + " between: ";

            switch (findingRnd)
            {
                case 0:
                    policeChoice1.Text = ""+ mainForm.names[chitSelect[3]-1];
                    policeChoice2.Text = ""+ mainForm.names[chitSelect[2]-1];
                    break;
                case 1:
                    policeChoice1.Text = ""+ mainForm.names[chitSelect[2]-1];
                    policeChoice2.Text = ""+ mainForm.names[chitSelect[3]-1];
                    break;
            }
            policeChoice1.Visible = true;
            policeChoice2.Visible = true;

        }

        private void policeChoice1_Click(object sender, EventArgs e)
        {
            policeChoice = 1;
            policeChoice1.BackColor = Color.Azure;
            calcResults();
        }

        private void policeChoice2_Click(object sender, EventArgs e)
        {
            policeChoice = 2;
            policeChoice1.BackColor = Color.Azure;
            calcResults();
        }

        void calcResults()
        {
            if (findingRnd == 0 && policeChoice == 1)
            {
                answerLabel.Text = "The " + ch[whomToSearch] +" is Caught ";
                if (whomToSearch == 0)
                {
                    pointDistribution = 2;
                }
                else
                {
                    pointDistribution = 3;
                }

            }
            else if (findingRnd == 1 && policeChoice == 2)
            {
                answerLabel.Text = "The " + ch[whomToSearch] + " is Caught ";
                if (whomToSearch == 0)
                {
                    pointDistribution = 2;
                }
                else
                {
                    pointDistribution = 3;
                }
            }
            else
            {
                answerLabel.Text = "The  " + ch[whomToSearch] + "  is Missed ";
                pointDistribution = 1;
            }

            btnNextRound.Visible = true;
        }

        void setScore()
        {

            roundPoints[chitSelect[0] - 1] = 1000;

            switch (pointDistribution)
            {
                case 1: //if Police Fails
                    roundPoints[chitSelect[1] - 1] = 0;
                    roundPoints[chitSelect[2] - 1] = 600;
                    roundPoints[chitSelect[3] - 1] = 400;
                    break;
                case 2: // if Chor Caught
                    roundPoints[chitSelect[1] - 1] = 800;
                    roundPoints[chitSelect[2] - 1] = 600;
                    roundPoints[chitSelect[3] - 1] = 0;
                    break;
                case 3: // if Dakat Caught
                    roundPoints[chitSelect[1] - 1] = 800;
                    roundPoints[chitSelect[2] - 1] = 0;
                    roundPoints[chitSelect[3] - 1] = 400;
                    break;
            }


            for (int i = 0; i < 4; i++)
            {
                mainForm.points[i] += roundPoints[i];
            }

            mainForm.addScoresToTable(roundPoints[0], roundPoints[1], roundPoints[2], roundPoints[3]);
        }

        void CalculateScore()
        {
            mainForm.AddResultsToTable();
            //mainForm.addResultsToTable(mainForm.points[0], mainForm.points[1], mainForm.points[2], mainForm.points[3]);
           
            //Application.Exit();
        }


        private void nextRound_Click(object sender, EventArgs e)
        {
            mainForm.rounds++;
            setScore();

            if (mainForm.rounds == mainForm.totalRounds)
            {
                CalculateScore();
                btnNextRound.Text = "Play Again";
            }
            else if (mainForm.rounds >= mainForm.totalRounds)
            {
                mainForm.clearScoreTable();
                mainForm.showHomePage();
            }
            else
            {
                mainForm.showGamePage();
            }
        }
    }
}
