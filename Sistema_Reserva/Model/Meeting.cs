﻿namespace Sistema_Reserva.Model
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Reserve Reserve { get; set; }
    }
}
