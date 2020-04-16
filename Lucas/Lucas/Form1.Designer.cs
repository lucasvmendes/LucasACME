namespace Lucas
{
    partial class Form1
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
            this.lblACMEFlightManager = new System.Windows.Forms.Label();
            this.listViewDados = new System.Windows.Forms.ListView();
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Captura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NivelDeDor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDataVoo = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCaptura = new System.Windows.Forms.Label();
            this.lblNivelDor = new System.Windows.Forms.Label();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.dtDataVoo = new System.Windows.Forms.DateTimePicker();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtNivelDor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtNivelDor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblACMEFlightManager
            // 
            this.lblACMEFlightManager.AutoSize = true;
            this.lblACMEFlightManager.Location = new System.Drawing.Point(13, 13);
            this.lblACMEFlightManager.Name = "lblACMEFlightManager";
            this.lblACMEFlightManager.Size = new System.Drawing.Size(135, 13);
            this.lblACMEFlightManager.TabIndex = 0;
            this.lblACMEFlightManager.Text = "ACME FLIGHT MANAGER";
            // 
            // listViewDados
            // 
            this.listViewDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.Captura,
            this.NivelDeDor});
            this.listViewDados.HideSelection = false;
            this.listViewDados.Location = new System.Drawing.Point(16, 52);
            this.listViewDados.Name = "listViewDados";
            this.listViewDados.Size = new System.Drawing.Size(371, 371);
            this.listViewDados.TabIndex = 1;
            this.listViewDados.UseCompatibleStateImageBehavior = false;
            this.listViewDados.View = System.Windows.Forms.View.Details;
            this.listViewDados.Click += new System.EventHandler(this.listViewDados_Click);
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 109;
            // 
            // Captura
            // 
            this.Captura.Text = "Captura";
            this.Captura.Width = 98;
            // 
            // NivelDeDor
            // 
            this.NivelDeDor.Text = "Nivel de dor";
            this.NivelDeDor.Width = 158;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(476, 52);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(607, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(476, 338);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(607, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDataVoo
            // 
            this.lblDataVoo.AutoSize = true;
            this.lblDataVoo.Location = new System.Drawing.Point(479, 106);
            this.lblDataVoo.Name = "lblDataVoo";
            this.lblDataVoo.Size = new System.Drawing.Size(30, 13);
            this.lblDataVoo.TabIndex = 6;
            this.lblDataVoo.Text = "Data";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(479, 145);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(34, 13);
            this.lblCusto.TabIndex = 7;
            this.lblCusto.Text = "Custo";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(479, 189);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 8;
            this.lblDistancia.Text = "Distancia";
            // 
            // lblCaptura
            // 
            this.lblCaptura.AutoSize = true;
            this.lblCaptura.Location = new System.Drawing.Point(479, 235);
            this.lblCaptura.Name = "lblCaptura";
            this.lblCaptura.Size = new System.Drawing.Size(44, 13);
            this.lblCaptura.TabIndex = 9;
            this.lblCaptura.Text = "Captura";
            // 
            // lblNivelDor
            // 
            this.lblNivelDor.AutoSize = true;
            this.lblNivelDor.Location = new System.Drawing.Point(479, 282);
            this.lblNivelDor.Name = "lblNivelDor";
            this.lblNivelDor.Size = new System.Drawing.Size(49, 13);
            this.lblNivelDor.TabIndex = 10;
            this.lblNivelDor.Text = "Nivel dor";
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Enabled = false;
            this.rdbNao.Location = new System.Drawing.Point(589, 235);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(45, 17);
            this.rdbNao.TabIndex = 15;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Nao";
            this.rdbNao.UseVisualStyleBackColor = true;
            this.rdbNao.CheckedChanged += new System.EventHandler(this.rdbNao_CheckedChanged);
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Enabled = false;
            this.rdbSim.Location = new System.Drawing.Point(647, 235);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(42, 17);
            this.rdbSim.TabIndex = 16;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            this.rdbSim.CheckedChanged += new System.EventHandler(this.rdbSim_CheckedChanged);
            // 
            // txtCusto
            // 
            this.txtCusto.Enabled = false;
            this.txtCusto.Location = new System.Drawing.Point(589, 145);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(100, 20);
            this.txtCusto.TabIndex = 12;
            this.txtCusto.TextChanged += new System.EventHandler(this.txtCusto_TextChanged);
            // 
            // dtDataVoo
            // 
            this.dtDataVoo.Enabled = false;
            this.dtDataVoo.Location = new System.Drawing.Point(588, 106);
            this.dtDataVoo.Name = "dtDataVoo";
            this.dtDataVoo.Size = new System.Drawing.Size(200, 20);
            this.dtDataVoo.TabIndex = 17;
            this.dtDataVoo.ValueChanged += new System.EventHandler(this.dtDataVoo_ValueChanged);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Enabled = false;
            this.txtDistancia.Location = new System.Drawing.Point(589, 189);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 13;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            // 
            // txtNivelDor
            // 
            this.txtNivelDor.Enabled = false;
            this.txtNivelDor.Location = new System.Drawing.Point(588, 282);
            this.txtNivelDor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNivelDor.Name = "txtNivelDor";
            this.txtNivelDor.Size = new System.Drawing.Size(120, 20);
            this.txtNivelDor.TabIndex = 18;
            this.txtNivelDor.ValueChanged += new System.EventHandler(this.txtNivelDor_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNivelDor);
            this.Controls.Add(this.dtDataVoo);
            this.Controls.Add(this.rdbSim);
            this.Controls.Add(this.rdbNao);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.lblNivelDor);
            this.Controls.Add(this.lblCaptura);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.lblDataVoo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.listViewDados);
            this.Controls.Add(this.lblACMEFlightManager);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtNivelDor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblACMEFlightManager;
        private System.Windows.Forms.ListView listViewDados;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Captura;
        private System.Windows.Forms.ColumnHeader NivelDeDor;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDataVoo;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblCaptura;
        private System.Windows.Forms.Label lblNivelDor;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.DateTimePicker dtDataVoo;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.NumericUpDown txtNivelDor;
    }
}

