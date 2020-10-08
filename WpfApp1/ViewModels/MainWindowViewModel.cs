using System;
using Panuon.UI.Silver;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Enterwell.Clients.Wpf.Notifications;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Linq;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using WpfApp1.Resource;
using Notifications.Wpf;
using System.Windows.Input;
using System.Windows.Controls;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Threading;
using MaterialDesignThemes.Wpf;
using MaterialDesignColors;
using System.Windows.Media;

namespace WpfApp1
{
    [Export(typeof(IShell))]
    class MainWindowViewModel : Screen, INotifyPropertyChanged,IHandle<string> ,IHandle<ObservableCollection<Lib.Xml_helper>>
    {
        #region  OnPropertyChanged
    //public event PropertyChangedEventHandler PropertyChanged;

    //protected virtual void OnPropertyChanged(string propertyName = null)
    //{
    //    if (PropertyChanged != null)
    //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}
    #endregion
    #region 字段声明
    private string Time_Now_1;
        public string Time_Now_0
        {
            get { return Time_Now_1; }
            set
            {
                Time_Now_1 = value;
                if (DateTime.Now.ToString("hh:mm:ss") =="09:38:00" )
                {
                     xls_creat();
                }
                NotifyOfPropertyChange(() => Time_Now_0); ;// OnPropertyChanged("Time_Now_0")
            }
        }
        private string _User_Name;
        public string User_Name
        {
            get { return _User_Name; }
            set {
                _User_Name = value;
                NotifyOfPropertyChange(() => User_Name); 
 //OnPropertyChanged("Name_mum")
            }

        }

