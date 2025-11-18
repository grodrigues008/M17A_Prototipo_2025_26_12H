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
            this.dgv_livros = new System.Windows.Forms.DataGridView();
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
            this.lb_feedback = new System.Windows.Forms.Label();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_capa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_procurar
            // 
            this.bt_procurar.Location = new System.Drawing.Point(160, 471);
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
            this.pb_capa.Location = new System.Drawing.Point(160, 335);
            this.pb_capa.Name = "pb_capa";
            this.pb_capa.Size = new System.Drawing.Size(204, 119);
            this.pb_capa.TabIndex = 26;
            this.pb_capa.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Capa";
            // 
            // dgv_livros
            // 
            this.dgv_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livros.Location = new System.Drawing.Point(415, 53);
            this.dgv_livros.Name = "dgv_livros";
            this.dgv_livros.Size = new System.Drawing.Size(656, 380);
            this.dgv_livros.TabIndex = 24;
            this.dgv_livros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_livros_CellClick);
            this.dgv_livros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_livros_CellContentClick);
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(160, 249);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(204, 20);
            this.tb_preco.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ano Publicação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Editora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Autor";
            // 
            // tb_autor
            // 
            this.tb_autor.Location = new System.Drawing.Point(160, 74);
            this.tb_autor.Name = "tb_autor";
            this.tb_autor.Size = new System.Drawing.Size(204, 20);
            this.tb_autor.TabIndex = 18;
            // 
            // tb_editora
            // 
            this.tb_editora.Location = new System.Drawing.Point(160, 113);
            this.tb_editora.Name = "tb_editora";
            this.tb_editora.Size = new System.Drawing.Size(204, 20);
            this.tb_editora.TabIndex = 17;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(160, 162);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(204, 20);
            this.tb_ano.TabIndex = 16;
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(160, 32);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(204, 20);
            this.tb_titulo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Título";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "ISBN";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(160, 287);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(204, 20);
            this.tb_isbn.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Data Aquisição";
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(160, 210);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(204, 20);
            this.dtp_data.TabIndex = 32;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(160, 503);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(204, 39);
            this.bt_guardar.TabIndex = 33;
            this.bt_guardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.bt_guardar, "Guarda os dados na base de dados");
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // lb_feedback
            // 
            this.lb_feedback.AutoSize = true;
            this.lb_feedback.Location = new System.Drawing.Point(101, 541);
            this.lb_feedback.Name = "lb_feedback";
            this.lb_feedback.Size = new System.Drawing.Size(0, 13);
            this.lb_feedback.TabIndex = 34;
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(415, 27);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(656, 20);
            this.tb_pesquisa.TabIndex = 35;
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(445, 455);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(141, 79);
            this.bt_editar.TabIndex = 36;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(640, 455);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(141, 79);
            this.bt_eliminar.TabIndex = 37;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Location = new System.Drawing.Point(834, 455);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(141, 79);
            this.bt_imprimir.TabIndex = 38;
            this.bt_imprimir.Text = "Imprimir";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 63);
            this.button1.TabIndex = 39;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Livro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.tb_pesquisa);
            this.Controls.Add(this.lb_feedback);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_procurar);
            this.Controls.Add(this.pb_capa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_livros);
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
            this.Load += new System.EventHandler(this.F_Livro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_capa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.PictureBox pb_capa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_livros;
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
        private System.Windows.Forms.Label lb_feedback;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button button1;
    }
}