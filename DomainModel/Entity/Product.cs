using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}