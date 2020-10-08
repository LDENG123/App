using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;


namespace WpfApp1.Views
{
    /// <summary>
    /// Asix.xaml 的交互逻辑
    /// </summary>
    public partial class AsixView : UserControl, INotifyPropertyChanged
    {
 
        public AsixView()
        {

            InitializeComponent();
            //Growl.Success("成功");

        }
  


        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        private async Task LoadTextFile(RichTextBox richTextBox, string filename)
        {
            richTextBox.Document.Blocks.Clear();
            using (StreamReader streamReader = File.OpenText(filename))
            {
                Paragraph paragraph = new Paragraph();

                richTextBox.Document.Blocks.Add(paragraph);
            }
        }
            private void InjectStopOnClick(object sender, RoutedEventArgs e)
        {
            //     // int I= 0;
            // //    I++;
            // //    DownButton1.Items.Add(I.ToString());

            //     Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            //     dlg.FileName = ""; // Default file name
            //     dlg.DefaultExt = ".xml";  // Default file extension
            //     dlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* "; // Filter files by extension
            //     // Show open file dialog box
            //     Nullable<bool> result = dlg.ShowDialog();
            //     // Process open file dialog box results
            ////     if (result == true)
            //{
            //Growl.Success("成功11", "SuccessMsg");
        
                //    string filename = dlg.FileName;
                //}

            }

       
    }
}
    

