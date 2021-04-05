using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFAppUsersTestCore.Models.Entities
{
    [Table("Subdivisions")]
    public class Subdivision
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
    }
}
