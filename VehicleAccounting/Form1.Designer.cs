namespace VehicleAccounting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.passportNumber = new System.Windows.Forms.Label();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.brandDropDownSave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveOwner = new System.Windows.Forms.Button();
            this.saveModel = new System.Windows.Forms.Button();
            this.saveBrand = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.brandDropDown = new System.Windows.Forms.ComboBox();
            this.modelDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searthButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.seathCarNumberField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 542);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(977, 510);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.passportNumber);
            this.tabPage2.Controls.Add(this.lastNameLable);
            this.tabPage2.Controls.Add(this.firstNameLabel);
            this.tabPage2.Controls.Add(this.brandDropDownSave);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.saveOwner);
            this.tabPage2.Controls.Add(this.saveModel);
            this.tabPage2.Controls.Add(this.saveBrand);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // passportNumber
            // 
            this.passportNumber.Location = new System.Drawing.Point(12, 147);
            this.passportNumber.Name = "passportNumber";
            this.passportNumber.Size = new System.Drawing.Size(100, 23);
            this.passportNumber.TabIndex = 12;
            this.passportNumber.Text = "passport №";
            this.passportNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLable
            // 
            this.lastNameLable.Location = new System.Drawing.Point(12, 121);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(100, 23);
            this.lastNameLable.TabIndex = 11;
            this.lastNameLable.Text = "Last name";
            this.lastNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(12, 95);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 23);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandDropDownSave
            // 
            this.brandDropDownSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandDropDownSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brandDropDownSave.FormattingEnabled = true;
            this.brandDropDownSave.Location = new System.Drawing.Point(127, 67);
            this.brandDropDownSave.Name = "brandDropDownSave";
            this.brandDropDownSave.Size = new System.Drawing.Size(100, 21);
            this.brandDropDownSave.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Add new model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add new brand";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveOwner
            // 
            this.saveOwner.Location = new System.Drawing.Point(233, 121);
            this.saveOwner.Name = "saveOwner";
            this.saveOwner.Size = new System.Drawing.Size(75, 23);
            this.saveOwner.TabIndex = 7;
            this.saveOwner.Text = "Save";
            this.saveOwner.UseVisualStyleBackColor = true;
            // 
            // saveModel
            // 
            this.saveModel.Location = new System.Drawing.Point(339, 65);
            this.saveModel.Name = "saveModel";
            this.saveModel.Size = new System.Drawing.Size(75, 23);
            this.saveModel.TabIndex = 6;
            this.saveModel.Text = "Save";
            this.saveModel.UseVisualStyleBackColor = true;
            // 
            // saveBrand
            // 
            this.saveBrand.Location = new System.Drawing.Point(233, 24);
            this.saveBrand.Name = "saveBrand";
            this.saveBrand.Size = new System.Drawing.Size(75, 23);
            this.saveBrand.TabIndex = 5;
            this.saveBrand.Text = "Save";
            this.saveBrand.UseVisualStyleBackColor = true;
            this.saveBrand.Click += new System.EventHandler(this.saveBrand_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // brandDropDown
            // 
            this.brandDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandDropDown.FormattingEnabled = true;
            this.brandDropDown.Location = new System.Drawing.Point(12, 10);
            this.brandDropDown.Name = "brandDropDown";
            this.brandDropDown.Size = new System.Drawing.Size(104, 21);
            this.brandDropDown.TabIndex = 0;
            this.brandDropDown.SelectedIndexChanged += new System.EventHandler(this.ComboboxIndexChange);
            // 
            // modelDropDown
            // 
            this.modelDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelDropDown.FormattingEnabled = true;
            this.modelDropDown.Location = new System.Drawing.Point(131, 10);
            this.modelDropDown.Name = "modelDropDown";
            this.modelDropDown.Size = new System.Drawing.Size(121, 21);
            this.modelDropDown.TabIndex = 3;
            this.modelDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entel last name owner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(380, 10);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(211, 20);
            this.searchText.TabIndex = 5;
            // 
            // searthButton
            // 
            this.searthButton.Location = new System.Drawing.Point(597, 8);
            this.searthButton.Name = "searthButton";
            this.searthButton.Size = new System.Drawing.Size(92, 24);
            this.searthButton.TabIndex = 6;
            this.searthButton.Text = "Searth owner";
            this.searthButton.UseVisualStyleBackColor = true;
            this.searthButton.Click += new System.EventHandler(this.searchLastNameButtonClick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(258, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entel car number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seathCarNumberField
            // 
            this.seathCarNumberField.Location = new System.Drawing.Point(380, 36);
            this.seathCarNumberField.Name = "seathCarNumberField";
            this.seathCarNumberField.Size = new System.Drawing.Size(89, 20);
            this.seathCarNumberField.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "Searth car number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchCarNumberButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(991, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seathCarNumberField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searthButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelDropDown);
            this.Controls.Add(this.brandDropDown);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox seathCarNumberField;

        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.Label passportNumber;

        private System.Windows.Forms.ComboBox brandDropDownSave;

        private System.Windows.Forms.ComboBox brandDropDown;

        private System.Windows.Forms.ComboBox modelDropDown;

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLable;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button saveModel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button saveOwner;
        private System.Windows.Forms.Button saveBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox searchText;

        private System.Windows.Forms.Button searthButton;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.ComboBox comboBox2;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.ColorDialog colorDialog1;

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
    }
}

