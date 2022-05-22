using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;

namespace KeyVN_Accounting
{
    internal class wordProcessing
    {
        private Word.Application wordApp;
        private Word.Document wordDoc;
        private String fileLocation;

        public wordProcessing()
        {
            wordApp = new Word.Application();
        }

        public void setWordDocWithAddress(String fileAddress)
        {
            try
            {
                wordDoc = wordApp.Documents.Open(fileAddress);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void closeInstance()
        {
            wordDoc.Close(SaveChanges: false);
            wordDoc = null;
            wordApp.Quit(SaveChanges: false);
        }

        public void saveInstance(string Address)
        {
            wordDoc.SaveAs2(Address);
        }

        private void findAndReplaceWith(Word.Application wordApp, object findText, object replaceWithText)
        {
            wordApp.Selection.Find.Execute(ref findText, true,
                                true, false, false, false, false, 1, false,
                                 replaceWithText, 2, false, false, false, false);
        }

        public void printWordDoc()
        {
            try
            {
                PrintDialog pDiag = new PrintDialog();
                if (pDiag.ShowDialog() == DialogResult.OK)
                {
                    this.wordApp.ActivePrinter = pDiag.PrinterSettings.PrinterName;
                    this.wordDoc.PrintOut();
                    // This sleep timer is to wait for ms to send the print command
                    // to the printer and ms doesn't have any method to wait for this
                    System.Threading.Thread.Sleep(4000);
                    this.wordApp.ActivePrinter = null;
                    this.closeInstance();
                    MessageBox.Show("Sent to Printer");
                }
                else
                {
                    this.closeInstance();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Lỗi" + error.Message);
                this.closeInstance();
            }
        }

        public void printFromAddress(String fileAddress)
        {
            try
            {
                this.fileLocation = fileAddress;
                this.wordDoc = wordApp.Documents.Open(fileLocation);
                this.printWordDoc();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
                this.closeInstance();
            }
        }

        public void replaceWords(Dictionary<String, String> find_replace_list)
        {
            try
            {
                foreach (var word in find_replace_list)
                {
                    String findWord = word.Key;
                    String replaceWord = word.Value;
                    this.findAndReplaceWith(wordApp, findWord, replaceWord);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        //check the table layout then edit this again
        public void customFillTable(DataGridView Grid)
        {
            try
            {
                int colIndex = 0;
                int rowIndex = 0;
                Word.Table Table = wordDoc.Tables[3];
                Grid.AllowUserToAddRows = false;

                foreach (DataGridViewRow row in Grid.Rows)
                {
                    if (rowIndex < Grid.Rows.Count - 1)
                    {
                        Table.Rows.Add(Table.Cell(rowIndex + 4, 1));
                    }
                    colIndex = 0;
                    Table.Cell(rowIndex + 4, colIndex).Range.Text = (rowIndex + 1).ToString();
                    foreach (DataGridViewColumn col in Grid.Columns)
                    {
                        var gridCellValue = Grid[colIndex, rowIndex].Value;
                        if (gridCellValue != null)
                        {
                            Table.Cell(rowIndex + 4, colIndex + 2).Range.Text = gridCellValue.ToString();
                        }
                        else
                        {
                            Table.Cell(rowIndex + 4, colIndex + 2).Range.Text = "";
                        }
                        colIndex++;
                    }
                    rowIndex++;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}
