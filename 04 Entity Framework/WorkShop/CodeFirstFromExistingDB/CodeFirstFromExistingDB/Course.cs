using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CodeFirstFromExistingDB
{
    [Table("Courses")]
    public partial class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? Date { get; set; }

        public int Level { get; set; }

        public int? Author_Id { get; set; }

        public virtual Author Author { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }

    }
}
