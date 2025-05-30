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
    public partial class HomePage : UserControl
    {
        MainForm mainForm;
        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            assignNames();
            //AssignNames();
            setTotalRounds();
            mainForm.showGamePage();
        }

        public void assignNames()
        {
            if (player1Name.Text != "")
            {
                mainForm.names[0] = player1Name.Text;
            }
            if (player2Name.Text != "")
            {
                mainForm.names[1] = player2Name.Text;
            }
            if (player3Name.Text != "")
            {
                mainForm.names[2] = player3Name.Text;
            }
            if (player4Name.Text != "")
            {
                mainForm.names[3] = player4Name.Text;
            }

            mainForm.AddScoreTableHeader(mainForm.names[0], mainForm.names[1], mainForm.names[2], mainForm.names[3]);
        }

        public void AssignNames()
        {
            MainForm.global.players[0].name = string.IsNullOrEmpty(player1Name.Text) ? "Alpha" : player1Name.Text;
            MainForm.global.players[1].name = string.IsNullOrEmpty(player2Name.Text) ? "Beta" : player2Name.Text;
            MainForm.global.players[2].name = string.IsNullOrEmpty(player3Name.Text) ? "Gamma" : player3Name.Text;
            MainForm.global.players[3].name = string.IsNullOrEmpty(player4Name.Text) ? "Delta" : player4Name.Text;
            
            mainForm.AddScoreTableHeader(MainForm.global.players[0].name, MainForm.global.players[1].name, MainForm.global.players[2].name, MainForm.global.players[3].name);
        }

        public void setTotalRounds()
        {
            if (RoundsTextBox.Text != "")
            {
                mainForm.totalRounds = int.Parse(RoundsTextBox.Text);
            
            }
        }
    }
}
