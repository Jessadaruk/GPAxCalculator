namespace Gpax
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
            btnAdd = new Button();
            label1 = new Label();
            tbGPAx = new TextBox();
            tbInputGPA = new TextBox();
            label2 = new Label();
            tbMaxGPA = new TextBox();
            tbMinGPA = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbTotalPeople = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Location = new Point(347, 70);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 65);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add data";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 70);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "ใส่คะแนน GPA";
            // 
            // tbGPAx
            // 
            tbGPAx.Location = new Point(222, 112);
            tbGPAx.Name = "tbGPAx";
            tbGPAx.Size = new Size(100, 23);
            tbGPAx.TabIndex = 2;
            tbGPAx.TextChanged += textBox1_TextChanged;
            // 
            // tbInputGPA
            // 
            tbInputGPA.Location = new Point(222, 66);
            tbInputGPA.Name = "tbInputGPA";
            tbInputGPA.Size = new Size(100, 23);
            tbInputGPA.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 120);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "GPAx";
            // 
            // tbMaxGPA
            // 
            tbMaxGPA.Location = new Point(222, 227);
            tbMaxGPA.Name = "tbMaxGPA";
            tbMaxGPA.Size = new Size(100, 23);
            tbMaxGPA.TabIndex = 5;
            // 
            // tbMinGPA
            // 
            tbMinGPA.Location = new Point(222, 271);
            tbMinGPA.Name = "tbMinGPA";
            tbMinGPA.Size = new Size(100, 23);
            tbMinGPA.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 230);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 7;
            label3.Text = "คะแนนเฉลี่ยสูงสุด";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 274);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 8;
            label4.Text = "คะแนนเฉลี่ยน้อยสุด";
            // 
            // tbTotalPeople
            // 
            tbTotalPeople.Location = new Point(222, 155);
            tbTotalPeople.Name = "tbTotalPeople";
            tbTotalPeople.Size = new Size(100, 23);
            tbTotalPeople.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(131, 158);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 10;
            label5.Text = "จำนวณนักศึกษา";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(490, 312);
            Controls.Add(label5);
            Controls.Add(tbTotalPeople);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbMinGPA);
            Controls.Add(tbMaxGPA);
            Controls.Add(label2);
            Controls.Add(tbInputGPA);
            Controls.Add(tbGPAx);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private TextBox tbGPAx;
        private TextBox tbInputGPA;
        private Label label2;
        private TextBox tbMaxGPA;
        private TextBox tbMinGPA;
        private Label label3;
        private Label label4;
        private TextBox tbTotalPeople;
        private Label label5;
    }
}
