using System.ComponentModel.DataAnnotations;

namespace CapivaraBeer.Domain.Entities
{
    public class Base
    {
        [Key]
        public Guid Id { get; set; }
    }
}
