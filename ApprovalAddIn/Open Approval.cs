using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Web.Services.Description;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;



namespace ApprovalAddIn
{
    partial class Open_Approval
    {

        String User, Partner, CMRN, tableParmName, codeReviewBY, codeReviewDate, impFinalStatus, PostImpReview, ProjectManager, CompletionDate, sendTo, Description, Title;
        String currentDate = DateTime.Today.ToShortDateString();
        String from = "Charlton.Williams@sonoco.com";
        bool UAOP, PAOIP, tableParm, developementCompleted, testingCompleted, codeReview, keyUserSignOff, partnerSignOff, Envelopes, BP, ServiceAdapters, perlScripts, EmailCodeList, docMaps, docExtractionMap, XSLTEmail;


        private String [] InitialAndUsername;
        private String Password;


        bool mapCodeTables, RAILStable, RAILSrecord, RAILSfilter, fileStructureProd, FTPconnect, TRANSPORTfile;
        private List<String> attachments = new List<string>();
        


        #region Form Region Factory 

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass(Microsoft.Office.Tools.Outlook.FormRegionMessageClassAttribute.Note)]
        [Microsoft.Office.Tools.Outlook.FormRegionName("ApprovalAddIn.Open Approval")]
        public partial class Open_ApprovalFactory
        {
            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            private void Open_ApprovalFactory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
                Outlook.MailItem mailItem = (Outlook.MailItem)e.OutlookItem;

