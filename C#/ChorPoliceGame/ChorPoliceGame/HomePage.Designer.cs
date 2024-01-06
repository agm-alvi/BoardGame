
namespace ChorPoliceGame
{
    partial class HomePage
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
            this.player1Name = new System.Windows.Forms.TextBox();
            this.player4Name = new System.Windows.Forms.TextBox();
            this.player3Name = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(79, 70);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(150, 23);
            this.player1Name.TabIndex = 1;
            // 
            // player4Name
            // 
            this.player4Name.Location = new System.Drawing.Point(79, 157);
            this.player4Name.Name = "player4Name";
            this.player4Name.Size = new System.Drawing.Size(150, 23);
            this.player4Name.TabIndex = 4;
            // 
            // player3Name
            // 
            this.player3Name.Location = new System.Drawing.Point(79, 128);
            this.player3Name.Name = "player3Name";
            this.player3Name.Size = new System.Drawing.Size(150, 23);
            this.player3Name.TabIndex = 3;
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(79, 99);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(150, 23);
            this.player2Name.TabIndex = 2;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartGame.Location = new System.Drawing.Point(45, 208);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(200, 80);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player3Name);
            this.Controls.Add(this.player4Name);
            this.Controls.Add(this.player1Name);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(450, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.TextBox player4Name;
        private System.Windows.Forms.TextBox player3Name;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.Button btnStartGame;
    }
}
