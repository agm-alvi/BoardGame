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
    public partial class MainForm : Form
    {

        public GameForm gp = new GameForm();
        public HomePage hp = new HomePage();

        public int totalRounds = 3;
        public int rounds = 0;


        public string[] names = { "Player 5", "Player 6", "Player 7", "Player 8" };
        public int[] points = {0, 0, 0, 0};


        DataTable dt = new DataTable();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showHomePage();
        }

        public void showHomePage()
        {
            hp = new HomePage(this);

            hp.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(hp);
            hp.BringToFront();
        }
        public void showGamePage()
        {
            gp = new GameForm(this);

            gp.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(gp);
            gp.BringToFront();
        }

        public void clearScoreTable()
        {
//            dt.Clear();
            dt.Reset();
        }
        public void addScoreTableHeader(String name1, String name2, String name3, String name4)
        {
            dt.Columns.Add("Round", Type.GetType("System.String"));
            dt.Columns.Add(name1, Type.GetType("System.Int32"));
            dt.Columns.Add(name2, Type.GetType("System.Int32"));
            dt.Columns.Add(name3, Type.GetType("System.Int32"));
            dt.Columns.Add(name4, Type.GetType("System.Int32"));
            scoreTableDataGrid.DataSource = dt;

        }

        public void addScoresToTable(int score1, int score2, int score3, int score4)
        {
            dt.Rows.Add(rounds, score1, score2, score3, score4);
        }

        public void addResultsToTable(int score1, int score2, int score3, int score4)
        {
            dt.Rows.Add("Total", score1, score2, score3, score4);
        }

    }
}
