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
    public partial class Login : Form
    {
        bool existeFunc = false;

        Menu form2;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            existeFunc = false;

            foreach (DataGridViewRow data in funcionariosDataGridView.Rows)
            {
                if (txUsername.Text.ToString() == data.Cells["username"].Value.ToString() && tbPassword.Text.ToString() == data.Cells["password"].Value.ToString())
                {
                    existeFunc=true;
                    Program.nomeUtilizador=data.Cells["username"].Value.ToString();
                    Program.categoria = data.Cells["categoria"].Value.ToString();
                    Program.idFuncionario = Convert.ToInt64(data.Cells["IdFuncionario"].Value.ToString());
                    this.Hide();
                    form2 = new Menu();
                    form2.Show();
                }
            }

            if (existeFunc==false)
            {
                MessageBox.Show("A palavra-passe/username estão incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dsFuncionarios.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.dsFuncionarios.Funcionarios);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.logout==true)
            {
                txUsername.Text = "";
                tbPassword.Text = "";

                this.Show();
                form2.Close();

                Program.logout = false; 
            }
        }
    }
}
