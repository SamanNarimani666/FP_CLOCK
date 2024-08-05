namespace FPClient
{
    partial class EnrollDataManagement
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.btnClearAllData = new System.Windows.Forms.Button();
            this.btnRmAllManager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcompanyString = new System.Windows.Forms.TextBox();
            this.btnSetCompanyString = new System.Windows.Forms.Button();
            this.btnDelCompanyString = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEnrollNum = new System.Windows.Forms.TextBox();
            this.cmbBackupNum = new System.Windows.Forms.ComboBox();
            this.cmbEMachineNum = new System.Windows.Forms.ComboBox();
            this.lable12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCardNum = new System.Windows.Forms.TextBox();
            this.cmbPrivilege = new System.Windows.Forms.ComboBox();
            this.tbEnrollName = new System.Windows.Forms.TextBox();
            this.btnGetUserName = new System.Windows.Forms.Button();
            this.btnSetUserName = new System.Windows.Forms.Button();
            this.btnModifyPrivilege = new System.Windows.Forms.Button();
            this.btnGetEnroll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendAllEnrollData = new System.Windows.Forms.Button();
            this.btnDelDBData = new System.Windows.Forms.Button();
            this.btnSetAllEnData = new System.Windows.Forms.Button();
            this.btnGetAllEnData = new System.Windows.Forms.Button();
            this.btnSetEnrollData = new System.Windows.Forms.Button();
            this.btnGetEnrollData = new System.Windows.Forms.Button();
            this.btnDelEnData = new System.Windows.Forms.Button();
            this.btnUDiskDownLoad = new System.Windows.Forms.Button();
            this.btnUDiskUpload = new System.Windows.Forms.Button();
            this.btnEmptyEnData = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSetUserProfile = new System.Windows.Forms.Button();
            this.btnGetUserProfile = new System.Windows.Forms.Button();
            this.btnEnableUser = new System.Windows.Forms.Button();
            this.btnDisEnableUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelInfo.Location = new System.Drawing.Point(28, 10);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(344, 33);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearAllData
            // 
            this.btnClearAllData.Location = new System.Drawing.Point(458, 2);
            this.btnClearAllData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearAllData.Name = "btnClearAllData";
            this.btnClearAllData.Size = new System.Drawing.Size(118, 42);
            this.btnClearAllData.TabIndex = 1;
            this.btnClearAllData.Text = "Clear All Data(E,GL,SL) ";
            this.btnClearAllData.UseVisualStyleBackColor = true;
            this.btnClearAllData.Click += new System.EventHandler(this.btnClearAllData_Click);
            // 
            // btnRmAllManager
            // 
            this.btnRmAllManager.Location = new System.Drawing.Point(617, 2);
            this.btnRmAllManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRmAllManager.Name = "btnRmAllManager";
            this.btnRmAllManager.Size = new System.Drawing.Size(107, 42);
            this.btnRmAllManager.TabIndex = 1;
            this.btnRmAllManager.Text = "Benumb All Manager";
            this.btnRmAllManager.UseVisualStyleBackColor = true;
            this.btnRmAllManager.Click += new System.EventHandler(this.btnRmAllManager_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company Name:";
            // 
            // tbcompanyString
            // 
            this.tbcompanyString.Location = new System.Drawing.Point(124, 82);
            this.tbcompanyString.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbcompanyString.Name = "tbcompanyString";
            this.tbcompanyString.Size = new System.Drawing.Size(199, 20);
            this.tbcompanyString.TabIndex = 3;
            // 
            // btnSetCompanyString
            // 
            this.btnSetCompanyString.Location = new System.Drawing.Point(388, 85);
            this.btnSetCompanyString.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetCompanyString.Name = "btnSetCompanyString";
            this.btnSetCompanyString.Size = new System.Drawing.Size(76, 19);
            this.btnSetCompanyString.TabIndex = 4;
            this.btnSetCompanyString.Text = "SetString";
            this.btnSetCompanyString.UseVisualStyleBackColor = true;
            this.btnSetCompanyString.Click += new System.EventHandler(this.btnSetCompanyString_Click);
            // 
            // btnDelCompanyString
            // 
            this.btnDelCompanyString.Location = new System.Drawing.Point(537, 85);
            this.btnDelCompanyString.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelCompanyString.Name = "btnDelCompanyString";
            this.btnDelCompanyString.Size = new System.Drawing.Size(92, 19);
            this.btnDelCompanyString.TabIndex = 4;
            this.btnDelCompanyString.Text = "Del String";
            this.btnDelCompanyString.UseVisualStyleBackColor = true;
            this.btnDelCompanyString.Click += new System.EventHandler(this.btnDelCompanyString_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(777, 2);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(9, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(777, 2);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enroll Num:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "EMechine Num:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "BackupNum:";
            // 
            // tbEnrollNum
            // 
            this.tbEnrollNum.Location = new System.Drawing.Point(124, 137);
            this.tbEnrollNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEnrollNum.Name = "tbEnrollNum";
            this.tbEnrollNum.Size = new System.Drawing.Size(76, 20);
            this.tbEnrollNum.TabIndex = 6;
            this.tbEnrollNum.Text = "1";
            // 
            // cmbBackupNum
            // 
            this.cmbBackupNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackupNum.FormattingEnabled = true;
            this.cmbBackupNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "50"});
            this.cmbBackupNum.Location = new System.Drawing.Point(124, 212);
            this.cmbBackupNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBackupNum.Name = "cmbBackupNum";
            this.cmbBackupNum.Size = new System.Drawing.Size(76, 21);
            this.cmbBackupNum.TabIndex = 7;
            // 
            // cmbEMachineNum
            // 
            this.cmbEMachineNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEMachineNum.FormattingEnabled = true;
            this.cmbEMachineNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbEMachineNum.Location = new System.Drawing.Point(124, 178);
            this.cmbEMachineNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEMachineNum.Name = "cmbEMachineNum";
            this.cmbEMachineNum.Size = new System.Drawing.Size(76, 21);
            this.cmbEMachineNum.TabIndex = 7;
            // 
            // lable12
            // 
            this.lable12.AutoSize = true;
            this.lable12.Location = new System.Drawing.Point(313, 146);
            this.lable12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable12.Name = "lable12";
            this.lable12.Size = new System.Drawing.Size(67, 13);
            this.lable12.TabIndex = 2;
            this.lable12.Text = "Enroll Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Privilege:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 215);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Card Number:";
            // 
            // tbCardNum
            // 
            this.tbCardNum.Location = new System.Drawing.Point(419, 215);
            this.tbCardNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCardNum.Name = "tbCardNum";
            this.tbCardNum.Size = new System.Drawing.Size(76, 20);
            this.tbCardNum.TabIndex = 6;
            // 
            // cmbPrivilege
            // 
            this.cmbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrivilege.FormattingEnabled = true;
            this.cmbPrivilege.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmbPrivilege.Location = new System.Drawing.Point(419, 178);
            this.cmbPrivilege.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPrivilege.Name = "cmbPrivilege";
            this.cmbPrivilege.Size = new System.Drawing.Size(76, 21);
            this.cmbPrivilege.TabIndex = 7;
            // 
            // tbEnrollName
            // 
            this.tbEnrollName.Location = new System.Drawing.Point(419, 144);
            this.tbEnrollName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEnrollName.Name = "tbEnrollName";
            this.tbEnrollName.Size = new System.Drawing.Size(76, 20);
            this.tbEnrollName.TabIndex = 6;
            // 
            // btnGetUserName
            // 
            this.btnGetUserName.Location = new System.Drawing.Point(569, 143);
            this.btnGetUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetUserName.Name = "btnGetUserName";
            this.btnGetUserName.Size = new System.Drawing.Size(92, 19);
            this.btnGetUserName.TabIndex = 4;
            this.btnGetUserName.Text = "GetUserName";
            this.btnGetUserName.UseVisualStyleBackColor = true;
            this.btnGetUserName.Click += new System.EventHandler(this.btnGetUserName_Click);
            // 
            // btnSetUserName
            // 
            this.btnSetUserName.Location = new System.Drawing.Point(692, 143);
            this.btnSetUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetUserName.Name = "btnSetUserName";
            this.btnSetUserName.Size = new System.Drawing.Size(84, 19);
            this.btnSetUserName.TabIndex = 4;
            this.btnSetUserName.Text = "SetUserName";
            this.btnSetUserName.UseVisualStyleBackColor = true;
            this.btnSetUserName.Click += new System.EventHandler(this.btnSetUserName_Click);
            // 
            // btnModifyPrivilege
            // 
            this.btnModifyPrivilege.Location = new System.Drawing.Point(682, 180);
            this.btnModifyPrivilege.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifyPrivilege.Name = "btnModifyPrivilege";
            this.btnModifyPrivilege.Size = new System.Drawing.Size(104, 35);
            this.btnModifyPrivilege.TabIndex = 4;
            this.btnModifyPrivilege.Text = "ModifyPrivilege";
            this.btnModifyPrivilege.UseVisualStyleBackColor = true;
            this.btnModifyPrivilege.Click += new System.EventHandler(this.btnModifyPrivilege_Click);
            // 
            // btnGetEnroll
            // 
            this.btnGetEnroll.Location = new System.Drawing.Point(557, 180);
            this.btnGetEnroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetEnroll.Name = "btnGetEnroll";
            this.btnGetEnroll.Size = new System.Drawing.Size(111, 35);
            this.btnGetEnroll.TabIndex = 4;
            this.btnGetEnroll.Text = "Get Enroll Info";
            this.btnGetEnroll.UseVisualStyleBackColor = true;
            this.btnGetEnroll.Click += new System.EventHandler(this.btnGetEnrollInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendAllEnrollData);
            this.groupBox1.Controls.Add(this.btnDelDBData);
            this.groupBox1.Controls.Add(this.btnSetAllEnData);
            this.groupBox1.Controls.Add(this.btnGetAllEnData);
            this.groupBox1.Location = new System.Drawing.Point(543, 261);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(118, 184);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB operation";
            // 
            // btnSendAllEnrollData
            // 
            this.btnSendAllEnrollData.Location = new System.Drawing.Point(14, 104);
            this.btnSendAllEnrollData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSendAllEnrollData.Name = "btnSendAllEnrollData";
            this.btnSendAllEnrollData.Size = new System.Drawing.Size(92, 36);
            this.btnSendAllEnrollData.TabIndex = 4;
            this.btnSendAllEnrollData.Text = "Send All Enroll Data";
            this.btnSendAllEnrollData.UseVisualStyleBackColor = true;
            this.btnSendAllEnrollData.Click += new System.EventHandler(this.btnSendAllEnrollData_Click);
            // 
            // btnDelDBData
            // 
            this.btnDelDBData.Location = new System.Drawing.Point(14, 146);
            this.btnDelDBData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelDBData.Name = "btnDelDBData";
            this.btnDelDBData.Size = new System.Drawing.Size(92, 34);
            this.btnDelDBData.TabIndex = 4;
            this.btnDelDBData.Text = "Delete DB Data";
            this.btnDelDBData.UseVisualStyleBackColor = true;
            this.btnDelDBData.Click += new System.EventHandler(this.btnDelDBData_Click);
            // 
            // btnSetAllEnData
            // 
            this.btnSetAllEnData.Location = new System.Drawing.Point(14, 62);
            this.btnSetAllEnData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetAllEnData.Name = "btnSetAllEnData";
            this.btnSetAllEnData.Size = new System.Drawing.Size(92, 36);
            this.btnSetAllEnData.TabIndex = 4;
            this.btnSetAllEnData.Text = "Set All Enroll Data";
            this.btnSetAllEnData.UseVisualStyleBackColor = true;
            this.btnSetAllEnData.Click += new System.EventHandler(this.btnSetAllEnData_Click);
            // 
            // btnGetAllEnData
            // 
            this.btnGetAllEnData.Location = new System.Drawing.Point(14, 21);
            this.btnGetAllEnData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetAllEnData.Name = "btnGetAllEnData";
            this.btnGetAllEnData.Size = new System.Drawing.Size(92, 36);
            this.btnGetAllEnData.TabIndex = 4;
            this.btnGetAllEnData.Text = "Get All Enroll Data";
            this.btnGetAllEnData.UseVisualStyleBackColor = true;
            this.btnGetAllEnData.Click += new System.EventHandler(this.btnGetAllEnData_Click);
            // 
            // btnSetEnrollData
            // 
            this.btnSetEnrollData.Location = new System.Drawing.Point(685, 278);
            this.btnSetEnrollData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetEnrollData.Name = "btnSetEnrollData";
            this.btnSetEnrollData.Size = new System.Drawing.Size(101, 42);
            this.btnSetEnrollData.TabIndex = 4;
            this.btnSetEnrollData.Text = "SetEnrollData";
            this.btnSetEnrollData.UseVisualStyleBackColor = true;
            this.btnSetEnrollData.Click += new System.EventHandler(this.btnSetEnrollData_Click);
            // 
            // btnGetEnrollData
            // 
            this.btnGetEnrollData.Location = new System.Drawing.Point(685, 229);
            this.btnGetEnrollData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetEnrollData.Name = "btnGetEnrollData";
            this.btnGetEnrollData.Size = new System.Drawing.Size(101, 42);
            this.btnGetEnrollData.TabIndex = 4;
            this.btnGetEnrollData.Text = "GetEnrollData";
            this.btnGetEnrollData.UseVisualStyleBackColor = true;
            this.btnGetEnrollData.Click += new System.EventHandler(this.btnGetEnrollData_Click);
            // 
            // btnDelEnData
            // 
            this.btnDelEnData.Location = new System.Drawing.Point(685, 343);
            this.btnDelEnData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelEnData.Name = "btnDelEnData";
            this.btnDelEnData.Size = new System.Drawing.Size(101, 42);
            this.btnDelEnData.TabIndex = 4;
            this.btnDelEnData.Text = "Delete Enroll Data";
            this.btnDelEnData.UseVisualStyleBackColor = true;
            this.btnDelEnData.Click += new System.EventHandler(this.btnDelEnData_Click);
            // 
            // btnUDiskDownLoad
            // 
            this.btnUDiskDownLoad.Location = new System.Drawing.Point(685, 400);
            this.btnUDiskDownLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUDiskDownLoad.Name = "btnUDiskDownLoad";
            this.btnUDiskDownLoad.Size = new System.Drawing.Size(101, 42);
            this.btnUDiskDownLoad.TabIndex = 4;
            this.btnUDiskDownLoad.Text = "U disk Download";
            this.btnUDiskDownLoad.UseVisualStyleBackColor = true;
            this.btnUDiskDownLoad.Click += new System.EventHandler(this.btnUDiskDownLoad_Click);
            // 
            // btnUDiskUpload
            // 
            this.btnUDiskUpload.Location = new System.Drawing.Point(685, 454);
            this.btnUDiskUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUDiskUpload.Name = "btnUDiskUpload";
            this.btnUDiskUpload.Size = new System.Drawing.Size(101, 42);
            this.btnUDiskUpload.TabIndex = 4;
            this.btnUDiskUpload.Text = "U disk Upload";
            this.btnUDiskUpload.UseVisualStyleBackColor = true;
            this.btnUDiskUpload.Click += new System.EventHandler(this.btnUDiskUpload_Click);
            // 
            // btnEmptyEnData
            // 
            this.btnEmptyEnData.Location = new System.Drawing.Point(685, 510);
            this.btnEmptyEnData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmptyEnData.Name = "btnEmptyEnData";
            this.btnEmptyEnData.Size = new System.Drawing.Size(101, 42);
            this.btnEmptyEnData.TabIndex = 4;
            this.btnEmptyEnData.Text = "Empty Enroll Data";
            this.btnEmptyEnData.UseVisualStyleBackColor = true;
            this.btnEmptyEnData.Click += new System.EventHandler(this.btnEmptyEnData_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 294);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 342);
            this.listBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(419, 251);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(76, 20);
            this.tbPassword.TabIndex = 12;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(685, 574);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(101, 28);
            this.btnAddUser.TabIndex = 25;
            this.btnAddUser.Text = "AddUser";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSetUserProfile
            // 
            this.btnSetUserProfile.Location = new System.Drawing.Point(545, 465);
            this.btnSetUserProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetUserProfile.Name = "btnSetUserProfile";
            this.btnSetUserProfile.Size = new System.Drawing.Size(104, 31);
            this.btnSetUserProfile.TabIndex = 26;
            this.btnSetUserProfile.Text = "SetUserProfile";
            this.btnSetUserProfile.UseVisualStyleBackColor = true;
            this.btnSetUserProfile.Click += new System.EventHandler(this.btnSetUserProfile_Click);
            // 
            // btnGetUserProfile
            // 
            this.btnGetUserProfile.Location = new System.Drawing.Point(545, 510);
            this.btnGetUserProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetUserProfile.Name = "btnGetUserProfile";
            this.btnGetUserProfile.Size = new System.Drawing.Size(104, 31);
            this.btnGetUserProfile.TabIndex = 27;
            this.btnGetUserProfile.Text = "GetUserProfile";
            this.btnGetUserProfile.UseVisualStyleBackColor = true;
            this.btnGetUserProfile.Click += new System.EventHandler(this.btnGetUserProfile_Click);
            // 
            // btnEnableUser
            // 
            this.btnEnableUser.Location = new System.Drawing.Point(545, 561);
            this.btnEnableUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnableUser.Name = "btnEnableUser";
            this.btnEnableUser.Size = new System.Drawing.Size(102, 19);
            this.btnEnableUser.TabIndex = 28;
            this.btnEnableUser.Text = "EnableUser";
            this.btnEnableUser.UseVisualStyleBackColor = true;
            this.btnEnableUser.Click += new System.EventHandler(this.btnEnableUser_Click);
            // 
            // btnDisEnableUser
            // 
            this.btnDisEnableUser.Location = new System.Drawing.Point(547, 601);
            this.btnDisEnableUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisEnableUser.Name = "btnDisEnableUser";
            this.btnDisEnableUser.Size = new System.Drawing.Size(102, 19);
            this.btnDisEnableUser.TabIndex = 29;
            this.btnDisEnableUser.Text = "DisEnableUser";
            this.btnDisEnableUser.UseVisualStyleBackColor = true;
            this.btnDisEnableUser.Click += new System.EventHandler(this.btnDisEnableUser_Click);
            // 
            // EnrollDataManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 646);
            this.Controls.Add(this.btnDisEnableUser);
            this.Controls.Add(this.btnEnableUser);
            this.Controls.Add(this.btnGetUserProfile);
            this.Controls.Add(this.btnSetUserProfile);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPrivilege);
            this.Controls.Add(this.cmbEMachineNum);
            this.Controls.Add(this.cmbBackupNum);
            this.Controls.Add(this.tbEnrollName);
            this.Controls.Add(this.tbCardNum);
            this.Controls.Add(this.tbEnrollNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelCompanyString);
            this.Controls.Add(this.btnModifyPrivilege);
            this.Controls.Add(this.btnSetUserName);
            this.Controls.Add(this.btnEmptyEnData);
            this.Controls.Add(this.btnUDiskUpload);
            this.Controls.Add(this.btnUDiskDownLoad);
            this.Controls.Add(this.btnDelEnData);
            this.Controls.Add(this.btnGetEnrollData);
            this.Controls.Add(this.btnSetEnrollData);
            this.Controls.Add(this.btnGetEnroll);
            this.Controls.Add(this.btnGetUserName);
            this.Controls.Add(this.btnSetCompanyString);
            this.Controls.Add(this.tbcompanyString);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lable12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRmAllManager);
            this.Controls.Add(this.btnClearAllData);
            this.Controls.Add(this.labelInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EnrollDataManagement";
            this.Text = "EnrollDataManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnrollDataManagement_FormClosed);
            this.Load += new System.EventHandler(this.EnrollDataManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btnClearAllData;
        private System.Windows.Forms.Button btnRmAllManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbcompanyString;
        private System.Windows.Forms.Button btnSetCompanyString;
        private System.Windows.Forms.Button btnDelCompanyString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEnrollNum;
        private System.Windows.Forms.ComboBox cmbBackupNum;
        private System.Windows.Forms.ComboBox cmbEMachineNum;
        private System.Windows.Forms.Label lable12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCardNum;
        private System.Windows.Forms.ComboBox cmbPrivilege;
        private System.Windows.Forms.TextBox tbEnrollName;
        private System.Windows.Forms.Button btnGetUserName;
        private System.Windows.Forms.Button btnSetUserName;
        private System.Windows.Forms.Button btnModifyPrivilege;
        private System.Windows.Forms.Button btnGetEnroll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSendAllEnrollData;
        private System.Windows.Forms.Button btnDelDBData;
        private System.Windows.Forms.Button btnSetAllEnData;
        private System.Windows.Forms.Button btnGetAllEnData;
        private System.Windows.Forms.Button btnSetEnrollData;
        private System.Windows.Forms.Button btnGetEnrollData;
        private System.Windows.Forms.Button btnDelEnData;
        private System.Windows.Forms.Button btnUDiskDownLoad;
        private System.Windows.Forms.Button btnUDiskUpload;
        private System.Windows.Forms.Button btnEmptyEnData;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSetUserProfile;
        private System.Windows.Forms.Button btnGetUserProfile;
        private System.Windows.Forms.Button btnEnableUser;
        private System.Windows.Forms.Button btnDisEnableUser;
    }
}