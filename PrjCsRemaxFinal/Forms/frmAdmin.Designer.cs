
namespace PrjCsRemaxFinal.Forms
{
    partial class frmAdmin
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
            this.gridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSrAgent = new System.Windows.Forms.Button();
            this.btnSrBuyer = new System.Windows.Forms.Button();
            this.btnSrSeller = new System.Windows.Forms.Button();
            this.btnSrHouse = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDispAgents = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnShowAllAgents = new System.Windows.Forms.Button();
            this.btnShowAllClients = new System.Windows.Forms.Button();
            this.btnShowAllHouses = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblJD = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.dtpJoinD = new System.Windows.Forms.DateTimePicker();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblEntries = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(18, 409);
            this.gridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 62;
            this.gridView.Size = new System.Drawing.Size(1059, 202);
            this.gridView.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(705, 318);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(316, 29);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter an Agent Number/Client Number/House Number to search:";
            // 
            // btnSrAgent
            // 
            this.btnSrAgent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrAgent.Location = new System.Drawing.Point(22, 354);
            this.btnSrAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrAgent.Name = "btnSrAgent";
            this.btnSrAgent.Size = new System.Drawing.Size(188, 46);
            this.btnSrAgent.TabIndex = 4;
            this.btnSrAgent.Text = "Search Agent";
            this.btnSrAgent.UseVisualStyleBackColor = false;
            this.btnSrAgent.Click += new System.EventHandler(this.btnSrAgent_Click);
            // 
            // btnSrBuyer
            // 
            this.btnSrBuyer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrBuyer.Location = new System.Drawing.Point(243, 354);
            this.btnSrBuyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrBuyer.Name = "btnSrBuyer";
            this.btnSrBuyer.Size = new System.Drawing.Size(178, 46);
            this.btnSrBuyer.TabIndex = 5;
            this.btnSrBuyer.Text = "Search Buyer";
            this.btnSrBuyer.UseVisualStyleBackColor = false;
            this.btnSrBuyer.Click += new System.EventHandler(this.btnSrBuyer_Click);
            // 
            // btnSrSeller
            // 
            this.btnSrSeller.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrSeller.Location = new System.Drawing.Point(460, 354);
            this.btnSrSeller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrSeller.Name = "btnSrSeller";
            this.btnSrSeller.Size = new System.Drawing.Size(178, 46);
            this.btnSrSeller.TabIndex = 6;
            this.btnSrSeller.Text = "Search Seller";
            this.btnSrSeller.UseVisualStyleBackColor = false;
            this.btnSrSeller.Click += new System.EventHandler(this.btnSrSeller_Click);
            // 
            // btnSrHouse
            // 
            this.btnSrHouse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrHouse.Location = new System.Drawing.Point(676, 354);
            this.btnSrHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrHouse.Name = "btnSrHouse";
            this.btnSrHouse.Size = new System.Drawing.Size(178, 46);
            this.btnSrHouse.TabIndex = 7;
            this.btnSrHouse.Text = "Search House";
            this.btnSrHouse.UseVisualStyleBackColor = false;
            this.btnSrHouse.Click += new System.EventHandler(this.btnSrHouse_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(898, 354);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 46);
            this.button5.TabIndex = 8;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDispAgents
            // 
            this.btnDispAgents.BackColor = System.Drawing.Color.Azure;
            this.btnDispAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispAgents.Location = new System.Drawing.Point(18, 18);
            this.btnDispAgents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispAgents.Name = "btnDispAgents";
            this.btnDispAgents.Size = new System.Drawing.Size(228, 46);
            this.btnDispAgents.TabIndex = 9;
            this.btnDispAgents.Text = "Display Agents";
            this.btnDispAgents.UseVisualStyleBackColor = false;
            this.btnDispAgents.Click += new System.EventHandler(this.btnDispAgents_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Azure;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 74);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 46);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add an Agent";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Azure;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(18, 129);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(228, 46);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Agent Info";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Azure;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(18, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(228, 46);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete an Agent";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(849, 129);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 46);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(849, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 46);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShowAllAgents
            // 
            this.btnShowAllAgents.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowAllAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAgents.Location = new System.Drawing.Point(174, 268);
            this.btnShowAllAgents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllAgents.Name = "btnShowAllAgents";
            this.btnShowAllAgents.Size = new System.Drawing.Size(228, 46);
            this.btnShowAllAgents.TabIndex = 15;
            this.btnShowAllAgents.Text = "Show all Agents";
            this.btnShowAllAgents.UseVisualStyleBackColor = false;
            this.btnShowAllAgents.Click += new System.EventHandler(this.btnShowAllAgents_Click);
            // 
            // btnShowAllClients
            // 
            this.btnShowAllClients.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowAllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllClients.Location = new System.Drawing.Point(411, 268);
            this.btnShowAllClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllClients.Name = "btnShowAllClients";
            this.btnShowAllClients.Size = new System.Drawing.Size(228, 46);
            this.btnShowAllClients.TabIndex = 16;
            this.btnShowAllClients.Text = "Show all Clients";
            this.btnShowAllClients.UseVisualStyleBackColor = false;
            this.btnShowAllClients.Click += new System.EventHandler(this.btnShowAllClients_Click);
            // 
            // btnShowAllHouses
            // 
            this.btnShowAllHouses.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowAllHouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllHouses.Location = new System.Drawing.Point(648, 268);
            this.btnShowAllHouses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllHouses.Name = "btnShowAllHouses";
            this.btnShowAllHouses.Size = new System.Drawing.Size(228, 46);
            this.btnShowAllHouses.TabIndex = 17;
            this.btnShowAllHouses.Text = "Show all Houses";
            this.btnShowAllHouses.UseVisualStyleBackColor = false;
            this.btnShowAllHouses.Click += new System.EventHandler(this.btnShowAllHouses_Click);
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(288, 29);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(114, 31);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Agent ID:";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(288, 85);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(158, 31);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Agent Name:";
            // 
            // lblPwd
            // 
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(288, 140);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(158, 31);
            this.lblPwd.TabIndex = 20;
            this.lblPwd.Text = "Password:";
            // 
            // lblJD
            // 
            this.lblJD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJD.Location = new System.Drawing.Point(288, 195);
            this.lblJD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJD.Name = "lblJD";
            this.lblJD.Size = new System.Drawing.Size(158, 31);
            this.lblJD.TabIndex = 21;
            this.lblJD.Text = "Join Date:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(460, 28);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(312, 35);
            this.txtId.TabIndex = 22;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(460, 83);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(312, 35);
            this.txtname.TabIndex = 23;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(460, 138);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(312, 35);
            this.txtPwd.TabIndex = 24;
            // 
            // dtpJoinD
            // 
            this.dtpJoinD.Location = new System.Drawing.Point(460, 189);
            this.dtpJoinD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpJoinD.Name = "dtpJoinD";
            this.dtpJoinD.Size = new System.Drawing.Size(312, 26);
            this.dtpJoinD.TabIndex = 25;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(292, 231);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(112, 35);
            this.btnFirst.TabIndex = 26;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(414, 231);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(112, 35);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(536, 231);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 35);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(657, 229);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(112, 35);
            this.btnLast.TabIndex = 29;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblEntries
            // 
            this.lblEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntries.Location = new System.Drawing.Point(844, 14);
            this.lblEntries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(232, 111);
            this.lblEntries.TabIndex = 30;
            this.lblEntries.Text = "Showing entry out of entries";
            this.lblEntries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(400, 619);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(296, 43);
            this.btnExit.TabIndex = 53;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 673);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.dtpJoinD);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblJD);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnShowAllHouses);
            this.Controls.Add(this.btnShowAllClients);
            this.Controls.Add(this.btnShowAllAgents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDispAgents);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSrHouse);
            this.Controls.Add(this.btnSrSeller);
            this.Controls.Add(this.btnSrBuyer);
            this.Controls.Add(this.btnSrAgent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridView);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSrAgent;
        private System.Windows.Forms.Button btnSrBuyer;
        private System.Windows.Forms.Button btnSrSeller;
        private System.Windows.Forms.Button btnSrHouse;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDispAgents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnShowAllAgents;
        private System.Windows.Forms.Button btnShowAllClients;
        private System.Windows.Forms.Button btnShowAllHouses;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblJD;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.DateTimePicker dtpJoinD;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.Button btnExit;
    }
}