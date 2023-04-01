namespace Calculadora
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
            sete = new Button();
            textBox1 = new TextBox();
            quatro = new Button();
            um = new Button();
            maisoumenos = new Button();
            zero = new Button();
            dois = new Button();
            cinco = new Button();
            oito = new Button();
            virgula = new Button();
            tres = new Button();
            seis = new Button();
            nove = new Button();
            igual = new Button();
            soma = new Button();
            multiplica = new Button();
            subtrai = new Button();
            divide = new Button();
            deleta = new Button();
            SuspendLayout();
            // 
            // sete
            // 
            sete.BackColor = SystemColors.ControlDarkDark;
            sete.FlatStyle = FlatStyle.Popup;
            sete.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            sete.ForeColor = Color.White;
            sete.Location = new Point(15, 100);
            sete.Name = "sete";
            sete.Size = new Size(71, 75);
            sete.TabIndex = 0;
            sete.Text = "7";
            sete.UseVisualStyleBackColor = false;
            sete.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Black", 25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(15, 25);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(450, 55);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // quatro
            // 
            quatro.BackColor = SystemColors.ControlDarkDark;
            quatro.FlatStyle = FlatStyle.Popup;
            quatro.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            quatro.ForeColor = Color.White;
            quatro.Location = new Point(15, 181);
            quatro.Name = "quatro";
            quatro.Size = new Size(71, 75);
            quatro.TabIndex = 2;
            quatro.Text = "4";
            quatro.UseVisualStyleBackColor = false;
            quatro.Click += button2_Click;
            // 
            // um
            // 
            um.BackColor = SystemColors.ControlDarkDark;
            um.FlatStyle = FlatStyle.Popup;
            um.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            um.ForeColor = Color.White;
            um.Location = new Point(15, 262);
            um.Name = "um";
            um.Size = new Size(71, 75);
            um.TabIndex = 3;
            um.Text = "1";
            um.UseVisualStyleBackColor = false;
            um.Click += button3_Click;
            // 
            // maisoumenos
            // 
            maisoumenos.BackColor = SystemColors.ControlDarkDark;
            maisoumenos.FlatStyle = FlatStyle.Popup;
            maisoumenos.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            maisoumenos.ForeColor = Color.White;
            maisoumenos.Location = new Point(15, 343);
            maisoumenos.Name = "maisoumenos";
            maisoumenos.Size = new Size(71, 75);
            maisoumenos.TabIndex = 4;
            maisoumenos.Text = "+/-";
            maisoumenos.UseVisualStyleBackColor = false;
            maisoumenos.Click += button4_Click;
            // 
            // zero
            // 
            zero.BackColor = SystemColors.ControlDarkDark;
            zero.FlatStyle = FlatStyle.Popup;
            zero.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            zero.ForeColor = Color.White;
            zero.Location = new Point(92, 343);
            zero.Name = "zero";
            zero.Size = new Size(71, 75);
            zero.TabIndex = 8;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += button5_Click;
            // 
            // dois
            // 
            dois.BackColor = SystemColors.ControlDarkDark;
            dois.FlatStyle = FlatStyle.Popup;
            dois.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dois.ForeColor = Color.White;
            dois.Location = new Point(92, 262);
            dois.Name = "dois";
            dois.Size = new Size(71, 75);
            dois.TabIndex = 7;
            dois.Text = "2";
            dois.UseVisualStyleBackColor = false;
            dois.Click += button6_Click;
            // 
            // cinco
            // 
            cinco.BackColor = SystemColors.ControlDarkDark;
            cinco.FlatStyle = FlatStyle.Popup;
            cinco.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cinco.ForeColor = Color.White;
            cinco.Location = new Point(92, 181);
            cinco.Name = "cinco";
            cinco.Size = new Size(71, 75);
            cinco.TabIndex = 6;
            cinco.Text = "5";
            cinco.UseVisualStyleBackColor = false;
            cinco.Click += button7_Click;
            // 
            // oito
            // 
            oito.BackColor = SystemColors.ControlDarkDark;
            oito.FlatStyle = FlatStyle.Popup;
            oito.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            oito.ForeColor = Color.White;
            oito.Location = new Point(92, 100);
            oito.Name = "oito";
            oito.Size = new Size(71, 75);
            oito.TabIndex = 5;
            oito.Text = "8";
            oito.UseVisualStyleBackColor = false;
            oito.Click += button8_Click;
            // 
            // virgula
            // 
            virgula.BackColor = SystemColors.ControlDarkDark;
            virgula.FlatStyle = FlatStyle.Popup;
            virgula.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            virgula.ForeColor = Color.White;
            virgula.Location = new Point(169, 343);
            virgula.Name = "virgula";
            virgula.Size = new Size(71, 75);
            virgula.TabIndex = 12;
            virgula.Text = ",";
            virgula.UseVisualStyleBackColor = false;
            virgula.Click += button9_Click;
            // 
            // tres
            // 
            tres.BackColor = SystemColors.ControlDarkDark;
            tres.FlatStyle = FlatStyle.Popup;
            tres.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tres.ForeColor = Color.White;
            tres.Location = new Point(169, 262);
            tres.Name = "tres";
            tres.Size = new Size(71, 75);
            tres.TabIndex = 11;
            tres.Text = "3";
            tres.UseVisualStyleBackColor = false;
            tres.Click += button10_Click;
            // 
            // seis
            // 
            seis.BackColor = SystemColors.ControlDarkDark;
            seis.FlatStyle = FlatStyle.Popup;
            seis.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            seis.ForeColor = Color.White;
            seis.Location = new Point(169, 181);
            seis.Name = "seis";
            seis.Size = new Size(71, 75);
            seis.TabIndex = 10;
            seis.Text = "6";
            seis.UseVisualStyleBackColor = false;
            seis.Click += button11_Click;
            // 
            // nove
            // 
            nove.BackColor = SystemColors.ControlDarkDark;
            nove.FlatStyle = FlatStyle.Popup;
            nove.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nove.ForeColor = Color.White;
            nove.Location = new Point(169, 100);
            nove.Name = "nove";
            nove.Size = new Size(71, 75);
            nove.TabIndex = 9;
            nove.Text = "9";
            nove.UseVisualStyleBackColor = false;
            nove.Click += button12_Click;
            // 
            // igual
            // 
            igual.BackColor = SystemColors.ControlDarkDark;
            igual.FlatStyle = FlatStyle.Popup;
            igual.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            igual.ForeColor = Color.White;
            igual.Location = new Point(316, 343);
            igual.Name = "igual";
            igual.Size = new Size(148, 75);
            igual.TabIndex = 16;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = false;
            igual.Click += button13_Click;
            // 
            // soma
            // 
            soma.BackColor = SystemColors.ControlDarkDark;
            soma.FlatStyle = FlatStyle.Popup;
            soma.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            soma.ForeColor = Color.White;
            soma.Location = new Point(393, 262);
            soma.Name = "soma";
            soma.Size = new Size(71, 75);
            soma.TabIndex = 15;
            soma.Text = "+";
            soma.UseVisualStyleBackColor = false;
            soma.Click += button14_Click;
            // 
            // multiplica
            // 
            multiplica.BackColor = SystemColors.ControlDarkDark;
            multiplica.FlatStyle = FlatStyle.Popup;
            multiplica.Font = new Font("Arial Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            multiplica.ForeColor = Color.White;
            multiplica.Location = new Point(393, 181);
            multiplica.Name = "multiplica";
            multiplica.Size = new Size(71, 75);
            multiplica.TabIndex = 14;
            multiplica.Text = "X";
            multiplica.UseVisualStyleBackColor = false;
            multiplica.Click += button15_Click;
            // 
            // subtrai
            // 
            subtrai.BackColor = SystemColors.ControlDarkDark;
            subtrai.FlatStyle = FlatStyle.Popup;
            subtrai.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            subtrai.ForeColor = Color.White;
            subtrai.Location = new Point(316, 262);
            subtrai.Name = "subtrai";
            subtrai.Size = new Size(71, 75);
            subtrai.TabIndex = 19;
            subtrai.Text = "-";
            subtrai.UseVisualStyleBackColor = false;
            subtrai.Click += button18_Click;
            // 
            // divide
            // 
            divide.BackColor = SystemColors.ControlDarkDark;
            divide.FlatStyle = FlatStyle.Popup;
            divide.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            divide.ForeColor = Color.White;
            divide.Location = new Point(316, 181);
            divide.Name = "divide";
            divide.Size = new Size(71, 75);
            divide.TabIndex = 18;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += button19_Click;
            // 
            // deleta
            // 
            deleta.BackColor = SystemColors.ControlDarkDark;
            deleta.FlatStyle = FlatStyle.Popup;
            deleta.Font = new Font("Arial Black", 20F, FontStyle.Regular, GraphicsUnit.Point);
            deleta.ForeColor = Color.White;
            deleta.Location = new Point(316, 100);
            deleta.Name = "deleta";
            deleta.Size = new Size(148, 75);
            deleta.TabIndex = 17;
            deleta.Text = "AC";
            deleta.UseVisualStyleBackColor = false;
            deleta.Click += button20_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(476, 456);
            Controls.Add(subtrai);
            Controls.Add(divide);
            Controls.Add(deleta);
            Controls.Add(igual);
            Controls.Add(soma);
            Controls.Add(multiplica);
            Controls.Add(virgula);
            Controls.Add(tres);
            Controls.Add(seis);
            Controls.Add(nove);
            Controls.Add(zero);
            Controls.Add(dois);
            Controls.Add(cinco);
            Controls.Add(oito);
            Controls.Add(maisoumenos);
            Controls.Add(um);
            Controls.Add(quatro);
            Controls.Add(textBox1);
            Controls.Add(sete);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sete;
        private TextBox textBox1;
        private Button quatro;
        private Button um;
        private Button maisoumenos;
        private Button zero;
        private Button dois;
        private Button cinco;
        private Button oito;
        private Button virgula;
        private Button tres;
        private Button seis;
        private Button nove;
        private Button igual;
        private Button soma;
        private Button multiplica;
        private Button subtrai;
        private Button divide;
        private Button deleta;
    }
}