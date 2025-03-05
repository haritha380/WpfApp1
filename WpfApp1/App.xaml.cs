using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 


    public partial class App : Application
    {
        public static AppDbContext db { get; set; } = new();
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
    }

}
