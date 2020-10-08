using Caliburn.Micro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using Panuon.UI.Silver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    [Export("MonitoringViewModel",typeof(MonitoringView))]
    class MonitoringViewModel : Screen, INotifyPropertyChanged,IHandle<string>, IHandle<ObservableCollection<Lib.Xml_helper>>
    {
    // //   public event PropertyChangedEventHandler PropertyChanged;
    //    protected virtual void OnPropertyChanged(string propertyName = null)
    //    {
    //        if (PropertyChanged != null)
    //            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
        #region List收集
        private ObservableCollection<Lib.Alm> alarmItems = new ObservableCollection<Lib.Alm>();
        public ObservableCollection<Lib.Alm> AlarmItems { 
            get {
             return alarmItems; 
            } 
            set {
                alarmItems = value;
               // OnPropertyChanged("AlarmItems");
               
                NotifyOfPropertyChange(() => AlarmItems);
            } }

        #endregion
        
        private void AddAlarmItem(Lib.Alm t)
        {
            foreach (Lib.Alm item in AlarmItems)
            {
                if (item.ID == t.ID) return;
            }
            AlarmItems.Add(t);
        }
        public IEnumerable<Swatch> Swatches { get; }
        private readonly IEventAggregator _eventAggregator;
     
        public MonitoringViewModel()

        {
            
            _eventAggregator = IoC.Get<IEventAggregator>();
            _eventAggregator.Subscribe(this);
            Swatches = new SwatchesProvider().Swatches;
            AddAlarmItem(new Lib.Alm(2, DateTime.Now.ToString(), "急停按下"));
            //Task.Run(() => {
            //    while (true) {
                   
            //        if (FH_V1)
            //        {
            //            FH_U = new Random(Chaos_GetRandomSeed()).Next(1, 2).ToString();/*Lib.Connect_Plc.plcitems.FH_U.ToString()*/
            //            FH_V = new Random(Chaos_GetRandomSeed()).Next(3, 4).ToString(); /* Lib.Connect_Plc.plcitems.FH_V.ToString() */
            //            FH_W = new Random(Chaos_GetRandomSeed()).Next(5, 6).ToString(); /*Lib.Connect_Plc.plcitems.FH_W.ToString()*/
            //            Tab_U = new Random(Chaos_GetRandomSeed()).Next(7, 8).ToString(); /*Lib.Connect_Plc.plcitems.Tab_U.ToString()*/
            //            Tab_V = new Random(Chaos_GetRandomSeed()).Next(9, 10).ToString();/*Lib.Connect_Plc.plcitems.Tab_V.ToString()*/
            //            Tab_W = new Random(Chaos_GetRandomSeed()).Next(11, 12).ToString();/*Lib.Connect_Plc.plcitems.Tab_W.ToString()*/
            //            //FH_V1 = false;
            //        }
            //        Thread.Sleep(500);
                
            //    }
            
            //});
        }

        private static int Chaos_GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        int i = 0;
        private Command_film.MyCommand _Add;
        public Command_film.MyCommand _add
        {
            get
            {
                if (_Add == null)
                    _Add = new Command_film.MyCommand(
                        new Action<object>(
                            e =>
                            {
                                //FH_U = new Random().Next(1, 2).ToString();/*Lib.Connect_Plc.plcitems.FH_U.ToString()*/
                                //FH_V = new Random().Next(3, 4).ToString(); /* Lib.Connect_Plc.plcitems.FH_V.ToString() */
                                //FH_W = new Random().Next(5, 6).ToString(); /*Lib.Connect_Plc.plcitems.FH_W.ToString()*/
                                //Tab_U = new Random().Next(7, 8).ToString(); /*Lib.Connect_Plc.plcitems.Tab_U.ToString()*/
                                //  Tab_V = new Random().Next(9, 10).ToString();/*Lib.Connect_Plc.plcitems.Tab_V.ToString()*/
                                //Tab_W = new Random().Next(11, 12).ToString();/*Lib.Connect_Plc.plcitems.Tab_W.ToString()*/
                                ////i++;
                                ////AlarmItems.Insert(0,new Lib.Alm(i, DateTime.Now.ToString(), i.ToString()));
                                FH_V1 = !FH_V1;
                            }));
                return _Add;
            }
        }
        private bool fH_V1;
        public bool FH_V1
        {
            get
            {
                return fH_V1;
            }
            set
            {
                fH_V1 = value;
                NotifyOfPropertyChange(() => FH_V1);
            }
        }

        #region"XLS数据读写"
        #region 字段声明 
        bool i1 = true;
        private string fH_U;
        public string FH_U
        {
            get
            {
                return fH_U;
            }
            set
            {

                if (value != FH_U && fH_U != "0")
                {
                    Xls_write(0, FH_U);

                }


                fH_U = value;
                NotifyOfPropertyChange(() => FH_U);
            }
        }
        private string fH_V;
        public string FH_V
        {
            get
            {
                return fH_V;
            }
            set
            {
                if(value != FH_V && fH_V != "0") 
                { 
                    Xls_write(1, FH_U);
                }
                fH_V = value;
                NotifyOfPropertyChange(() => FH_V);
            }
        }
        private string fH_W;
        public string FH_W
        {
            get
            {
                return fH_W;
            }
            set
            {
                if (value != FH_W && fH_W != "0")
                { 
                    Xls_write(2, FH_U);
                    
                }
               
                fH_W = value;
                NotifyOfPropertyChange(() => FH_W);
            }
        }
        private string tab_U;
        public string Tab_U
        {
            get
            {
                return tab_U;
            }
            set
            {
                if (value != Tab_U && tab_U != "0")
                {
                    
Xls_write(3, FH_U);
                }
                tab_U = value;
                NotifyOfPropertyChange(() => Tab_U);
                
            }
        }
        private string tab_V;
        public string Tab_V
        {
            get
            {
                return tab_V;
            }
            set
            {
                if (value != Tab_V && tab_V != "0")
                {
                Xls_write(4, FH_U);
                  
                }
                tab_V = value;
                NotifyOfPropertyChange(() => Tab_V);
                
            }
        }
        private string tab_W;
        public string Tab_W
        {
            get
            {
                return tab_W;
            }
            set
            {
                if (value != Tab_W && tab_W != "0")
                {
                    Xls_write(5, FH_U);

                }
                tab_W = value;
                NotifyOfPropertyChange(() => Tab_W);
               
            }
        }
        private string jg;
        public string JG
        {
            get
            {
                return jg;
            }
            set
            {
                jg = value;
                NotifyOfPropertyChange(() => JG);
            }
        }
        #endregion
        //#region Command_par
        //private Command_film.MyCommand _command0;
        //public Command_film.MyCommand Command0
        //{
        //    get
        //    {
        //        if (_command0 == null)
        //            _command0 = new Command_film.MyCommand(
        //                new Action<object>(
        //                async e =>
        //                    {
        //                        try
        //                        {
        //                            //FH_U = (new Random().Next(1, 5) / 2.1).ToString("F3");
        //                            //await Xls_write(0, FH_U);

        //                            Notice.Show("Success",
        //                                          e.ToString(),
        //                                          2,
        //                                         MessageBoxIcon.Success);
        //                        }
        //                        catch (Exception f)
        //                        {
        //                            Notice.Show("Error",
        //                               f.ToString(),
        //                               10,
        //                               MessageBoxIcon.Error);
        //                        }


        //                    }));
        //        return _command0;
        //    }
        //}
        //private Command_film.MyCommand _command1;
        //public Command_film.MyCommand Command1
        //{
        //    get
        //    {
        //        if (_command1 == null)
        //            _command1 = new Command_film.MyCommand(
        //                new Action<object>(
        //                async e =>
        //                    {
        //                        //Tab_U = new Random().Next(1, 5).ToString();
        //                        try
        //                        {
        //                            //Tab_U = (new Random().Next(1, 5) / 2.1).ToString("F3");
        //                            //await Xls_write(1, Tab_U);

        //                            Notice.Show("Success",
        //                                       "1111",
        //                                          2,
        //                                         MessageBoxIcon.Success);
        //                        }
        //                        catch (Exception f)
        //                        {
        //                            Notice.Show("Error",
        //                               f.ToString(),
        //                               10,
        //                               MessageBoxIcon.Error);
        //                        }

        //                    }));
        //        return _command1;
        //    }
        //}
        //private Command_film.MyCommand _command2;
        //public Command_film.MyCommand Command2
        //{
        //    get
        //    {
        //        if (_command2 == null)
        //            _command2 = new Command_film.MyCommand(
        //                new Action<object>(
        //               async     e =>
        //                    {

        //                        try
        //                        {
        //                            FH_V = (new Random().Next(1, 5) / 2.1).ToString("F3");
        //                        await    Xls_write(2, FH_V);

        //                            Notice.Show("Success",
        //                                        "Excel File Creat Success",
        //                                          2,
        //                                         MessageBoxIcon.Success);
        //                        }
        //                        catch (Exception f)
        //                        {
        //                            Notice.Show("Error",
        //                               f.ToString(),
        //                               10,
        //                               MessageBoxIcon.Error);
        //                        }
        //                    }));
        //        return _command2;
        //    }
        //}
        //private Command_film.MyCommand _command3;
        //public Command_film.MyCommand Command3
        //{
        //    get
        //    {
        //        if (_command3 == null)
        //            _command3 = new Command_film.MyCommand(
        //                new Action<object>(
        //               async     e =>
        //                    {
        //                        //Tab_V = new Random().Next(1, 5).ToString();
        //                        try
        //                        {
        //                            Tab_V = (new Random().Next(1, 5) / 2.1).ToString("F3");
        //                     await       Xls_write(3, Tab_V);

        //                            Notice.Show("Success",
        //                                        "Excel File Creat Success",
        //                                          2,
        //                                         MessageBoxIcon.Success);
        //                        }
        //                        catch (Exception f)
        //                        {
        //                            Notice.Show("Error",
        //                               f.ToString(),
        //                               10,
        //                               MessageBoxIcon.Error);
        //                        }
        //                    }));
        //        return _command3;
        //    }
        //}
        //private Command_film.MyCommand _command4;
        //public Command_film.MyCommand Command4
        //{
        //    get
        //    {
        //        if (_command4 == null)
        //            _command4 = new Command_film.MyCommand(
        //                new Action<object>(
        //                 async   e =>
        //                    {
        //                        try
        //                        {
        //                            FH_W = (new Random().Next(1, 5) / 2.1).ToString("F3");
        //                        await    Xls_write(4, FH_W);

        //                            Notice.Show("Success",
        //                                        "Excel File Creat Success",
        //                                          2,
        //                                         MessageBoxIcon.Success);
        //                        }
        //                        catch (Exception f)
        //                        {
        //                            Notice.Show("Error",
        //                               f.ToString(),
        //                               10,
        //                               MessageBoxIcon.Error);
        //                        }
        //                    }));
        //        return _command4;
        //    }
        //}
        //private Command_film.MyCommand _command5;
        //public Command_film.MyCommand Command5
        //{
        //    get
        //    {
        //        if (_command5 == null)
        //            _command5 = new Command_film.MyCommand(
        //                new Action<object>(
        //                 async   e =>
        //                    {
        //                        try
        //                        {
        //                            Tab_W = (new Random().Next(1, 5) / 2.1).ToString("F3");
        //                          await  Xls_write(5, Tab_W);

        //                            Notice.Show("Success",
        //                                        "Excel File Creat Success",
        //                                          2,
        //                                         MessageBoxIcon.Success);
        //                        }
        //                        catch (Exception f)
        //                        {
        //                            Notice.Show("Error",
        //                               f.ToString(),
        //                               10,
        //                               MessageBoxIcon.Error);
        //                        }
        //                    }));
        //        return _command5;
        //    }
        //}
        //private Command_film.MyCommand _command6;
        //public Command_film.MyCommand Command6
        //{
        //    get
        //    {
        //        if (_command6 == null)
        //            _command6 = new Command_film.MyCommand(
        //                new Action<object>(
        //                async    e =>
        //                    {
        //                        try
        //                        {
        //                            JG =( new Random().Next(1, 5) / 2.1).ToString("F3");
        //                        await   Xls_write(6, JG);

        //                            Notice.Show("Success",
        //                                        "Excel File Creat Success1111",
        //                                          2,
        //                                         MessageBoxIcon.Success);
        //                        }
        //                        catch (Exception f)
        //                        {
        //                            Notice.Show("Error",
        //                               f.ToString(),
        //                               10,
        //                               MessageBoxIcon.Error);
        //                        }
        //                    }));
        //        return _command6;
        //    }
        //}
        //private Command_film.MyCommand _command7;
        //public Command_film.MyCommand Command7
        //{
        //    get
        //    {
        //        if (_command7 == null)
        //            _command7 = new Command_film.MyCommand(
        //                new Action<object>(
        //                 async   e =>
        //                    {
        //                        await xls_creat();
        //                        Notice.Show("Success",
        //                               "Excel File Creat Success",
        //                               1,
        //                               MessageBoxIcon.Success);
        //                    }));
        //        return _command7;
        //    }
        //}
        //#endregion
        HSSFWorkbook HSSFWorkbook;
        HSSFWorkbook HSSFWorkbook_re;
        private FileStream FileStreamfile;
        string xlsfilename;
        private async Task xls_creat()
        {

            await Task.Run(async () =>
            {

                HSSFWorkbook = new HSSFWorkbook();
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "NPOI Team";
                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Subject = "NPOI SDK Example";
                HSSFWorkbook.DocumentSummaryInformation = dsi;
                HSSFWorkbook.SummaryInformation = si;
                ISheet hSSFSheet = HSSFWorkbook.CreateSheet("sheet1");
                xlsfilename = DateTime.Now.ToString("D") + "text.xls";
                if (File.Exists(xlsfilename))
                {
                    //System.Windows.MessageBox.Show("该表已经存在");
                    await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("Wow, you typed Return and got", "该表已经存在");
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

               
            });

        }
        string str1 = null;
        private void  Xls_write(int column_index,string data)
        {
            
            string str = "H:/B11_Log/Wpf_notice - 副本/WpfApp1/bin/Debug/excel/" + DateTime.Now.ToString("D") + ".xls";
            //Task.Run(() =>
            //{
            //if (data != str1) {
                using (FileStream file = new FileStream(str, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    HSSFWorkbook_re = new HSSFWorkbook(file);//获取读取的文件
                    ISheet sheet = HSSFWorkbook_re.GetSheetAt(0);//读取第一个文档
                    int cellRows = sheet.LastRowNum;//读取最大行数 
                    ICell reult = sheet.GetRow(cellRows).GetCell(column_index);
                    IRow rows_frist = sheet.GetRow(cellRows);
                    ICellStyle HSSFCellStylecellStyle = HSSFWorkbook_re.CreateCellStyle();
                    HSSFCellStylecellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.000");
                    if (reult == null)
                    {
                        ICellStyle cell_style = rows_frist.CreateCell(column_index).CellStyle;
                        rows_frist.CreateCell(column_index).SetCellValue(data);
                        cell_style = HSSFCellStylecellStyle;
                    }
                    else if (reult != null)
                    {
                        var cellrows1 = cellRows + 1;
                        IRow rows = sheet.CreateRow(cellrows1);
                        ICellStyle cell_style = rows.CreateCell(column_index).CellStyle;
                        cell_style = HSSFCellStylecellStyle;
                        rows.CreateCell(column_index).SetCellValue(data);
                    }

                    using (FileStreamfile = new FileStream(str, FileMode.Create))
                    {
                        HSSFWorkbook_re.Write(FileStreamfile);
                    };

                }

            //    str1 = data;
            //}
            //});
        }
        #endregion

        #region xml
        private Command_film.MyCommand _command8;
        public Command_film.MyCommand Command8
        {
            get
            {
                if (_command8 == null)
                    _command8 = new Command_film.MyCommand(
                        new Action<object>(
                    async  e =>
                        {
                            try
                            {
                                Lib.Repice_Xml repice_Xml = new Lib.Repice_Xml();
                                await repice_Xml.Xml_Creat();


                                Notice.Show("Success",
                                  "Excel File Creat Success",
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
                return _command8;
            }
        }
        PaletteHelper paletteHelper; ITheme theme;
        private Command_film.MyCommand _command9;
        public Command_film.MyCommand Command9
        {
            get
            {
                if (_command9 == null)
                    _command9 = new Command_film.MyCommand(
                        new Action<object>(
                         async e =>
                         {
                             Lib.Repice_Xml repice_Xml = new Lib.Repice_Xml();
                             //await repice_Xml.Xml_Read();
                             AlarmItems1 = repice_Xml.XmlItems;


                            
                             Notice.Show("Success",
                                    "Excel File Creat Success",
                                    1,
                                    MessageBoxIcon.Success);
                         }));
                return _command9;
            }
        }
        private Command_film.MyCommand _command10;
        public Command_film.MyCommand Command10
        {
            get
            {
                if (_command10 == null)
                    _command10 = new Command_film.MyCommand(
                        new Action<object>(
                          e =>
                         {
                              int i = 0;
                             _Enable12 = !_Enable12;
                             Task.Run( () =>
                             {

                                 while (_Enable12)
                                 {
                                    
                                     i++;
                                     OneMessage1 = i.ToString();  
                                     Thread.Sleep(1000);
                                 }
                                 
                             });

                         }));
                return _command10;
            }
        }
        private bool enable12;
        public bool _Enable12
        {
            get
            {
                return enable12;
            }
            set
            {
                enable12 = value;
                NotifyOfPropertyChange(() => _Enable12);
            }
        }
        string oneMessage1;
        public string OneMessage1
        {
            get
            {
                return oneMessage1;
            }
            set
            {
                oneMessage1 = value;
              

                NotifyOfPropertyChange(() => OneMessage1);
            }
        }
        public void calCellEditEnding(object str, string str2)
        {
            if (str is DataGrid dataGrid)
            {
               
                Notice.Show("Success",
                                  "Excel File Creat dataGrid",
                                  1,
                                  MessageBoxIcon.Success);

            }
        }
        #endregion

        #region List收集
        private ObservableCollection<Lib.Xml_helper> alarmItems1 = new ObservableCollection<Lib.Xml_helper>();
        public ObservableCollection<Lib.Xml_helper> AlarmItems1
        {
            get
            { return alarmItems1; }
            set
            {
                alarmItems1 = value;
                // OnPropertyChanged("AlarmItems1");
                Notice.Show("Success",
                                    "Data has changed11",
                                    1,
                                    MessageBoxIcon.Success);
                NotifyOfPropertyChange(() => AlarmItems1);
            }
        }

        #endregion

        private void AddAlarmItem(Lib.Xml_helper t1)
        {
            foreach (Lib.Xml_helper item in AlarmItems1)
            {
                if (item.ID == t1.ID) return;
            }
            AlarmItems1.Add(t1);
           
        }
        

        public void ChanguageLanguage(string lan)
        {
            System.Windows.MessageBox.Show(lan);
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
                        _Enable=true;
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
                enable= value;
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
        private Command_film.MyCommand _Add1;
        public Command_film.MyCommand _add1
        {
            get
            {
                if (_Add1 == null)
                    _Add1 = new Command_film.MyCommand(
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

                                                                      select p;
                                    foreach (XElement p in xElements)
                                    {
                                        //AlarmItems1.Insert(0, new Lib.Xml_helper(
                                        // Convert.ToInt32(p.Element("ID").Value),
                                        //    p.Element("POsition0").Value.ToString(),
                                        //    p.Element("POsition1").Value.ToString(),
                                            /* p.Element("POsition2").Value.ToString())*/
                                            //p.Element("POsition2").Attribute("AGE").Value.ToString()));

                                    }

                                }


                            }));
                return _Add1;
            }
        }
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

        #endregion

        public void Handle(ObservableCollection<Lib.Xml_helper> message)
        {
            AlarmItems1 = message;
        }

        #endregion
        private Command_film.MyCommand _RecipeCbxDropDownOpened;
        public Command_film.MyCommand RecipeCbxDropDownOpened
        {
            get
            {
                if (_RecipeCbxDropDownOpened == null)
                    _RecipeCbxDropDownOpened = new Command_film.MyCommand(
                        new Action<object>(
                          e =>
                         {
                             Notice.Show("Success",
                                 "Loaded",
                                 1,
                                 MessageBoxIcon.Success);



                         }));
                return _RecipeCbxDropDownOpened;
            }
        }
    }
}