        #endregion
        private readonly IEventAggregator _eventAggregator;
       [ImportingConstructor]
        public MainWindowViewModel(IEventAggregator e)
        {
            ToggleBaseCommand = new Command_film.MyCommand(o => ApplyBase((bool)o));
            paletteHelper = new PaletteHelper();
            // Lib.ConnectPlc1 connectPlc1 = new Lib.ConnectPlc1();
            //xls_creat();
            Lib.Excel_Class excel_Class = new Lib.Excel_Class();
            excel_Class.xls_creat();
            _eventAggregator = e;
            _eventAggregator.Subscribe(this);
            lan = "zh";
            Visible = true;
            Task.Run( () =>
            {
                while(true)
                { 

                Time_Now_0 = DateTime.Now.ToString();
                    
                
                  
                    Thread.Sleep(1000);
                }

            });
            
            
          

        }
        #region  excel生成
        HSSFWorkbook HSSFWorkbook;
        HSSFWorkbook HSSFWorkbook_re;
        private FileStream FileStreamfile;
        string xlsfilename;
        private void xls_creat()
        {

           
                HSSFWorkbook = new HSSFWorkbook();
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "NPOI Team";
                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Subject = "NPOI SDK Example";
                HSSFWorkbook.DocumentSummaryInformation = dsi;
                HSSFWorkbook.SummaryInformation = si;
                ISheet hSSFSheet = HSSFWorkbook.CreateSheet("sheet1");
                xlsfilename = "excel/" + DateTime.Now.ToString("D") + ".xls";
                if (File.Exists(xlsfilename))
                {
                    //System.Windows.MessageBox.Show("该表已经存在");
                    //await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("Wow, you typed Return and got", "该表已经存在");
                   ;
                }
                else //第一行数据设置
                {
                    ///创建单元格风格
                    ICellStyle hSSFCellStyle = HSSFWorkbook.CreateCellStyle();
                    //style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    hSSFCellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    hSSFCellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                    IRow rows = hSSFSheet.CreateRow(0);
                    rows.CreateCell(0).SetCellValue("FH_U");
                    rows.CreateCell(1).SetCellValue("Tab_U");
                    rows.CreateCell(2).SetCellValue("FH_V");
                    rows.CreateCell(3).SetCellValue("Tab_V");
                    rows.CreateCell(4).SetCellValue("FH_W");
                    rows.CreateCell(5).SetCellValue("Tab_W");
                    rows.CreateCell(6).SetCellValue("OK/NG");
                using (FileStreamfile = new FileStream(xlsfilename, FileMode.Create))
                {
                    HSSFWorkbook.Write(FileStreamfile);
                };
                }

                
              
          

        }
        #endregion
        #region  语言切换
        string lan =null ;
        private Command_film.MyCommand _SetLanguage;
        public Command_film.MyCommand SetLanguage
        {
            get
            {
                if (_SetLanguage == null)
                    _SetLanguage = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                             if(lan == "en")
                            {
                                lan = "zh";
                            }
                            else
                            {
                                lan = "en";
                            }
                          
                            var res = IoC.Get<IResourceTask>();

                            switch (lan)
                            {
                                case "zh":
                                    res.ChangeLanguage("zh-CN");
                                    break;
                                case "en":
                                    res.ChangeLanguage("en-US");
                                    break;
                            } 
                            
                           

                        }));
                return _SetLanguage;
            }
        }
        public async void ChanguageLanguage(string lan)
        {
           // _eventAggregator.PublishOnUIThread("Hello");
            var res = IoC.Get<IResourceTask>();

            switch (lan)
            {
                case "zh":
                    res.ChangeLanguage("zh-CN");
                    break;
                case "en":
                    res.ChangeLanguage("en-US");
                    break;
            }

        }
        #endregion

        #region  NOTICE
        //private INotificationMessageManager _manager;
        //public INotificationMessageManager Manager
        //{
        //    get;
        //} = new NotificationMessageManager();
        ////this.Manager
        ////     .CreateMessage()
        ////     .Accent("#1751C3")
        ////     .Background("#333")
        ////     .HasBadge("Info")
        ////     .Animates(true)//动画开启
        ////     .AnimationInDuration(0.75)

        ////     .AnimationOutDuration(2)
        ////     .HasMessage("Update will be installed on next application restart.")
        ////     .Dismiss().WithButton("Update now", button => { System.Windows.MessageBox.Show("11"); })
        ////     .Dismiss().WithButton("Release notes", button => { System.Windows.MessageBox.Show("21"); })
        ////     .Dismiss().WithButton("Later", button => { System.Windows.MessageBox.Show("31"); })
        ////     .Dismiss().WithDelay(TimeSpan.FromSeconds(5))
        ////     .Queue();
        ////var content = new NotificationContent { Title = "Notification in window", Message = "Click me!" };
        ////var clickContent = new NotificationContent
        ////{
        ////    Title = "Clicked!",
        ////    Message = "Window notification was clicked!",
        ////    Type = NotificationType.Success
        ////};
        ////_notificationManager.Show(content, "WindowArea", onClick: () => _notificationManager.Show(clickContent));
        //private readonly NotificationManager _notificationManager = new NotificationManager();


        #endregion
        #region FLyOUT
        //private void ToggleFlyout(int index)
        //{
        //    var flyout = this.Flyouts.Items[index] as Flyout;
        //    if (flyout == null)
        //    {
        //        return;
        //    }

        //    flyout.IsOpen = !flyout.IsOpen;
        //}
        #endregion
        private bool visible;
        public bool Visible {
            get { return visible; }
            set
            {
                visible = value;
                // OnPropertyChanged1("Value");
                NotifyOfPropertyChange(() => Visible);

            }
        }
        public ICommand TextBoxButtonCmdWithParameter { get; }
        #region 聚合通知

        #region List收集
        private ObservableCollection<Lib.Xml_helper> xmlItems = new ObservableCollection<Lib.Xml_helper>();
        public ObservableCollection<Lib.Xml_helper> XmlItems
        {
            get
            { return xmlItems; }
            set
            {
                xmlItems = value;
                // OnPropertyChanged("AlarmItems1");
                Notice.Show("Success",
                                    "Data has changed11",
                                    1,
                                    MessageBoxIcon.Success);
                NotifyOfPropertyChange(() => XmlItems);
            }
        }
        private ObservableCollection<Lib.Xml_helper> xmlItems0 = new ObservableCollection<Lib.Xml_helper>();
        public ObservableCollection<Lib.Xml_helper> XmlItems0
        {
            get
            { return xmlItems0; }
            set
            {
                xmlItems0 = value;
                // OnPropertyChanged("AlarmItems1");
                Notice.Show("Success",
                                    "Data has changed11",
                                    1,
                                    MessageBoxIcon.Success);
                NotifyOfPropertyChange(() => XmlItems0);
            }
        }
        #endregion

        public void Handle(ObservableCollection<Lib.Xml_helper> message)
        {
            XmlItems = message;
        }
        public void Handle(bool message)
        {
            levelHandle = message; 
        }
        private bool _levelHandle;
        public bool levelHandle
        {
            get
            {
                return levelHandle;
            }
            set
            {
                _levelHandle = value;
                NotifyOfPropertyChange(() => levelHandle);
            }
        }
        public void Handle(string message)
        {
            OneMessage = message;
        }

        #region Login_level  
        /// <summary>
        /// oneMessage=FM 覆膜平台FLYout
        /// oneMessage=TAB 上下料平台FLYout
        ///  oneMessage=BY 搬运片料平台FLYout
        ///  oneMessage=JL 收料FLYout
        /// </summary>
        string oneMessage;
        public string OneMessage
        {
            get
            {
                return oneMessage;
            }
            set
            {
                oneMessage = value;
                switch (OneMessage)
                {
                    case "FM":
                        Vision = true;
                        break;
                    case "TAB":
                        Vision1 = true;
                        break;
                    case "Vision":
                        Vision2 = true;
                        break;
                    case "Carray":
                        Vision3 = true;
                        break;
                    case "Level0":
                        _Enable = true;
                        break;
                    case "Level1":
                        _Enable1 = true;
                        break;
                    case "Level2":
                        _Enable2 = true;
                        break;
                    case "Cancellation":
                        _Enable = false;
                        _Enable1 = false;
                        _Enable2 = false;
                        break;

                }

                NotifyOfPropertyChange(() => OneMessage);
            }
        }
        private bool enable;
        public bool _Enable
        {
            get
            {
                return enable;
            }
            set
            {
                enable = value;
                NotifyOfPropertyChange(() => _Enable);
            }
        }
        private bool enable1;
        public bool _Enable1
        {
            get
            {
                return enable1;
            }
            set
            {
                enable1 = value;
                NotifyOfPropertyChange(() => _Enable1);
            }
        }
        private bool enable2;
        public bool _Enable2
        {
            get
            {
                return enable2;
            }
            set
            {
                enable2 = value;
                NotifyOfPropertyChange(() => _Enable2);
            }
        }
        private bool vision;
        public bool Vision
        {
            get
            {
                return vision;
            }
            set
            {
                vision = value;
                NotifyOfPropertyChange(() => Vision);
            }
        }
        private bool vision1;
        public bool Vision1
        {
            get
            {
                return vision1;
            }
            set
            {
                vision1 = value;
                NotifyOfPropertyChange(() => Vision1);
            }
        }
        private bool vision2;
        public bool Vision2
        {
            get
            {
                return vision2;
            }
            set
            {
                vision2 = value;
                NotifyOfPropertyChange(() => Vision2);
            }
        }
        private bool vision3;
        public bool Vision3
        {
            get
            {
                return vision3;
            }
            set
            {
                vision3 = value;
                NotifyOfPropertyChange(() => Vision3);
            }
        }
        #endregion
        #endregion
        #region  file_open

        #endregion
        #region MVVM——command
        private Command_film.MyCommand _login;
        public Command_film.MyCommand login
        {
            get
            {
                if (_login == null)
                    _login = new Command_film.MyCommand(
                        new Action<object>(
                        async e =>
                            {
                                Lib.Repice_Xml repice_Xml = new Lib.Repice_Xml();
                                //await repice_Xml.Xml_Read();
                                XmlItems0 = repice_Xml.XmlItems;
                                _eventAggregator.PublishOnUIThread(XmlItems0);

                                Notice.Show("Success",
                                       "Publish Success",
                                       1,
                                       MessageBoxIcon.Success);

                             
                              
                                


                            }));
                return _login;
            }
        }

        private Command_film.MyCommand _cheakin;
        public Command_film.MyCommand CheakIn
        {
            get
            {
                if (_cheakin == null)
                    _cheakin = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {

                            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                            dlg.FileName = ""; // Default file name
                            dlg.DefaultExt = ".xml";  // Default file extension
                            dlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* "; // Filter files by extension
                                                                                   // Show open file dialog box
                            Nullable<bool> result = dlg.ShowDialog();
                            // Process open file dialog box results
                            if (result == true)
                            {

                                string filename = dlg.FileName;
                                XDocument xDocument = new XDocument();
                                XElement xElement = XElement.Load(filename);
                                IEnumerable<XElement> xElements = from p in xElement.Descendants("Asix")
                                                                  where (string)p.Element("ID") == User_Name && (string)p.Element("POsition0") == password
                                                                  select p;
                                foreach (XElement p in xElements) {
                                 if (p != null)
                                {

                                  
                                    Notice.Show("Success",
                               xElements.ToString(),
                                3,
                                MessageBoxIcon.Success);
                                }
                                }
                                   
                            }





                        }));
                return _cheakin;
            }
        }

        //public ICommand command { get; }= new Command_film.MyCommand(e =>
        private string password;
        public void MyClick(object str, string str2)
        {
            if (str is PasswordBox passwordBox)
            {
                password = passwordBox.Password;
                ////await((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("PasswordBox Button was clicked1111!", passwordBox.Password);
                

            }
        }

        #endregion
        #region them
        PaletteHelper paletteHelper; ITheme theme;
        public ICommand ToggleBaseCommand { get; }
        private void ApplyBase(bool isDark)
        {
            theme = paletteHelper.GetTheme();
            IBaseTheme baseTheme = isDark ? new MaterialDesignDarkTheme() : (IBaseTheme)new MaterialDesignLightTheme();
            theme.SetBaseTheme(baseTheme);
            paletteHelper.SetTheme(theme);
        }
        private Command_film.MyCommand _buttonThem0Command;
        public Command_film.MyCommand ButtonThem0Command
        {
            get
            {
                if (_buttonThem0Command == null)
                    _buttonThem0Command = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            try
                            {
                                // Lib.Repice_Xml repice_Xml = new Lib.Repice_Xml();
                                //await repice_Xml.Xml_Creat();

                                theme = paletteHelper.GetTheme();

                                theme.SetBaseTheme(MaterialDesignThemes.Wpf.Theme.Light);
                                //or theme.SetBaseTheme(Theme.Light);

                                //Change all of the primary colors to Red
                                theme.SetPrimaryColor(Colors.Green);

                                //Change all of the secondary colors to Blue
                                theme.SetSecondaryColor(Colors.Yellow);

                                //You can also change a single color on the theme, and optionally set the corresponding foreground color
                                theme.PrimaryMid = new ColorPair(Colors.Brown, Colors.White);

                                paletteHelper.SetTheme(theme);
                                Notice.Show("Success",
                                  "Them0 Success",
                                  1,
                                  MessageBoxIcon.Success);
                            }
                            catch (Exception f)
                            {
                                Notice.Show("Error",
                                   f.ToString(),
                                   10,
                                   MessageBoxIcon.Error);
                            }
                        }));
                return _buttonThem0Command;
            }
        }
        private Command_film.MyCommand _buttonThem1Command;
        public Command_film.MyCommand ButtonThem1Command
        {
            get
            {
                if (_buttonThem1Command == null)
                    _buttonThem1Command = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            try
                            {
                                theme = paletteHelper.GetTheme();

                                theme.SetBaseTheme(MaterialDesignThemes.Wpf.Theme.Light);
                                //or theme.SetBaseTheme(Theme.Light);

                                //Change all of the primary colors to Red
                                theme.SetPrimaryColor(Colors.Red);

                                //Change all of the secondary colors to Blue
                                theme.SetSecondaryColor(Colors.Gold);

                                //You can also change a single color on the theme, and optionally set the corresponding foreground color
                                theme.PrimaryMid = new ColorPair(Colors.Brown, Colors.White);



                                paletteHelper.SetTheme(theme);
                                Notice.Show("Success",
                                       "Them1 Success",
                                       1,
                                       MessageBoxIcon.Success);
                            }
                            catch (Exception f)
                            {
                                Notice.Show("Error",
                                   f.ToString(),
                                   10,
                                   MessageBoxIcon.Error);
                            }
                        }));
                return _buttonThem1Command;
            }
        }

        #endregion

        #region "flyout程序设定"
        //public FlyoutsControl Flyouts { get;  set; }
        //private void ToggleFlyout(int index)
        //{
        //    var flyout =  Flyouts.Items[index] as Flyout;
        //    if (flyout == null)
        //    {
        //        return;
        //    }

        //    flyout.IsOpen = !flyout.IsOpen;
        //}

        #endregion
    }
}
