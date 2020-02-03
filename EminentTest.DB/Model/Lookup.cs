using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EminentTest.DB.Model
{
    public class Lookup
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string LookupName { get; set; }
        [Required]
        public string LookupType { get; set; }
        [Required]
        public string LookupDescription { get; set; }
        [Required]
        public int LookupValue { get; set; }

    }
}
