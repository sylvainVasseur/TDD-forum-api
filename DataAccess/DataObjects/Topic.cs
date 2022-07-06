using System;
using System.Collections.Generic;

namespace forum_api.DataAccess.DataObjects
{
    public partial class Topic
    {
        public Topic()
        {
            Comments = new HashSet<Comment>();
        }

        public int Idtopic { get; set; }
        public DateOnly CreationDate { get; set; }
        public DateOnly ModificationDate { get; set; }
        public string Title { get; set; } = null!;
        public string CreatorName { get; set; } = null!;

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
