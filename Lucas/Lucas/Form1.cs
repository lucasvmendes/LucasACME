using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carregaLista();
        }
        Database database = new Database();
        int indiceDoVoo;
        bool novoRegistro = false;
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            limpaCampos();
            habilitaCampos();
            btnSalvar.Enabled = 
            btnCancelar.Enabled = true;
            novoRegistro = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            database.ExcluirDadosPorID(indiceDoVoo);
            limpaCampos();
            desabilitaCampos();
            carregaLista();
            btnExcluir.Enabled =
            btnSalvar.Enabled =
            btnCancelar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                if (novoRegistro)
                {
                    Dados dados = new Dados();
                    dados = registrosAtuais();
                    database.AdicionarDados(dados);
                }
                else
                {
                    Dados dados = new Dados();
                    dados = registrosAtuais();
                    database.ModificarDados(dados, indiceDoVoo);
                }

                carregaLista();
                limpaCampos();
                desabilitaCampos();
                btnSalvar.Enabled =
                btnCancelar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            carregaLista();
            limpaCampos();
            desabilitaCampos();
            btnSalvar.Enabled =
            btnCancelar.Enabled = false;
        }
        private void carregaLista()
        {
            try
            {
                Database database = new Database();
                DataTable dtable = database.BuscaDados();
                listViewDados.Items.Clear();
                for (int i = 0; i < dtable.Rows.Count; i++)
                {
                    DataRow drow = dtable.Rows[i];
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        ListViewItem lvi = new ListViewItem(String.Format("{0:yyyy/MM/dd}",drow["DATA_VOO"]));
                        lvi.SubItems.Add(drow["Captura"].ToString());
                        lvi.SubItems.Add(drow["NIVEL_DOR"].ToString());
                        lvi.SubItems.Add(drow["ID_VOO"].ToString());
                        listViewDados.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void carregaValores(int indiceDoVoo)
        {
            try
            {
                DataTable dtable = database.BuscaDadosPorID(indiceDoVoo);
                DataRow drow = dtable.Rows[0];
                dtDataVoo.Value = Convert.ToDateTime(drow["DATA_VOO"]);
                txtCusto.Text = drow["CUSTO"].ToString();
                txtDistancia.Text = drow["DISTANCIA"].ToString();
                txtNivelDor.Text = drow["NIVEL_DOR"].ToString();
                if (Convert.ToChar(drow["CAPTURA"]) == 'N')
                    rdbNao.Checked = true;
                else
                    rdbSim.Checked = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void listViewDados_Click(object sender, EventArgs e)
        {
            indiceDoVoo = Convert.ToInt32(listViewDados.SelectedItems[0].SubItems[3].Text);
            carregaValores(indiceDoVoo);
            habilitaCampos();
            btnExcluir.Enabled = true;
            btnSalvar.Enabled =
            btnCancelar.Enabled = false;
        }
        private void limpaCampos()
        {
            txtCusto.Text =
            txtDistancia.Text = null;
            txtNivelDor.Value = 0;
            btnExcluir.Enabled =
            rdbNao.Checked = 
            rdbSim.Checked = false;
        }
        private Dados registrosAtuais()
        {
            try
            {
                Dados dados = new Dados();
                dados.DATA_VOO = Convert.ToDateTime(dtDataVoo.Value);
                dados.CUSTO = Convert.ToDouble(txtCusto.Text);
                dados.DISTANCIA = Convert.ToInt32(txtDistancia.Text);
                dados.CAPTURA = (rdbNao.Checked ? 'N' : 'S');
                dados.NIVEL_DOR = Convert.ToInt32(txtNivelDor.Text);
                return dados;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        private bool validaDados()
        {
            if (!string.IsNullOrEmpty(txtCusto.Text) && !string.IsNullOrEmpty(txtDistancia.Text)
                && Int32.TryParse(txtDistancia.Text, out int i) && Double.TryParse(txtCusto.Text, out double k))
            {
                return true;
            }
            else
                return false;
            
        }
        private void habilitaCampos()
        {
            dtDataVoo.Enabled =
            txtCusto.Enabled =
            txtDistancia.Enabled =
            rdbNao.Enabled =
            rdbSim.Enabled =
            txtNivelDor.Enabled = true;
        }
        private void desabilitaCampos()
        {
            dtDataVoo.Enabled =
            txtCusto.Enabled =
            txtDistancia.Enabled =
            rdbNao.Enabled =
            rdbSim.Enabled =
            txtNivelDor.Enabled = false;
        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled =
            btnCancelar.Enabled = true;
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled =
            btnCancelar.Enabled = true;
        }

        private void rdbNao_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled =
            btnCancelar.Enabled = true;
        }

        private void rdbSim_CheckedChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled =
            btnCancelar.Enabled = true;
        }

        private void dtDataVoo_ValueChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled =
            btnCancelar.Enabled = true;
        }

        private void txtNivelDor_ValueChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled =
            btnCancelar.Enabled = true;
        }
    }
}
