using System.ComponentModel.DataAnnotations;

namespace TESTE.Models
{
    public class TB_NUMEROS
    {
        [Key]
        public Guid ID_REGISTRO { get; set; }
        public int NUMEROS { get; set; }
    }
}
