namespace TRIÂNGULO
{
    public partial class TRIÂNGULOS : Form
    {
        public TRIÂNGULOS()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public double CalcTriangulo(float peso, float altura)
        {
            double tri;
            float valorCateto1 = float.Parse(txtCateto1.Text);
            float valorCateto2 = float.Parse(txtCateto2.Text);
            float valorHipotenusa = float.Parse(txtHipotenusa.Text);
            double ResultTriangulo = (valorCateto1 * valorCateto2 / 2);

            if (valorCateto1 == valorCateto2 && valorCateto2 == valorHipotenusa)
            {
                lblSituacao.Text = "EQUILÁTERO";
            }
            if (valorCateto1 == valorCateto2 || valorCateto1 == valorHipotenusa || valorCateto2 == valorHipotenusa)
            {
                lblSituacao.Text = "ISÓSCELES";
            }
            else
            {
                lblSituacao.Text = "ESCALENO";
            }
        
            tri = ResultTriangulo;

            return tri;
        }

        private void btnCaucular_Click(object sender, EventArgs e)
        {
            float Cateto1 = float.Parse(txtCateto1.Text);
            float Cateto2 = float.Parse(txtCateto2.Text);
            double Hipotenusa = CalcTriangulo(Cateto1, Cateto2);
            txtTotal.Text = Hipotenusa.ToString("N1");
        }
    }
}