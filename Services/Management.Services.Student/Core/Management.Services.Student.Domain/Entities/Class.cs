﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Services.Student.Domain.Entities
{
    public class Class : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
    }
}
