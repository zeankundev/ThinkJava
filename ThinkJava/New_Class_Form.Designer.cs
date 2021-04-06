#region Copyright
/***************************************************************************************
 ******Copyright (C) 2016 Pritam Zope*****
 
  <copyright file="New_Class_Form.Designer.cs" company="">
  
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
    partial class New_Class_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Class_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.publicRadioButton = new System.Windows.Forms.RadioButton();
            this.privateRadioButton = new System.Windows.Forms.RadioButton();
            this.protectedRadioButton = new System.Windows.Forms.RadioButton();
            this.AbstractCheckBox = new System.Windows.Forms.CheckBox();
            this.staticCheckBox = new System.Windows.Forms.CheckBox();
            this.FinalCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuperClassTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InterfaceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.JavaMainMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.ConstructorCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateClasswithThemesCheckBox = new System.Windows.Forms.CheckBox();
            this.MetalThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.MotifThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.NimbusThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.WindowsThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.WindowsClassicThemeCheckBox = new System.Windows.Forms.CheckBox();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Finishbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorlabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class Name : ";
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTextBox.Location = new System.Drawing.Point(124, 99);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.Size = new System.Drawing.Size(584, 23);
            this.ClassTextBox.TabIndex = 3;
            this.ClassTextBox.TextChanged += new System.EventHandler(this.ClassTextBox_TextChanged);
            this.ClassTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClassTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modifiers : ";
            // 
            // publicRadioButton
            // 
            this.publicRadioButton.AutoSize = true;
            this.publicRadioButton.Checked = true;
            this.publicRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicRadioButton.Location = new System.Drawing.Point(124, 147);
            this.publicRadioButton.Name = "publicRadioButton";
            this.publicRadioButton.Size = new System.Drawing.Size(58, 19);
            this.publicRadioButton.TabIndex = 5;
            this.publicRadioButton.TabStop = true;
            this.publicRadioButton.Text = "public";
            this.publicRadioButton.UseVisualStyleBackColor = true;
            // 
            // privateRadioButton
            // 
            this.privateRadioButton.AutoSize = true;
            this.privateRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateRadioButton.Location = new System.Drawing.Point(334, 147);
            this.privateRadioButton.Name = "privateRadioButton";
            this.privateRadioButton.Size = new System.Drawing.Size(61, 19);
            this.privateRadioButton.TabIndex = 6;
            this.privateRadioButton.Text = "private";
            this.privateRadioButton.UseVisualStyleBackColor = true;
            // 
            // protectedRadioButton
            // 
            this.protectedRadioButton.AutoSize = true;
            this.protectedRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protectedRadioButton.Location = new System.Drawing.Point(547, 147);
            this.protectedRadioButton.Name = "protectedRadioButton";
            this.protectedRadioButton.Size = new System.Drawing.Size(76, 19);
            this.protectedRadioButton.TabIndex = 7;
            this.protectedRadioButton.Text = "protected";
            this.protectedRadioButton.UseVisualStyleBackColor = true;
            // 
            // AbstractCheckBox
            // 
            this.AbstractCheckBox.AutoSize = true;
            this.AbstractCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbstractCheckBox.Location = new System.Drawing.Point(124, 194);
            this.AbstractCheckBox.Name = "AbstractCheckBox";
            this.AbstractCheckBox.Size = new System.Drawing.Size(68, 19);
            this.AbstractCheckBox.TabIndex = 8;
            this.AbstractCheckBox.Text = "abstract";
            this.AbstractCheckBox.UseVisualStyleBackColor = true;
            this.AbstractCheckBox.CheckedChanged += new System.EventHandler(this.AbstractCheckBox_CheckedChanged);
            // 
            // staticCheckBox
            // 
            this.staticCheckBox.AutoSize = true;
            this.staticCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticCheckBox.Location = new System.Drawing.Point(334, 194);
            this.staticCheckBox.Name = "staticCheckBox";
            this.staticCheckBox.Size = new System.Drawing.Size(54, 19);
            this.staticCheckBox.TabIndex = 9;
            this.staticCheckBox.Text = "static";
            this.staticCheckBox.UseVisualStyleBackColor = true;
            this.staticCheckBox.CheckedChanged += new System.EventHandler(this.staticCheckBox_CheckedChanged);
            // 
            // FinalCheckBox
            // 
            this.FinalCheckBox.AutoSize = true;
            this.FinalCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCheckBox.Location = new System.Drawing.Point(547, 194);
            this.FinalCheckBox.Name = "FinalCheckBox";
            this.FinalCheckBox.Size = new System.Drawing.Size(49, 19);
            this.FinalCheckBox.TabIndex = 10;
            this.FinalCheckBox.Text = "final";
            this.FinalCheckBox.UseVisualStyleBackColor = true;
            this.FinalCheckBox.CheckedChanged += new System.EventHandler(this.FinalCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Super Class : ";
            // 
            // SuperClassTextBox
            // 
            this.SuperClassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperClassTextBox.Location = new System.Drawing.Point(121, 233);
            this.SuperClassTextBox.Name = "SuperClassTextBox";
            this.SuperClassTextBox.Size = new System.Drawing.Size(584, 23);
            this.SuperClassTextBox.TabIndex = 12;
            this.SuperClassTextBox.TextChanged += new System.EventHandler(this.SuperClassTextBox_TextChanged);
            this.SuperClassTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuperClassTextBox_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Interface : ";
            // 
            // InterfaceTextBox
            // 
            this.InterfaceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterfaceTextBox.Location = new System.Drawing.Point(121, 269);
            this.InterfaceTextBox.Name = "InterfaceTextBox";
            this.InterfaceTextBox.Size = new System.Drawing.Size(584, 23);
            this.InterfaceTextBox.TabIndex = 14;
            this.InterfaceTextBox.TextChanged += new System.EventHandler(this.InterfaceTextBox_TextChanged);
            this.InterfaceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InterfaceTextBox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Methods : ";
            // 
            // JavaMainMethodCheckBox
            // 
            this.JavaMainMethodCheckBox.AutoSize = true;
            this.JavaMainMethodCheckBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.JavaMainMethodCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JavaMainMethodCheckBox.Location = new System.Drawing.Point(252, 310);
            this.JavaMainMethodCheckBox.Name = "JavaMainMethodCheckBox";
            this.JavaMainMethodCheckBox.Size = new System.Drawing.Size(218, 19);
            this.JavaMainMethodCheckBox.TabIndex = 16;
            this.JavaMainMethodCheckBox.Text = "public static void main(String[] args)";
            this.JavaMainMethodCheckBox.UseVisualStyleBackColor = true;
            this.JavaMainMethodCheckBox.CheckedChanged += new System.EventHandler(this.JavaMainMethodCheckBox_CheckedChanged);
            // 
            // ConstructorCheckBox
            // 
            this.ConstructorCheckBox.AutoSize = true;
            this.ConstructorCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstructorCheckBox.Location = new System.Drawing.Point(252, 342);
            this.ConstructorCheckBox.Name = "ConstructorCheckBox";
            this.ConstructorCheckBox.Size = new System.Drawing.Size(126, 19);
            this.ConstructorCheckBox.TabIndex = 17;
            this.ConstructorCheckBox.Text = "Create Constructor";
            this.ConstructorCheckBox.UseVisualStyleBackColor = true;
            this.ConstructorCheckBox.CheckedChanged += new System.EventHandler(this.ConstructorCheckBox_CheckedChanged);
            // 
            // CreateClasswithThemesCheckBox
            // 
            this.CreateClasswithThemesCheckBox.AutoSize = true;
            this.CreateClasswithThemesCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateClasswithThemesCheckBox.Location = new System.Drawing.Point(16, 366);
            this.CreateClasswithThemesCheckBox.Name = "CreateClasswithThemesCheckBox";
            this.CreateClasswithThemesCheckBox.Size = new System.Drawing.Size(195, 19);
            this.CreateClasswithThemesCheckBox.TabIndex = 18;
            this.CreateClasswithThemesCheckBox.Text = "Create Class with Java Themes : ";
            this.CreateClasswithThemesCheckBox.UseVisualStyleBackColor = true;
            this.CreateClasswithThemesCheckBox.CheckedChanged += new System.EventHandler(this.CreateClasswithThemesCheckBox_CheckedChanged);
            // 
            // MetalThemeCheckBox
            // 
            this.MetalThemeCheckBox.AutoSize = true;
            this.MetalThemeCheckBox.Enabled = false;
            this.MetalThemeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetalThemeCheckBox.Location = new System.Drawing.Point(47, 414);
            this.MetalThemeCheckBox.Name = "MetalThemeCheckBox";
            this.MetalThemeCheckBox.Size = new System.Drawing.Size(56, 19);
            this.MetalThemeCheckBox.TabIndex = 19;
            this.MetalThemeCheckBox.Text = "Metal";
            this.MetalThemeCheckBox.UseVisualStyleBackColor = true;
            this.MetalThemeCheckBox.CheckedChanged += new System.EventHandler(this.MetalThemeCheckBox_CheckedChanged);
            // 
            // MotifThemeCheckBox
            // 
            this.MotifThemeCheckBox.AutoSize = true;
            this.MotifThemeCheckBox.Enabled = false;
            this.MotifThemeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotifThemeCheckBox.Location = new System.Drawing.Point(157, 414);
            this.MotifThemeCheckBox.Name = "MotifThemeCheckBox";
            this.MotifThemeCheckBox.Size = new System.Drawing.Size(55, 19);
            this.MotifThemeCheckBox.TabIndex = 20;
            this.MotifThemeCheckBox.Text = "Motif";
            this.MotifThemeCheckBox.UseVisualStyleBackColor = true;
            this.MotifThemeCheckBox.CheckedChanged += new System.EventHandler(this.MotifThemeCheckBox_CheckedChanged);
            // 
            // NimbusThemeCheckBox
            // 
            this.NimbusThemeCheckBox.AutoSize = true;
            this.NimbusThemeCheckBox.Enabled = false;
            this.NimbusThemeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NimbusThemeCheckBox.Location = new System.Drawing.Point(268, 414);
            this.NimbusThemeCheckBox.Name = "NimbusThemeCheckBox";
            this.NimbusThemeCheckBox.Size = new System.Drawing.Size(68, 19);
            this.NimbusThemeCheckBox.TabIndex = 21;
            this.NimbusThemeCheckBox.Text = "Nimbus";
            this.NimbusThemeCheckBox.UseVisualStyleBackColor = true;
            this.NimbusThemeCheckBox.CheckedChanged += new System.EventHandler(this.NimbusThemeCheckBox_CheckedChanged);
            // 
            // WindowsThemeCheckBox
            // 
            this.WindowsThemeCheckBox.AutoSize = true;
            this.WindowsThemeCheckBox.Checked = true;
            this.WindowsThemeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WindowsThemeCheckBox.Enabled = false;
            this.WindowsThemeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsThemeCheckBox.Location = new System.Drawing.Point(387, 414);
            this.WindowsThemeCheckBox.Name = "WindowsThemeCheckBox";
            this.WindowsThemeCheckBox.Size = new System.Drawing.Size(75, 19);
            this.WindowsThemeCheckBox.TabIndex = 22;
            this.WindowsThemeCheckBox.Text = "Windows";
            this.WindowsThemeCheckBox.UseVisualStyleBackColor = true;
            this.WindowsThemeCheckBox.CheckedChanged += new System.EventHandler(this.WindowsThemeCheckBox_CheckedChanged);
            // 
            // WindowsClassicThemeCheckBox
            // 
            this.WindowsClassicThemeCheckBox.AutoSize = true;
            this.WindowsClassicThemeCheckBox.Enabled = false;
            this.WindowsClassicThemeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsClassicThemeCheckBox.Location = new System.Drawing.Point(526, 414);
            this.WindowsClassicThemeCheckBox.Name = "WindowsClassicThemeCheckBox";
            this.WindowsClassicThemeCheckBox.Size = new System.Drawing.Size(114, 19);
            this.WindowsClassicThemeCheckBox.TabIndex = 23;
            this.WindowsClassicThemeCheckBox.Text = "Windows Classic";
            this.WindowsClassicThemeCheckBox.UseVisualStyleBackColor = true;
            this.WindowsClassicThemeCheckBox.CheckedChanged += new System.EventHandler(this.WindowsClassicThemeCheckBox_CheckedChanged);
            // 
            // Helpbutton
            // 
            this.Helpbutton.Location = new System.Drawing.Point(621, 508);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(87, 29);
            this.Helpbutton.TabIndex = 35;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = true;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(526, 508);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(87, 29);
            this.Cancelbutton.TabIndex = 34;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Finishbutton
            // 
            this.Finishbutton.Enabled = false;
            this.Finishbutton.Location = new System.Drawing.Point(432, 508);
            this.Finishbutton.Name = "Finishbutton";
            this.Finishbutton.Size = new System.Drawing.Size(87, 29);
            this.Finishbutton.TabIndex = 33;
            this.Finishbutton.Text = "Finish";
            this.Finishbutton.UseVisualStyleBackColor = true;
            this.Finishbutton.Click += new System.EventHandler(this.Finishbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 1);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New Class";
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(14, 513);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 15);
            this.errorlabel.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(234, 453);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(246, 15);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to explore more in the Marketplace";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // New_Class_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 550);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Finishbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.WindowsClassicThemeCheckBox);
            this.Controls.Add(this.WindowsThemeCheckBox);
            this.Controls.Add(this.NimbusThemeCheckBox);
            this.Controls.Add(this.MotifThemeCheckBox);
            this.Controls.Add(this.MetalThemeCheckBox);
            this.Controls.Add(this.CreateClasswithThemesCheckBox);
            this.Controls.Add(this.ConstructorCheckBox);
            this.Controls.Add(this.JavaMainMethodCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InterfaceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SuperClassTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FinalCheckBox);
            this.Controls.Add(this.staticCheckBox);
            this.Controls.Add(this.AbstractCheckBox);
            this.Controls.Add(this.protectedRadioButton);
            this.Controls.Add(this.privateRadioButton);
            this.Controls.Add(this.publicRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClassTextBox);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Class_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClassTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton publicRadioButton;
        private System.Windows.Forms.RadioButton privateRadioButton;
        private System.Windows.Forms.RadioButton protectedRadioButton;
        private System.Windows.Forms.CheckBox AbstractCheckBox;
        private System.Windows.Forms.CheckBox staticCheckBox;
        private System.Windows.Forms.CheckBox FinalCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SuperClassTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InterfaceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox JavaMainMethodCheckBox;
        private System.Windows.Forms.CheckBox ConstructorCheckBox;
        private System.Windows.Forms.CheckBox CreateClasswithThemesCheckBox;
        private System.Windows.Forms.CheckBox MetalThemeCheckBox;
        private System.Windows.Forms.CheckBox MotifThemeCheckBox;
        private System.Windows.Forms.CheckBox NimbusThemeCheckBox;
        private System.Windows.Forms.CheckBox WindowsThemeCheckBox;
        private System.Windows.Forms.CheckBox WindowsClassicThemeCheckBox;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Finishbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}