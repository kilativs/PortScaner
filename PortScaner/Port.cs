namespace PortScaner
{
    internal class Port
    {
        public int PortNumber { get; set; }
        public string LocalAdress { get; set; }
        public string RemoteAdress { get; set; }
        public string State { get; set; }

        public Port(int portNumber, string local, string remote, string state)
        {
            PortNumber = portNumber;
            LocalAdress = local;
            RemoteAdress = remote;
            State = state;
        }
    }
}
