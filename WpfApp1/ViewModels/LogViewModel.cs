using System;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Collections;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using Panuon.UI.Silver;
using System.Collections.ObjectModel;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Collections.Generic;
using System.Windows.Input;
using WpfApp1.Lib;
using System.IO;
using System.Text;
using System.Windows.Controls;

namespace WpfApp1.ViewModels
{
    class LogViewModel : Screen, INotifyPropertyChanged,IHandle<string>
    {
        
        private readonly IEventAggregator _eventAggregator;
        public LogViewModel()
        {
            AddAlarmItem(new Lib.Alm(2, DateTime.Now.ToString(), "急停按下"));
            _eventAggregator = IoC.Get<IEventAggregator>();
            _eventAggregator.Subscribe(this);
            this.Runlog = new Command_film.password_button(
                o => true,
                 x => {
                     MessageBox.Show(x.ToString());

                 }
            );
          
        }

        public void Handle(string message)
        {
            OneMessage = message;
        }
        #region Login_level  
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
        #endregion

        private Command_film.MyCommand _login;
        public Command_film.MyCommand login
        {
            get
            {
                if (_login == null)
                    _login = new Command_film.MyCommand(
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
                                Task.Run(() =>
                                {
                                    while (true)
                                    {
                                        using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                                        {
                                            using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
                                            {
                                                StringBuilder sb = new StringBuilder();
                                                while (!sr.EndOfStream)
                                                {
                                                    sb.AppendLine(sr.ReadLine() + "<br>");
                                                }
                                                Document = sb.ToString();
                                            }
                                        }
                                        Thread.Sleep(1000); ;
                                    }


                                });

                            }

                        }));
                return _login;
            }
        }
        #region  LOG

        private List<string> errorlog1 = new List<string>();
        public List<string> Errorlog1
        {
            get
            {
                return errorlog1;
            }
            set
            {
                errorlog1 = value;
                NotifyOfPropertyChange(() => Errorlog1);
            }
        }
        private Command_film.MyCommand _Errorlog;
        public Command_film.MyCommand Errorlog
        {
            get
            {
                if (_Errorlog == null)
                    _Errorlog = new Command_film.MyCommand(
                        new Action<object>(
                     async e =>
                     {
                         await Taskdebuglog();
                         await TaskErrorlog();
                         await TaskRunlog();
                         MessageBox.Show("加载完成");
                         //Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                         //dlg.FileName = ""; // Default file name
                         //dlg.DefaultExt = ".xml";  // Default file extension
                         //dlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* "; // Filter files by extension
                         //                                                       // Show open file dialog box
                         //Nullable<bool> result = dlg.ShowDialog();
                         //// Process open file dialog box results
                         //if (result == true)
                         //{
                         //    string filename = System.IO.Path.GetDirectoryName(dlg.FileName);
                         //    DirectoryInfo folder = new DirectoryInfo(filename);

                         //    foreach (FileInfo file in folder.GetFiles("*.txt"))
                         //    {
                         //        Errorlog1.Add(System.IO.Path.GetFileNameWithoutExtension(file.FullName));
                         //        AddLogtexts(new Logtext(System.IO.Path.GetFileNameWithoutExtension(file.FullName),
                         //                                                file.FullName));
                         //    }
                         //}
                         //Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                         //dlg.FileName = ""; // Default file name
                         //dlg.DefaultExt = ".xml";  // Default file extension
                         //dlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* "; // Filter files by extension
                         //                                                       // Show open file dialog box
                         //Nullable<bool> result = dlg.ShowDialog();
                         //// Process open file dialog box results
                         //if (result == true)
                         //{
                         //    Growl.Success("成功");
                         //    string filename = dlg.FileName;
                         //    XDocument xDocument = new XDocument();
                         //    XElement xElement = XElement.Load(filename);
                         //    IEnumerable<XElement> xElements = from p in xElement.Descendants("Asix")
                         //                                      where (string)p.Element("ID") == "1"&&(string)p.Element("POsition0") == "150"
                         //                                      select p;
                         //    if (xElements != null)
                         //    {

                         //         _eventAggregator.PublishOnUIThread("Level0"); 
                         Notice.Show("Success",
                     "Notice",
                     3,
                     MessageBoxIcon.Success);
                         //    }

                         //}


                     }));
                return _Errorlog;
            }
        }
        public ICommand Runlog
        {
            get;

        }

        private Command_film.MyCommand _Debuglog;
        public Command_film.MyCommand Debuglog
        {
            get
            {
                if (_Debuglog == null)
                    _Debuglog = new Command_film.MyCommand(
                        new Action<object>(
                         e =>
                         {

                             //MessageBox.Show(e.ToString());
                         }));
                return _Debuglog;
            }
        }
        #endregion
        #region List收集
        private ObservableCollection<Lib.Alm> alarmItems = new ObservableCollection<Lib.Alm>();
        public ObservableCollection<Lib.Alm> AlarmItems
        {
            get
            { return alarmItems; }
            set
            {
                alarmItems = value;
                // OnPropertyChanged("AlarmItems");

                NotifyOfPropertyChange(() => AlarmItems);
            }
        }



        private void AddAlarmItem(Lib.Alm t)
        {
            foreach (Lib.Alm item in AlarmItems)
            {
                if (item.ID == t.ID) return;
            }
            AlarmItems.Add(t);
        }
        #endregion
        #region Richbox 
        #region richbox_field
        private string document;
        public string Document
        {
            get
            {
                return document;
            }
            set
            {
                document = value;
                NotifyOfPropertyChange(() => Document);
            }
        }
        #endregion
        #region Error Collection
        private ObservableCollection<Lib.Logtext> logtexts = new ObservableCollection<Logtext>();
        public ObservableCollection<Logtext> Logtexts
        {
            get
            { return logtexts; }
            set
            {
                logtexts = value;
                // OnPropertyChanged("AlarmItems");

                NotifyOfPropertyChange(() => Logtexts);
            }
        }
        private int index;
        public int Index
        {
            get
            { return index; }
            set
            {
                index = value;
                // OnPropertyChanged("AlarmItems");

                NotifyOfPropertyChange(() => Index);
            }
        }
        private void AddLogtexts(Lib.Logtext t)
        {
            foreach (Lib.Logtext item in Logtexts)
            {
                if (item.Name == t.Name) return;
            }
            Logtexts.Insert(0, t);
        }
        #endregion
        #region Run Collection
        private ObservableCollection<Lib.Logtext> logtexts_run = new ObservableCollection<Logtext>();
        public ObservableCollection<Logtext> Logtexts_run
        {
            get
            { return logtexts_run; }
            set
            {
                logtexts_run = value;
                // OnPropertyChanged("AlarmItems");

                NotifyOfPropertyChange(() => Logtexts_run);
            }
        }
        private int index_run;
        public int Index_run
        {
            get
            { return index_run; }
            set
            {
                index_run = value;
                // OnPropertyChanged("AlarmItems");

                NotifyOfPropertyChange(() => Index_run);
            }
        }
        private void AddLogtexts_Run(Lib.Logtext t)
        {
            foreach (Lib.Logtext item in Logtexts_run)
            {
                if (item.Name == t.Name) return;
            }
            Logtexts_run.Insert(0, t);
        }
        #endregion
        #region debug Collection
        private ObservableCollection<Lib.Logtext> logtexts_debug = new ObservableCollection<Logtext>();
        public ObservableCollection<Logtext> Logtexts_debug
        {
            get
            { return logtexts_debug; }
            set
            {
                logtexts_debug = value;
                // OnPropertyChanged("AlarmItems");

                NotifyOfPropertyChange(() => Logtexts_debug);
            }
        }
        private int index_debug;
        public int Index_debug
        {
            get
            { return index_debug; }
            set
            {
                index_debug = value;
                // OnPropertyChanged("AlarmItems");

                NotifyOfPropertyChange(() => Index_debug);
            }
        }
        private void AddLogtexts_Debug(Lib.Logtext t)
        {
            foreach (Lib.Logtext item in Logtexts_debug)
            {
                if (item.Name == t.Name) return;
            }
            Logtexts_debug.Insert(0, t);
        }
        #endregion
        #region Errorlog
        private async Task TaskErrorlog()
        {

            string filename = "Log/LogError";
            DirectoryInfo folder = new DirectoryInfo(filename);

            foreach (FileInfo file in folder.GetFiles("*.txt"))
            {

                AddLogtexts(new Logtext(System.IO.Path.GetFileNameWithoutExtension(file.FullName),
                                                        file.FullName));
            }


        }
        #endregion
        #region runlog
        private async Task TaskRunlog()
        {
            //  string filename = System.IO.Path.GetDirectoryName(dlg.FileName);
            string filename = "Log/Logrun";
            DirectoryInfo folder = new DirectoryInfo(filename);

            foreach (FileInfo file in folder.GetFiles("*.txt"))
            {

                AddLogtexts_Run(new Lib.Logtext(System.IO.Path.GetFileNameWithoutExtension(file.FullName),
                                                        file.FullName));
            }
        }

        #endregion
        #region debuglog
        private async Task Taskdebuglog()
        {
            //string filename = System.IO.Path.GetDirectoryName(dlg.FileName);
            string filename = "Log/LogInfo";
            DirectoryInfo folder = new DirectoryInfo(filename);

            foreach (FileInfo file in folder.GetFiles("*.txt"))
            {

                AddLogtexts_Debug(new Lib.Logtext(System.IO.Path.GetFileNameWithoutExtension(file.FullName),
                                                        file.FullName));
            }

        }

        #endregion
        #region  file_read
        private async Task FileLogRead(string filename)
        {
            await Task.Run(async () =>
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
                    {
                        StringBuilder sb = new StringBuilder();
                        while (!sr.EndOfStream)
                        {
                            sb.AppendLine(await sr.ReadToEndAsync());
                        }
                        Document = sb.ToString();
                    }
                }

            });
        }
        private async Task<int> FileLogRead1(string filename)
        {
            await Task.Run(async () =>
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default))
                    {
                        StringBuilder sb = new StringBuilder();
                        while (!sr.EndOfStream)
                        {
                            sb.AppendLine(sr.ReadLine());
                        }
                        Document = sb.ToString();
                    }
                }

            }); return 1;
        }
        #endregion
        #region Rich_box Command
        private Command_film.MyCommand _RecipeCbxSelectionChanged;
        public Command_film.MyCommand RecipeCbxSelectionChanged
        {
            get
            {
                if (_RecipeCbxSelectionChanged == null)
                    _RecipeCbxSelectionChanged = new Command_film.MyCommand(
                        new Action<object>(
                         async e =>
                         {

                             if (Logtexts.Count == 0)
                             {
                                 Notice.Show("Warn",
                                 "No Error File",
                                 15,
                                 MessageBoxIcon.Warning);
                                 Log_Helper.Log_Info("未找到日志文件，" +
                                    "检查问价存储位置是否正确");
                             }
                             else
                             {
                                 try
                                 {
                                     string filename = Logtexts[Index].Path_Name;
                                     var controller = await ((MetroWindow)Application.Current.MainWindow).ShowProgressAsync("Please wait...", "File reading");
                                     controller.SetIndeterminate();
                                     await Task.Delay(100);
                                     await FileLogRead(filename);

                                     await controller.CloseAsync();

                                 }
                                 catch (Exception error)
                                 {
                                     Notice.Show("File Read Fail",
                                      "Error",
                                      150,
                                      MessageBoxIcon.Error);
                                     Log_Helper.Log_Error("", error);
                                 }


                 ;

                             }
                         }));
                return _RecipeCbxSelectionChanged;
            }
        }
        private Command_film.MyCommand _RecipeCbxSelectionChanged1;
        public Command_film.MyCommand RecipeCbxSelectionChanged1
        {
            get
            {
                if (_RecipeCbxSelectionChanged1 == null)
                    _RecipeCbxSelectionChanged1 = new Command_film.MyCommand(
                        new Action<object>(
                        async e =>
                        {

                            if (Logtexts_debug.Count == 0)
                            {
                                Notice.Show("File Read Fail",
                                    "Error",
                                    150,
                                    MessageBoxIcon.Error);
                                Log_Helper.Log_Info("未找到日志文件，" +
                                    "检查问价存储位置是否正确");
                            }
                            else
                            {
                                try
                                {
                                    string filename = Logtexts_debug[Index_debug].Path_Name;
                                    var controller = await ((MetroWindow)Application.Current.MainWindow).ShowProgressAsync("Please wait...", "File reading");
                                    controller.SetIndeterminate();
                                    await Task.Delay(100);
                                    await FileLogRead(filename);

                                    await controller.CloseAsync();
                                }
                                catch (Exception error)
                                {
                                    Notice.Show("File Read Fail",
                                    "Error",
                                    150,
                                    MessageBoxIcon.Error);
                                    Log_Helper.Log_Error("", error);
                                }
                            }
                    ;

                        }));
                return _RecipeCbxSelectionChanged1;
            }
        }
        private Command_film.MyCommand _RecipeCbxSelectionChanged2;
        public Command_film.MyCommand RecipeCbxSelectionChanged2
        {
            get
            {
                if (_RecipeCbxSelectionChanged2 == null)
                    _RecipeCbxSelectionChanged2 = new Command_film.MyCommand(
                        new Action<object>(
                         async e =>
                         {

                             if (Logtexts_debug.Count == 0)
                             {
                                 Notice.Show("Warn",
                               "No Error File",
                               15,
                               MessageBoxIcon.Warning);
                                 Log_Helper.Log_Info("未找到日志文件，" +
                                     "检查问价存储位置是否正确");
                             }
                             else
                             {
                                 try
                                 {


                                     string filename = Logtexts_run[Index_run].Path_Name;
                                     var controller = await ((MetroWindow)Application.Current.MainWindow).ShowProgressAsync("Please wait...", "File reading");
                                     controller.SetIndeterminate();
                                     await Task.Delay(100);
                                     await FileLogRead(filename);

                                     await controller.CloseAsync();


                                 }
                                 catch (Exception error)
                                 {
                                     Notice.Show("Error",
                                      "File Read Fail",
                                      150,
                                      MessageBoxIcon.Warning);
                                     Log_Helper.Log_Error("", error);

                                 }


                             }
                    ;

                         }));
                return _RecipeCbxSelectionChanged2;
            }
        }
        private Command_film.MyCommand _RecipeCbxSelectionChanged3;
        public Command_film.MyCommand RecipeCbxSelectionChanged3
        {
            get
            {
                if (_RecipeCbxSelectionChanged3 == null)
                    _RecipeCbxSelectionChanged3 = new Command_film.MyCommand(
                        new Action<object>(
                         async e =>
                         {

                             if (Logtexts_debug.Count == 0)
                             {
                                 Notice.Show("Warn",
                               "No Error File",
                               15,
                               MessageBoxIcon.Warning);
                                 Log_Helper.Log_Info("未找到日志文件，" +
                                     "检查问价存储位置是否正确");
                             }
                             else
                             {
                                 try
                                 {

                                     double i = 0.0;
                                     StringBuilder sb = new StringBuilder();

                                     await Task.Run(() =>
                                     {
                                         while (Isenable)
                                         {
                                             i++;
                                             sb.AppendLine("2020-02-20 16:22:12,840 [1] ERROR logerror" + "\r\n" +
                                                  i.ToString());
                                             Thread.Sleep(1000); Document = sb.ToString();
                                         }


                                     }

                                      );






                                 }
                                 catch (Exception error)
                                 {
                                     Notice.Show("Error",
                                      "File Read Fail",
                                      150,
                                      MessageBoxIcon.Warning);
                                     Log_Helper.Log_Error("", error);

                                 }


                             }
                    ;

                         }));
                return _RecipeCbxSelectionChanged3;
            }
        }
        private async void ShowProgressDialog(object sender, RoutedEventArgs e)
        {
            var mySettings = new MetroDialogSettings()
            {
                NegativeButtonText = "Close now",
                AnimateShow = false,
                AnimateHide = false
            };


            var controller = await ((MetroWindow)Application.Current.MainWindow).ShowProgressAsync("Please wait...", "We are baking some cupcakes!", settings: mySettings);
            controller.SetIndeterminate();

            await Task.Delay(5000);

            controller.SetCancelable(true);

            double i = 0.0;
            while (i < 6.0)
            {
                double val = (i / 100.0) * 20.0;
                controller.SetProgress(val);
                controller.SetMessage("Baking cupcake: " + i + "...");

                if (controller.IsCanceled)
                    break; //canceled progressdialog auto closes.

                i += 1.0;

                await Task.Delay(2000);
            }

            await controller.CloseAsync();

            if (controller.IsCanceled)
            {
                await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("No cupcakes!", "You stopped baking!");
            }
            else
            {
                await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("Cupcakes!", "Your cupcakes are finished! Enjoy!");
            }
        }
        private Command_film.MyCommand _RecipeCbxDropDownOpened;
        public Command_film.MyCommand RecipeCbxDropDownOpened
        {
            get
            {
                if (_RecipeCbxDropDownOpened == null)
                    _RecipeCbxDropDownOpened = new Command_film.MyCommand(
                        new Action<object>(
                         async e =>
                         {

                             await Taskdebuglog();
                             await TaskErrorlog();
                             await TaskRunlog();
                             Index = 0;
                             Index_debug = 0;
                             Index_run = 0;

                         }));
                return _RecipeCbxDropDownOpened;
            }
        }
        private bool isenable;
        public bool Isenable
        {
            get
            { return isenable; }
            set
            {
                isenable = value;
                NotifyOfPropertyChange(() => Isenable);
            }
        }
        private Command_film.MyCommand _RecipeCbxDropDownOpened1;
        public Command_film.MyCommand RecipeCbxDropDownOpened1
        {
            get
            {
                if (_RecipeCbxDropDownOpened1 == null)
                    _RecipeCbxDropDownOpened1 = new Command_film.MyCommand(
                        new Action<object>(
                         e =>
                         {
                             Isenable = !Isenable;

                         }));
                return _RecipeCbxDropDownOpened1;
            }
        }



        public void MyClick2(object str, string str2)
        {
            if (str is RichTextBox richTextBox)

            {
                richTextBox.ScrollToEnd();
            }
            else
                MessageBox.Show("2");
        }
        #endregion
        #endregion

    }




}

