
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
            this.SuspendLayout();
            // 
            // chit1
            // 
            this.chit1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chit1.Location = new System.Drawing.Point(9, 75);
            this.chit1.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.chit1.Name = "chit1";
            this.chit1.Size = new System.Drawing.Size(100, 100);
            this.chit1.TabIndex = 0;
            this.chit1.Text = "1";
            this.chit1.UseVisualStyleBackColor = true;
            // 
            // chit2
            // 
            this.chit2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chit2.Location = new System.Drawing.Point(115, 75);
            this.chit2.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.chit2.Name = "chit2";
            this.chit2.Size = new System.Drawing.Size(100, 100);
            this.chit2.TabIndex = 1;
            this.chit2.Text = "2";
            this.chit2.UseVisualStyleBackColor = true;
            // 
            // chit4
            // 
            this.chit4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chit4.Location = new System.Drawing.Point(328, 75);
            this.chit4.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.chit4.Name = "chit4";
            this.chit4.Size = new System.Drawing.Size(100, 100);
            this.chit4.TabIndex = 3;
            this.chit4.Text = "4";
            this.chit4.UseVisualStyleBackColor = true;
            // 
            // chit3
            // 
            this.chit3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chit3.Location = new System.Drawing.Point(222, 75);
            this.chit3.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.chit3.Name = "chit3";
            this.chit3.Size = new System.Drawing.Size(100, 100);
            this.chit3.TabIndex = 2;
            this.chit3.Text = "3";
            this.chit3.UseVisualStyleBackColor = true;
            // 
            // chitCHoosingLabel
            // 
            this.chitCHoosingLabel.AutoSize = true;
            this.chitCHoosingLabel.Location = new System.Drawing.Point(36, 25);
            this.chitCHoosingLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.chitCHoosingLabel.Name = "chitCHoosingLabel";
            this.chitCHoosingLabel.Size = new System.Drawing.Size(112, 37);
            this.chitCHoosingLabel.TabIndex = 4;
            this.chitCHoosingLabel.Text = "label1";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.chitCHoosingLabel);
            this.Controls.Add(this.chit4);
            this.Controls.Add(this.chit3);
            this.Controls.Add(this.chit2);
            this.Controls.Add(this.chit1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "GameForm";
            this.Size = new System.Drawing.Size(450, 350);
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
    }
}
