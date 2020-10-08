using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindowView :MetroWindow
    {
        public MainWindowView()
        {
            InitializeComponent();
            //Growl.Success("成功12", "SuccessMsg");

        }
        
      
       
        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel)
            {
                return;
            }

           
            
        }

       

        #region "flyout程序设定"
        private void ToggleFlyout(int index)
        {
            var flyout = this.Flyouts.Items[index] as Flyout;
            if (flyout == null)
            {
                return;
            }

            flyout.IsOpen = !flyout.IsOpen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.ToggleFlyout(1);
        }

        #endregion
       
    
      
      
        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.ToggleFlyout(0);
        }
        
       
           


        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            HamburgerMenuControl.Content = e.InvokedItem;
        }


        private void Button_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            this.ToggleFlyout(0);
        }

       
    }
  
}
