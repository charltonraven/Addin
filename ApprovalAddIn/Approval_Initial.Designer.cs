namespace ApprovalAddIn
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class Approval_Initial : Microsoft.Office.Tools.Outlook.FormRegionBase
    {
        public Approval_Initial(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
            : base(Globals.Factory, formRegion)
        {
            this.InitializeComponent();
        }

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            this.tabcApprovals = new System.Windows.Forms.TabControl();
            this.tabApprovals = new System.Windows.Forms.TabPage();
            this.tabCheckList = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChangeManagemntRequestNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTableParmNAME = new System.Windows.Forms.TextBox();
            this.txtCodeReviewBY = new System.Windows.Forms.TextBox();
            this.cbUserApproval = new System.Windows.Forms.CheckBox();
            this.cbtableParm = new System.Windows.Forms.CheckBox();
            this.cbTestingCompleted = new System.Windows.Forms.CheckBox();
            this.cbDevelopmentCompleted = new System.Windows.Forms.CheckBox();
            this.cbKeyUserSignOff = new System.Windows.Forms.CheckBox();
            this.cbPartnerSignOff = new System.Windows.Forms.CheckBox();
            this.cbPartnerApproval = new System.Windows.Forms.CheckBox();
            this.cbCodeReview = new System.Windows.Forms.CheckBox();
            this.txtCodeReviewDATE = new System.Windows.Forms.TextBox();
            this.grpPostReview = new System.Windows.Forms.GroupBox();
            this.rbInstalledP = new System.Windows.Forms.RadioButton();
            this.rbBackedOutP = new System.Windows.Forms.RadioButton();
            this.rbAbandonedP = new System.Windows.Forms.RadioButton();
            this.grpImplementationReview = new System.Windows.Forms.GroupBox();
            this.rbAbandonedI = new System.Windows.Forms.RadioButton();
            this.rbBackedOutI = new System.Windows.Forms.RadioButton();
            this.rbInstalledI = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cbEnvelopes = new System.Windows.Forms.CheckBox();
            this.cbEmailCodeList = new System.Windows.Forms.CheckBox();
            this.cbPerlScripts = new System.Windows.Forms.CheckBox();
            this.cbRAILStable = new System.Windows.Forms.CheckBox();
            this.cbTRANSPORTparmfile = new System.Windows.Forms.CheckBox();
            this.cbFTPconnect = new System.Windows.Forms.CheckBox();
            this.cbFileStructureInProduction = new System.Windows.Forms.CheckBox();
            this.cbRAILSfilter = new System.Windows.Forms.CheckBox();
            this.cbRAILSrecord = new System.Windows.Forms.CheckBox();
            this.cbBusinessProcess = new System.Windows.Forms.CheckBox();
            this.cbServiceAdapter = new System.Windows.Forms.CheckBox();
            this.cbDocumentExtractionMap = new System.Windows.Forms.CheckBox();
            this.cbDocumentMap = new System.Windows.Forms.CheckBox();
            this.cbMapCodeTables = new System.Windows.Forms.CheckBox();
            this.cbXSLTEmailErrorHeader = new System.Windows.Forms.CheckBox();
            this.txtPerlScripts = new System.Windows.Forms.TextBox();
            this.tabReview = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtProjectManager = new System.Windows.Forms.TextBox();
            this.txtCompletionDate = new System.Windows.Forms.TextBox();
            this.tabcApprovals.SuspendLayout();
            this.tabApprovals.SuspendLayout();
            this.tabCheckList.SuspendLayout();
            this.grpPostReview.SuspendLayout();
            this.grpImplementationReview.SuspendLayout();
            this.tabReview.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcApprovals
            // 
            this.tabcApprovals.Controls.Add(this.tabApprovals);
            this.tabcApprovals.Controls.Add(this.tabCheckList);
            this.tabcApprovals.Controls.Add(this.tabReview);
            this.tabcApprovals.Location = new System.Drawing.Point(23, 23);
            this.tabcApprovals.Name = "tabcApprovals";
            this.tabcApprovals.SelectedIndex = 0;
            this.tabcApprovals.Size = new System.Drawing.Size(1053, 627);
            this.tabcApprovals.TabIndex = 0;
            // 
            // tabApprovals
            // 
            this.tabApprovals.BackColor = System.Drawing.Color.SlateGray;
            this.tabApprovals.Controls.Add(this.grpImplementationReview);
            this.tabApprovals.Controls.Add(this.grpPostReview);
            this.tabApprovals.Controls.Add(this.txtCodeReviewDATE);
            this.tabApprovals.Controls.Add(this.cbCodeReview);
            this.tabApprovals.Controls.Add(this.cbPartnerApproval);
            this.tabApprovals.Controls.Add(this.cbPartnerSignOff);
            this.tabApprovals.Controls.Add(this.cbKeyUserSignOff);
            this.tabApprovals.Controls.Add(this.cbDevelopmentCompleted);
            this.tabApprovals.Controls.Add(this.cbTestingCompleted);
            this.tabApprovals.Controls.Add(this.cbtableParm);
            this.tabApprovals.Controls.Add(this.cbUserApproval);
            this.tabApprovals.Controls.Add(this.txtCodeReviewBY);
            this.tabApprovals.Controls.Add(this.txtTableParmNAME);
            this.tabApprovals.Controls.Add(this.label14);
            this.tabApprovals.Controls.Add(this.label13);
            this.tabApprovals.Controls.Add(this.label12);
            this.tabApprovals.Controls.Add(this.label11);
            this.tabApprovals.Controls.Add(this.label10);
            this.tabApprovals.Controls.Add(this.label9);
            this.tabApprovals.Controls.Add(this.label8);
            this.tabApprovals.Controls.Add(this.label7);
            this.tabApprovals.Controls.Add(this.label6);
            this.tabApprovals.Controls.Add(this.label5);
            this.tabApprovals.Controls.Add(this.txtChangeManagemntRequestNumber);
            this.tabApprovals.Controls.Add(this.label4);
            this.tabApprovals.Controls.Add(this.txtPartner);
            this.tabApprovals.Controls.Add(this.txtDate);
            this.tabApprovals.Controls.Add(this.txtUser);
            this.tabApprovals.Controls.Add(this.label3);
            this.tabApprovals.Controls.Add(this.label2);
            this.tabApprovals.Controls.Add(this.label1);
            this.tabApprovals.Location = new System.Drawing.Point(4, 22);
            this.tabApprovals.Name = "tabApprovals";
            this.tabApprovals.Padding = new System.Windows.Forms.Padding(3);
            this.tabApprovals.Size = new System.Drawing.Size(1045, 601);
            this.tabApprovals.TabIndex = 0;
            this.tabApprovals.Text = "Approvals";
            // 
            // tabCheckList
            // 
            this.tabCheckList.BackColor = System.Drawing.Color.SlateGray;
            this.tabCheckList.Controls.Add(this.txtPerlScripts);
            this.tabCheckList.Controls.Add(this.cbXSLTEmailErrorHeader);
            this.tabCheckList.Controls.Add(this.cbMapCodeTables);
            this.tabCheckList.Controls.Add(this.cbDocumentMap);
            this.tabCheckList.Controls.Add(this.cbDocumentExtractionMap);
            this.tabCheckList.Controls.Add(this.cbServiceAdapter);
            this.tabCheckList.Controls.Add(this.cbBusinessProcess);
            this.tabCheckList.Controls.Add(this.cbRAILSrecord);
            this.tabCheckList.Controls.Add(this.cbRAILSfilter);
            this.tabCheckList.Controls.Add(this.cbFileStructureInProduction);
            this.tabCheckList.Controls.Add(this.cbFTPconnect);
            this.tabCheckList.Controls.Add(this.cbTRANSPORTparmfile);
            this.tabCheckList.Controls.Add(this.cbRAILStable);
            this.tabCheckList.Controls.Add(this.cbPerlScripts);
            this.tabCheckList.Controls.Add(this.cbEmailCodeList);
            this.tabCheckList.Controls.Add(this.cbEnvelopes);
            this.tabCheckList.Controls.Add(this.label29);
            this.tabCheckList.Controls.Add(this.label28);
            this.tabCheckList.Controls.Add(this.label27);
            this.tabCheckList.Controls.Add(this.label26);
            this.tabCheckList.Controls.Add(this.label25);
            this.tabCheckList.Controls.Add(this.label24);
            this.tabCheckList.Controls.Add(this.label23);
            this.tabCheckList.Controls.Add(this.label22);
            this.tabCheckList.Controls.Add(this.label21);
            this.tabCheckList.Controls.Add(this.label20);
            this.tabCheckList.Controls.Add(this.label19);
            this.tabCheckList.Controls.Add(this.label18);
            this.tabCheckList.Controls.Add(this.label17);
            this.tabCheckList.Controls.Add(this.label16);
            this.tabCheckList.Controls.Add(this.label15);
            this.tabCheckList.Location = new System.Drawing.Point(4, 22);
            this.tabCheckList.Name = "tabCheckList";
            this.tabCheckList.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckList.Size = new System.Drawing.Size(1045, 601);
            this.tabCheckList.TabIndex = 1;
            this.tabCheckList.Text = "CheckList";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Partner:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(88, 41);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(237, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(769, 39);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(237, 20);
            this.txtDate.TabIndex = 4;
            // 
            // txtPartner
            // 
            this.txtPartner.Location = new System.Drawing.Point(425, 41);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(237, 20);
            this.txtPartner.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Change Management Request Number:";
            // 
            // txtChangeManagemntRequestNumber
            // 
            this.txtChangeManagemntRequestNumber.Location = new System.Drawing.Point(464, 91);
            this.txtChangeManagemntRequestNumber.Name = "txtChangeManagemntRequestNumber";
            this.txtChangeManagemntRequestNumber.Size = new System.Drawing.Size(237, 20);
            this.txtChangeManagemntRequestNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Users Approval of Project";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Partner Approval Of Initial Project:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Table/Parm Update:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Testing Completed (Attached Results):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Developement Completed:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Code Review/Check Sign Off:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Partner Signoff:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(582, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Key User SignOff:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(526, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Implementation Final Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(521, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Post Implementation Review";
            // 
            // txtTableParmNAME
            // 
            this.txtTableParmNAME.Location = new System.Drawing.Point(346, 294);
            this.txtTableParmNAME.Name = "txtTableParmNAME";
            this.txtTableParmNAME.Size = new System.Drawing.Size(154, 20);
            this.txtTableParmNAME.TabIndex = 19;
            // 
            // txtCodeReviewBY
            // 
            this.txtCodeReviewBY.Location = new System.Drawing.Point(818, 190);
            this.txtCodeReviewBY.Name = "txtCodeReviewBY";
            this.txtCodeReviewBY.Size = new System.Drawing.Size(60, 20);
            this.txtCodeReviewBY.TabIndex = 20;
            this.txtCodeReviewBY.Text = "By";
            // 
            // cbUserApproval
            // 
            this.cbUserApproval.AutoSize = true;
            this.cbUserApproval.Location = new System.Drawing.Point(243, 193);
            this.cbUserApproval.Name = "cbUserApproval";
            this.cbUserApproval.Size = new System.Drawing.Size(102, 17);
            this.cbUserApproval.TabIndex = 27;
            this.cbUserApproval.Text = "cbUserApproval";
            this.cbUserApproval.UseVisualStyleBackColor = true;
            // 
            // cbtableParm
            // 
            this.cbtableParm.AutoSize = true;
            this.cbtableParm.Location = new System.Drawing.Point(243, 297);
            this.cbtableParm.Name = "cbtableParm";
            this.cbtableParm.Size = new System.Drawing.Size(85, 17);
            this.cbtableParm.TabIndex = 28;
            this.cbtableParm.Text = "cbtableParm";
            this.cbtableParm.UseVisualStyleBackColor = true;
            // 
            // cbTestingCompleted
            // 
            this.cbTestingCompleted.AutoSize = true;
            this.cbTestingCompleted.Location = new System.Drawing.Point(243, 403);
            this.cbTestingCompleted.Name = "cbTestingCompleted";
            this.cbTestingCompleted.Size = new System.Drawing.Size(123, 17);
            this.cbTestingCompleted.TabIndex = 29;
            this.cbTestingCompleted.Text = "cbTestingCompleted";
            this.cbTestingCompleted.UseVisualStyleBackColor = true;
            // 
            // cbDevelopmentCompleted
            // 
            this.cbDevelopmentCompleted.AutoSize = true;
            this.cbDevelopmentCompleted.Location = new System.Drawing.Point(243, 345);
            this.cbDevelopmentCompleted.Name = "cbDevelopmentCompleted";
            this.cbDevelopmentCompleted.Size = new System.Drawing.Size(151, 17);
            this.cbDevelopmentCompleted.TabIndex = 30;
            this.cbDevelopmentCompleted.Text = "cbDevelopmentCompleted";
            this.cbDevelopmentCompleted.UseVisualStyleBackColor = true;
            // 
            // cbKeyUserSignOff
            // 
            this.cbKeyUserSignOff.AutoSize = true;
            this.cbKeyUserSignOff.Location = new System.Drawing.Point(690, 244);
            this.cbKeyUserSignOff.Name = "cbKeyUserSignOff";
            this.cbKeyUserSignOff.Size = new System.Drawing.Size(113, 17);
            this.cbKeyUserSignOff.TabIndex = 31;
            this.cbKeyUserSignOff.Text = "cbKeyUserSignOff";
            this.cbKeyUserSignOff.UseVisualStyleBackColor = true;
            // 
            // cbPartnerSignOff
            // 
            this.cbPartnerSignOff.AutoSize = true;
            this.cbPartnerSignOff.Location = new System.Drawing.Point(690, 297);
            this.cbPartnerSignOff.Name = "cbPartnerSignOff";
            this.cbPartnerSignOff.Size = new System.Drawing.Size(107, 17);
            this.cbPartnerSignOff.TabIndex = 33;
            this.cbPartnerSignOff.Text = "cbPartnerSignOff";
            this.cbPartnerSignOff.UseVisualStyleBackColor = true;
            // 
            // cbPartnerApproval
            // 
            this.cbPartnerApproval.AutoSize = true;
            this.cbPartnerApproval.Location = new System.Drawing.Point(243, 247);
            this.cbPartnerApproval.Name = "cbPartnerApproval";
            this.cbPartnerApproval.Size = new System.Drawing.Size(114, 17);
            this.cbPartnerApproval.TabIndex = 36;
            this.cbPartnerApproval.Text = "cbPartnerApproval";
            this.cbPartnerApproval.UseVisualStyleBackColor = true;
            // 
            // cbCodeReview
            // 
            this.cbCodeReview.AutoSize = true;
            this.cbCodeReview.Location = new System.Drawing.Point(690, 197);
            this.cbCodeReview.Name = "cbCodeReview";
            this.cbCodeReview.Size = new System.Drawing.Size(99, 17);
            this.cbCodeReview.TabIndex = 37;
            this.cbCodeReview.Text = "cbCodeReview";
            this.cbCodeReview.UseVisualStyleBackColor = true;
            // 
            // txtCodeReviewDATE
            // 
            this.txtCodeReviewDATE.Location = new System.Drawing.Point(899, 191);
            this.txtCodeReviewDATE.Name = "txtCodeReviewDATE";
            this.txtCodeReviewDATE.Size = new System.Drawing.Size(77, 20);
            this.txtCodeReviewDATE.TabIndex = 39;
            this.txtCodeReviewDATE.Text = "Date";
            // 
            // grpPostReview
            // 
            this.grpPostReview.Controls.Add(this.rbAbandonedP);
            this.grpPostReview.Controls.Add(this.rbBackedOutP);
            this.grpPostReview.Controls.Add(this.rbInstalledP);
            this.grpPostReview.Location = new System.Drawing.Point(690, 385);
            this.grpPostReview.Name = "grpPostReview";
            this.grpPostReview.Size = new System.Drawing.Size(297, 53);
            this.grpPostReview.TabIndex = 40;
            this.grpPostReview.TabStop = false;
            // 
            // rbInstalledP
            // 
            this.rbInstalledP.AutoSize = true;
            this.rbInstalledP.Location = new System.Drawing.Point(16, 19);
            this.rbInstalledP.Name = "rbInstalledP";
            this.rbInstalledP.Size = new System.Drawing.Size(64, 17);
            this.rbInstalledP.TabIndex = 0;
            this.rbInstalledP.TabStop = true;
            this.rbInstalledP.Text = "Installed";
            this.rbInstalledP.UseVisualStyleBackColor = true;
            // 
            // rbBackedOutP
            // 
            this.rbBackedOutP.AutoSize = true;
            this.rbBackedOutP.Location = new System.Drawing.Point(97, 19);
            this.rbBackedOutP.Name = "rbBackedOutP";
            this.rbBackedOutP.Size = new System.Drawing.Size(82, 17);
            this.rbBackedOutP.TabIndex = 1;
            this.rbBackedOutP.TabStop = true;
            this.rbBackedOutP.Text = "Backed Out";
            this.rbBackedOutP.UseVisualStyleBackColor = true;
            // 
            // rbAbandonedP
            // 
            this.rbAbandonedP.AutoSize = true;
            this.rbAbandonedP.Location = new System.Drawing.Point(196, 19);
            this.rbAbandonedP.Name = "rbAbandonedP";
            this.rbAbandonedP.Size = new System.Drawing.Size(80, 17);
            this.rbAbandonedP.TabIndex = 2;
            this.rbAbandonedP.TabStop = true;
            this.rbAbandonedP.Text = "Abandoned";
            this.rbAbandonedP.UseVisualStyleBackColor = true;
            // 
            // grpImplementationReview
            // 
            this.grpImplementationReview.Controls.Add(this.rbAbandonedI);
            this.grpImplementationReview.Controls.Add(this.rbBackedOutI);
            this.grpImplementationReview.Controls.Add(this.rbInstalledI);
            this.grpImplementationReview.Location = new System.Drawing.Point(690, 326);
            this.grpImplementationReview.Name = "grpImplementationReview";
            this.grpImplementationReview.Size = new System.Drawing.Size(297, 53);
            this.grpImplementationReview.TabIndex = 41;
            this.grpImplementationReview.TabStop = false;
            // 
            // rbAbandonedI
            // 
            this.rbAbandonedI.AutoSize = true;
            this.rbAbandonedI.Location = new System.Drawing.Point(196, 19);
            this.rbAbandonedI.Name = "rbAbandonedI";
            this.rbAbandonedI.Size = new System.Drawing.Size(80, 17);
            this.rbAbandonedI.TabIndex = 2;
            this.rbAbandonedI.TabStop = true;
            this.rbAbandonedI.Text = "Abandoned";
            this.rbAbandonedI.UseVisualStyleBackColor = true;
            // 
            // rbBackedOutI
            // 
            this.rbBackedOutI.AutoSize = true;
            this.rbBackedOutI.Location = new System.Drawing.Point(97, 19);
            this.rbBackedOutI.Name = "rbBackedOutI";
            this.rbBackedOutI.Size = new System.Drawing.Size(82, 17);
            this.rbBackedOutI.TabIndex = 1;
            this.rbBackedOutI.TabStop = true;
            this.rbBackedOutI.Text = "Backed Out";
            this.rbBackedOutI.UseVisualStyleBackColor = true;
            // 
            // rbInstalledI
            // 
            this.rbInstalledI.AutoSize = true;
            this.rbInstalledI.Location = new System.Drawing.Point(16, 19);
            this.rbInstalledI.Name = "rbInstalledI";
            this.rbInstalledI.Size = new System.Drawing.Size(64, 17);
            this.rbInstalledI.TabIndex = 0;
            this.rbInstalledI.TabStop = true;
            this.rbInstalledI.Text = "Installed";
            this.rbInstalledI.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Envelopes:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(558, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "TRANSPORT Parm File:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(608, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "FTP Connect:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(544, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "File Structure in Production:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(592, 382);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "RAILS csv  Filter:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(582, 312);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "RAILS csv Record:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(590, 457);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "RAILS csv Table:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(131, 531);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Map Code Tables:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(553, 43);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "XSLT Email Error Header:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(92, 457);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(133, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "Document Extraction Map:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(43, 382);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(182, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "Document Maps(Remove Delimiters):";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(143, 312);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 13);
            this.label26.TabIndex = 11;
            this.label26.Text = "Email Code List:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(162, 233);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "Perl Scripts:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(143, 163);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 13);
            this.label28.TabIndex = 13;
            this.label28.Text = "Service Adapter:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(121, 96);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(104, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "Business Processes:";
            // 
            // cbEnvelopes
            // 
            this.cbEnvelopes.AutoSize = true;
            this.cbEnvelopes.Location = new System.Drawing.Point(247, 39);
            this.cbEnvelopes.Name = "cbEnvelopes";
            this.cbEnvelopes.Size = new System.Drawing.Size(88, 17);
            this.cbEnvelopes.TabIndex = 15;
            this.cbEnvelopes.Text = "cbEnvelopes";
            this.cbEnvelopes.UseVisualStyleBackColor = true;
            // 
            // cbEmailCodeList
            // 
            this.cbEmailCodeList.AutoSize = true;
            this.cbEmailCodeList.Location = new System.Drawing.Point(247, 308);
            this.cbEmailCodeList.Name = "cbEmailCodeList";
            this.cbEmailCodeList.Size = new System.Drawing.Size(104, 17);
            this.cbEmailCodeList.TabIndex = 16;
            this.cbEmailCodeList.Text = "cbEmailCodeList";
            this.cbEmailCodeList.UseVisualStyleBackColor = true;
            // 
            // cbPerlScripts
            // 
            this.cbPerlScripts.AutoSize = true;
            this.cbPerlScripts.Location = new System.Drawing.Point(247, 229);
            this.cbPerlScripts.Name = "cbPerlScripts";
            this.cbPerlScripts.Size = new System.Drawing.Size(88, 17);
            this.cbPerlScripts.TabIndex = 17;
            this.cbPerlScripts.Text = "cbPerlScripts";
            this.cbPerlScripts.UseVisualStyleBackColor = true;
            // 
            // cbRAILStable
            // 
            this.cbRAILStable.AutoSize = true;
            this.cbRAILStable.Location = new System.Drawing.Point(711, 457);
            this.cbRAILStable.Name = "cbRAILStable";
            this.cbRAILStable.Size = new System.Drawing.Size(92, 17);
            this.cbRAILStable.TabIndex = 18;
            this.cbRAILStable.Text = "cbRAILStable";
            this.cbRAILStable.UseVisualStyleBackColor = true;
            // 
            // cbTRANSPORTparmfile
            // 
            this.cbTRANSPORTparmfile.AutoSize = true;
            this.cbTRANSPORTparmfile.Location = new System.Drawing.Point(711, 96);
            this.cbTRANSPORTparmfile.Name = "cbTRANSPORTparmfile";
            this.cbTRANSPORTparmfile.Size = new System.Drawing.Size(141, 17);
            this.cbTRANSPORTparmfile.TabIndex = 19;
            this.cbTRANSPORTparmfile.Text = "cbTRANSPORTparmfile";
            this.cbTRANSPORTparmfile.UseVisualStyleBackColor = true;
            // 
            // cbFTPconnect
            // 
            this.cbFTPconnect.AutoSize = true;
            this.cbFTPconnect.Location = new System.Drawing.Point(711, 229);
            this.cbFTPconnect.Name = "cbFTPconnect";
            this.cbFTPconnect.Size = new System.Drawing.Size(97, 17);
            this.cbFTPconnect.TabIndex = 20;
            this.cbFTPconnect.Text = "cbFTPconnect";
            this.cbFTPconnect.UseVisualStyleBackColor = true;
            // 
            // cbFileStructureInProduction
            // 
            this.cbFileStructureInProduction.AutoSize = true;
            this.cbFileStructureInProduction.Location = new System.Drawing.Point(711, 151);
            this.cbFileStructureInProduction.Name = "cbFileStructureInProduction";
            this.cbFileStructureInProduction.Size = new System.Drawing.Size(157, 17);
            this.cbFileStructureInProduction.TabIndex = 21;
            this.cbFileStructureInProduction.Text = "cbFileStructureInProduction";
            this.cbFileStructureInProduction.UseVisualStyleBackColor = true;
            // 
            // cbRAILSfilter
            // 
            this.cbRAILSfilter.AutoSize = true;
            this.cbRAILSfilter.Location = new System.Drawing.Point(711, 382);
            this.cbRAILSfilter.Name = "cbRAILSfilter";
            this.cbRAILSfilter.Size = new System.Drawing.Size(88, 17);
            this.cbRAILSfilter.TabIndex = 22;
            this.cbRAILSfilter.Text = "cbRAILSfilter";
            this.cbRAILSfilter.UseVisualStyleBackColor = true;
            // 
            // cbRAILSrecord
            // 
            this.cbRAILSrecord.AutoSize = true;
            this.cbRAILSrecord.Location = new System.Drawing.Point(711, 308);
            this.cbRAILSrecord.Name = "cbRAILSrecord";
            this.cbRAILSrecord.Size = new System.Drawing.Size(99, 17);
            this.cbRAILSrecord.TabIndex = 23;
            this.cbRAILSrecord.Text = "cbRAILSrecord";
            this.cbRAILSrecord.UseVisualStyleBackColor = true;
            // 
            // cbBusinessProcess
            // 
            this.cbBusinessProcess.AutoSize = true;
            this.cbBusinessProcess.Location = new System.Drawing.Point(247, 92);
            this.cbBusinessProcess.Name = "cbBusinessProcess";
            this.cbBusinessProcess.Size = new System.Drawing.Size(118, 17);
            this.cbBusinessProcess.TabIndex = 24;
            this.cbBusinessProcess.Text = "cbBusinessProcess";
            this.cbBusinessProcess.UseVisualStyleBackColor = true;
            // 
            // cbServiceAdapter
            // 
            this.cbServiceAdapter.AutoSize = true;
            this.cbServiceAdapter.Location = new System.Drawing.Point(247, 159);
            this.cbServiceAdapter.Name = "cbServiceAdapter";
            this.cbServiceAdapter.Size = new System.Drawing.Size(111, 17);
            this.cbServiceAdapter.TabIndex = 25;
            this.cbServiceAdapter.Text = "cbServiceAdapter";
            this.cbServiceAdapter.UseVisualStyleBackColor = true;
            // 
            // cbDocumentExtractionMap
            // 
            this.cbDocumentExtractionMap.AutoSize = true;
            this.cbDocumentExtractionMap.Location = new System.Drawing.Point(247, 453);
            this.cbDocumentExtractionMap.Name = "cbDocumentExtractionMap";
            this.cbDocumentExtractionMap.Size = new System.Drawing.Size(155, 17);
            this.cbDocumentExtractionMap.TabIndex = 26;
            this.cbDocumentExtractionMap.Text = "cbDocumentExtractionMap";
            this.cbDocumentExtractionMap.UseVisualStyleBackColor = true;
            // 
            // cbDocumentMap
            // 
            this.cbDocumentMap.AutoSize = true;
            this.cbDocumentMap.Location = new System.Drawing.Point(247, 382);
            this.cbDocumentMap.Name = "cbDocumentMap";
            this.cbDocumentMap.Size = new System.Drawing.Size(113, 17);
            this.cbDocumentMap.TabIndex = 27;
            this.cbDocumentMap.Text = "cbDocumentMaps";
            this.cbDocumentMap.UseVisualStyleBackColor = true;
            // 
            // cbMapCodeTables
            // 
            this.cbMapCodeTables.AutoSize = true;
            this.cbMapCodeTables.Location = new System.Drawing.Point(247, 531);
            this.cbMapCodeTables.Name = "cbMapCodeTables";
            this.cbMapCodeTables.Size = new System.Drawing.Size(116, 17);
            this.cbMapCodeTables.TabIndex = 28;
            this.cbMapCodeTables.Text = "cbMapCodeTables";
            this.cbMapCodeTables.UseVisualStyleBackColor = true;
            // 
            // cbXSLTEmailErrorHeader
            // 
            this.cbXSLTEmailErrorHeader.AutoSize = true;
            this.cbXSLTEmailErrorHeader.Location = new System.Drawing.Point(711, 39);
            this.cbXSLTEmailErrorHeader.Name = "cbXSLTEmailErrorHeader";
            this.cbXSLTEmailErrorHeader.Size = new System.Drawing.Size(147, 17);
            this.cbXSLTEmailErrorHeader.TabIndex = 29;
            this.cbXSLTEmailErrorHeader.Text = "cbXSLTEmailErrorHeader";
            this.cbXSLTEmailErrorHeader.UseVisualStyleBackColor = true;
            // 
            // txtPerlScripts
            // 
            this.txtPerlScripts.Location = new System.Drawing.Point(349, 226);
            this.txtPerlScripts.Name = "txtPerlScripts";
            this.txtPerlScripts.Size = new System.Drawing.Size(207, 20);
            this.txtPerlScripts.TabIndex = 30;
            // 
            // tabReview
            // 
            this.tabReview.BackColor = System.Drawing.Color.SlateGray;
            this.tabReview.Controls.Add(this.groupBox1);
            this.tabReview.Location = new System.Drawing.Point(4, 22);
            this.tabReview.Name = "tabReview";
            this.tabReview.Size = new System.Drawing.Size(1045, 601);
            this.tabReview.TabIndex = 2;
            this.tabReview.Text = "Review";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCompletionDate);
            this.groupBox1.Controls.Add(this.txtProjectManager);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Location = new System.Drawing.Point(221, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(44, 55);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(176, 25);
            this.label30.TabIndex = 0;
            this.label30.Text = "Project Manager:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(49, 141);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(177, 25);
            this.label31.TabIndex = 1;
            this.label31.Text = "Completion Date:";
            // 
            // txtProjectManager
            // 
            this.txtProjectManager.Location = new System.Drawing.Point(239, 55);
            this.txtProjectManager.Multiline = true;
            this.txtProjectManager.Name = "txtProjectManager";
            this.txtProjectManager.Size = new System.Drawing.Size(214, 37);
            this.txtProjectManager.TabIndex = 2;
            this.txtProjectManager.TextChanged += new System.EventHandler(this.txtProjectManager_TextChanged);
            // 
            // txtCompletionDate
            // 
            this.txtCompletionDate.Location = new System.Drawing.Point(239, 127);
            this.txtCompletionDate.Multiline = true;
            this.txtCompletionDate.Name = "txtCompletionDate";
            this.txtCompletionDate.Size = new System.Drawing.Size(214, 39);
            this.txtCompletionDate.TabIndex = 3;
            // 
            // Approval_Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabcApprovals);
            this.Name = "Approval_Initial";
            this.Size = new System.Drawing.Size(1111, 684);
            this.FormRegionShowing += new System.EventHandler(this.Approval_Initial_FormRegionShowing);
            this.FormRegionClosed += new System.EventHandler(this.Approval_Initial_FormRegionClosed);
            this.tabcApprovals.ResumeLayout(false);
            this.tabApprovals.ResumeLayout(false);
            this.tabApprovals.PerformLayout();
            this.tabCheckList.ResumeLayout(false);
            this.tabCheckList.PerformLayout();
            this.grpPostReview.ResumeLayout(false);
            this.grpPostReview.PerformLayout();
            this.grpImplementationReview.ResumeLayout(false);
            this.grpImplementationReview.PerformLayout();
            this.tabReview.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Form Region Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private static void InitializeManifest(Microsoft.Office.Tools.Outlook.FormRegionManifest manifest, Microsoft.Office.Tools.Outlook.Factory factory)
        {
            manifest.Description = "Initial Take off for Project Approval";
            manifest.FormRegionName = "Send to Approve";
            manifest.FormRegionType = Microsoft.Office.Tools.Outlook.FormRegionType.Replacement;
            manifest.Title = "Approval_Initial";

        }

        #endregion

        private System.Windows.Forms.TabControl tabcApprovals;
        private System.Windows.Forms.TabPage tabApprovals;
        private System.Windows.Forms.GroupBox grpImplementationReview;
        private System.Windows.Forms.RadioButton rbAbandonedI;
        private System.Windows.Forms.RadioButton rbBackedOutI;
        private System.Windows.Forms.RadioButton rbInstalledI;
        private System.Windows.Forms.GroupBox grpPostReview;
        private System.Windows.Forms.RadioButton rbAbandonedP;
        private System.Windows.Forms.RadioButton rbBackedOutP;
        private System.Windows.Forms.RadioButton rbInstalledP;
        private System.Windows.Forms.TextBox txtCodeReviewDATE;
        private System.Windows.Forms.CheckBox cbCodeReview;
        private System.Windows.Forms.CheckBox cbPartnerApproval;
        private System.Windows.Forms.CheckBox cbPartnerSignOff;
        private System.Windows.Forms.CheckBox cbKeyUserSignOff;
        private System.Windows.Forms.CheckBox cbDevelopmentCompleted;
        private System.Windows.Forms.CheckBox cbTestingCompleted;
        private System.Windows.Forms.CheckBox cbtableParm;
        private System.Windows.Forms.CheckBox cbUserApproval;
        private System.Windows.Forms.TextBox txtCodeReviewBY;
        private System.Windows.Forms.TextBox txtTableParmNAME;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChangeManagemntRequestNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPartner;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCheckList;
        private System.Windows.Forms.TextBox txtPerlScripts;
        private System.Windows.Forms.CheckBox cbXSLTEmailErrorHeader;
        private System.Windows.Forms.CheckBox cbMapCodeTables;
        private System.Windows.Forms.CheckBox cbDocumentMap;
        private System.Windows.Forms.CheckBox cbDocumentExtractionMap;
        private System.Windows.Forms.CheckBox cbServiceAdapter;
        private System.Windows.Forms.CheckBox cbBusinessProcess;
        private System.Windows.Forms.CheckBox cbRAILSrecord;
        private System.Windows.Forms.CheckBox cbRAILSfilter;
        private System.Windows.Forms.CheckBox cbFileStructureInProduction;
        private System.Windows.Forms.CheckBox cbFTPconnect;
        private System.Windows.Forms.CheckBox cbTRANSPORTparmfile;
        private System.Windows.Forms.CheckBox cbRAILStable;
        private System.Windows.Forms.CheckBox cbPerlScripts;
        private System.Windows.Forms.CheckBox cbEmailCodeList;
        private System.Windows.Forms.CheckBox cbEnvelopes;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabReview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCompletionDate;
        private System.Windows.Forms.TextBox txtProjectManager;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;

        public partial class Approval_InitialFactory : Microsoft.Office.Tools.Outlook.IFormRegionFactory
        {
            public event Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler FormRegionInitializing;

            private Microsoft.Office.Tools.Outlook.FormRegionManifest _Manifest;

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public Approval_InitialFactory()
            {
                this._Manifest = Globals.Factory.CreateFormRegionManifest();
                Approval_Initial.InitializeManifest(this._Manifest, Globals.Factory);
                this.FormRegionInitializing += new Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler(this.Approval_InitialFactory_FormRegionInitializing);
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public Microsoft.Office.Tools.Outlook.FormRegionManifest Manifest
            {
                get
                {
                    return this._Manifest;
                }
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            Microsoft.Office.Tools.Outlook.IFormRegion Microsoft.Office.Tools.Outlook.IFormRegionFactory.CreateFormRegion(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
            {
                Approval_Initial form = new Approval_Initial(formRegion);
                form.Factory = this;
                return form;
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            byte[] Microsoft.Office.Tools.Outlook.IFormRegionFactory.GetFormRegionStorage(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
            {
                throw new System.NotSupportedException();
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            bool Microsoft.Office.Tools.Outlook.IFormRegionFactory.IsDisplayedForItem(object outlookItem, Microsoft.Office.Interop.Outlook.OlFormRegionMode formRegionMode, Microsoft.Office.Interop.Outlook.OlFormRegionSize formRegionSize)
            {
                if (this.FormRegionInitializing != null)
                {
                    Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs cancelArgs = Globals.Factory.CreateFormRegionInitializingEventArgs(outlookItem, formRegionMode, formRegionSize, false);
                    this.FormRegionInitializing(this, cancelArgs);
                    return !cancelArgs.Cancel;
                }
                else
                {
                    return true;
                }
            }

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            Microsoft.Office.Tools.Outlook.FormRegionKindConstants Microsoft.Office.Tools.Outlook.IFormRegionFactory.Kind
            {
                get
                {
                    return Microsoft.Office.Tools.Outlook.FormRegionKindConstants.WindowsForms;
                }
            }
        }
    }

    partial class WindowFormRegionCollection
    {
        internal Approval_Initial Approval_Initial
        {
            get
            {
                foreach (var item in this)
                {
                    if (item.GetType() == typeof(Approval_Initial))
                        return (Approval_Initial)item;
                }
                return null;
            }
        }
    }
}
