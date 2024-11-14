using System.ComponentModel.DataAnnotations;

namespace CapivaraBeer.Domain.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
