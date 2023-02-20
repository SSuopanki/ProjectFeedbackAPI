using System;
using System.Collections.Generic;

namespace ProjectFeedbackApi.Models
{
    public class ProjectFeedback
    {
        public int RowId { get; set; }
        public int ProjectId { get; set; }
        public int FeedbackId { get; set; }
    }
}