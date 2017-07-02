
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ApprovalAddIn
{
    partial class Approval_Initial
    {
        #region Form Region Factory 

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Note.Contoso")]
        [Microsoft.Office.Tools.Outlook.FormRegionName("ApprovalAddIn.Approval_Initial")]
        public partial class Approval_InitialFactory
        {
            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            private void Approval_InitialFactory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }

        #endregion

        

        // Occurs before the form region is displayed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void Approval_Initial_FormRegionShowing(object sender, System.EventArgs e)
        {
            if(this.OutlookItem is Outlook.MailItem)
            {
                if (this.OutlookFormRegion.FormRegionMode == Outlook.OlFormRegionMode.olFormRegionRead)
                {
                    Outlook.MailItem MailItem = (Outlook.MailItem)this.OutlookItem;
                   
                   
                }
            }

        }

        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void Approval_Initial_FormRegionClosed(object sender, System.EventArgs e)
        {
        }

        private void txtProjectManager_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
