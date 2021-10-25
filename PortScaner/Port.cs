namespace PortScaner
{
    internal class Port
    {
        public int PortNumber { get; set; }
        public string LocalAdress { get; set; }
        public string RemoteAdress { get; set; }
        public string State { get; set; }

        public Port(int portNumber, string localAdress, string remoteAdress, string state)
        {
            PortNumber = portNumber;
            LocalAdress = localAdress;
            RemoteAdress = remoteAdress;
            State = state;
        }
    }
}
