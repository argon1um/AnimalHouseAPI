using AnimalHouseRestAPI.DataBase;
using AnimalHouseRestAPI.Models;
using AnimalHouseRestAPI.ModelsDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AHRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clients : ControllerBase
    {
        [HttpPost]
        [Route("/clients/auth/log")]
        public ActionResult<ClientRegistrationDTO> ClientAuthentification([FromBody] ClientDTO clientdto)
        {
            Client clreg = DataBaseConnection.Context.Clients.ToList().FirstOrDefault(x => x.ClientLogin == clientdto.Login && x.ClientPassword == clientdto.Password);
            if (clreg == null)
            {
                return BadRequest();
            }
            else
            {
                return ClientRegistrationDTO.ClientConverter(clreg);
            }
        }

        [HttpPost]
        [Route("/clients/auth/reg")]
        public ActionResult<Client> ClientRegistration([FromBody] ClientRegistrationDTO clientregdto)
        {
            if (clientregdto != null)
            {
                List<Client> clients = DataBaseConnection.Context.Clients.ToList();
                foreach (Client client in clients)
                {
                    if (client.ClientLogin == clientregdto.ClientLogin)
                    {
                        return Conflict();
                    }
                }
                clientregdto.ID = DataBaseConnection.Context.Clients.Count()+1;
                DataBaseConnection.Context.Clients.Add(ClientRegistrationDTO.ClientConverter(clientregdto));
                DataBaseConnection.Context.SaveChanges();
                return Ok();
            }
            else { return BadRequest(); }
        }
    }
}
