namespace Layered.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Comment")]
    public partial class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
