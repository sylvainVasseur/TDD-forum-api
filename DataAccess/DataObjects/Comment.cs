using System;
using System.Collections.Generic;

namespace forum_api.DataAccess.DataObjects
{
    public partial class Comment
    {
        public int IdComment { get; set; }
        public string Username { get; set; } = null!;
        public DateOnly CreationDate { get; set; }
        public DateOnly ModificationDate { get; set; }
        public string Content { get; set; } = null!;
        public int TopicIdtopic { get; set; }

        public virtual Topic TopicIdtopicNavigation { get; set; } = null!;
    }
}
