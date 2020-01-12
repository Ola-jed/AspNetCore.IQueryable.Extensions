﻿using System;
using System.Diagnostics;

namespace RESTFul.Api.Models
{
    [DebuggerDisplay("{FullName}")]
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{LastName}, {FirstName}";
        public string Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
    }
}