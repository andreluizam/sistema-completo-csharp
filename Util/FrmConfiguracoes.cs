namespace SistemaEmpresarial.Util
{
    public partial class FrmConfiguracoes : Form
    {
        public FrmConfiguracoes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           Configuracoes.CaminhoImpressao = txtCaminhoImpressao.Text;
        }
    }
}
