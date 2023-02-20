using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name {get; set; }
        [DisplayName("display orders")]
        [Range(1,100,ErrorMessage ="the range should be between no 1 to 100 only!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
