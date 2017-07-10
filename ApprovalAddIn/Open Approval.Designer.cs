namespace ApprovalAddIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Open_Approval));
            this.txtCodeReviewDATE = new System.Windows.Forms.TextBox();
            this.txtCodeReviewBY = new System.Windows.Forms.TextBox();
            this.rbAbandonedI = new System.Windows.Forms.RadioButton();
            this.rbBackedOutI = new System.Windows.Forms.RadioButton();
            this.rbInstalledI = new System.Windows.Forms.RadioButton();
            this.rbAbandonedP = new System.Windows.Forms.RadioButton();
            this.rbBackedOutP = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.rbSuccessP = new System.Windows.Forms.RadioButton();
            this.txtTableParmNAME = new System.Windows.Forms.TextBox();
            this.txtChangeManagemntRequestNumber = new System.Windows.Forms.TextBox();
            this.txtPartner = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.grpImplementationReview = new System.Windows.Forms.GroupBox();
            this.grpPostReview = new System.Windows.Forms.GroupBox();
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
            this.lblTableParmName = new System.Windows.Forms.Label();
            this.lblCodeReviewBy = new System.Windows.Forms.Label();
            this.lblCodeReviewDate = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtProjectManager = new System.Windows.Forms.TextBox();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpImplementationReview.SuspendLayout();
            this.grpPostReview.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodeReviewDATE
            // 
            this.txtCodeReviewDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeReviewDATE.Location = new System.Drawing.Point(623, 451);
            this.txtCodeReviewDATE.Name = "txtCodeReviewDATE";
            this.txtCodeReviewDATE.Size = new System.Drawing.Size(139, 26);
            this.txtCodeReviewDATE.TabIndex = 96;
            this.txtCodeReviewDATE.TextChanged += new System.EventHandler(this.txtCodeReviewDATE_TextChanged);
            // 
            // txtCodeReviewBY
            // 
            this.txtCodeReviewBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeReviewBY.Location = new System.Drawing.Point(460, 447);
            this.txtCodeReviewBY.Name = "txtCodeReviewBY";
            this.txtCodeReviewBY.Size = new System.Drawing.Size(93, 26);
            this.txtCodeReviewBY.TabIndex = 87;
            this.txtCodeReviewBY.TextChanged += new System.EventHandler(this.txtCodeReviewBY_TextChanged);
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
            // 
            // rbInstalledI
            // 
            this.rbInstalledI.AutoSize = true;
            this.rbInstalledI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbInstalledI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInstalledI.Location = new System.Drawing.Point(13, 19);
            this.rbInstalledI.Name = "rbInstalledI";
            this.rbInstalledI.Size = new System.Drawing.Size(78, 22);
            this.rbInstalledI.TabIndex = 0;
            this.rbInstalledI.TabStop = true;
            this.rbInstalledI.Text = "Installed";
            this.rbInstalledI.UseVisualStyleBackColor = true;
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
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(702, 677);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(328, 163);
            this.txtDescription.TabIndex = 100;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // rbSuccessP
            // 
            this.rbSuccessP.AutoSize = true;
            this.rbSuccessP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSuccessP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuccessP.Location = new System.Drawing.Point(12, 19);
            this.rbSuccessP.Name = "rbSuccessP";
            this.rbSuccessP.Size = new System.Drawing.Size(83, 22);
            this.rbSuccessP.TabIndex = 0;
            this.rbSuccessP.TabStop = true;
            this.rbSuccessP.Text = "Success";
            this.rbSuccessP.UseVisualStyleBackColor = true;
            this.rbSuccessP.CheckedChanged += new System.EventHandler(this.rbSuccessP_CheckedChanged);
            // 
            // txtTableParmNAME
            // 
            this.txtTableParmNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableParmNAME.Location = new System.Drawing.Point(517, 287);
            this.txtTableParmNAME.Name = "txtTableParmNAME";
            this.txtTableParmNAME.Size = new System.Drawing.Size(182, 26);
            this.txtTableParmNAME.TabIndex = 86;
            this.txtTableParmNAME.TextChanged += new System.EventHandler(this.txtTableParmNAME_TextChanged);
            // 
            // txtChangeManagemntRequestNumber
            // 
            this.txtChangeManagemntRequestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeManagemntRequestNumber.Location = new System.Drawing.Point(702, 105);
            this.txtChangeManagemntRequestNumber.Name = "txtChangeManagemntRequestNumber";
            this.txtChangeManagemntRequestNumber.Size = new System.Drawing.Size(184, 26);
            this.txtChangeManagemntRequestNumber.TabIndex = 75;
            this.txtChangeManagemntRequestNumber.TextChanged += new System.EventHandler(this.txtChangeManagemntRequestNumber_TextChanged);
            // 
            // txtPartner
            // 
            this.txtPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartner.Location = new System.Drawing.Point(473, 33);
            this.txtPartner.Name = "txtPartner";
            this.txtPartner.Size = new System.Drawing.Size(237, 26);
            this.txtPartner.TabIndex = 73;
            this.txtPartner.TextChanged += new System.EventHandler(this.txtPartner_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(798, 33);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(149, 26);
            this.txtDate.TabIndex = 72;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(93, 36);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(237, 26);
            this.txtUser.TabIndex = 71;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(810, 655);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(91, 19);
            this.label31.TabIndex = 99;
            this.label31.Text = "Description:";
            // 
            // grpImplementationReview
            // 
            this.grpImplementationReview.Controls.Add(this.rbAbandonedI);
            this.grpImplementationReview.Controls.Add(this.rbBackedOutI);
            this.grpImplementationReview.Controls.Add(this.rbInstalledI);
            this.grpImplementationReview.Location = new System.Drawing.Point(307, 592);
            this.grpImplementationReview.Name = "grpImplementationReview";
            this.grpImplementationReview.Size = new System.Drawing.Size(308, 53);
            this.grpImplementationReview.TabIndex = 98;
            this.grpImplementationReview.TabStop = false;
            // 
            // grpPostReview
            // 
            this.grpPostReview.Controls.Add(this.rbAbandonedP);
            this.grpPostReview.Controls.Add(this.rbBackedOutP);
            this.grpPostReview.Controls.Add(this.rbSuccessP);
            this.grpPostReview.Location = new System.Drawing.Point(307, 671);
            this.grpPostReview.Name = "grpPostReview";
            this.grpPostReview.Size = new System.Drawing.Size(308, 53);
            this.grpPostReview.TabIndex = 97;
            this.grpPostReview.TabStop = false;
            // 
            // cbCodeReview
            // 
            this.cbCodeReview.AutoSize = true;
            this.cbCodeReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCodeReview.Location = new System.Drawing.Point(320, 453);
            this.cbCodeReview.Name = "cbCodeReview";
            this.cbCodeReview.Size = new System.Drawing.Size(97, 17);
            this.cbCodeReview.TabIndex = 95;
            this.cbCodeReview.Text = "cbCodeReview";
            this.cbCodeReview.UseVisualStyleBackColor = true;
            this.cbCodeReview.CheckedChanged += new System.EventHandler(this.cbCodeReview_CheckedChanged);
            // 
            // cbPartnerApproval
            // 
            this.cbPartnerApproval.AutoSize = true;
            this.cbPartnerApproval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPartnerApproval.Location = new System.Drawing.Point(319, 246);
            this.cbPartnerApproval.Name = "cbPartnerApproval";
            this.cbPartnerApproval.Size = new System.Drawing.Size(112, 17);
            this.cbPartnerApproval.TabIndex = 94;
            this.cbPartnerApproval.Text = "cbPartnerApproval";
            this.cbPartnerApproval.UseVisualStyleBackColor = true;
            this.cbPartnerApproval.CheckedChanged += new System.EventHandler(this.cbPartnerApproval_CheckedChanged);
            // 
            // cbPartnerSignOff
            // 
            this.cbPartnerSignOff.AutoSize = true;
            this.cbPartnerSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPartnerSignOff.Location = new System.Drawing.Point(320, 569);
            this.cbPartnerSignOff.Name = "cbPartnerSignOff";
            this.cbPartnerSignOff.Size = new System.Drawing.Size(105, 17);
            this.cbPartnerSignOff.TabIndex = 93;
            this.cbPartnerSignOff.Text = "cbPartnerSignOff";
            this.cbPartnerSignOff.UseVisualStyleBackColor = true;
            this.cbPartnerSignOff.CheckedChanged += new System.EventHandler(this.cbPartnerSignOff_CheckedChanged);
            // 
            // cbKeyUserSignOff
            // 
            this.cbKeyUserSignOff.AutoSize = true;
            this.cbKeyUserSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbKeyUserSignOff.Location = new System.Drawing.Point(320, 516);
            this.cbKeyUserSignOff.Name = "cbKeyUserSignOff";
            this.cbKeyUserSignOff.Size = new System.Drawing.Size(111, 17);
            this.cbKeyUserSignOff.TabIndex = 92;
            this.cbKeyUserSignOff.Text = "cbKeyUserSignOff";
            this.cbKeyUserSignOff.UseVisualStyleBackColor = true;
            this.cbKeyUserSignOff.CheckedChanged += new System.EventHandler(this.cbKeyUserSignOff_CheckedChanged);
            // 
            // cbDevelopmentCompleted
            // 
            this.cbDevelopmentCompleted.AutoSize = true;
            this.cbDevelopmentCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDevelopmentCompleted.Location = new System.Drawing.Point(320, 346);
            this.cbDevelopmentCompleted.Name = "cbDevelopmentCompleted";
            this.cbDevelopmentCompleted.Size = new System.Drawing.Size(149, 17);
            this.cbDevelopmentCompleted.TabIndex = 91;
            this.cbDevelopmentCompleted.Text = "cbDevelopmentCompleted";
            this.cbDevelopmentCompleted.UseVisualStyleBackColor = true;
            this.cbDevelopmentCompleted.CheckedChanged += new System.EventHandler(this.cbDevelopmentCompleted_CheckedChanged);
            // 
            // cbTestingCompleted
            // 
            this.cbTestingCompleted.AutoSize = true;
            this.cbTestingCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTestingCompleted.Location = new System.Drawing.Point(320, 396);
            this.cbTestingCompleted.Name = "cbTestingCompleted";
            this.cbTestingCompleted.Size = new System.Drawing.Size(121, 17);
            this.cbTestingCompleted.TabIndex = 90;
            this.cbTestingCompleted.Text = "cbTestingCompleted";
            this.cbTestingCompleted.UseVisualStyleBackColor = true;
            this.cbTestingCompleted.CheckedChanged += new System.EventHandler(this.cbTestingCompleted_CheckedChanged);
            // 
            // cbtableParm
            // 
            this.cbtableParm.AutoSize = true;
            this.cbtableParm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbtableParm.Location = new System.Drawing.Point(320, 293);
            this.cbtableParm.Name = "cbtableParm";
            this.cbtableParm.Size = new System.Drawing.Size(83, 17);
            this.cbtableParm.TabIndex = 89;
            this.cbtableParm.Text = "cbtableParm";
            this.cbtableParm.UseVisualStyleBackColor = true;
            this.cbtableParm.CheckedChanged += new System.EventHandler(this.cbtableParm_CheckedChanged);
            // 
            // cbUserApproval
            // 
            this.cbUserApproval.AutoSize = true;
            this.cbUserApproval.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbUserApproval.Location = new System.Drawing.Point(320, 198);
            this.cbUserApproval.Name = "cbUserApproval";
            this.cbUserApproval.Size = new System.Drawing.Size(100, 17);
            this.cbUserApproval.TabIndex = 88;
            this.cbUserApproval.Text = "cbUserApproval";
            this.cbUserApproval.UseVisualStyleBackColor = true;
            this.cbUserApproval.CheckedChanged += new System.EventHandler(this.cbUserApproval_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(67, 692);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 19);
            this.label14.TabIndex = 85;
            this.label14.Text = "Post Implementation Review:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(71, 614);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 19);
            this.label13.TabIndex = 84;
            this.label13.Text = "Implementation Final Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(144, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 19);
            this.label12.TabIndex = 83;
            this.label12.Text = "Key User SignOff:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(157, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 19);
            this.label11.TabIndex = 82;
            this.label11.Text = "Partner Signoff:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 19);
            this.label10.TabIndex = 81;
            this.label10.Text = "Code Review/Check Sign Off:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 19);
            this.label9.TabIndex = 80;
            this.label9.Text = "Developement Completed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 19);
            this.label8.TabIndex = 79;
            this.label8.Text = "Testing Completed (Attached Results):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 19);
            this.label7.TabIndex = 78;
            this.label7.Text = "Table/Parm Update:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "Partner Approval Of Initial Project:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "Users Approval of Project:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Change Management Request Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(388, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Partner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "User:";
            // 
            // cbXSLTEmailErrorHeader
            // 
            this.cbXSLTEmailErrorHeader.AutoSize = true;
            this.cbXSLTEmailErrorHeader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbXSLTEmailErrorHeader.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbXSLTEmailErrorHeader.Location = new System.Drawing.Point(17, 235);
            this.cbXSLTEmailErrorHeader.Name = "cbXSLTEmailErrorHeader";
            this.cbXSLTEmailErrorHeader.Size = new System.Drawing.Size(195, 23);
            this.cbXSLTEmailErrorHeader.TabIndex = 116;
            this.cbXSLTEmailErrorHeader.Text = "XSLT Email Error Header";
            this.cbXSLTEmailErrorHeader.UseVisualStyleBackColor = true;
            this.cbXSLTEmailErrorHeader.CheckedChanged += new System.EventHandler(this.cbXSLTEmailErrorHeader_CheckedChanged);
            // 
            // cbRAILSrecord
            // 
            this.cbRAILSrecord.AutoSize = true;
            this.cbRAILSrecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRAILSrecord.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAILSrecord.Location = new System.Drawing.Point(16, 330);
            this.cbRAILSrecord.Name = "cbRAILSrecord";
            this.cbRAILSrecord.Size = new System.Drawing.Size(146, 23);
            this.cbRAILSrecord.TabIndex = 115;
            this.cbRAILSrecord.Text = "RAILS csv Record";
            this.cbRAILSrecord.UseVisualStyleBackColor = true;
            this.cbRAILSrecord.CheckedChanged += new System.EventHandler(this.cbRAILSrecord_CheckedChanged);
            // 
            // cbEmailCodeList
            // 
            this.cbEmailCodeList.AutoSize = true;
            this.cbEmailCodeList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEmailCodeList.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmailCodeList.Location = new System.Drawing.Point(16, 148);
            this.cbEmailCodeList.Name = "cbEmailCodeList";
            this.cbEmailCodeList.Size = new System.Drawing.Size(132, 23);
            this.cbEmailCodeList.TabIndex = 103;
            this.cbEmailCodeList.Text = "Email Code List";
            this.cbEmailCodeList.UseVisualStyleBackColor = true;
            this.cbEmailCodeList.CheckedChanged += new System.EventHandler(this.cbEmailCodeList_CheckedChanged);
            // 
            // cbRAILSfilter
            // 
            this.cbRAILSfilter.AutoSize = true;
            this.cbRAILSfilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRAILSfilter.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAILSfilter.Location = new System.Drawing.Point(17, 359);
            this.cbRAILSfilter.Name = "cbRAILSfilter";
            this.cbRAILSfilter.Size = new System.Drawing.Size(132, 23);
            this.cbRAILSfilter.TabIndex = 114;
            this.cbRAILSfilter.Text = "RAILS csv Filter";
            this.cbRAILSfilter.UseVisualStyleBackColor = true;
            this.cbRAILSfilter.CheckedChanged += new System.EventHandler(this.cbRAILSfilter_CheckedChanged);
            // 
            // cbFileStructureInProduction
            // 
            this.cbFileStructureInProduction.AutoSize = true;
            this.cbFileStructureInProduction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFileStructureInProduction.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFileStructureInProduction.Location = new System.Drawing.Point(17, 389);
            this.cbFileStructureInProduction.Name = "cbFileStructureInProduction";
            this.cbFileStructureInProduction.Size = new System.Drawing.Size(215, 23);
            this.cbFileStructureInProduction.TabIndex = 113;
            this.cbFileStructureInProduction.Text = "File Structure In Production";
            this.cbFileStructureInProduction.UseVisualStyleBackColor = true;
            this.cbFileStructureInProduction.CheckedChanged += new System.EventHandler(this.cbFileStructureInProduction_CheckedChanged);
            // 
            // cbFTPconnect
            // 
            this.cbFTPconnect.AutoSize = true;
            this.cbFTPconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFTPconnect.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFTPconnect.Location = new System.Drawing.Point(17, 418);
            this.cbFTPconnect.Name = "cbFTPconnect";
            this.cbFTPconnect.Size = new System.Drawing.Size(112, 23);
            this.cbFTPconnect.TabIndex = 112;
            this.cbFTPconnect.Text = "FTP Connect";
            this.cbFTPconnect.UseVisualStyleBackColor = true;
            this.cbFTPconnect.CheckedChanged += new System.EventHandler(this.cbFTPconnect_CheckedChanged);
            // 
            // cbTRANSPORTparmfile
            // 
            this.cbTRANSPORTparmfile.AutoSize = true;
            this.cbTRANSPORTparmfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTRANSPORTparmfile.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTRANSPORTparmfile.Location = new System.Drawing.Point(17, 447);
            this.cbTRANSPORTparmfile.Name = "cbTRANSPORTparmfile";
            this.cbTRANSPORTparmfile.Size = new System.Drawing.Size(183, 23);
            this.cbTRANSPORTparmfile.TabIndex = 111;
            this.cbTRANSPORTparmfile.Text = "TRANSPORT Parm File";
            this.cbTRANSPORTparmfile.UseVisualStyleBackColor = true;
            this.cbTRANSPORTparmfile.CheckedChanged += new System.EventHandler(this.cbTRANSPORTparmfile_CheckedChanged);
            // 
            // cbRAILStable
            // 
            this.cbRAILStable.AutoSize = true;
            this.cbRAILStable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRAILStable.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRAILStable.Location = new System.Drawing.Point(17, 299);
            this.cbRAILStable.Name = "cbRAILStable";
            this.cbRAILStable.Size = new System.Drawing.Size(141, 23);
            this.cbRAILStable.TabIndex = 110;
            this.cbRAILStable.Text = "RAILS csv Tables";
            this.cbRAILStable.UseVisualStyleBackColor = true;
            this.cbRAILStable.CheckedChanged += new System.EventHandler(this.cbRAILStable_CheckedChanged);
            // 
            // cbMapCodeTables
            // 
            this.cbMapCodeTables.AutoSize = true;
            this.cbMapCodeTables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMapCodeTables.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMapCodeTables.Location = new System.Drawing.Point(17, 270);
            this.cbMapCodeTables.Name = "cbMapCodeTables";
            this.cbMapCodeTables.Size = new System.Drawing.Size(145, 23);
            this.cbMapCodeTables.TabIndex = 109;
            this.cbMapCodeTables.Text = "Map Code Tables";
            this.cbMapCodeTables.UseVisualStyleBackColor = true;
            this.cbMapCodeTables.CheckedChanged += new System.EventHandler(this.cbMapCodeTables_CheckedChanged);
            // 
            // cbDocumentMap
            // 
            this.cbDocumentMap.AutoSize = true;
            this.cbDocumentMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDocumentMap.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocumentMap.Location = new System.Drawing.Point(17, 177);
            this.cbDocumentMap.Name = "cbDocumentMap";
            this.cbDocumentMap.Size = new System.Drawing.Size(140, 23);
            this.cbDocumentMap.TabIndex = 108;
            this.cbDocumentMap.Text = "Document Maps";
            this.cbDocumentMap.UseVisualStyleBackColor = true;
            this.cbDocumentMap.CheckedChanged += new System.EventHandler(this.cbDocumentMap_CheckedChanged);
            // 
            // cbDocumentExtractionMap
            // 
            this.cbDocumentExtractionMap.AutoSize = true;
            this.cbDocumentExtractionMap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDocumentExtractionMap.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocumentExtractionMap.Location = new System.Drawing.Point(17, 206);
            this.cbDocumentExtractionMap.Name = "cbDocumentExtractionMap";
            this.cbDocumentExtractionMap.Size = new System.Drawing.Size(205, 23);
            this.cbDocumentExtractionMap.TabIndex = 107;
            this.cbDocumentExtractionMap.Text = "Document Extraction Map";
            this.cbDocumentExtractionMap.UseVisualStyleBackColor = true;
            this.cbDocumentExtractionMap.CheckedChanged += new System.EventHandler(this.cbDocumentExtractionMap_CheckedChanged);
            // 
            // cbServiceAdapter
            // 
            this.cbServiceAdapter.AutoSize = true;
            this.cbServiceAdapter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbServiceAdapter.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServiceAdapter.Location = new System.Drawing.Point(17, 90);
            this.cbServiceAdapter.Name = "cbServiceAdapter";
            this.cbServiceAdapter.Size = new System.Drawing.Size(135, 23);
            this.cbServiceAdapter.TabIndex = 106;
            this.cbServiceAdapter.Text = "Service Adapter";
            this.cbServiceAdapter.UseVisualStyleBackColor = true;
            this.cbServiceAdapter.CheckedChanged += new System.EventHandler(this.cbServiceAdapter_CheckedChanged);
            // 
            // cbBusinessProcess
            // 
            this.cbBusinessProcess.AutoSize = true;
            this.cbBusinessProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbBusinessProcess.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusinessProcess.Location = new System.Drawing.Point(16, 61);
            this.cbBusinessProcess.Name = "cbBusinessProcess";
            this.cbBusinessProcess.Size = new System.Drawing.Size(143, 23);
            this.cbBusinessProcess.TabIndex = 105;
            this.cbBusinessProcess.Text = "Business Process";
            this.cbBusinessProcess.UseVisualStyleBackColor = true;
            this.cbBusinessProcess.CheckedChanged += new System.EventHandler(this.cbBusinessProcess_CheckedChanged);
            // 
            // cbPerlScripts
            // 
            this.cbPerlScripts.AutoSize = true;
            this.cbPerlScripts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPerlScripts.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerlScripts.Location = new System.Drawing.Point(16, 119);
            this.cbPerlScripts.Name = "cbPerlScripts";
            this.cbPerlScripts.Size = new System.Drawing.Size(104, 23);
            this.cbPerlScripts.TabIndex = 104;
            this.cbPerlScripts.Text = "Perl Scripts";
            this.cbPerlScripts.UseVisualStyleBackColor = true;
            this.cbPerlScripts.CheckedChanged += new System.EventHandler(this.cbPerlScripts_CheckedChanged);
            // 
            // cbEnvelopes
            // 
            this.cbEnvelopes.AutoSize = true;
            this.cbEnvelopes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEnvelopes.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnvelopes.Location = new System.Drawing.Point(16, 32);
            this.cbEnvelopes.Name = "cbEnvelopes";
            this.cbEnvelopes.Size = new System.Drawing.Size(96, 23);
            this.cbEnvelopes.TabIndex = 118;
            this.cbEnvelopes.Text = "Envelopes";
            this.cbEnvelopes.UseVisualStyleBackColor = true;
            this.cbEnvelopes.CheckedChanged += new System.EventHandler(this.cbEnvelopes_CheckedChanged);
            // 
            // lblTableParmName
            // 
            this.lblTableParmName.AutoSize = true;
            this.lblTableParmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableParmName.Location = new System.Drawing.Point(456, 295);
            this.lblTableParmName.Name = "lblTableParmName";
            this.lblTableParmName.Size = new System.Drawing.Size(55, 20);
            this.lblTableParmName.TabIndex = 120;
            this.lblTableParmName.Text = "Name:";
            // 
            // lblCodeReviewBy
            // 
            this.lblCodeReviewBy.AutoSize = true;
            this.lblCodeReviewBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeReviewBy.Location = new System.Drawing.Point(429, 457);
            this.lblCodeReviewBy.Name = "lblCodeReviewBy";
            this.lblCodeReviewBy.Size = new System.Drawing.Size(31, 20);
            this.lblCodeReviewBy.TabIndex = 121;
            this.lblCodeReviewBy.Text = "By:";
            // 
            // lblCodeReviewDate
            // 
            this.lblCodeReviewDate.AutoSize = true;
            this.lblCodeReviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeReviewDate.Location = new System.Drawing.Point(569, 460);
            this.lblCodeReviewDate.Name = "lblCodeReviewDate";
            this.lblCodeReviewDate.Size = new System.Drawing.Size(48, 20);
            this.lblCodeReviewDate.TabIndex = 122;
            this.lblCodeReviewDate.Text = "Date:";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.cbRAILSrecord);
            this.grpOptions.Controls.Add(this.cbRAILStable);
            this.grpOptions.Controls.Add(this.cbEnvelopes);
            this.grpOptions.Controls.Add(this.cbBusinessProcess);
            this.grpOptions.Controls.Add(this.cbPerlScripts);
            this.grpOptions.Controls.Add(this.cbEmailCodeList);
            this.grpOptions.Controls.Add(this.cbTRANSPORTparmfile);
            this.grpOptions.Controls.Add(this.cbDocumentMap);
            this.grpOptions.Controls.Add(this.cbFTPconnect);
            this.grpOptions.Controls.Add(this.cbFileStructureInProduction);
            this.grpOptions.Controls.Add(this.cbRAILSfilter);
            this.grpOptions.Controls.Add(this.cbDocumentExtractionMap);
            this.grpOptions.Controls.Add(this.cbServiceAdapter);
            this.grpOptions.Controls.Add(this.cbXSLTEmailErrorHeader);
            this.grpOptions.Controls.Add(this.cbMapCodeTables);
            this.grpOptions.Location = new System.Drawing.Point(798, 146);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(234, 487);
            this.grpOptions.TabIndex = 123;
            this.grpOptions.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(248, 778);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 20);
            this.label19.TabIndex = 124;
            this.label19.Text = "Project Manager:";
            // 
            // txtProjectManager
            // 
            this.txtProjectManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectManager.Location = new System.Drawing.Point(383, 778);
            this.txtProjectManager.Name = "txtProjectManager";
            this.txtProjectManager.Size = new System.Drawing.Size(207, 19);
            this.txtProjectManager.TabIndex = 126;
            this.txtProjectManager.TextChanged += new System.EventHandler(this.txtProjectManager_TextChanged);
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletionDate.Location = new System.Drawing.Point(89, 0);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(82, 13);
            this.lblCompletionDate.TabIndex = 127;
            this.lblCompletionDate.Text = "CompletionDate";
            // 
            // btnReject
            // 
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Image = ((System.Drawing.Image)(resources.GetObject("btnReject.Image")));
            this.btnReject.Location = new System.Drawing.Point(505, 803);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(48, 53);
            this.btnReject.TabIndex = 129;
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 13);
            this.lblStatus.TabIndex = 102;
            this.lblStatus.Text = "status here";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(42, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 130;
            this.label15.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(93, 105);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(237, 26);
            this.txtTitle.TabIndex = 131;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(394, 810);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 132;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Open_Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.txtProjectManager);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblCodeReviewDate);
            this.Controls.Add(this.lblCodeReviewBy);
            this.Controls.Add(this.lblTableParmName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCodeReviewDATE);
            this.Controls.Add(this.txtCodeReviewBY);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTableParmNAME);
            this.Controls.Add(this.txtChangeManagemntRequestNumber);
            this.Controls.Add(this.txtPartner);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.grpImplementationReview);
            this.Controls.Add(this.grpPostReview);
            this.Controls.Add(this.cbCodeReview);
            this.Controls.Add(this.cbPartnerApproval);
            this.Controls.Add(this.cbPartnerSignOff);
            this.Controls.Add(this.cbKeyUserSignOff);
            this.Controls.Add(this.cbDevelopmentCompleted);
            this.Controls.Add(this.cbTestingCompleted);
            this.Controls.Add(this.cbtableParm);
            this.Controls.Add(this.cbUserApproval);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Open_Approval";
            this.Size = new System.Drawing.Size(1057, 910);
            this.FormRegionShowing += new System.EventHandler(this.Open_Approval_FormRegionShowing);
            this.FormRegionClosed += new System.EventHandler(this.Open_Approval_FormRegionClosed);
            this.grpImplementationReview.ResumeLayout(false);
            this.grpImplementationReview.PerformLayout();
            this.grpPostReview.ResumeLayout(false);
            this.grpPostReview.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtCodeReviewDATE;
        private System.Windows.Forms.TextBox txtCodeReviewBY;
        private System.Windows.Forms.RadioButton rbAbandonedI;
        private System.Windows.Forms.RadioButton rbBackedOutI;
        private System.Windows.Forms.RadioButton rbInstalledI;
        private System.Windows.Forms.RadioButton rbAbandonedP;
        private System.Windows.Forms.RadioButton rbBackedOutP;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.RadioButton rbSuccessP;
        private System.Windows.Forms.TextBox txtTableParmNAME;
        private System.Windows.Forms.TextBox txtChangeManagemntRequestNumber;
        private System.Windows.Forms.TextBox txtPartner;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox grpImplementationReview;
        private System.Windows.Forms.GroupBox grpPostReview;
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
        private System.Windows.Forms.Label lblTableParmName;
        private System.Windows.Forms.Label lblCodeReviewBy;
        private System.Windows.Forms.Label lblCodeReviewDate;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtProjectManager;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSave;

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
