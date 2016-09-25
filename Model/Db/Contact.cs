using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(20)]
        public string Phone { get; set; }

        public DateTime CreatedUtc { get; set; }

        public bool IsActual { get; set; }

        public Contact()
        {
            this.CreatedUtc = DateTime.UtcNow;
            this.IsActual = true;
        }

        public Contact(string name, string phone)
        {
            this.CreatedUtc = DateTime.UtcNow;
            this.Name = name;
            this.Phone = phone;
            this.IsActual = true;
        }

        public Contact(int id, string name, string phone)
        {
            this.CreatedUtc = DateTime.UtcNow;
            this.Name = name;
            this.Phone = phone;
            this.Id = id;
            this.IsActual = true;
        }
    }
}
