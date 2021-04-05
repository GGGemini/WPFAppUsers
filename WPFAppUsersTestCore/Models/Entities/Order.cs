using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFAppUsersTestCore.Models.Entities
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
