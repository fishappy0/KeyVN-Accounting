using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyVN_Accounting
{
    public partial class Import_form : Form
    {
        public Import_form()
        {
            InitializeComponent();
        }
        private string totalPrice;
        private string totalPriceText;
        private dbAccess dB = new dbAccess();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            existing_items item_form = new existing_items();
            item_form.ShowDialog();
        }

        private void browse_signature_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Picture files (*.png)|*.png";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.InitialDirectory = @"%USERPROFILE%\Desktop";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //signature_picbox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
        private String moneyToString(float money)
        {
            // Declaring the numbers names
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // "#" Symbol to remove the "E" - exponential notation
            //     as well as decimals
            string sNumber = money.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;
            int positionDigit = sNumber.Length;   // last -> first
            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;


                    // Warning 1: No type or string sanitation, this code below potentially
                    // causes issues when it cannot parse anything that is not number
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        // Refer to Warning 1
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            try
                            {
                                // Refer to Warning 1
                                hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                                positionDigit--;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                    {
                        result = placeValues[placeValue] + result;
                    }

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            double decimalNumbers = money - Math.Floor(money);
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (decimalNumbers != 0 ? "" : " đồng chẵn");
        }
        private void updateTotal()
        {
            float money_amount = 0;
            float unit_price = 0;
            int quantity = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var valueOfMoneyCell = row.Cells[6].Value;

                // Total price Type Check
                if (valueOfMoneyCell != null && float.TryParse(valueOfMoneyCell.ToString(), out _))
                {
                    money_amount += float.Parse(valueOfMoneyCell.ToString());
                }
                else
                {
                    row.Cells[6].Value = "0";
                }
                if (row.Cells[4].Value == null)
                {
                    row.Cells[4].Value = "0";
                }
            }
            this.totalPrice = money_lbl.Text = money_amount.ToString("N0") + " VND";
            this.totalPriceText = money_txt_lbl.Text = money_amount != 0 ? moneyToString(money_amount) : "Không đồng";

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.updateTotal();
        }
        private void openSaveDialog(Action<String> func)
        {
            saveFileDialog1.Filter = "Word 2015 Documents File (*.docx)|*.doc";
            saveFileDialog1.FileName = "import-form.doc";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.InitialDirectory = @"%USERPROFILE%\Desktop";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                func(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancelled the save action");
            }
        }
        private void findAndReplaceText(wordProcessing WP)
        {
            Dictionary<String, String> find_and_replace_dict = new Dictionary<String, String>();
            find_and_replace_dict.Add("{year}", DateTime.Now.Year.ToString());
            find_and_replace_dict.Add("{month}", DateTime.Now.Month.ToString());
            find_and_replace_dict.Add("{date}", DateTime.Now.Day.ToString());
            find_and_replace_dict.Add("{courierName}", courier_name_txtbox.Text);
            find_and_replace_dict.Add("{storageName}", storage_name_txtbox.Text);
            find_and_replace_dict.Add("{storageLocation}", storage_location_txtbox.Text);
            find_and_replace_dict.Add("{totalAmountText}", this.totalPriceText);
            find_and_replace_dict.Add("{totalAmount}", this.totalPrice);
            find_and_replace_dict.Add("{officialDocuments}", official_document_txtbox.Text);

            WP.replaceWords(find_and_replace_dict);
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            openSaveDialog(fileLocation =>
            {
                dataGridView1.AllowUserToAddRows = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Dictionary<string, string> dataDict = new Dictionary<string, string>();
                    dataDict.Add("@ItemID", row.Cells[1].Value.ToString());
                    DataTable dt = dB.getDT("SELECT * FROM Items WHERE ItemID=@ItemID", dataDict);


                    if (dt.Rows.Count < 1)
                    {
                        Dictionary<string, string> updateDict = new Dictionary<string, string>();
                        updateDict.Add("@ItemID", row.Cells[1].Value.ToString());
                        updateDict.Add("@ItemName", row.Cells[0].Value.ToString());
                        updateDict.Add("@Unit", row.Cells[2].Value.ToString());
                        updateDict.Add("@ItemDocuments", official_document_txtbox.Text);
                        updateDict.Add("@ItemDocumentQuantity", row.Cells[3].Value.ToString());
                        updateDict.Add("@ItemActualQuantity", row.Cells[4].Value.ToString());
                        updateDict.Add("@UnitPrice", row.Cells[5].Value.ToString());
                        updateDict.Add("@TotalCost", row.Cells[6].Value.ToString());
                        dB.updateTable("INSERT INTO Items VALUES(@ItemID, @ItemName, @Unit, @ItemDocuments" +
                                   ", @ItemDocumentQuantity, @ItemActualQuantity, @UnitPrice, @TotalCost, 1)", updateDict);
                    }
                    else
                    {
                        Dictionary<string, string> queryDict = new Dictionary<string, string>();
                        queryDict.Add("@ItemID", row.Cells[1].Value.ToString());
                        int cellQuantityValue = int.Parse(row.Cells[4].Value.ToString());
                        int cellPriceValue = int.Parse(row.Cells[6].Value.ToString());

                        int cellQuantityValue2 = int.Parse(dt.Rows[0][4].ToString());
                        int cellPriceValue2 = int.Parse(dt.Rows[0][7].ToString().TrimEnd('0').TrimEnd('.'));

                        int quantity = cellQuantityValue2 + cellQuantityValue;
                        int price = cellPriceValue2 + cellPriceValue;
                        queryDict.Add("@ActualQuantity", quantity.ToString());
                        queryDict.Add("@TotalCost", price.ToString());
                        dB.updateTable("UPDATE Items SET ItemActualQuantity=@ActualQuantity, TotalCost=@TotalCost WHERE ItemID=@ItemID", queryDict);

                        Dictionary<string, string> insert_string = new Dictionary<string, string>();
                        dB.updateTable("INSERT INTO Histories VALUES (@AccID, @ItemID, @ItemName, @Unit, " +
                                                                     "@ItemDocuments, @ItemDocumentQuantity," +
                                                 " @ItemActualQuantity, @UnitPrice, @TotalCost, @ItemStatus, @AddedDate)");
                    }
                }


                var grid = dataGridView1;
                wordProcessing WP = new wordProcessing();
                WP.setWordDocWithAddress(AppDomain.CurrentDomain.BaseDirectory + @"\documentTemplates\import_form.doc");
                findAndReplaceText(WP);
                WP.customFillTable(grid);
                WP.saveInstance(fileLocation);
                WP.printWordDoc();
                WP = null;
                MessageBox.Show("Operation executed successfully!");
                this.Close();
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
