﻿namespace ApprovalAddIn
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class Open_Approval : Microsoft.Office.Tools.Outlook.FormRegionBase
    {
        public Open_Approval(Microsoft.Office.Interop.Outlook.FormRegion formRegion)
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCodeReviewDATE = new System.Windows.Forms.TextBox();
            this.txtCodeReviewBY = new System.Windows.Forms.TextBox();
            this.txtTableParmNAME = new System.Windows.Forms.TextBox();
            this.txtChangeManagemntRequestNumber = new System.Windows.Forms.TextBox();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.grpImplementationReview = new System.Windows.Forms.GroupBox();
            this.rbAbandonedI = new System.Windows.Forms.RadioButton();
            this.rbBackedOutI = new System.Windows.Forms.RadioButton();
            this.rbInstalledI = new System.Windows.Forms.RadioButton();
            this.grpPostReview = new System.Windows.Forms.GroupBox();
            this.rbAbandonedP = new System.Windows.Forms.RadioButton();
            this.rbBackedOutP = new System.Windows.Forms.RadioButton();
            this.rbInstalledP = new System.Windows.Forms.RadioButton();
            this.cbCodeReview = new System.Windows.Forms.CheckBox();
            this.cbPartnerApproval = new System.Windows.Forms.CheckBox();
            this.cbPartnerSignOff = new System.Windows.Forms.CheckBox();
            this.cbKeyUserSignOff = new System.Windows.Forms.CheckBox();
            this.cbDevelopmentCompleted = new System.Windows.Forms.CheckBox();
            this.cbTestingCompleted = new System.Windows.Forms.CheckBox();
            this.cbtableParm = new System.Windows.Forms.CheckBox();
            this.cbUserApproval = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabReview = new System.Windows.Forms.TabPage();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtApprovingManager = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtProjectManager = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtPerlScripts = new System.Windows.Forms.TextBox();
            this.cbXSLTEmailErrorHeader = new System.Windows.Forms.CheckBox();
            this.cbRAILSrecord = new System.Windows.Forms.CheckBox();
            this.cbEmailCodeList = new System.Windows.Forms.CheckBox();
            this.cbRAILSfilter = new System.Windows.Forms.CheckBox();
            this.cbFileStructureInProduction = new System.Windows.Forms.CheckBox();
            this.cbFTPconnect = new System.Windows.Forms.CheckBox();
            this.cbTRANSPORTparmfile = new System.Windows.Forms.CheckBox();
            this.cbRAILStable = new System.Windows.Forms.CheckBox();
            this.cbMapCodeTables = new System.Windows.Forms.CheckBox();
            this.cbDocumentMap = new System.Windows.Forms.CheckBox();
            this.cbDocumentExtractionMap = new System.Windows.Forms.CheckBox();
            this.cbServiceAdapter = new System.Windows.Forms.CheckBox();
            this.cbBusinessProcess = new System.Windows.Forms.CheckBox();
            this.cbPerlScripts = new System.Windows.Forms.CheckBox();
            this.cbEnvelopes = new System.Windows.Forms.CheckBox();
            this.ddAttachments = new System.Windows.Forms.DomainUpDown();
            this.tabcApprovals.SuspendLayout();
            this.tabApprovals.SuspendLayout();
            this.grpImplementationReview.SuspendLayout();
            this.grpPostReview.SuspendLayout();
            this.tabReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcApprovals
            // 
            this.tabcApprovals.Controls.Add(this.tabApprovals);
            this.tabcApprovals.Controls.Add(this.tabReview);
            this.tabcApprovals.Location = new System.Drawing.Point(3, 3);
            this.tabcApprovals.Name = "tabcApprovals";
            this.tabcApprovals.SelectedIndex = 0;
            this.tabcApprovals.Size = new System.Drawing.Size(1135, 503);
            this.tabcApprovals.TabIndex = 1;
            // 
            // tabApprovals
            // 
            this.tabApprovals.AutoScroll = true;
            this.tabApprovals.BackColor = System.Drawing.Color.LightBlue;
            this.tabApprovals.Controls.Add(this.lblStatus);
            this.tabApprovals.Controls.Add(this.label15);
            this.tabApprovals.Controls.Add(this.txtDescription);
            this.tabApprovals.Controls.Add(this.txtCodeReviewDATE);
            this.tabApprovals.Controls.Add(this.txtCodeReviewBY);
            this.tabApprovals.Controls.Add(this.txtTableParmNAME);
            this.tabApprovals.Controls.Add(this.txtChangeManagemntRequestNumber);
            this.tabApprovals.Controls.Add(this.txtPartner);
            this.tabApprovals.Controls.Add(this.txtDate);
            this.tabApprovals.Controls.Add(this.txtUser);
            this.tabApprovals.Controls.Add(this.btnPrint);
            this.tabApprovals.Controls.Add(this.label31);
            this.tabApprovals.Controls.Add(this.grpImplementationReview);
            this.tabApprovals.Controls.Add(this.grpPostReview);
            this.tabApprovals.Controls.Add(this.cbCodeReview);
            this.tabApprovals.Controls.Add(this.cbPartnerApproval);
            this.tabApprovals.Controls.Add(this.cbPartnerSignOff);
            this.tabApprovals.Controls.Add(this.cbKeyUserSignOff);
            this.tabApprovals.Controls.Add(this.cbDevelopmentCompleted);
            this.tabApprovals.Controls.Add(this.cbTestingCompleted);
            this.tabApprovals.Controls.Add(this.cbtableParm);
            this.tabApprovals.Controls.Add(this.cbUserApproval);
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
            this.tabApprovals.Controls.Add(this.label4);
            this.tabApprovals.Controls.Add(this.label3);
            this.tabApprovals.Controls.Add(this.label2);
            this.tabApprovals.Controls.Add(this.label1);
            this.tabApprovals.Location = new System.Drawing.Point(4, 22);
            this.tabApprovals.Name = "tabApprovals";
            this.tabApprovals.Padding = new System.Windows.Forms.Padding(3);
            this.tabApprovals.Size = new System.Drawing.Size(1127, 477);
            this.tabApprovals.TabIndex = 0;
            this.tabApprovals.Text = "Approvals";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(502, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 20);
            this.lblStatus.TabIndex = 67;
            this.lblStatus.Text = "status here";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(436, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "Status:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(172, 94);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(237, 26);
            this.txtDescription.TabIndex = 43;
            // 
            // txtCodeReviewDATE
            // 
            this.txtCodeReviewDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeReviewDATE.Location = new System.Drawing.Point(921, 189);
            this.txtCodeReviewDATE.Name = "txtCodeReviewDATE";
            this.txtCodeReviewDATE.Size = new System.Drawing.Size(77, 26);
            this.txtCodeReviewDATE.TabIndex = 39;
            this.txtCodeReviewDATE.Text = "Date";
            // 
            // txtCodeReviewBY
            // 
            this.txtCodeReviewBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeReviewBY.Location = new System.Drawing.Point(825, 189);
            this.txtCodeReviewBY.Name = "txtCodeReviewBY";
            this.txtCodeReviewBY.Size = new System.Drawing.Size(60, 26);
            this.txtCodeReviewBY.TabIndex = 20;
            this.txtCodeReviewBY.Text = "By";
            // 
            // txtTableParmNAME
            // 
            this.txtTableParmNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableParmNAME.Location = new System.Drawing.Point(398, 297);
            this.txtTableParmNAME.Name = "txtTableParmNAME";
            this.txtTableParmNAME.Size = new System.Drawing.Size(154, 26);
            this.txtTableParmNAME.TabIndex = 19;
            // 
            // txtChangeManagemntRequestNumber
            // 
            this.txtChangeManagemntRequestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeManagemntRequestNumber.Location = new System.Drawing.Point(776, 94);
            this.txtChangeManagemntRequestNumber.Name = "txtChangeManagemntRequestNumber";
            this.txtChangeManagemntRequestNumber.Size = new System.Drawing.Size(237, 26);
            this.txtChangeManagemntRequestNumber.TabIndex = 7;
            // 
            // txtPartner
            // 
            this.txtPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartner.Location = new System.Drawing.Point(446, 46);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(237, 26);
            this.txtPartner.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(761, 46);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(237, 26);
            this.txtDate.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(91, 46);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(237, 26);
            this.txtUser.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(3, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 44;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(73, 94);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(91, 19);
            this.label31.TabIndex = 42;
            this.label31.Text = "Description:";
            // 
            // grpImplementationReview
            // 
            this.grpImplementationReview.Controls.Add(this.rbAbandonedI);
            this.grpImplementationReview.Controls.Add(this.rbBackedOutI);
            this.grpImplementationReview.Controls.Add(this.rbInstalledI);
            this.grpImplementationReview.Location = new System.Drawing.Point(690, 326);
            this.grpImplementationReview.Name = "grpImplementationReview";
            this.grpImplementationReview.Size = new System.Drawing.Size(308, 53);
            this.grpImplementationReview.TabIndex = 41;
            this.grpImplementationReview.TabStop = false;
            // 
            // rbAbandonedI
            // 
            this.rbAbandonedI.AutoSize = true;
            this.rbAbandonedI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbAbandonedI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbandonedI.Location = new System.Drawing.Point(196, 19);
            this.rbAbandonedI.Name = "rbAbandonedI";
            this.rbAbandonedI.Size = new System.Drawing.Size(99, 22);
            this.rbAbandonedI.TabIndex = 2;
            this.rbAbandonedI.TabStop = true;
            this.rbAbandonedI.Text = "Abandoned";
            this.rbAbandonedI.UseVisualStyleBackColor = true;
            this.rbAbandonedI.CheckedChanged += new System.EventHandler(this.rbAbandonedI_CheckedChanged);
            // 
            // rbBackedOutI
            // 
            this.rbBackedOutI.AutoSize = true;
            this.rbBackedOutI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbBackedOutI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBackedOutI.Location = new System.Drawing.Point(97, 19);
            this.rbBackedOutI.Name = "rbBackedOutI";
            this.rbBackedOutI.Size = new System.Drawing.Size(103, 22);
            this.rbBackedOutI.TabIndex = 1;
            this.rbBackedOutI.TabStop = true;
            this.rbBackedOutI.Text = "Backed Out";
            this.rbBackedOutI.UseVisualStyleBackColor = true;
            this.rbBackedOutI.CheckedChanged += new System.EventHandler(this.rbBackedOutI_CheckedChanged);
            // 
            // rbInstalledI
            // 
            this.rbInstalledI.AutoSize = true;
            this.rbInstalledI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbInstalledI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInstalledI.Location = new System.Drawing.Point(16, 19);
            this.rbInstalledI.Name = "rbInstalledI";
            this.rbInstalledI.Size = new System.Drawing.Size(78, 22);
            this.rbInstalledI.TabIndex = 0;
            this.rbInstalledI.TabStop = true;
            this.rbInstalledI.Text = "Installed";
            this.rbInstalledI.UseVisualStyleBackColor = true;
            this.rbInstalledI.CheckedChanged += new System.EventHandler(this.rbInstalledI_CheckedChanged);
            // 
            // grpPostReview
            // 
            this.grpPostReview.Controls.Add(this.rbAbandonedP);
            this.grpPostReview.Controls.Add(this.rbBackedOutP);
            this.grpPostReview.Controls.Add(this.rbInstalledP);
            this.grpPostReview.Location = new System.Drawing.Point(690, 385);
            this.grpPostReview.Name = "grpPostReview";
            this.grpPostReview.Size = new System.Drawing.Size(308, 53);
            this.grpPostReview.TabIndex = 40;
            this.grpPostReview.TabStop = false;
            // 
            // rbAbandonedP
            // 
            this.rbAbandonedP.AutoSize = true;
            this.rbAbandonedP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbAbandonedP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbandonedP.Location = new System.Drawing.Point(196, 19);
            this.rbAbandonedP.Name = "rbAbandonedP";
            this.rbAbandonedP.Size = new System.Drawing.Size(99, 22);
            this.rbAbandonedP.TabIndex = 2;
            this.rbAbandonedP.TabStop = true;
            this.rbAbandonedP.Text = "Abandoned";
            this.rbAbandonedP.UseVisualStyleBackColor = true;
            this.rbAbandonedP.CheckedChanged += new System.EventHandler(this.rbAbandonedP_CheckedChanged);
            // 
            // rbBackedOutP
            // 
            this.rbBackedOutP.AutoSize = true;
            this.rbBackedOutP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbBackedOutP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBackedOutP.Location = new System.Drawing.Point(97, 19);
            this.rbBackedOutP.Name = "rbBackedOutP";
            this.rbBackedOutP.Size = new System.Drawing.Size(103, 22);
            this.rbBackedOutP.TabIndex = 1;
            this.rbBackedOutP.TabStop = true;
            this.rbBackedOutP.Text = "Backed Out";
            this.rbBackedOutP.UseVisualStyleBackColor = true;
            this.rbBackedOutP.CheckedChanged += new System.EventHandler(this.rbBackedOutP_CheckedChanged);
            // 
            // rbInstalledP
            // 
            this.rbInstalledP.AutoSize = true;
            this.rbInstalledP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbInstalledP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInstalledP.Location = new System.Drawing.Point(16, 19);
            this.rbInstalledP.Name = "rbInstalledP";
            this.rbInstalledP.Size = new System.Drawing.Size(78, 22);
            this.rbInstalledP.TabIndex = 0;
            this.rbInstalledP.TabStop = true;
            this.rbInstalledP.Text = "Installed";
            this.rbInstalledP.UseVisualStyleBackColor = true;
            this.rbInstalledP.CheckedChanged += new System.EventHandler(this.rbInstalledP_CheckedChanged);
            // 
            // cbCodeReview
            // 
            this.cbCodeReview.AutoSize = true;
            this.cbCodeReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCodeReview.Location = new System.Drawing.Point(706, 192);
            this.cbCodeReview.Name = "cbCodeReview";
            this.cbCodeReview.Size = new System.Drawing.Size(97, 17);
            this.cbCodeReview.TabIndex = 37;
            this.cbCodeReview.Text = "cbCodeReview";
            this.cbCodeReview.UseVisualStyleBackColor = true;
            // 
            // cbPartnerApproval
            // 
            this.cbPartnerApproval.AutoSize = true;
            this.cbPartnerApproval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPartnerApproval.Location = new System.Drawing.Point(307, 251);
            this.cbPartnerApproval.Name = "cbPartnerApproval";
            this.cbPartnerApproval.Size = new System.Drawing.Size(112, 17);
            this.cbPartnerApproval.TabIndex = 36;
            this.cbPartnerApproval.Text = "cbPartnerApproval";
            this.cbPartnerApproval.UseVisualStyleBackColor = true;
            // 
            // cbPartnerSignOff
            // 
            this.cbPartnerSignOff.AutoSize = true;
            this.cbPartnerSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPartnerSignOff.Location = new System.Drawing.Point(707, 298);
            this.cbPartnerSignOff.Name = "cbPartnerSignOff";
            this.cbPartnerSignOff.Size = new System.Drawing.Size(105, 17);
            this.cbPartnerSignOff.TabIndex = 33;
            this.cbPartnerSignOff.Text = "cbPartnerSignOff";
            this.cbPartnerSignOff.UseVisualStyleBackColor = true;
            // 
            // cbKeyUserSignOff
            // 
            this.cbKeyUserSignOff.AutoSize = true;
            this.cbKeyUserSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbKeyUserSignOff.Location = new System.Drawing.Point(707, 248);
            this.cbKeyUserSignOff.Name = "cbKeyUserSignOff";
            this.cbKeyUserSignOff.Size = new System.Drawing.Size(111, 17);
            this.cbKeyUserSignOff.TabIndex = 31;
            this.cbKeyUserSignOff.Text = "cbKeyUserSignOff";
            this.cbKeyUserSignOff.UseVisualStyleBackColor = true;
            // 
            // cbDevelopmentCompleted
            // 
            this.cbDevelopmentCompleted.AutoSize = true;
            this.cbDevelopmentCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDevelopmentCompleted.Location = new System.Drawing.Point(307, 346);
            this.cbDevelopmentCompleted.Name = "cbDevelopmentCompleted";
            this.cbDevelopmentCompleted.Size = new System.Drawing.Size(149, 17);
            this.cbDevelopmentCompleted.TabIndex = 30;
            this.cbDevelopmentCompleted.Text = "cbDevelopmentCompleted";
            this.cbDevelopmentCompleted.UseVisualStyleBackColor = true;
            // 
            // cbTestingCompleted
            // 
            this.cbTestingCompleted.AutoSize = true;
            this.cbTestingCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTestingCompleted.Location = new System.Drawing.Point(307, 411);
            this.cbTestingCompleted.Name = "cbTestingCompleted";
            this.cbTestingCompleted.Size = new System.Drawing.Size(121, 17);
            this.cbTestingCompleted.TabIndex = 29;
            this.cbTestingCompleted.Text = "cbTestingCompleted";
            this.cbTestingCompleted.UseVisualStyleBackColor = true;
            // 
            // cbtableParm
            // 
            this.cbtableParm.AutoSize = true;
            this.cbtableParm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbtableParm.Location = new System.Drawing.Point(307, 300);
            this.cbtableParm.Name = "cbtableParm";
            this.cbtableParm.Size = new System.Drawing.Size(83, 17);
            this.cbtableParm.TabIndex = 28;
            this.cbtableParm.Text = "cbtableParm";
            this.cbtableParm.UseVisualStyleBackColor = true;
            // 
            // cbUserApproval
            // 
            this.cbUserApproval.AutoSize = true;
            this.cbUserApproval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbUserApproval.Location = new System.Drawing.Point(307, 198);
            this.cbUserApproval.Name = "cbUserApproval";
            this.cbUserApproval.Size = new System.Drawing.Size(100, 17);
            this.cbUserApproval.TabIndex = 27;
            this.cbUserApproval.Text = "cbUserApproval";
            this.cbUserApproval.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(473, 404);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Post Implementation Review";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(473, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "Implementation Final Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(566, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Key User SignOff:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(581, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Partner Signoff:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Code Review/Check Sign Off:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(104, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Developement Completed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Testing Completed (Attached Results):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Table/Parm Update:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Partner Approval Of Initial Project:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Users Approval of Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Change Management Request Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Partner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(707, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // tabReview
            // 
            this.tabReview.BackColor = System.Drawing.Color.LightBlue;
            this.tabReview.Controls.Add(this.ddAttachments);
            this.tabReview.Controls.Add(this.btnApprove);
            this.tabReview.Controls.Add(this.txtApprovingManager);
            this.tabReview.Controls.Add(this.label32);
            this.tabReview.Controls.Add(this.txtProjectManager);
            this.tabReview.Controls.Add(this.label30);
            this.tabReview.Controls.Add(this.txtPerlScripts);
            this.tabReview.Controls.Add(this.cbXSLTEmailErrorHeader);
            this.tabReview.Controls.Add(this.cbRAILSrecord);
            this.tabReview.Controls.Add(this.cbEmailCodeList);
            this.tabReview.Controls.Add(this.cbRAILSfilter);
            this.tabReview.Controls.Add(this.cbFileStructureInProduction);
            this.tabReview.Controls.Add(this.cbFTPconnect);
            this.tabReview.Controls.Add(this.cbTRANSPORTparmfile);
            this.tabReview.Controls.Add(this.cbRAILStable);
            this.tabReview.Controls.Add(this.cbMapCodeTables);
            this.tabReview.Controls.Add(this.cbDocumentMap);
            this.tabReview.Controls.Add(this.cbDocumentExtractionMap);
            this.tabReview.Controls.Add(this.cbServiceAdapter);
            this.tabReview.Controls.Add(this.cbBusinessProcess);
            this.tabReview.Controls.Add(this.cbPerlScripts);
            this.tabReview.Controls.Add(this.cbEnvelopes);
            this.tabReview.Location = new System.Drawing.Point(4, 22);
            this.tabReview.Name = "tabReview";
            this.tabReview.Size = new System.Drawing.Size(1127, 477);
            this.tabReview.TabIndex = 2;
            this.tabReview.Text = "Review";
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(922, 441);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(80, 28);
            this.btnApprove.TabIndex = 86;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // txtApprovingManager
            // 
            this.txtApprovingManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApprovingManager.Location = new System.Drawing.Point(713, 441);
            this.txtApprovingManager.Multiline = true;
            this.txtApprovingManager.Name = "txtApprovingManager";
            this.txtApprovingManager.Size = new System.Drawing.Size(186, 28);
            this.txtApprovingManager.TabIndex = 85;
            this.txtApprovingManager.TextChanged += new System.EventHandler(this.txtApprovingManager_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(477, 441);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(212, 25);
            this.label32.TabIndex = 84;
            this.label32.Text = "Approving Manager: ";
            // 
            // txtProjectManager
            // 
            this.txtProjectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectManager.Location = new System.Drawing.Point(239, 440);
            this.txtProjectManager.Multiline = true;
            this.txtProjectManager.Name = "txtProjectManager";
            this.txtProjectManager.Size = new System.Drawing.Size(186, 26);
            this.txtProjectManager.TabIndex = 83;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(44, 441);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(176, 25);
            this.label30.TabIndex = 82;
            this.label30.Text = "Project Manager:";
            // 
            // txtPerlScripts
            // 
            this.txtPerlScripts.Location = new System.Drawing.Point(560, 92);
            this.txtPerlScripts.Name = "txtPerlScripts";
            this.txtPerlScripts.Size = new System.Drawing.Size(161, 20);
            this.txtPerlScripts.TabIndex = 81;
            // 
            // cbXSLTEmailErrorHeader
            // 
            this.cbXSLTEmailErrorHeader.AutoSize = true;
            this.cbXSLTEmailErrorHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbXSLTEmailErrorHeader.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXSLTEmailErrorHeader.Location = new System.Drawing.Point(328, 214);
            this.cbXSLTEmailErrorHeader.Name = "cbXSLTEmailErrorHeader";
            this.cbXSLTEmailErrorHeader.Size = new System.Drawing.Size(195, 23);
            this.cbXSLTEmailErrorHeader.TabIndex = 80;
            this.cbXSLTEmailErrorHeader.Text = "XSLT Email Error Header";
            this.cbXSLTEmailErrorHeader.UseVisualStyleBackColor = true;
            // 
            // cbRAILSrecord
            // 
            this.cbRAILSrecord.AutoSize = true;
            this.cbRAILSrecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRAILSrecord.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAILSrecord.Location = new System.Drawing.Point(583, 296);
            this.cbRAILSrecord.Name = "cbRAILSrecord";
            this.cbRAILSrecord.Size = new System.Drawing.Size(142, 23);
            this.cbRAILSrecord.TabIndex = 79;
            this.cbRAILSrecord.Text = "RAILS csv record";
            this.cbRAILSrecord.UseVisualStyleBackColor = true;
            // 
            // cbEmailCodeList
            // 
            this.cbEmailCodeList.AutoSize = true;
            this.cbEmailCodeList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEmailCodeList.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmailCodeList.Location = new System.Drawing.Point(583, 143);
            this.cbEmailCodeList.Name = "cbEmailCodeList";
            this.cbEmailCodeList.Size = new System.Drawing.Size(136, 23);
            this.cbEmailCodeList.TabIndex = 67;
            this.cbEmailCodeList.Text = " Email Code List";
            this.cbEmailCodeList.UseVisualStyleBackColor = true;
            // 
            // cbRAILSfilter
            // 
            this.cbRAILSfilter.AutoSize = true;
            this.cbRAILSfilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRAILSfilter.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAILSfilter.Location = new System.Drawing.Point(825, 214);
            this.cbRAILSfilter.Name = "cbRAILSfilter";
            this.cbRAILSfilter.Size = new System.Drawing.Size(133, 23);
            this.cbRAILSfilter.TabIndex = 78;
            this.cbRAILSfilter.Text = " RAILS csv filter";
            this.cbRAILSfilter.UseVisualStyleBackColor = true;
            // 
            // cbFileStructureInProduction
            // 
            this.cbFileStructureInProduction.AutoSize = true;
            this.cbFileStructureInProduction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFileStructureInProduction.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFileStructureInProduction.Location = new System.Drawing.Point(49, 214);
            this.cbFileStructureInProduction.Name = "cbFileStructureInProduction";
            this.cbFileStructureInProduction.Size = new System.Drawing.Size(215, 23);
            this.cbFileStructureInProduction.TabIndex = 77;
            this.cbFileStructureInProduction.Text = "File Structure In Production";
            this.cbFileStructureInProduction.UseVisualStyleBackColor = true;
            // 
            // cbFTPconnect
            // 
            this.cbFTPconnect.AutoSize = true;
            this.cbFTPconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFTPconnect.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFTPconnect.Location = new System.Drawing.Point(49, 296);
            this.cbFTPconnect.Name = "cbFTPconnect";
            this.cbFTPconnect.Size = new System.Drawing.Size(112, 23);
            this.cbFTPconnect.TabIndex = 76;
            this.cbFTPconnect.Text = "FTP Connect";
            this.cbFTPconnect.UseVisualStyleBackColor = true;
            // 
            // cbTRANSPORTparmfile
            // 
            this.cbTRANSPORTparmfile.AutoSize = true;
            this.cbTRANSPORTparmfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTRANSPORTparmfile.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTRANSPORTparmfile.Location = new System.Drawing.Point(328, 143);
            this.cbTRANSPORTparmfile.Name = "cbTRANSPORTparmfile";
            this.cbTRANSPORTparmfile.Size = new System.Drawing.Size(183, 23);
            this.cbTRANSPORTparmfile.TabIndex = 75;
            this.cbTRANSPORTparmfile.Text = "TRANSPORT Parm File";
            this.cbTRANSPORTparmfile.UseVisualStyleBackColor = true;
            // 
            // cbRAILStable
            // 
            this.cbRAILStable.AutoSize = true;
            this.cbRAILStable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRAILStable.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAILStable.Location = new System.Drawing.Point(583, 214);
            this.cbRAILStable.Name = "cbRAILStable";
            this.cbRAILStable.Size = new System.Drawing.Size(131, 23);
            this.cbRAILStable.TabIndex = 74;
            this.cbRAILStable.Text = "RAILS csv table";
            this.cbRAILStable.UseVisualStyleBackColor = true;
            // 
            // cbMapCodeTables
            // 
            this.cbMapCodeTables.AutoSize = true;
            this.cbMapCodeTables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMapCodeTables.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMapCodeTables.Location = new System.Drawing.Point(328, 60);
            this.cbMapCodeTables.Name = "cbMapCodeTables";
            this.cbMapCodeTables.Size = new System.Drawing.Size(145, 23);
            this.cbMapCodeTables.TabIndex = 73;
            this.cbMapCodeTables.Text = "Map Code Tables";
            this.cbMapCodeTables.UseVisualStyleBackColor = true;
            // 
            // cbDocumentMap
            // 
            this.cbDocumentMap.AutoSize = true;
            this.cbDocumentMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDocumentMap.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocumentMap.Location = new System.Drawing.Point(825, 63);
            this.cbDocumentMap.Name = "cbDocumentMap";
            this.cbDocumentMap.Size = new System.Drawing.Size(140, 23);
            this.cbDocumentMap.TabIndex = 72;
            this.cbDocumentMap.Text = "Document Maps";
            this.cbDocumentMap.UseVisualStyleBackColor = true;
            // 
            // cbDocumentExtractionMap
            // 
            this.cbDocumentExtractionMap.AutoSize = true;
            this.cbDocumentExtractionMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDocumentExtractionMap.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocumentExtractionMap.Location = new System.Drawing.Point(49, 143);
            this.cbDocumentExtractionMap.Name = "cbDocumentExtractionMap";
            this.cbDocumentExtractionMap.Size = new System.Drawing.Size(205, 23);
            this.cbDocumentExtractionMap.TabIndex = 71;
            this.cbDocumentExtractionMap.Text = "Document Extraction Map";
            this.cbDocumentExtractionMap.UseVisualStyleBackColor = true;
            // 
            // cbServiceAdapter
            // 
            this.cbServiceAdapter.AutoSize = true;
            this.cbServiceAdapter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbServiceAdapter.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiceAdapter.Location = new System.Drawing.Point(825, 134);
            this.cbServiceAdapter.Name = "cbServiceAdapter";
            this.cbServiceAdapter.Size = new System.Drawing.Size(135, 23);
            this.cbServiceAdapter.TabIndex = 70;
            this.cbServiceAdapter.Text = "Service Adapter";
            this.cbServiceAdapter.UseVisualStyleBackColor = true;
            // 
            // cbBusinessProcess
            // 
            this.cbBusinessProcess.AutoSize = true;
            this.cbBusinessProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBusinessProcess.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusinessProcess.Location = new System.Drawing.Point(49, 63);
            this.cbBusinessProcess.Name = "cbBusinessProcess";
            this.cbBusinessProcess.Size = new System.Drawing.Size(143, 23);
            this.cbBusinessProcess.TabIndex = 69;
            this.cbBusinessProcess.Text = "Business Process";
            this.cbBusinessProcess.UseVisualStyleBackColor = true;
            // 
            // cbPerlScripts
            // 
            this.cbPerlScripts.AutoSize = true;
            this.cbPerlScripts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPerlScripts.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerlScripts.Location = new System.Drawing.Point(583, 63);
            this.cbPerlScripts.Name = "cbPerlScripts";
            this.cbPerlScripts.Size = new System.Drawing.Size(104, 23);
            this.cbPerlScripts.TabIndex = 68;
            this.cbPerlScripts.Text = "Perl Scripts";
            this.cbPerlScripts.UseVisualStyleBackColor = true;
            // 
            // cbEnvelopes
            // 
            this.cbEnvelopes.AutoSize = true;
            this.cbEnvelopes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEnvelopes.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnvelopes.Location = new System.Drawing.Point(328, 296);
            this.cbEnvelopes.Name = "cbEnvelopes";
            this.cbEnvelopes.Size = new System.Drawing.Size(96, 23);
            this.cbEnvelopes.TabIndex = 66;
            this.cbEnvelopes.Text = "Envelopes";
            this.cbEnvelopes.UseVisualStyleBackColor = true;
            // 
            // ddAttachments
            // 
            this.ddAttachments.Location = new System.Drawing.Point(825, 300);
            this.ddAttachments.Name = "ddAttachments";
            this.ddAttachments.Size = new System.Drawing.Size(120, 20);
            this.ddAttachments.TabIndex = 87;
            this.ddAttachments.Text = "ddAttatch";
            // 
            // Open_Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabcApprovals);
            this.Name = "Open_Approval";
            this.Size = new System.Drawing.Size(1188, 877);
            this.FormRegionShowing += new System.EventHandler(this.Open_Approval_FormRegionShowing);
            this.FormRegionClosed += new System.EventHandler(this.Open_Approval_FormRegionClosed);
            this.tabcApprovals.ResumeLayout(false);
            this.tabApprovals.ResumeLayout(false);
            this.tabApprovals.PerformLayout();
            this.grpImplementationReview.ResumeLayout(false);
            this.grpImplementationReview.PerformLayout();
            this.grpPostReview.ResumeLayout(false);
            this.grpPostReview.PerformLayout();
            this.tabReview.ResumeLayout(false);
            this.tabReview.PerformLayout();
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
            manifest.FormRegionName = "Open Approval";
            manifest.ShowReadingPane = false;

        }

        #endregion

        private System.Windows.Forms.TabControl tabcApprovals;
        private System.Windows.Forms.TabPage tabApprovals;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCodeReviewDATE;
        private System.Windows.Forms.TextBox txtCodeReviewBY;
        private System.Windows.Forms.TextBox txtTableParmNAME;
        private System.Windows.Forms.TextBox txtChangeManagemntRequestNumber;
        private System.Windows.Forms.TextBox txtPartner;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox grpImplementationReview;
        private System.Windows.Forms.RadioButton rbAbandonedI;
        private System.Windows.Forms.RadioButton rbBackedOutI;
        private System.Windows.Forms.RadioButton rbInstalledI;
        private System.Windows.Forms.GroupBox grpPostReview;
        private System.Windows.Forms.RadioButton rbAbandonedP;
        private System.Windows.Forms.RadioButton rbBackedOutP;
        private System.Windows.Forms.RadioButton rbInstalledP;
        private System.Windows.Forms.CheckBox cbCodeReview;
        private System.Windows.Forms.CheckBox cbPartnerApproval;
        private System.Windows.Forms.CheckBox cbPartnerSignOff;
        private System.Windows.Forms.CheckBox cbKeyUserSignOff;
        private System.Windows.Forms.CheckBox cbDevelopmentCompleted;
        private System.Windows.Forms.CheckBox cbTestingCompleted;
        private System.Windows.Forms.CheckBox cbtableParm;
        private System.Windows.Forms.CheckBox cbUserApproval;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabReview;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.TextBox txtApprovingManager;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtProjectManager;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtPerlScripts;
        private System.Windows.Forms.CheckBox cbXSLTEmailErrorHeader;
        private System.Windows.Forms.CheckBox cbRAILSrecord;
        private System.Windows.Forms.CheckBox cbEmailCodeList;
        private System.Windows.Forms.CheckBox cbRAILSfilter;
        private System.Windows.Forms.CheckBox cbFileStructureInProduction;
        private System.Windows.Forms.CheckBox cbFTPconnect;
        private System.Windows.Forms.CheckBox cbTRANSPORTparmfile;
        private System.Windows.Forms.CheckBox cbRAILStable;
        private System.Windows.Forms.CheckBox cbMapCodeTables;
        private System.Windows.Forms.CheckBox cbDocumentMap;
        private System.Windows.Forms.CheckBox cbDocumentExtractionMap;
        private System.Windows.Forms.CheckBox cbServiceAdapter;
        private System.Windows.Forms.CheckBox cbBusinessProcess;
        private System.Windows.Forms.CheckBox cbPerlScripts;
        private System.Windows.Forms.CheckBox cbEnvelopes;
        private System.Windows.Forms.DomainUpDown ddAttachments;

        public partial class Open_ApprovalFactory : Microsoft.Office.Tools.Outlook.IFormRegionFactory
        {
            public event Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler FormRegionInitializing;

            private Microsoft.Office.Tools.Outlook.FormRegionManifest _Manifest;

            [System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public Open_ApprovalFactory()
            {
                this._Manifest = Globals.Factory.CreateFormRegionManifest();
                Open_Approval.InitializeManifest(this._Manifest, Globals.Factory);
                this.FormRegionInitializing += new Microsoft.Office.Tools.Outlook.FormRegionInitializingEventHandler(this.Open_ApprovalFactory_FormRegionInitializing);
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
                Open_Approval form = new Open_Approval(formRegion);
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
        internal Open_Approval Open_Approval
        {
            get
            {
                foreach (var item in this)
                {
                    if (item.GetType() == typeof(Open_Approval))
                        return (Open_Approval)item;
                }
                return null;
            }
        }
    }
}
