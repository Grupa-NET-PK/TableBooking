﻿namespace TableBooking.Model
{
    public class Booking : Entity
    {
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public Guid TableId { get; set; }
        public Table Table { get; set; }
        public Guid UserId { get; set; }
    }
}
