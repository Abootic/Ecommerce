﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BaseEntity;

namespace EcommereceWeb.Domain.Entity
{
    public class BasicClassification : AuditableEntity, IBaseEntity<int>
    {

        public int Id { get; set; }
        public string BasicClassificationName { get; set; }
        public int? MainClassificationId { get; set; } // from MainClassification Model
        public string? ImageUrl { get; set; }
        

      
      
    }
}