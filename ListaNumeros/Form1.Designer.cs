namespace ListaNumeros
{
    partial class FormUnico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMultiplo = new System.Windows.Forms.TextBox();
            this.rdbMultiplo = new System.Windows.Forms.RadioButton();
            this.rdbImpares = new System.Windows.Forms.RadioButton();
            this.rdbPares = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb01 = new System.Windows.Forms.RadioButton();
            this.rdb05 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb15 = new System.Windows.Forms.RadioButton();
            this.rdb20 = new System.Windows.Forms.RadioButton();
            this.rdb25 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbLista
            // 
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.Location = new System.Drawing.Point(12, 162);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(634, 225);
            this.ltbLista.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(12, 127);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(200, 29);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar Números";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMultiplo);
            this.groupBox1.Controls.Add(this.rdbMultiplo);
            this.groupBox1.Controls.Add(this.rdbImpares);
            this.groupBox1.Controls.Add(this.rdbPares);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Número";
            // 
            // txbMultiplo
            // 
            this.txbMultiplo.Location = new System.Drawing.Point(125, 68);
            this.txbMultiplo.Name = "txbMultiplo";
            this.txbMultiplo.Size = new System.Drawing.Size(58, 20);
            this.txbMultiplo.TabIndex = 3;
            this.txbMultiplo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbMultiplo.Visible = false;
            this.txbMultiplo.TextChanged += new System.EventHandler(this.txbMultiplo_TextChanged);
            // 
            // rdbMultiplo
            // 
            this.rdbMultiplo.AutoSize = true;
            this.rdbMultiplo.Location = new System.Drawing.Point(7, 68);
            this.rdbMultiplo.Name = "rdbMultiplo";
            this.rdbMultiplo.Size = new System.Drawing.Size(111, 17);
            this.rdbMultiplo.TabIndex = 2;
            this.rdbMultiplo.TabStop = true;
            this.rdbMultiplo.Text = "Números Múltiplos";
            this.rdbMultiplo.UseVisualStyleBackColor = true;
            this.rdbMultiplo.CheckedChanged += new System.EventHandler(this.rdbMultiplo_CheckedChanged);
            // 
            // rdbImpares
            // 
            this.rdbImpares.AutoSize = true;
            this.rdbImpares.Location = new System.Drawing.Point(7, 44);
            this.rdbImpares.Name = "rdbImpares";
            this.rdbImpares.Size = new System.Drawing.Size(107, 17);
            this.rdbImpares.TabIndex = 1;
            this.rdbImpares.TabStop = true;
            this.rdbImpares.Text = "Números Ímpares";
            this.rdbImpares.UseVisualStyleBackColor = true;
            this.rdbImpares.CheckedChanged += new System.EventHandler(this.rdbImpares_CheckedChanged);
            // 
            // rdbPares
            // 
            this.rdbPares.AutoSize = true;
            this.rdbPares.Location = new System.Drawing.Point(7, 20);
            this.rdbPares.Name = "rdbPares";
            this.rdbPares.Size = new System.Drawing.Size(97, 17);
            this.rdbPares.TabIndex = 0;
            this.rdbPares.TabStop = true;
            this.rdbPares.Text = "Números Pares";
            this.rdbPares.UseVisualStyleBackColor = true;
            this.rdbPares.CheckedChanged += new System.EventHandler(this.rdbPares_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(218, 127);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(205, 29);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSair.Location = new System.Drawing.Point(429, 127);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(217, 29);
            this.bntSair.TabIndex = 4;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb25);
            this.groupBox2.Controls.Add(this.rdb20);
            this.groupBox2.Controls.Add(this.rdb15);
            this.groupBox2.Controls.Add(this.rdb10);
            this.groupBox2.Controls.Add(this.rdb05);
            this.groupBox2.Controls.Add(this.rdb01);
            this.groupBox2.Location = new System.Drawing.Point(223, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantidades de números mostrados em cada linha";
            // 
            // rdb01
            // 
            this.rdb01.AutoSize = true;
            this.rdb01.Location = new System.Drawing.Point(7, 20);
            this.rdb01.Name = "rdb01";
            this.rdb01.Size = new System.Drawing.Size(112, 17);
            this.rdb01.TabIndex = 0;
            this.rdb01.TabStop = true;
            this.rdb01.Text = "1 número por linha";
            this.rdb01.UseVisualStyleBackColor = true;
            // 
            // rdb05
            // 
            this.rdb05.AutoSize = true;
            this.rdb05.Location = new System.Drawing.Point(6, 44);
            this.rdb05.Name = "rdb05";
            this.rdb05.Size = new System.Drawing.Size(112, 17);
            this.rdb05.TabIndex = 1;
            this.rdb05.TabStop = true;
            this.rdb05.Text = "5 número por linha";
            this.rdb05.UseVisualStyleBackColor = true;
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(6, 67);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(118, 17);
            this.rdb10.TabIndex = 2;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "10 número por linha";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb15
            // 
            this.rdb15.AutoSize = true;
            this.rdb15.Location = new System.Drawing.Point(148, 20);
            this.rdb15.Name = "rdb15";
            this.rdb15.Size = new System.Drawing.Size(118, 17);
            this.rdb15.TabIndex = 3;
            this.rdb15.TabStop = true;
            this.rdb15.Text = "15 número por linha";
            this.rdb15.UseVisualStyleBackColor = true;
            // 
            // rdb20
            // 
            this.rdb20.AutoSize = true;
            this.rdb20.Location = new System.Drawing.Point(148, 44);
            this.rdb20.Name = "rdb20";
            this.rdb20.Size = new System.Drawing.Size(118, 17);
            this.rdb20.TabIndex = 4;
            this.rdb20.TabStop = true;
            this.rdb20.Text = "20 número por linha";
            this.rdb20.UseVisualStyleBackColor = true;
            // 
            // rdb25
            // 
            this.rdb25.AutoSize = true;
            this.rdb25.Location = new System.Drawing.Point(148, 67);
            this.rdb25.Name = "rdb25";
            this.rdb25.Size = new System.Drawing.Size(118, 17);
            this.rdb25.TabIndex = 5;
            this.rdb25.TabStop = true;
            this.rdb25.Text = "25 número por linha";
            this.rdb25.UseVisualStyleBackColor = true;
            // 
            // FormUnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.ltbLista);
            this.Name = "FormUnico";
            this.Text = "Listagem de Números";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbLista;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMultiplo;
        private System.Windows.Forms.RadioButton rdbMultiplo;
        private System.Windows.Forms.RadioButton rdbImpares;
        private System.Windows.Forms.RadioButton rdbPares;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb25;
        private System.Windows.Forms.RadioButton rdb20;
        private System.Windows.Forms.RadioButton rdb15;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb05;
        private System.Windows.Forms.RadioButton rdb01;
    }
}

