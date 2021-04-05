using System;
using System.ComponentModel.DataAnnotations.Schema;
using WPFAppUsersTestCore.Models.Enums;

namespace WPFAppUsersTestCore.Models.Entities
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateBirth { get; set; }
        public Gender Gender { get; set; }
        public int? SubdivisionId { get; set; }
    }
}
