﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Core
{
    public class Client : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
    }
}
