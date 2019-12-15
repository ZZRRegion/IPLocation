using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Runtime.Serialization;
using System.IO;

namespace IPLocation
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string result = await httpClient.GetStringAsync("https://api.ip.sb/geoip");
            this.txt.Text = result;
            System.Runtime.Serialization.Json.DataContractJsonSerializer json = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(GetIpModel));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            GetIpModel model = json.ReadObject(ms) as GetIpModel;
            this.DataContext = model;
        }
    }
}
