﻿using Bukinist.DAL.Entityes.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukinist.DAL.Entityes
{
    public class Deal:Entity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public virtual Book Book { get; set; }

        public virtual Seller Seller { get; set; }

        public virtual Buyer Buyer { get; set; }    

    }
}
