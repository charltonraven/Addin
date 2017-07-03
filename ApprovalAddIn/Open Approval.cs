using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Office = Microsoft.Office.Core;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ApprovalAddIn
{
    partial class Open_Approval
    {

        String User;
        String Partner;
        String currentDate = DateTime.Today.ToShortDateString();
        String CMRN;
        bool UAOP;
        bool PAOIP;
        bool tableParm;
        String tableParmName;
        bool developementCompleted;
        bool testingCompleted;
        bool codeReview;
        String codeReviewBY;
        String codeReviewDate;
        bool keyUserSignOff;
        bool partnerSignOff;
        String impFinalStatus;
        String PostImpReview;

        bool Envelopes;
        bool BP;
        bool ServiceAdapters;
        bool perlScripts;
        bool EmailCodeList;
        bool docMaps;
        bool docExtractionMap;
        bool XSLTEmail;
        bool mapCodeTables;
        bool RAILStable;
        bool RAILSrecord;
        bool RAILSfilter;
        bool fileStructureProd;
        bool FTPconnect;
        bool TRANSPORTfile;

        String ProjectManager;
        String CompletionDate;

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
                    if(mailItem.Body!=null && mailItem.Body.Trim().Length > 0)
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
            String body = mailItem.Body;

            
      






        }

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void Open_Approval_FormRegionClosed(object sender, System.EventArgs e)
        {


           

        }
    }
}
