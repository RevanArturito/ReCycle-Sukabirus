using Microsoft.AspNetCore.Mvc;
using static API_Version_Recycle.Riwayat_API;

namespace API_Version_Recycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RiwayatController
    {
        private static List<Riwayat_API> rwyt = new List<Riwayat_API>()
        {
            new Riwayat_API("STX02839393", "4.800.000", 1),
            new Riwayat_API("STX02813551", "9.600.000", 2),
            new Riwayat_API("STX55123612", "2.350.000", 1)
        };

        [HttpGet(Name = "Riwayat")]
        
        public IEnumerable<Riwayat_API> Get()
        {
            return rwyt;
        }
    }
}