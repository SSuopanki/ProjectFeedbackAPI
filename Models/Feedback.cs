using System;
using System.Collections.Generic;

namespace ProjectFeedbackApi.Models
{
    public partial class Feedback
    {
        public int FeedbackId { get; set; }
        public string? FeedbackTitle { get; set; }
        public string? FeedbackMessage { get; set; }
    }
}