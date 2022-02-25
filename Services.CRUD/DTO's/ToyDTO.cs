using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.CRUD.DTO_s
{
   public class ToyDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }
       
        public string Descripcíon { get; set; }
        public int RetriccionEdad { get; set; }
        [Required]
        [MaxLength(50)]
        public string Compania { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public Decimal Precio { get; set; }
        public string Imagen { get; set; }
    }
}
