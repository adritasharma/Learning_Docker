using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.db.Entities
{
    [Table("Occasions")]
    public class Occasion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OccasionId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string LastName { get; set; }
        
        public DateTime Date { get; set; }
        public int OccasionTypeId { get; set; }

        [ForeignKey("OccasionTypeId")]
        public virtual OccasionType OccasionType { get; set; }

    }
}
