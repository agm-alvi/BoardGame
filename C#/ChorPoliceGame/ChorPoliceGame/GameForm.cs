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
        MainForm mainForm;
        int playerNo;
        int chitBtnClicked = 0;
        int[] chitSelect = { 0, 0, 0, 0 };
        string[] findBetween = {"Chor", "Dakat"};
        int whomToSearch;
        int pointDistribution; //1 = police 0, 2=chor 0, 3=dakat 0;

        int policeChoice;


        public GameForm()
        {
            InitializeComponent();
        }   
        public GameForm(MainForm form)
        {
            InitializeComponent();
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
            chitSelect[chitBtnClicked] = 1;
            chitBtnClicked++;
            guessingPart();
        }

        private void chit2_Click(object sender, EventArgs e)
        {
            switch (playerNo)
            {

            }
            chit2.Enabled = false;
            chitSelect[chitBtnClicked] = 2;
            chitBtnClicked++;
            guessingPart();
        }

        private void chit3_Click(object sender, EventArgs e)
        {
            switch (playerNo)
            {

            }
            chit3.Enabled = false;
            chitSelect[chitBtnClicked] = 3;
            chitBtnClicked++;
            guessingPart();
        }

        private void chit4_Click(object sender, EventArgs e)
        {
            switch (playerNo)
            {

            }
            chit4.Enabled = false;
            chitSelect[chitBtnClicked] = 4;
            chitBtnClicked++;
            guessingPart();
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

            headFoundLabel.Text = mainForm.names[chitSelect[0]-1] + " is The Head";
            policeGuessLabel.Text = mainForm.names[chitSelect[1]-1] + " is Police";
            findBetweenLabel.Text = "Please find " + findBetween[whomToSearch] + " between: ";

            policeChoice1.Text = ""+ mainForm.names[chitSelect[2]-1];
            policeChoice2.Text = ""+ mainForm.names[chitSelect[3]-1];
            policeChoice1.Visible = true;
            policeChoice2.Visible = true;

        }

        private void policeChoice1_Click(object sender, EventArgs e)
        {
            policeChoice = chitSelect[2];
            calcResults();
        }

        private void policeChoice2_Click(object sender, EventArgs e)
        {
            policeChoice = chitSelect[3];
            calcResults();
        }

        void calcResults()
        {
            if (policeChoice == chitSelect[2])
            {
                answerLabel.Text = "The " + findBetween[whomToSearch] +" is Caught ";
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
                answerLabel.Text = "The  " + findBetween[whomToSearch] + "  is Missed ";
                pointDistribution = 1;
            }

            btnNextRound.Visible = true;
        }

        void setScore()
        {

            mainForm.points[chitSelect[0]-1] += 1000;

            switch (pointDistribution)
            {
                case 1:
                    mainForm.points[chitSelect[1]-1] += 0;
                    mainForm.points[chitSelect[2]-1] += 600;
                    mainForm.points[chitSelect[3]-1] += 400;
                    break;
                case 2:
                    mainForm.points[chitSelect[1]-1] += 800;
                    mainForm.points[chitSelect[2]-1] += 600;
                    mainForm.points[chitSelect[3]-1] += 0;
                    break;
                case 3:
                    mainForm.points[chitSelect[1]-1] += 800;
                    mainForm.points[chitSelect[2]-1] += 0;
                    mainForm.points[chitSelect[3]-1] += 400;
                    break;
            }


            mainForm.addScoresToTable(mainForm.points[0], mainForm.points[1], mainForm.points[2], mainForm.points[3]);
        }

        void calculateScore()
        {
            
            mainForm.addResultsToTable(mainForm.points[0], mainForm.points[1], mainForm.points[2], mainForm.points[3]);
           
            //Application.Exit();
        }


        private void nextRound_Click(object sender, EventArgs e)
        {
            mainForm.rounds++;
            setScore();

            if (mainForm.rounds >= mainForm.totalRounds)
            {
                calculateScore();
            }
            else
            {
                mainForm.showGamePage();
            }
        }
    }
}
