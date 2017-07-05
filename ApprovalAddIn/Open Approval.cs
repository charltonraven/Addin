﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ApprovalAddIn
{
    partial class Open_Approval
    {
        private static bool isApprove = false;


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

            if (subject.Contains("Needs Approval"))
            {
                lblStatus.Text = "Needs Approval";


                String body = mailItem.Body;


                String[] lines = body.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length && !lines[i].Equals(""); ++i)
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
                            if (value.Equals("Installed"))
                            {
                                rbInstalledP.Checked = true;
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

                    }
                }

                StringBuilder attachmentInfo = new StringBuilder();
                Outlook.Attachments mailAttachments = mailItem.Attachments;
                if (mailAttachments != null)
                {
                    for (int i = 1; i <= mailAttachments.Count; i++)
                    {
                        //  ddAttachments.Items.Insert(i, mailAttachments[i].DisplayName);
                    }


                }
                lblCompletionDate.Visible = false;
                lblCompletionDateTitle.Visible = false;
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
                rbAbandonedI.Enabled = false;
                rbBackedOutI.Enabled = false;
                rbInstalledI.Enabled = false;
                rbInstalledP.Enabled = true;
                rbAbandonedP.Enabled = true;
                rbBackedOutP.Enabled = true;
                // txtApprovingManager.Text = mailItem.To;

            }
        }

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void Open_Approval_FormRegionClosed(object sender, System.EventArgs e)
        {

        }

        public static void ApproveOrNot()
        {

        }

        private void rbInstalledP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInstalledP.Checked == true)
            {
                isApprove = true;
            }

        }

        private void rbBackedOutP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackedOutP.Checked == true)
            {
                isApprove = false;
            }

        }

        private void rbAbandonedP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbandonedP.Checked == true)
            {
                isApprove = false;
            }
        }

        private void rbInstalledI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInstalledI.Checked == true)
            {
                isApprove = true;
            }
        }

        private void rbBackedOutI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackedOutI.Checked == true)
            {
                isApprove = false;
            }
        }

        private void rbAbandonedI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbandonedI.Checked == true)
            {
                isApprove = false;
            }
        }

        private void txtApprovingManager_TextChanged(object sender, EventArgs e)
        {

        }

       
    }

    
}
