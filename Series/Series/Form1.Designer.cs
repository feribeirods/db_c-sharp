
namespace Series
{
    partial class formseries
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTemporadas = new System.Windows.Forms.TextBox();
            this.tbAssistir = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.limpar = new System.Windows.Forms.Button();
            this.dgSeries = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSeries)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temporadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Onde assistir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(741, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gênero";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(63, 11);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(202, 22);
            this.tbNome.TabIndex = 6;
            // 
            // tbTemporadas
            // 
            this.tbTemporadas.Location = new System.Drawing.Point(365, 11);
            this.tbTemporadas.Name = "tbTemporadas";
            this.tbTemporadas.Size = new System.Drawing.Size(39, 22);
            this.tbTemporadas.TabIndex = 7;
            // 
            // tbAssistir
            // 
            this.tbAssistir.Location = new System.Drawing.Point(507, 11);
            this.tbAssistir.Name = "tbAssistir";
            this.tbAssistir.Size = new System.Drawing.Size(128, 22);
            this.tbAssistir.TabIndex = 8;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(680, 11);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(55, 22);
            this.tbAno.TabIndex = 9;
            // 
            // tbGenero
            // 
            this.tbGenero.Location = new System.Drawing.Point(803, 11);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(163, 22);
            this.tbGenero.TabIndex = 10;
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(15, 55);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(94, 44);
            this.limpar.TabIndex = 11;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // dgSeries
            // 
            this.dgSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.temporadas,
            this.assistir,
            this.ano,
            this.genero});
            this.dgSeries.Location = new System.Drawing.Point(15, 180);
            this.dgSeries.Name = "dgSeries";
            this.dgSeries.RowHeadersWidth = 51;
            this.dgSeries.RowTemplate.Height = 24;
            this.dgSeries.Size = new System.Drawing.Size(951, 380);
            this.dgSeries.TabIndex = 12;
            this.dgSeries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // temporadas
            // 
            this.temporadas.HeaderText = "Temporadas";
            this.temporadas.MinimumWidth = 6;
            this.temporadas.Name = "temporadas";
            this.temporadas.Width = 50;
            // 
            // assistir
            // 
            this.assistir.HeaderText = "Onde Assistir";
            this.assistir.MinimumWidth = 6;
            this.assistir.Name = "assistir";
            this.assistir.Width = 150;
            // 
            // ano
            // 
            this.ano.HeaderText = "Ano";
            this.ano.MinimumWidth = 6;
            this.ano.Name = "ano";
            this.ano.Width = 50;
            // 
            // genero
            // 
            this.genero.HeaderText = "Gênero";
            this.genero.MinimumWidth = 6;
            this.genero.Name = "genero";
            this.genero.Width = 150;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(128, 55);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(94, 44);
            this.salvar.TabIndex = 13;
            this.salvar.Text = "Salvar";
            this.salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // formseries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 572);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.dgSeries);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.tbGenero);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbAssistir);
            this.Controls.Add(this.tbTemporadas);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "formseries";
            this.Text = "Séries";
            this.Load += new System.EventHandler(this.formseries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbTemporadas;
        private System.Windows.Forms.TextBox tbAssistir;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.DataGridView dgSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.Button salvar;
    }
}

