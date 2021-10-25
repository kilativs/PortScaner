using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace PortScaner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            IEnumerable<Port> port = MainWindow.GetOpenPort();
            ListviewScaner.ItemsSource = port;
        }

        private static IEnumerable<Port> GetOpenPort()
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            properties.GetActiveTcpListeners();
            TcpConnectionInformation[] tcpConnections = properties.GetActiveTcpConnections();

            return tcpConnections.Select(p => new Port(
                p.LocalEndPoint.Port,
                $"{p.LocalEndPoint.Address}:{p.LocalEndPoint.Port}",
                $"{p.RemoteEndPoint.Address}:{p.RemoteEndPoint.Port}",
                p.State.ToString())).ToList();
        }
    }
}
