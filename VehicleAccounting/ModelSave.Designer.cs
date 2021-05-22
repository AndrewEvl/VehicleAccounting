using System.ComponentModel;

namespace VehicleAccounting
{
    partial class ModelSave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelSave));
            this.brandDropDownSave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveModel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brandDropDownSave
            // 
            this.brandDropDownSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandDropDownSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.brandDropDownSave.FormattingEnabled = true;
            this.brandDropDownSave.Location = new System.Drawing.Point(115, 12);
            this.brandDropDownSave.Name = "brandDropDownSave";
            this.brandDropDownSave.Size = new System.Drawing.Size(228, 21);
            this.brandDropDownSave.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Add new model";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveModel
            // 
            this.saveModel.Location = new System.Drawing.Point(234, 41);
            this.saveModel.Name = "saveModel";
            this.saveModel.Size = new System.Drawing.Size(109, 23);
            this.saveModel.TabIndex = 11;
            this.saveModel.Text = "Save";
            this.saveModel.UseVisualStyleBackColor = true;
            this.saveModel.Click += new System.EventHandler(this.saveModel_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 20);
            this.textBox2.TabIndex = 10;
            // 
            // ModelSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 76);
            this.Controls.Add(this.brandDropDownSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveModel);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "ModelSave";
            this.Text = "ModelSave";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox brandDropDownSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveModel;
        private System.Windows.Forms.TextBox textBox2;

        #endregion
    }
}