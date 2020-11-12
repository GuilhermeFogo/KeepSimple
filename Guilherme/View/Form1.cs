using ConfiguracaoAplication;
using ConfiguracaoAplication.interfaces;
using Guilherme.Helpers;
using Guilherme.Modal;
using Guilherme.Repository;
using Guilherme.Repository.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guilherme
{
    public partial class Form1 : Form
    {
        private HelperCampos helper;
        private IConfiguracao configuracao;
        private IRepositoryVoo db;
        private string id;
        public Form1()
        {
            InitializeComponent();
            PreencherNivelDor();
            this.configuracao = new Configuracao();
            db = new RepositoryVoo(this.configuracao);
            this.id = "";
            PopulandoListView();
        }

        private void Incluir_Click(object sender, EventArgs e)
        {
            this.Salvar.Enabled = true;
            this.Cancelar.Enabled = true;

            this.helper = new HelperCampos(this.campo_data.Value, this.campo_custo.Text, this.campo_distancia.Text,
                this.campoCaptura.Text, this.campo_nivelDor.Text);
            if (this.Validacao_campos())
            {
                var custo = this.helper.Custo();
                var distancia = this.helper.Distancia();
                var nivelDor = this.helper.NivelDor();
                var ids = this.helper.id(this.id);
                var voo = new Voo(ids, this.campo_data.Value, custo, distancia, this.campoCaptura.Text, nivelDor);

                db.Deletar(voo);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            this.helper = new HelperCampos(this.campo_data.Value, this.campo_custo.Text, this.campo_distancia.Text,
                this.campoCaptura.Text, this.campo_nivelDor.Text);
            if (this.Validacao_campos())
            {
                var custo = this.helper.Custo();
                var distancia = this.helper.Distancia();
                var nivelDor = this.helper.NivelDor();
                var ids = this.helper.id(this.id);
                var voo = new Voo(ids, this.campo_data.Value, custo, distancia, this.campoCaptura.Text, nivelDor);

                db.Deletar(voo);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            this.Salvar.Enabled = false;
            this.Cancelar.Enabled = false;

            this.helper = new HelperCampos(this.campo_data.Value, this.campo_custo.Text, this.campo_distancia.Text,
                this.campoCaptura.Text, this.campo_nivelDor.Text);
            if (this.Validacao_campos())
            {
                var custo = this.helper.Custo();
                var distancia = this.helper.Distancia();
                var nivelDor = this.helper.NivelDor();

                if (string.IsNullOrEmpty(this.id))
                {
                    var ids = this.helper.id(this.id);
                    if (db.existID(ids)){
                        var voo = db.ListarUmVoo(ids);
                        db.EditarVoo(voo);
                    }

                }
                else
                {
                    var voo = new Voo(0, this.campo_data.Value, custo, distancia, this.campoCaptura.Text, nivelDor);
                    db.Salvar(voo);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.limparCampos();
            this.Salvar.Enabled = false;
            this.Cancelar.Enabled = false;
        }


        private bool Validacao_campos()
        {
            var validacaoCusto = helper.ValidacaoCusto();
            var validacaoDistancia = helper.ValidacaoDistancia();
            var validacaoNivel = helper.ValidacaoDor();
            return validacaoCusto && validacaoDistancia && validacaoNivel;
        }


        private void PreencherNivelDor()
        {
            for (int i = 0; i < 10; i++)
            {
                this.campo_nivelDor.Items.Add(i);
            }
        }


        private void CampoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }


        private void CampoDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
        }


        private void limparCampos()
        {
            this.campo_custo.Clear();
            this.campo_distancia.Clear();
            this.campo_nivelDor.SelectedItem = 0;
            this.campo_data.Value = DateTime.Now;
        }



        private void PopulandoListView()
        {
            var datatable = this.db.ListarTudo();

            // exibe os itens no controle ListView 
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                DataRow drow = datatable.Rows[i];

                // Somente as linhas que não foram deletadas
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(drow["Data"].ToString());
                    lvi.SubItems.Add(drow["Custo"].ToString());
                    lvi.SubItems.Add(drow["Distancia"].ToString());
                    lvi.SubItems.Add(drow["Captura"].ToString());
                    lvi.SubItems.Add(drow["NivelDor"].ToString());
                    lvi.SubItems.Add(drow["ID_VOO"].ToString());

                    // Inclui os itens no ListView
                    listaVoo.Items.Add(lvi);
                }
            }
        }





        private void sim_CheckedChanged(object sender, EventArgs e)
        {
            this.campoCaptura.Text = "s";
        }

        private void nao_CheckedChanged(object sender, EventArgs e)
        {
            this.campoCaptura.Text = "n";
        }

        private void listaVoo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaVoo.SelectedItems.Count > 0)
            {
                ObtendoValores();
            }
        }

        private void ObtendoValores()
        {
            this.campo_data.Text = listaVoo.Items[0].SubItems[0].Text;
            this.campo_custo.Text = listaVoo.Items[0].SubItems[1].Text;
            this.campo_distancia.Text = listaVoo.Items[0].SubItems[2].Text;
            this.campoCaptura.Text = this.helper.selecionaRadios(listaVoo.Items[0].SubItems[3].Text);
            this.campo_nivelDor.Text = listaVoo.Items[0].SubItems[4].Text;

            this.id = listaVoo.Items[0].SubItems[5].Text;
        }

        
    }
}