                if (mailItem != null)
                {
                    if (mailItem.Body != null && mailItem.Body.Trim().Length > 0)
                    {
                        return;
                    }
                }
                e.Cancel = true;

            }
        }

        #endregion

        // Occurs before the form region is displayed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void Open_Approval_FormRegionShowing(object sender, System.EventArgs e)
        {
            Outlook.MailItem mailItem = (Outlook.MailItem)this.OutlookItem;
            String subject = mailItem.Subject;

            //Sends to Approving Manager from Project Manager
            if (subject.Contains("Needs Approval"))
            {
                lblStatus.Text = "Needs Approval";
                lblTestEmail.Text = mailItem.To;

                String body = mailItem.Body;

                this.InitialAndUsername = UsernameEmail(mailItem.To);
           
                String[] lines = body.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length && !lines[i].Equals("-----------------------------------------"); ++i)
                {

                    int firstSpace = lines[i].IndexOf(" ");
                    if (firstSpace > 0)
                    {
                        //  String[] ItemValue = lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        String item = lines[i].Substring(0, firstSpace).Trim();
                        String value = lines[i].Substring(firstSpace).Trim();


                        if (item.Equals("Status"))
                        {
                            lblStatus.Text = value;
                            continue;
                        }

                        if (item.Equals("User"))
                        {
                            txtUser.Text = value;
                            continue;
                        }
                        if (item.Equals("Partner"))
                        {
                            txtPartner.Text = value; continue;
                        }
                        if (item.Equals("Date"))
                        {
                            txtDate.Text = value; continue;
                        }
                        if (item.Equals("ChangeManagementRequestNumber"))
                        {
                            txtChangeManagemntRequestNumber.Text = value; continue;

                        }
                        if (item.Equals("UserApprovalofProject"))
                        {
                            cbUserApproval.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PartnerApprovalofInitialProject"))
                        {
                            cbPartnerApproval.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("Table/ParmUpdate"))
                        {
                            cbtableParm.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("Table/ParmName"))
                        {
                            txtTableParmNAME.Text = value; continue;
                        }
                        if (item.Equals("DevelopmentCompleted"))
                        {
                            cbDevelopmentCompleted.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("TestingCompleted"))
                        {
                            cbTestingCompleted.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("CodeReview/CheckSignOff"))
                        {
                            cbCodeReview.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("CodeReviewBy"))
                        {
                            txtCodeReviewBY.Text = value; continue;
                        }
                        if (item.Equals("CodeReviewDate"))
                        {
                            txtCodeReviewDATE.Text = value; continue;
                        }
                        if (item.Equals("KeyUserSignoff"))
                        {
                            cbKeyUserSignOff.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PartnerSignoff"))
                        {
                            cbPartnerSignOff.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("ImplementationFinalStatus"))
                        {

                            impFinalStatus = value;

                            if (value.Equals("Installed"))
                            {
                                rbInstalledI.Checked = true;

                            }
                            if (value.Equals("Backed Out"))
                            {
                                rbBackedOutI.Checked = true;
                            }
                            if (value.Equals("Abandoned"))
                            {
                                rbAbandonedI.Checked = true;
                            }
                            continue;
                        }
                        if (item.Equals("PostImplementationReview"))
                        {

                            PostImpReview = value;

                            if (value.Equals("Success"))
                            {
                                rbSuccessP.Checked = true;
                            }
                            if (value.Equals("Backed Out"))
                            {
                                rbBackedOutP.Checked = true;
                            }
                            if (value.Equals("Abandoned"))
                            {
                                rbAbandonedP.Checked = true;
                            }
                            continue;
                        }
                        if (item.Equals("Envelopes"))
                        {
                            cbEnvelopes.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("BusinessProcess"))
                        {
                            cbBusinessProcess.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("ServiceAdapters"))
                        {

                            cbServiceAdapter.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PerlScripts"))
                        {
                            cbPerlScripts.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("EmailCodeList"))
                        {
                            cbEmailCodeList.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("DocumentMaps"))
                        {

                            cbDocumentMap.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("DocumentExtractionMap"))
                        {
                            cbDocumentExtractionMap.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("XSLTEmailErrorHeader"))
                        {
                            cbXSLTEmailErrorHeader.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("MapCodeTables"))
                        {

                            cbMapCodeTables.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("RAILScsvTable"))
                        {
                            cbRAILStable.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("RAILScsvRecord"))
                        {
                            cbRAILSrecord.Checked = bool.Parse(value); continue;


                        }
                        if (item.Equals("RAILScsvFilter"))
                        {
                            cbRAILSfilter.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("FileStructureinProduction"))
                        {
                            cbFileStructureInProduction.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("FTPConnect"))
                        {
                            cbFTPconnect.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("TRANSPORTParmFile"))
                        {
                            cbTRANSPORTparmfile.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("ProjectManager"))
                        {
                            txtProjectManager.Text = value;
                        }
                        if (item.Equals("Title"))
                        {
                            txtTitle.Text = value;
                        }
                        if (item.Equals("Description"))
                        {
                            txtDescription.Text = value;
                        }

                    }
                }

                StringBuilder attachmentInfo = new StringBuilder();
                
               


                lblCompletionDate.Visible = false;
                cbtableParm.Enabled = false;
                btnSave.Enabled = false;
                cbBusinessProcess.Enabled = false;
                cbDevelopmentCompleted.Enabled = false;
                cbDocumentExtractionMap.Enabled = false;
                cbDocumentMap.Enabled = false;
                cbEmailCodeList.Enabled = false;
                cbEnvelopes.Enabled = false;
                cbFileStructureInProduction.Enabled = false;
                cbFTPconnect.Enabled = false;
                cbKeyUserSignOff.Enabled = false;
                cbMapCodeTables.Enabled = false;
                cbPartnerApproval.Enabled = false;
                cbPartnerSignOff.Enabled = false;
                cbPerlScripts.Enabled = false;
                cbRAILSfilter.Enabled = false;
                cbRAILSrecord.Enabled = false;
                cbRAILStable.Enabled = false;
                cbServiceAdapter.Enabled = false;
                cbTestingCompleted.Enabled = false;
                cbTRANSPORTparmfile.Enabled = false;
                cbUserApproval.Enabled = false;
                cbXSLTEmailErrorHeader.Enabled = false;
                //txtApprovingManager.Enabled = false;
                txtChangeManagemntRequestNumber.Enabled = false;
                txtDate.Enabled = false;
                txtDescription.Enabled = false;
                txtPartner.Enabled = false;
                txtProjectManager.Enabled = false;
                txtTableParmNAME.Enabled = false;
                txtUser.Enabled = false;
                txtCodeReviewBY.Enabled = false;
                txtTitle.Enabled = false;
                txtCodeReviewDATE.Enabled = false;
                rbAbandonedI.Enabled = false;
                rbBackedOutI.Enabled = false;
                rbInstalledI.Enabled = false;
                rbSuccessP.Enabled = true;
                rbAbandonedP.Enabled = true;
                rbBackedOutP.Enabled = true;
                lblCodeReviewBy.Enabled = false;
                lblCodeReviewDate.Enabled = false;

                // txtApprovingManager.Text = mailItem.To;


                


            }




            //Sends to Project Manager from Approving Manager. Successful Approval
            if (subject.Contains("Approved!"))
            {
                lblStatus.Text = "Approved";


                String body = mailItem.Body;

                

                String[] lines = body.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length && !lines[i].Equals(""); ++i)
                {

                    int firstSpace = lines[i].IndexOf("\t");
                    if (firstSpace > 0)
                    {
                        //  String[] ItemValue = lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        String item = lines[i].Substring(0, firstSpace).Trim();
                        String value = lines[i].Substring(firstSpace).Trim();


                        if (item.Equals("Status"))
                        {
                            lblStatus.Text = value;
                            continue;
                        }

                        if (item.Equals("User"))
                        {
                            txtUser.Text = value;
                            continue;
                        }
                        if (item.Equals("Partner"))
                        {
                            txtPartner.Text = value; continue;
                        }
                        if (item.Equals("Date"))
                        {
                            txtDate.Text = value; continue;
                        }
                        if (item.Equals("ChangeManagementRequestNumber"))
                        {
                            txtChangeManagemntRequestNumber.Text = value; continue;

                        }
                        if (item.Equals("UserApprovalofProject"))
                        {
                            cbUserApproval.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PartnerApprovalofInitialProject"))
                        {
                            cbPartnerApproval.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("Table/ParmUpdate"))
                        {
                            cbtableParm.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("Table/ParmName"))
                        {
                            txtTableParmNAME.Text = value; continue;
                        }
                        if (item.Equals("DevelopmentCompleted"))
                        {
                            cbDevelopmentCompleted.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("TestingCompleted"))
                        {
                            cbTestingCompleted.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("CodeReview/CheckSignOff"))
                        {
                            cbCodeReview.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("CodeReviewBy"))
                        {
                            txtCodeReviewBY.Text = value; continue;
                        }
                        if (item.Equals("CodeReviewDate"))
                        {
                            txtCodeReviewDATE.Text = value; continue;
                        }
                        if (item.Equals("KeyUserSignoff"))
                        {
                            cbKeyUserSignOff.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PartnerSignoff"))
                        {
                            cbPartnerSignOff.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("ImplementationFinalStatus"))
                        {

                            impFinalStatus = value;

                            if (value.Equals("Installed"))
                            {
                                rbInstalledI.Checked = true;

                            }
                            if (value.Equals("Backed Out"))
                            {
                                rbBackedOutI.Checked = true;
                            }
                            if (value.Equals("Abandoned"))
                            {
                                rbAbandonedI.Checked = true;
                            }
                            continue;
                        }
                        if (item.Equals("PostImplementationReview"))
                        {

                            PostImpReview = value;

                            if (value.Equals("Success"))
                            {
                                rbSuccessP.Checked = true;
                            }
                            if (value.Equals("Backed Out"))
                            {
                                rbBackedOutP.Checked = true;
                            }
                            if (value.Equals("Abandoned"))
                            {
                                rbAbandonedP.Checked = true;
                            }
                            continue;
                        }
                        if (item.Equals("Envelopes"))
                        {
                            cbEnvelopes.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("BusinessProcess"))
                        {
                            cbBusinessProcess.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("ServiceAdapters"))
                        {

                            cbServiceAdapter.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PerlScripts"))
                        {
                            cbPerlScripts.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("EmailCodeList"))
                        {
                            cbEmailCodeList.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("DocumentMaps"))
                        {

                            cbDocumentMap.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("DocumentExtractionMap"))
                        {
                            cbDocumentExtractionMap.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("XSLTEmailErrorHeader"))
                        {
                            cbXSLTEmailErrorHeader.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("MapCodeTables"))
                        {

                            cbMapCodeTables.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("RAILScsvTable"))
                        {
                            cbRAILStable.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("RAILScsvRecord"))
                        {
                            cbRAILSrecord.Checked = bool.Parse(value); continue;


                        }
                        if (item.Equals("RAILScsvFilter"))
                        {
                            cbRAILSfilter.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("FileStructureinProduction"))
                        {
                            cbFileStructureInProduction.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("FTPConnect"))
                        {
                            cbFTPconnect.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("TRANSPORTParmFile"))
                        {
                            cbTRANSPORTparmfile.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("ProjectManager"))
                        {
                            txtProjectManager.Text = value;
                        }
                        if (item.Equals("Title"))
                        {
                            txtTitle.Text = value;
                        }
                        if (item.Equals("Description"))
                        {
                            txtDescription.Text = value;
                        }
                        if (item.Equals("CompletionDate"))
                        {
                            lblCompletionDate.Text = value;
                        }
                    }

                }

                lblCompletionDate.Visible = true;

                cbtableParm.Enabled = false;
               
                cbBusinessProcess.Enabled = false;
                cbDevelopmentCompleted.Enabled = false;
                cbDocumentExtractionMap.Enabled = false;
                cbDocumentMap.Enabled = false;
                cbEmailCodeList.Enabled = false;
                cbEnvelopes.Enabled = false;
                cbFileStructureInProduction.Enabled = false;
                cbFTPconnect.Enabled = false;
                cbKeyUserSignOff.Enabled = false;
                cbMapCodeTables.Enabled = false;
                cbPartnerApproval.Enabled = false;
                cbPartnerSignOff.Enabled = false;
                cbPerlScripts.Enabled = false;
                cbRAILSfilter.Enabled = false;
                cbRAILSrecord.Enabled = false;
                cbRAILStable.Enabled = false;
                cbServiceAdapter.Enabled = false;
                cbTestingCompleted.Enabled = false;
                cbTRANSPORTparmfile.Enabled = false;
                cbUserApproval.Enabled = false;
                cbXSLTEmailErrorHeader.Enabled = false;
                //txtApprovingManager.Enabled = false;
                txtChangeManagemntRequestNumber.Enabled = false;
                txtDate.Enabled = false;
                txtDescription.Enabled = false;
                txtPartner.Enabled = false;
                txtProjectManager.Enabled = false;
                txtTableParmNAME.Enabled = false;
                txtUser.Enabled = false;
                txtCodeReviewBY.Enabled = false;
                txtTitle.Enabled = false;
                txtCodeReviewDATE.Enabled = false;
                rbAbandonedI.Enabled = false;
                rbBackedOutI.Enabled = false;
                rbInstalledI.Enabled = false;
                rbSuccessP.Enabled = true;
                rbAbandonedP.Enabled = true;
                rbBackedOutP.Enabled = true;
                lblCodeReviewBy.Enabled = false;
                lblCodeReviewDate.Enabled = false;
                //btnApprove.Visible = false;
                btnReject.Visible = false;
                // txtApprovingManager.Text = mailItem.To;

            }




            //Sends to Project Manager from Approving Manager. UnSuccessful Approval
            if (subject.Contains("Not Approved"))
            {
                lblStatus.Text = "Not Approved";


                String body = mailItem.Body;


                String[] lines = body.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length && !lines[i].Equals(""); ++i)
                {

                    int firstSpace = lines[i].IndexOf("\t");
                    if (firstSpace > 0)
                    {
                        //  String[] ItemValue = lines[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        String item = lines[i].Substring(0, firstSpace).Trim();
                        String value = lines[i].Substring(firstSpace).Trim();


                        if (item.Equals("Status"))
                        {
                            lblStatus.Text = value;
                            continue;
                        }

                        if (item.Equals("User"))
                        {
                            txtUser.Text = value;
                            continue;
                        }
                        if (item.Equals("Partner"))
                        {
                            txtPartner.Text = value; continue;
                        }
                        if (item.Equals("Date"))
                        {
                            txtDate.Text = value; continue;
                        }
                        if (item.Equals("ChangeManagementRequestNumber"))
                        {
                            txtChangeManagemntRequestNumber.Text = value; continue;

                        }
                        if (item.Equals("UserApprovalofProject"))
                        {
                            cbUserApproval.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PartnerApprovalofInitialProject"))
                        {
                            cbPartnerApproval.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("Table/ParmUpdate"))
                        {
                            cbtableParm.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("Table/ParmName"))
                        {
                            txtTableParmNAME.Text = value; continue;
                        }
                        if (item.Equals("DevelopmentCompleted"))
                        {
                            cbDevelopmentCompleted.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("TestingCompleted"))
                        {
                            cbTestingCompleted.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("CodeReview/CheckSignOff"))
                        {
                            cbCodeReview.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("CodeReviewBy"))
                        {
                            txtCodeReviewBY.Text = value; continue;
                        }
                        if (item.Equals("CodeReviewDate"))
                        {
                            txtCodeReviewDATE.Text = value; continue;
                        }
                        if (item.Equals("KeyUserSignoff"))
                        {
                            cbKeyUserSignOff.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PartnerSignoff"))
                        {
                            cbPartnerSignOff.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("ImplementationFinalStatus"))
                        {

                            impFinalStatus = value;

                            if (value.Equals("Installed"))
                            {
                                rbInstalledI.Checked = true;

                            }
                            if (value.Equals("Backed Out"))
                            {
                                rbBackedOutI.Checked = true;
                            }
                            if (value.Equals("Abandoned"))
                            {
                                rbAbandonedI.Checked = true;
                            }
                            continue;
                        }
                        if (item.Equals("PostImplementationReview"))
                        {

                            PostImpReview = value;

                            if (value.Equals("Success"))
                            {
                                rbSuccessP.Checked = true;
                            }
                            if (value.Equals("Backed Out"))
                            {
                                rbBackedOutP.Checked = true;
                            }
                            if (value.Equals("Abandoned"))
                            {
                                rbAbandonedP.Checked = true;
                            }
                            continue;
                        }
                        if (item.Equals("Envelopes"))
                        {
                            cbEnvelopes.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("BusinessProcess"))
                        {
                            cbBusinessProcess.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("ServiceAdapters"))
                        {

                            cbServiceAdapter.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("PerlScripts"))
                        {
                            cbPerlScripts.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("EmailCodeList"))
                        {
                            cbEmailCodeList.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("DocumentMaps"))
                        {

                            cbDocumentMap.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("DocumentExtractionMap"))
                        {
                            cbDocumentExtractionMap.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("XSLTEmailErrorHeader"))
                        {
                            cbXSLTEmailErrorHeader.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("MapCodeTables"))
                        {

                            cbMapCodeTables.Checked = bool.Parse(value); continue;
                        }
                        if (item.Equals("RAILScsvTable"))
                        {
                            cbRAILStable.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("RAILScsvRecord"))
                        {
                            cbRAILSrecord.Checked = bool.Parse(value); continue;


                        }
                        if (item.Equals("RAILScsvFilter"))
                        {
                            cbRAILSfilter.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("FileStructureinProduction"))
                        {
                            cbFileStructureInProduction.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("FTPConnect"))
                        {
                            cbFTPconnect.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("TRANSPORTParmFile"))
                        {
                            cbTRANSPORTparmfile.Checked = bool.Parse(value); continue;

                        }
                        if (item.Equals("ProjectManager"))
                        {
                            txtProjectManager.Text = value;
                        }
                        if (item.Equals("Title"))
                        {
                            txtTitle.Text = value;
                        }
                        if (item.Equals("Description"))
                        {
                            txtDescription.Text = value;
                        }
                        if (item.Equals("CompletionDate"))
                        {
                            lblCompletionDate.Text = value;
                        }
                    }

                    

                    // txtApprovingManager.Text = mailItem.To;
                }

                
                lblCompletionDate.Visible = true;
                cbtableParm.Enabled = false;
                cbBusinessProcess.Enabled = false;
                cbDevelopmentCompleted.Enabled = false;
                cbDocumentExtractionMap.Enabled = false;
                cbDocumentMap.Enabled = false;
                cbEmailCodeList.Enabled = false;
                cbEnvelopes.Enabled = false;
                cbFileStructureInProduction.Enabled = false;
                cbFTPconnect.Enabled = false;
                cbKeyUserSignOff.Enabled = false;
                cbMapCodeTables.Enabled = false;
                txtCodeReviewBY.Enabled = false;
                txtCodeReviewDATE.Enabled = false;
                cbPartnerApproval.Enabled = false;
                cbPartnerSignOff.Enabled = false;
                cbPerlScripts.Enabled = false;
                cbRAILSfilter.Enabled = false;
                cbRAILSrecord.Enabled = false;
                cbRAILStable.Enabled = false;
                cbServiceAdapter.Enabled = false;
                cbTestingCompleted.Enabled = false;
                cbTRANSPORTparmfile.Enabled = false;
                cbUserApproval.Enabled = false;
                cbXSLTEmailErrorHeader.Enabled = false;
                //txtApprovingManager.Enabled = false;
                txtChangeManagemntRequestNumber.Enabled = false;
                txtDate.Enabled = false;
                txtDescription.Enabled = false;
                txtPartner.Enabled = false;
                txtProjectManager.Enabled = false;
                txtTableParmNAME.Enabled = false;
                txtUser.Enabled = false;
                txtCodeReviewBY.Enabled = false;
                txtTitle.Enabled = false;
                txtCodeReviewDATE.Enabled = false;
                rbAbandonedI.Enabled = false;
                rbBackedOutI.Enabled = false;
                rbInstalledI.Enabled = false;
                rbSuccessP.Enabled = false;
                rbAbandonedP.Enabled = false;
                rbBackedOutP.Enabled = false;
                lblCodeReviewBy.Enabled = false;
                lblCodeReviewDate.Enabled = false;
                btnSave.Visible = false;
               
                btnReject.Visible = false;

            }


        }

        private String []  UsernameEmail(String name)
        {

            String[] flname = name.Split(' ');
            String periodIncluded = flname[0] + "." + flname[1];
            String initials = flname[0].ToCharArray()[0].ToString()+ flname[1].ToCharArray()[0].ToString();

           

            String[] nameVariables = new String[] { initials, periodIncluded + "@sonoco.com" };

            return nameVariables;
            
        }

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void Open_Approval_FormRegionClosed(object sender, System.EventArgs e)
        {

        }


        private void btnApprove_Click(object sender, EventArgs e)
        {

        }


        
        public void SendNotApproved(String[] lineTitles, String[] lineAnswers, Outlook.MailItem mailItem)
        {

            StringBuilder stringbuilder = new StringBuilder();



            for (int i = 0; i < lineTitles.Length; i++)
            {
                stringbuilder.AppendLine(lineTitles[i] + "\t" + lineAnswers[i]);
            }

            String body = stringbuilder.ToString();
            String Subject = "Not Approved for" + User + " and Partner " + Partner;


            Outlook.MailItem ReplyEmail = mailItem.Reply();
            ReplyEmail.Subject = Subject;
            ReplyEmail.Body = body;
            ReplyEmail.Importance = Outlook.OlImportance.olImportanceHigh;
            ReplyEmail.Send();



        }

        private void rbInstalledI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInstalledI.Checked == true)
            {
                impFinalStatus = "Installed";
            }
        }

        private void rbBackedOutI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackedOutI.Checked == true)
            {
                impFinalStatus = "Backed Out";
            }
        }

        private void rbAbandonedI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbandonedI.Checked == true)
            {
                impFinalStatus = "Abandoned";
            }
        }

        private void txtApprovingManager_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbInstalledP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSuccessP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuccessP.Checked == true)
            {
                PostImpReview = "Success";
            }
        }

        private void rbBackedOutP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuccessP.Checked == true)
            {
                PostImpReview = "Backed Out";
            }
        }

        private void rbAbandonedP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSuccessP.Checked == true)
            {
                PostImpReview = "Abandoned";
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Outlook.MailItem mailItem = (Outlook.MailItem)this.OutlookItem;

            CompletionDate = currentDate;
            String[] lineTitles = { "User", "Partner", "Date", "Title", "ChangeManagementRequestNumber", "UserApprovalofProject", "PartnerApprovalofInitialProject", "Table/ParmUpdate", "Table/ParmName", "DevelopmentCompleted", "TestingCompleted", "CodeReview/CheckSignOff", "CodeReviewBy", "CodeReviewDate", "KeyUserSignoff", "PartnerSignoff", "ImplementationFinalStatus", "PostImplementationReview", "Envelopes", "BusinessProcess", "ServiceAdapters", "PerlScripts", "EmailCodeList", "DocumentMaps", "DocumentExtractionMap", "XSLTEmailErrorHeader", "MapCodeTables", "RAILScsvTable", "RAILScsvRecord", "RAILScsvFilter", "FileStructureinProduction", "FTPConnect", "TRANSPORTParmFile", "Description", "ProjectManager", "CompletionDate" };
            String[] lineAnswers = { User, Partner, currentDate, Title, CMRN, UAOP.ToString(), PAOIP.ToString(), tableParm.ToString(), tableParmName, developementCompleted.ToString(), testingCompleted.ToString(), codeReview.ToString(), codeReviewBY, codeReviewDate, keyUserSignOff.ToString(), partnerSignOff.ToString(), impFinalStatus, PostImpReview, Envelopes.ToString(), BP.ToString(), ServiceAdapters.ToString(), perlScripts.ToString(), EmailCodeList.ToString(), docMaps.ToString(), docExtractionMap.ToString(), XSLTEmail.ToString(), mapCodeTables.ToString(), RAILStable.ToString(), RAILSrecord.ToString(), RAILSfilter.ToString(), fileStructureProd.ToString(), FTPconnect.ToString(), TRANSPORTfile.ToString(), Description, ProjectManager, CompletionDate };
            SendNotApproved(lineTitles, lineAnswers, mailItem);
            mailItem.Close(Outlook.OlInspectorClose.olDiscard);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DirectoryInfo saveAttatchementsFolder = new DirectoryInfo(@"C:\TempAttach");
            if (!txtPassword.Text.Equals("")) {

               
                Outlook.MailItem mailItem = (Outlook.MailItem)this.OutlookItem;
                Outlook.Attachments mailAttachments = mailItem.Attachments;

                if (mailAttachments != null)
                {
                    for (int i = 1; i <= mailAttachments.Count; i++)
                    {
                       

                        if (!saveAttatchementsFolder.Exists)
                        {
                            saveAttatchementsFolder.Create();
                        }

                        String filePath = Path.Combine(saveAttatchementsFolder.FullName, mailAttachments[i].FileName);
                        mailAttachments[i].SaveAsFile(filePath);

                    }
                }


                CompletionDate = currentDate;
                String[] lineTitles = { "User", "Partner", "Date", "Title", "ChangeManagementRequestNumber", "UserApprovalofProject", "PartnerApprovalofInitialProject", "Table/ParmUpdate", "Table/ParmName", "DevelopmentCompleted", "TestingCompleted", "CodeReview/CheckSignOff", "CodeReviewBy", "CodeReviewDate", "KeyUserSignoff", "PartnerSignoff", "ImplementationFinalStatus", "PostImplementationReview", "Envelopes", "BusinessProcess", "ServiceAdapters", "PerlScripts", "EmailCodeList", "DocumentMaps", "DocumentExtractionMap", "XSLTEmailErrorHeader", "MapCodeTables", "RAILScsvTable", "RAILScsvRecord", "RAILScsvFilter", "FileStructureinProduction", "FTPConnect", "TRANSPORTParmFile", "Description", "ProjectManager", "CompletionDate" };
                String[] lineAnswers = { User, Partner, currentDate, Title, CMRN, UAOP.ToString(), PAOIP.ToString(), tableParm.ToString(), tableParmName, developementCompleted.ToString(), testingCompleted.ToString(), codeReview.ToString(), codeReviewBY, codeReviewDate, keyUserSignOff.ToString(), partnerSignOff.ToString(), impFinalStatus, PostImpReview, Envelopes.ToString(), BP.ToString(), ServiceAdapters.ToString(), perlScripts.ToString(), EmailCodeList.ToString(), docMaps.ToString(), docExtractionMap.ToString(), XSLTEmail.ToString(), mapCodeTables.ToString(), RAILStable.ToString(), RAILSrecord.ToString(), RAILSfilter.ToString(), fileStructureProd.ToString(), FTPconnect.ToString(), TRANSPORTfile.ToString(), Description, ProjectManager, CompletionDate };
                SendApproved(lineTitles, lineAnswers, mailItem,InitialAndUsername,Password);


                FileInfo[] files = saveAttatchementsFolder.GetFiles();
                foreach (FileInfo file in files)
                {

                    file.Delete();
                }

                   mailItem.Close(Outlook.OlInspectorClose.olDiscard);
                }
            
        }

        public void SendApproved(String[] lineTitles, String[] lineAnswers, Outlook.MailItem mailItem, String [] InitialAndUsername, String Password)
        {
               String ModUser = User.Replace(" ", "");
            String ModTitle = Title.Replace(" ", "");
            String ModPartner = Partner.Replace(" ", "");

            String date = DateTime.Now.ToString("yyyyMMdd");
            String Foldername = date + "_" + ModUser + "_" + ModPartner + "_" + ModTitle+ "_" + InitialAndUsername[0];
            
            SharepointUpload upload = new SharepointUpload(InitialAndUsername[1], Password, Foldername, mailItem.Attachments);





            StringBuilder stringbuilder = new StringBuilder();



            for (int i = 0; i < lineTitles.Length; i++)
            {
                stringbuilder.AppendLine(lineTitles[i] + "\t" + lineAnswers[i]);
            }

            String body = stringbuilder.ToString();
            String Subject = "Approved! " + User + " and Partner " + Partner;

            Outlook.MailItem ReplyEmail = mailItem.Reply();
            ReplyEmail.Subject = Subject;
            ReplyEmail.Body = body;
            ReplyEmail.Importance = Outlook.OlImportance.olImportanceHigh;
            ReplyEmail.Send();
            



        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(""))
            {
                btnSave.Enabled=true;
                Password = txtPassword.Text;
            }
        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            //------------------------------------------------------------------------------------------------

            GetSnapshot()


            //var bmpScreenshot = new Bitmap(this.Width,
            //              this.Height,
            //               System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            //var grxScreenshot = Graphics.FromImage(bmpScreenshot);

            //grxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
            //            Screen.PrimaryScreen.Bounds.Y,
            //            0,
            //            0,
            //            Screen.PrimaryScreen.Bounds.Size,
            //            CopyPixelOperation.SourceCopy);


            //string outputFileName = @"C:\Users\63530\Desktop\image.png";
            //using (MemoryStream memory = new MemoryStream())
            //{
            //    using (FileStream fs = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite))
            //    {
            //        bmpScreenshot.Save(memory, ImageFormat.Png);
            //        byte[] bytes = memory.ToArray();
            //        fs.Write(bytes, 0, bytes.Length);
            //    }
            //}


            //------------------------------------------------------------------------------------------------

        }

        private void txtProjectManager_TextChanged(object sender, EventArgs e)
        {
            ProjectManager = txtProjectManager.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            Description = txtDescription.Text;
        }

        private void txtCodeReviewDATE_TextChanged(object sender, EventArgs e)
        {
            codeReviewDate = txtCodeReviewDATE.Text;
        }

        private void txtCodeReviewBY_TextChanged(object sender, EventArgs e)
        {
            codeReviewBY = txtCodeReviewBY.Text;
        }

        private void txtTableParmNAME_TextChanged(object sender, EventArgs e)
        {
            tableParmName = txtTableParmNAME.Text;
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            Title = txtTitle.Text;
        }

        private void txtChangeManagemntRequestNumber_TextChanged(object sender, EventArgs e)
        {
            CMRN = txtChangeManagemntRequestNumber.Text;
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            currentDate = txtDate.Text;
        }

        private void txtPartner_TextChanged(object sender, EventArgs e)
        {
            Partner = txtPartner.Text;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            User = txtUser.Text;
        }

        private void cbtableParm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtableParm.Checked == true)
            {
                tableParm = true;

            }
            else
            {
                tableParm = false;
            }
        }

        private void cbDevelopmentCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDevelopmentCompleted.Checked == true)
            {
                developementCompleted = true;
            }
            else
            {
                developementCompleted = false;
            }
        }

        private void cbTestingCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTestingCompleted.Checked == true)
            {
                testingCompleted = true;
            }
            else
            {
                testingCompleted = false;
            }
        }

        private void cbCodeReview_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCodeReview.Checked == true)
            {
                codeReview = true;
                txtCodeReviewBY.Enabled = true;
                txtCodeReviewDATE.Enabled = true;
                lblCodeReviewDate.Enabled = true;
                lblCodeReviewBy.Enabled = true;
                txtCodeReviewDATE.Text = currentDate;
            }
            else
            {
                codeReview = false;
                txtCodeReviewDATE.Text = "";
                txtCodeReviewBY.Text = "";
                txtCodeReviewBY.Enabled = false;
                txtCodeReviewDATE.Enabled = false;
                lblCodeReviewDate.Enabled = false;
                lblCodeReviewBy.Enabled = false;
            }
        }

        private void cbKeyUserSignOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKeyUserSignOff.Checked == true)
            {
                keyUserSignOff = true;
            }
            else
            {
                keyUserSignOff = false;
            }
        }

        private void cbPartnerSignOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPartnerSignOff.Checked == true)
            {
                partnerSignOff = true;
            }
            else
            {
                partnerSignOff = false;
            }
        }

        private void cbEnvelopes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnvelopes.Checked == true)
            {
                Envelopes = true;
            }
            else
            {
                Envelopes = false;
            }
        }

        private void cbBusinessProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBusinessProcess.Checked == true)
            {
                BP = true;
            }
            else
            {
                BP = false;
            }
        }

        private void cbServiceAdapter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbServiceAdapter.Checked == true)
            {
                ServiceAdapters = true;
            }
            else
            {
                ServiceAdapters = false;
            }
        }

        private void cbPerlScripts_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPerlScripts.Checked == true)
            {
                perlScripts = true;
            }
            else
            {
                perlScripts = false;
            }
        }

        private void cbEmailCodeList_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEmailCodeList.Checked == true)
            {
                EmailCodeList = true;
            }
            else
            {
                EmailCodeList = false;
            }
        }

        private void cbDocumentMap_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDocumentMap.Checked == true)
            {
                docMaps = true;
            }
            else
            {
                docMaps = false;
            }
        }

        private void cbDocumentExtractionMap_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDocumentExtractionMap.Checked == true)
            {
                docExtractionMap = true;
            }
            else
            {
                docExtractionMap = false;
            }
        }

        private void cbXSLTEmailErrorHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXSLTEmailErrorHeader.Checked == true)
            {
                XSLTEmail = true;
            }
            else
            {
                XSLTEmail = false;
            }
        }

        private void cbMapCodeTables_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMapCodeTables.Checked == true)
            {
                mapCodeTables = true;
            }
            else
            {
                mapCodeTables = false;
            }
        }

        private void cbRAILStable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRAILStable.Checked == true)
            {
                RAILStable = true;
            }
            else
            {
                RAILStable = false;
            }
        }

        private void cbRAILSrecord_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRAILSrecord.Checked == true)
            {
                RAILSrecord = true;
            }
            else
            {
                RAILSrecord = false;
            }
        }

        private void cbRAILSfilter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRAILSfilter.Checked == true)
            {
                RAILSfilter = true;
            }
            else
            {
                RAILSfilter = false;
            }
        }

        private void cbFileStructureInProduction_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFileStructureInProduction.Checked == true)
            {
                fileStructureProd = true;
            }
            else
            {
                fileStructureProd = false;
            }
        }

        private void cbFTPconnect_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFTPconnect.Checked == true)
            {
                FTPconnect = true;
            }
            else
            {
                FTPconnect = false;
            }
        }

        private void cbTRANSPORTparmfile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTRANSPORTparmfile.Checked == true)
            {
                TRANSPORTfile = true;
            }
            else
            {
                TRANSPORTfile = false;
            }
        }

        private void cbPartnerApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPartnerApproval.Checked == true)
            {
                PAOIP = true;
            }
            else
            {
                PAOIP = false;
            }
        }

        private void cbUserApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUserApproval.Checked == true)
            {
                UAOP = true;
            }
            else
            {
                UAOP = false;
            }
        }
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        public static Bitmap GetSnapshot(IntPtr hWnd) // capture a window by its handle
        {
            Int32 windowLeft;
            Int32 windowTop;
            Int32 windowWidth;
            Int32 windowHeight;
            if (hWnd == IntPtr.Zero) return null;
            if (!GetWindowRect(hWnd, out windowLeft, out windowTop, out windowWidth, out windowHeight)) return null;

            Bitmap bmp = new Bitmap(windowWidth, windowHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
            IntPtr hdcBitmap = gfxBmp.GetHdc();

            PrintWindow(hWnd, hdcBitmap, 0); // from user32.dll

            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();

            return bmp;
        }

        private static bool GetWindowRect(IntPtr hWnd, out Int32 left, out Int32 top, out Int32 width, out Int32 height)
        {
            left = 0;
            top = 0;
            width = 0;
            height = 0;

            RECT rct = new RECT();
            if (!GetWindowRect(hWnd, ref rct)) return false; // from user32.dll

            left = rct.Left;
            top = rct.Top;
            width = rct.Right - rct.Left + 1;
            height = rct.Bottom - rct.Top + 1;
            return true;
        }

        public struct RECT
        {
            public Int32 Left;
            public Int32 Top;
            public Int32 Right;
            public Int32 Bottom;
        }

    }


}
