using Sample.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Model
{
    public class UserModel : BaseEntity
    {
        public string FullName { get; set; }
    }
}
