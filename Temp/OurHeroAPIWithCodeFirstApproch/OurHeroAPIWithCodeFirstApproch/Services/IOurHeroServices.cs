using OurHeroAPIWithCodeFirstApproch.Models;
using OurHeroAPIWithCodeFirstApproch.Model;

namespace OurHeroAPIWithCodeFirstApproch.Services
{
    public interface IOurHeroServices
    {
        Task<List<OurHero>> GetAllHeros(bool? isActive);
        Task<OurHero?> GetHerosByID(int id);
        Task<OurHero?> AddOurHero(AddUpdateOurHero obj);
        Task<OurHero?> UpdateOurHero(int id, AddUpdateOurHero obj);
        Task<bool> DeleteHerosByID(int id);

    }
}
