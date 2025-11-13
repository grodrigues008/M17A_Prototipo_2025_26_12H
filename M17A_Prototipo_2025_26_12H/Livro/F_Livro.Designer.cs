namespace M17A_Prototipo_2025_26_12H.Livro
{
    partial class F_Livro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_procurar = new System.Windows.Forms.Button();
            this.pb_capa = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_autor = new System.Windows.Forms.TextBox();
            this.tb_editora = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_capa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_procurar
            // 
            this.bt_procurar.Location = new System.Drawing.Point(99, 477);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(204, 23);
            this.bt_procurar.TabIndex = 27;
            this.bt_procurar.Text = "Procurar";
            this.toolTip1.SetToolTip(this.bt_procurar, "Procurar o ficheiro para a capa do livro\r\n");
            this.bt_procurar.UseVisualStyleBackColor = true;
            this.bt_procurar.Click += new System.EventHandler(this.bt_procurar_Click);
            // 
            // pb_capa
            // 
            this.pb_capa.Location = new System.Drawing.Point(99, 341);
            this.pb_capa.Name = "pb_capa";
            this.pb_capa.Size = new System.Drawing.Size(204, 119);
            this.pb_capa.TabIndex = 26;
            this.pb_capa.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Capa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 510);
            this.dataGridView1.TabIndex = 24;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(99, 255);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(204, 20);
            this.tb_preco.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ano Publicação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Editora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Autor";
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(99, 80);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(204, 20);
            this.tb_autor.TabIndex = 18;
            // 
            // tb_editora
            // 
            this.tb_editora.Location = new System.Drawing.Point(99, 119);
            this.tb_editora.Name = "tb_editora";
            this.tb_editora.Size = new System.Drawing.Size(204, 20);
            this.tb_editora.TabIndex = 17;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(99, 168);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(204, 20);
            this.tb_ano.TabIndex = 16;
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(99, 38);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(204, 20);
            this.tb_titulo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Título";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ISBN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(99, 293);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(204, 20);
            this.tb_isbn.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Data Aquisição";
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(99, 216);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(204, 20);
            this.dtp_data.TabIndex = 32;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(99, 509);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(204, 39);
            this.bt_guardar.TabIndex = 33;
            this.bt_guardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.bt_guardar, "Guarda os dados na base de dados");
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // F_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 574);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_procurar);
            this.Controls.Add(this.pb_capa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_autor);
            this.Controls.Add(this.tb_editora);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_titulo);
            this.Controls.Add(this.label1);
            this.Name = "F_Livro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_capa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.PictureBox pb_capa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_autor;
        private System.Windows.Forms.TextBox tb_editora;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}