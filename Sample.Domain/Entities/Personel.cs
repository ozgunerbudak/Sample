using Sample.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Entities
{
    public class Personel:BaseEntity
    {
        public string Name { get; set; }
        public DateTime IseGirisTarih { get; set; }
    }
}
