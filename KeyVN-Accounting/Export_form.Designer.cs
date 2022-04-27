namespace KeyVN_Accounting
{
    partial class Export_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_form));
            this.title_2_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.export_reason_txtbox = new System.Windows.Forms.TextBox();
            this.recipient_name_txtbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.browse_signature_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.signature_picbox = new System.Windows.Forms.PictureBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.recipient_address_txtbox = new System.Windows.Forms.TextBox();
            this.money_txt_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.money_lbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.debt_amount_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signature_picbox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_2_lbl
            // 
            this.title_2_lbl.AutoSize = true;
            this.title_2_lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_2_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_2_lbl.Location = new System.Drawing.Point(234, 9);
            this.title_2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_2_lbl.Name = "title_2_lbl";
            this.title_2_lbl.Size = new System.Drawing.Size(311, 55);
            this.title_2_lbl.TabIndex = 3;
            this.title_2_lbl.Text = "Export Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recipient full name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Storage name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(5, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Storage location:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_number,
            this.name,
            this.id,
            this.unit,
            this.quantity_by_doc,
            this.quantity_actual_amount,
            this.unit_price,
            this.total_cost});
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 288);
            this.dataGridView1.TabIndex = 7;
            // 
            // order_number
            // 
            this.order_number.HeaderText = "Order No.";
            this.order_number.Name = "order_number";
            // 
            // name
            // 
            this.name.HeaderText = "Name, Label, Property or Tool Type";
            this.name.Name = "name";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // unit
            // 
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            // 
            // quantity_by_doc
            // 
            this.quantity_by_doc.HeaderText = "Quantity by official document";
            this.quantity_by_doc.Name = "quantity_by_doc";
            // 
            // quantity_actual_amount
            // 
            this.quantity_actual_amount.HeaderText = "Actual Amount Quantity";
            this.quantity_actual_amount.Name = "quantity_actual_amount";
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "Unit Price";
            this.unit_price.Name = "unit_price";
            // 
            // total_cost
            // 
            this.total_cost.HeaderText = "Total Cost";
            this.total_cost.Name = "total_cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(338, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Export reason:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(14, 613);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total amount (in words): ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 677);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Included official documents (separated by \",\"):";
            // 
            // storage_name_txtbox
            // 
            this.storage_name_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storage_name_txtbox.Location = new System.Drawing.Point(147, 109);
            this.storage_name_txtbox.Name = "storage_name_txtbox";
            this.storage_name_txtbox.Size = new System.Drawing.Size(193, 33);
            this.storage_name_txtbox.TabIndex = 11;
            // 
            // official_document_txtbox
            // 
            this.official_document_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.official_document_txtbox.Location = new System.Drawing.Point(12, 705);
            this.official_document_txtbox.Name = "official_document_txtbox";
            this.official_document_txtbox.Size = new System.Drawing.Size(605, 33);
            this.official_document_txtbox.TabIndex = 12;
            // 
            // storage_location_txtbox
            // 
            this.storage_location_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storage_location_txtbox.Location = new System.Drawing.Point(166, 157);
            this.storage_location_txtbox.Name = "storage_location_txtbox";
            this.storage_location_txtbox.Size = new System.Drawing.Size(583, 33);
            this.storage_location_txtbox.TabIndex = 13;
            // 
            // export_reason_txtbox
            // 
            this.export_reason_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_reason_txtbox.Location = new System.Drawing.Point(479, 109);
            this.export_reason_txtbox.Name = "export_reason_txtbox";
            this.export_reason_txtbox.Size = new System.Drawing.Size(270, 33);
            this.export_reason_txtbox.TabIndex = 14;
            // 
            // recipient_name_txtbox
            // 
            this.recipient_name_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipient_name_txtbox.Location = new System.Drawing.Point(187, 19);
            this.recipient_name_txtbox.Name = "recipient_name_txtbox";
            this.recipient_name_txtbox.Size = new System.Drawing.Size(262, 33);
            this.recipient_name_txtbox.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(7, 757);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Form preparer signature:";
            // 
            // browse_signature_btn
            // 
            this.browse_signature_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browse_signature_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browse_signature_btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_signature_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browse_signature_btn.Location = new System.Drawing.Point(244, 751);
            this.browse_signature_btn.Margin = new System.Windows.Forms.Padding(2);
            this.browse_signature_btn.Name = "browse_signature_btn";
            this.browse_signature_btn.Size = new System.Drawing.Size(176, 40);
            this.browse_signature_btn.TabIndex = 18;
            this.browse_signature_btn.Text = "Browse Signature Photo";
            this.browse_signature_btn.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(7, 827);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Form preparer signature preview:";
            // 
            // signature_picbox
            // 
            this.signature_picbox.BackColor = System.Drawing.Color.Azure;
            this.signature_picbox.Location = new System.Drawing.Point(12, 855);
            this.signature_picbox.Name = "signature_picbox";
            this.signature_picbox.Size = new System.Drawing.Size(296, 82);
            this.signature_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signature_picbox.TabIndex = 20;
            this.signature_picbox.TabStop = false;
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit_btn.Location = new System.Drawing.Point(129, 971);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(541, 40);
            this.submit_btn.TabIndex = 21;
            this.submit_btn.Text = "Submit form for review and print .docx document";
            this.submit_btn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.debt_amount_txtbox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.recipient_address_txtbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.storage_location_txtbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.storage_name_txtbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.export_reason_txtbox);
            this.groupBox1.Controls.Add(this.recipient_name_txtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 208);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(7, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 317);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(7, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Recipient address:";
            // 
            // recipient_address_txtbox
            // 
            this.recipient_address_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipient_address_txtbox.Location = new System.Drawing.Point(175, 65);
            this.recipient_address_txtbox.Name = "recipient_address_txtbox";
            this.recipient_address_txtbox.Size = new System.Drawing.Size(573, 33);
            this.recipient_address_txtbox.TabIndex = 18;
            // 
            // money_txt_lbl
            // 
            this.money_txt_lbl.AutoSize = true;
            this.money_txt_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_txt_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.money_txt_lbl.Location = new System.Drawing.Point(14, 638);
            this.money_txt_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.money_txt_lbl.Name = "money_txt_lbl";
            this.money_txt_lbl.Size = new System.Drawing.Size(328, 25);
            this.money_txt_lbl.TabIndex = 24;
            this.money_txt_lbl.Text = "Four Hundred And Twenty Thousands";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(321, 613);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total amount: ";
            // 
            // money_lbl
            // 
            this.money_lbl.AutoSize = true;
            this.money_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.money_lbl.Location = new System.Drawing.Point(450, 613);
            this.money_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.money_lbl.Name = "money_lbl";
            this.money_lbl.Size = new System.Drawing.Size(120, 25);
            this.money_lbl.TabIndex = 26;
            this.money_lbl.Text = "420,000 VND";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(454, 22);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Debt amount:";
            // 
            // debt_amount_txtbox
            // 
            this.debt_amount_txtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debt_amount_txtbox.Location = new System.Drawing.Point(590, 19);
            this.debt_amount_txtbox.Name = "debt_amount_txtbox";
            this.debt_amount_txtbox.Size = new System.Drawing.Size(159, 33);
            this.debt_amount_txtbox.TabIndex = 20;
            // 
            // Export_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(786, 1022);
            this.Controls.Add(this.money_lbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.money_txt_lbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.signature_picbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.browse_signature_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.official_document_txtbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.title_2_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Export_form";
            this.Text = "Import Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signature_picbox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_2_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_by_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_actual_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox storage_name_txtbox;
        private System.Windows.Forms.TextBox official_document_txtbox;
        private System.Windows.Forms.TextBox storage_location_txtbox;
        private System.Windows.Forms.TextBox export_reason_txtbox;
        private System.Windows.Forms.TextBox recipient_name_txtbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button browse_signature_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox signature_picbox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox debt_amount_txtbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox recipient_address_txtbox;
        private System.Windows.Forms.Label money_txt_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label money_lbl;
    }
}