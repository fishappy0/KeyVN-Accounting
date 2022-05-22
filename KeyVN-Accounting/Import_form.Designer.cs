namespace KeyVN_Accounting
{
    partial class Import_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import_form));
            this.title_2_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_by_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_actual_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.storage_name_txtbox = new System.Windows.Forms.TextBox();
            this.official_document_txtbox = new System.Windows.Forms.TextBox();
            this.storage_location_txtbox = new System.Windows.Forms.TextBox();
            this.debt_txtbox = new System.Windows.Forms.TextBox();
            this.courier_name_txtbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.submit_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.money_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.money_txt_lbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_2_lbl
            // 
            this.title_2_lbl.AutoSize = true;
            this.title_2_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_2_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_2_lbl.Location = new System.Drawing.Point(697, 9);
            this.title_2_lbl.Name = "title_2_lbl";
            this.title_2_lbl.Size = new System.Drawing.Size(389, 70);
            this.title_2_lbl.TabIndex = 3;
            this.title_2_lbl.Text = "Import Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Courier full name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Storage name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Storage location:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.unit,
            this.quantity_by_doc,
            this.quantity_actual_amount,
            this.unit_price,
            this.total_cost});
            this.dataGridView1.Location = new System.Drawing.Point(9, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(812, 447);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // name
            // 
            this.name.HeaderText = "Name, Label, Property or Tool Type";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Width = 125;
            // 
            // quantity_by_doc
            // 
            this.quantity_by_doc.HeaderText = "Quantity by official document";
            this.quantity_by_doc.MinimumWidth = 6;
            this.quantity_by_doc.Name = "quantity_by_doc";
            this.quantity_by_doc.ReadOnly = true;
            this.quantity_by_doc.Width = 125;
            // 
            // quantity_actual_amount
            // 
            this.quantity_actual_amount.HeaderText = "Actual Amount Quantity";
            this.quantity_actual_amount.MinimumWidth = 6;
            this.quantity_actual_amount.Name = "quantity_actual_amount";
            this.quantity_actual_amount.ReadOnly = true;
            this.quantity_actual_amount.Width = 125;
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.MinimumWidth = 6;
            this.unit_price.Name = "unit_price";
            this.unit_price.ReadOnly = true;
            this.unit_price.Width = 125;
            // 
            // total_cost
            // 
            this.total_cost.HeaderText = "Total Cost";
            this.total_cost.MinimumWidth = 6;
            this.total_cost.Name = "total_cost";
            this.total_cost.ReadOnly = true;
            this.total_cost.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(460, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Debt amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total amount (in words): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(497, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Included official documents (separated by \",\"):";
            // 
            // storage_name_txtbox
            // 
            this.storage_name_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storage_name_txtbox.Location = new System.Drawing.Point(197, 97);
            this.storage_name_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.storage_name_txtbox.Name = "storage_name_txtbox";
            this.storage_name_txtbox.Size = new System.Drawing.Size(256, 39);
            this.storage_name_txtbox.TabIndex = 11;
            // 
            // official_document_txtbox
            // 
            this.official_document_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.official_document_txtbox.Location = new System.Drawing.Point(13, 166);
            this.official_document_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.official_document_txtbox.Name = "official_document_txtbox";
            this.official_document_txtbox.Size = new System.Drawing.Size(805, 39);
            this.official_document_txtbox.TabIndex = 12;
            // 
            // storage_location_txtbox
            // 
            this.storage_location_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storage_location_txtbox.Location = new System.Drawing.Point(221, 179);
            this.storage_location_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.storage_location_txtbox.Name = "storage_location_txtbox";
            this.storage_location_txtbox.Size = new System.Drawing.Size(597, 39);
            this.storage_location_txtbox.TabIndex = 13;
            // 
            // debt_txtbox
            // 
            this.debt_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debt_txtbox.Location = new System.Drawing.Point(638, 97);
            this.debt_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.debt_txtbox.Name = "debt_txtbox";
            this.debt_txtbox.Size = new System.Drawing.Size(180, 39);
            this.debt_txtbox.TabIndex = 14;
            // 
            // courier_name_txtbox
            // 
            this.courier_name_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courier_name_txtbox.Location = new System.Drawing.Point(235, 23);
            this.courier_name_txtbox.Margin = new System.Windows.Forms.Padding(4);
            this.courier_name_txtbox.Name = "courier_name_txtbox";
            this.courier_name_txtbox.Size = new System.Drawing.Size(584, 39);
            this.courier_name_txtbox.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit_btn.Location = new System.Drawing.Point(648, 654);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(466, 49);
            this.submit_btn.TabIndex = 21;
            this.submit_btn.Text = "Import and print .docx document";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.storage_location_txtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.storage_name_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.debt_txtbox);
            this.groupBox1.Controls.Add(this.courier_name_txtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(829, 243);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(862, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(829, 478);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item information";
            // 
            // money_lbl
            // 
            this.money_lbl.AutoSize = true;
            this.money_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.money_lbl.Location = new System.Drawing.Point(633, 18);
            this.money_lbl.Name = "money_lbl";
            this.money_lbl.Size = new System.Drawing.Size(154, 32);
            this.money_lbl.TabIndex = 29;
            this.money_lbl.Text = "420,000 VND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(454, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 31);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total amount: ";
            // 
            // money_txt_lbl
            // 
            this.money_txt_lbl.AutoSize = true;
            this.money_txt_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_txt_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.money_txt_lbl.Location = new System.Drawing.Point(9, 68);
            this.money_txt_lbl.Name = "money_txt_lbl";
            this.money_txt_lbl.Size = new System.Drawing.Size(418, 32);
            this.money_txt_lbl.TabIndex = 27;
            this.money_txt_lbl.Text = "Four Hundred And Twenty Thousands";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.money_lbl);
            this.groupBox3.Controls.Add(this.money_txt_lbl);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.official_document_txtbox);
            this.groupBox3.Location = new System.Drawing.Point(26, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 228);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total amount";
            // 
            // Import_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1704, 725);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.title_2_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Import_form";
            this.Text = "Import Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_2_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox storage_name_txtbox;
        private System.Windows.Forms.TextBox official_document_txtbox;
        private System.Windows.Forms.TextBox storage_location_txtbox;
        private System.Windows.Forms.TextBox debt_txtbox;
        private System.Windows.Forms.TextBox courier_name_txtbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label money_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label money_txt_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_by_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_actual_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}