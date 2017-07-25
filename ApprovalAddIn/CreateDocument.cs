using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace ApprovalAddIn
{
    class CreateDocument
    {
       public  CreateDocument(String [] Section_1, String[] Section_2, String[] Section_3, String[] Section_4)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */


            
            //Start Word and create a new document.

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = false;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);


            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;


            //User Partner Section---------------------------------------------------------------------------------------------------------
            Word.Paragraph UserPartner_Section;
            UserPartner_Section = oDoc.Content.Paragraphs.Add(ref oMissing);
            UserPartner_Section.Range.Text = "User: " + Section_1[0];
            UserPartner_Section.Range.InsertAfter("\t\t");
            UserPartner_Section.Range.InsertAfter("Partner: " + Section_1[1]);
            UserPartner_Section.Range.InsertAfter("\t\t");
            UserPartner_Section.Range.InsertAfter("Date: " + Section_1[2]);
            UserPartner_Section.Range.InsertAfter("\n");
            UserPartner_Section.Range.InsertAfter("Title:  " + Section_1[3]);
            UserPartner_Section.Range.InsertAfter("\t\t");
            UserPartner_Section.Range.InsertAfter("Change Management Request Number: " + Section_1[4]);
            UserPartner_Section.Range.InsertParagraphAfter();


            //User Signoff Checklist Section------------------------------------------------------------------------------------------------------
        

            Word.Table UserCheckList;

            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            UserCheckList = oDoc.Tables.Add(wrdRng, 10, 4, ref oMissing, ref oMissing);
            UserCheckList.Range.ParagraphFormat.SpaceAfter = 6;
            UserCheckList.AllowAutoFit = true;
            UserCheckList.Range.Font.Size = 8;
            Word.Column first = UserCheckList.Columns[1];
            //first.SetWidth(100, Word.WdRulerStyle.wdAdjustFirstColumn);

            int checklist = 0;
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 4; c++)
                {

                    UserCheckList.Cell(r, c).Range.Text = Section_2[checklist];
                    checklist++;
                }
            }


            //User Signoff Checklist Section--------------------------------------------------------------------------------------------------------------
            //Insert another paragraph.
            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = " ------------------------------------------------------------------------------------------------------------------------------------------";
            oPara3.Range.Font.Bold = 0;
            oPara3.Range.Font.Size = 8;
            oPara3.Range.InsertParagraphAfter();



            Word.Table FinalCheckList;

            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3.Range.Paragraphs.LineSpacing = 10f;

            FinalCheckList = oDoc.Tables.Add(wrdRng, 18, 3, ref oMissing, ref oMissing);
            FinalCheckList.Range.ParagraphFormat.SpaceAfter = 6;
            FinalCheckList.AllowAutoFit = true;

            //first.SetWidth(100, Word.WdRulerStyle.wdAdjustFirstColumn);

            checklist = 0;
            for (int r = 1; r <= 18; r++)
            {
                for (int c = 1; c <= 3; c++)
                {

                    FinalCheckList.Cell(r, c).Range.Text = Section_3[checklist];
                    checklist++;
                }
            }

            //Insert another paragraph.
            Word.Paragraph SignatureAndDate;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            SignatureAndDate = oDoc.Content.Paragraphs.Add(ref oRng);
            SignatureAndDate.Range.Font.Bold = 0;
            SignatureAndDate.Range.InsertParagraphAfter();
            SignatureAndDate.Range.Text = "\n\t\t\t\t\t\t\tProject Manager: " + Section_4[0];
            SignatureAndDate.Range.InsertAfter("\n\n");
            SignatureAndDate.Range.InsertAfter("\t\t\t\t\t\t\tCompletion Date: " + Section_4[1]);

            oWord.ActiveDocument.SaveAs2(@"C:\TempAttach\Checklist.docx");
            oWord.ActiveDocument.Close();
        }

    }
}

