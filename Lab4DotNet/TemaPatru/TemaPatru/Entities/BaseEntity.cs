using System;
using System.ComponentModel.DataAnnotations;

namespace TemaPatru.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}