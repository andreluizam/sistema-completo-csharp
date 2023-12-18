namespace SistemaEmpresarial.Models
{
    public class ComumSistema
    {
        public int UsuarioID { get; set; }

        // COLOCARIA AS PRINCIPAIS INFORMAÇÕES DO SISTEMA
        public ComumSistema(int usuarioID)
        {
            UsuarioID = usuarioID;
        }
    }
}