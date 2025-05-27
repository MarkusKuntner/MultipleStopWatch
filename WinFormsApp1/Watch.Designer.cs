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
            components = new System.ComponentModel.Container();
            start = new Button();
            stop = new Button();
            labelTimeSum = new Label();
            save = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox1a = new ComboBox();
            labelTime = new Label();
            labelLap = new Label();
            comboBox2a = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            textBox2 = new TextBox();
            comboBox3a = new ComboBox();
            label3 = new Label();
            comboBox3 = new ComboBox();
            button4 = new Button();
            textBox3 = new TextBox();
            comboBox4a = new ComboBox();
            label4 = new Label();
            comboBox4 = new ComboBox();
            button5 = new Button();
            textBox4 = new TextBox();
            comboBox5a = new ComboBox();
            label5 = new Label();
            comboBox5 = new ComboBox();
            button6 = new Button();
            textBox5 = new TextBox();
            comboBox6a = new ComboBox();
            label6 = new Label();
            comboBox6 = new ComboBox();
            button7 = new Button();
            textBox6 = new TextBox();
            comboBox7a = new ComboBox();
            label7 = new Label();
            comboBox7 = new ComboBox();
            button8 = new Button();
            textBox7 = new TextBox();
            comboBox8a = new ComboBox();
            label8 = new Label();
            comboBox8 = new ComboBox();
            button9 = new Button();
            textBox8 = new TextBox();
            comboBox9a = new ComboBox();
            label9 = new Label();
            comboBox9 = new ComboBox();
            button10 = new Button();
            textBox9 = new TextBox();
            comboBox10a = new ComboBox();
            label10 = new Label();
            comboBox10 = new ComboBox();
            button11 = new Button();
            textBox10 = new TextBox();
            comboBox11a = new ComboBox();
            label11 = new Label();
            comboBox11 = new ComboBox();
            button12 = new Button();
            textBox11 = new TextBox();
            comboBox12a = new ComboBox();
            label12 = new Label();
            comboBox12 = new ComboBox();
            button13 = new Button();
            textBox12 = new TextBox();
            comboBox13a = new ComboBox();
            label13 = new Label();
            comboBox13 = new ComboBox();
            button14 = new Button();
            textBox13 = new TextBox();
            comboBox14a = new ComboBox();
            label14 = new Label();
            comboBox14 = new ComboBox();
            button15 = new Button();
            textBox14 = new TextBox();
            comboBox15a = new ComboBox();
            label15 = new Label();
            comboBox15 = new ComboBox();
            textBox15 = new TextBox();
            button2 = new Button();
            button16 = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // start
            // 
            start.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start.Location = new Point(39, 22);
            start.Name = "start";
            start.Size = new Size(146, 69);
            start.TabIndex = 0;
            start.Text = "&Start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stop.Location = new Point(204, 22);
            stop.Name = "stop";
            stop.Size = new Size(146, 69);
            stop.TabIndex = 1;
            stop.Text = "Stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // labelTimeSum
            // 
            labelTimeSum.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimeSum.Location = new Point(372, 28);
            labelTimeSum.Name = "labelTimeSum";
            labelTimeSum.Size = new Size(167, 52);
            labelTimeSum.TabIndex = 2;
            labelTimeSum.Text = "00:00:00";
            // 
            // save
            // 
            save.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save.Location = new Point(536, 22);
            save.Name = "save";
            save.Size = new Size(146, 69);
            save.TabIndex = 3;
            save.Text = "Save";
            toolTip1.SetToolTip(save, "Save ltotal and lap times");
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(39, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 33);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(737, 125);
            button1.Name = "button1";
            button1.Size = new Size(92, 38);
            button1.TabIndex = 5;
            button1.TabStop = false;
            button1.Text = "&Lap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(411, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(128, 33);
            comboBox1.TabIndex = 6;
            comboBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(699, 133);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 7;
            label1.Text = "0";
            // 
            // comboBox1a
            // 
            comboBox1a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1a.FormattingEnabled = true;
            comboBox1a.Location = new Point(554, 130);
            comboBox1a.Name = "comboBox1a";
            comboBox1a.Size = new Size(128, 33);
            comboBox1a.TabIndex = 8;
            comboBox1a.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(429, 102);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(98, 25);
            labelTime.TabIndex = 9;
            labelTime.Text = "Total Time";
            // 
            // labelLap
            // 
            labelLap.AutoSize = true;
            labelLap.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLap.Location = new Point(574, 102);
            labelLap.Name = "labelLap";
            labelLap.Size = new Size(88, 25);
            labelLap.TabIndex = 10;
            labelLap.Text = "Lap Time";
            // 
            // comboBox2a
            // 
            comboBox2a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2a.FormattingEnabled = true;
            comboBox2a.Location = new Point(554, 180);
            comboBox2a.Name = "comboBox2a";
            comboBox2a.Size = new Size(128, 33);
            comboBox2a.TabIndex = 15;
            comboBox2a.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(699, 183);
            label2.Name = "label2";
            label2.Size = new Size(22, 25);
            label2.TabIndex = 14;
            label2.Text = "0";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(411, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(128, 33);
            comboBox2.TabIndex = 13;
            comboBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(737, 227);
            button3.Name = "button3";
            button3.Size = new Size(92, 38);
            button3.TabIndex = 12;
            button3.TabStop = false;
            button3.Text = "&Lap";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(39, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 33);
            textBox2.TabIndex = 11;
            // 
            // comboBox3a
            // 
            comboBox3a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3a.FormattingEnabled = true;
            comboBox3a.Location = new Point(554, 233);
            comboBox3a.Name = "comboBox3a";
            comboBox3a.Size = new Size(128, 33);
            comboBox3a.TabIndex = 20;
            comboBox3a.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(699, 236);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 19;
            label3.Text = "0";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(411, 233);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(128, 33);
            comboBox3.TabIndex = 18;
            comboBox3.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(737, 280);
            button4.Name = "button4";
            button4.Size = new Size(92, 38);
            button4.TabIndex = 17;
            button4.TabStop = false;
            button4.Text = "&Lap";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(39, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 33);
            textBox3.TabIndex = 16;
            // 
            // comboBox4a
            // 
            comboBox4a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4a.FormattingEnabled = true;
            comboBox4a.Location = new Point(554, 285);
            comboBox4a.Name = "comboBox4a";
            comboBox4a.Size = new Size(128, 33);
            comboBox4a.TabIndex = 25;
            comboBox4a.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(699, 288);
            label4.Name = "label4";
            label4.Size = new Size(22, 25);
            label4.TabIndex = 24;
            label4.Text = "0";
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(411, 285);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(128, 33);
            comboBox4.TabIndex = 23;
            comboBox4.TabStop = false;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(737, 332);
            button5.Name = "button5";
            button5.Size = new Size(92, 38);
            button5.TabIndex = 22;
            button5.TabStop = false;
            button5.Text = "&Lap";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(39, 284);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(350, 33);
            textBox4.TabIndex = 21;
            // 
            // comboBox5a
            // 
            comboBox5a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5a.FormattingEnabled = true;
            comboBox5a.Location = new Point(554, 340);
            comboBox5a.Name = "comboBox5a";
            comboBox5a.Size = new Size(128, 33);
            comboBox5a.TabIndex = 30;
            comboBox5a.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(699, 343);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 29;
            label5.Text = "0";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(411, 340);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(128, 33);
            comboBox5.TabIndex = 28;
            comboBox5.TabStop = false;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(737, 387);
            button6.Name = "button6";
            button6.Size = new Size(92, 38);
            button6.TabIndex = 27;
            button6.TabStop = false;
            button6.Text = "&Lap";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(39, 339);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(350, 33);
            textBox5.TabIndex = 26;
            // 
            // comboBox6a
            // 
            comboBox6a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox6a.FormattingEnabled = true;
            comboBox6a.Location = new Point(554, 393);
            comboBox6a.Name = "comboBox6a";
            comboBox6a.Size = new Size(128, 33);
            comboBox6a.TabIndex = 35;
            comboBox6a.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(699, 396);
            label6.Name = "label6";
            label6.Size = new Size(22, 25);
            label6.TabIndex = 34;
            label6.Text = "0";
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(411, 393);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(128, 33);
            comboBox6.TabIndex = 33;
            comboBox6.TabStop = false;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(737, 440);
            button7.Name = "button7";
            button7.Size = new Size(92, 38);
            button7.TabIndex = 32;
            button7.TabStop = false;
            button7.Text = "&Lap";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(39, 392);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(350, 33);
            textBox6.TabIndex = 31;
            // 
            // comboBox7a
            // 
            comboBox7a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox7a.FormattingEnabled = true;
            comboBox7a.Location = new Point(554, 445);
            comboBox7a.Name = "comboBox7a";
            comboBox7a.Size = new Size(128, 33);
            comboBox7a.TabIndex = 40;
            comboBox7a.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(699, 448);
            label7.Name = "label7";
            label7.Size = new Size(22, 25);
            label7.TabIndex = 39;
            label7.Text = "0";
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(411, 445);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(128, 33);
            comboBox7.TabIndex = 38;
            comboBox7.TabStop = false;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(737, 492);
            button8.Name = "button8";
            button8.Size = new Size(92, 38);
            button8.TabIndex = 37;
            button8.TabStop = false;
            button8.Text = "&Lap";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(39, 444);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(350, 33);
            textBox7.TabIndex = 36;
            // 
            // comboBox8a
            // 
            comboBox8a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox8a.FormattingEnabled = true;
            comboBox8a.Location = new Point(554, 496);
            comboBox8a.Name = "comboBox8a";
            comboBox8a.Size = new Size(128, 33);
            comboBox8a.TabIndex = 45;
            comboBox8a.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(699, 499);
            label8.Name = "label8";
            label8.Size = new Size(22, 25);
            label8.TabIndex = 44;
            label8.Text = "0";
            // 
            // comboBox8
            // 
            comboBox8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(411, 496);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(128, 33);
            comboBox8.TabIndex = 43;
            comboBox8.TabStop = false;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(737, 543);
            button9.Name = "button9";
            button9.Size = new Size(92, 38);
            button9.TabIndex = 42;
            button9.TabStop = false;
            button9.Text = "&Lap";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(39, 495);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(350, 33);
            textBox8.TabIndex = 41;
            // 
            // comboBox9a
            // 
            comboBox9a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox9a.FormattingEnabled = true;
            comboBox9a.Location = new Point(554, 545);
            comboBox9a.Name = "comboBox9a";
            comboBox9a.Size = new Size(128, 33);
            comboBox9a.TabIndex = 50;
            comboBox9a.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(699, 548);
            label9.Name = "label9";
            label9.Size = new Size(22, 25);
            label9.TabIndex = 49;
            label9.Text = "0";
            // 
            // comboBox9
            // 
            comboBox9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(411, 545);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(128, 33);
            comboBox9.TabIndex = 48;
            comboBox9.TabStop = false;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(737, 592);
            button10.Name = "button10";
            button10.Size = new Size(92, 38);
            button10.TabIndex = 47;
            button10.TabStop = false;
            button10.Text = "&Lap";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button1_Click;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(39, 544);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(350, 33);
            textBox9.TabIndex = 46;
            // 
            // comboBox10a
            // 
            comboBox10a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox10a.FormattingEnabled = true;
            comboBox10a.Location = new Point(554, 598);
            comboBox10a.Name = "comboBox10a";
            comboBox10a.Size = new Size(128, 33);
            comboBox10a.TabIndex = 55;
            comboBox10a.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(699, 601);
            label10.Name = "label10";
            label10.Size = new Size(22, 25);
            label10.TabIndex = 54;
            label10.Text = "0";
            // 
            // comboBox10
            // 
            comboBox10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(411, 598);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(128, 33);
            comboBox10.TabIndex = 53;
            comboBox10.TabStop = false;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Location = new Point(737, 645);
            button11.Name = "button11";
            button11.Size = new Size(92, 38);
            button11.TabIndex = 52;
            button11.TabStop = false;
            button11.Text = "&Lap";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button1_Click;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox10.Location = new Point(39, 597);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(350, 33);
            textBox10.TabIndex = 51;
            // 
            // comboBox11a
            // 
            comboBox11a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox11a.FormattingEnabled = true;
            comboBox11a.Location = new Point(554, 649);
            comboBox11a.Name = "comboBox11a";
            comboBox11a.Size = new Size(128, 33);
            comboBox11a.TabIndex = 60;
            comboBox11a.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(699, 652);
            label11.Name = "label11";
            label11.Size = new Size(22, 25);
            label11.TabIndex = 59;
            label11.Text = "0";
            // 
            // comboBox11
            // 
            comboBox11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox11.FormattingEnabled = true;
            comboBox11.Location = new Point(411, 649);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(128, 33);
            comboBox11.TabIndex = 58;
            comboBox11.TabStop = false;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Location = new Point(737, 696);
            button12.Name = "button12";
            button12.Size = new Size(92, 38);
            button12.TabIndex = 57;
            button12.TabStop = false;
            button12.Text = "&Lap";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button1_Click;
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox11.Location = new Point(39, 648);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(350, 33);
            textBox11.TabIndex = 56;
            // 
            // comboBox12a
            // 
            comboBox12a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox12a.FormattingEnabled = true;
            comboBox12a.Location = new Point(554, 698);
            comboBox12a.Name = "comboBox12a";
            comboBox12a.Size = new Size(128, 33);
            comboBox12a.TabIndex = 65;
            comboBox12a.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(699, 701);
            label12.Name = "label12";
            label12.Size = new Size(22, 25);
            label12.TabIndex = 64;
            label12.Text = "0";
            // 
            // comboBox12
            // 
            comboBox12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox12.FormattingEnabled = true;
            comboBox12.Location = new Point(411, 698);
            comboBox12.Name = "comboBox12";
            comboBox12.Size = new Size(128, 33);
            comboBox12.TabIndex = 63;
            comboBox12.TabStop = false;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Location = new Point(737, 745);
            button13.Name = "button13";
            button13.Size = new Size(92, 38);
            button13.TabIndex = 62;
            button13.TabStop = false;
            button13.Text = "&Lap";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button1_Click;
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox12.Location = new Point(39, 697);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(350, 33);
            textBox12.TabIndex = 61;
            // 
            // comboBox13a
            // 
            comboBox13a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox13a.FormattingEnabled = true;
            comboBox13a.Location = new Point(554, 746);
            comboBox13a.Name = "comboBox13a";
            comboBox13a.Size = new Size(128, 33);
            comboBox13a.TabIndex = 70;
            comboBox13a.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(699, 749);
            label13.Name = "label13";
            label13.Size = new Size(22, 25);
            label13.TabIndex = 69;
            label13.Text = "0";
            // 
            // comboBox13
            // 
            comboBox13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox13.FormattingEnabled = true;
            comboBox13.Location = new Point(411, 746);
            comboBox13.Name = "comboBox13";
            comboBox13.Size = new Size(128, 33);
            comboBox13.TabIndex = 68;
            comboBox13.TabStop = false;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.Location = new Point(737, 793);
            button14.Name = "button14";
            button14.Size = new Size(92, 38);
            button14.TabIndex = 67;
            button14.TabStop = false;
            button14.Text = "&Lap";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button1_Click;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox13.Location = new Point(39, 745);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(350, 33);
            textBox13.TabIndex = 66;
            // 
            // comboBox14a
            // 
            comboBox14a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox14a.FormattingEnabled = true;
            comboBox14a.Location = new Point(554, 795);
            comboBox14a.Name = "comboBox14a";
            comboBox14a.Size = new Size(128, 33);
            comboBox14a.TabIndex = 75;
            comboBox14a.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(699, 798);
            label14.Name = "label14";
            label14.Size = new Size(22, 25);
            label14.TabIndex = 74;
            label14.Text = "0";
            // 
            // comboBox14
            // 
            comboBox14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox14.FormattingEnabled = true;
            comboBox14.Location = new Point(411, 795);
            comboBox14.Name = "comboBox14";
            comboBox14.Size = new Size(128, 33);
            comboBox14.TabIndex = 73;
            comboBox14.TabStop = false;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.Location = new Point(737, 842);
            button15.Name = "button15";
            button15.Size = new Size(92, 38);
            button15.TabIndex = 72;
            button15.TabStop = false;
            button15.Text = "&Lap";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button1_Click;
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox14.Location = new Point(39, 794);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(350, 33);
            textBox14.TabIndex = 71;
            // 
            // comboBox15a
            // 
            comboBox15a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox15a.FormattingEnabled = true;
            comboBox15a.Location = new Point(554, 845);
            comboBox15a.Name = "comboBox15a";
            comboBox15a.Size = new Size(128, 33);
            comboBox15a.TabIndex = 80;
            comboBox15a.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(699, 848);
            label15.Name = "label15";
            label15.Size = new Size(22, 25);
            label15.TabIndex = 79;
            label15.Text = "0";
            // 
            // comboBox15
            // 
            comboBox15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox15.FormattingEnabled = true;
            comboBox15.Location = new Point(411, 845);
            comboBox15.Name = "comboBox15";
            comboBox15.Size = new Size(128, 33);
            comboBox15.TabIndex = 78;
            comboBox15.TabStop = false;
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox15.Location = new Point(39, 844);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(350, 33);
            textBox15.TabIndex = 76;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(737, 179);
            button2.Name = "button2";
            button2.Size = new Size(92, 38);
            button2.TabIndex = 81;
            button2.TabStop = false;
            button2.Text = "&Lap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.Location = new Point(700, 22);
            button16.Name = "button16";
            button16.Size = new Size(146, 69);
            button16.TabIndex = 82;
            button16.Text = "Load";
            toolTip1.SetToolTip(button16, "Load a list of names");
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 904);
            Controls.Add(button16);
            Controls.Add(button2);
            Controls.Add(comboBox15a);
            Controls.Add(label15);
            Controls.Add(comboBox15);
            Controls.Add(textBox15);
            Controls.Add(comboBox14a);
            Controls.Add(label14);
            Controls.Add(comboBox14);
            Controls.Add(button15);
            Controls.Add(textBox14);
            Controls.Add(comboBox13a);
            Controls.Add(label13);
            Controls.Add(comboBox13);
            Controls.Add(button14);
            Controls.Add(textBox13);
            Controls.Add(comboBox12a);
            Controls.Add(label12);
            Controls.Add(comboBox12);
            Controls.Add(button13);
            Controls.Add(textBox12);
            Controls.Add(comboBox11a);
            Controls.Add(label11);
            Controls.Add(comboBox11);
            Controls.Add(button12);
            Controls.Add(textBox11);
            Controls.Add(comboBox10a);
            Controls.Add(label10);
            Controls.Add(comboBox10);
            Controls.Add(button11);
            Controls.Add(textBox10);
            Controls.Add(comboBox9a);
            Controls.Add(label9);
            Controls.Add(comboBox9);
            Controls.Add(button10);
            Controls.Add(textBox9);
            Controls.Add(comboBox8a);
            Controls.Add(label8);
            Controls.Add(comboBox8);
            Controls.Add(button9);
            Controls.Add(textBox8);
            Controls.Add(comboBox7a);
            Controls.Add(label7);
            Controls.Add(comboBox7);
            Controls.Add(button8);
            Controls.Add(textBox7);
            Controls.Add(comboBox6a);
            Controls.Add(label6);
            Controls.Add(comboBox6);
            Controls.Add(button7);
            Controls.Add(textBox6);
            Controls.Add(comboBox5a);
            Controls.Add(label5);
            Controls.Add(comboBox5);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(comboBox4a);
            Controls.Add(label4);
            Controls.Add(comboBox4);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(comboBox3a);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(comboBox2a);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(labelLap);
            Controls.Add(labelTime);
            Controls.Add(comboBox1a);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(save);
            Controls.Add(labelTimeSum);
            Controls.Add(stop);
            Controls.Add(start);
            Name = "Form1";
            Text = "Stop Watch";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private Button stop;
        public Label labelTimeSum;
        private Button save;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox1a;
        private Label labelTime;
        private Label labelLap;
        private ComboBox comboBox2a;
        private Label label2;
        private ComboBox comboBox2;
        private Button button3;
        private TextBox textBox2;
        private ComboBox comboBox3a;
        private Label label3;
        private ComboBox comboBox3;
        private Button button4;
        private TextBox textBox3;
        private ComboBox comboBox4a;
        private Label label4;
        private ComboBox comboBox4;
        private Button button5;
        private TextBox textBox4;
        private ComboBox comboBox5a;
        private Label label5;
        private ComboBox comboBox5;
        private Button button6;
        private TextBox textBox5;
        private ComboBox comboBox6a;
        private Label label6;
        private ComboBox comboBox6;
        private Button button7;
        private TextBox textBox6;
        private ComboBox comboBox7a;
        private Label label7;
        private ComboBox comboBox7;
        private Button button8;
        private TextBox textBox7;
        private ComboBox comboBox8a;
        private Label label8;
        private ComboBox comboBox8;
        private Button button9;
        private TextBox textBox8;
        private ComboBox comboBox9a;
        private Label label9;
        private ComboBox comboBox9;
        private Button button10;
        private TextBox textBox9;
        private ComboBox comboBox10a;
        private Label label10;
        private ComboBox comboBox10;
        private Button button11;
        private TextBox textBox10;
        private ComboBox comboBox11a;
        private Label label11;
        private ComboBox comboBox11;
        private Button button12;
        private TextBox textBox11;
        private ComboBox comboBox12a;
        private Label label12;
        private ComboBox comboBox12;
        private Button button13;
        private TextBox textBox12;
        private ComboBox comboBox13a;
        private Label label13;
        private ComboBox comboBox13;
        private Button button14;
        private TextBox textBox13;
        private ComboBox comboBox14a;
        private Label label14;
        private ComboBox comboBox14;
        private Button button15;
        private TextBox textBox14;
        private ComboBox comboBox15a;
        private Label label15;
        private ComboBox comboBox15;
        private TextBox textBox15;
        private Button button2;
        private ToolTip toolTip1;
        private Button button16;
    }
}
