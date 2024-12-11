namespace WinFormsApp1
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
            btnCircleArea = new Button();
            groupBox1 = new GroupBox();
            lblResult = new Label();
            label1 = new Label();
            txtRadius = new TextBox();
            btncircumference = new Button();
            groupBox2 = new GroupBox();
            btnOutputParameter = new Button();
            txtinput = new TextBox();
            btnRefParameter = new Button();
            txtSize = new TextBox();
            txtLetter = new TextBox();
            btnTriangle01 = new Button();
            txtoutput = new TextBox();
            btnArrayParameter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(228, 47);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(75, 23);
            btnCircleArea.TabIndex = 1;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(btncircumference);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Location = new Point(33, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 196);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Circle";
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.AppWorkspace;
            lblResult.Location = new Point(144, 105);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(159, 60);
            lblResult.TabIndex = 5;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 52);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "รัศมีวงกลม";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(102, 47);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(88, 23);
            txtRadius.TabIndex = 3;
            txtRadius.Text = "1";
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // btncircumference
            // 
            btncircumference.Location = new Point(334, 48);
            btncircumference.Name = "btncircumference";
            btncircumference.Size = new Size(75, 23);
            btncircumference.TabIndex = 2;
            btncircumference.Text = "เส้นรอบวง";
            btncircumference.UseVisualStyleBackColor = true;
            btncircumference.Click += btncircumference_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(btnOutputParameter);
            groupBox2.Controls.Add(txtinput);
            groupBox2.Controls.Add(btnRefParameter);
            groupBox2.Controls.Add(txtSize);
            groupBox2.Controls.Add(txtLetter);
            groupBox2.Controls.Add(btnTriangle01);
            groupBox2.Controls.Add(txtoutput);
            groupBox2.Location = new Point(33, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 233);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทดสอบfuction";
            // 
            // btnOutputParameter
            // 
            btnOutputParameter.Location = new Point(188, 189);
            btnOutputParameter.Name = "btnOutputParameter";
            btnOutputParameter.Size = new Size(190, 23);
            btnOutputParameter.TabIndex = 6;
            btnOutputParameter.Text = "ทดสอบ output Parameter";
            btnOutputParameter.UseVisualStyleBackColor = true;
            btnOutputParameter.Click += btnOutputParameter_Click;
            // 
            // txtinput
            // 
            txtinput.Location = new Point(188, 112);
            txtinput.Name = "txtinput";
            txtinput.Size = new Size(190, 23);
            txtinput.TabIndex = 5;
            // 
            // btnRefParameter
            // 
            btnRefParameter.Location = new Point(188, 150);
            btnRefParameter.Name = "btnRefParameter";
            btnRefParameter.Size = new Size(190, 23);
            btnRefParameter.TabIndex = 4;
            btnRefParameter.Text = "ทดสอบ reference parameter";
            btnRefParameter.UseVisualStyleBackColor = true;
            btnRefParameter.Click += btnRefParameter_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(188, 72);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(79, 23);
            txtSize.TabIndex = 3;
            txtSize.Text = "5";
            txtSize.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(188, 32);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(79, 23);
            txtLetter.TabIndex = 2;
            txtLetter.Text = "A";
            txtLetter.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(304, 41);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(74, 41);
            btnTriangle01.TabIndex = 1;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // txtoutput
            // 
            txtoutput.Location = new Point(19, 34);
            txtoutput.Multiline = true;
            txtoutput.Name = "txtoutput";
            txtoutput.Size = new Size(118, 180);
            txtoutput.TabIndex = 0;
            // 
            // btnArrayParameter
            // 
            btnArrayParameter.Location = new Point(511, 36);
            btnArrayParameter.Name = "btnArrayParameter";
            btnArrayParameter.Size = new Size(85, 57);
            btnArrayParameter.TabIndex = 4;
            btnArrayParameter.Text = "Parameter แบบArray";
            btnArrayParameter.UseVisualStyleBackColor = true;
            btnArrayParameter.Click += btnArrayParameter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 492);
            Controls.Add(btnArrayParameter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCircleArea;
        private GroupBox groupBox1;
        private TextBox txtRadius;
        private Button btncircumference;
        private Label lblResult;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtoutput;
        private Button btnTriangle01;
        private TextBox txtSize;
        private TextBox txtLetter;
        private Button btnRefParameter;
        private TextBox txtinput;
        private Button btnOutputParameter;
        private Button btnArrayParameter;
    }
}
