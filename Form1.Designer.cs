namespace RE_JavaTexturePackage2NBTP
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
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 293);
            label3.Name = "label3";
            label3.Size = new Size(268, 17);
            label3.TabIndex = 2;
            label3.Text = "适用范围：1.6.0到1.18.12的所有JE材质，素材包";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(617, 293);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 3;
            label1.Text = "Ver240512";
            // 
            // button1
            // 
            button1.Location = new Point(617, 12);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 4;
            button1.Text = "打开";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 5;
            label2.Text = "BE路径";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "此处的路径指是就是windowsmc文件夹路径，一般在MCLDownload/MinecraftBE下";
            textBox1.Size = new Size(548, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 45);
            label4.Name = "label4";
            label4.Size = new Size(272, 17);
            label4.TabIndex = 7;
            label4.Text = "音效、材质包载入顺序（后面的会替换前面的）：";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Items.AddRange(new object[] { "(音效包)我是名字", "(材质包)我还是名字", "(未知)我是加载错误" });
            listBox1.Location = new Point(12, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(226, 208);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(244, 65);
            button2.Name = "button2";
            button2.Size = new Size(88, 33);
            button2.TabIndex = 9;
            button2.Text = "添加";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(338, 65);
            button3.Name = "button3";
            button3.Size = new Size(88, 33);
            button3.TabIndex = 10;
            button3.Text = "移除";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(244, 104);
            button4.Name = "button4";
            button4.Size = new Size(88, 33);
            button4.TabIndex = 11;
            button4.Text = "上移";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(338, 104);
            button5.Name = "button5";
            button5.Size = new Size(88, 33);
            button5.TabIndex = 12;
            button5.Text = "下移";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(244, 143);
            button6.Name = "button6";
            button6.Size = new Size(88, 33);
            button6.TabIndex = 13;
            button6.Text = "置顶";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(338, 143);
            button7.Name = "button7";
            button7.Size = new Size(88, 33);
            button7.TabIndex = 14;
            button7.Text = "置底";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(462, 65);
            button8.Name = "button8";
            button8.Size = new Size(208, 74);
            button8.TabIndex = 15;
            button8.Text = "点我开始转换";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 319);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "RE:JTP2NBTP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
