using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPICODEFIRST.Model
{
    public class User
    {
        public int Id { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}
