﻿using System;
using System.Collections.Generic;

namespace Library.Models
{
    public class Action
    {
        public int Id { get; set; }

        public DateTime ActionDate { get; set; }

        public string ActionName { get; set; } = null!;

        public string Controller { get; set; } = null!;

        public string Ip { get; set; } = null!;
    }
}
