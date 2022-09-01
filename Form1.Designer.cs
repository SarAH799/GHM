namespace GHMForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyHeadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gHM_Member_DetailsDataSet = new GHMForm.GHM_Member_DetailsDataSet();
            this.addressDetailsTableAdapter = new GHMForm.GHM_Member_DetailsDataSetTableAdapters.AddressDetailsTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHM_Member_DetailsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GOD\'S HAND MINISTRIES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Family Head:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 153);
            this.label5.TabIndex = 4;
            this.label5.Text = "Permanent-\r\n\r\nArea:\r\n\r\nCity:\r\n\r\nState:\r\n\r\nPincode:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 153);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temporary-\r\n\r\nArea:\r\n\r\nCity:\r\n\r\nState:\r\n\r\nPincode:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(192, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(192, 303);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(192, 348);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(192, 376);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 22);
            this.textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(192, 459);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(149, 22);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(192, 487);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(149, 22);
            this.textBox8.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(192, 527);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(149, 22);
            this.textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(192, 555);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(149, 22);
            this.textBox10.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 720);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pAreaDataGridViewTextBoxColumn,
            this.pCityDataGridViewTextBoxColumn,
            this.pStateDataGridViewTextBoxColumn,
            this.pPincodeDataGridViewTextBoxColumn,
            this.tAreaDataGridViewTextBoxColumn,
            this.tCityDataGridViewTextBoxColumn,
            this.tStateDataGridViewTextBoxColumn,
            this.tPincodeDataGridViewTextBoxColumn,
            this.addressCodeDataGridViewTextBoxColumn,
            this.familyHeadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(410, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 426);
            this.dataGridView1.TabIndex = 19;
            // 
            // pAreaDataGridViewTextBoxColumn
            // 
            this.pAreaDataGridViewTextBoxColumn.DataPropertyName = "PArea";
            this.pAreaDataGridViewTextBoxColumn.HeaderText = "PArea";
            this.pAreaDataGridViewTextBoxColumn.Name = "pAreaDataGridViewTextBoxColumn";
            // 
            // pCityDataGridViewTextBoxColumn
            // 
            this.pCityDataGridViewTextBoxColumn.DataPropertyName = "PCity";
            this.pCityDataGridViewTextBoxColumn.HeaderText = "PCity";
            this.pCityDataGridViewTextBoxColumn.Name = "pCityDataGridViewTextBoxColumn";
            // 
            // pStateDataGridViewTextBoxColumn
            // 
            this.pStateDataGridViewTextBoxColumn.DataPropertyName = "PState";
            this.pStateDataGridViewTextBoxColumn.HeaderText = "PState";
            this.pStateDataGridViewTextBoxColumn.Name = "pStateDataGridViewTextBoxColumn";
            // 
            // pPincodeDataGridViewTextBoxColumn
            // 
            this.pPincodeDataGridViewTextBoxColumn.DataPropertyName = "PPincode";
            this.pPincodeDataGridViewTextBoxColumn.HeaderText = "PPincode";
            this.pPincodeDataGridViewTextBoxColumn.Name = "pPincodeDataGridViewTextBoxColumn";
            // 
            // tAreaDataGridViewTextBoxColumn
            // 
            this.tAreaDataGridViewTextBoxColumn.DataPropertyName = "TArea";
            this.tAreaDataGridViewTextBoxColumn.HeaderText = "TArea";
            this.tAreaDataGridViewTextBoxColumn.Name = "tAreaDataGridViewTextBoxColumn";
            // 
            // tCityDataGridViewTextBoxColumn
            // 
            this.tCityDataGridViewTextBoxColumn.DataPropertyName = "TCity";
            this.tCityDataGridViewTextBoxColumn.HeaderText = "TCity";
            this.tCityDataGridViewTextBoxColumn.Name = "tCityDataGridViewTextBoxColumn";
            // 
            // tStateDataGridViewTextBoxColumn
            // 
            this.tStateDataGridViewTextBoxColumn.DataPropertyName = "TState";
            this.tStateDataGridViewTextBoxColumn.HeaderText = "TState";
            this.tStateDataGridViewTextBoxColumn.Name = "tStateDataGridViewTextBoxColumn";
            // 
            // tPincodeDataGridViewTextBoxColumn
            // 
            this.tPincodeDataGridViewTextBoxColumn.DataPropertyName = "TPincode";
            this.tPincodeDataGridViewTextBoxColumn.HeaderText = "TPincode";
            this.tPincodeDataGridViewTextBoxColumn.Name = "tPincodeDataGridViewTextBoxColumn";
            // 
            // addressCodeDataGridViewTextBoxColumn
            // 
            this.addressCodeDataGridViewTextBoxColumn.DataPropertyName = "AddressCode";
            this.addressCodeDataGridViewTextBoxColumn.HeaderText = "AddressCode";
            this.addressCodeDataGridViewTextBoxColumn.Name = "addressCodeDataGridViewTextBoxColumn";
            // 
            // familyHeadDataGridViewTextBoxColumn
            // 
            this.familyHeadDataGridViewTextBoxColumn.DataPropertyName = "FamilyHead";
            this.familyHeadDataGridViewTextBoxColumn.HeaderText = "FamilyHead";
            this.familyHeadDataGridViewTextBoxColumn.Name = "familyHeadDataGridViewTextBoxColumn";
            // 
            // addressDetailsBindingSource
            // 
            this.addressDetailsBindingSource.DataMember = "AddressDetails";
            this.addressDetailsBindingSource.DataSource = this.gHM_Member_DetailsDataSet;
            // 
            // gHM_Member_DetailsDataSet
            // 
            this.gHM_Member_DetailsDataSet.DataSetName = "GHM_Member_DetailsDataSet";
            this.gHM_Member_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressDetailsTableAdapter
            // 
            this.addressDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(982, 650);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 60);
            this.button4.TabIndex = 20;
            this.button4.Text = "Fill other details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(54, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 35);
            this.button5.TabIndex = 21;
            this.button5.Text = "New";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(192, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 35);
            this.button6.TabIndex = 22;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Enter Registration No. to Edit:";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 24;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 778);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gHM_Member_DetailsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GHM_Member_DetailsDataSet gHM_Member_DetailsDataSet;
        private System.Windows.Forms.BindingSource addressDetailsBindingSource;
        private GHM_Member_DetailsDataSetTableAdapters.AddressDetailsTableAdapter addressDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyHeadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

