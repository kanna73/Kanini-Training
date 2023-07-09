using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPICODEFIRST.Model
{
    public class Bike
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string? Bike_Name { get; set; }
        public int Power { get; set; }
        public int meilage { get; set; }
        public int Price { get; set; }




    }
}
