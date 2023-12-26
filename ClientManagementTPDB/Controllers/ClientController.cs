using ClientManagementTPDB.Data;
using ClientManagementTPDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientManagementTPDB.Controllers
{
    public class ClientController : Controller
    {
        private static int Id =4 ;
        List<Client> listeClient = ClientRepo.GetClients();
        public IActionResult Index()
        {
            ViewBag.clients = listeClient;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            Client client = new Client();
            client.Id = Id;
            Id++;
            return View(client);

        }

        [HttpPost]
        public IActionResult Create(Client client)
        {
            listeClient.Add(client);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Client client = listeClient.Find(cl  => cl.Id == id);
            return View(client);
        }

        [HttpPost]
        public IActionResult Update(Client client) 
        {
            Client cl = listeClient.Find(cl => cl.Id == client.Id);
            cl.FirstName = client.FirstName;
            cl.LastName = client.LastName;  
            cl.City = client.City;
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            Client client = listeClient.Find(cl => cl.Id == id);
            listeClient.Remove(client); 
            return RedirectToAction("Index");
        }


    }
}
