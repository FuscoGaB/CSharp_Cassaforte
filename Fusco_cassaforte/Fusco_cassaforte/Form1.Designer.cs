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
            button2.Text = "Conferma";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
