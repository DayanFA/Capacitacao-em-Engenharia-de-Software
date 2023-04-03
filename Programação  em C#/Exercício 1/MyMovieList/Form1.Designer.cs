namespace WinFormsApp4
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            resultado = new Label();
            salvar = new Button();
            campo_titulo = new TextBox();
            campo_estou = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            campo_nota = new TextBox();
            label5 = new Label();
            dados = new DataGridView();
            conexaoBindingSource = new BindingSource(components);
            carregar = new Button();
            Deletar = new Button();
            atualizar_registro = new Button();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            campo_critica = new RichTextBox();
            label6 = new Label();
            campo_id = new TextBox();
            campo_data = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultado.Location = new Point(650, 7);
            resultado.Name = "resultado";
            resultado.Size = new Size(158, 37);
            resultado.TabIndex = 1;
            resultado.Text = "Minha Lista";
            resultado.Click += resultado_Click;
            // 
            // salvar
            // 
            salvar.BackColor = Color.Purple;
            salvar.FlatStyle = FlatStyle.Popup;
            salvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            salvar.ForeColor = Color.White;
            salvar.Location = new Point(390, 288);
            salvar.Margin = new Padding(3, 2, 3, 2);
            salvar.Name = "salvar";
            salvar.Size = new Size(194, 43);
            salvar.TabIndex = 2;
            salvar.Text = "Enviar";
            salvar.UseVisualStyleBackColor = false;
            salvar.Click += botao2_Click;
            // 
            // campo_titulo
            // 
            campo_titulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_titulo.Location = new Point(141, 62);
            campo_titulo.Margin = new Padding(3, 2, 3, 2);
            campo_titulo.Name = "campo_titulo";
            campo_titulo.Size = new Size(195, 39);
            campo_titulo.TabIndex = 3;
            campo_titulo.TextChanged += campo_id_TextChanged;
            // 
            // campo_estou
            // 
            campo_estou.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_estou.Location = new Point(141, 109);
            campo_estou.Margin = new Padding(3, 2, 3, 2);
            campo_estou.Name = "campo_estou";
            campo_estou.Size = new Size(195, 39);
            campo_estou.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 62);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 5;
            label1.Text = "Título";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 109);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 6;
            label2.Text = "Estou";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 162);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 13;
            label4.Text = "Nota";
            label4.Click += label4_Click_1;
            // 
            // campo_nota
            // 
            campo_nota.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_nota.Location = new Point(141, 162);
            campo_nota.Margin = new Padding(3, 2, 3, 2);
            campo_nota.Name = "campo_nota";
            campo_nota.Size = new Size(195, 39);
            campo_nota.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 208);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 15;
            label5.Text = "Dia Assistido";
            // 
            // dados
            // 
            dados.BackgroundColor = SystemColors.Control;
            dados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dados.GridColor = SystemColors.Control;
            dados.Location = new Point(390, 49);
            dados.Margin = new Padding(3, 2, 3, 2);
            dados.Name = "dados";
            dados.RowHeadersWidth = 51;
            dados.RowTemplate.Height = 18;
            dados.RowTemplate.ReadOnly = true;
            dados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dados.Size = new Size(676, 170);
            dados.TabIndex = 16;
            dados.CellClick += dados_CellClick;
            // 
            // carregar
            // 
            carregar.BackColor = Color.Indigo;
            carregar.FlatStyle = FlatStyle.Popup;
            carregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            carregar.ForeColor = Color.White;
            carregar.Location = new Point(843, 22);
            carregar.Margin = new Padding(3, 2, 3, 2);
            carregar.Name = "carregar";
            carregar.Size = new Size(155, 22);
            carregar.TabIndex = 17;
            carregar.Text = "Atualizar Lista";
            carregar.UseVisualStyleBackColor = false;
            carregar.Click += carregar_Click;
            // 
            // Deletar
            // 
            Deletar.BackColor = Color.Purple;
            Deletar.FlatStyle = FlatStyle.Popup;
            Deletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Deletar.ForeColor = Color.White;
            Deletar.Location = new Point(862, 288);
            Deletar.Margin = new Padding(3, 2, 3, 2);
            Deletar.Name = "Deletar";
            Deletar.Size = new Size(194, 43);
            Deletar.TabIndex = 18;
            Deletar.Text = "Deletar";
            Deletar.UseVisualStyleBackColor = false;
            Deletar.Click += Deletar_Click;
            // 
            // atualizar_registro
            // 
            atualizar_registro.BackColor = Color.Purple;
            atualizar_registro.FlatStyle = FlatStyle.Popup;
            atualizar_registro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            atualizar_registro.ForeColor = Color.White;
            atualizar_registro.Location = new Point(628, 288);
            atualizar_registro.Margin = new Padding(3, 2, 3, 2);
            atualizar_registro.Name = "atualizar_registro";
            atualizar_registro.Size = new Size(194, 43);
            atualizar_registro.TabIndex = 19;
            atualizar_registro.Text = "Editar Existente";
            atualizar_registro.UseVisualStyleBackColor = false;
            atualizar_registro.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 259);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 21;
            label3.Text = "Crítica";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // campo_critica
            // 
            campo_critica.Location = new Point(141, 259);
            campo_critica.Name = "campo_critica";
            campo_critica.Size = new Size(195, 96);
            campo_critica.TabIndex = 25;
            campo_critica.Text = "";
            campo_critica.TextChanged += richTextBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(40, 11);
            label6.Name = "label6";
            label6.Size = new Size(25, 21);
            label6.TabIndex = 29;
            label6.Text = "ID";
            // 
            // campo_id
            // 
            campo_id.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_id.Location = new Point(141, 11);
            campo_id.Margin = new Padding(3, 2, 3, 2);
            campo_id.Name = "campo_id";
            campo_id.Size = new Size(195, 39);
            campo_id.TabIndex = 28;
            // 
            // campo_data
            // 
            campo_data.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_data.Location = new Point(141, 208);
            campo_data.Margin = new Padding(3, 2, 3, 2);
            campo_data.Name = "campo_data";
            campo_data.Size = new Size(195, 39);
            campo_data.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1076, 367);
            Controls.Add(campo_data);
            Controls.Add(label6);
            Controls.Add(campo_id);
            Controls.Add(campo_critica);
            Controls.Add(label3);
            Controls.Add(atualizar_registro);
            Controls.Add(Deletar);
            Controls.Add(carregar);
            Controls.Add(dados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(campo_nota);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(campo_estou);
            Controls.Add(campo_titulo);
            Controls.Add(salvar);
            Controls.Add(resultado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "MyMovieList";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dados).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label resultado;
        private Button salvar;
        private TextBox campo_titulo;
        private TextBox campo_estou;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox campo_nota;
        private Label label5;
        private DataGridView dados;
        private BindingSource conexaoBindingSource;
        private Button carregar;
        private Button Deletar;
        private Button atualizar_registro;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox campo_critica;
        private Label label6;
        private TextBox campo_id;
        private TextBox campo_data;
    }
}