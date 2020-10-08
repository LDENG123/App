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
using System.IO;
using NPOI.SS.UserModel;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using System.Text;
using System.Windows.Controls;

namespace WpfApp1.ViewModels
{
    [Export(typeof(AlmViewModel))]
    class AlmViewModel: Screen,INotifyPropertyChanged,IHandle<string>
    {
       
        /// <summary>
        /// 通知
        /// </summary>
        private readonly IEventAggregator _eventAggregator;
        /// <summary>
        /// 字符串
        /// </summary>
        StringBuilder sb;
        public AlmViewModel()
        {
            AddAlarmItem( new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "FM开始"));
            sb = new StringBuilder();
            _eventAggregator = IoC.Get<IEventAggregator>();
            _eventAggregator.Subscribe(this);
            outputCio_1 = "0";
            readitems();
            Thanslate();

        }
        private void AddAlarmItem(Lib.Alm t1)
        {
            foreach (Lib.Alm item in AlarmItems)
            {
                if (item.ID == t1.ID) return;
            }
            AlarmItems.Add(t1);

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
        #region
        private ObservableCollection<Lib.Alm> alarmItems = new ObservableCollection<Lib.Alm>();
        public ObservableCollection<Lib.Alm> AlarmItems
        {
            get
            { return alarmItems; }
            set
            {
                alarmItems = value;
                NotifyOfPropertyChange(() => AlarmItems);
            }
        }
        

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
                             //    Lib.Repice_Xml repice_Xml = new Lib.Repice_Xml();
                             //    await repice_Xml.Xml_Read();
                             //    AlarmItems1 = repice_Xml.XmlItems;

                             //    Notice.Show("Success",
                             //           "Excel File Creat Success",
                             //           1,
                             //           MessageBoxIcon.Success);
                             //var mySettings = new MetroDialogSettings()
                             //{
                             //    AffirmativeButtonText = "Hi",
                             //    NegativeButtonText = "Go away!",
                             //    FirstAuxiliaryButtonText = "Cancel",

                             //};
                             //    MessageDialogResult result = await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("Please wait...", "File reading",
                             //    MessageDialogStyle.AffirmativeAndNegative,mySettings);
                             //    if (result == MessageDialogResult.Affirmative)
                             //    {

                             //        Notice.Show("Success",
                             //          "Excel File Creat Success",
                             //           1,
                             //           MessageBoxIcon.Success);
                             //    }
                             //    else if (result == MessageDialogResult.Negative)
                             //    {
                             //        Notice.Show("Success",
                             //            "Excel File Creat Success11",
                             //             1,
                             //             MessageBoxIcon.Success);
                             //    }
                             FrameColor = !FrameColor;
                         }));
                return _command9;
            }
        }
        #endregion
        private BitArray INT_BIT(long par)
        {
            byte[] ListBit;
            BitArray Array;
            ListBit = BitConverter.GetBytes(par);
            Array = new BitArray(ListBit);
            return Array;
        }
        private bool frameColor;
        public bool FrameColor
        {
            get
            {
                return frameColor;
            }
            set
            {
                frameColor = value;
                NotifyOfPropertyChange(() => FrameColor);
            }
        }
        #region 字段声明 
        bool i1 = true;
        private string _outputCio_0;
        public string outputCio_0
        {
            get
            {
                return _outputCio_0;
            }
            set
            {
                _outputCio_0 = value;
                NotifyOfPropertyChange(() => outputCio_0);
            }
        }
        private string _outputCio_1;
        public string outputCio_1
        {
            get
            {
                return _outputCio_1;
            }
            set
            {
                _outputCio_1 = value;
                NotifyOfPropertyChange(() => outputCio_1);
            }
        }

        private string _outputCio_2;
        public string outputCio_2
        {
            get
            {
                return _outputCio_2;
            }
            set
            {
                Application.Current.Dispatcher.Invoke((System.Action)(() =>
                {
                    Thanslate();
                }));
                _outputCio_2 = value;
                NotifyOfPropertyChange(() => outputCio_2);
            }
        }
        private string _outputCio_3;
        public string outputCio_3
        {
            get
            {
                return _outputCio_3;
            }
            set
            {
                _outputCio_3 = value;
                NotifyOfPropertyChange(() => outputCio_3);
            }
        }
        private string fH_U;
        public string FH_U
        {
            get
            {
                return fH_U;
            }
            set
            {

                if (value != FH_U )//&& fH_U != "0"
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
                if (value != FH_V )//&& fH_V != "0"
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
                if (value != FH_W )//&& fH_W != "0"
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
                if (value != Tab_U )//&& tab_U != "0"
                {

                    Xls_write(3, Tab_U);
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
                if (value != Tab_V) //&& tab_V != "0"
                {
                    Xls_write(4, Tab_V);

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
                if (value != Tab_W )//&& tab_W != "0"
                {
                    Xls_write(5, Tab_W);

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
        private bool vision_0;
        #region state
        bool[] ONCE = new bool[64];
        public bool Vision_0
        {
            get
            {
                return vision_0;
            }
            set
            {

                if (value == true && !ONCE[0])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                     AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "FM开始"));
                    }));
                    ONCE[0] = true;
                }
                if (value == false)
                {
                    ONCE[0] = false;
                }
                vision_0 = value;
                NotifyOfPropertyChange(() => Vision_0

                );
            }
        }
        private bool vision_1;
        public bool Vision_1
        {
            get
            {
                return vision_1;
            }
            set
            {

                if (value == true && !ONCE[1])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                 
                    ONCE[1] = true;
                }
                if (value == false)
                {
                    ONCE[1] = false;
                }
                vision_1 = value;
                NotifyOfPropertyChange(() => Vision_1);
            }
        }
        private bool vision_2;
        public bool Vision_2
        {
            get
            {
                return vision_2;
            }
            set
            {
                if (value == true && !ONCE[2])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "出膜拍照位置"));

                    }));
                  
                    ONCE[2] = true;
                }
                if (value == false)
                {
                    ONCE[2] = false;
                }
                vision_2 = value;
                NotifyOfPropertyChange(() => Vision_2);
            }
        }
        private bool vision_3;
        public bool Vision_3
        {
            get
            {
                return vision_3;
            }
            set
            {
                if (value == true && !ONCE[3])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "出膜拍照ING"));
                    }));
                   
                    
                    ONCE[3] = true;
                }

                if (value == false)
                {
                    ONCE[3] = false;
                }
                vision_3 = value;
                NotifyOfPropertyChange(() => Vision_3);
            }
        }
        private bool vision_4;
        public bool Vision_4
        {
            get
            {
                return vision_4;
            }
            set
            {
                if (value == true && !ONCE[4])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "CM拍照完成"));

                    }));
                   
                    ONCE[4] = true;
                }

                if (value == false)
                {
                    ONCE[4] = false;
                }
                vision_4 = value;
                NotifyOfPropertyChange(() => Vision_4);
            }
        }
        private bool vision_5;
        public bool Vision_5
        {
            get
            {
                return vision_5;
            }
            set
            {
                if (value == true && !ONCE[5])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "到取料位置 "));
                    }));
                   
                    ONCE[5] = true;
                }
                if (value == false)
                {
                    ONCE[5] = false;
                }
                vision_5 = value;
                NotifyOfPropertyChange(() => Vision_5);
            }
        }
        private bool vision_6;
        public bool Vision_6
        {
            get
            {
                return vision_6;
            }
            set
            {
                if (value == true && !ONCE[6])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), " 到达取料位置 "));
                    }));
                   
                    
                    ONCE[6] = true;
                }
                if (value == false)
                {
                    ONCE[6] = false;
                }
                vision_6 = value;
                NotifyOfPropertyChange(() => Vision_6);
            }
        }
        private bool vision_7;
        public bool Vision_7
        {
            get
            {
                return vision_7;
            }
            set
            {
                if (value == true && !ONCE[7])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "开始补正"));

                    }));
                    
                    
                    ONCE[7] = true;
                }
                if (value == false)
                {
                    ONCE[7] = false;
                }
                vision_7 = value;
                NotifyOfPropertyChange(() => Vision_7);
            }
        }
        private bool vision_8;
        public bool Vision_8
        {
            get
            {
                return vision_8;
            }
            set
            {

                if (value == true && !ONCE[8])
                {
                    ONCE[8] = true;
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "补正结束"));

                    }));
                   
                   
                }
                if (value == false)
                {
                    ONCE[8] = false;
                }
                vision_8 = value;
                NotifyOfPropertyChange(() => Vision_8

                );
            }
        }
        private bool vision_9;
        public bool Vision_9
        {
            get
            {
                return vision_9;
            }
            set
            {

                if (value == true && !ONCE[9])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "Z轴下降到位 "));

                    }));
                   
                    
                    ONCE[9] = true;
                }
                if (value == false)
                {
                    ONCE[9] = false;
                }
                vision_9 = value;
                NotifyOfPropertyChange(() => Vision_9);
            }
        }
        private bool vision_10;
        public bool Vision_10
        {
            get
            {
                return vision_10;
            }
            set
            {
                if (value == true && !ONCE[10])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "吸取散热膜"));
                    }));
                    
                    ONCE[10] = true;
                }
                if (value == false)
                {
                    ONCE[10] = false;
                }
                vision_10 = value;
                NotifyOfPropertyChange(() => Vision_10);
            }
        }
        private bool vision_11;
        public bool Vision_11
        {
            get
            {
                return vision_11;
            }
            set
            {
                if (value == true && !ONCE[11])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "真空达到开始同步移动 "));

                    }));
                  
                    ONCE[11] = true;
                }

                if (value == false)
                {
                    ONCE[11] = false;
                }
                vision_11 = value;
                NotifyOfPropertyChange(() => Vision_11);
            }
        }
        private bool vision_12;
        public bool Vision_12
        {
            get
            {
                return vision_12;
            }
            set
            {
                if (value == true && !ONCE[12])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "同步完成 "));
                    }));
                    
                    
                    ONCE[12] = true;
                }

                if (value == false)
                {
                    ONCE[12] = false;
                }
                vision_12 = value;
                NotifyOfPropertyChange(() => Vision_12);
            }
        }
        private bool vision_13;
        public bool Vision_13
        {
            get
            {
                return vision_13;
            }
            set
            {
                if (value == true && !ONCE[13])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ到拍照位置1 "));
                    }));
                    
                    
                    ONCE[13] = true;
                }
                if (value == false)
                {
                    ONCE[13] = false;
                }
                vision_13 = value;
                NotifyOfPropertyChange(() => Vision_13);
            }
        }
        private bool vision_14;
        public bool Vision_14
        {
            get
            {
                return vision_14;
            }
            set
            {
                if (value == true && !ONCE[14])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ到拍照位置2 "));
                    }));
                   
                    
                    ONCE[14] = true;
                }
                if (value == false)
                {
                    ONCE[14] = false;
                }
                vision_14 = value;
                NotifyOfPropertyChange(() => Vision_14);
            }
        }
        private bool vision_15;
        public bool Vision_15
        {
            get
            {
                return vision_15;
            }
            set
            {
                if (value == true && !ONCE[15])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "FM0开始拍照  "));
                    }));
                  
                     
                    ONCE[15] = true;
                }
                if (value == false)
                {
                    ONCE[15] = false;
                }
                vision_15 = value;
                NotifyOfPropertyChange(() => Vision_15);
            }
        }
        private bool vision_16;
        public bool Vision_16
        {
            get
            {
                return vision_16;
            }
            set
            {
                if (value == true && !ONCE[16])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "FM0拍照OK "));
                    }));
                   
                    
                    ONCE[16] = true;
                }
                if (value == false)
                {
                    ONCE[16] = false;
                }
                vision_16 = value;
                NotifyOfPropertyChange(() => Vision_16);
            }
        }
        private bool vision_17;
        public bool Vision_17
        {
            get
            {
                return vision_17;
            }
            set
            {
                if (value == true && !ONCE[17])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "FM0拍照NG"));
                    }));
                  
                    
                    ONCE[17] = true;
                }
                if (value == false)
                {
                    ONCE[17] = false;
                }
                vision_17 = value;
                NotifyOfPropertyChange(() => Vision_17);
            }
        }
        private bool vision_18;
        public bool Vision_18
        {
            get
            {
                return vision_18;
            }
            set
            {
                if (value == true && !ONCE[18])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ到拍照位置2"));
                    }));
                    
                    
                    ONCE[18] = true;
                }

                if (value == false)
                {
                    ONCE[18] = false;
                }
                vision_18 = value;
                NotifyOfPropertyChange(() => Vision_18);
            }
        }
        private bool vision_19;
        public bool Vision_19
        {
            get
            {
                return vision_19;
            }
            set
            {
                if (value == true && !ONCE[19])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ到拍照位置2"));

                    }));
                    
                    ONCE[19] = true;
                }

                if (value == false)
                {
                    ONCE[19] = false;
                }
                vision_19 = value;
                NotifyOfPropertyChange(() => Vision_19);
            }
        }
        private bool vision_20;
        public bool Vision_20
        {
            get
            {
                return vision_20;
            }
            set
            {
                if (value == true && !ONCE[20])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "FM1开始拍照"));
                    }));
                   
                     
                    ONCE[20] = true;
                }
                if (value == false)
                {
                    ONCE[20] = false;
                }
                vision_20 = value;
                NotifyOfPropertyChange(() => Vision_20);
            }
        }
        private bool vision_21;
        public bool Vision_21
        {
            get
            {
                return vision_21;
            }
            set
            {
                if (value == true && !ONCE[21])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "FM1拍照OK "));
                    }));
                   
                    
                    ONCE[21] = true;
                }
                if (value == false)
                {
                    ONCE[21] = false;
                }
                vision_21 = value;
                NotifyOfPropertyChange(() => Vision_21);
            }
        }
        private bool vision_22;
        public bool Vision_22
        {
            get
            {
                return vision_22;
            }
            set
            {
                if (value == true && !ONCE[22])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "FM1拍照NG "));
                    }));
                    
              
                    ONCE[22] = true;
                }
                if (value == false)
                {
                    ONCE[22] = false;
                }
                vision_22 = value;
                NotifyOfPropertyChange(() => Vision_22);
            }
        }
        private bool vision_23;
        public bool Vision_23
        {
            get
            {
                return vision_23;
            }
            set
            {
                if (value == true && !ONCE[23])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "平台0对位计算 "));
                    }));
                   
                    
                    ONCE[23] = true;
                }
                if (value == false)
                {
                    ONCE[23] = false;
                }
                vision_23 = value;
                NotifyOfPropertyChange(() => Vision_23);
            }
        }

        private bool vision_24;
        public bool Vision_24
        {
            get
            {
                return vision_24;
            }
            set
            {
                if (value == true && !ONCE[24])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "平台1对位计算 "));
                    }));
                 

                    
                    ONCE[24] = true;
                }
                if (value == false)
                {
                    ONCE[24] = false;
                }
                vision_24 = value;
                NotifyOfPropertyChange(() => Vision_24);
            }
        }
        private bool vision_25;
        public bool Vision_25
        {
            get
            {
                return vision_25;
            }
            set
            {
                if (value == true && !ONCE[25])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ去往平台0起始位置 "));
                    }));
                   
 
                    ONCE[25] = true;
                }

                if (value == false)
                {
                    ONCE[25] = false;
                }
                vision_25 = value;
                NotifyOfPropertyChange(() => Vision_25);
            }
        }
        private bool vision_26;
        public bool Vision_26
        {
            get
            {
                return vision_26;
            }
            set
            {
                if (value == true && !ONCE[26])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ到达平台0起始位置 "));
                    }));
                    
                     
                    ONCE[26] = true;
                }

                if (value == false)
                {
                    ONCE[26] = false;
                }
                vision_26 = value;
                NotifyOfPropertyChange(() => Vision_26);
            }
        }
        private bool vision_27;
        public bool Vision_27
        {
            get
            {
                return vision_27;
            }
            set
            {
                if (value == true && !ONCE[27])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ到平台0结束位置 "));
                    }));
                   
                     
                    ONCE[27] = true;
                }
                if (value == false)
                {
                    ONCE[27] = false;
                }
                vision_27 = value;
                NotifyOfPropertyChange(() => Vision_27);
            }
        }
        private bool vision_28;
        public bool Vision_28
        {
            get
            {
                return vision_28;
            }
            set
            {
                if (value == true && !ONCE[28])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ去往平台1起始位置 "));
                    }));
                   
                    
                    ONCE[28] = true;
                }
                if (value == false)
                {
                    ONCE[28] = false;
                }
                vision_28 = value;
                NotifyOfPropertyChange(() => Vision_28);
            }
        }
        private bool vision_29;
        public bool Vision_29
        {
            get
            {
                return vision_29;
            }
            set
            {
                if (value == true && !ONCE[29])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ到达平台1起始位置 "));
                    }));
                  
                    
                    ONCE[29] = true;
                }
                if (value == false)
                {
                    ONCE[29] = false;
                }
                vision_29 = value;
                NotifyOfPropertyChange(() => Vision_29);
            }
        }
        private bool vision_30;
        public bool Vision_30
        {
            get
            {
                return vision_30;
            }
            set
            {
                if (value == true && !ONCE[30])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ到平台1结束位置 ")); ;
                    }));
                   
                   
                    ONCE[30] = true;
                }
                if (value == false)
                {
                    ONCE[30] = false;
                }
                vision_30 = value;
                NotifyOfPropertyChange(() => Vision_30);
            }
        }
        private bool vision_31;
        public bool Vision_31
        {
            get
            {
                return vision_31;
            }
            set
            {
                if (value == true && !ONCE[31])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ进行补正 "));
                    }));
                   
                    
                    ONCE[31] = true;
                }
                if (value == false)
                {
                    ONCE[31] = false;
                }
                vision_31 = value;
                NotifyOfPropertyChange(() => Vision_31);
            }
        }
        private bool vision_32;
        public bool Vision_32
        {
            get
            {
                return vision_32;
            }
            set
            {
                if (value == true && !ONCE[32])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "XYZ进行补正到位 "));

                    }));
                    
                    ONCE[32] = true;
                }

                if (value == false)
                {
                    ONCE[32] = false;
                }
                vision_32 = value;
                NotifyOfPropertyChange(() => Vision_32);
            }
        }
        private bool vision_33;
        public bool Vision_33
        {
            get
            {
                return vision_33;
            }
            set
            {
                if (value == true && !ONCE[33])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "Z去往贴合位置 "));
                    }));
                   
                  
                    ONCE[33] = true;
                }

                if (value == false)
                {
                    ONCE[33] = false;
                }
                vision_33 = value;
                NotifyOfPropertyChange(() => Vision_33);
            }
        }
        private bool vision_34;
        public bool Vision_34
        {
            get
            {
                return vision_34;
            }
            set
            {
                if (value == true && !ONCE[34])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "Z到达贴合位置 "));
                    }));
                   
                    
                    ONCE[34] = true;
                }
                if (value == false)
                {
                    ONCE[34] = false;
                }
                vision_34 = value;
                NotifyOfPropertyChange(() => Vision_34);
            }
        }
        private bool vision_35;
        public bool Vision_35
        {
            get
            {
                return vision_35;
            }
            set
            {
                if (value == true && !ONCE[35])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                    
                    ONCE[35] = true;
                }
                if (value == false)
                {
                    ONCE[35] = false;
                }
                vision_35 = value;
                NotifyOfPropertyChange(() => Vision_35);
            }
        }
        private bool vision_36;
        public bool Vision_36
        {
            get
            {
                return vision_36;
            }
            set
            {
                if (value == true && !ONCE[36])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[36] = true;
                }
                if (value == false)
                {
                    ONCE[36] = false;
                }
                vision_36 = value;
                NotifyOfPropertyChange(() => Vision_36);
            }
        }
        private bool vision_37;
        public bool Vision_37
        {
            get
            {
                return vision_37;
            }
            set
            {
                if (value == true && !ONCE[37])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                  
                    ONCE[37] = true;
                }
                if (value == false)
                {
                    ONCE[37] = false;
                }
                vision_37 = value;
                NotifyOfPropertyChange(() => Vision_37);
            }
        }


        private bool vision_38;
        public bool Vision_38
        {
            get
            {
                return vision_38;
            }
            set
            {
                if (value == true && !ONCE[38])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                  
                    ONCE[38] = true;
                }
                if (value == false)
                {
                    ONCE[38] = false;
                }
                vision_38 = value;
                NotifyOfPropertyChange(() => Vision_38);
            }
        }
        private bool vision_39;
        public bool Vision_39
        {
            get
            {
                return vision_39;
            }
            set
            {
                if (value == true && !ONCE[39])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[39] = true;
                }

                if (value == false)
                {
                    ONCE[39] = false;
                }
                vision_39 = value;
                NotifyOfPropertyChange(() => Vision_39);
            }
        }
        private bool vision_40;
        public bool Vision_40
        {
            get
            {
                return vision_40;
            }
            set
            {
                if (value == true && !ONCE[40])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[40] = true;
                }

                if (value == false)
                {
                    ONCE[40] = false;
                }
                vision_40 = value;
                NotifyOfPropertyChange(() => Vision_40);
            }
        }
        private bool vision_41;
        public bool Vision_41
        {
            get
            {
                return vision_41;
            }
            set
            {
                if (value == true && !ONCE[41])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                    
                    ONCE[41] = true;
                }
                if (value == false)
                {
                    ONCE[41] = false;
                }
                vision_41 = value;
                NotifyOfPropertyChange(() => Vision_41);
            }
        }
        private bool vision_42;
        public bool Vision_42
        {
            get
            {
                return vision_42;
            }
            set
            {
                if (value == true && !ONCE[42])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                    
                    ONCE[42] = true;
                }
                if (value == false)
                {
                    ONCE[42] = false;
                }
                vision_42 = value;
                NotifyOfPropertyChange(() => Vision_42);
            }
        }
        private bool vision_43;
        public bool Vision_43
        {
            get
            {
                return vision_43;
            }
            set
            {
                if (value == true && !ONCE[43])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[43] = true;
                }
                if (value == false)
                {
                    ONCE[43] = false;
                }
                vision_43 = value;
                NotifyOfPropertyChange(() => Vision_43);
            }
        }
        private bool vision_44;
        public bool Vision_44
        {
            get
            {
                return vision_44;
            }
            set
            {
                if (value == true && !ONCE[44])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                 
                    ONCE[44] = true;
                }
                if (value == false)
                {
                    ONCE[44] = false;
                }
                vision_44 = value;
                NotifyOfPropertyChange(() => Vision_44);
            }
        }
        private bool vision_45;
        public bool Vision_45
        {
            get
            {
                return vision_45;
            }
            set
            {
                if (value == true && !ONCE[45])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                  
                    ONCE[45] = true;
                }
                if (value == false)
                {
                    ONCE[45] = false;
                }
                vision_45 = value;
                NotifyOfPropertyChange(() => Vision_45);
            }
        }
        private bool vision_46;
        public bool Vision_46
        {
            get
            {
                return vision_46;
            }
            set
            {
                if (value == true && !ONCE[46])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[46] = true;
                }

                if (value == false)
                {
                    ONCE[46] = false;
                }
                vision_46 = value;
                NotifyOfPropertyChange(() => Vision_46);
            }
        }
        private bool vision_47;
        public bool Vision_47
        {
            get
            {
                return vision_47;
            }
            set
            {
                if (value == true && !ONCE[47])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                 
                    ONCE[47] = true;
                }

                if (value == false)
                {
                    ONCE[47] = false;
                }
                vision_47 = value;
                NotifyOfPropertyChange(() => Vision_47);
            }
        }
        private bool vision_48;
        public bool Vision_48
        {
            get
            {
                return vision_48;
            }
            set
            {
                if (value == true && !ONCE[48])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                  
                    ONCE[48] = true;
                }
                if (value == false)
                {
                    ONCE[48] = false;
                }
                vision_48 = value;
                NotifyOfPropertyChange(() => Vision_48);
            }
        }
        private bool vision_49;
        public bool Vision_49
        {
            get
            {
                return vision_49;
            }
            set
            {
                if (value == true && !ONCE[49])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[49] = true;
                }
                if (value == false)
                {
                    ONCE[49] = false;
                }
                vision_49 = value;
                NotifyOfPropertyChange(() => Vision_49);
            }
        }
        private bool vision_50;
        public bool Vision_50
        {
            get
            {
                return vision_50;
            }
            set
            {
                if (value == true && !ONCE[50])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[50] = true;
                }
                if (value == false)
                {
                    ONCE[50] = false;
                }
                vision_50 = value;
                NotifyOfPropertyChange(() => Vision_50);
            }
        }
        private bool vision_51;
        public bool Vision_51
        {
            get
            {
                return vision_51;
            }
            set
            {
                if (value == true && !ONCE[51])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[51] = true;
                }
                if (value == false)
                {
                    ONCE[51] = false;
                }
                vision_51 = value;
                NotifyOfPropertyChange(() => Vision_51);
            }
        }

        private bool vision_52;
        public bool Vision_52
        {
            get
            {
                return vision_52;
            }
            set
            {
                if (value == true && !ONCE[52])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                    
                    ONCE[52] = true;
                }
                if (value == false)
                {
                    ONCE[52] = false;
                }
                vision_52 = value;
                NotifyOfPropertyChange(() => Vision_52);
            }
        }
        private bool vision_53;
        public bool Vision_53
        {
            get
            {
                return vision_53;
            }
            set
            {
                if (value == true && !ONCE[53])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                  
                    ONCE[53] = true;
                }

                if (value == false)
                {
                    ONCE[53] = false;
                }
                vision_53 = value;
                NotifyOfPropertyChange(() => Vision_53);
            }
        }
        private bool vision_54;
        public bool Vision_54
        {
            get
            {
                return vision_54;
            }
            set
            {
                if (value == true && !ONCE[54])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                  
                    ONCE[54] = true;
                }

                if (value == false)
                {
                    ONCE[54] = false;
                }
                vision_54 = value;
                NotifyOfPropertyChange(() => Vision_54);
            }
        }
        private bool vision_55;
        public bool Vision_55
        {
            get
            {
                return vision_55;
            }
            set
            {
                if (value == true && !ONCE[55])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                    
                    ONCE[55] = true;
                }
                if (value == false)
                {
                    ONCE[55] = false;
                }
                vision_55 = value;
                NotifyOfPropertyChange(() => Vision_55);
            }
        }
        private bool vision_56;
        public bool Vision_56
        {
            get
            {
                return vision_56;
            }
            set
            {
                if (value == true && !ONCE[56])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[56] = true;
                }
                if (value == false)
                {
                    ONCE[56] = false;
                }
                vision_56 = value;
                NotifyOfPropertyChange(() => Vision_56);
            }
        }
        private bool vision_57;
        public bool Vision_57
        {
            get
            {
                return vision_57;
            }
            set
            {
                if (value == true && !ONCE[57])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                    
                    ONCE[57] = true;
                }
                if (value == false)
                {
                    ONCE[57] = false;
                }
                vision_57 = value;
                NotifyOfPropertyChange(() => Vision_57);
            }
        }
        private bool vision_58;
        public bool Vision_58
        {
            get
            {
                return vision_58;
            }
            set
            {
                if (value == true && !ONCE[58])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                    
                    ONCE[58] = true;
                }
                if (value == false)
                {
                    ONCE[58] = false;
                }
                vision_58 = value;
                NotifyOfPropertyChange(() => Vision_58);
            }
        }
        private bool vision_59;
        public bool Vision_59
        {
            get
            {
                return vision_59;
            }
            set
            {
                if (value == true && !ONCE[59])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                    
                    ONCE[59] = true;
                }
                if (value == false)
                {
                    ONCE[59] = false;
                }
                vision_59 = value;
                NotifyOfPropertyChange(() => Vision_59);
            }
        }
        private bool vision_60;
        public bool Vision_60
        {
            get
            {
                return vision_60;
            }
            set
            {
                if (value == true && !ONCE[60])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[60] = true;
                }

                if (value == false)
                {
                    ONCE[60] = false;
                }
                vision_60 = value;
                NotifyOfPropertyChange(() => Vision_60);
            }
        }
        private bool vision_61;
        public bool Vision_61
        {
            get
            {
                return vision_61;
            }
            set
            {
                if (value == true && !ONCE[61])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "等待料"));
                    }));
                   
                    ONCE[61] = true;
                }

                if (value == false)
                {
                    ONCE[61] = false;
                }
                vision_61 = value;
                NotifyOfPropertyChange(() => Vision_61);
            }
        }
        private bool vision_62;
        public bool Vision_62
        {
            get
            {
                return vision_62;
            }
            set
            {
                if (value == true && !ONCE[62])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "滚轮下压 "));
                    }));
                   
                    ONCE[62] = true;
                }
                if (value == false)
                {
                    ONCE[62] = false;
                }
                vision_62 = value;
                NotifyOfPropertyChange(() => Vision_62);
            }
        }
        private bool vision_63;
        public bool Vision_63
        {
            get
            {
                return vision_63;
            }
            set
            {
                if (value == true && !ONCE[63])
                {
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        AlarmItems.Insert(0, new Lib.Alm(AlarmItems.Count, DateTime.Now.ToString(), "滚轮下压 "));
                    }));
                   
                    ONCE[63] = true;
                }
                if (value == false)
                {
                    ONCE[63] = false;
                }
                vision_63 = value;
                NotifyOfPropertyChange(() => Vision_63);
            }
        }



        #endregion

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

        public string Vision_Command0 {
            get
            {
                return vision_command0;
            }
            set
            {
                vision_command0 = value;
                NotifyOfPropertyChange(() => Vision_Command0);
            }
        }
        private string vision_command0;
        public string Vision_Command0_1 {
            get
            {
                return vision_command0_1;
            }
            set
            {

                vision_command0_1 = value;
                NotifyOfPropertyChange(() => Vision_Command0_1);
            }
        }
        private string vision_command0_1;
        public string Vision_Command0_2 {
            get
            {
               
                return vision_command0_2;
            }
            set
            {
                vision_command0_2 = value;
                NotifyOfPropertyChange(() => Vision_Command0_2);
            }
        }
        private string vision_command0_2;
        public string Vision_Command0_3
        {
            get
            {

                return vision_command0_3;
            }
            set
            {
                vision_command0_3 = value;
                NotifyOfPropertyChange(() => Vision_Command0_3);
            }
        }
        private string vision_command0_3;
        public string Vision_Command1 {
            get
            {

                return vision_command1;
            }
            set
            {
                vision_command1 = value;
                NotifyOfPropertyChange(() => Vision_Command1);
            }
        }
        private string vision_command1;
        public string Vision_Command1_1
        {
            get
            {

                return vision_command1_1;
            }
            set
            {
                vision_command1_1 = value;
                NotifyOfPropertyChange(() => Vision_Command1_1);
            }
        }
        private string vision_command1_1;
        public string Vision_Command1_2
        {
            get
            {

                return vision_command1_2;
            }
            set
            {
                vision_command1_2 = value;
                NotifyOfPropertyChange(() => Vision_Command1_2);
            }
        }
        private string vision_command1_2;
        public string Vision_Command1_3
        {
            get
            {

                return vision_command1_3;
            }
            set
            {
                vision_command1_3 = value;
                NotifyOfPropertyChange(() => Vision_Command1_3);
            }
        }
        private string vision_command1_3;
        public string Vision_Command2 {
            get
            {

                return vision_command2;
            }
            set
            {
                vision_command2 = value;
                NotifyOfPropertyChange(() => Vision_Command2);
            }
        }
        private string vision_command2;
        public string Vision_Command2_1 {
            get
            {

                return vision_command2_1;
            }
            set
            {
                vision_command2_1 = value;
                NotifyOfPropertyChange(() => Vision_Command2_1);
            }
        }
        private string vision_command2_1;
        public string Vision_Command2_2
        {
            get
            {

                return vision_command2_2;
            }
            set
            {
                vision_command2_2 = value;
                NotifyOfPropertyChange(() => Vision_Command2_2);
            }
        }
        private string vision_command2_2;
        public string Vision_Command2_3 {
            get
            {

                return vision_command2_3;
            }
            set
            {
                vision_command2_3 = value;
                NotifyOfPropertyChange(() => Vision_Command2_3);
            }
        }
        private string vision_command2_3;
        #endregion
        #region
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
        private void Xls_write(int column_index, string data)
        {

            string str = "E:/YJ_personal/上位机/Wpf_notice - 副本/WpfApp1/bin/Debug/excel/" + DateTime.Now.ToString("D") + ".xls";

            try
            {
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
            }
            catch (Exception error)
            {
                //Notice.Show(error.ToString(),
                //    "ERROR",
                //     MessageBoxIcon.Error);

            }

        }
        #endregion
        #region 读取数据
        BitArray vision;
        private void readitems()
        {
            Task.Run(() =>
            {
                while
                (true)
                {

                    FH_U = Lib.ConnectPlc1.plcitems.FH_U.ToString("f3");
                    FH_V = Lib.ConnectPlc1.plcitems.FH_V.ToString("f3");
                    FH_W = Lib.ConnectPlc1.plcitems.FH_W.ToString("f3");
                    Tab_U = Lib.ConnectPlc1.plcitems.Tab_U.ToString("f3");
                    Tab_V = Lib.ConnectPlc1.plcitems.Tab_V.ToString("f3");
                    Tab_W = Lib.ConnectPlc1.plcitems.Tab_W.ToString("f3");
                    outputCio_0 = Lib.ConnectPlc1.plcitems.Vision_Triger.ToString();
                  //  outputCio_1 = Lib.ConnectPlc1.plcitems.outputCio_1.ToString();
                    outputCio_2 = Lib.ConnectPlc1.plcitems.outputCio_2.ToString();
                    outputCio_3 = Lib.ConnectPlc1.plcitems.outputCio_3.ToString();
                    //Vision_Command0 = Lib.ConnectPlc1.plcitems.Vision_Command0.ToString();
                    //Vision_Command0_1 = Lib.ConnectPlc1.plcitems.Vision_Command0_1.ToString();
                    //Vision_Command0_2 = Lib.ConnectPlc1.plcitems.Vision_Command0_2.ToString();
                    //Vision_Command1 = Lib.ConnectPlc1.plcitems.Vision_Command1.ToString();
                    //Vision_Command1_1 = Lib.ConnectPlc1.plcitems.Vision_Command1_1.ToString();
                    //Vision_Command1_2 = Lib.ConnectPlc1.plcitems.Vision_Command1_2.ToString();
                    //Vision_Command2 = Lib.ConnectPlc1.plcitems.Vision_Command2.ToString();
                    //Vision_Command2_1 = Lib.ConnectPlc1.plcitems.Vision_Command2_1.ToString();
                    //Vision_Command2_2 = Lib.ConnectPlc1.plcitems.Vision_Command2_2.ToString();



                    Thread.Sleep(200);

                }
                
            });
        }
        BitArray bitArray;
        private void Thanslate()
        {
            Task.Run(() =>
            {
                    bitArray = new BitArray(64);
                    bitArray = INT_BIT(long.Parse(outputCio_1));
                    Vision_0 = bitArray[0];
                    Vision_1 = bitArray[1];
                    Vision_2 = bitArray[2];
                    Vision_3 = bitArray[3];
                    Vision_4 = bitArray[4];
                    Vision_5 = bitArray[5];
                    Vision_6 = bitArray[6];
                    Vision_7 = bitArray[7];
                    Vision_8 = bitArray[8];
                    Vision_9 = bitArray[9];
                    Vision_10 = bitArray[10];
                    Vision_11 = bitArray[11];
                    Vision_12 = bitArray[12];
                    Vision_13 = bitArray[13];
                    Vision_14 = bitArray[14];
                    Vision_15 = bitArray[15];
                    Vision_16 = bitArray[16];
                    Vision_17 = bitArray[17];
                    Vision_18 = bitArray[18];
                    Vision_19 = bitArray[19];
                    Vision_20 = bitArray[20];
                    Vision_21 = bitArray[21];
                    Vision_22 = bitArray[22];
                    Vision_23 = bitArray[23];
                    Vision_24 = bitArray[24];
                    Vision_25 = bitArray[25];
                    Vision_26 = bitArray[26];
                    Vision_27 = bitArray[27];
                    Vision_28 = bitArray[28];
                    Vision_29 = bitArray[29];
                    Vision_30 = bitArray[30];
                    Vision_31 = bitArray[31];
                    Vision_32 = bitArray[32];
                    Vision_33 = bitArray[33];
                    Vision_34 = bitArray[34];
                    Vision_35 = bitArray[35];
                    Vision_36 = bitArray[36];
                    Vision_37 = bitArray[37];
                    Vision_38 = bitArray[38];
                    Vision_39 = bitArray[39];
                    Vision_40 = bitArray[40];
                    Vision_41 = bitArray[41];
                    Vision_42 = bitArray[42];
                    Vision_43 = bitArray[43];
                    Vision_44 = bitArray[44];
                    Vision_45 = bitArray[45];
                    Vision_46 = bitArray[46];
                    Vision_47 = bitArray[47];
                    Vision_48 = bitArray[48];
                    Vision_49 = bitArray[49];
                    Vision_50 = bitArray[50];
                    Vision_51 = bitArray[51];
                    Vision_52 = bitArray[52];
                    Vision_53 = bitArray[53];
                    Vision_54 = bitArray[54];
                    Vision_55 = bitArray[55];
                    Vision_56 = bitArray[56];
                    Vision_57 = bitArray[57];
                    Vision_58 = bitArray[58];
                    Vision_59 = bitArray[59];
                    Vision_60 = bitArray[60];
                    Vision_61 = bitArray[61];
                    Vision_62 = bitArray[62];
                    Vision_63 = bitArray[63];
                    Thread.Sleep(200);
               
            });
        }
       
        
        #endregion
            #region Command


        private Command_film.MyCommand _sizeChanged;
    public Command_film.MyCommand SizeChanged
    {
        get
        {
            if (_sizeChanged == null)
                _sizeChanged = new Command_film.MyCommand(
                    new Action<object>(
                    e =>
                    {
                        if (e is RichTextBox richTextBox)
                        {
                            richTextBox.ScrollToEnd();
                            MessageBox.Show("8");

                        }

                    }));
            return _sizeChanged;
        }
    }
    #endregion
}
}
