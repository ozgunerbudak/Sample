using Sample.Dal;
using Sample.Domain.Entities;
using Sample.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLPuantaj
{
    public class PuantajService : IPuantajService
    {
        IPuantajRepository _puantajRepository;
        IUserRepository _userRepository;
        public PuantajService(IPuantajRepository puantajRepository, IUserRepository userRepository)
        {
            _puantajRepository = puantajRepository;
            _userRepository = userRepository;
        }


        public List<PuantajModel> GetPuantajs()
        {
            //Login olan user gibi düşün
            var user = _userRepository.GetAllUser().FirstOrDefault();

            var personeller =_puantajRepository.GetPuantajListByPersonelId(user.Id);
            List<PuantajModel> puantajModels = new();
            foreach (var personel in personeller)
            {
             var puantajListesi=   _puantajRepository.GetPuantajListByPersonelId(personel.Id);
                puantajModels.AddRange(puantajListesi.Select(s => new PuantajModel()
                {
                    CalismaSaati = 4,
                    CalismaTarihi = DateTime.UtcNow,
                    PersonelAdiSoyadi = s.Gun
                }));
            }

            return puantajModels;
        }
    }
}
