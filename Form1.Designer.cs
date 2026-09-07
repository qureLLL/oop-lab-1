namespace _3практична
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            знятиВсіПрапорціToolStripMenuItem = new ToolStripMenuItem();
            встановитиВсіПрапорціToolStripMenuItem = new ToolStripMenuItem();
            встановитиІнверсіюToolStripMenuItem = new ToolStripMenuItem();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            обчисленняToolStripMenuItem = new ToolStripMenuItem();
            протабулюватиToolStripMenuItem = new ToolStripMenuItem();
            очиститиПолеВиведенняToolStripMenuItem = new ToolStripMenuItem();
            кінецьToolStripMenuItem = new ToolStripMenuItem();
            кінецьToolStripMenuItem1 = new ToolStripMenuItem();
            checkBox4 = new CheckBox();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(185, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaptionText;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(185, 208);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "2";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaptionText;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(185, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "0,2";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(185, 112);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "Ліва межа";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(185, 185);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 4;
            label2.Text = "Права межа";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(185, 262);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "Крок";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(187, 44);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 6;
            label4.Text = "y = sin(x) + 1";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.ContextMenuStrip = contextMenuStrip1;
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(369, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 158);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Виведення";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { знятиВсіПрапорціToolStripMenuItem, встановитиВсіПрапорціToolStripMenuItem, встановитиІнверсіюToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(256, 76);
            // 
            // знятиВсіПрапорціToolStripMenuItem
            // 
            знятиВсіПрапорціToolStripMenuItem.Name = "знятиВсіПрапорціToolStripMenuItem";
            знятиВсіПрапорціToolStripMenuItem.Size = new Size(255, 24);
            знятиВсіПрапорціToolStripMenuItem.Text = "Зняти всі прапорці ";
            знятиВсіПрапорціToolStripMenuItem.Click += знятиВсіПрапорціToolStripMenuItem_Click_1;
            // 
            // встановитиВсіПрапорціToolStripMenuItem
            // 
            встановитиВсіПрапорціToolStripMenuItem.Name = "встановитиВсіПрапорціToolStripMenuItem";
            встановитиВсіПрапорціToolStripMenuItem.Size = new Size(255, 24);
            встановитиВсіПрапорціToolStripMenuItem.Text = "Встановити всі прапорці ";
            встановитиВсіПрапорціToolStripMenuItem.Click += встановитиВсіПрапорціToolStripMenuItem_Click;
            // 
            // встановитиІнверсіюToolStripMenuItem
            // 
            встановитиІнверсіюToolStripMenuItem.Name = "встановитиІнверсіюToolStripMenuItem";
            встановитиІнверсіюToolStripMenuItem.Size = new Size(255, 24);
            встановитиІнверсіюToolStripMenuItem.Text = "Встановити інверсію";
            встановитиІнверсіюToolStripMenuItem.Click += встановитиІнверсіюToolStripMenuItem_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(20, 107);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(94, 23);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "У масив";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(20, 77);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 23);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "У файл";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(20, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 23);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "На екран";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaptionText;
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(12, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 284);
            listBox1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { обчисленняToolStripMenuItem, кінецьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(546, 28);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // обчисленняToolStripMenuItem
            // 
            обчисленняToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { протабулюватиToolStripMenuItem, очиститиПолеВиведенняToolStripMenuItem });
            обчисленняToolStripMenuItem.Name = "обчисленняToolStripMenuItem";
            обчисленняToolStripMenuItem.Size = new Size(109, 24);
            обчисленняToolStripMenuItem.Text = "Обчислення";
            // 
            // протабулюватиToolStripMenuItem
            // 
            протабулюватиToolStripMenuItem.Name = "протабулюватиToolStripMenuItem";
            протабулюватиToolStripMenuItem.Size = new Size(274, 26);
            протабулюватиToolStripMenuItem.Text = "Протабулювати";
            протабулюватиToolStripMenuItem.Click += протабулюватиToolStripMenuItem_Click;
            // 
            // очиститиПолеВиведенняToolStripMenuItem
            // 
            очиститиПолеВиведенняToolStripMenuItem.Name = "очиститиПолеВиведенняToolStripMenuItem";
            очиститиПолеВиведенняToolStripMenuItem.Size = new Size(274, 26);
            очиститиПолеВиведенняToolStripMenuItem.Text = "Очистити поле виведення";
            очиститиПолеВиведенняToolStripMenuItem.Click += очиститиПолеВиведенняToolStripMenuItem_Click;
            // 
            // кінецьToolStripMenuItem
            // 
            кінецьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { кінецьToolStripMenuItem1 });
            кінецьToolStripMenuItem.Name = "кінецьToolStripMenuItem";
            кінецьToolStripMenuItem.Size = new Size(70, 24);
            кінецьToolStripMenuItem.Text = "Кінець";
            кінецьToolStripMenuItem.Click += кінецьToolStripMenuItem_Click;
            // 
            // кінецьToolStripMenuItem1
            // 
            кінецьToolStripMenuItem1.Name = "кінецьToolStripMenuItem1";
            кінецьToolStripMenuItem1.Size = new Size(139, 26);
            кінецьToolStripMenuItem1.Text = "Кінець";
            кінецьToolStripMenuItem1.Click += кінецьToolStripMenuItem_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Black;
            checkBox4.ForeColor = SystemColors.ButtonFace;
            checkBox4.Location = new Point(185, 72);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(87, 24);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Похідна";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(546, 348);
            Controls.Add(checkBox4);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Табулювання функції";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem обчисленняToolStripMenuItem;
        private ToolStripMenuItem протабулюватиToolStripMenuItem;
        private ToolStripMenuItem очиститиПолеВиведенняToolStripMenuItem;
        private ToolStripMenuItem кінецьToolStripMenuItem;
        private ToolStripMenuItem кінецьToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem знятиВсіПрапорціToolStripMenuItem;
        private ToolStripMenuItem встановитиВсіПрапорціToolStripMenuItem;
        private ToolStripMenuItem встановитиІнверсіюToolStripMenuItem;
        private CheckBox checkBox4;
    }
}
