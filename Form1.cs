namespace Atividade_7___Calculado__RadioButton_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Double.Parse(txtValor1.Text);
            valor2 = Double.Parse(txtValor2.Text);

            if (rbAdicao.Checked)
            {
                resultado = valor1 + valor2;
                lblResultado.Text = resultado.ToString();
            }
            else if (rbSubtracao.Checked)
            {
                resultado = valor1 - valor2;
                lblResultado.Text = resultado.ToString();
            }
            else if (rbMultiplicacao.Checked)
            {
                resultado = valor1 * valor2;
                lblResultado.Text = resultado.ToString();
            }
            else if (rbDivisao.Checked)
            {
                resultado = valor1 / valor2;
                lblResultado.Text = resultado.ToString();
            }
            else
            {

                lblResultado.Visible = false;
            }
        }

        private void rbAdicao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
