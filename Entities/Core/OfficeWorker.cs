using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Core
{
    public class OfficeWorker : EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
