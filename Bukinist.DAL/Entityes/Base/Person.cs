﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukinist.DAL.Entityes.Base
{
    public abstract class Person : NamedEntity
    {
        public string Surname { get; set; }
        public string Patronymic { get; set; }
    }
}
