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
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object collection;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mefostat:mefostat.234@cluster0.g4gtx.mongodb.net/Lesson401?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("Lesson401");
            var collection = database.GetCollection<BsonDocument>("student");
            var cursor = collection.Find(new BsonDocument()).ToCursor();
            var doc = new BsonDocument

            {"First Name",First Name.Text },
            { "Last Name",Last Name.Text },
            { "Cours Number",Grup.Text },
            { "Direction",Last Spec.Text };

            Collection.InsertOne(doc);
  MessageBox.Show("Коллекция добалена!");

foreach (var document in cursor.ToEnumerable())

            {
                MongoDB.Text += ($"{ document}");
            }

        }    
    }
}
