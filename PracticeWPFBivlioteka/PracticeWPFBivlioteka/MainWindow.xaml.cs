
using JsonConverterTest;
using System;
using System.IO;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static JsonConverterTest.DataSerializer;
namespace PracticeWPFBivlioteka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  string filePath = "SUPER-PUPERFailExe.xml";

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void SerializedBtn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = new Test
                {
                    RandomTextOne = NameTxb.Text,
                    RandomTextTwo = SurNameTxb.Text,
                    RandomTextThree = TelephoneTxb.Text

                };
                DataSerializer.Serialize(data, filePath);
                MessageBox.Show("Ваши данные сохранены");
                NameTxb.Text = string.Empty;
                SurNameTxb.Text = string.Empty;
                TelephoneTxb.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DeserializedBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var data = DataSerializer.Deserialize<Test>(filePath);
                    NameTxb.Text = data.RandomTextOne;
                    SurNameTxb.Text = data.RandomTextTwo;
                    TelephoneTxb.Text = data.RandomTextThree;
                    MessageBox.Show("Ваши данные выгружены");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
