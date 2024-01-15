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
            
            mainForm.addScoreTableHeader(mainForm.names[0], mainForm.names[1], mainForm.names[2], mainForm.names[3]);
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
