using Sample.Domain.Entities;

namespace Sample.Dal
{
    public interface IPuantajRepository
    {
        List<Personel> GetPersonelListesiByUserId(int userId);
        List<Puantaj> GetPuantajListByPersonelId(int personelId);
    }
}