﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class ProductEvaluaton : AuditableEntity, IBaseEntity<int>
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int? ProductId { get; set; }
        public string UserId { get; set; }
      
       
    }
}