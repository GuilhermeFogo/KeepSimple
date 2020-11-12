namespace Guilherme
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Incluir = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.campo_data = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campo_custo = new System.Windows.Forms.TextBox();
            this.campo_distancia = new System.Windows.Forms.TextBox();
            this.campoCaptura = new System.Windows.Forms.GroupBox();
            this.nao = new System.Windows.Forms.RadioButton();
            this.sim = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.listaVoo = new System.Windows.Forms.ListView();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.Custo = new System.Windows.Forms.ColumnHeader();
            this.Distancia = new System.Windows.Forms.ColumnHeader();
            this.Captura = new System.Windows.Forms.ColumnHeader();
            this.NivelDor = new System.Windows.Forms.ColumnHeader();
            this.ID_VOO = new System.Windows.Forms.ColumnHeader();
            this.Salvar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.campo_nivelDor = new System.Windows.Forms.ComboBox();
            this.campoCaptura.SuspendLayout();
            this.SuspendLayout();
            // 
            // Incluir
            // 
            this.Incluir.Location = new System.Drawing.Point(575, 12);
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(75, 23);
            this.Incluir.TabIndex = 0;
            this.Incluir.Text = "incluir";
            this.Incluir.UseVisualStyleBackColor = true;
            this.Incluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(703, 13);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 1;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // campo_data
            // 
            this.campo_data.Location = new System.Drawing.Point(647, 73);
            this.campo_data.Name = "campo_data";
            this.campo_data.Size = new System.Drawing.Size(200, 23);
            this.campo_data.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Custo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distancia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Captura";
            // 
            // campo_custo
            // 
            this.campo_custo.Location = new System.Drawing.Point(669, 115);
            this.campo_custo.Name = "campo_custo";
            this.campo_custo.Size = new System.Drawing.Size(178, 23);
            this.campo_custo.TabIndex = 5;
            this.campo_custo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CampoCusto_KeyPress);
            // 
            // campo_distancia
            // 
            this.campo_distancia.Location = new System.Drawing.Point(671, 173);
            this.campo_distancia.Name = "campo_distancia";
            this.campo_distancia.Size = new System.Drawing.Size(178, 23);
            this.campo_distancia.TabIndex = 5;
            this.campo_distancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CampoDistancia_KeyPress);
            // 
            // campoCaptura
            // 
            this.campoCaptura.Controls.Add(this.nao);
            this.campoCaptura.Controls.Add(this.sim);
            this.campoCaptura.Location = new System.Drawing.Point(671, 225);
            this.campoCaptura.Name = "campoCaptura";
            this.campoCaptura.Size = new System.Drawing.Size(211, 42);
            this.campoCaptura.TabIndex = 6;
            this.campoCaptura.TabStop = false;
            // 
            // nao
            // 
            this.nao.AutoSize = true;
            this.nao.Location = new System.Drawing.Point(125, 12);
            this.nao.Name = "nao";
            this.nao.Size = new System.Drawing.Size(47, 19);
            this.nao.TabIndex = 1;
            this.nao.TabStop = true;
            this.nao.Tag = "Nao";
            this.nao.Text = "Não";
            this.nao.UseVisualStyleBackColor = true;
            this.nao.CheckedChanged += new System.EventHandler(this.nao_CheckedChanged);
            // 
            // sim
            // 
            this.sim.AutoSize = true;
            this.sim.Location = new System.Drawing.Point(7, 13);
            this.sim.Name = "sim";
            this.sim.Size = new System.Drawing.Size(45, 19);
            this.sim.TabIndex = 0;
            this.sim.TabStop = true;
            this.sim.Tag = "Sim";
            this.sim.Text = "Sim";
            this.sim.UseVisualStyleBackColor = true;
            this.sim.CheckedChanged += new System.EventHandler(this.sim_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nivel Dor";
            // 
            // listaVoo
            // 
            this.listaVoo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.Custo,
            this.Distancia,
            this.Captura,
            this.NivelDor,
            this.ID_VOO});
            this.listaVoo.HideSelection = false;
            this.listaVoo.Location = new System.Drawing.Point(47, 57);
            this.listaVoo.Name = "listaVoo";
            this.listaVoo.Size = new System.Drawing.Size(498, 484);
            this.listaVoo.TabIndex = 7;
            this.listaVoo.UseCompatibleStateImageBehavior = false;
            this.listaVoo.View = System.Windows.Forms.View.Details;
            this.listaVoo.SelectedIndexChanged += new System.EventHandler(this.listaVoo_SelectedIndexChanged);
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 100;
            // 
            // Custo
            // 
            this.Custo.Text = "Custo";
            this.Custo.Width = 100;
            // 
            // Distancia
            // 
            this.Distancia.Text = "Distancia";
            this.Distancia.Width = 100;
            // 
            // Captura
            // 
            this.Captura.Text = "Captura";
            this.Captura.Width = 100;
            // 
            // NivelDor
            // 
            this.NivelDor.Text = "Nivel de dor";
            this.NivelDor.Width = 110;
            // 
            // ID_VOO
            // 
            this.ID_VOO.Text = "id";
            // 
            // Salvar
            // 
            this.Salvar.Enabled = false;
            this.Salvar.Location = new System.Drawing.Point(647, 353);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 8;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Enabled = false;
            this.Cancelar.Location = new System.Drawing.Point(779, 352);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 9;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // campo_nivelDor
            // 
            this.campo_nivelDor.AllowDrop = true;
            this.campo_nivelDor.FormattingEnabled = true;
            this.campo_nivelDor.Location = new System.Drawing.Point(673, 282);
            this.campo_nivelDor.Name = "campo_nivelDor";
            this.campo_nivelDor.Size = new System.Drawing.Size(174, 23);
            this.campo_nivelDor.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 572);
            this.Controls.Add(this.campo_nivelDor);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.listaVoo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoCaptura);
            this.Controls.Add(this.campo_distancia);
            this.Controls.Add(this.campo_custo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campo_data);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Incluir);
            this.Name = "Form1";
            this.Text = "Captura";
            this.campoCaptura.ResumeLayout(false);
            this.campoCaptura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Incluir;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.DateTimePicker campo_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campo_custo;
        private System.Windows.Forms.TextBox campo_distancia;
        private System.Windows.Forms.GroupBox campoCaptura;
        private System.Windows.Forms.RadioButton nao;
        private System.Windows.Forms.RadioButton sim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listaVoo;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ComboBox campo_nivelDor;
        private System.Windows.Forms.ColumnHeader data_voo;
        private System.Windows.Forms.ColumnHeader Custo;
        private System.Windows.Forms.ColumnHeader Distancia;
        private System.Windows.Forms.ColumnHeader Captura;
        private System.Windows.Forms.ColumnHeader Nivel_dor;
        private System.Windows.Forms.ColumnHeader nivelDor;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader NivelDor;
        private System.Windows.Forms.ColumnHeader ID_VOO;
    }
}

