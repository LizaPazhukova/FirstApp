﻿using FirstApp.Data.Enums;

namespace FirstApp.Logic.DTO
{
    public class CardDTO
    {
        //public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly DueDate { get; set; }
        public string? Description { get; set; }
        public PriorityEnum Priority { get; set; }
    }
}
