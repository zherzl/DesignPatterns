namespace Layered.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    [Table("Post")]
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

       

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime DateAdded { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public static Post Find(int postId)
        {
            throw new NotImplementedException();
        }

        public static Post[] FindAll()
        {
            return new BlogContext().Posts.ToArray<Post>();
        }

        public static Post FindLatestPost()
        {
            return new BlogContext().Posts.OrderByDescending(x => x.Id).FirstOrDefault();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
