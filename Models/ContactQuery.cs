﻿using System;

namespace AIMSRCollegeWebsite.Models
{
    public class ContactQuery
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}