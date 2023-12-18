using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEmpresarial.Models
{
    public class Permissoes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int FormID { get; set; }

        [ForeignKey("GrupoID")]
        public int GrupoID { get; set; }

        public bool INSERIR { get; set; }
        public bool VISUALIZAR { get; set; }
        public bool ALTERAR { get; set; }
        public bool EXCLUIR { get; set; }
    }
}
