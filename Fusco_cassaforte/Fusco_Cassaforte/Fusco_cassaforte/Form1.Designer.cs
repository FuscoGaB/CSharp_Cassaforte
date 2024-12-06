namespace Fusco_cassaforte
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
            label1 = new Label();
            testoCodice = new TextBox();
            label2 = new Label();
            accessoCodice = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 42);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Inserisci codice utente";
            // 
            // testoCodice
            // 
            testoCodice.Location = new Point(40, 62);
            testoCodice.Name = "testoCodice";
            testoCodice.Size = new Size(122, 23);
            testoCodice.TabIndex = 1;
            testoCodice.TextChanged += testoCodice_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 136);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 2;
            label2.Text = "Codice sicurezza cassaforte";
            // 
            // accessoCodice
            // 
            accessoCodice.Location = new Point(38, 154);
            accessoCodice.Name = "accessoCodice";
            accessoCodice.Size = new Size(150, 23);
            accessoCodice.TabIndex = 3;
            accessoCodice.TextChanged += accessoCodice_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(179, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "conferma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(203, 154);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Apri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(400, 100);
            button3.Name = "button3";
            button3.Size = new Size(174, 109);
            button3.TabIndex = 6;
            button3.Text = "cassaforte";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 147);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 8;
            label3.Text = "soldi";
            // 
            // button4
            // 
            button4.Location = new Point(203, 186);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Chiudi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 13);
            label4.Name = "label4";
            label4.Size = new Size(208, 15);
            label4.TabIndex = 10;
            label4.Text = "Codice alfanumerico di apertura cassa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(402, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.Location = new Point(632, 33);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Apri";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 60);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 13;
            label5.Text = "Password: a1b2c3d4e5f6";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(accessoCodice);
            Controls.Add(label2);
            Controls.Add(testoCodice);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox testoCodice;
        private Label label2;
        private TextBox accessoCodice;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Label label4;
        private TextBox textBox1;
        private Button button5;
        private Label label5;
    }
}
