using act_01.Data; // Add this line at the top of your ServerService.cs file

namespace act_01
{
    public class ServerService
    {
        public List<Server> GetServers() => ServersRepository.GetServers();

        public void AddServer(Server server) => ServersRepository.AddServer(server);

        public void DeleteServer(int serverId) => ServersRepository.DeleteServer(serverId);

        //public void AddServer(Server server) => ServersRepository.AddServer(server);

        public void UpdateServer(int id, Server server) => ServersRepository.UpdateServer(id, server);

        //public void DeleteServer(int id) => ServersRepository.DeleteServer(id);

        public List<Server> GetServersByCity(string city) => ServersRepository.GetServersByCity(city);

        public Server? GetServerById(int id) => ServersRepository.GetServerById(id);

        public List<Server> SearchServers(string filter) => ServersRepository.SearchServers(filter);
    }
}