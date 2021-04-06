#region Copyright
/***************************************************************************************
 ******Copyright (C) 2016 Pritam Zope*****
 
  <copyright file="New_Interface_Form.Designer.cs" company="">
  
 {-  Program Name = Silver-J
      An Integrated Development Environment(IDE) for Java Programming
      Language written In C#   -}  
 
   This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
  
   Please credit me if you reuse, don't sell it under your own name, don't pretend you're me
  </copyright>
  * ****************************************************************************************/
#endregion

namespace Silver_J
{
    partial class New_Interface_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Interface_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InterfaceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publicRadioButton = new System.Windows.Forms.RadioButton();
            this.privateRadioButton = new System.Windows.Forms.RadioButton();
            this.protectedRadioButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HelpButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Finishbutton = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New Interface";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interface Name : ";
            // 
            // InterfaceTextBox
            // 
            this.InterfaceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterfaceTextBox.Location = new System.Drawing.Point(115, 83);
            this.InterfaceTextBox.Name = "InterfaceTextBox";
            this.InterfaceTextBox.Size = new System.Drawing.Size(466, 23);
            this.InterfaceTextBox.TabIndex = 2;
            this.InterfaceTextBox.TextChanged += new System.EventHandler(this.InterfaceTextBox_TextChanged);
            this.InterfaceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InterfaceTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modifiers : ";
            // 
            // publicRadioButton
            // 
            this.publicRadioButton.AutoSize = true;
            this.publicRadioButton.Checked = true;
            this.publicRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicRadioButton.Location = new System.Drawing.Point(131, 121);
            this.publicRadioButton.Name = "publicRadioButton";
            this.publicRadioButton.Size = new System.Drawing.Size(58, 19);
            this.publicRadioButton.TabIndex = 4;
            this.publicRadioButton.TabStop = true;
            this.publicRadioButton.Text = "public";
            this.publicRadioButton.UseVisualStyleBackColor = true;
            // 
            // privateRadioButton
            // 
            this.privateRadioButton.AutoSize = true;
            this.privateRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateRadioButton.Location = new System.Drawing.Point(294, 121);
            this.privateRadioButton.Name = "privateRadioButton";
            this.privateRadioButton.Size = new System.Drawing.Size(61, 19);
            this.privateRadioButton.TabIndex = 5;
            this.privateRadioButton.Text = "private";
            this.privateRadioButton.UseVisualStyleBackColor = true;
            // 
            // protectedRadioButton
            // 
            this.protectedRadioButton.AutoSize = true;
            this.protectedRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protectedRadioButton.Location = new System.Drawing.Point(478, 121);
            this.protectedRadioButton.Name = "protectedRadioButton";
            this.protectedRadioButton.Size = new System.Drawing.Size(76, 19);
            this.protectedRadioButton.TabIndex = 6;
            this.protectedRadioButton.Text = "protected";
            this.protectedRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 1);
            this.panel2.TabIndex = 7;
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.SystemColors.Control;
            this.HelpButton.Location = new System.Drawing.Point(506, 175);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 23);
            this.HelpButton.TabIndex = 27;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.Location = new System.Drawing.Point(425, 175);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 26;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Finishbutton
            // 
            this.Finishbutton.BackColor = System.Drawing.SystemColors.Control;
            this.Finishbutton.Location = new System.Drawing.Point(344, 175);
            this.Finishbutton.Name = "Finishbutton";
            this.Finishbutton.Size = new System.Drawing.Size(75, 23);
            this.Finishbutton.TabIndex = 25;
            this.Finishbutton.Text = "Finish";
            this.Finishbutton.UseVisualStyleBackColor = false;
            this.Finishbutton.Click += new System.EventHandler(this.Finishbutton_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorlabel.Location = new System.Drawing.Point(23, 178);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 17);
            this.errorlabel.TabIndex = 2;
            // 
            // New_Interface_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Finishbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.protectedRadioButton);
            this.Controls.Add(this.privateRadioButton);
            this.Controls.Add(this.publicRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InterfaceTextBox);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Interface_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InterfaceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton publicRadioButton;
        private System.Windows.Forms.RadioButton privateRadioButton;
        private System.Windows.Forms.RadioButton protectedRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button Finishbutton;
        private System.Windows.Forms.Label errorlabel;
    }
}