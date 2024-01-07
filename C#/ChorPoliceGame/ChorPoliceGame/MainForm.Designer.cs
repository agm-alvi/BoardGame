
namespace ChorPoliceGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.scoreTableDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTableDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(600, 580);
            this.mainPanel.TabIndex = 0;
            // 
            // scoreTableDataGrid
            // 
            this.scoreTableDataGrid.AllowUserToDeleteRows = false;
            this.scoreTableDataGrid.AllowUserToResizeColumns = false;
            this.scoreTableDataGrid.AllowUserToResizeRows = false;
            this.scoreTableDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scoreTableDataGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.scoreTableDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.scoreTableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreTableDataGrid.Enabled = false;
            this.scoreTableDataGrid.Location = new System.Drawing.Point(612, 3);
            this.scoreTableDataGrid.Name = "scoreTableDataGrid";
            this.scoreTableDataGrid.RowTemplate.Height = 25;
            this.scoreTableDataGrid.Size = new System.Drawing.Size(480, 580);
            this.scoreTableDataGrid.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.scoreTableDataGrid);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "Chor Police";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreTableDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView scoreTableDataGrid;
    }
}

