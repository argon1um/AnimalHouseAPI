using AnimalHouseRestAPI.Models;

namespace AnimalHouseRestAPI.ModelsDTO
{
    public class ClientRegistrationDTO
    {
        public int ID { get; set; }
        public string ClientName { get; set; }
        public string ClientLogin { get; set; }
        public string ClientPassword { get; set; }
        public decimal ClientPhone { get; set; }
        public string ClientEmail { get; set; }

        public static Client ClientConverter (ClientRegistrationDTO clientRegistrationDTO)
        {
            Client client = new Client();
            client.ClientLogin = clientRegistrationDTO.ClientLogin;
            client.ClientPhone = clientRegistrationDTO.ClientPhone;
            client.ClientId = clientRegistrationDTO.ID;
            client.ClientName = clientRegistrationDTO.ClientName;
            client.ClientPassword = clientRegistrationDTO.ClientPassword;
            client.ClientEmail = clientRegistrationDTO.ClientEmail;
            return client;
        }

        public static ClientRegistrationDTO ClientConverter(Client client)
        {
            ClientRegistrationDTO clientRegistrationDTO = new ClientRegistrationDTO();
            clientRegistrationDTO.ClientLogin = client.ClientLogin;
            clientRegistrationDTO.ClientPhone = client.ClientPhone;
            clientRegistrationDTO.ID = client.ClientId;
            clientRegistrationDTO.ClientName = client.ClientName;
            clientRegistrationDTO.ClientPassword = client.ClientPassword;
            clientRegistrationDTO.ClientEmail = client.ClientEmail;
            return clientRegistrationDTO;
        }
    }
}
