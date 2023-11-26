namespace VSORK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            textBox4Månad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox3År = new TextBox();
            textBox2Räntesats = new TextBox();
            label1 = new Label();
            Kapital = new Label();
            textBox1Kapital = new TextBox();
            panel3 = new Panel();
            label7 = new Label();
            buttonDivide = new Button();
            buttonEquals = new Button();
            buttonMultiply = new Button();
            button3 = new Button();
            buttonSubstract = new Button();
            button6 = new Button();
            buttonDecimal = new Button();
            buttonAddition = new Button();
            button2 = new Button();
            button9 = new Button();
            button5 = new Button();
            button0 = new Button();
            button1 = new Button();
            button8 = new Button();
            button4 = new Button();
            buttonC = new Button();
            button7 = new Button();
            buttonCE = new Button();
            buttonBackSpace = new Button();
            txtDisplay = new TextBox();
            panel2 = new Panel();
            label11 = new Label();
            textBox7UtmDag = new TextBox();
            textBox8UtmMån = new TextBox();
            label10 = new Label();
            textBox10VårAndel = new TextBox();
            label6 = new Label();
            label8 = new Label();
            textBox9KassaflödeMån = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox5SaldoVS = new TextBox();
            textBox6VårSaldo = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox4Månad);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3År);
            panel1.Controls.Add(textBox2Räntesats);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Kapital);
            panel1.Controls.Add(textBox1Kapital);
            panel1.Location = new Point(201, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 137);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
            // 
            // textBox4Månad
            // 
            textBox4Månad.BackColor = SystemColors.ControlLight;
            textBox4Månad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4Månad.Location = new Point(85, 98);
            textBox4Månad.Name = "textBox4Månad";
            textBox4Månad.ReadOnly = true;
            textBox4Månad.Size = new Size(100, 29);
            textBox4Månad.TabIndex = 7;
            textBox4Månad.TextAlign = HorizontalAlignment.Right;
            textBox4Månad.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 101);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 6;
            label3.Text = "Månad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 69);
            label2.Name = "label2";
            label2.Size = new Size(26, 21);
            label2.TabIndex = 5;
            label2.Text = "År";
            // 
            // textBox3År
            // 
            textBox3År.BackColor = SystemColors.ControlLight;
            textBox3År.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3År.Location = new Point(85, 66);
            textBox3År.Name = "textBox3År";
            textBox3År.ReadOnly = true;
            textBox3År.Size = new Size(100, 29);
            textBox3År.TabIndex = 4;
            textBox3År.TextAlign = HorizontalAlignment.Right;
            textBox3År.TextChanged += textBox3_TextChanged;
            // 
            // textBox2Räntesats
            // 
            textBox2Räntesats.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2Räntesats.Location = new Point(86, 34);
            textBox2Räntesats.Name = "textBox2Räntesats";
            textBox2Räntesats.Size = new Size(100, 29);
            textBox2Räntesats.TabIndex = 3;
            textBox2Räntesats.TextAlign = HorizontalAlignment.Right;
            textBox2Räntesats.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 37);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 2;
            label1.Text = "Räntesats";
            // 
            // Kapital
            // 
            Kapital.AutoSize = true;
            Kapital.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Kapital.Location = new Point(4, 7);
            Kapital.Name = "Kapital";
            Kapital.Size = new Size(57, 21);
            Kapital.TabIndex = 1;
            Kapital.Text = "Kapital";
            Kapital.Click += label1_Click;
            // 
            // textBox1Kapital
            // 
            textBox1Kapital.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1Kapital.Location = new Point(85, 4);
            textBox1Kapital.Name = "textBox1Kapital";
            textBox1Kapital.Size = new Size(100, 29);
            textBox1Kapital.TabIndex = 0;
            textBox1Kapital.TextAlign = HorizontalAlignment.Right;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(buttonDivide);
            panel3.Controls.Add(buttonEquals);
            panel3.Controls.Add(buttonMultiply);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(buttonSubstract);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(buttonDecimal);
            panel3.Controls.Add(buttonAddition);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button0);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(buttonC);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(buttonCE);
            panel3.Controls.Add(buttonBackSpace);
            panel3.Controls.Add(txtDisplay);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(196, 312);
            panel3.TabIndex = 1;
            panel3.TabStop = true;
            panel3.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(9, 10);
            label7.Name = "label7";
            label7.Size = new Size(68, 30);
            label7.TabIndex = 2;
            label7.Text = "label7";
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivide.Location = new Point(147, 84);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(40, 40);
            buttonDivide.TabIndex = 1;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonCalcDivide_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEquals.Location = new Point(147, 265);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(40, 40);
            buttonEquals.TabIndex = 1;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonCalcEquals_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiply.Location = new Point(147, 129);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(40, 40);
            buttonMultiply.TabIndex = 1;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonCalcMultiply_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(101, 220);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 1;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonCalc3_Click;
            // 
            // buttonSubstract
            // 
            buttonSubstract.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubstract.Location = new Point(147, 175);
            buttonSubstract.Name = "buttonSubstract";
            buttonSubstract.Size = new Size(40, 40);
            buttonSubstract.TabIndex = 1;
            buttonSubstract.Text = "-";
            buttonSubstract.UseVisualStyleBackColor = true;
            buttonSubstract.Click += buttonCalcSubstract_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(101, 175);
            button6.Name = "button6";
            button6.Size = new Size(40, 40);
            button6.TabIndex = 1;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonCalc6_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDecimal.Location = new Point(101, 265);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(40, 40);
            buttonDecimal.TabIndex = 1;
            buttonDecimal.Text = ",";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += buttonCalcDecimal_Click;
            // 
            // buttonAddition
            // 
            buttonAddition.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddition.Location = new Point(147, 220);
            buttonAddition.Name = "buttonAddition";
            buttonAddition.Size = new Size(40, 40);
            buttonAddition.TabIndex = 1;
            buttonAddition.Text = "+";
            buttonAddition.UseVisualStyleBackColor = true;
            buttonAddition.Click += buttonCalcAddition_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(55, 220);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonCalc2_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(101, 129);
            button9.Name = "button9";
            button9.Size = new Size(40, 40);
            button9.TabIndex = 1;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonCalc9_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(55, 175);
            button5.Name = "button5";
            button5.Size = new Size(40, 40);
            button5.TabIndex = 1;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonCalc5_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(9, 265);
            button0.Name = "button0";
            button0.Size = new Size(86, 40);
            button0.TabIndex = 1;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += buttonCalc0_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(9, 220);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCalc1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(55, 129);
            button8.Name = "button8";
            button8.Size = new Size(40, 40);
            button8.TabIndex = 1;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonCalc8_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(9, 175);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 1;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonCalc4_Click;
            // 
            // buttonC
            // 
            buttonC.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonC.Location = new Point(101, 84);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(40, 40);
            buttonC.TabIndex = 1;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonCalcC_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(9, 129);
            button7.Name = "button7";
            button7.Size = new Size(40, 40);
            button7.TabIndex = 1;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonCalc7_Click;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCE.Location = new Point(55, 84);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(40, 40);
            buttonCE.TabIndex = 1;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCalcCE_Click;
            // 
            // buttonBackSpace
            // 
            buttonBackSpace.Font = new Font("Wingdings", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackSpace.Location = new Point(9, 84);
            buttonBackSpace.Name = "buttonBackSpace";
            buttonBackSpace.Size = new Size(40, 40);
            buttonBackSpace.TabIndex = 1;
            buttonBackSpace.Text = "";
            buttonBackSpace.UseVisualStyleBackColor = true;
            buttonBackSpace.Click += buttonCalcBackspace_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay.Location = new Point(9, 43);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(178, 35);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox7UtmDag);
            panel2.Controls.Add(textBox8UtmMån);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox10VårAndel);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox9KassaflödeMån);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox5SaldoVS);
            panel2.Controls.Add(textBox6VårSaldo);
            panel2.Location = new Point(201, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 181);
            panel2.TabIndex = 2;
            panel2.TabStop = true;
            panel2.Paint += panel3_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 93);
            label11.Name = "label11";
            label11.Size = new Size(121, 21);
            label11.TabIndex = 29;
            label11.Text = "Utmätning/mån";
            // 
            // textBox7UtmDag
            // 
            textBox7UtmDag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7UtmDag.Location = new Point(132, 61);
            textBox7UtmDag.Name = "textBox7UtmDag";
            textBox7UtmDag.Size = new Size(55, 29);
            textBox7UtmDag.TabIndex = 28;
            textBox7UtmDag.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox8UtmMån
            // 
            textBox8UtmMån.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8UtmMån.Location = new Point(132, 90);
            textBox8UtmMån.Name = "textBox8UtmMån";
            textBox8UtmMån.Size = new Size(55, 29);
            textBox8UtmMån.TabIndex = 27;
            textBox8UtmMån.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(6, 149);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 24;
            label10.Text = "Vår andel";
            label10.Click += label10_Click;
            // 
            // textBox10VårAndel
            // 
            textBox10VårAndel.BackColor = SystemColors.ControlLight;
            textBox10VårAndel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10VårAndel.Location = new Point(132, 149);
            textBox10VårAndel.Name = "textBox10VårAndel";
            textBox10VårAndel.ReadOnly = true;
            textBox10VårAndel.Size = new Size(55, 29);
            textBox10VårAndel.TabIndex = 23;
            textBox10VårAndel.TextChanged += textBox10VårAndel_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 64);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 14;
            label6.Text = "Utmätning/dag";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 123);
            label8.Name = "label8";
            label8.Size = new Size(121, 21);
            label8.TabIndex = 22;
            label8.Text = "Kassaflöde/mån";
            // 
            // textBox9KassaflödeMån
            // 
            textBox9KassaflödeMån.BackColor = SystemColors.ControlLight;
            textBox9KassaflödeMån.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9KassaflödeMån.Location = new Point(132, 120);
            textBox9KassaflödeMån.Name = "textBox9KassaflödeMån";
            textBox9KassaflödeMån.ReadOnly = true;
            textBox9KassaflödeMån.Size = new Size(55, 29);
            textBox9KassaflödeMån.TabIndex = 21;
            textBox9KassaflödeMån.TextAlign = HorizontalAlignment.Right;
            textBox9KassaflödeMån.TextChanged += textBox10_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 35);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 12;
            label5.Text = "Vår saldo";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 6);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 10;
            label4.Text = "Saldo VS";
            label4.Click += label4_Click;
            // 
            // textBox5SaldoVS
            // 
            textBox5SaldoVS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5SaldoVS.Location = new Point(96, 3);
            textBox5SaldoVS.Name = "textBox5SaldoVS";
            textBox5SaldoVS.Size = new Size(91, 29);
            textBox5SaldoVS.TabIndex = 11;
            textBox5SaldoVS.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox6VårSaldo
            // 
            textBox6VårSaldo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6VårSaldo.Location = new Point(96, 32);
            textBox6VårSaldo.Name = "textBox6VårSaldo";
            textBox6VårSaldo.Size = new Size(91, 29);
            textBox6VårSaldo.TabIndex = 10;
            textBox6VårSaldo.TextAlign = HorizontalAlignment.Right;
            textBox6VårSaldo.TextChanged += textBox6_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(399, 318);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VSORK";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox textBox1Kapital;
        private Label Kapital;
        private Label label3;
        private Label label2;
        private TextBox textBox3År;
        private TextBox textBox2Räntesats;
        private Label label1;
        private TextBox textBox4Månad;
        private TextBox txtDisplay;
        private Panel panel2;
        private Label label4;
        private TextBox textBox5SaldoVS;
        private TextBox textBox6VårSaldo;
        private Label label5;
        private TextBox textBox9;
        private Label label6;
        private TextBox textBox8UtmMån;
        private Label label10;
        private TextBox textBox10VårAndel;
        private Label label8;
        private TextBox textBox9KassaflödeMån;
        private Button buttonBackSpace;
        private Button buttonDivide;
        private Button buttonEquals;
        private Button buttonMultiply;
        private Button button3;
        private Button buttonSubstract;
        private Button button6;
        private Button buttonDecimal;
        private Button buttonAddition;
        private Button button2;
        private Button button9;
        private Button button5;
        private Button button0;
        private Button button1;
        private Button button8;
        private Button button4;
        private Button buttonC;
        private Button button7;
        private Button buttonCE;
        private TextBox textBox7UtmDag;
        private Label label11;
        private Label label7;
    }
}