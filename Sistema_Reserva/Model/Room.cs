﻿namespace Sistema_Reserva.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
