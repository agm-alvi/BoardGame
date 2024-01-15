
namespace ChorPoliceGame
{
    partial class GameForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chit1 = new System.Windows.Forms.Button();
            this.chit2 = new System.Windows.Forms.Button();
            this.chit4 = new System.Windows.Forms.Button();
            this.chit3 = new System.Windows.Forms.Button();
            this.chitCHoosingLabel = new System.Windows.Forms.Label();
            this.policeChoice2 = new System.Windows.Forms.Button();
            this.policeChoice1 = new System.Windows.Forms.Button();
            this.headFoundLabel = new System.Windows.Forms.Label();
            this.policeGuessLabel = new System.Windows.Forms.Label();
            this.findBetweenLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.roundNoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chit1
            // 
            this.chit1.FlatAppearance.BorderSize = 3;
            this.chit1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chit1.Location = new System.Drawing.Point(58, 104);
            this.chit1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.chit1.Name = "chit1";
            this.chit1.Size = new System.Drawing.Size(220, 80);
            this.chit1.TabIndex = 1;
            this.chit1.Text = "1";
            this.chit1.UseVisualStyleBackColor = true;
            this.chit1.Click += new System.EventHandler(this.chit1_Click);
            // 
            // chit2
            // 
            this.chit2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chit2.Location = new System.Drawing.Point(319, 104);
            this.chit2.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.chit2.Name = "chit2";
            this.chit2.Size = new System.Drawing.Size(220, 80);
            this.chit2.TabIndex = 2;
            this.chit2.Text = "2";
            this.chit2.UseVisualStyleBackColor = true;
            this.chit2.Click += new System.EventHandler(this.chit2_Click);
            // 
            // chit4
            // 
            this.chit4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chit4.Location = new System.Drawing.Point(319, 199);
            this.chit4.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.chit4.Name = "chit4";
            this.chit4.Size = new System.Drawing.Size(220, 80);
            this.chit4.TabIndex = 4;
            this.chit4.Text = "4";
            this.chit4.UseVisualStyleBackColor = true;
            this.chit4.Click += new System.EventHandler(this.chit4_Click);
            // 
            // chit3
            // 
            this.chit3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chit3.Location = new System.Drawing.Point(58, 199);
            this.chit3.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.chit3.Name = "chit3";
            this.chit3.Size = new System.Drawing.Size(220, 80);
            this.chit3.TabIndex = 3;
            this.chit3.Text = "3";
            this.chit3.UseVisualStyleBackColor = true;
            this.chit3.Click += new System.EventHandler(this.chit3_Click);
            // 
            // chitCHoosingLabel
            // 
            this.chitCHoosingLabel.AutoSize = true;
            this.chitCHoosingLabel.Location = new System.Drawing.Point(6, 61);
            this.chitCHoosingLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.chitCHoosingLabel.Name = "chitCHoosingLabel";
            this.chitCHoosingLabel.Size = new System.Drawing.Size(192, 32);
            this.chitCHoosingLabel.TabIndex = 4;
            this.chitCHoosingLabel.Text = "Choose a chit";
            // 
            // policeChoice2
            // 
            this.policeChoice2.Location = new System.Drawing.Point(283, 433);
            this.policeChoice2.Name = "policeChoice2";
            this.policeChoice2.Size = new System.Drawing.Size(165, 47);
            this.policeChoice2.TabIndex = 5;
            this.policeChoice2.Text = "choice2";
            this.policeChoice2.UseVisualStyleBackColor = true;
            this.policeChoice2.Click += new System.EventHandler(this.policeChoice2_Click);
            // 
            // policeChoice1
            // 
            this.policeChoice1.Location = new System.Drawing.Point(102, 433);
            this.policeChoice1.Name = "policeChoice1";
            this.policeChoice1.Size = new System.Drawing.Size(175, 47);
            this.policeChoice1.TabIndex = 6;
            this.policeChoice1.Text = "choice1";
            this.policeChoice1.UseVisualStyleBackColor = true;
            this.policeChoice1.Click += new System.EventHandler(this.policeChoice1_Click);
            // 
            // headFoundLabel
            // 
            this.headFoundLabel.AutoSize = true;
            this.headFoundLabel.Location = new System.Drawing.Point(8, 304);
            this.headFoundLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.headFoundLabel.Name = "headFoundLabel";
            this.headFoundLabel.Size = new System.Drawing.Size(254, 32);
            this.headFoundLabel.TabIndex = 7;
            this.headFoundLabel.Text = "Player 000 is head";
            // 
            // policeGuessLabel
            // 
            this.policeGuessLabel.AutoSize = true;
            this.policeGuessLabel.Location = new System.Drawing.Point(8, 345);
            this.policeGuessLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.policeGuessLabel.Name = "policeGuessLabel";
            this.policeGuessLabel.Size = new System.Drawing.Size(267, 32);
            this.policeGuessLabel.TabIndex = 8;
            this.policeGuessLabel.Text = "player 000 is police";
            // 
            // findBetweenLabel
            // 
            this.findBetweenLabel.AutoSize = true;
            this.findBetweenLabel.Location = new System.Drawing.Point(8, 385);
            this.findBetweenLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.findBetweenLabel.Name = "findBetweenLabel";
            this.findBetweenLabel.Size = new System.Drawing.Size(257, 32);
            this.findBetweenLabel.TabIndex = 9;
            this.findBetweenLabel.Text = "Find chor between";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(8, 490);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(114, 32);
            this.answerLabel.TabIndex = 10;
            this.answerLabel.Text = "Answer";
            // 
            // btnNextRound
            // 
            this.btnNextRound.Location = new System.Drawing.Point(198, 532);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(179, 40);
            this.btnNextRound.TabIndex = 11;
            this.btnNextRound.Text = "Next Round";
            this.btnNextRound.UseVisualStyleBackColor = true;
            this.btnNextRound.Click += new System.EventHandler(this.nextRound_Click);
            // 
            // roundNoLabel
            // 
            this.roundNoLabel.AutoSize = true;
            this.roundNoLabel.Location = new System.Drawing.Point(137, 15);
            this.roundNoLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundNoLabel.Name = "roundNoLabel";
            this.roundNoLabel.Size = new System.Drawing.Size(98, 32);
            this.roundNoLabel.TabIndex = 12;
            this.roundNoLabel.Text = "Round";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.roundNoLabel);
            this.Controls.Add(this.btnNextRound);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.findBetweenLabel);
            this.Controls.Add(this.policeGuessLabel);
            this.Controls.Add(this.headFoundLabel);
            this.Controls.Add(this.policeChoice1);
            this.Controls.Add(this.policeChoice2);
            this.Controls.Add(this.chitCHoosingLabel);
            this.Controls.Add(this.chit4);
            this.Controls.Add(this.chit3);
            this.Controls.Add(this.chit2);
            this.Controls.Add(this.chit1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "GameForm";
            this.Size = new System.Drawing.Size(600, 580);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chit1;
        private System.Windows.Forms.Button chit2;
        private System.Windows.Forms.Button chit4;
        private System.Windows.Forms.Button chit3;
        private System.Windows.Forms.Label chitCHoosingLabel;
        private System.Windows.Forms.Button policeChoice2;
        private System.Windows.Forms.Button policeChoice1;
        private System.Windows.Forms.Label headFoundLabel;
        private System.Windows.Forms.Label policeGuessLabel;
        private System.Windows.Forms.Label findBetweenLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Label roundNoLabel;
    }
}
