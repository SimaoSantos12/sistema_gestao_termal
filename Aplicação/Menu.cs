using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Menu : Form
    {
        private tabelaFornecedor tabelaFornecedorInstance; // Campo para armazenar a instância de tabelaFornecedor
        private tabelaFunc tabelaFuncInstance;
        private tabelaAtividades tabelaAtividadesInstance;
        private tabelaProdutos tabelaProdutosInstance;
        private TabelaServicos tabelaServicosInstance;
        private TabelaCliente tabelaClienteInstance;
        private efetuarServico efetuarServicoInstance;
        private tabelaFornecimento tabelaFornecimentoInstance;
        private mudarPassAdmin mudarPassAdminInstance;
        private mudarPass mudarPassInstance;
        private realizarAtividade realizarAtividadeInstance;

        public Menu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Aplicação " + DateTime.Now.ToString() + " Nome: " + Program.nomeUtilizador;

            if (Program.categoria.ToLower() == "func" || Program.categoria.ToLower() == "gestor")
            {
                fornecedorToolStripMenuItem.Enabled = false;
                mudarPalavraPassToolStripMenuItem.Enabled = false;

            }
            if (Program.categoria.ToLower() == "gestor")
            {
                efetuarServiçoToolStripMenuItem.Enabled = false;

            }
            if (Program.categoria.ToLower() == "func")
            {
                realizarAtividadeToolStripMenuItem.Enabled = false;
            }
        }

        private void CloseAllOpenForms()
        {
            tabelaFornecedorInstance?.Close();
            tabelaFuncInstance?.Close();
            tabelaAtividadesInstance?.Close();
            tabelaProdutosInstance?.Close();
            tabelaServicosInstance?.Close();
            tabelaClienteInstance?.Close();
            efetuarServicoInstance?.Close();
            tabelaFornecimentoInstance?.Close();
            mudarPassAdminInstance?.Close(); ;
            mudarPassInstance?.Close();
            realizarAtividadeInstance?.Close(); 

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (tabelaFuncInstance == null || tabelaFuncInstance.IsDisposed)
            {
                tabelaFuncInstance = new tabelaFunc();
                tabelaFuncInstance.MdiParent = this;
                tabelaFuncInstance.FormClosed += (s, args) => tabelaFuncInstance = null; // Reseta a instância quando a janela é fechada
                tabelaFuncInstance.Show();
            }
            else
            {
                tabelaFuncInstance.BringToFront(); // Traz a janela existente para frente
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (tabelaClienteInstance == null || tabelaClienteInstance.IsDisposed)
            {
                tabelaClienteInstance = new TabelaCliente();
                tabelaClienteInstance.MdiParent = this;
                tabelaClienteInstance.FormClosed += (s, args) => tabelaClienteInstance = null; // Reseta a instância quando a janela é fechada
                tabelaClienteInstance.Show();
            }
            else
            {
                tabelaClienteInstance.BringToFront(); // Traz a janela existente para frente
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (tabelaServicosInstance == null || tabelaServicosInstance.IsDisposed)
            {
                tabelaServicosInstance = new TabelaServicos();
                tabelaServicosInstance.MdiParent = this;
                tabelaServicosInstance.FormClosed += (s, args) => tabelaServicosInstance = null; // Reseta a instância quando a janela é fechada
                tabelaServicosInstance.Show();
            }
            else
            {
                tabelaServicosInstance.BringToFront(); // Traz a janela existente para frente
            }
        }

        private void atividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (tabelaAtividadesInstance == null || tabelaAtividadesInstance.IsDisposed)
            {
                tabelaAtividadesInstance = new tabelaAtividades();
                tabelaAtividadesInstance.MdiParent = this;
                tabelaAtividadesInstance.FormClosed += (s, args) => tabelaAtividadesInstance = null; // Reseta a instância quando a janela é fechada
                tabelaAtividadesInstance.Show();
            }
            else
            {
                tabelaAtividadesInstance.BringToFront(); // Traz a janela existente para frente
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (tabelaProdutosInstance == null || tabelaProdutosInstance.IsDisposed)
            {
                tabelaProdutosInstance = new tabelaProdutos();
                tabelaProdutosInstance.MdiParent = this;
                tabelaProdutosInstance.FormClosed += (s, args) => tabelaProdutosInstance = null; // Reseta a instância quando a janela é fechada
                tabelaProdutosInstance.Show();
            }
            else
            {
                tabelaProdutosInstance.BringToFront(); // Traz a janela existente para frente
            }
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (tabelaFornecedorInstance == null || tabelaFornecedorInstance.IsDisposed)
            {
                tabelaFornecedorInstance = new tabelaFornecedor();
                tabelaFornecedorInstance.MdiParent = this;
                tabelaFornecedorInstance.FormClosed += (s, args) => tabelaFornecedorInstance = null; // Reseta a instância quando a janela é fechada
                tabelaFornecedorInstance.Show();
            }
            else
            {
                tabelaFornecedorInstance.BringToFront(); // Traz a janela existente para frente
            }
        }

        private void efetuarServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (efetuarServicoInstance == null || efetuarServicoInstance.IsDisposed)
            {
                efetuarServicoInstance = new efetuarServico();
                efetuarServicoInstance.MdiParent = this;
                efetuarServicoInstance.FormClosed += (s, args) => efetuarServicoInstance = null; // Reseta a instância quando a janela é fechada
                efetuarServicoInstance.Show();
            }
            else
            {
                efetuarServicoInstance.BringToFront(); // Traz a janela existente para frente
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.logout = true;
        }

        private void registarFornecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (tabelaFornecimentoInstance == null || tabelaFornecimentoInstance.IsDisposed)
            {
                tabelaFornecimentoInstance = new tabelaFornecimento();
                tabelaFornecimentoInstance.MdiParent = this;
                tabelaFornecimentoInstance.FormClosed += (s, args) => tabelaFornecimentoInstance = null; // Reseta a instância quando a janela é fechada
                tabelaFornecimentoInstance.Show();
            }
            else
            {
                tabelaFornecimentoInstance.BringToFront(); // Traz a janela existente para frente
            }
        }

        private void mudarPalavraPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();
                if (mudarPassAdminInstance == null || mudarPassAdminInstance.IsDisposed)
                {
                    mudarPassAdminInstance = new mudarPassAdmin();
                    mudarPassAdminInstance.MdiParent = this;
                    mudarPassAdminInstance.FormClosed += (s, args) => mudarPassAdminInstance = null; // Reseta a instância quando a janela é fechada
                    mudarPassAdminInstance.Show();
                }
                else
                {
                    mudarPassAdminInstance.BringToFront(); // Traz a janela existente para frente
                }
            }
        

        private void reporPalavraPasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();
            
                if (mudarPassInstance == null || mudarPassInstance.IsDisposed)
                {
                    mudarPassInstance = new mudarPass();
                    mudarPassInstance.MdiParent = this;
                    mudarPassInstance.FormClosed += (s, args) => mudarPassInstance = null; // Reseta a instância quando a janela é fechada
                    mudarPassInstance.Show();
                }
                else
                {
                    mudarPassInstance.BringToFront(); // Traz a janela existente para frente
                }
            
        }

        private void realizarAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenForms();

            if (realizarAtividadeInstance == null || realizarAtividadeInstance.IsDisposed)
            {
                realizarAtividadeInstance = new realizarAtividade();
                realizarAtividadeInstance.MdiParent = this;
                realizarAtividadeInstance.FormClosed += (s, args) => realizarAtividadeInstance = null; // Reseta a instância quando a janela é fechada
                realizarAtividadeInstance.Show();
            }
            else
            {
                realizarAtividadeInstance.BringToFront(); // Traz a janela existente para frente
            }
        }
    }
}