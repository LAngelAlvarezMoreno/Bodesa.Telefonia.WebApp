﻿using System.ComponentModel.DataAnnotations;

namespace Bodesa.Telefonia.WebApp.Entities
{
    public class cnf_PhoneNumber
    {
        [Key]
        public string PhoneNumber { get; set; }
        public int Region { get; set; }
        public string? Status { get; set; }
    }
}
