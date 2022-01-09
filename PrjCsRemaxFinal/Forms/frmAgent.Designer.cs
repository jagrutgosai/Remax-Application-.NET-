
namespace PrjCsRemaxFinal.Forms
{
    partial class frmAgent
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
            this.lblEntries = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnShowAllHouses = new System.Windows.Forms.Button();
            this.btnShowAllClients = new System.Windows.Forms.Button();
            this.btnShowAllAgents = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteBuy = new System.Windows.Forms.Button();
            this.btnEditBuy = new System.Windows.Forms.Button();
            this.btnAddBuy = new System.Windows.Forms.Button();
            this.btnDispBuyers = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSrHouse = new System.Windows.Forms.Button();
            this.btnSrSeller = new System.Windows.Forms.Button();
            this.btnSrBuyer = new System.Windows.Forms.Button();
            this.btnSrAgent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnDispSellers = new System.Windows.Forms.Button();
            this.btnAddSel = new System.Windows.Forms.Button();
            this.btnEditSel = new System.Windows.Forms.Button();
            this.btnDeleteSel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntries
            // 
            this.lblEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntries.Location = new System.Drawing.Point(849, 12);
            this.lblEntries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(232, 111);
            this.lblEntries.TabIndex = 60;
            this.lblEntries.Text = "Showing entry out of entries";
            this.lblEntries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(679, 217);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(112, 35);
            this.btnLast.TabIndex = 59;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(558, 219);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 35);
            this.btnNext.TabIndex = 58;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(436, 219);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(112, 35);
            this.btnPrev.TabIndex = 57;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(314, 219);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(112, 35);
            this.btnFirst.TabIndex = 56;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(481, 136);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.Multiline = true;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(312, 35);
            this.txtPwd.TabIndex = 54;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(481, 81);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(312, 35);
            this.txtname.TabIndex = 53;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(481, 26);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(312, 35);
            this.txtId.TabIndex = 52;
            // 
            // lblPwd
            // 
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(309, 138);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(158, 31);
            this.lblPwd.TabIndex = 50;
            this.lblPwd.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(309, 83);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(158, 31);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Client Name:";
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(309, 27);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(114, 31);
            this.lblId.TabIndex = 48;
            this.lblId.Text = "Client ID:";
            // 
            // btnShowAllHouses
            // 
            this.btnShowAllHouses.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowAllHouses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllHouses.Location = new System.Drawing.Point(653, 266);
            this.btnShowAllHouses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllHouses.Name = "btnShowAllHouses";
            this.btnShowAllHouses.Size = new System.Drawing.Size(228, 46);
            this.btnShowAllHouses.TabIndex = 47;
            this.btnShowAllHouses.Text = "Show all Houses";
            this.btnShowAllHouses.UseVisualStyleBackColor = false;
            this.btnShowAllHouses.Click += new System.EventHandler(this.btnShowAllHouses_Click);
            // 
            // btnShowAllClients
            // 
            this.btnShowAllClients.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowAllClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllClients.Location = new System.Drawing.Point(416, 266);
            this.btnShowAllClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllClients.Name = "btnShowAllClients";
            this.btnShowAllClients.Size = new System.Drawing.Size(228, 46);
            this.btnShowAllClients.TabIndex = 46;
            this.btnShowAllClients.Text = "Show all Clients";
            this.btnShowAllClients.UseVisualStyleBackColor = false;
            this.btnShowAllClients.Click += new System.EventHandler(this.btnShowAllClients_Click);
            // 
            // btnShowAllAgents
            // 
            this.btnShowAllAgents.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShowAllAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllAgents.Location = new System.Drawing.Point(179, 266);
            this.btnShowAllAgents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAllAgents.Name = "btnShowAllAgents";
            this.btnShowAllAgents.Size = new System.Drawing.Size(228, 46);
            this.btnShowAllAgents.TabIndex = 45;
            this.btnShowAllAgents.Text = "Show all Agents";
            this.btnShowAllAgents.UseVisualStyleBackColor = false;
            this.btnShowAllAgents.Click += new System.EventHandler(this.btnShowAllAgents_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(854, 183);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 46);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(854, 127);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 46);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteBuy
            // 
            this.btnDeleteBuy.BackColor = System.Drawing.Color.Azure;
            this.btnDeleteBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBuy.Location = new System.Drawing.Point(23, 222);
            this.btnDeleteBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteBuy.Name = "btnDeleteBuy";
            this.btnDeleteBuy.Size = new System.Drawing.Size(128, 41);
            this.btnDeleteBuy.TabIndex = 42;
            this.btnDeleteBuy.Text = "Del Buyer";
            this.btnDeleteBuy.UseVisualStyleBackColor = false;
            this.btnDeleteBuy.Click += new System.EventHandler(this.btnDeleteBuy_Click);
            // 
            // btnEditBuy
            // 
            this.btnEditBuy.BackColor = System.Drawing.Color.Azure;
            this.btnEditBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBuy.Location = new System.Drawing.Point(23, 166);
            this.btnEditBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditBuy.Name = "btnEditBuy";
            this.btnEditBuy.Size = new System.Drawing.Size(128, 41);
            this.btnEditBuy.TabIndex = 41;
            this.btnEditBuy.Text = "Edit Buyer";
            this.btnEditBuy.UseVisualStyleBackColor = false;
            this.btnEditBuy.Click += new System.EventHandler(this.btnEditBuy_Click);
            // 
            // btnAddBuy
            // 
            this.btnAddBuy.BackColor = System.Drawing.Color.Azure;
            this.btnAddBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBuy.Location = new System.Drawing.Point(23, 111);
            this.btnAddBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBuy.Name = "btnAddBuy";
            this.btnAddBuy.Size = new System.Drawing.Size(128, 40);
            this.btnAddBuy.TabIndex = 40;
            this.btnAddBuy.Text = "Add Buyer";
            this.btnAddBuy.UseVisualStyleBackColor = false;
            this.btnAddBuy.Click += new System.EventHandler(this.btnAddBuy_Click);
            // 
            // btnDispBuyers
            // 
            this.btnDispBuyers.BackColor = System.Drawing.Color.Azure;
            this.btnDispBuyers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispBuyers.Location = new System.Drawing.Point(23, 14);
            this.btnDispBuyers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispBuyers.Name = "btnDispBuyers";
            this.btnDispBuyers.Size = new System.Drawing.Size(262, 44);
            this.btnDispBuyers.TabIndex = 39;
            this.btnDispBuyers.Text = "Display My Buyers";
            this.btnDispBuyers.UseVisualStyleBackColor = false;
            this.btnDispBuyers.Click += new System.EventHandler(this.btnDispBuyers_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(903, 352);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 46);
            this.button5.TabIndex = 38;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSrHouse
            // 
            this.btnSrHouse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrHouse.Location = new System.Drawing.Point(681, 352);
            this.btnSrHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrHouse.Name = "btnSrHouse";
            this.btnSrHouse.Size = new System.Drawing.Size(178, 46);
            this.btnSrHouse.TabIndex = 37;
            this.btnSrHouse.Text = "Search House";
            this.btnSrHouse.UseVisualStyleBackColor = false;
            this.btnSrHouse.Click += new System.EventHandler(this.btnSrHouse_Click);
            // 
            // btnSrSeller
            // 
            this.btnSrSeller.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrSeller.Location = new System.Drawing.Point(465, 352);
            this.btnSrSeller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrSeller.Name = "btnSrSeller";
            this.btnSrSeller.Size = new System.Drawing.Size(178, 46);
            this.btnSrSeller.TabIndex = 36;
            this.btnSrSeller.Text = "Search Seller";
            this.btnSrSeller.UseVisualStyleBackColor = false;
            this.btnSrSeller.Click += new System.EventHandler(this.btnSrSeller_Click);
            // 
            // btnSrBuyer
            // 
            this.btnSrBuyer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrBuyer.Location = new System.Drawing.Point(248, 352);
            this.btnSrBuyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrBuyer.Name = "btnSrBuyer";
            this.btnSrBuyer.Size = new System.Drawing.Size(178, 46);
            this.btnSrBuyer.TabIndex = 35;
            this.btnSrBuyer.Text = "Search Buyer";
            this.btnSrBuyer.UseVisualStyleBackColor = false;
            this.btnSrBuyer.Click += new System.EventHandler(this.btnSrBuyer_Click);
            // 
            // btnSrAgent
            // 
            this.btnSrAgent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSrAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrAgent.Location = new System.Drawing.Point(27, 352);
            this.btnSrAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrAgent.Name = "btnSrAgent";
            this.btnSrAgent.Size = new System.Drawing.Size(188, 46);
            this.btnSrAgent.TabIndex = 34;
            this.btnSrAgent.Text = "Search Agent";
            this.btnSrAgent.UseVisualStyleBackColor = false;
            this.btnSrAgent.Click += new System.EventHandler(this.btnSrAgent_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(678, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Enter an Agent Number/Client Number/House Number to search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(710, 316);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(316, 29);
            this.txtSearch.TabIndex = 32;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(23, 407);
            this.gridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 62;
            this.gridView.Size = new System.Drawing.Size(1059, 215);
            this.gridView.TabIndex = 31;
            // 
            // btnDispSellers
            // 
            this.btnDispSellers.BackColor = System.Drawing.Color.Azure;
            this.btnDispSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispSellers.Location = new System.Drawing.Point(25, 62);
            this.btnDispSellers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDispSellers.Name = "btnDispSellers";
            this.btnDispSellers.Size = new System.Drawing.Size(262, 44);
            this.btnDispSellers.TabIndex = 61;
            this.btnDispSellers.Text = "Display My Sellers";
            this.btnDispSellers.UseVisualStyleBackColor = false;
            this.btnDispSellers.Click += new System.EventHandler(this.btnDispSellers_Click);
            // 
            // btnAddSel
            // 
            this.btnAddSel.BackColor = System.Drawing.Color.Azure;
            this.btnAddSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSel.Location = new System.Drawing.Point(157, 111);
            this.btnAddSel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSel.Name = "btnAddSel";
            this.btnAddSel.Size = new System.Drawing.Size(128, 40);
            this.btnAddSel.TabIndex = 62;
            this.btnAddSel.Text = "Add Seller";
            this.btnAddSel.UseVisualStyleBackColor = false;
            this.btnAddSel.Click += new System.EventHandler(this.btnAddSel_Click);
            // 
            // btnEditSel
            // 
            this.btnEditSel.BackColor = System.Drawing.Color.Azure;
            this.btnEditSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSel.Location = new System.Drawing.Point(159, 166);
            this.btnEditSel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditSel.Name = "btnEditSel";
            this.btnEditSel.Size = new System.Drawing.Size(128, 41);
            this.btnEditSel.TabIndex = 63;
            this.btnEditSel.Text = "Edit Seller";
            this.btnEditSel.UseVisualStyleBackColor = false;
            this.btnEditSel.Click += new System.EventHandler(this.btnEditSel_Click);
            // 
            // btnDeleteSel
            // 
            this.btnDeleteSel.BackColor = System.Drawing.Color.Azure;
            this.btnDeleteSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSel.Location = new System.Drawing.Point(161, 222);
            this.btnDeleteSel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteSel.Name = "btnDeleteSel";
            this.btnDeleteSel.Size = new System.Drawing.Size(128, 41);
            this.btnDeleteSel.TabIndex = 64;
            this.btnDeleteSel.Text = "Del Seller";
            this.btnDeleteSel.UseVisualStyleBackColor = false;
            this.btnDeleteSel.Click += new System.EventHandler(this.btnDeleteSel_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(376, 630);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(337, 43);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 677);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteSel);
            this.Controls.Add(this.btnEditSel);
            this.Controls.Add(this.btnAddSel);
            this.Controls.Add(this.btnDispSellers);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnShowAllHouses);
            this.Controls.Add(this.btnShowAllClients);
            this.Controls.Add(this.btnShowAllAgents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteBuy);
            this.Controls.Add(this.btnEditBuy);
            this.Controls.Add(this.btnAddBuy);
            this.Controls.Add(this.btnDispBuyers);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSrHouse);
            this.Controls.Add(this.btnSrSeller);
            this.Controls.Add(this.btnSrBuyer);
            this.Controls.Add(this.btnSrAgent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridView);
            this.Name = "frmAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgent";
            this.Load += new System.EventHandler(this.frmAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnShowAllHouses;
        private System.Windows.Forms.Button btnShowAllClients;
        private System.Windows.Forms.Button btnShowAllAgents;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteBuy;
        private System.Windows.Forms.Button btnEditBuy;
        private System.Windows.Forms.Button btnAddBuy;
        private System.Windows.Forms.Button btnDispBuyers;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSrHouse;
        private System.Windows.Forms.Button btnSrSeller;
        private System.Windows.Forms.Button btnSrBuyer;
        private System.Windows.Forms.Button btnSrAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnDispSellers;
        private System.Windows.Forms.Button btnAddSel;
        private System.Windows.Forms.Button btnEditSel;
        private System.Windows.Forms.Button btnDeleteSel;
        private System.Windows.Forms.Button btnExit;
    }
}