using Sample.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Entities
{
    // Db objesi()clası
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
