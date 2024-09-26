using System;
using System.Collections.Generic;

namespace HotelManagementSystem.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Bookings = new HashSet<Booking>();
        }

        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int CustomerId { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
