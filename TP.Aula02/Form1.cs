namespace TP.Aula02
{
    public partial class frmCalcIMC : Form
    {
        public frmCalcIMC()
        {
            InitializeComponent();
        }

        private void frmCalcIMC_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(txbPeso.Text);
            altura = Convert.ToDouble(mtbAltura.Text);

            var (descricaoIMC, resultadoImc) = CalcularImc(peso, altura / 100);

            lblSituacaoIMC.Text = $"{descricaoIMC}\nSeu IMC: {resultadoImc}";
        }

        private (string, double) CalcularImc(double peso, double altura)
        {
            double imc = peso / (altura * altura);

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >=20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobrepeso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (resultado, imc);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbPeso.Text = String.Empty;
            mtbAltura.Text = String.Empty;
            lblSituacaoIMC.Text = String.Empty;

            txbPeso.Focus();
        }

        private void lblSituacaoIMC_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}