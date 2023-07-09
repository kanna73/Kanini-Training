using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPICODEFIRST.Model
{
    public class Admin
    {
        public int Id { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string? AdminName { get; set; }
        public string? Password { get; set; }
    }
}
