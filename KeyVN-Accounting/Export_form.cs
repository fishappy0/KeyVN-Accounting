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
    public partial class Export_form : Form
    {
        public Export_form()
        {
            InitializeComponent();
        }
        dbAccess dB = new dbAccess();
        private string totalPrice;
        private string totalPriceText;
        private Dictionary<string, string> quantityDict = new Dictionary<string, string>();
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
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Dictionary<string, string> select_dict = new Dictionary<string, string>();
            select_dict.Add("@order", globals.orderid);
            DataTable dt = dB.getDT("SELECT * FROM Ordered_items WHERE OrderID=@order", select_dict);
            int dgindex = 0;
            foreach (DataRow dr in dt.Rows)
            {
                string item_id = dr[1].ToString();
                Dictionary<string, string> item_to_find = new Dictionary<string, string>();
                item_to_find.Add("@itemid", item_id);
                DataTable temp = dB.getDT("SELECT * FROM Items WHERE ItemID=@itemid", item_to_find);
                var row_info = temp.Rows[0];
                if (row_info[8].ToString() == "True")
                {
                    this.dataGridView1.Rows.Insert(dgindex, row_info[1].ToString(),
                                                            row_info[0].ToString(),
                                                            row_info[2].ToString(),
                                                            row_info[4].ToString(),
                                                            dr[2].ToString(),
                                                            row_info[6].ToString(),
                                                            (
                                                                int.Parse(dr[2].ToString()) *
                                                                int.Parse(row_info[6].ToString().TrimEnd('0').TrimEnd('.'))
                                                            ).ToString("#,#"));
                    string quantity = row_info[5].ToString();
                    quantityDict.Add(item_id, quantity);
                    dgindex++;
                }
            }
            Dictionary<string, string> account_dict = new Dictionary<string, string>();
            account_dict.Add("@accountid", globals.accountid);
            dt = dB.getDT("SELECT * FROM Accounts, Users WHERE Users.UserID = Accounts.UserID AND AccountID = @accountid", account_dict);
            recipient_name_txtbox.Text = dt.Rows[0][5].ToString();
            recipient_address_txtbox.Text = dt.Rows[0][6].ToString();
            this.updateTotal();
        }

        private void findAndReplaceText(wordProcessing WP)
        {
            Dictionary<String, String> find_and_replace_dict = new Dictionary<String, String>();
            find_and_replace_dict.Add("{year}", DateTime.Now.Year.ToString());
            find_and_replace_dict.Add("{month}", DateTime.Now.Month.ToString());
            find_and_replace_dict.Add("{date}", DateTime.Now.Day.ToString());
            find_and_replace_dict.Add("{courierName}", recipient_name_txtbox.Text);
            find_and_replace_dict.Add("{storageName}", storage_name_txtbox.Text);
            find_and_replace_dict.Add("{storageLocation}", storage_location_txtbox.Text);
            find_and_replace_dict.Add("{totalAmountText}", this.totalPriceText);
            find_and_replace_dict.Add("{totalAmount}", this.totalPrice);
            find_and_replace_dict.Add("{officialDocuments}", official_document_txtbox.Text);

            WP.replaceWords(find_and_replace_dict);
        }
        private void openSaveDialog(Action<String> func)
        {
            saveFileDialog1.Filter = "Word 2015 Documents File (*.docx)|*.doc";
            saveFileDialog1.FileName = "export-form.doc";
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

        private void submit_btn_Click(object sender, EventArgs e)
        {
            openSaveDialog(fileLocation =>
            {
                dataGridView1.AllowUserToAddRows = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Dictionary<string, string> dataDict = new Dictionary<string, string>();
                    string item_id = row.Cells[1].Value.ToString();
                    int quantity_from_dict = int.Parse(quantityDict[item_id].ToString().TrimEnd('.'));
                    int quantity_from_table = int.Parse(row.Cells[4].Value.ToString().TrimEnd('.'));
                    dataDict.Add("@ItemID", item_id);
                    DataTable dt2 = dB.getDT("SELECT * FROM Items WHERE ItemID=@ItemID", dataDict);
                    dataDict.Add("@quantity", (quantity_from_dict
                                                - quantity_from_table)
                                               .ToString()
                                               );
                    dB.updateTable("UPDATE Items SET ItemActualQuantity=@quantity WHERE ItemID=@ItemID", dataDict);

                    string unit = dt2.Rows[0][2].ToString();
                    string unit_price = dt2.Rows[0][6].ToString();

                    Dictionary<string, string> history_dict = new Dictionary<string, string>();
                    history_dict.Add("@ItemID", dt2.Rows[0][0].ToString());
                    history_dict.Add("@ItemName", dt2.Rows[0][1].ToString());
                    history_dict.Add("@Unit", unit);
                    history_dict.Add("@UnitPrice", unit_price);
                    history_dict.Add("@TotalCost", (int.Parse(unit) * int.Parse(unit_price)).ToString());
                    history_dict.Add("@ItemDocuments", "");
                    history_dict.Add("@ItemDocumentQuantity", "0");
                    history_dict.Add("@ItemActualQuantity", quantity_from_table.ToString());
                    dB.updateTable("INSERT INTO Histories VALUES(null, @ItemID, @ItemName, " +
                        "                                       @Unit, @ItemDocuments, @ItemDocumentQuantity," +
                        "                                       @ItemActualQuantity, @UnitPrice, @TotalCost, 'Exported', @AddedDate)", history_dict);

                }
                Dictionary<string, string> update_orders = new Dictionary<string, string>();
                update_orders.Add("@OrderID", globals.orderid.ToString());
                dB.updateTable("DELETE FROM Ordered_items WHERE OrderID=@OrderID", update_orders);
                dB.updateTable("UPDATE Orders SET OrderStatus = 'Delivering' WHERE OrderID=@OrderID", update_orders);
                globals.orderid = "";


                wordProcessing WP = new wordProcessing();
                WP.setWordDocWithAddress(AppDomain.CurrentDomain.BaseDirectory + @"\documentTemplates\export_form.doc");
                findAndReplaceText(WP);
                WP.customFillTable(dataGridView1);
                WP.saveInstance(fileLocation);
                WP.printWordDoc();
                WP = null;
                MessageBox.Show("Operation executed successfully!");
                this.Close();
            });

        }

        private void custom_item_btn_Click(object sender, EventArgs e)
        {
            existing_items exist_form = new existing_items();
            exist_form.ShowDialog();
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
    }
}
