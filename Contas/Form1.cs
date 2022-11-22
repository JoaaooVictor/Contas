using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ContaPoupanca cp = new ContaPoupanca();

        private void btnSacar_Click(object sender, EventArgs e)
        {
            cp.Sacar(Convert.ToDouble(txtValor.Text));
            txtSaldo.Text = cp.Saldo.ToString();
            txtValor.Text = null;
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titular: " + cp.Titular + "\nAgência: " + cp.Agencia 
                + "\nNúmero da conta: " + cp.Numero + "\nSaldo: " + cp.Saldo.ToString("C") 
                + "\nValor do juros: " + cp.Calcular().ToString("C"));
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            cp.Depositar(Convert.ToDouble(txtValor.Text));
            txtSaldo.Text = cp.Saldo.ToString();
            txtValor.Text = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cp.Agencia = txtAgencia.Text;
            cp.Numero = txtConta.Text;
            cp.Titular = txtTitular.Text;
            cp.Saldo = Convert.ToDouble(txtSaldo.Text);
            cp.Limite = 500;
            MessageBox.Show("Conta Criada com sucesso!");
        }
    }
}
