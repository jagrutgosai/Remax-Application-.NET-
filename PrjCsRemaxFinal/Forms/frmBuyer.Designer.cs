
namespace PrjCsRemaxFinal.Forms
{
    partial class frmBuyer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAgentInfo = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnShowAllHouses = new System.Windows.Forms.Button();
            this.btnSrHouse = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(54, 14);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(610, 31);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome ";
            // 
            // lblAgentInfo
            // 
            this.lblAgentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentInfo.Location = new System.Drawing.Point(475, 405);
            this.lblAgentInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgentInfo.Name = "lblAgentInfo";
            this.lblAgentInfo.Size = new System.Drawing.Size(327, 31);
            this.lblAgentInfo.TabIndex = 5;
            this.lblAgentInfo.Text = "Your Agent:";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(18, 174);
            this.gridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 62;
            this.gridView.Size = new System.Drawing.Size(784, 209);
            this.gridView.TabIndex = 6;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // btnShowAllHouses
            // 
            this.btnShowAllHouses.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowAllHouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllHouses.Location = new System.Drawing.Point(18, 91);
            this.btnShowAllHouses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllHouses.Name = "btnShowAllHouses";
            this.btnShowAllHouses.Size = new System.Drawing.Size(228, 46);
            this.btnShowAllHouses.TabIndex = 18;
            this.btnShowAllHouses.Text = "Show all Houses";
            this.btnShowAllHouses.UseVisualStyleBackColor = false;
            this.btnShowAllHouses.Click += new System.EventHandler(this.btnShowAllHouses_Click);
            // 
            // btnSrHouse
            // 
            this.btnSrHouse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrHouse.Location = new System.Drawing.Point(478, 91);
            this.btnSrHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrHouse.Name = "btnSrHouse";
            this.btnSrHouse.Size = new System.Drawing.Size(178, 46);
            this.btnSrHouse.TabIndex = 19;
            this.btnSrHouse.Text = "Search House";
            this.btnSrHouse.UseVisualStyleBackColor = false;
            this.btnSrHouse.Click += new System.EventHandler(this.btnSrHouse_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(255, 100);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 29);
            this.txtSearch.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 51);
            this.label3.TabIndex = 21;
            this.label3.Text = "Enter a House Number below to search";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(666, 91);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 46);
            this.button5.TabIndex = 22;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Click on the house you\'re interested in below";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(694, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 43);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 455);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSrHouse);
            this.Controls.Add(this.btnShowAllHouses);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.lblAgentInfo);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuyer";
            this.Load += new System.EventHandler(this.frmBuyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAgentInfo;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnShowAllHouses;
        private System.Windows.Forms.Button btnSrHouse;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}