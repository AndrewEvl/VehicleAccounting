using System.ComponentModel;

namespace VehicleAccounting
{
    partial class OwnerSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerSave));
            this.label12 = new System.Windows.Forms.Label();
            this.passportNumber = new System.Windows.Forms.Label();
            this.lastNameLable = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.saveOwner = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(130, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Save owner";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passportNumber
            // 
            this.passportNumber.Location = new System.Drawing.Point(50, 94);
            this.passportNumber.Name = "passportNumber";
            this.passportNumber.Size = new System.Drawing.Size(100, 23);
            this.passportNumber.TabIndex = 40;
            this.passportNumber.Text = "passport №";
            this.passportNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLable
            // 
            this.lastNameLable.Location = new System.Drawing.Point(50, 67);
            this.lastNameLable.Name = "lastNameLable";
            this.lastNameLable.Size = new System.Drawing.Size(100, 23);
            this.lastNameLable.TabIndex = 39;
            this.lastNameLable.Text = "Last name";
            this.lastNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(50, 40);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 23);
            this.firstNameLabel.TabIndex = 38;
            this.firstNameLabel.Text = "First name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveOwner
            // 
            this.saveOwner.Location = new System.Drawing.Point(139, 122);
            this.saveOwner.Name = "saveOwner";
            this.saveOwner.Size = new System.Drawing.Size(100, 23);
            this.saveOwner.TabIndex = 37;
            this.saveOwner.Text = "Save";
            this.saveOwner.UseVisualStyleBackColor = true;
            this.saveOwner.Click += new System.EventHandler(this.saveOwner_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 20);
            this.textBox5.TabIndex = 36;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 34;
            // 
            // OwnerSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 169);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.passportNumber);
            this.Controls.Add(this.lastNameLable);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.saveOwner);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "OwnerSave";
            this.Text = "OwnerSave";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label passportNumber;
        private System.Windows.Forms.Label lastNameLable;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button saveOwner;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;

        #endregion
    }
}