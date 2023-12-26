using ClientManagementTPDB.Models;

namespace ClientManagementTPDB.Data
{
    public class ClientRepo
    {
        private static List<Client> clients = new List<Client>()
        {
            new Client
            {
                 Id = 1,
                FirstName = "Said",
                LastName = "Jamali",
                City="Casablanca"
            },
            new Client
            {
                Id = 2,
                FirstName = "Salma",
                LastName = "Krawi",
                City="Fes"
            },
            new Client {
                Id = 3,
                FirstName = "Amin",
                LastName = "Safi",
                City="Agadir"
            }
        };

        public static List<Client> GetClients() { return clients; }
    }
}
