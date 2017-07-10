using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;
using Microsoft.Office.Interop.Outlook;
using System.Security;
using System.IO;
namespace ApprovalAddIn
{


    class SharepointUpload
    {
       public String SiteURL = "https://sonoco.sharepoint.com/sites/business-technology/team/edi/";
        private String Username = "";
       private  String Password = "";
       private  Attachments attachments;


        public SharepointUpload()
        {

        }

       public SharepointUpload(String Username, String Password, Attachments attachments)
        {
            this.Username = Username;
            this.Password = Password;
            this.attachments = attachments;

            UploadToSharepoint();

        }

        public void UploadToSharepoint()
        {
            Random rand = new Random();
            int randNum = rand.Next(1000);
            var SaveFilePath = @"C:\Temp";
            for (int i = 1; i <= attachments.Count; i++)
            {
                //var SaveFilePath = attachments[i].GetTemporaryFilePath();
                String a = attachments[i].FileName;
                attachments[i].SaveAsFile(SaveFilePath + "\\" + attachments[i].FileName);
            }


            ClientContext clientContext = new ClientContext(SiteURL);
            SecureString sPassword = new SecureString();
            foreach (char c in this.Password.ToCharArray()) sPassword.AppendChar(c);
            clientContext.Credentials = new SharePointOnlineCredentials(this.Username, sPassword);
            List olist = clientContext.Web.Lists.GetByTitle("EDI Projects");
            clientContext.ExecuteQuery();

            //To Create Folder
            ListItemCreationInformation itemCreateInfo = new ListItemCreationInformation();
            itemCreateInfo.UnderlyingObjectType = FileSystemObjectType.Folder;
            itemCreateInfo.LeafName = "Completed Projects/testFolder"+randNum;
            ListItem oListItem = olist.AddItem(itemCreateInfo);
            oListItem.Update();


            clientContext.ExecuteQuery();



            //clientContext.AuthenticationMode = ClientAuthenticationMode.FormsAuthentication;
            //clientContext.FormsAuthenticationLoginInfo = new FormsAuthenticationLoginInfo("Charlton.Williams@sonoco.com", "Raven47946$");
            DirectoryInfo directory = new DirectoryInfo(@"C:\Temp");
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo file in files) {
                var FileCreationInfo = new FileCreationInformation
                {
                    Content = System.IO.File.ReadAllBytes(file.FullName),
                    Overwrite = true,
                    //  Url = Path.Combine(@"Completed Projects\testFolder", Path.GetFileName(file.FullName))
                    Url = Path.Combine(@"Completed Projects\testFolder" + randNum, Path.GetFileName(file.FullName))
                };

                

                var uploadFile = olist.RootFolder.Files.Add(FileCreationInfo);
                clientContext.Load(uploadFile);
               
             clientContext.ExecuteQuery();
            }





                
            
        }



    }
}
