namespace GPACalculator
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.textBoxMinName = new System.Windows.Forms.TextBox();
            this.textBoxMaxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAlldata = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA INPUT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1007, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName_input.Location = new System.Drawing.Point(203, 42);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(452, 52);
            this.textBoxName_input.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "GPAX";
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGPAx.Location = new System.Drawing.Point(649, 36);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.ReadOnly = true;
            this.textBoxGPAx.Size = new System.Drawing.Size(310, 52);
            this.textBoxGPAx.TabIndex = 6;
            this.textBoxGPAx.TabStop = false;
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGPA_input.Location = new System.Drawing.Point(670, 42);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(310, 52);
            this.textBoxGPA_input.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.textBoxMinName);
            this.groupBox1.Controls.Add(this.textBoxMaxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 294);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "output";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(986, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 71);
            this.button2.TabIndex = 13;
            this.button2.TabStop = false;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinGPA.Location = new System.Drawing.Point(649, 189);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.ReadOnly = true;
            this.textBoxMinGPA.Size = new System.Drawing.Size(310, 52);
            this.textBoxMinGPA.TabIndex = 12;
            this.textBoxMinGPA.TabStop = false;
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxGPA.Location = new System.Drawing.Point(649, 109);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.ReadOnly = true;
            this.textBoxMaxGPA.Size = new System.Drawing.Size(310, 52);
            this.textBoxMaxGPA.TabIndex = 11;
            this.textBoxMaxGPA.TabStop = false;
            // 
            // textBoxMinName
            // 
            this.textBoxMinName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinName.Location = new System.Drawing.Point(176, 189);
            this.textBoxMinName.Name = "textBoxMinName";
            this.textBoxMinName.ReadOnly = true;
            this.textBoxMinName.Size = new System.Drawing.Size(452, 52);
            this.textBoxMinName.TabIndex = 10;
            this.textBoxMinName.TabStop = false;
            // 
            // textBoxMaxName
            // 
            this.textBoxMaxName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxName.Location = new System.Drawing.Point(176, 109);
            this.textBoxMaxName.Name = "textBoxMaxName";
            this.textBoxMaxName.ReadOnly = true;
            this.textBoxMaxName.Size = new System.Drawing.Size(452, 52);
            this.textBoxMaxName.TabIndex = 9;
            this.textBoxMaxName.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "MIN GPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "MAX GPA";
            // 
            // textBoxAlldata
            // 
            this.textBoxAlldata.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAlldata.Location = new System.Drawing.Point(21, 427);
            this.textBoxAlldata.Multiline = true;
            this.textBoxAlldata.Name = "textBoxAlldata";
            this.textBoxAlldata.ReadOnly = true;
            this.textBoxAlldata.Size = new System.Drawing.Size(1164, 245);
            this.textBoxAlldata.TabIndex = 9;
            this.textBoxAlldata.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1210, 696);
            this.Controls.Add(this.textBoxAlldata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxGPA_input);
            this.Controls.Add(this.textBoxName_input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBoxName_input;
        private Label label2;
        private TextBox textBoxGPAx;
        private TextBox textBoxGPA_input;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBoxMinGPA;
        private TextBox textBoxMaxGPA;
        private TextBox textBoxMinName;
        private TextBox textBoxMaxName;
        private Label label4;
        private Label label3;
        private TextBox textBoxAlldata;
    }
}