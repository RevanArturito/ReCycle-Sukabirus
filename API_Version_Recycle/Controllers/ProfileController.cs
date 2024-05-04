using Microsoft.AspNetCore.Mvc;

namespace API_Version_Recycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController
    {
        private static List<Profile_API> prfl = new List<Profile_API>()
        {
            new Profile_API("Rivapermana", "riv@example.com", 6281223023201)
        };

        [HttpGet(Name = "Profile")]
        
        public IEnumerable<Profile_API> Get()
        {
            return prfl;
        }
    }
}