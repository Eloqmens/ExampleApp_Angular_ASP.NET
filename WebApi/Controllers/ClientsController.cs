using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ClientsController : Controller
    {
        [HttpGet]
        [Route("Api/Client/GetAll")]
        public IEnumerable<Client> GetAll()
        {
            return new[]
            {
                new Client {Name = "Pasha", Age =20, Specialty = ".Net"},
                new Client {Name = "Petya", Age =27, Specialty = "Angular"},
                new Client {Name = "Sasha", Age =25, Specialty = "React"}
            };
        }
    }
}
