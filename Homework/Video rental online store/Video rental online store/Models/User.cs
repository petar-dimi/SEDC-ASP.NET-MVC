﻿using Video_rental_online_store.Enums;

namespace Video_rental_online_store.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string CardNumber { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsSubscriptionExpired { get; set; }
        public SubscriptionType SubscriptionType { get; set; }

    }
}
