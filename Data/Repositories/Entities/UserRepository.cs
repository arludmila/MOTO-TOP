﻿using Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Entities
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(MotoTopContext context) : base(context)
        {

        }

    }
}