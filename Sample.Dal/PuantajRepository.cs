using Sample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Dal
{
    public class PuantajRepository : IPuantajRepository
    {
        public List<Puantaj> GetPuantajListByPersonelId(int personelId)
        {
            return null;
        }

        public List<Personel> GetPersonelListesiByUserId(int userId)
        {
            return null;
        }
    } 
}
