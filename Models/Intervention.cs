﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketElevatorsCustomerPortal.Models
{
    public class Intervention
    {
        public long id { get; set; }
        public long author { get; set; }
        public long customer_id { get; set; }
        public long building_id { get; set; }
        public long? battery_id { get; set; }
        public long? column_id { get; set; }
        public long? elevator_id { get; set; }
        public long? employee_id { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string result { get; set; }
        public string report { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}