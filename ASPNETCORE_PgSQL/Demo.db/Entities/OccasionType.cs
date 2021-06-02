using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Demo.db.Entities
{
    [Table("OccasionTypes")]
    public class OccasionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OccasionTypeId { get; set; }
        public string OccasionTypeName { get; set; }

    }
}
