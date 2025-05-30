
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
            mainPanel = new System.Windows.Forms.Panel();
            splitContainerMain = new System.Windows.Forms.SplitContainer();
            scoreTableDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scoreTableDataGrid).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            mainPanel.Location = new System.Drawing.Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new System.Drawing.Size(632, 591);
            mainPanel.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerMain.Location = new System.Drawing.Point(0, 0);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(mainPanel);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(scoreTableDataGrid);
            splitContainerMain.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainerMain.Size = new System.Drawing.Size(1104, 591);
            splitContainerMain.SplitterDistance = 632;
            splitContainerMain.TabIndex = 2;
            // 
            // scoreTableDataGrid
            // 
            scoreTableDataGrid.AllowUserToDeleteRows = false;
            scoreTableDataGrid.AllowUserToResizeColumns = false;
            scoreTableDataGrid.AllowUserToResizeRows = false;
            scoreTableDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            scoreTableDataGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            scoreTableDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            scoreTableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scoreTableDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            scoreTableDataGrid.Enabled = false;
            scoreTableDataGrid.Location = new System.Drawing.Point(0, 0);
            scoreTableDataGrid.Name = "scoreTableDataGrid";
            scoreTableDataGrid.RowTemplate.Height = 25;
            scoreTableDataGrid.Size = new System.Drawing.Size(468, 591);
            scoreTableDataGrid.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1104, 591);
            Controls.Add(splitContainerMain);
            Name = "MainForm";
            Text = "Chor Police";
            Load += MainForm_Load;
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scoreTableDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.DataGridView scoreTableDataGrid;
    }
}

