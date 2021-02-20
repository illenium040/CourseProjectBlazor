using System;

namespace CourseProjectBlazor.DataAccessLayer.Models
{
    public class Product
    {
        public virtual int Id { get; set;}
        public virtual string Model { get; set; }
        public virtual int Price { get; set; }
    }
}