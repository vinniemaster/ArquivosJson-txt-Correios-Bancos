using System.ComponentModel.DataAnnotations;

namespace TESTE.Models
{
    public class TB_JSON
    {
        [Key]
        public Guid ID_REGISTRO { get; set; }
        public int CODIGO { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
