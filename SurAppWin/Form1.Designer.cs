namespace SurAppWin
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
            groupBox1 = new GroupBox();
            textBoxBY = new TextBox();
            label3 = new Label();
            textBoxBX = new TextBox();
            label2 = new Label();
            textBoxBna = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBoxEY = new TextBox();
            label4 = new Label();
            textBoxEX = new TextBox();
            label5 = new Label();
            textBoxEn = new TextBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            textBox_Dist = new TextBox();
            label_d = new Label();
            textBox_A = new TextBox();
            label_AZ = new Label();
            button_Cal = new Button();
            button_change = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxBY);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxBX);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxBna);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 78);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "起点";
            // 
            // textBoxBY
            // 
            textBoxBY.Location = new Point(407, 26);
            textBoxBY.Name = "textBoxBY";
            textBoxBY.Size = new Size(125, 27);
            textBoxBY.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 26);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 4;
            label3.Text = "Y=";
            // 
            // textBoxBX
            // 
            textBoxBX.Location = new Point(200, 26);
            textBoxBX.Name = "textBoxBX";
            textBoxBX.Size = new Size(125, 27);
            textBoxBX.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 26);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 2;
            label2.Text = "X=";
            // 
            // textBoxBna
            // 
            textBoxBna.Location = new Point(73, 26);
            textBoxBna.Name = "textBoxBna";
            textBoxBna.Size = new Size(53, 27);
            textBoxBna.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "点名";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxEY);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxEX);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxEn);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(563, 78);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "终点";
            // 
            // textBoxEY
            // 
            textBoxEY.Location = new Point(407, 26);
            textBoxEY.Name = "textBoxEY";
            textBoxEY.Size = new Size(125, 27);
            textBoxEY.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 26);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 4;
            label4.Text = "Y=";
            // 
            // textBoxEX
            // 
            textBoxEX.Location = new Point(200, 26);
            textBoxEX.Name = "textBoxEX";
            textBoxEX.Size = new Size(125, 27);
            textBoxEX.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 26);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 2;
            label5.Text = "X=";
            // 
            // textBoxEn
            // 
            textBoxEn.Location = new Point(73, 26);
            textBoxEn.Name = "textBoxEn";
            textBoxEn.Size = new Size(53, 27);
            textBoxEn.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 26);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 0;
            label6.Text = "点名";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox_Dist);
            groupBox3.Controls.Add(label_d);
            groupBox3.Controls.Add(textBox_A);
            groupBox3.Controls.Add(label_AZ);
            groupBox3.Location = new Point(12, 258);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(563, 61);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "计算结果";
            // 
            // textBox_Dist
            // 
            textBox_Dist.Location = new Point(407, 26);
            textBox_Dist.Name = "textBox_Dist";
            textBox_Dist.Size = new Size(125, 27);
            textBox_Dist.TabIndex = 5;
            // 
            // label_d
            // 
            label_d.AutoSize = true;
            label_d.Location = new Point(362, 26);
            label_d.Name = "label_d";
            label_d.Size = new Size(54, 20);
            label_d.TabIndex = 4;
            label_d.Text = "距离：";
            // 
            // textBox_A
            // 
            textBox_A.Location = new Point(231, 26);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(125, 27);
            textBox_A.TabIndex = 3;
            // 
            // label_AZ
            // 
            label_AZ.Location = new Point(6, 29);
            label_AZ.Name = "label_AZ";
            label_AZ.Size = new Size(207, 20);
            label_AZ.TabIndex = 2;
            label_AZ.Text = "坐标方位角：";
            label_AZ.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_Cal
            // 
            button_Cal.Location = new Point(435, 219);
            button_Cal.Name = "button_Cal";
            button_Cal.Size = new Size(94, 29);
            button_Cal.TabIndex = 7;
            button_Cal.Text = "计算";
            button_Cal.UseVisualStyleBackColor = true;
            button_Cal.Click += button_Cal_Click;
            // 
            // button_change
            // 
            button_change.Location = new Point(263, 219);
            button_change.Name = "button_change";
            button_change.Size = new Size(119, 29);
            button_change.TabIndex = 7;
            button_change.Text = "起点<--->终点";
            button_change.UseVisualStyleBackColor = true;
            button_change.Click += button_change_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 333);
            Controls.Add(button_change);
            Controls.Add(button_Cal);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "坐标方位角和距离计算";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxBna;
        private Label label1;
        private TextBox textBoxBY;
        private Label label3;
        private TextBox textBoxBX;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBoxEY;
        private Label label4;
        private TextBox textBoxEX;
        private Label label5;
        private TextBox textBoxEn;
        private Label label6;
        private GroupBox groupBox3;
        private TextBox textBox_Dist;
        private Label label_d;
        private TextBox textBox_A;
        private Label label_AZ;
        private Button button_Cal;
        private Button button_change;
    }
}
