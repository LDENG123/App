using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

using WpfApp1.Lib;
using System.Windows.Input;
using System.Text.RegularExpressions;
using Caliburn.Micro;
using System;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Panuon.UI.Silver;

namespace WpfApp1.TransitionsFile.TransitionsVM
{
    class Slide1_IntroVM : Screen, INotifyPropertyChanged
    {

        private readonly IEventAggregator _eventAggregator;
        public Slide1_IntroVM()
        {
            _eventAggregator = IoC.Get<IEventAggregator>();
            _eventAggregator.Subscribe(this);
            MessageBox.Show("123ok");
        }

        #region  聚合通知
        public void Handle(string message)
        {
            OneMessage = message;
        }
        private bool flyout;
        public bool Flyout { get { return flyout; } set { flyout = value; NotifyOfPropertyChange(() => Flyout); } }

        public void Handle(bool message)
        {
            Flyout = message;
        }
        #endregion
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
        #region Command
        #region SAVE
        private Command_film.MyCommand dataSave00_triger;
        public Command_film.MyCommand DataSave00_Triger
        {
            get
            {
                if (dataSave00_triger == null)
                    dataSave00_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix00 = "5";

                        }));
                return dataSave00_triger;
            }
        }
        private Command_film.MyCommand dataSave01_triger;
        public Command_film.MyCommand DataSave01_Triger
        {
            get
            {
                if (dataSave01_triger == null)
                    dataSave01_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix01 = "5";

                        }));
                return dataSave01_triger;
            }
        }
        private Command_film.MyCommand dataSave02_triger;
        public Command_film.MyCommand DataSave02_Triger
        {
            get
            {
                if (dataSave02_triger == null)
                    dataSave02_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix02 = "5";

                        }));
                return dataSave02_triger;
            }
        }
        private Command_film.MyCommand dataSave03_triger;
        public Command_film.MyCommand DataSave03_Triger
        {
            get
            {
                if (dataSave03_triger == null)
                    dataSave03_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix03 = "5";

                        }));
                return dataSave03_triger;
            }
        }
        private Command_film.MyCommand dataSave04_triger;
        public Command_film.MyCommand DataSave04_Triger
        {
            get
            {
                if (dataSave04_triger == null)
                    dataSave04_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix04 = "5";

                        }));
                return dataSave04_triger;
            }
        }
        private Command_film.MyCommand dataSave05_triger;
        public Command_film.MyCommand DataSave05_Triger
        {
            get
            {
                if (dataSave05_triger == null)
                    dataSave05_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix05 = "5";

                        }));
                return dataSave05_triger;
            }
        }
        private Command_film.MyCommand dataSave06_triger;
        public Command_film.MyCommand DataSave06_Triger
        {
            get
            {
                if (dataSave06_triger == null)
                    dataSave06_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix06 = "5";

                        }));
                return dataSave06_triger;
            }
        }
        private Command_film.MyCommand dataSave07_triger;
        public Command_film.MyCommand DataSave07_Triger
        {
            get
            {
                if (dataSave07_triger == null)
                    dataSave07_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix07 = "5";

                        }));
                return dataSave07_triger;
            }
        }
        private Command_film.MyCommand dataSave08_triger;
        public Command_film.MyCommand DataSave08_Triger
        {
            get
            {
                if (dataSave08_triger == null)
                    dataSave08_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix08 = "5";

                        }));
                return dataSave08_triger;
            }
        }
        private Command_film.MyCommand dataSave09_triger;
        public Command_film.MyCommand DataSave09_Triger
        {
            get
            {
                if (dataSave09_triger == null)
                    dataSave09_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix09 = "5";

                        }));
                return dataSave09_triger;
            }
        }
        private Command_film.MyCommand dataSave10_triger;
        public Command_film.MyCommand DataSave10_Triger
        {
            get
            {
                if (dataSave10_triger == null)
                    dataSave10_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix10 = "5";

                        }));
                return dataSave10_triger;
            }
        }

        private Command_film.MyCommand dataSave11_triger;
        public Command_film.MyCommand DataSave11_Triger
        {
            get
            {
                if (dataSave11_triger == null)
                    dataSave11_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix11 = "5";

                        }));
                return dataSave11_triger;
            }
        }
        private Command_film.MyCommand dataSave12_triger;
        public Command_film.MyCommand DataSave12_Triger
        {
            get
            {
                if (dataSave12_triger == null)
                    dataSave12_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix12 = "5";

                        }));
                return dataSave12_triger;
            }
        }
        private Command_film.MyCommand dataSave13_triger;
        public Command_film.MyCommand DataSave13_Triger
        {
            get
            {
                if (dataSave13_triger == null)
                    dataSave13_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix13 = "5";

                        }));
                return dataSave13_triger;
            }
        }
        private Command_film.MyCommand dataSave14_triger;
        public Command_film.MyCommand DataSave14_Triger
        {
            get
            {
                if (dataSave14_triger == null)
                    dataSave14_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix14 = "5";

                        }));
                return dataSave14_triger;
            }
        }
        private Command_film.MyCommand dataSave15_triger;
        public Command_film.MyCommand DataSave15_Triger
        {
            get
            {
                if (dataSave15_triger == null)
                    dataSave15_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix15 = "5";

                        }));
                return dataSave15_triger;
            }
        }
        private Command_film.MyCommand dataSave16_triger;
        public Command_film.MyCommand DataSave16_Triger
        {
            get
            {
                if (dataSave16_triger == null)
                    dataSave16_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix16 = "5";

                        }));
                return dataSave16_triger;
            }
        }

        #endregion SAVE
        #region gETdate
        private Command_film.MyCommand dataSet00_triger;
        public Command_film.MyCommand DataSet00_Triger
        {
            get
            {
                if (dataSet00_triger == null)
                    dataSet00_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix00 = "5";

                        }));
                return dataSet00_triger;
            }
        }
        private Command_film.MyCommand dataSet01_triger;
        public Command_film.MyCommand DataSet01_Triger
        {
            get
            {
                if (dataSet01_triger == null)
                    dataSet01_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix01 = "5";

                        }));
                return dataSet01_triger;
            }
        }
        private Command_film.MyCommand dataSet02_triger;
        public Command_film.MyCommand DataSet02_Triger
        {
            get
            {
                if (dataSet02_triger == null)
                    dataSet02_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix02 = "5";

                        }));
                return dataSet02_triger;
            }
        }
        private Command_film.MyCommand dataSet03_triger;
        public Command_film.MyCommand DataSet03_Triger
        {
            get
            {
                if (dataSet03_triger == null)
                    dataSet03_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix03 = "5";

                        }));
                return dataSet03_triger;
            }
        }
        private Command_film.MyCommand dataSet04_triger;
        public Command_film.MyCommand DataSet04_Triger
        {
            get
            {
                if (dataSet04_triger == null)
                    dataSet04_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix04 = "5";

                        }));
                return dataSet04_triger;
            }
        }
        private Command_film.MyCommand dataSet05_triger;
        public Command_film.MyCommand DataSet05_Triger
        {
            get
            {
                if (dataSet05_triger == null)
                    dataSet05_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix05 = "5";

                        }));
                return dataSet05_triger;
            }
        }
        private Command_film.MyCommand dataSet06_triger;
        public Command_film.MyCommand DataSet06_Triger
        {
            get
            {
                if (dataSet06_triger == null)
                    dataSet06_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix06 = "5";

                        }));
                return dataSet06_triger;
            }
        }
        private Command_film.MyCommand dataSet07_triger;
        public Command_film.MyCommand DataSet07_Triger
        {
            get
            {
                if (dataSet07_triger == null)
                    dataSet07_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix07 = "5";

                        }));
                return dataSet07_triger;
            }
        }
        private Command_film.MyCommand dataSet08_triger;
        public Command_film.MyCommand DataSet08_Triger
        {
            get
            {
                if (dataSet08_triger == null)
                    dataSet08_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix08 = "5";

                        }));
                return dataSet08_triger;
            }
        }
        private Command_film.MyCommand dataSet09_triger;
        public Command_film.MyCommand DataSet09_Triger
        {
            get
            {
                if (dataSet09_triger == null)
                    dataSet09_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix09 = "5";

                        }));
                return dataSet09_triger;
            }
        }
        private Command_film.MyCommand dataSet10_triger;
        public Command_film.MyCommand DataSet10_Triger
        {
            get
            {
                if (dataSet10_triger == null)
                    dataSet10_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix10 = "5";

                        }));
                return dataSet10_triger;
            }
        }

        private Command_film.MyCommand dataSet11_triger;
        public Command_film.MyCommand DataSet11_Triger
        {
            get
            {
                if (dataSet11_triger == null)
                    dataSet11_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix11 = "5";

                        }));
                return dataSet11_triger;
            }
        }
        private Command_film.MyCommand dataSet12_triger;
        public Command_film.MyCommand DataSet12_Triger
        {
            get
            {
                if (dataSet12_triger == null)
                    dataSet12_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix12 = "5";

                        }));
                return dataSet12_triger;
            }
        }
        private Command_film.MyCommand dataSet13_triger;
        public Command_film.MyCommand DataSet13_Triger
        {
            get
            {
                if (dataSet13_triger == null)
                    dataSet13_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix13 = "5";

                        }));
                return dataSet13_triger;
            }
        }
        private Command_film.MyCommand dataSet14_triger;
        public Command_film.MyCommand DataSet14_Triger
        {
            get
            {
                if (dataSet14_triger == null)
                    dataSet14_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix14 = "5";

                        }));
                return dataSet14_triger;
            }
        }
        private Command_film.MyCommand dataSet15_triger;
        public Command_film.MyCommand DataSet15_Triger
        {
            get
            {
                if (dataSet15_triger == null)
                    dataSet15_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix15 = "5";

                        }));
                return dataSet15_triger;
            }
        }
        private Command_film.MyCommand dataSet16_triger;
        public Command_film.MyCommand DataSet16_Triger
        {
            get
            {
                if (dataSet16_triger == null)
                    dataSet16_triger = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Get1_Asix16 = "5";

                        }));
                return dataSet16_triger;
            }
        }

        #endregion SAVE
        private Command_film.MyCommand _login;
        public Command_film.MyCommand Loaded
        {
            get
            {
                if (_login == null)
                    _login = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {

                            Lib.ConnectPlc1.plcitems.Get1_Asix00 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix01 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix02 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix03 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix04 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix05 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix06 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix07 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix08 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix09 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix10 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix11 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix12 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix13 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix14 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix15 = "5";
                            Lib.ConnectPlc1.plcitems.Get1_Asix16 = "5";
                        }));
                return _login;
            }
        }
        private Command_film.MyCommand fM_fly;
        public Command_film.MyCommand FM_fly
        {
            get
            {
                if (fM_fly == null)
                    fM_fly = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            _eventAggregator.PublishOnUIThread("FM");

                        }));
                return fM_fly;
            }
        }
        private Command_film.MyCommand tab_fly;
        public Command_film.MyCommand Tab_fly
        {
            get
            {
                if (tab_fly == null)
                    tab_fly = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            _eventAggregator.PublishOnUIThread("TAB");

                        }));
                return tab_fly;
            }
        }
        private Command_film.MyCommand vision_fly;
        public Command_film.MyCommand Vision_fly
        {
            get
            {
                if (vision_fly == null)
                    vision_fly = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            _eventAggregator.PublishOnUIThread("Vision");

                        }));
                return vision_fly;
            }
        }
        private Command_film.MyCommand carray_fly;
        public Command_film.MyCommand Carray_fly
        {
            get
            {
                if (carray_fly == null)
                    carray_fly = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            _eventAggregator.PublishOnUIThread("Carray");

                        }));
                return carray_fly;
            }
        }
        #region asix read
        private Command_film.MyCommand _asix0getvalue;
        public Command_film.MyCommand Asix0GetValue
        {
            get
            {
                if (_asix0getvalue == null)
                    _asix0getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {


                                Act_autoSpeed0 = Lib.ConnectPlc1.plcitems.Act_autoSpeed0.ToString("f3");
                                Act_manauSpeed0 = Lib.ConnectPlc1.plcitems.Act_manauSpeed0.ToString("f3");
                                Act_pos0 = Lib.ConnectPlc1.plcitems.Act_pos0.ToString("f3");
                                Act_pos1_0 = Lib.ConnectPlc1.plcitems.Act_pos1_0.ToString("f3");
                                Act_pos2_0 = Lib.ConnectPlc1.plcitems.Act_pos2_0.ToString("f3");
                                Act_pos00_2 = Lib.ConnectPlc1.plcitems.Act_pos00_2.ToString("f3");
                                Act_pos00_3 = Lib.ConnectPlc1.plcitems.Act_pos00_3.ToString("f3");
                                Act_pos00_4 = Lib.ConnectPlc1.plcitems.Act_pos00_4.ToString("f3");
                                Act_pos00_5 = Lib.ConnectPlc1.plcitems.Act_pos00_5.ToString("f3");
                                Act_pos00_6 = Lib.ConnectPlc1.plcitems.Act_pos00_6.ToString("f3");
                                Act_pos00_7 = Lib.ConnectPlc1.plcitems.Act_pos00_7.ToString("f3");
                                Act_pos00_8 = Lib.ConnectPlc1.plcitems.Act_pos00_8.ToString("f3");
                                Act_pos00_9 = Lib.ConnectPlc1.plcitems.Act_pos00_9.ToString("f3");
                                Act_Speed00_2 = Lib.ConnectPlc1.plcitems.Act_Speed00_2.ToString("f3");
                                Act_Speed00_3 = Lib.ConnectPlc1.plcitems.Act_Speed00_3.ToString("f3");
                                Act_Speed00_4 = Lib.ConnectPlc1.plcitems.Act_Speed00_4.ToString("f3");
                                Act_Speed00_5 = Lib.ConnectPlc1.plcitems.Act_Speed00_5.ToString("f3");
                                Act_Speed00_6 = Lib.ConnectPlc1.plcitems.Act_Speed00_6.ToString("f3");
                                Act_Speed00_7 = Lib.ConnectPlc1.plcitems.Act_Speed00_7.ToString("f3");
                                Act_Speed00_8 = Lib.ConnectPlc1.plcitems.Act_Speed00_8.ToString("f3");
                                Act_Speed00_9 = Lib.ConnectPlc1.plcitems.Act_Speed00_9.ToString("f3");



                            });
                        }));
                return _asix0getvalue;
            }
        }
        private Command_film.MyCommand _asix1getvalue;
        public Command_film.MyCommand Asix1GetValue
        {
            get
            {
                if (_asix1getvalue == null)
                    _asix1getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {


                                Act_autoSpeed1 = Lib.ConnectPlc1.plcitems.Act_autoSpeed1.ToString("f3");
                                Act_manauSpeed1 = Lib.ConnectPlc1.plcitems.Act_manauSpeed1.ToString("f3");
                                Act_pos1 = Lib.ConnectPlc1.plcitems.Act_pos1.ToString("f3");
                                Act_pos1_1 = Lib.ConnectPlc1.plcitems.Act_pos1_1.ToString("f3");
                                Act_pos2_1 = Lib.ConnectPlc1.plcitems.Act_pos2_1.ToString("f3");
                                Act_pos01_2 = Lib.ConnectPlc1.plcitems.Act_pos01_2.ToString("f3");
                                Act_pos01_3 = Lib.ConnectPlc1.plcitems.Act_pos01_3.ToString("f3");
                                Act_pos01_4 = Lib.ConnectPlc1.plcitems.Act_pos01_4.ToString("f3");
                                Act_pos01_5 = Lib.ConnectPlc1.plcitems.Act_pos01_5.ToString("f3");
                                Act_pos01_6 = Lib.ConnectPlc1.plcitems.Act_pos01_6.ToString("f3");
                                Act_pos01_7 = Lib.ConnectPlc1.plcitems.Act_pos01_7.ToString("f3");
                                Act_pos01_8 = Lib.ConnectPlc1.plcitems.Act_pos01_8.ToString("f3");
                                Act_pos01_9 = Lib.ConnectPlc1.plcitems.Act_pos01_9.ToString("f3");
                                Act_Speed01_2 = Lib.ConnectPlc1.plcitems.Act_Speed01_2.ToString("f3");
                                Act_Speed01_3 = Lib.ConnectPlc1.plcitems.Act_Speed01_3.ToString("f3");
                                Act_Speed01_4 = Lib.ConnectPlc1.plcitems.Act_Speed01_4.ToString("f3");
                                Act_Speed01_5 = Lib.ConnectPlc1.plcitems.Act_Speed01_5.ToString("f3");
                                Act_Speed01_6 = Lib.ConnectPlc1.plcitems.Act_Speed01_6.ToString("f3");
                                Act_Speed01_7 = Lib.ConnectPlc1.plcitems.Act_Speed01_7.ToString("f3");
                                Act_Speed01_8 = Lib.ConnectPlc1.plcitems.Act_Speed01_8.ToString("f3");
                                Act_Speed01_9 = Lib.ConnectPlc1.plcitems.Act_Speed01_9.ToString("f3");



                            });
                        }));
                return _asix1getvalue;
            }
        }
        private Command_film.MyCommand _asix2getvalue;
        public Command_film.MyCommand Asix2GetValue
        {
            get
            {
                if (_asix2getvalue == null)
                    _asix2getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {
                                while (false)
                                {

                                    Act_autoSpeed2 = Lib.ConnectPlc1.plcitems.Act_autoSpeed2.ToString("f3");
                                    Act_manauSpeed2 = Lib.ConnectPlc1.plcitems.Act_manauSpeed2.ToString("f3");
                                    Act_pos2 = Lib.ConnectPlc1.plcitems.Act_pos2.ToString("f3");
                                    Act_pos1_2 = Lib.ConnectPlc1.plcitems.Act_pos1_2.ToString("f3");
                                    Act_pos2_2 = Lib.ConnectPlc1.plcitems.Act_pos2_2.ToString("f3");
                                    Act_pos02_2 = Lib.ConnectPlc1.plcitems.Act_pos02_2.ToString("f3");
                                    Act_pos02_3 = Lib.ConnectPlc1.plcitems.Act_pos02_3.ToString("f3");
                                    Act_pos02_4 = Lib.ConnectPlc1.plcitems.Act_pos02_4.ToString("f3");
                                    Act_pos02_5 = Lib.ConnectPlc1.plcitems.Act_pos02_5.ToString("f3");
                                    Act_pos02_6 = Lib.ConnectPlc1.plcitems.Act_pos02_6.ToString("f3");
                                    Act_pos02_7 = Lib.ConnectPlc1.plcitems.Act_pos02_7.ToString("f3");
                                    Act_pos02_8 = Lib.ConnectPlc1.plcitems.Act_pos02_8.ToString("f3");
                                    Act_pos02_9 = Lib.ConnectPlc1.plcitems.Act_pos02_9.ToString("f3");
                                    Act_Speed02_2 = Lib.ConnectPlc1.plcitems.Act_Speed02_2.ToString("f3");
                                    Act_Speed02_3 = Lib.ConnectPlc1.plcitems.Act_Speed02_3.ToString("f3");
                                    Act_Speed02_4 = Lib.ConnectPlc1.plcitems.Act_Speed02_4.ToString("f3");
                                    Act_Speed02_5 = Lib.ConnectPlc1.plcitems.Act_Speed02_5.ToString("f3");
                                    Act_Speed02_6 = Lib.ConnectPlc1.plcitems.Act_Speed02_6.ToString("f3");
                                    Act_Speed02_7 = Lib.ConnectPlc1.plcitems.Act_Speed02_7.ToString("f3");
                                    Act_Speed02_8 = Lib.ConnectPlc1.plcitems.Act_Speed02_8.ToString("f3");
                                    Act_Speed02_9 = Lib.ConnectPlc1.plcitems.Act_Speed02_9.ToString("f3");
                                }

                                Thread.Sleep(200);
                            });
                        }));
                return _asix2getvalue;
            }
        }
        private Command_film.MyCommand _asix3getvalue;
        public Command_film.MyCommand Asix3GetValue
        {
            get
            {
                if (_asix3getvalue == null)
                    _asix3getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {


                                Act_autoSpeed3 = Lib.ConnectPlc1.plcitems.Act_autoSpeed3.ToString("f3");
                                Act_manauSpeed3 = Lib.ConnectPlc1.plcitems.Act_manauSpeed3.ToString("f3");
                                Act_pos3 = Lib.ConnectPlc1.plcitems.Act_pos3.ToString("f3");
                                Act_pos1_3 = Lib.ConnectPlc1.plcitems.Act_pos1_3.ToString("f3");
                                Act_pos2_3 = Lib.ConnectPlc1.plcitems.Act_pos2_3.ToString("f3");
                                Act_pos03_2 = Lib.ConnectPlc1.plcitems.Act_pos03_2.ToString("f3");
                                Act_pos03_3 = Lib.ConnectPlc1.plcitems.Act_pos03_3.ToString("f3");
                                Act_pos03_4 = Lib.ConnectPlc1.plcitems.Act_pos03_4.ToString("f3");
                                Act_pos03_5 = Lib.ConnectPlc1.plcitems.Act_pos03_5.ToString("f3");
                                Act_pos03_6 = Lib.ConnectPlc1.plcitems.Act_pos03_6.ToString("f3");
                                Act_pos03_7 = Lib.ConnectPlc1.plcitems.Act_pos03_7.ToString("f3");
                                Act_pos03_8 = Lib.ConnectPlc1.plcitems.Act_pos03_8.ToString("f3");
                                Act_pos03_9 = Lib.ConnectPlc1.plcitems.Act_pos03_9.ToString("f3");
                                Act_Speed03_2 = Lib.ConnectPlc1.plcitems.Act_Speed03_2.ToString("f3");
                                Act_Speed03_3 = Lib.ConnectPlc1.plcitems.Act_Speed03_3.ToString("f3");
                                Act_Speed03_4 = Lib.ConnectPlc1.plcitems.Act_Speed03_4.ToString("f3");
                                Act_Speed03_5 = Lib.ConnectPlc1.plcitems.Act_Speed03_5.ToString("f3");
                                Act_Speed03_6 = Lib.ConnectPlc1.plcitems.Act_Speed03_6.ToString("f3");
                                Act_Speed03_7 = Lib.ConnectPlc1.plcitems.Act_Speed03_7.ToString("f3");
                                Act_Speed03_8 = Lib.ConnectPlc1.plcitems.Act_Speed03_8.ToString("f3");
                                Act_Speed03_9 = Lib.ConnectPlc1.plcitems.Act_Speed03_9.ToString("f3");



                            });
                        }));
                return _asix3getvalue;
            }
        }
        private Command_film.MyCommand _asix4getvalue;
        public Command_film.MyCommand Asix4GetValue
        {
            get
            {
                if (_asix4getvalue == null)
                    _asix4getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed4 = Lib.ConnectPlc1.plcitems.Act_autoSpeed4.ToString("f3");
                                Act_manauSpeed4 = Lib.ConnectPlc1.plcitems.Act_manauSpeed4.ToString("f3");
                                Act_pos4 = Lib.ConnectPlc1.plcitems.Act_pos4.ToString("f3");
                                Act_pos1_4 = Lib.ConnectPlc1.plcitems.Act_pos1_4.ToString("f3");
                                Act_pos2_4 = Lib.ConnectPlc1.plcitems.Act_pos2_4.ToString("f3");

                                Act_pos04_2 = Lib.ConnectPlc1.plcitems.Act_pos04_2.ToString("f3");
                                Act_pos04_3 = Lib.ConnectPlc1.plcitems.Act_pos04_3.ToString("f3");
                                Act_pos04_4 = Lib.ConnectPlc1.plcitems.Act_pos04_4.ToString("f3");
                                Act_pos04_5 = Lib.ConnectPlc1.plcitems.Act_pos04_5.ToString("f3");
                                Act_pos04_6 = Lib.ConnectPlc1.plcitems.Act_pos04_6.ToString("f3");
                                Act_pos04_7 = Lib.ConnectPlc1.plcitems.Act_pos04_7.ToString("f3");
                                Act_pos04_8 = Lib.ConnectPlc1.plcitems.Act_pos04_8.ToString("f3");
                                Act_pos04_9 = Lib.ConnectPlc1.plcitems.Act_pos04_9.ToString("f3");
                                Act_Speed04_2 = Lib.ConnectPlc1.plcitems.Act_Speed04_2.ToString("f3");
                                Act_Speed04_3 = Lib.ConnectPlc1.plcitems.Act_Speed04_3.ToString("f3");
                                Act_Speed04_4 = Lib.ConnectPlc1.plcitems.Act_Speed04_4.ToString("f3");
                                Act_Speed04_5 = Lib.ConnectPlc1.plcitems.Act_Speed04_5.ToString("f3");
                                Act_Speed04_6 = Lib.ConnectPlc1.plcitems.Act_Speed04_6.ToString("f3");
                                Act_Speed04_7 = Lib.ConnectPlc1.plcitems.Act_Speed04_7.ToString("f3");
                                Act_Speed04_8 = Lib.ConnectPlc1.plcitems.Act_Speed04_8.ToString("f3");
                                Act_Speed04_9 = Lib.ConnectPlc1.plcitems.Act_Speed04_9.ToString("f3");



                            });
                        }));
                return _asix4getvalue;
            }
        }
        private Command_film.MyCommand _asix5getvalue;
        public Command_film.MyCommand Asix5GetValue
        {
            get
            {
                if (_asix5getvalue == null)
                    _asix5getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed5 = Lib.ConnectPlc1.plcitems.Act_autoSpeed5.ToString("f3");
                                Act_manauSpeed5 = Lib.ConnectPlc1.plcitems.Act_manauSpeed5.ToString("f3");
                                Act_pos5 = Lib.ConnectPlc1.plcitems.Act_pos5.ToString("f3");
                                Act_pos1_5 = Lib.ConnectPlc1.plcitems.Act_pos1_5.ToString("f3");
                                Act_pos2_5 = Lib.ConnectPlc1.plcitems.Act_pos2_5.ToString("f3");

                                Act_pos05_2 = Lib.ConnectPlc1.plcitems.Act_pos05_2.ToString("f3");
                                Act_pos05_3 = Lib.ConnectPlc1.plcitems.Act_pos05_3.ToString("f3");
                                Act_pos05_4 = Lib.ConnectPlc1.plcitems.Act_pos05_4.ToString("f3");
                                Act_pos05_5 = Lib.ConnectPlc1.plcitems.Act_pos05_5.ToString("f3");
                                Act_pos05_6 = Lib.ConnectPlc1.plcitems.Act_pos05_6.ToString("f3");
                                Act_pos05_7 = Lib.ConnectPlc1.plcitems.Act_pos05_7.ToString("f3");
                                Act_pos05_8 = Lib.ConnectPlc1.plcitems.Act_pos05_8.ToString("f3");
                                Act_pos05_9 = Lib.ConnectPlc1.plcitems.Act_pos05_9.ToString("f3");
                                Act_Speed05_2 = Lib.ConnectPlc1.plcitems.Act_Speed05_2.ToString("f3");
                                Act_Speed05_3 = Lib.ConnectPlc1.plcitems.Act_Speed05_3.ToString("f3");
                                Act_Speed05_4 = Lib.ConnectPlc1.plcitems.Act_Speed05_4.ToString("f3");
                                Act_Speed05_5 = Lib.ConnectPlc1.plcitems.Act_Speed05_5.ToString("f3");
                                Act_Speed05_6 = Lib.ConnectPlc1.plcitems.Act_Speed05_6.ToString("f3");
                                Act_Speed05_7 = Lib.ConnectPlc1.plcitems.Act_Speed05_7.ToString("f3");
                                Act_Speed05_8 = Lib.ConnectPlc1.plcitems.Act_Speed05_8.ToString("f3");
                                Act_Speed05_9 = Lib.ConnectPlc1.plcitems.Act_Speed05_9.ToString("f3");



                            });
                        }));
                return _asix5getvalue;
            }
        }
        private Command_film.MyCommand _asix6getvalue;
        public Command_film.MyCommand Asix6GetValue
        {
            get
            {
                if (_asix6getvalue == null)
                    _asix6getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed6 = Lib.ConnectPlc1.plcitems.Act_autoSpeed6.ToString("f3");
                                Act_manauSpeed6 = Lib.ConnectPlc1.plcitems.Act_manauSpeed6.ToString("f3");
                                Act_pos6 = Lib.ConnectPlc1.plcitems.Act_pos6.ToString("f3");
                                Act_pos1_6 = Lib.ConnectPlc1.plcitems.Act_pos1_6.ToString("f3");
                                Act_pos2_6 = Lib.ConnectPlc1.plcitems.Act_pos2_6.ToString("f3");

                                Act_pos06_2 = Lib.ConnectPlc1.plcitems.Act_pos06_2.ToString("f3");
                                Act_pos06_3 = Lib.ConnectPlc1.plcitems.Act_pos06_3.ToString("f3");
                                Act_pos06_4 = Lib.ConnectPlc1.plcitems.Act_pos06_4.ToString("f3");
                                Act_pos06_5 = Lib.ConnectPlc1.plcitems.Act_pos06_5.ToString("f3");
                                Act_pos06_6 = Lib.ConnectPlc1.plcitems.Act_pos06_6.ToString("f3");
                                Act_pos06_7 = Lib.ConnectPlc1.plcitems.Act_pos06_7.ToString("f3");
                                Act_pos06_8 = Lib.ConnectPlc1.plcitems.Act_pos06_8.ToString("f3");
                                Act_pos06_9 = Lib.ConnectPlc1.plcitems.Act_pos06_9.ToString("f3");
                                Act_Speed06_2 = Lib.ConnectPlc1.plcitems.Act_Speed06_2.ToString("f3");
                                Act_Speed06_3 = Lib.ConnectPlc1.plcitems.Act_Speed06_3.ToString("f3");
                                Act_Speed06_4 = Lib.ConnectPlc1.plcitems.Act_Speed06_4.ToString("f3");
                                Act_Speed06_5 = Lib.ConnectPlc1.plcitems.Act_Speed06_5.ToString("f3");
                                Act_Speed06_6 = Lib.ConnectPlc1.plcitems.Act_Speed06_6.ToString("f3");
                                Act_Speed06_7 = Lib.ConnectPlc1.plcitems.Act_Speed06_7.ToString("f3");
                                Act_Speed06_8 = Lib.ConnectPlc1.plcitems.Act_Speed06_8.ToString("f3");
                                Act_Speed06_9 = Lib.ConnectPlc1.plcitems.Act_Speed06_9.ToString("f3");


                            });
                        }));
                return _asix6getvalue;
            }
        }
        private Command_film.MyCommand _asix7getvalue;
        public Command_film.MyCommand Asix7GetValue
        {
            get
            {
                if (_asix7getvalue == null)
                    _asix7getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {


                                Act_autoSpeed7 = Lib.ConnectPlc1.plcitems.Act_autoSpeed7.ToString("f3");
                                Act_manauSpeed7 = Lib.ConnectPlc1.plcitems.Act_manauSpeed7.ToString("f3");
                                Act_pos7 = Lib.ConnectPlc1.plcitems.Act_pos7.ToString("f3");
                                Act_pos1_7 = Lib.ConnectPlc1.plcitems.Act_pos1_7.ToString("f3");
                                Act_pos2_7 = Lib.ConnectPlc1.plcitems.Act_pos2_7.ToString("f3");
                                Act_pos07_2 = Lib.ConnectPlc1.plcitems.Act_pos07_2.ToString("f3");
                                Act_pos07_3 = Lib.ConnectPlc1.plcitems.Act_pos07_3.ToString("f3");
                                Act_pos07_4 = Lib.ConnectPlc1.plcitems.Act_pos07_4.ToString("f3");
                                Act_pos07_5 = Lib.ConnectPlc1.plcitems.Act_pos07_5.ToString("f3");
                                Act_pos07_6 = Lib.ConnectPlc1.plcitems.Act_pos07_6.ToString("f3");
                                Act_pos07_7 = Lib.ConnectPlc1.plcitems.Act_pos07_7.ToString("f3");
                                Act_pos07_8 = Lib.ConnectPlc1.plcitems.Act_pos07_8.ToString("f3");
                                Act_pos07_9 = Lib.ConnectPlc1.plcitems.Act_pos07_9.ToString("f3");
                                Act_Speed07_2 = Lib.ConnectPlc1.plcitems.Act_Speed07_2.ToString("f3");
                                Act_Speed07_3 = Lib.ConnectPlc1.plcitems.Act_Speed07_3.ToString("f3");
                                Act_Speed07_4 = Lib.ConnectPlc1.plcitems.Act_Speed07_4.ToString("f3");
                                Act_Speed07_5 = Lib.ConnectPlc1.plcitems.Act_Speed07_5.ToString("f3");
                                Act_Speed07_6 = Lib.ConnectPlc1.plcitems.Act_Speed07_6.ToString("f3");
                                Act_Speed07_7 = Lib.ConnectPlc1.plcitems.Act_Speed07_7.ToString("f3");
                                Act_Speed07_8 = Lib.ConnectPlc1.plcitems.Act_Speed07_8.ToString("f3");
                                Act_Speed07_9 = Lib.ConnectPlc1.plcitems.Act_Speed07_9.ToString("f3");



                            });
                        }));
                return _asix7getvalue;
            }
        }
        private Command_film.MyCommand _asix8getvalue;
        public Command_film.MyCommand Asix8GetValue
        {
            get
            {
                if (_asix8getvalue == null)
                    _asix8getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed8 = Lib.ConnectPlc1.plcitems.Act_autoSpeed8.ToString("f3");
                                Act_manauSpeed8 = Lib.ConnectPlc1.plcitems.Act_manauSpeed8.ToString("f3");
                                Act_pos8 = Lib.ConnectPlc1.plcitems.Act_pos8.ToString("f3");
                                Act_pos1_8 = Lib.ConnectPlc1.plcitems.Act_pos1_8.ToString("f3");
                                Act_pos2_8 = Lib.ConnectPlc1.plcitems.Act_pos2_8.ToString("f3");

                                Act_pos08_2 = Lib.ConnectPlc1.plcitems.Act_pos08_2.ToString("f3");
                                Act_pos08_3 = Lib.ConnectPlc1.plcitems.Act_pos08_3.ToString("f3");
                                Act_pos08_4 = Lib.ConnectPlc1.plcitems.Act_pos08_4.ToString("f3");
                                Act_pos08_5 = Lib.ConnectPlc1.plcitems.Act_pos08_5.ToString("f3");
                                Act_pos08_6 = Lib.ConnectPlc1.plcitems.Act_pos08_6.ToString("f3");
                                Act_pos08_7 = Lib.ConnectPlc1.plcitems.Act_pos08_7.ToString("f3");
                                Act_pos08_8 = Lib.ConnectPlc1.plcitems.Act_pos08_8.ToString("f3");
                                Act_pos08_9 = Lib.ConnectPlc1.plcitems.Act_pos08_9.ToString("f3");
                                Act_Speed08_2 = Lib.ConnectPlc1.plcitems.Act_Speed08_2.ToString("f3");
                                Act_Speed08_3 = Lib.ConnectPlc1.plcitems.Act_Speed08_3.ToString("f3");
                                Act_Speed08_4 = Lib.ConnectPlc1.plcitems.Act_Speed08_4.ToString("f3");
                                Act_Speed08_5 = Lib.ConnectPlc1.plcitems.Act_Speed08_5.ToString("f3");
                                Act_Speed08_6 = Lib.ConnectPlc1.plcitems.Act_Speed08_6.ToString("f3");
                                Act_Speed08_7 = Lib.ConnectPlc1.plcitems.Act_Speed08_7.ToString("f3");
                                Act_Speed08_8 = Lib.ConnectPlc1.plcitems.Act_Speed08_8.ToString("f3");
                                Act_Speed08_9 = Lib.ConnectPlc1.plcitems.Act_Speed08_9.ToString("f3");



                            });
                        }));
                return _asix8getvalue;
            }
        }
        private Command_film.MyCommand _asix9getvalue;
        public Command_film.MyCommand Asix9GetValue
        {
            get
            {
                if (_asix9getvalue == null)
                    _asix9getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed9 = Lib.ConnectPlc1.plcitems.Act_autoSpeed9.ToString("f3");
                                Act_manauSpeed9 = Lib.ConnectPlc1.plcitems.Act_manauSpeed9.ToString("f3");
                                Act_pos9 = Lib.ConnectPlc1.plcitems.Act_pos9.ToString("f3");
                                Act_pos1_9 = Lib.ConnectPlc1.plcitems.Act_pos1_9.ToString("f3");
                                Act_pos2_9 = Lib.ConnectPlc1.plcitems.Act_pos2_9.ToString("f3");

                                Act_pos09_2 = Lib.ConnectPlc1.plcitems.Act_pos09_2.ToString("f3");
                                Act_pos09_3 = Lib.ConnectPlc1.plcitems.Act_pos09_3.ToString("f3");
                                Act_pos09_4 = Lib.ConnectPlc1.plcitems.Act_pos09_4.ToString("f3");
                                Act_pos09_5 = Lib.ConnectPlc1.plcitems.Act_pos09_5.ToString("f3");
                                Act_pos09_6 = Lib.ConnectPlc1.plcitems.Act_pos09_6.ToString("f3");
                                Act_pos09_7 = Lib.ConnectPlc1.plcitems.Act_pos09_7.ToString("f3");
                                Act_pos09_8 = Lib.ConnectPlc1.plcitems.Act_pos09_8.ToString("f3");
                                Act_pos09_9 = Lib.ConnectPlc1.plcitems.Act_pos09_9.ToString("f3");
                                Act_Speed09_2 = Lib.ConnectPlc1.plcitems.Act_Speed09_2.ToString("f3");
                                Act_Speed09_3 = Lib.ConnectPlc1.plcitems.Act_Speed09_3.ToString("f3");
                                Act_Speed09_4 = Lib.ConnectPlc1.plcitems.Act_Speed09_4.ToString("f3");
                                Act_Speed09_5 = Lib.ConnectPlc1.plcitems.Act_Speed09_5.ToString("f3");
                                Act_Speed09_6 = Lib.ConnectPlc1.plcitems.Act_Speed09_6.ToString("f3");
                                Act_Speed09_7 = Lib.ConnectPlc1.plcitems.Act_Speed09_7.ToString("f3");
                                Act_Speed09_8 = Lib.ConnectPlc1.plcitems.Act_Speed09_8.ToString("f3");
                                Act_Speed09_9 = Lib.ConnectPlc1.plcitems.Act_Speed09_9.ToString("f3");



                            });
                        }));
                return _asix9getvalue;
            }
        }
        private Command_film.MyCommand _asix10getvalue;
        public Command_film.MyCommand Asix10GetValue
        {
            get
            {
                if (_asix10getvalue == null)
                    _asix10getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed10 = Lib.ConnectPlc1.plcitems.Act_autoSpeed10.ToString("f3");
                                Act_manauSpeed10 = Lib.ConnectPlc1.plcitems.Act_manauSpeed10.ToString("f3");
                                Act_pos10 = Lib.ConnectPlc1.plcitems.Act_pos10.ToString("f3");
                                Act_pos1_10 = Lib.ConnectPlc1.plcitems.Act_pos1_10.ToString("f3");
                                Act_pos2_10 = Lib.ConnectPlc1.plcitems.Act_pos2_10.ToString("f3");

                                Act_pos10_2 = Lib.ConnectPlc1.plcitems.Act_pos10_2.ToString("f3");
                                Act_pos10_3 = Lib.ConnectPlc1.plcitems.Act_pos10_3.ToString("f3");
                                Act_pos10_4 = Lib.ConnectPlc1.plcitems.Act_pos10_4.ToString("f3");
                                Act_pos10_5 = Lib.ConnectPlc1.plcitems.Act_pos10_5.ToString("f3");
                                Act_pos10_6 = Lib.ConnectPlc1.plcitems.Act_pos10_6.ToString("f3");
                                Act_pos10_7 = Lib.ConnectPlc1.plcitems.Act_pos10_7.ToString("f3");
                                Act_pos10_8 = Lib.ConnectPlc1.plcitems.Act_pos10_8.ToString("f3");
                                Act_pos10_9 = Lib.ConnectPlc1.plcitems.Act_pos10_9.ToString("f3");
                                Act_Speed10_2 = Lib.ConnectPlc1.plcitems.Act_Speed10_2.ToString("f3");
                                Act_Speed10_3 = Lib.ConnectPlc1.plcitems.Act_Speed10_3.ToString("f3");
                                Act_Speed10_4 = Lib.ConnectPlc1.plcitems.Act_Speed10_4.ToString("f3");
                                Act_Speed10_5 = Lib.ConnectPlc1.plcitems.Act_Speed10_5.ToString("f3");
                                Act_Speed10_6 = Lib.ConnectPlc1.plcitems.Act_Speed10_6.ToString("f3");
                                Act_Speed10_7 = Lib.ConnectPlc1.plcitems.Act_Speed10_7.ToString("f3");
                                Act_Speed10_8 = Lib.ConnectPlc1.plcitems.Act_Speed10_8.ToString("f3");
                                Act_Speed10_9 = Lib.ConnectPlc1.plcitems.Act_Speed10_9.ToString("f3");



                            });
                        }));
                return _asix10getvalue;
            }
        }
        private Command_film.MyCommand _asix11getvalue;
        public Command_film.MyCommand Asix11GetValue
        {
            get
            {
                if (_asix11getvalue == null)
                    _asix11getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed11 = Lib.ConnectPlc1.plcitems.Act_autoSpeed11.ToString("f3");
                                Act_manauSpeed11 = Lib.ConnectPlc1.plcitems.Act_manauSpeed11.ToString("f3");
                                Act_pos11 = Lib.ConnectPlc1.plcitems.Act_pos11.ToString("f3");
                                Act_pos1_11 = Lib.ConnectPlc1.plcitems.Act_pos1_11.ToString("f3");
                                Act_pos2_11 = Lib.ConnectPlc1.plcitems.Act_pos2_11.ToString("f3");
                                Act_pos11_2 = Lib.ConnectPlc1.plcitems.Act_pos11_2.ToString("f3");
                                Act_pos11_3 = Lib.ConnectPlc1.plcitems.Act_pos11_3.ToString("f3");
                                Act_pos11_4 = Lib.ConnectPlc1.plcitems.Act_pos11_4.ToString("f3");
                                Act_pos11_5 = Lib.ConnectPlc1.plcitems.Act_pos11_5.ToString("f3");
                                Act_pos11_6 = Lib.ConnectPlc1.plcitems.Act_pos11_6.ToString("f3");
                                Act_pos11_7 = Lib.ConnectPlc1.plcitems.Act_pos11_7.ToString("f3");
                                Act_pos11_8 = Lib.ConnectPlc1.plcitems.Act_pos11_8.ToString("f3");
                                Act_pos11_9 = Lib.ConnectPlc1.plcitems.Act_pos11_9.ToString("f3");
                                Act_Speed11_2 = Lib.ConnectPlc1.plcitems.Act_Speed11_2.ToString("f3");
                                Act_Speed11_3 = Lib.ConnectPlc1.plcitems.Act_Speed11_3.ToString("f3");
                                Act_Speed11_4 = Lib.ConnectPlc1.plcitems.Act_Speed11_4.ToString("f3");
                                Act_Speed11_5 = Lib.ConnectPlc1.plcitems.Act_Speed11_5.ToString("f3");
                                Act_Speed11_6 = Lib.ConnectPlc1.plcitems.Act_Speed11_6.ToString("f3");
                                Act_Speed11_7 = Lib.ConnectPlc1.plcitems.Act_Speed11_7.ToString("f3");
                                Act_Speed11_8 = Lib.ConnectPlc1.plcitems.Act_Speed11_8.ToString("f3");
                                Act_Speed11_9 = Lib.ConnectPlc1.plcitems.Act_Speed11_9.ToString("f3");



                            });
                        }));
                return _asix11getvalue;
            }
        }
        private Command_film.MyCommand _asix12getvalue;
        public Command_film.MyCommand Asix12GetValue
        {
            get
            {
                if (_asix12getvalue == null)
                    _asix12getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed12 = Lib.ConnectPlc1.plcitems.Act_autoSpeed12.ToString("f3");
                                Act_manauSpeed12 = Lib.ConnectPlc1.plcitems.Act_manauSpeed12.ToString("f3");
                                Act_pos12 = Lib.ConnectPlc1.plcitems.Act_pos12.ToString("f3");
                                Act_pos1_12 = Lib.ConnectPlc1.plcitems.Act_pos1_12.ToString("f3");
                                Act_pos2_12 = Lib.ConnectPlc1.plcitems.Act_pos2_12.ToString("f3");

                                Act_pos12_2 = Lib.ConnectPlc1.plcitems.Act_pos12_2.ToString("f3");
                                Act_pos12_3 = Lib.ConnectPlc1.plcitems.Act_pos12_3.ToString("f3");
                                Act_pos12_4 = Lib.ConnectPlc1.plcitems.Act_pos12_4.ToString("f3");
                                Act_pos12_5 = Lib.ConnectPlc1.plcitems.Act_pos12_5.ToString("f3");
                                Act_pos12_6 = Lib.ConnectPlc1.plcitems.Act_pos12_6.ToString("f3");
                                Act_pos12_7 = Lib.ConnectPlc1.plcitems.Act_pos12_7.ToString("f3");
                                Act_pos12_8 = Lib.ConnectPlc1.plcitems.Act_pos12_8.ToString("f3");
                                Act_pos12_9 = Lib.ConnectPlc1.plcitems.Act_pos12_9.ToString("f3");
                                Act_Speed12_2 = Lib.ConnectPlc1.plcitems.Act_Speed12_2.ToString("f3");
                                Act_Speed12_3 = Lib.ConnectPlc1.plcitems.Act_Speed12_3.ToString("f3");
                                Act_Speed12_4 = Lib.ConnectPlc1.plcitems.Act_Speed12_4.ToString("f3");
                                Act_Speed12_5 = Lib.ConnectPlc1.plcitems.Act_Speed12_5.ToString("f3");
                                Act_Speed12_6 = Lib.ConnectPlc1.plcitems.Act_Speed12_6.ToString("f3");
                                Act_Speed12_7 = Lib.ConnectPlc1.plcitems.Act_Speed12_7.ToString("f3");
                                Act_Speed12_8 = Lib.ConnectPlc1.plcitems.Act_Speed12_8.ToString("f3");
                                Act_Speed12_9 = Lib.ConnectPlc1.plcitems.Act_Speed12_9.ToString("f3");



                            });
                        }));
                return _asix12getvalue;
            }
        }
        private Command_film.MyCommand _asix13getvalue;
        public Command_film.MyCommand Asix13GetValue
        {
            get
            {
                if (_asix13getvalue == null)
                    _asix13getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed13 = Lib.ConnectPlc1.plcitems.Act_autoSpeed13.ToString("f3");
                                Act_manauSpeed13 = Lib.ConnectPlc1.plcitems.Act_manauSpeed13.ToString("f3");
                                Act_pos13 = Lib.ConnectPlc1.plcitems.Act_pos13.ToString("f3");
                                Act_pos1_13 = Lib.ConnectPlc1.plcitems.Act_pos1_13.ToString("f3");
                                Act_pos2_13 = Lib.ConnectPlc1.plcitems.Act_pos2_13.ToString("f3");
                                Act_pos13_2 = Lib.ConnectPlc1.plcitems.Act_pos13_2.ToString("f3");
                                Act_pos13_3 = Lib.ConnectPlc1.plcitems.Act_pos13_3.ToString("f3");
                                Act_pos13_4 = Lib.ConnectPlc1.plcitems.Act_pos13_4.ToString("f3");
                                Act_pos13_5 = Lib.ConnectPlc1.plcitems.Act_pos13_5.ToString("f3");
                                Act_pos13_6 = Lib.ConnectPlc1.plcitems.Act_pos13_6.ToString("f3");
                                Act_pos13_7 = Lib.ConnectPlc1.plcitems.Act_pos13_7.ToString("f3");
                                Act_pos13_8 = Lib.ConnectPlc1.plcitems.Act_pos13_8.ToString("f3");
                                Act_pos13_9 = Lib.ConnectPlc1.plcitems.Act_pos13_9.ToString("f3");
                                Act_Speed13_2 = Lib.ConnectPlc1.plcitems.Act_Speed13_2.ToString("f3");
                                Act_Speed13_3 = Lib.ConnectPlc1.plcitems.Act_Speed13_3.ToString("f3");
                                Act_Speed13_4 = Lib.ConnectPlc1.plcitems.Act_Speed13_4.ToString("f3");
                                Act_Speed13_5 = Lib.ConnectPlc1.plcitems.Act_Speed13_5.ToString("f3");
                                Act_Speed13_6 = Lib.ConnectPlc1.plcitems.Act_Speed13_6.ToString("f3");
                                Act_Speed13_7 = Lib.ConnectPlc1.plcitems.Act_Speed13_7.ToString("f3");
                                Act_Speed13_8 = Lib.ConnectPlc1.plcitems.Act_Speed13_8.ToString("f3");
                                Act_Speed13_9 = Lib.ConnectPlc1.plcitems.Act_Speed13_9.ToString("f3");



                            });
                        }));
                return _asix13getvalue;
            }
        }
        private Command_film.MyCommand _asix14getvalue;
        public Command_film.MyCommand Asix14GetValue
        {
            get
            {
                if (_asix14getvalue == null)
                    _asix14getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed14 = Lib.ConnectPlc1.plcitems.Act_autoSpeed14.ToString("f3");
                                Act_manauSpeed14 = Lib.ConnectPlc1.plcitems.Act_manauSpeed14.ToString("f3");
                                Act_pos14 = Lib.ConnectPlc1.plcitems.Act_pos14.ToString("f3");
                                Act_pos1_14 = Lib.ConnectPlc1.plcitems.Act_pos1_14.ToString("f3");
                                Act_pos2_14 = Lib.ConnectPlc1.plcitems.Act_pos2_14.ToString("f3");

                                Act_pos14_2 = Lib.ConnectPlc1.plcitems.Act_pos14_2.ToString("f3");
                                Act_pos14_3 = Lib.ConnectPlc1.plcitems.Act_pos14_3.ToString("f3");
                                Act_pos14_4 = Lib.ConnectPlc1.plcitems.Act_pos14_4.ToString("f3");
                                Act_pos14_5 = Lib.ConnectPlc1.plcitems.Act_pos14_5.ToString("f3");
                                Act_pos14_6 = Lib.ConnectPlc1.plcitems.Act_pos14_6.ToString("f3");
                                Act_pos14_7 = Lib.ConnectPlc1.plcitems.Act_pos14_7.ToString("f3");
                                Act_pos14_8 = Lib.ConnectPlc1.plcitems.Act_pos14_8.ToString("f3");
                                Act_pos14_9 = Lib.ConnectPlc1.plcitems.Act_pos14_9.ToString("f3");
                                Act_Speed14_2 = Lib.ConnectPlc1.plcitems.Act_Speed14_2.ToString("f3");
                                Act_Speed14_3 = Lib.ConnectPlc1.plcitems.Act_Speed14_3.ToString("f3");
                                Act_Speed14_4 = Lib.ConnectPlc1.plcitems.Act_Speed14_4.ToString("f3");
                                Act_Speed14_5 = Lib.ConnectPlc1.plcitems.Act_Speed14_5.ToString("f3");
                                Act_Speed14_6 = Lib.ConnectPlc1.plcitems.Act_Speed14_6.ToString("f3");
                                Act_Speed14_7 = Lib.ConnectPlc1.plcitems.Act_Speed14_7.ToString("f3");
                                Act_Speed14_8 = Lib.ConnectPlc1.plcitems.Act_Speed14_8.ToString("f3");
                                Act_Speed14_9 = Lib.ConnectPlc1.plcitems.Act_Speed14_9.ToString("f3");



                            });
                        }));
                return _asix14getvalue;
            }
        }
        private Command_film.MyCommand _asix15getvalue;
        public Command_film.MyCommand Asix15GetValue
        {
            get
            {
                if (_asix15getvalue == null)
                    _asix15getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {

                                Act_autoSpeed15 = Lib.ConnectPlc1.plcitems.Act_autoSpeed15.ToString("f3");
                                Act_manauSpeed15 = Lib.ConnectPlc1.plcitems.Act_manauSpeed15.ToString("f3");
                                Act_pos15 = Lib.ConnectPlc1.plcitems.Act_pos15.ToString("f3");
                                Act_pos1_15 = Lib.ConnectPlc1.plcitems.Act_pos1_15.ToString("f3");
                                Act_pos2_15 = Lib.ConnectPlc1.plcitems.Act_pos2_15.ToString("f3");

                                Act_pos15_2 = Lib.ConnectPlc1.plcitems.Act_pos15_2.ToString("f3");
                                Act_pos15_3 = Lib.ConnectPlc1.plcitems.Act_pos15_3.ToString("f3");
                                Act_pos15_4 = Lib.ConnectPlc1.plcitems.Act_pos15_4.ToString("f3");
                                Act_pos15_5 = Lib.ConnectPlc1.plcitems.Act_pos15_5.ToString("f3");
                                Act_pos15_6 = Lib.ConnectPlc1.plcitems.Act_pos15_6.ToString("f3");
                                Act_pos15_7 = Lib.ConnectPlc1.plcitems.Act_pos15_7.ToString("f3");
                                Act_pos15_8 = Lib.ConnectPlc1.plcitems.Act_pos15_8.ToString("f3");
                                Act_pos15_9 = Lib.ConnectPlc1.plcitems.Act_pos15_9.ToString("f3");
                                Act_Speed15_2 = Lib.ConnectPlc1.plcitems.Act_Speed15_2.ToString("f3");
                                Act_Speed15_3 = Lib.ConnectPlc1.plcitems.Act_Speed15_3.ToString("f3");
                                Act_Speed15_4 = Lib.ConnectPlc1.plcitems.Act_Speed15_4.ToString("f3");
                                Act_Speed15_5 = Lib.ConnectPlc1.plcitems.Act_Speed15_5.ToString("f3");
                                Act_Speed15_6 = Lib.ConnectPlc1.plcitems.Act_Speed15_6.ToString("f3");
                                Act_Speed15_7 = Lib.ConnectPlc1.plcitems.Act_Speed15_7.ToString("f3");
                                Act_Speed15_8 = Lib.ConnectPlc1.plcitems.Act_Speed15_8.ToString("f3");
                                Act_Speed15_9 = Lib.ConnectPlc1.plcitems.Act_Speed15_9.ToString("f3");



                            });
                        }));
                return _asix15getvalue;
            }
        }
        private Command_film.MyCommand _asix16getvalue;
        public Command_film.MyCommand Asix16GetValue
        {
            get
            {
                if (_asix16getvalue == null)
                    _asix16getvalue = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Task.Run(() =>
                            {
                                Act_autoSpeed16 = Lib.ConnectPlc1.plcitems.Act_autoSpeed16.ToString("f3");
                                Act_manauSpeed16 = Lib.ConnectPlc1.plcitems.Act_manauSpeed16.ToString("f3");
                                Act_pos16 = Lib.ConnectPlc1.plcitems.Act_pos16.ToString("f3");
                                Act_pos1_16 = Lib.ConnectPlc1.plcitems.Act_pos1_16.ToString("f3");
                                Act_pos2_16 = Lib.ConnectPlc1.plcitems.Act_pos2_16.ToString("f3");

                                Act_pos16_2 = Lib.ConnectPlc1.plcitems.Act_pos16_2.ToString("f3");
                                Act_pos16_3 = Lib.ConnectPlc1.plcitems.Act_pos16_3.ToString("f3");
                                Act_pos16_4 = Lib.ConnectPlc1.plcitems.Act_pos16_4.ToString("f3");
                                Act_pos16_5 = Lib.ConnectPlc1.plcitems.Act_pos16_5.ToString("f3");
                                Act_pos16_6 = Lib.ConnectPlc1.plcitems.Act_pos16_6.ToString("f3");
                                Act_pos16_7 = Lib.ConnectPlc1.plcitems.Act_pos16_7.ToString("f3");
                                Act_pos16_8 = Lib.ConnectPlc1.plcitems.Act_pos16_8.ToString("f3");
                                Act_pos16_9 = Lib.ConnectPlc1.plcitems.Act_pos16_9.ToString("f3");
                                Act_Speed16_2 = Lib.ConnectPlc1.plcitems.Act_Speed16_2.ToString("f3");
                                Act_Speed16_3 = Lib.ConnectPlc1.plcitems.Act_Speed16_3.ToString("f3");
                                Act_Speed16_4 = Lib.ConnectPlc1.plcitems.Act_Speed16_4.ToString("f3");
                                Act_Speed16_5 = Lib.ConnectPlc1.plcitems.Act_Speed16_5.ToString("f3");
                                Act_Speed16_6 = Lib.ConnectPlc1.plcitems.Act_Speed16_6.ToString("f3");
                                Act_Speed16_7 = Lib.ConnectPlc1.plcitems.Act_Speed16_7.ToString("f3");
                                Act_Speed16_8 = Lib.ConnectPlc1.plcitems.Act_Speed16_8.ToString("f3");
                                Act_Speed16_9 = Lib.ConnectPlc1.plcitems.Act_Speed16_9.ToString("f3");



                            });
                        }));
                return _asix16getvalue;
            }
        }
        #endregion
        #endregion
        #region CALIBURN
        public void LoadFMData(object e, string pr)
        {
            MessageBox.Show("123");
        }
        #endregion
        #region  LOG

        private List<string> errorlog1 = new List<string>();
        public List<string> Errorlog1 { get { return errorlog1; } set { errorlog1 = value; NotifyOfPropertyChange(() => Errorlog1); } }










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

            string filename = " H:/B11_Log/Wpf_notice - 副本/WpfApp1/bin/Debug/Log/LogError";
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
            string filename = " H:/B11_Log/Wpf_notice - 副本/WpfApp1/bin/Debug/Log/Logrun";
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
            string filename = " H:/B11_Log/Wpf_notice - 副本/WpfApp1/bin/Debug/Log/LogInfo";
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

        #region  字段
        //#region asix_par  public
        //#region 0

        //public string Act_Pos0 { get; set; }
        //public string Act_autoSpeed0 { get; set; }
        //public string Act_manauSpeed0 { get; set; }
        //public string Act_acc0 { get; set; }
        //public string Act_dec0 { get; set; }
        //public string Act_pos0 { get; set; }
        //public string Act_pos1_0 { get; set; }
        //public string Act_pos2_0 { get; set; }
        //#endregion
        //#region 1
        //public string Act_Pos1 { get; set; }
        //public string Act_autoSpeed1 { get; set; }
        //public string Act_manauSpeed1 { get; set; }
        //public string Act_acc1 { get; set; }
        //public string Act_dec1 { get; set; }
        //public string Act_pos1 { get; set; }
        //public string Act_pos1_1 { get; set; }
        //public string Act_pos2_1 { get; set; }
        //#endregion
        //#region 2
        //public string Act_Pos2 { get; set; }
        //public string Act_autoSpeed2 { get; set; }
        //public string Act_manauSpeed2 { get; set; }
        //public string Act_acc2 { get; set; }
        //public string Act_dec2 { get; set; }
        //public string Act_pos2 { get; set; }
        //public string Act_pos1_2 { get; set; }
        //public string Act_pos2_2 { get; set; }
        //#endregion
        //#region 3
        //public string Act_Pos3 { get; set; }
        //public string Act_autoSpeed3 { get; set; }
        //public string Act_manauSpeed3 { get; set; }
        //public string Act_acc3 { get; set; }
        //public string Act_dec3 { get; set; }
        //public string Act_pos3 { get; set; }
        //public string Act_pos1_3 { get; set; }
        //public string Act_pos2_3 { get; set; }
        //#endregion
        //#region 4
        //public string Act_Pos4 { get; set; }
        //public string Act_autoSpeed4 { get; set; }
        //public string Act_manauSpeed4 { get; set; }
        //public string Act_acc4 { get; set; }
        //public string Act_dec4 { get; set; }
        //public string Act_pos4 { get; set; }
        //public string Act_pos1_4 { get; set; }
        //public string Act_pos2_4 { get; set; }
        //#endregion
        //#region 5
        //public string Act_Pos5 { get; set; }
        //public string Act_autoSpeed5 { get; set; }
        //public string Act_manauSpeed5 { get; set; }
        //public string Act_acc5 { get; set; }
        //public string Act_dec5 { get; set; }
        //public string Act_pos5 { get; set; }
        //public string Act_pos1_5 { get; set; }
        //public string Act_pos2_5 { get; set; }
        //#endregion
        //#region 6
        //public string Act_Pos6 { get; set; }
        //public string Act_autoSpeed6 { get; set; }
        //public string Act_manauSpeed6 { get; set; }
        //public string Act_acc6 { get; set; }
        //public string Act_dec6 { get; set; }
        //public string Act_pos6 { get; set; }
        //public string Act_pos1_6 { get; set; }
        //public string Act_pos2_6 { get; set; }
        //#endregion
        //#region 7
        //public string Act_Pos7 { get; set; }
        //public string Act_autoSpeed7 { get; set; }
        //public string Act_manauSpeed7 { get; set; }
        //public string Act_acc7 { get; set; }
        //public string Act_dec7 { get; set; }
        //public string Act_pos7 { get; set; }
        //public string Act_pos1_7 { get; set; }
        //public string Act_pos2_7 { get; set; }
        //#endregion
        //#region 8
        //public string Act_Pos8 { get; set; }
        //public string Act_autoSpeed8 { get; set; }
        //public string Act_manauSpeed8 { get; set; }
        //public string Act_acc8 { get; set; }
        //public string Act_dec8 { get; set; }
        //public string Act_pos8 { get; set; }
        //public string Act_pos1_8 { get; set; }
        //public string Act_pos2_8 { get; set; }
        //#endregion
        //#region 9
        //public string Act_Pos9 { get; set; }
        //public string Act_autoSpeed9 { get; set; }
        //public string Act_manauSpeed9 { get; set; }
        //public string Act_acc9 { get; set; }
        //public string Act_dec9 { get; set; }
        //public string Act_pos9 { get; set; }
        //public string Act_pos1_9 { get; set; }
        //public string Act_pos2_9 { get; set; }
        //#endregion
        //#region 10
        //public string Act_Pos10 { get; set; }
        //public string Act_autoSpeed10 { get; set; }
        //public string Act_manauSpeed10 { get; set; }
        //public string Act_acc10 { get; set; }
        //public string Act_dec10 { get; set; }
        //public string Act_pos10 { get; set; }
        //public string Act_pos1_10 { get; set; }
        //public string Act_pos2_10 { get; set; }
        //#endregion
        //#region 11
        //public string Act_Pos11 { get; set; }
        //public string Act_autoSpeed11 { get; set; }
        //public string Act_manauSpeed11 { get; set; }
        //public string Act_acc11 { get; set; }
        //public string Act_dec11 { get; set; }
        //public string Act_pos11 { get; set; }
        //public string Act_pos1_11 { get; set; }
        //public string Act_pos2_11 { get; set; }
        //#endregion
        //#region 12
        //public string Act_Pos12 { get; set; }
        //public string Act_autoSpeed12 { get; set; }
        //public string Act_manauSpeed12 { get; set; }
        //public string Act_acc12 { get; set; }
        //public string Act_dec12 { get; set; }
        //public string Act_pos12 { get; set; }
        //public string Act_pos1_12 { get; set; }
        //public string Act_pos2_12 { get; set; }
        //#endregion
        //#region 13
        //public string Act_Pos13 { get; set; }
        //public string Act_autoSpeed13 { get; set; }
        //public string Act_manauSpeed13 { get; set; }
        //public string Act_acc13 { get; set; }
        //public string Act_dec13 { get; set; }
        //public string Act_pos13 { get; set; }
        //public string Act_pos1_13 { get; set; }
        //public string Act_pos2_13 { get; set; }
        //#endregion
        //#region 14
        //public string Act_Pos14 { get; set; }
        //public string Act_autoSpeed14 { get; set; }
        //public string Act_manauSpeed14 { get; set; }
        //public string Act_acc14 { get; set; }
        //public string Act_dec14 { get; set; }
        //public string Act_pos14 { get; set; }
        //public string Act_pos1_14 { get; set; }
        //public string Act_pos2_14 { get; set; }
        //#endregion
        //#region 15
        //public string Act_Pos15 { get; set; }
        //public string Act_autoSpeed15 { get; set; }
        //public string Act_manauSpeed15 { get; set; }
        //public string Act_acc15 { get; set; }
        //public string Act_dec15 { get; set; }
        //public string Act_pos15 { get; set; }
        //public string Act_pos1_15 { get; set; }
        //public string Act_pos2_15 { get; set; }
        //#endregion
        //#region  16
        //public string Act_Pos16 { get; set; }
        //public string Act_autoSpeed16 { get; set; }
        //public string Act_manauSpeed16 { get; set; }
        //public string Act_acc16 { get; set; }
        //public string Act_dec16 { get; set; }
        //public string Act_pos16 { get; set; }
        //public string Act_pos1_16 { get; set; }
        //public string Act_pos2_16 { get; set; }
        //#endregion
        //#endregion
        #region asix_par  public
        #region 0
        public string Error_Code0
        {
            get { return erroor_code0; }
            set
            {
                if (Regex.IsMatch(value, @"^\d"))
                { erroor_code0 = value; }

                NotifyOfPropertyChange(() => Error_Code0);
            }
        }
        public string Act_Posion0 { get { return _act_Pos0; } set { if (Regex.IsMatch(value, @"^\d")) { _act_Pos0 = value; } NotifyOfPropertyChange(() => Act_Posion0); } }
        public string Act_autoSpeed0
        {
            get { return _act_autoSpeed0; }
            set
            {
                if (Regex.IsMatch(value, @"\d$"))
                { _act_autoSpeed0 = value; }
                else
                {
                    {
                        Notice.Show("warn", "输入字符不是数字", 3, MessageBoxIcon.Success);
                    }
                }
                NotifyOfPropertyChange(() => Act_autoSpeed0);
            }
        }
        public string Act_manauSpeed0 { get { return _act_manauSpeed0; } set { _act_manauSpeed0 = value; NotifyOfPropertyChange(() => Act_manauSpeed0); } }
        public string Act_acc0 { get { return _act_acc0; } set { _act_acc0 = value; NotifyOfPropertyChange(() => Act_acc0); } }
        public string Act_dec0 { get { return _act_dec0; } set { _act_dec0 = value; NotifyOfPropertyChange(() => Act_dec0); } }
        public string Act_pos0 { get { return _act_pos0; } set { _act_pos0 = value; NotifyOfPropertyChange(() => Act_pos0); } }
        public string Act_pos1_0 { get { return _act_pos1_0; } set { _act_pos1_0 = value; NotifyOfPropertyChange(() => Act_pos1_0); } }
        public string Act_pos2_0 { get { return _act_pos2_0; } set { _act_pos2_0 = value; NotifyOfPropertyChange(() => Act_pos2_0); } }
        public String Act_pos00_2 { get { return act_pos00_2; } set { act_pos00_2 = value; NotifyOfPropertyChange(() => Act_pos00_2); } }
        public String Act_pos00_3 { get { return act_pos00_3; } set { act_pos00_3 = value; NotifyOfPropertyChange(() => Act_pos00_3); } }
        public String Act_pos00_4 { get { return act_pos00_4; } set { act_pos00_4 = value; NotifyOfPropertyChange(() => Act_pos00_4); } }
        public String Act_pos00_5 { get { return act_pos00_5; } set { act_pos00_5 = value; NotifyOfPropertyChange(() => Act_pos00_5); } }
        public String Act_pos00_6 { get { return act_pos00_6; } set { act_pos00_6 = value; NotifyOfPropertyChange(() => Act_pos00_6); } }
        public String Act_pos00_7 { get { return act_pos00_7; } set { act_pos00_7 = value; NotifyOfPropertyChange(() => Act_pos00_7); } }
        public String Act_pos00_8 { get { return act_pos00_8; } set { act_pos00_8 = value; NotifyOfPropertyChange(() => Act_pos00_8); } }
        public String Act_pos00_9 { get { return act_pos00_9; } set { act_pos00_9 = value; NotifyOfPropertyChange(() => Act_pos00_9); } }
        public String Act_Speed00_2 { get { return act_Speed00_2; } set { act_Speed00_2 = value; NotifyOfPropertyChange(() => Act_Speed00_2); } }
        public String Act_Speed00_3 { get { return act_Speed00_3; } set { act_Speed00_3 = value; NotifyOfPropertyChange(() => Act_Speed00_3); } }
        public String Act_Speed00_4 { get { return act_Speed00_4; } set { act_Speed00_4 = value; NotifyOfPropertyChange(() => Act_Speed00_4); } }
        public String Act_Speed00_5 { get { return act_Speed00_5; } set { act_Speed00_5 = value; NotifyOfPropertyChange(() => Act_Speed00_5); } }
        public String Act_Speed00_6 { get { return act_Speed00_6; } set { act_Speed00_6 = value; NotifyOfPropertyChange(() => Act_Speed00_6); } }
        public String Act_Speed00_7 { get { return act_Speed00_7; } set { act_Speed00_7 = value; NotifyOfPropertyChange(() => Act_Speed00_7); } }
        public String Act_Speed00_8 { get { return act_Speed00_8; } set { act_Speed00_8 = value; NotifyOfPropertyChange(() => Act_Speed00_8); } }
        public String Act_Speed00_9 { get { return act_Speed00_9; } set { act_Speed00_9 = value; NotifyOfPropertyChange(() => Act_Speed00_9); } }
        #endregion
        #region 1
        public string Error_Code1 { get { return erroor_code1; } set { erroor_code1 = value; NotifyOfPropertyChange(() => Error_Code1); } }
        public string Act_Posion1 { get { return _act_Pos1; } set { _act_Pos1 = value; NotifyOfPropertyChange(() => Act_Posion1); } }
        public string Act_autoSpeed1 { get { return _act_autoSpeed1; } set { _act_autoSpeed1 = value; NotifyOfPropertyChange(() => Act_autoSpeed1); } }
        public string Act_manauSpeed1 { get { return _act_manauSpeed1; } set { _act_manauSpeed1 = value; NotifyOfPropertyChange(() => Act_manauSpeed1); } }
        public string Act_acc1 { get { return _act_acc1; } set { _act_acc1 = value; NotifyOfPropertyChange(() => Act_acc1); } }
        public string Act_dec1 { get { return _act_dec1; } set { _act_dec1 = value; NotifyOfPropertyChange(() => Act_dec1); } }
        public string Act_pos1 { get { return _act_pos1; } set { _act_pos1 = value; NotifyOfPropertyChange(() => Act_pos1); } }
        public string Act_pos1_1 { get { return _act_pos1_1; } set { _act_pos1_1 = value; NotifyOfPropertyChange(() => Act_pos1_1); } }
        public string Act_pos2_1 { get { return _act_pos2_1; } set { _act_pos2_1 = value; NotifyOfPropertyChange(() => Act_pos2_1); } }

        public String Act_pos01_2 { get { return act_pos01_2; } set { act_pos01_2 = value; NotifyOfPropertyChange(() => Act_pos01_2); } }
        public String Act_pos01_3 { get { return act_pos01_3; } set { act_pos01_3 = value; NotifyOfPropertyChange(() => Act_pos01_3); } }
        public String Act_pos01_4 { get { return act_pos01_4; } set { act_pos01_4 = value; NotifyOfPropertyChange(() => Act_pos01_4); } }
        public String Act_pos01_5 { get { return act_pos01_5; } set { act_pos01_5 = value; NotifyOfPropertyChange(() => Act_pos01_5); } }
        public String Act_pos01_6 { get { return act_pos01_6; } set { act_pos01_6 = value; NotifyOfPropertyChange(() => Act_pos01_6); } }
        public String Act_pos01_7 { get { return act_pos01_7; } set { act_pos01_7 = value; NotifyOfPropertyChange(() => Act_pos01_7); } }
        public String Act_pos01_8 { get { return act_pos01_8; } set { act_pos01_8 = value; NotifyOfPropertyChange(() => Act_pos01_8); } }
        public String Act_pos01_9 { get { return act_pos01_9; } set { act_pos01_9 = value; NotifyOfPropertyChange(() => Act_pos01_9); } }
        public String Act_Speed01_2 { get { return act_Speed01_2; } set { act_Speed01_2 = value; NotifyOfPropertyChange(() => Act_Speed01_2); } }
        public String Act_Speed01_3 { get { return act_Speed01_3; } set { act_Speed01_3 = value; NotifyOfPropertyChange(() => Act_Speed01_3); } }
        public String Act_Speed01_4 { get { return act_Speed01_4; } set { act_Speed01_4 = value; NotifyOfPropertyChange(() => Act_Speed01_4); } }
        public String Act_Speed01_5 { get { return act_Speed01_5; } set { act_Speed01_5 = value; NotifyOfPropertyChange(() => Act_Speed01_5); } }
        public String Act_Speed01_6 { get { return act_Speed01_6; } set { act_Speed01_6 = value; NotifyOfPropertyChange(() => Act_Speed01_6); } }
        public String Act_Speed01_7 { get { return act_Speed01_7; } set { act_Speed01_7 = value; NotifyOfPropertyChange(() => Act_Speed01_7); } }
        public String Act_Speed01_8 { get { return act_Speed01_8; } set { act_Speed01_8 = value; NotifyOfPropertyChange(() => Act_Speed01_8); } }
        public String Act_Speed01_9 { get { return act_Speed01_9; } set { act_Speed01_9 = value; NotifyOfPropertyChange(() => Act_Speed01_9); } }

        #endregion
        #region 2
        public string Error_Code2 { get { return erroor_code2; } set { erroor_code2 = value; NotifyOfPropertyChange(() => Error_Code2); } }
        public string Act_Posion2 { get { return _act_Pos2; } set { _act_Pos2 = value; NotifyOfPropertyChange(() => Act_Posion2); } }
        public string Act_autoSpeed2 { get { return _act_autoSpeed2; } set { _act_autoSpeed2 = value; NotifyOfPropertyChange(() => Act_autoSpeed2); } }
        public string Act_manauSpeed2 { get { return _act_manauSpeed2; } set { _act_manauSpeed2 = value; NotifyOfPropertyChange(() => Act_manauSpeed2); } }
        public string Act_acc2 { get { return _act_acc2; } set { _act_acc2 = value; NotifyOfPropertyChange(() => Act_acc2); } }
        public string Act_dec2 { get { return _act_dec2; } set { _act_dec2 = value; NotifyOfPropertyChange(() => Act_dec2); } }
        public string Act_pos2 { get { return _act_pos2; } set { _act_pos2 = value; NotifyOfPropertyChange(() => Act_pos2); } }
        public string Act_pos1_2 { get { return _act_pos1_2; } set { _act_pos1_2 = value; NotifyOfPropertyChange(() => Act_pos1_2); } }
        public string Act_pos2_2 { get { return _act_pos2_2; } set { _act_pos2_2 = value; NotifyOfPropertyChange(() => Act_pos2_2); } }

        public String Act_pos02_2 { get { return act_pos02_2; } set { act_pos02_2 = value; NotifyOfPropertyChange(() => Act_pos02_2); } }
        public String Act_pos02_3 { get { return act_pos02_3; } set { act_pos02_3 = value; NotifyOfPropertyChange(() => Act_pos02_3); } }
        public String Act_pos02_4 { get { return act_pos02_4; } set { act_pos02_4 = value; NotifyOfPropertyChange(() => Act_pos02_4); } }
        public String Act_pos02_5 { get { return act_pos02_5; } set { act_pos02_5 = value; NotifyOfPropertyChange(() => Act_pos02_5); } }
        public String Act_pos02_6 { get { return act_pos02_6; } set { act_pos02_6 = value; NotifyOfPropertyChange(() => Act_pos02_6); } }
        public String Act_pos02_7 { get { return act_pos02_7; } set { act_pos02_7 = value; NotifyOfPropertyChange(() => Act_pos02_7); } }
        public String Act_pos02_8 { get { return act_pos02_8; } set { act_pos02_8 = value; NotifyOfPropertyChange(() => Act_pos02_8); } }
        public String Act_pos02_9 { get { return act_pos02_9; } set { act_pos02_9 = value; NotifyOfPropertyChange(() => Act_pos02_9); } }
        public String Act_Speed02_2 { get { return act_Speed02_2; } set { act_Speed02_2 = value; NotifyOfPropertyChange(() => Act_Speed02_2); } }
        public String Act_Speed02_3 { get { return act_Speed02_3; } set { act_Speed02_3 = value; NotifyOfPropertyChange(() => Act_Speed02_3); } }
        public String Act_Speed02_4 { get { return act_Speed02_4; } set { act_Speed02_4 = value; NotifyOfPropertyChange(() => Act_Speed02_4); } }
        public String Act_Speed02_5 { get { return act_Speed02_5; } set { act_Speed02_5 = value; NotifyOfPropertyChange(() => Act_Speed02_5); } }
        public String Act_Speed02_6 { get { return act_Speed02_6; } set { act_Speed02_6 = value; NotifyOfPropertyChange(() => Act_Speed02_6); } }
        public String Act_Speed02_7 { get { return act_Speed02_7; } set { act_Speed02_7 = value; NotifyOfPropertyChange(() => Act_Speed02_7); } }
        public String Act_Speed02_8 { get { return act_Speed02_8; } set { act_Speed02_8 = value; NotifyOfPropertyChange(() => Act_Speed02_8); } }
        public String Act_Speed02_9 { get { return act_Speed02_9; } set { act_Speed02_9 = value; NotifyOfPropertyChange(() => Act_Speed02_9); } }

        #endregion
        #region 3
        public string Error_Code3 { get { return erroor_code3; } set { erroor_code3 = value; NotifyOfPropertyChange(() => Error_Code3); } }
        public string Act_Posion3 { get { return _act_Pos3; } set { _act_Pos3 = value; NotifyOfPropertyChange(() => Act_Posion3); } }
        public string Act_autoSpeed3 { get { return _act_autoSpeed3; } set { _act_autoSpeed3 = value; NotifyOfPropertyChange(() => Act_autoSpeed3); } }
        public string Act_manauSpeed3 { get { return _act_manauSpeed3; } set { _act_manauSpeed3 = value; NotifyOfPropertyChange(() => Act_manauSpeed3); } }
        public string Act_acc3 { get { return _act_acc3; } set { _act_acc3 = value; NotifyOfPropertyChange(() => Act_acc3); } }
        public string Act_dec3 { get { return _act_dec3; } set { _act_dec3 = value; NotifyOfPropertyChange(() => Act_dec3); } }
        public string Act_pos3 { get { return _act_pos3; } set { _act_pos3 = value; NotifyOfPropertyChange(() => Act_pos3); } }
        public string Act_pos1_3 { get { return _act_pos1_3; } set { _act_pos1_3 = value; NotifyOfPropertyChange(() => Act_pos1_3); } }
        public string Act_pos2_3 { get { return _act_pos2_3; } set { _act_pos2_3 = value; NotifyOfPropertyChange(() => Act_pos2_3); } }

        public String Act_pos03_2 { get { return act_pos03_2; } set { act_pos03_2 = value; NotifyOfPropertyChange(() => Act_pos03_2); } }
        public String Act_pos03_3 { get { return act_pos03_3; } set { act_pos03_3 = value; NotifyOfPropertyChange(() => Act_pos03_3); } }
        public String Act_pos03_4 { get { return act_pos03_4; } set { act_pos03_4 = value; NotifyOfPropertyChange(() => Act_pos03_4); } }
        public String Act_pos03_5 { get { return act_pos03_5; } set { act_pos03_5 = value; NotifyOfPropertyChange(() => Act_pos03_5); } }
        public String Act_pos03_6 { get { return act_pos03_6; } set { act_pos03_6 = value; NotifyOfPropertyChange(() => Act_pos03_6); } }
        public String Act_pos03_7 { get { return act_pos03_7; } set { act_pos03_7 = value; NotifyOfPropertyChange(() => Act_pos03_7); } }
        public String Act_pos03_8 { get { return act_pos03_8; } set { act_pos03_8 = value; NotifyOfPropertyChange(() => Act_pos03_8); } }
        public String Act_pos03_9 { get { return act_pos03_9; } set { act_pos03_9 = value; NotifyOfPropertyChange(() => Act_pos03_9); } }
        public String Act_Speed03_2 { get { return act_Speed03_2; } set { act_Speed03_2 = value; NotifyOfPropertyChange(() => Act_Speed03_2); } }
        public String Act_Speed03_3 { get { return act_Speed03_3; } set { act_Speed03_3 = value; NotifyOfPropertyChange(() => Act_Speed03_3); } }
        public String Act_Speed03_4 { get { return act_Speed03_4; } set { act_Speed03_4 = value; NotifyOfPropertyChange(() => Act_Speed03_4); } }
        public String Act_Speed03_5 { get { return act_Speed03_5; } set { act_Speed03_5 = value; NotifyOfPropertyChange(() => Act_Speed03_5); } }
        public String Act_Speed03_6 { get { return act_Speed03_6; } set { act_Speed03_6 = value; NotifyOfPropertyChange(() => Act_Speed03_6); } }
        public String Act_Speed03_7 { get { return act_Speed03_7; } set { act_Speed03_7 = value; NotifyOfPropertyChange(() => Act_Speed03_7); } }
        public String Act_Speed03_8 { get { return act_Speed03_8; } set { act_Speed03_8 = value; NotifyOfPropertyChange(() => Act_Speed03_8); } }
        public String Act_Speed03_9 { get { return act_Speed03_9; } set { act_Speed03_9 = value; NotifyOfPropertyChange(() => Act_Speed03_9); } }

        #endregion
        #region 4
        public string Error_Code4 { get { return erroor_code4; } set { erroor_code4 = value; NotifyOfPropertyChange(() => Error_Code4); } }
        public string Act_Posion4 { get { return _act_Pos4; } set { _act_Pos4 = value; NotifyOfPropertyChange(() => Act_Posion4); } }
        public string Act_autoSpeed4 { get { return _act_autoSpeed4; } set { _act_autoSpeed4 = value; NotifyOfPropertyChange(() => Act_autoSpeed4); } }
        public string Act_manauSpeed4 { get { return _act_manauSpeed4; } set { _act_manauSpeed4 = value; NotifyOfPropertyChange(() => Act_manauSpeed4); } }
        public string Act_acc4 { get { return _act_acc4; } set { _act_acc4 = value; NotifyOfPropertyChange(() => Act_acc4); } }
        public string Act_dec4 { get { return _act_dec4; } set { _act_dec4 = value; NotifyOfPropertyChange(() => Act_dec4); } }
        public string Act_pos4 { get { return _act_pos4; } set { _act_pos4 = value; NotifyOfPropertyChange(() => Act_pos4); } }
        public string Act_pos1_4 { get { return _act_pos1_4; } set { _act_pos1_4 = value; NotifyOfPropertyChange(() => Act_pos1_4); } }
        public string Act_pos2_4 { get { return _act_pos2_4; } set { _act_pos2_4 = value; NotifyOfPropertyChange(() => Act_pos2_4); } }

        public String Act_pos04_2 { get { return act_pos04_2; } set { act_pos04_2 = value; NotifyOfPropertyChange(() => Act_pos04_2); } }
        public String Act_pos04_3 { get { return act_pos04_3; } set { act_pos04_3 = value; NotifyOfPropertyChange(() => Act_pos04_3); } }
        public String Act_pos04_4 { get { return act_pos04_4; } set { act_pos04_4 = value; NotifyOfPropertyChange(() => Act_pos04_4); } }
        public String Act_pos04_5 { get { return act_pos04_5; } set { act_pos04_5 = value; NotifyOfPropertyChange(() => Act_pos04_5); } }
        public String Act_pos04_6 { get { return act_pos04_6; } set { act_pos04_6 = value; NotifyOfPropertyChange(() => Act_pos04_6); } }
        public String Act_pos04_7 { get { return act_pos04_7; } set { act_pos04_7 = value; NotifyOfPropertyChange(() => Act_pos04_7); } }
        public String Act_pos04_8 { get { return act_pos04_8; } set { act_pos04_8 = value; NotifyOfPropertyChange(() => Act_pos04_8); } }
        public String Act_pos04_9 { get { return act_pos04_9; } set { act_pos04_9 = value; NotifyOfPropertyChange(() => Act_pos04_9); } }
        public String Act_Speed04_2 { get { return act_Speed04_2; } set { act_Speed04_2 = value; NotifyOfPropertyChange(() => Act_Speed04_2); } }
        public String Act_Speed04_3 { get { return act_Speed04_3; } set { act_Speed04_3 = value; NotifyOfPropertyChange(() => Act_Speed04_3); } }
        public String Act_Speed04_4 { get { return act_Speed04_4; } set { act_Speed04_4 = value; NotifyOfPropertyChange(() => Act_Speed04_4); } }
        public String Act_Speed04_5 { get { return act_Speed04_5; } set { act_Speed04_5 = value; NotifyOfPropertyChange(() => Act_Speed04_5); } }
        public String Act_Speed04_6 { get { return act_Speed04_6; } set { act_Speed04_6 = value; NotifyOfPropertyChange(() => Act_Speed04_6); } }
        public String Act_Speed04_7 { get { return act_Speed04_7; } set { act_Speed04_7 = value; NotifyOfPropertyChange(() => Act_Speed04_7); } }
        public String Act_Speed04_8 { get { return act_Speed04_8; } set { act_Speed04_8 = value; NotifyOfPropertyChange(() => Act_Speed04_8); } }
        public String Act_Speed04_9 { get { return act_Speed04_9; } set { act_Speed04_9 = value; NotifyOfPropertyChange(() => Act_Speed04_9); } }

        #endregion
        #region 5
        public string Error_Code5 { get { return erroor_code5; } set { erroor_code5 = value; NotifyOfPropertyChange(() => Error_Code5); } }
        public string Act_Posion5 { get { return _act_Pos5; } set { _act_Pos5 = value; NotifyOfPropertyChange(() => Act_Posion5); } }
        public string Act_autoSpeed5 { get { return _act_autoSpeed5; } set { _act_autoSpeed5 = value; NotifyOfPropertyChange(() => Act_autoSpeed5); } }
        public string Act_manauSpeed5 { get { return _act_manauSpeed5; } set { _act_manauSpeed5 = value; NotifyOfPropertyChange(() => Act_manauSpeed5); } }
        public string Act_acc5 { get { return _act_acc5; } set { _act_acc5 = value; NotifyOfPropertyChange(() => Act_acc5); } }
        public string Act_dec5 { get { return _act_dec5; } set { _act_dec5 = value; NotifyOfPropertyChange(() => Act_dec5); } }
        public string Act_pos5 { get { return _act_pos5; } set { _act_pos5 = value; NotifyOfPropertyChange(() => Act_pos5); } }
        public string Act_pos1_5 { get { return _act_pos1_5; } set { _act_pos1_5 = value; NotifyOfPropertyChange(() => Act_pos1_5); } }
        public string Act_pos2_5 { get { return _act_pos2_5; } set { _act_pos2_5 = value; NotifyOfPropertyChange(() => Act_pos2_5); } }

        public String Act_pos05_2 { get { return act_pos05_2; } set { act_pos05_2 = value; NotifyOfPropertyChange(() => Act_pos05_2); } }
        public String Act_pos05_3 { get { return act_pos05_3; } set { act_pos05_3 = value; NotifyOfPropertyChange(() => Act_pos05_3); } }
        public String Act_pos05_4 { get { return act_pos05_4; } set { act_pos05_4 = value; NotifyOfPropertyChange(() => Act_pos05_4); } }
        public String Act_pos05_5 { get { return act_pos05_5; } set { act_pos05_5 = value; NotifyOfPropertyChange(() => Act_pos05_5); } }
        public String Act_pos05_6 { get { return act_pos05_6; } set { act_pos05_6 = value; NotifyOfPropertyChange(() => Act_pos05_6); } }
        public String Act_pos05_7 { get { return act_pos05_7; } set { act_pos05_7 = value; NotifyOfPropertyChange(() => Act_pos05_7); } }
        public String Act_pos05_8 { get { return act_pos05_8; } set { act_pos05_8 = value; NotifyOfPropertyChange(() => Act_pos05_8); } }
        public String Act_pos05_9 { get { return act_pos05_9; } set { act_pos05_9 = value; NotifyOfPropertyChange(() => Act_pos05_9); } }
        public String Act_Speed05_2 { get { return act_Speed05_2; } set { act_Speed05_2 = value; NotifyOfPropertyChange(() => Act_Speed05_2); } }
        public String Act_Speed05_3 { get { return act_Speed05_3; } set { act_Speed05_3 = value; NotifyOfPropertyChange(() => Act_Speed05_3); } }
        public String Act_Speed05_4 { get { return act_Speed05_4; } set { act_Speed05_4 = value; NotifyOfPropertyChange(() => Act_Speed05_4); } }
        public String Act_Speed05_5 { get { return act_Speed05_5; } set { act_Speed05_5 = value; NotifyOfPropertyChange(() => Act_Speed05_5); } }
        public String Act_Speed05_6 { get { return act_Speed05_6; } set { act_Speed05_6 = value; NotifyOfPropertyChange(() => Act_Speed05_6); } }
        public String Act_Speed05_7 { get { return act_Speed05_7; } set { act_Speed05_7 = value; NotifyOfPropertyChange(() => Act_Speed05_7); } }
        public String Act_Speed05_8 { get { return act_Speed05_8; } set { act_Speed05_8 = value; NotifyOfPropertyChange(() => Act_Speed05_8); } }
        public String Act_Speed05_9 { get { return act_Speed05_9; } set { act_Speed05_9 = value; NotifyOfPropertyChange(() => Act_Speed05_9); } }

        #endregion
        #region 6
        public string Error_Code6 { get { return erroor_code6; } set { erroor_code6 = value; NotifyOfPropertyChange(() => Error_Code6); } }
        public string Act_Posion6 { get { return _act_Pos6; } set { _act_Pos6 = value; NotifyOfPropertyChange(() => Act_Posion6); } }
        public string Act_autoSpeed6 { get { return _act_autoSpeed6; } set { _act_autoSpeed6 = value; NotifyOfPropertyChange(() => Act_autoSpeed6); } }
        public string Act_manauSpeed6 { get { return _act_manauSpeed6; } set { _act_manauSpeed6 = value; NotifyOfPropertyChange(() => Act_manauSpeed6); } }
        public string Act_acc6 { get { return _act_acc6; } set { _act_acc6 = value; NotifyOfPropertyChange(() => Act_acc6); } }
        public string Act_dec6 { get { return _act_dec6; } set { _act_dec6 = value; NotifyOfPropertyChange(() => Act_dec6); } }
        public string Act_pos6 { get { return _act_pos6; } set { _act_pos6 = value; NotifyOfPropertyChange(() => Act_pos6); } }
        public string Act_pos1_6 { get { return _act_pos1_6; } set { _act_pos1_6 = value; NotifyOfPropertyChange(() => Act_pos1_6); } }
        public string Act_pos2_6 { get { return _act_pos2_6; } set { _act_pos2_6 = value; NotifyOfPropertyChange(() => Act_pos2_6); } }

        public String Act_pos06_2 { get { return act_pos06_2; } set { act_pos06_2 = value; NotifyOfPropertyChange(() => Act_pos06_2); } }
        public String Act_pos06_3 { get { return act_pos06_3; } set { act_pos06_3 = value; NotifyOfPropertyChange(() => Act_pos06_3); } }
        public String Act_pos06_4 { get { return act_pos06_4; } set { act_pos06_4 = value; NotifyOfPropertyChange(() => Act_pos06_4); } }
        public String Act_pos06_5 { get { return act_pos06_5; } set { act_pos06_5 = value; NotifyOfPropertyChange(() => Act_pos06_5); } }
        public String Act_pos06_6 { get { return act_pos06_6; } set { act_pos06_6 = value; NotifyOfPropertyChange(() => Act_pos06_6); } }
        public String Act_pos06_7 { get { return act_pos06_7; } set { act_pos06_7 = value; NotifyOfPropertyChange(() => Act_pos06_7); } }
        public String Act_pos06_8 { get { return act_pos06_8; } set { act_pos06_8 = value; NotifyOfPropertyChange(() => Act_pos06_8); } }
        public String Act_pos06_9 { get { return act_pos06_9; } set { act_pos06_9 = value; NotifyOfPropertyChange(() => Act_pos06_9); } }
        public String Act_Speed06_2 { get { return act_Speed06_2; } set { act_Speed06_2 = value; NotifyOfPropertyChange(() => Act_Speed06_2); } }
        public String Act_Speed06_3 { get { return act_Speed06_3; } set { act_Speed06_3 = value; NotifyOfPropertyChange(() => Act_Speed06_3); } }
        public String Act_Speed06_4 { get { return act_Speed06_4; } set { act_Speed06_4 = value; NotifyOfPropertyChange(() => Act_Speed06_4); } }
        public String Act_Speed06_5 { get { return act_Speed06_5; } set { act_Speed06_5 = value; NotifyOfPropertyChange(() => Act_Speed06_5); } }
        public String Act_Speed06_6 { get { return act_Speed06_6; } set { act_Speed06_6 = value; NotifyOfPropertyChange(() => Act_Speed06_6); } }
        public String Act_Speed06_7 { get { return act_Speed06_7; } set { act_Speed06_7 = value; NotifyOfPropertyChange(() => Act_Speed06_7); } }
        public String Act_Speed06_8 { get { return act_Speed06_8; } set { act_Speed06_8 = value; NotifyOfPropertyChange(() => Act_Speed06_8); } }
        public String Act_Speed06_9 { get { return act_Speed06_9; } set { act_Speed06_9 = value; NotifyOfPropertyChange(() => Act_Speed06_9); } }

        #endregion
        #region 7
        public string Error_Code7 { get { return erroor_code7; } set { erroor_code7 = value; NotifyOfPropertyChange(() => Error_Code7); } }
        public string Act_Posion7 { get { return _act_Pos7; } set { _act_Pos7 = value; NotifyOfPropertyChange(() => Act_Posion7); } }
        public string Act_autoSpeed7 { get { return _act_autoSpeed7; } set { _act_autoSpeed7 = value; NotifyOfPropertyChange(() => Act_autoSpeed7); } }
        public string Act_manauSpeed7 { get { return _act_manauSpeed7; } set { _act_manauSpeed7 = value; NotifyOfPropertyChange(() => Act_manauSpeed7); } }
        public string Act_acc7 { get { return _act_acc7; } set { _act_acc7 = value; NotifyOfPropertyChange(() => Act_acc7); } }
        public string Act_dec7 { get { return _act_dec7; } set { _act_dec7 = value; NotifyOfPropertyChange(() => Act_dec7); } }
        public string Act_pos7 { get { return _act_pos7; } set { _act_pos7 = value; NotifyOfPropertyChange(() => Act_pos7); } }
        public string Act_pos1_7 { get { return _act_pos1_7; } set { _act_pos1_7 = value; NotifyOfPropertyChange(() => Act_pos1_7); } }
        public string Act_pos2_7 { get { return _act_pos2_7; } set { _act_pos2_7 = value; NotifyOfPropertyChange(() => Act_pos2_7); } }

        public String Act_pos07_2 { get { return act_pos07_2; } set { act_pos07_2 = value; NotifyOfPropertyChange(() => Act_pos07_2); } }
        public String Act_pos07_3 { get { return act_pos07_3; } set { act_pos07_3 = value; NotifyOfPropertyChange(() => Act_pos07_3); } }
        public String Act_pos07_4 { get { return act_pos07_4; } set { act_pos07_4 = value; NotifyOfPropertyChange(() => Act_pos07_4); } }
        public String Act_pos07_5 { get { return act_pos07_5; } set { act_pos07_5 = value; NotifyOfPropertyChange(() => Act_pos07_5); } }
        public String Act_pos07_6 { get { return act_pos07_6; } set { act_pos07_6 = value; NotifyOfPropertyChange(() => Act_pos07_6); } }
        public String Act_pos07_7 { get { return act_pos07_7; } set { act_pos07_7 = value; NotifyOfPropertyChange(() => Act_pos07_7); } }
        public String Act_pos07_8 { get { return act_pos07_8; } set { act_pos07_8 = value; NotifyOfPropertyChange(() => Act_pos07_8); } }
        public String Act_pos07_9 { get { return act_pos07_9; } set { act_pos07_9 = value; NotifyOfPropertyChange(() => Act_pos07_9); } }
        public String Act_Speed07_2 { get { return act_Speed07_2; } set { act_Speed07_2 = value; NotifyOfPropertyChange(() => Act_Speed07_2); } }
        public String Act_Speed07_3 { get { return act_Speed07_3; } set { act_Speed07_3 = value; NotifyOfPropertyChange(() => Act_Speed07_3); } }
        public String Act_Speed07_4 { get { return act_Speed07_4; } set { act_Speed07_4 = value; NotifyOfPropertyChange(() => Act_Speed07_4); } }
        public String Act_Speed07_5 { get { return act_Speed07_5; } set { act_Speed07_5 = value; NotifyOfPropertyChange(() => Act_Speed07_5); } }
        public String Act_Speed07_6 { get { return act_Speed07_6; } set { act_Speed07_6 = value; NotifyOfPropertyChange(() => Act_Speed07_6); } }
        public String Act_Speed07_7 { get { return act_Speed07_7; } set { act_Speed07_7 = value; NotifyOfPropertyChange(() => Act_Speed07_7); } }
        public String Act_Speed07_8 { get { return act_Speed07_8; } set { act_Speed07_8 = value; NotifyOfPropertyChange(() => Act_Speed07_8); } }
        public String Act_Speed07_9 { get { return act_Speed07_9; } set { act_Speed07_9 = value; NotifyOfPropertyChange(() => Act_Speed07_9); } }

        #endregion
        #region 8
        public string Error_Code8 { get { return erroor_code8; } set { erroor_code8 = value; NotifyOfPropertyChange(() => Error_Code8); } }
        public string Act_Posion8 { get { return _act_Pos8; } set { _act_Pos8 = value; NotifyOfPropertyChange(() => Act_Posion8); } }
        public string Act_autoSpeed8 { get { return _act_autoSpeed8; } set { _act_autoSpeed8 = value; NotifyOfPropertyChange(() => Act_autoSpeed8); } }
        public string Act_manauSpeed8 { get { return _act_manauSpeed8; } set { _act_manauSpeed8 = value; NotifyOfPropertyChange(() => Act_manauSpeed8); } }
        public string Act_acc8 { get { return _act_acc8; } set { _act_acc8 = value; NotifyOfPropertyChange(() => Act_acc8); } }
        public string Act_dec8 { get { return _act_dec8; } set { _act_dec8 = value; NotifyOfPropertyChange(() => Act_dec8); } }
        public string Act_pos8 { get { return _act_pos8; } set { _act_pos8 = value; NotifyOfPropertyChange(() => Act_pos8); } }
        public string Act_pos1_8 { get { return _act_pos1_8; } set { _act_pos1_8 = value; NotifyOfPropertyChange(() => Act_pos1_8); } }
        public string Act_pos2_8 { get { return _act_pos2_8; } set { _act_pos2_8 = value; NotifyOfPropertyChange(() => Act_pos2_8); } }

        public String Act_pos08_2 { get { return act_pos08_2; } set { act_pos08_2 = value; NotifyOfPropertyChange(() => Act_pos08_2); } }
        public String Act_pos08_3 { get { return act_pos08_3; } set { act_pos08_3 = value; NotifyOfPropertyChange(() => Act_pos08_3); } }
        public String Act_pos08_4 { get { return act_pos08_4; } set { act_pos08_4 = value; NotifyOfPropertyChange(() => Act_pos08_4); } }
        public String Act_pos08_5 { get { return act_pos08_5; } set { act_pos08_5 = value; NotifyOfPropertyChange(() => Act_pos08_5); } }
        public String Act_pos08_6 { get { return act_pos08_6; } set { act_pos08_6 = value; NotifyOfPropertyChange(() => Act_pos08_6); } }
        public String Act_pos08_7 { get { return act_pos08_7; } set { act_pos08_7 = value; NotifyOfPropertyChange(() => Act_pos08_7); } }
        public String Act_pos08_8 { get { return act_pos08_8; } set { act_pos08_8 = value; NotifyOfPropertyChange(() => Act_pos08_8); } }
        public String Act_pos08_9 { get { return act_pos08_9; } set { act_pos08_9 = value; NotifyOfPropertyChange(() => Act_pos08_9); } }
        public String Act_Speed08_2 { get { return act_Speed08_2; } set { act_Speed08_2 = value; NotifyOfPropertyChange(() => Act_Speed08_2); } }
        public String Act_Speed08_3 { get { return act_Speed08_3; } set { act_Speed08_3 = value; NotifyOfPropertyChange(() => Act_Speed08_3); } }
        public String Act_Speed08_4 { get { return act_Speed08_4; } set { act_Speed08_4 = value; NotifyOfPropertyChange(() => Act_Speed08_4); } }
        public String Act_Speed08_5 { get { return act_Speed08_5; } set { act_Speed08_5 = value; NotifyOfPropertyChange(() => Act_Speed08_5); } }
        public String Act_Speed08_6 { get { return act_Speed08_6; } set { act_Speed08_6 = value; NotifyOfPropertyChange(() => Act_Speed08_6); } }
        public String Act_Speed08_7 { get { return act_Speed08_7; } set { act_Speed08_7 = value; NotifyOfPropertyChange(() => Act_Speed08_7); } }
        public String Act_Speed08_8 { get { return act_Speed08_8; } set { act_Speed08_8 = value; NotifyOfPropertyChange(() => Act_Speed08_8); } }
        public String Act_Speed08_9 { get { return act_Speed08_9; } set { act_Speed08_9 = value; NotifyOfPropertyChange(() => Act_Speed08_9); } }

        #endregion
        #region 9
        public string Error_Code9 { get { return erroor_code9; } set { erroor_code9 = value; NotifyOfPropertyChange(() => Error_Code9); } }
        public string Act_Posion9 { get { return _act_Pos9; } set { _act_Pos9 = value; NotifyOfPropertyChange(() => Act_Posion9); } }
        public string Act_autoSpeed9 { get { return _act_autoSpeed9; } set { _act_autoSpeed9 = value; NotifyOfPropertyChange(() => Act_autoSpeed9); } }
        public string Act_manauSpeed9 { get { return _act_manauSpeed9; } set { _act_manauSpeed9 = value; NotifyOfPropertyChange(() => Act_manauSpeed9); } }
        public string Act_acc9 { get { return _act_acc9; } set { _act_acc9 = value; NotifyOfPropertyChange(() => Act_acc9); } }
        public string Act_dec9 { get { return _act_dec9; } set { _act_dec9 = value; NotifyOfPropertyChange(() => Act_dec9); } }
        public string Act_pos9 { get { return _act_pos9; } set { _act_pos9 = value; NotifyOfPropertyChange(() => Act_pos9); } }
        public string Act_pos1_9 { get { return _act_pos1_9; } set { _act_pos1_9 = value; NotifyOfPropertyChange(() => Act_pos1_9); } }
        public string Act_pos2_9 { get { return _act_pos2_9; } set { _act_pos2_9 = value; NotifyOfPropertyChange(() => Act_pos2_9); } }

        public String Act_pos09_2 { get { return act_pos09_2; } set { act_pos09_2 = value; NotifyOfPropertyChange(() => Act_pos09_2); } }
        public String Act_pos09_3 { get { return act_pos09_3; } set { act_pos09_3 = value; NotifyOfPropertyChange(() => Act_pos09_3); } }
        public String Act_pos09_4 { get { return act_pos09_4; } set { act_pos09_4 = value; NotifyOfPropertyChange(() => Act_pos09_4); } }
        public String Act_pos09_5 { get { return act_pos09_5; } set { act_pos09_5 = value; NotifyOfPropertyChange(() => Act_pos09_5); } }
        public String Act_pos09_6 { get { return act_pos09_6; } set { act_pos09_6 = value; NotifyOfPropertyChange(() => Act_pos09_6); } }
        public String Act_pos09_7 { get { return act_pos09_7; } set { act_pos09_7 = value; NotifyOfPropertyChange(() => Act_pos09_7); } }
        public String Act_pos09_8 { get { return act_pos09_8; } set { act_pos09_8 = value; NotifyOfPropertyChange(() => Act_pos09_8); } }
        public String Act_pos09_9 { get { return act_pos09_9; } set { act_pos09_9 = value; NotifyOfPropertyChange(() => Act_pos09_9); } }
        public String Act_Speed09_2 { get { return act_Speed09_2; } set { act_Speed09_2 = value; NotifyOfPropertyChange(() => Act_Speed09_2); } }
        public String Act_Speed09_3 { get { return act_Speed09_3; } set { act_Speed09_3 = value; NotifyOfPropertyChange(() => Act_Speed09_3); } }
        public String Act_Speed09_4 { get { return act_Speed09_4; } set { act_Speed09_4 = value; NotifyOfPropertyChange(() => Act_Speed09_4); } }
        public String Act_Speed09_5 { get { return act_Speed09_5; } set { act_Speed09_5 = value; NotifyOfPropertyChange(() => Act_Speed09_5); } }
        public String Act_Speed09_6 { get { return act_Speed09_6; } set { act_Speed09_6 = value; NotifyOfPropertyChange(() => Act_Speed09_6); } }
        public String Act_Speed09_7 { get { return act_Speed09_7; } set { act_Speed09_7 = value; NotifyOfPropertyChange(() => Act_Speed09_7); } }
        public String Act_Speed09_8 { get { return act_Speed09_8; } set { act_Speed09_8 = value; NotifyOfPropertyChange(() => Act_Speed09_8); } }
        public String Act_Speed09_9 { get { return act_Speed09_9; } set { act_Speed09_9 = value; NotifyOfPropertyChange(() => Act_Speed09_9); } }

        #endregion
        #region 10
        public string Error_Code10 { get { return erroor_code10; } set { erroor_code10 = value; NotifyOfPropertyChange(() => Error_Code10); } }
        public string Act_Posion10 { get { return _act_Pos10; } set { _act_Pos10 = value; NotifyOfPropertyChange(() => Act_Posion10); } }
        public string Act_autoSpeed10 { get { return _act_autoSpeed10; } set { _act_autoSpeed10 = value; NotifyOfPropertyChange(() => Act_autoSpeed10); } }
        public string Act_manauSpeed10 { get { return _act_manauSpeed10; } set { _act_manauSpeed10 = value; NotifyOfPropertyChange(() => Act_manauSpeed10); } }
        public string Act_acc10 { get { return _act_acc10; } set { _act_acc10 = value; NotifyOfPropertyChange(() => Act_acc10); } }
        public string Act_dec10 { get { return _act_dec10; } set { _act_dec10 = value; NotifyOfPropertyChange(() => Act_dec10); } }
        public string Act_pos10 { get { return _act_pos10; } set { _act_pos10 = value; NotifyOfPropertyChange(() => Act_pos10); } }
        public string Act_pos1_10 { get { return _act_pos1_10; } set { _act_pos1_10 = value; NotifyOfPropertyChange(() => Act_pos1_10); } }
        public string Act_pos2_10 { get { return _act_pos2_10; } set { _act_pos2_10 = value; NotifyOfPropertyChange(() => Act_pos2_10); } }

        public String Act_pos10_2 { get { return act_pos10_2; } set { act_pos10_2 = value; NotifyOfPropertyChange(() => Act_pos10_2); } }
        public String Act_pos10_3 { get { return act_pos10_3; } set { act_pos10_3 = value; NotifyOfPropertyChange(() => Act_pos10_3); } }
        public String Act_pos10_4 { get { return act_pos10_4; } set { act_pos10_4 = value; NotifyOfPropertyChange(() => Act_pos10_4); } }
        public String Act_pos10_5 { get { return act_pos10_5; } set { act_pos10_5 = value; NotifyOfPropertyChange(() => Act_pos10_5); } }
        public String Act_pos10_6 { get { return act_pos10_6; } set { act_pos10_6 = value; NotifyOfPropertyChange(() => Act_pos10_6); } }
        public String Act_pos10_7 { get { return act_pos10_7; } set { act_pos10_7 = value; NotifyOfPropertyChange(() => Act_pos10_7); } }
        public String Act_pos10_8 { get { return act_pos10_8; } set { act_pos10_8 = value; NotifyOfPropertyChange(() => Act_pos10_8); } }
        public String Act_pos10_9 { get { return act_pos10_9; } set { act_pos10_9 = value; NotifyOfPropertyChange(() => Act_pos10_9); } }
        public String Act_Speed10_2 { get { return act_Speed10_2; } set { act_Speed10_2 = value; NotifyOfPropertyChange(() => Act_Speed10_2); } }
        public String Act_Speed10_3 { get { return act_Speed10_3; } set { act_Speed10_3 = value; NotifyOfPropertyChange(() => Act_Speed10_3); } }
        public String Act_Speed10_4 { get { return act_Speed10_4; } set { act_Speed10_4 = value; NotifyOfPropertyChange(() => Act_Speed10_4); } }
        public String Act_Speed10_5 { get { return act_Speed10_5; } set { act_Speed10_5 = value; NotifyOfPropertyChange(() => Act_Speed10_5); } }
        public String Act_Speed10_6 { get { return act_Speed10_6; } set { act_Speed10_6 = value; NotifyOfPropertyChange(() => Act_Speed10_6); } }
        public String Act_Speed10_7 { get { return act_Speed10_7; } set { act_Speed10_7 = value; NotifyOfPropertyChange(() => Act_Speed10_7); } }
        public String Act_Speed10_8 { get { return act_Speed10_8; } set { act_Speed10_8 = value; NotifyOfPropertyChange(() => Act_Speed10_8); } }
        public String Act_Speed10_9 { get { return act_Speed10_9; } set { act_Speed10_9 = value; NotifyOfPropertyChange(() => Act_Speed10_9); } }

        #endregion
        #region 11
        public string Error_Code11 { get { return erroor_code11; } set { erroor_code11 = value; NotifyOfPropertyChange(() => Error_Code11); } }
        public string Act_Posion11 { get { return _act_Pos11; } set { _act_Pos11 = value; NotifyOfPropertyChange(() => Act_Posion11); } }
        public string Act_autoSpeed11 { get { return _act_autoSpeed11; } set { _act_autoSpeed11 = value; NotifyOfPropertyChange(() => Act_autoSpeed11); } }
        public string Act_manauSpeed11 { get { return _act_manauSpeed11; } set { _act_manauSpeed11 = value; NotifyOfPropertyChange(() => Act_manauSpeed11); } }
        public string Act_acc11 { get { return _act_acc11; } set { _act_acc11 = value; NotifyOfPropertyChange(() => Act_acc11); } }
        public string Act_dec11 { get { return _act_dec11; } set { _act_dec11 = value; NotifyOfPropertyChange(() => Act_dec11); } }
        public string Act_pos11 { get { return _act_pos11; } set { _act_pos11 = value; NotifyOfPropertyChange(() => Act_pos11); } }
        public string Act_pos1_11 { get { return _act_pos1_11; } set { _act_pos1_11 = value; NotifyOfPropertyChange(() => Act_pos1_11); } }
        public string Act_pos2_11 { get { return _act_pos2_11; } set { _act_pos2_11 = value; NotifyOfPropertyChange(() => Act_pos2_11); } }

        public String Act_pos11_2 { get { return act_pos11_2; } set { act_pos11_2 = value; NotifyOfPropertyChange(() => Act_pos11_2); } }
        public String Act_pos11_3 { get { return act_pos11_3; } set { act_pos11_3 = value; NotifyOfPropertyChange(() => Act_pos11_3); } }
        public String Act_pos11_4 { get { return act_pos11_4; } set { act_pos11_4 = value; NotifyOfPropertyChange(() => Act_pos11_4); } }
        public String Act_pos11_5 { get { return act_pos11_5; } set { act_pos11_5 = value; NotifyOfPropertyChange(() => Act_pos11_5); } }
        public String Act_pos11_6 { get { return act_pos11_6; } set { act_pos11_6 = value; NotifyOfPropertyChange(() => Act_pos11_6); } }
        public String Act_pos11_7 { get { return act_pos11_7; } set { act_pos11_7 = value; NotifyOfPropertyChange(() => Act_pos11_7); } }
        public String Act_pos11_8 { get { return act_pos11_8; } set { act_pos11_8 = value; NotifyOfPropertyChange(() => Act_pos11_8); } }
        public String Act_pos11_9 { get { return act_pos11_9; } set { act_pos11_9 = value; NotifyOfPropertyChange(() => Act_pos11_9); } }
        public String Act_Speed11_2 { get { return act_Speed11_2; } set { act_Speed11_2 = value; NotifyOfPropertyChange(() => Act_Speed11_2); } }
        public String Act_Speed11_3 { get { return act_Speed11_3; } set { act_Speed11_3 = value; NotifyOfPropertyChange(() => Act_Speed11_3); } }
        public String Act_Speed11_4 { get { return act_Speed11_4; } set { act_Speed11_4 = value; NotifyOfPropertyChange(() => Act_Speed11_4); } }
        public String Act_Speed11_5 { get { return act_Speed11_5; } set { act_Speed11_5 = value; NotifyOfPropertyChange(() => Act_Speed11_5); } }
        public String Act_Speed11_6 { get { return act_Speed11_6; } set { act_Speed11_6 = value; NotifyOfPropertyChange(() => Act_Speed11_6); } }
        public String Act_Speed11_7 { get { return act_Speed11_7; } set { act_Speed11_7 = value; NotifyOfPropertyChange(() => Act_Speed11_7); } }
        public String Act_Speed11_8 { get { return act_Speed11_8; } set { act_Speed11_8 = value; NotifyOfPropertyChange(() => Act_Speed11_8); } }
        public String Act_Speed11_9 { get { return act_Speed11_9; } set { act_Speed11_9 = value; NotifyOfPropertyChange(() => Act_Speed11_9); } }

        #endregion
        #region 12
        public string Error_Code12 { get { return erroor_code12; } set { erroor_code12 = value; NotifyOfPropertyChange(() => Error_Code12); } }
        public string Act_Posion12 { get { return _act_Pos12; } set { _act_Pos12 = value; NotifyOfPropertyChange(() => Act_Posion12); } }
        public string Act_autoSpeed12 { get { return _act_autoSpeed12; } set { _act_autoSpeed12 = value; NotifyOfPropertyChange(() => Act_autoSpeed12); } }
        public string Act_manauSpeed12 { get { return _act_manauSpeed12; } set { _act_manauSpeed12 = value; NotifyOfPropertyChange(() => Act_manauSpeed12); } }
        public string Act_acc12 { get { return _act_acc12; } set { _act_acc12 = value; NotifyOfPropertyChange(() => Act_acc12); } }
        public string Act_dec12 { get { return _act_dec12; } set { _act_dec12 = value; NotifyOfPropertyChange(() => Act_dec12); } }
        public string Act_pos12 { get { return _act_pos12; } set { _act_pos12 = value; NotifyOfPropertyChange(() => Act_pos12); } }
        public string Act_pos1_12 { get { return _act_pos1_12; } set { _act_pos1_12 = value; NotifyOfPropertyChange(() => Act_pos1_12); } }
        public string Act_pos2_12 { get { return _act_pos2_12; } set { _act_pos2_12 = value; NotifyOfPropertyChange(() => Act_pos2_12); } }

        public String Act_pos12_2 { get { return act_pos12_2; } set { act_pos12_2 = value; NotifyOfPropertyChange(() => Act_pos12_2); } }
        public String Act_pos12_3 { get { return act_pos12_3; } set { act_pos12_3 = value; NotifyOfPropertyChange(() => Act_pos12_3); } }
        public String Act_pos12_4 { get { return act_pos12_4; } set { act_pos12_4 = value; NotifyOfPropertyChange(() => Act_pos12_4); } }
        public String Act_pos12_5 { get { return act_pos12_5; } set { act_pos12_5 = value; NotifyOfPropertyChange(() => Act_pos12_5); } }
        public String Act_pos12_6 { get { return act_pos12_6; } set { act_pos12_6 = value; NotifyOfPropertyChange(() => Act_pos12_6); } }
        public String Act_pos12_7 { get { return act_pos12_7; } set { act_pos12_7 = value; NotifyOfPropertyChange(() => Act_pos12_7); } }
        public String Act_pos12_8 { get { return act_pos12_8; } set { act_pos12_8 = value; NotifyOfPropertyChange(() => Act_pos12_8); } }
        public String Act_pos12_9 { get { return act_pos12_9; } set { act_pos12_9 = value; NotifyOfPropertyChange(() => Act_pos12_9); } }
        public String Act_Speed12_2 { get { return act_Speed12_2; } set { act_Speed12_2 = value; NotifyOfPropertyChange(() => Act_Speed12_2); } }
        public String Act_Speed12_3 { get { return act_Speed12_3; } set { act_Speed12_3 = value; NotifyOfPropertyChange(() => Act_Speed12_3); } }
        public String Act_Speed12_4 { get { return act_Speed12_4; } set { act_Speed12_4 = value; NotifyOfPropertyChange(() => Act_Speed12_4); } }
        public String Act_Speed12_5 { get { return act_Speed12_5; } set { act_Speed12_5 = value; NotifyOfPropertyChange(() => Act_Speed12_5); } }
        public String Act_Speed12_6 { get { return act_Speed12_6; } set { act_Speed12_6 = value; NotifyOfPropertyChange(() => Act_Speed12_6); } }
        public String Act_Speed12_7 { get { return act_Speed12_7; } set { act_Speed12_7 = value; NotifyOfPropertyChange(() => Act_Speed12_7); } }
        public String Act_Speed12_8 { get { return act_Speed12_8; } set { act_Speed12_8 = value; NotifyOfPropertyChange(() => Act_Speed12_8); } }
        public String Act_Speed12_9 { get { return act_Speed12_9; } set { act_Speed12_9 = value; NotifyOfPropertyChange(() => Act_Speed12_9); } }

        #endregion
        #region 13
        public string Error_Code13 { get { return erroor_code13; } set { erroor_code13 = value; NotifyOfPropertyChange(() => Error_Code13); } }
        public string Act_Posion13 { get { return _act_Pos13; } set { _act_Pos13 = value; NotifyOfPropertyChange(() => Act_Posion13); } }
        public string Act_autoSpeed13 { get { return _act_autoSpeed13; } set { _act_autoSpeed13 = value; NotifyOfPropertyChange(() => Act_autoSpeed13); } }
        public string Act_manauSpeed13 { get { return _act_manauSpeed13; } set { _act_manauSpeed13 = value; NotifyOfPropertyChange(() => Act_manauSpeed13); } }
        public string Act_acc13 { get { return _act_acc13; } set { _act_acc13 = value; NotifyOfPropertyChange(() => Act_acc13); } }
        public string Act_dec13 { get { return _act_dec13; } set { _act_dec13 = value; NotifyOfPropertyChange(() => Act_dec13); } }
        public string Act_pos13 { get { return _act_pos13; } set { _act_pos13 = value; NotifyOfPropertyChange(() => Act_pos13); } }
        public string Act_pos1_13 { get { return _act_pos1_13; } set { _act_pos1_13 = value; NotifyOfPropertyChange(() => Act_pos1_13); } }
        public string Act_pos2_13 { get { return _act_pos2_13; } set { _act_pos2_13 = value; NotifyOfPropertyChange(() => Act_pos2_13); } }

        public String Act_pos13_2 { get { return act_pos13_2; } set { act_pos13_2 = value; NotifyOfPropertyChange(() => Act_pos13_2); } }
        public String Act_pos13_3 { get { return act_pos13_3; } set { act_pos13_3 = value; NotifyOfPropertyChange(() => Act_pos13_3); } }
        public String Act_pos13_4 { get { return act_pos13_4; } set { act_pos13_4 = value; NotifyOfPropertyChange(() => Act_pos13_4); } }
        public String Act_pos13_5 { get { return act_pos13_5; } set { act_pos13_5 = value; NotifyOfPropertyChange(() => Act_pos13_5); } }
        public String Act_pos13_6 { get { return act_pos13_6; } set { act_pos13_6 = value; NotifyOfPropertyChange(() => Act_pos13_6); } }
        public String Act_pos13_7 { get { return act_pos13_7; } set { act_pos13_7 = value; NotifyOfPropertyChange(() => Act_pos13_7); } }
        public String Act_pos13_8 { get { return act_pos13_8; } set { act_pos13_8 = value; NotifyOfPropertyChange(() => Act_pos13_8); } }
        public String Act_pos13_9 { get { return act_pos13_9; } set { act_pos13_9 = value; NotifyOfPropertyChange(() => Act_pos13_9); } }
        public String Act_Speed13_2 { get { return act_Speed13_2; } set { act_Speed13_2 = value; NotifyOfPropertyChange(() => Act_Speed13_2); } }
        public String Act_Speed13_3 { get { return act_Speed13_3; } set { act_Speed13_3 = value; NotifyOfPropertyChange(() => Act_Speed13_3); } }
        public String Act_Speed13_4 { get { return act_Speed13_4; } set { act_Speed13_4 = value; NotifyOfPropertyChange(() => Act_Speed13_4); } }
        public String Act_Speed13_5 { get { return act_Speed13_5; } set { act_Speed13_5 = value; NotifyOfPropertyChange(() => Act_Speed13_5); } }
        public String Act_Speed13_6 { get { return act_Speed13_6; } set { act_Speed13_6 = value; NotifyOfPropertyChange(() => Act_Speed13_6); } }
        public String Act_Speed13_7 { get { return act_Speed13_7; } set { act_Speed13_7 = value; NotifyOfPropertyChange(() => Act_Speed13_7); } }
        public String Act_Speed13_8 { get { return act_Speed13_8; } set { act_Speed13_8 = value; NotifyOfPropertyChange(() => Act_Speed13_8); } }
        public String Act_Speed13_9 { get { return act_Speed13_9; } set { act_Speed13_9 = value; NotifyOfPropertyChange(() => Act_Speed13_9); } }

        #endregion
        #region 14
        public string Error_Code14 { get { return erroor_code14; } set { erroor_code14 = value; NotifyOfPropertyChange(() => Error_Code14); } }
        public string Act_Posion14 { get { return _act_Pos14; } set { _act_Pos14 = value; NotifyOfPropertyChange(() => Act_Posion14); } }
        public string Act_autoSpeed14 { get { return _act_autoSpeed14; } set { _act_autoSpeed14 = value; NotifyOfPropertyChange(() => Act_autoSpeed14); } }
        public string Act_manauSpeed14 { get { return _act_manauSpeed14; } set { _act_manauSpeed14 = value; NotifyOfPropertyChange(() => Act_manauSpeed14); } }
        public string Act_acc14 { get { return _act_acc14; } set { _act_acc14 = value; NotifyOfPropertyChange(() => Act_acc14); } }
        public string Act_dec14 { get { return _act_dec14; } set { _act_dec14 = value; NotifyOfPropertyChange(() => Act_dec14); } }
        public string Act_pos14 { get { return _act_pos14; } set { _act_pos14 = value; NotifyOfPropertyChange(() => Act_pos14); } }
        public string Act_pos1_14 { get { return _act_pos1_14; } set { _act_pos1_14 = value; NotifyOfPropertyChange(() => Act_pos1_14); } }
        public string Act_pos2_14 { get { return _act_pos2_14; } set { _act_pos2_14 = value; NotifyOfPropertyChange(() => Act_pos2_14); } }

        public String Act_pos14_2 { get { return act_pos14_2; } set { act_pos14_2 = value; NotifyOfPropertyChange(() => Act_pos14_2); } }
        public String Act_pos14_3 { get { return act_pos14_3; } set { act_pos14_3 = value; NotifyOfPropertyChange(() => Act_pos14_3); } }
        public String Act_pos14_4 { get { return act_pos14_4; } set { act_pos14_4 = value; NotifyOfPropertyChange(() => Act_pos14_4); } }
        public String Act_pos14_5 { get { return act_pos14_5; } set { act_pos14_5 = value; NotifyOfPropertyChange(() => Act_pos14_5); } }
        public String Act_pos14_6 { get { return act_pos14_6; } set { act_pos14_6 = value; NotifyOfPropertyChange(() => Act_pos14_6); } }
        public String Act_pos14_7 { get { return act_pos14_7; } set { act_pos14_7 = value; NotifyOfPropertyChange(() => Act_pos14_7); } }
        public String Act_pos14_8 { get { return act_pos14_8; } set { act_pos14_8 = value; NotifyOfPropertyChange(() => Act_pos14_8); } }
        public String Act_pos14_9 { get { return act_pos14_9; } set { act_pos14_9 = value; NotifyOfPropertyChange(() => Act_pos14_9); } }
        public String Act_Speed14_2 { get { return act_Speed14_2; } set { act_Speed14_2 = value; NotifyOfPropertyChange(() => Act_Speed14_2); } }
        public String Act_Speed14_3 { get { return act_Speed14_3; } set { act_Speed14_3 = value; NotifyOfPropertyChange(() => Act_Speed14_3); } }
        public String Act_Speed14_4 { get { return act_Speed14_4; } set { act_Speed14_4 = value; NotifyOfPropertyChange(() => Act_Speed14_4); } }
        public String Act_Speed14_5 { get { return act_Speed14_5; } set { act_Speed14_5 = value; NotifyOfPropertyChange(() => Act_Speed14_5); } }
        public String Act_Speed14_6 { get { return act_Speed14_6; } set { act_Speed14_6 = value; NotifyOfPropertyChange(() => Act_Speed14_6); } }
        public String Act_Speed14_7 { get { return act_Speed14_7; } set { act_Speed14_7 = value; NotifyOfPropertyChange(() => Act_Speed14_7); } }
        public String Act_Speed14_8 { get { return act_Speed14_8; } set { act_Speed14_8 = value; NotifyOfPropertyChange(() => Act_Speed14_8); } }
        public String Act_Speed14_9 { get { return act_Speed14_9; } set { act_Speed14_9 = value; NotifyOfPropertyChange(() => Act_Speed14_9); } }

        #endregion
        #region 15
        public string Error_Code15 { get { return erroor_code15; } set { erroor_code15 = value; NotifyOfPropertyChange(() => Error_Code15); } }
        public string Act_Posion15 { get { return _act_Pos15; } set { _act_Pos15 = value; NotifyOfPropertyChange(() => Act_Posion15); } }
        public string Act_autoSpeed15 { get { return _act_autoSpeed15; } set { _act_autoSpeed15 = value; NotifyOfPropertyChange(() => Act_autoSpeed15); } }
        public string Act_manauSpeed15 { get { return _act_manauSpeed15; } set { _act_manauSpeed15 = value; NotifyOfPropertyChange(() => Act_manauSpeed15); } }
        public string Act_acc15 { get { return _act_acc15; } set { _act_acc15 = value; NotifyOfPropertyChange(() => Act_acc15); } }
        public string Act_dec15 { get { return _act_dec15; } set { _act_dec15 = value; NotifyOfPropertyChange(() => Act_dec15); } }
        public string Act_pos15 { get { return _act_pos15; } set { _act_pos15 = value; NotifyOfPropertyChange(() => Act_pos15); } }
        public string Act_pos1_15 { get { return _act_pos1_15; } set { _act_pos1_15 = value; NotifyOfPropertyChange(() => Act_pos1_15); } }
        public string Act_pos2_15 { get { return _act_pos2_15; } set { _act_pos2_15 = value; NotifyOfPropertyChange(() => Act_pos2_15); } }

        public String Act_pos15_2 { get { return act_pos15_2; } set { act_pos15_2 = value; NotifyOfPropertyChange(() => Act_pos15_2); } }
        public String Act_pos15_3 { get { return act_pos15_3; } set { act_pos15_3 = value; NotifyOfPropertyChange(() => Act_pos15_3); } }
        public String Act_pos15_4 { get { return act_pos15_4; } set { act_pos15_4 = value; NotifyOfPropertyChange(() => Act_pos15_4); } }
        public String Act_pos15_5 { get { return act_pos15_5; } set { act_pos15_5 = value; NotifyOfPropertyChange(() => Act_pos15_5); } }
        public String Act_pos15_6 { get { return act_pos15_6; } set { act_pos15_6 = value; NotifyOfPropertyChange(() => Act_pos15_6); } }
        public String Act_pos15_7 { get { return act_pos15_7; } set { act_pos15_7 = value; NotifyOfPropertyChange(() => Act_pos15_7); } }
        public String Act_pos15_8 { get { return act_pos15_8; } set { act_pos15_8 = value; NotifyOfPropertyChange(() => Act_pos15_8); } }
        public String Act_pos15_9 { get { return act_pos15_9; } set { act_pos15_9 = value; NotifyOfPropertyChange(() => Act_pos15_9); } }
        public String Act_Speed15_2 { get { return act_Speed15_2; } set { act_Speed15_2 = value; NotifyOfPropertyChange(() => Act_Speed15_2); } }
        public String Act_Speed15_3 { get { return act_Speed15_3; } set { act_Speed15_3 = value; NotifyOfPropertyChange(() => Act_Speed15_3); } }
        public String Act_Speed15_4 { get { return act_Speed15_4; } set { act_Speed15_4 = value; NotifyOfPropertyChange(() => Act_Speed15_4); } }
        public String Act_Speed15_5 { get { return act_Speed15_5; } set { act_Speed15_5 = value; NotifyOfPropertyChange(() => Act_Speed15_5); } }
        public String Act_Speed15_6 { get { return act_Speed15_6; } set { act_Speed15_6 = value; NotifyOfPropertyChange(() => Act_Speed15_6); } }
        public String Act_Speed15_7 { get { return act_Speed15_7; } set { act_Speed15_7 = value; NotifyOfPropertyChange(() => Act_Speed15_7); } }
        public String Act_Speed15_8 { get { return act_Speed15_8; } set { act_Speed15_8 = value; NotifyOfPropertyChange(() => Act_Speed15_8); } }
        public String Act_Speed15_9 { get { return act_Speed15_9; } set { act_Speed15_9 = value; NotifyOfPropertyChange(() => Act_Speed15_9); } }

        #endregion
        #region  16
        public string Error_Code16 { get { return erroor_code16; } set { erroor_code16 = value; NotifyOfPropertyChange(() => Error_Code16); } }
        public string Act_Posion16 { get { return _act_Pos16; } set { _act_Pos16 = value; NotifyOfPropertyChange(() => Act_Posion16); } }
        public string Act_autoSpeed16 { get { return _act_autoSpeed16; } set { _act_autoSpeed16 = value; NotifyOfPropertyChange(() => Act_autoSpeed16); } }
        public string Act_manauSpeed16 { get { return _act_manauSpeed16; } set { _act_manauSpeed16 = value; NotifyOfPropertyChange(() => Act_manauSpeed16); } }
        public string Act_acc16 { get { return _act_acc16; } set { _act_acc16 = value; NotifyOfPropertyChange(() => Act_acc16); } }
        public string Act_dec16 { get { return _act_dec16; } set { _act_dec16 = value; NotifyOfPropertyChange(() => Act_dec16); } }
        public string Act_pos16 { get { return _act_pos16; } set { _act_pos16 = value; NotifyOfPropertyChange(() => Act_pos16); } }
        public string Act_pos1_16 { get { return _act_pos1_16; } set { _act_pos1_16 = value; NotifyOfPropertyChange(() => Act_pos1_16); } }
        public string Act_pos2_16 { get { return _act_pos2_16; } set { _act_pos2_16 = value; NotifyOfPropertyChange(() => Act_pos2_16); } }

        public String Act_pos16_2 { get { return act_pos16_2; } set { act_pos16_2 = value; NotifyOfPropertyChange(() => Act_pos16_2); } }
        public String Act_pos16_3 { get { return act_pos16_3; } set { act_pos16_3 = value; NotifyOfPropertyChange(() => Act_pos16_3); } }
        public String Act_pos16_4 { get { return act_pos16_4; } set { act_pos16_4 = value; NotifyOfPropertyChange(() => Act_pos16_4); } }
        public String Act_pos16_5 { get { return act_pos16_5; } set { act_pos16_5 = value; NotifyOfPropertyChange(() => Act_pos16_5); } }
        public String Act_pos16_6 { get { return act_pos16_6; } set { act_pos16_6 = value; NotifyOfPropertyChange(() => Act_pos16_6); } }
        public String Act_pos16_7 { get { return act_pos16_7; } set { act_pos16_7 = value; NotifyOfPropertyChange(() => Act_pos16_7); } }
        public String Act_pos16_8 { get { return act_pos16_8; } set { act_pos16_8 = value; NotifyOfPropertyChange(() => Act_pos16_8); } }
        public String Act_pos16_9 { get { return act_pos16_9; } set { act_pos16_9 = value; NotifyOfPropertyChange(() => Act_pos16_9); } }
        public String Act_Speed16_2 { get { return act_Speed16_2; } set { act_Speed16_2 = value; NotifyOfPropertyChange(() => Act_Speed16_2); } }
        public String Act_Speed16_3 { get { return act_Speed16_3; } set { act_Speed16_3 = value; NotifyOfPropertyChange(() => Act_Speed16_3); } }
        public String Act_Speed16_4 { get { return act_Speed16_4; } set { act_Speed16_4 = value; NotifyOfPropertyChange(() => Act_Speed16_4); } }
        public String Act_Speed16_5 { get { return act_Speed16_5; } set { act_Speed16_5 = value; NotifyOfPropertyChange(() => Act_Speed16_5); } }
        public String Act_Speed16_6 { get { return act_Speed16_6; } set { act_Speed16_6 = value; NotifyOfPropertyChange(() => Act_Speed16_6); } }
        public String Act_Speed16_7 { get { return act_Speed16_7; } set { act_Speed16_7 = value; NotifyOfPropertyChange(() => Act_Speed16_7); } }
        public String Act_Speed16_8 { get { return act_Speed16_8; } set { act_Speed16_8 = value; NotifyOfPropertyChange(() => Act_Speed16_8); } }
        public String Act_Speed16_9 { get { return act_Speed16_9; } set { act_Speed16_9 = value; NotifyOfPropertyChange(() => Act_Speed16_9); } }

        #endregion


        #endregion
        #region asix_par  private
        #region 0
        private string erroor_code0;
        private string _act_Pos0;
        private string _act_autoSpeed0;
        private string _act_manauSpeed0;
        private string _act_acc0;
        private string _act_dec0;
        private string _act_pos0;
        private string _act_pos1_0;
        private string _act_pos2_0;
        #endregion
        #region 1
        private string erroor_code1;
        private string _act_Pos1;
        private string _act_autoSpeed1;
        private string _act_manauSpeed1;
        private string _act_acc1;
        private string _act_dec1;
        private string _act_pos1;
        private string _act_pos1_1;
        private string _act_pos2_1;
        #endregion
        #region 2
        private string erroor_code2;
        private string _act_Pos2;
        private string _act_autoSpeed2;
        private string _act_manauSpeed2;
        private string _act_acc2;
        private string _act_dec2;
        private string _act_pos2;
        private string _act_pos1_2;
        private string _act_pos2_2;
        #endregion
        #region 3
        private string erroor_code3;
        private string _act_Pos3;
        private string _act_autoSpeed3;
        private string _act_manauSpeed3;
        private string _act_acc3;
        private string _act_dec3;
        private string _act_pos3;
        private string _act_pos1_3;
        private string _act_pos2_3;
        #endregion
        #region 4
        private string erroor_code4;
        private string _act_Pos4;
        private string _act_autoSpeed4;
        private string _act_manauSpeed4;
        private string _act_acc4;
        private string _act_dec4;
        private string _act_pos4;
        private string _act_pos1_4;
        private string _act_pos2_4;
        #endregion
        #region 5
        private string erroor_code5;
        private string _act_Pos5;
        private string _act_autoSpeed5;
        private string _act_manauSpeed5;
        private string _act_acc5;
        private string _act_dec5;
        private string _act_pos5;
        private string _act_pos1_5;
        private string _act_pos2_5;
        #endregion
        #region 6
        private string erroor_code6;
        private string _act_Pos6;
        private string _act_autoSpeed6;
        private string _act_manauSpeed6;
        private string _act_acc6;
        private string _act_dec6;
        private string _act_pos6;
        private string _act_pos1_6;
        private string _act_pos2_6;
        #endregion
        #region 7
        private string erroor_code7;
        private string _act_Pos7;
        private string _act_autoSpeed7;
        private string _act_manauSpeed7;
        private string _act_acc7;
        private string _act_dec7;
        private string _act_pos7;
        private string _act_pos1_7;
        private string _act_pos2_7;
        #endregion
        #region 8
        private string erroor_code8;
        private string _act_Pos8;
        private string _act_autoSpeed8;
        private string _act_manauSpeed8;
        private string _act_acc8;
        private string _act_dec8;
        private string _act_pos8;
        private string _act_pos1_8;
        private string _act_pos2_8;
        #endregion
        #region 9
        private string erroor_code9;
        private string _act_Pos9;
        private string _act_autoSpeed9;
        private string _act_manauSpeed9;
        private string _act_acc9;
        private string _act_dec9;
        private string _act_pos9;
        private string _act_pos1_9;
        private string _act_pos2_9;
        #endregion
        #region 10
        private string erroor_code10;
        private string _act_Pos10;
        private string _act_autoSpeed10;
        private string _act_manauSpeed10;
        private string _act_acc10;
        private string _act_dec10;
        private string _act_pos10;
        private string _act_pos1_10;
        private string _act_pos2_10;
        #endregion
        #region 11
        private string erroor_code11;
        private string _act_Pos11;
        private string _act_autoSpeed11;
        private string _act_manauSpeed11;
        private string _act_acc11;
        private string _act_dec11;
        private string _act_pos11;
        private string _act_pos1_11;
        private string _act_pos2_11;
        #endregion
        #region 12
        private string erroor_code12;
        private string _act_Pos12;
        private string _act_autoSpeed12;
        private string _act_manauSpeed12;
        private string _act_acc12;
        private string _act_dec12;
        private string _act_pos12;
        private string _act_pos1_12;
        private string _act_pos2_12;
        #endregion
        #region 13
        private string erroor_code13;
        private string _act_Pos13;
        private string _act_autoSpeed13;
        private string _act_manauSpeed13;
        private string _act_acc13;
        private string _act_dec13;
        private string _act_pos13;
        private string _act_pos1_13;
        private string _act_pos2_13;
        #endregion
        #region 14
        private string erroor_code14;
        private string _act_Pos14;
        private string _act_autoSpeed14;
        private string _act_manauSpeed14;
        private string _act_acc14;
        private string _act_dec14;
        private string _act_pos14;
        private string _act_pos1_14;
        private string _act_pos2_14;
        #endregion
        #region 15
        private string erroor_code15;
        private string _act_Pos15;
        private string _act_autoSpeed15;
        private string _act_manauSpeed15;
        private string _act_acc15;
        private string _act_dec15;
        private string _act_pos15;
        private string _act_pos1_15;
        private string _act_pos2_15;
        #endregion
        #region  16
        private string erroor_code16;
        private string _act_Pos16;
        private string _act_autoSpeed16;
        private string _act_manauSpeed16;
        private string _act_acc16;
        private string _act_dec16;
        private string _act_pos16;
        private string _act_pos1_16;
        private string _act_pos2_16;
        #endregion
        #endregion
        private String act_pos00_2;
        private String act_pos00_3;
        private String act_pos00_4;
        private String act_pos00_5;
        private String act_pos00_6;
        private String act_pos00_7;
        private String act_pos00_8;
        private String act_pos00_9;
        private String act_Speed00_2;
        private String act_Speed00_3;
        private String act_Speed00_4;
        private String act_Speed00_5;
        private String act_Speed00_6;
        private String act_Speed00_7;
        private String act_Speed00_8;
        private String act_Speed00_9;
        private String act_pos01_2;
        private String act_pos01_3;
        private String act_pos01_4;
        private String act_pos01_5;
        private String act_pos01_6;
        private String act_pos01_7;
        private String act_pos01_8;
        private String act_pos01_9;
        private String act_Speed01_2;
        private String act_Speed01_3;
        private String act_Speed01_4;
        private String act_Speed01_5;
        private String act_Speed01_6;
        private String act_Speed01_7;
        private String act_Speed01_8;
        private String act_Speed01_9;
        private String act_pos02_2;
        private String act_pos02_3;
        private String act_pos02_4;
        private String act_pos02_5;
        private String act_pos02_6;
        private String act_pos02_7;
        private String act_pos02_8;
        private String act_pos02_9;
        private String act_Speed02_2;
        private String act_Speed02_3;
        private String act_Speed02_4;
        private String act_Speed02_5;
        private String act_Speed02_6;
        private String act_Speed02_7;
        private String act_Speed02_8;
        private String act_Speed02_9;
        private String act_pos03_2;
        private String act_pos03_3;
        private String act_pos03_4;
        private String act_pos03_5;
        private String act_pos03_6;
        private String act_pos03_7;
        private String act_pos03_8;
        private String act_pos03_9;
        private String act_Speed03_2;
        private String act_Speed03_3;
        private String act_Speed03_4;
        private String act_Speed03_5;
        private String act_Speed03_6;
        private String act_Speed03_7;
        private String act_Speed03_8;
        private String act_Speed03_9;
        private String act_pos04_2;
        private String act_pos04_3;
        private String act_pos04_4;
        private String act_pos04_5;
        private String act_pos04_6;
        private String act_pos04_7;
        private String act_pos04_8;
        private String act_pos04_9;
        private String act_Speed04_2;
        private String act_Speed04_3;
        private String act_Speed04_4;
        private String act_Speed04_5;
        private String act_Speed04_6;
        private String act_Speed04_7;
        private String act_Speed04_8;
        private String act_Speed04_9;
        private String act_pos05_2;
        private String act_pos05_3;
        private String act_pos05_4;
        private String act_pos05_5;
        private String act_pos05_6;
        private String act_pos05_7;
        private String act_pos05_8;
        private String act_pos05_9;
        private String act_Speed05_2;
        private String act_Speed05_3;
        private String act_Speed05_4;
        private String act_Speed05_5;
        private String act_Speed05_6;
        private String act_Speed05_7;
        private String act_Speed05_8;
        private String act_Speed05_9;
        private String act_pos06_2;
        private String act_pos06_3;
        private String act_pos06_4;
        private String act_pos06_5;
        private String act_pos06_6;
        private String act_pos06_7;
        private String act_pos06_8;
        private String act_pos06_9;
        private String act_Speed06_2;
        private String act_Speed06_3;
        private String act_Speed06_4;
        private String act_Speed06_5;
        private String act_Speed06_6;
        private String act_Speed06_7;
        private String act_Speed06_8;
        private String act_Speed06_9;
        private String act_pos07_2;
        private String act_pos07_3;
        private String act_pos07_4;
        private String act_pos07_5;
        private String act_pos07_6;
        private String act_pos07_7;
        private String act_pos07_8;
        private String act_pos07_9;
        private String act_Speed07_2;
        private String act_Speed07_3;
        private String act_Speed07_4;
        private String act_Speed07_5;
        private String act_Speed07_6;
        private String act_Speed07_7;
        private String act_Speed07_8;
        private String act_Speed07_9;
        private String act_pos08_2;
        private String act_pos08_3;
        private String act_pos08_4;
        private String act_pos08_5;
        private String act_pos08_6;
        private String act_pos08_7;
        private String act_pos08_8;
        private String act_pos08_9;
        private String act_Speed08_2;
        private String act_Speed08_3;
        private String act_Speed08_4;
        private String act_Speed08_5;
        private String act_Speed08_6;
        private String act_Speed08_7;
        private String act_Speed08_8;
        private String act_Speed08_9;
        private String act_pos09_2;
        private String act_pos09_3;
        private String act_pos09_4;
        private String act_pos09_5;
        private String act_pos09_6;
        private String act_pos09_7;
        private String act_pos09_8;
        private String act_pos09_9;
        private String act_Speed09_2;
        private String act_Speed09_3;
        private String act_Speed09_4;
        private String act_Speed09_5;
        private String act_Speed09_6;
        private String act_Speed09_7;
        private String act_Speed09_8;
        private String act_Speed09_9;
        private String act_pos10_2;
        private String act_pos10_3;
        private String act_pos10_4;
        private String act_pos10_5;
        private String act_pos10_6;
        private String act_pos10_7;
        private String act_pos10_8;
        private String act_pos10_9;
        private String act_Speed10_2;
        private String act_Speed10_3;
        private String act_Speed10_4;
        private String act_Speed10_5;
        private String act_Speed10_6;
        private String act_Speed10_7;
        private String act_Speed10_8;
        private String act_Speed10_9;
        private String act_pos11_2;
        private String act_pos11_3;
        private String act_pos11_4;
        private String act_pos11_5;
        private String act_pos11_6;
        private String act_pos11_7;
        private String act_pos11_8;
        private String act_pos11_9;
        private String act_Speed11_2;
        private String act_Speed11_3;
        private String act_Speed11_4;
        private String act_Speed11_5;
        private String act_Speed11_6;
        private String act_Speed11_7;
        private String act_Speed11_8;
        private String act_Speed11_9;
        private String act_pos12_2;
        private String act_pos12_3;
        private String act_pos12_4;
        private String act_pos12_5;
        private String act_pos12_6;
        private String act_pos12_7;
        private String act_pos12_8;
        private String act_pos12_9;
        private String act_Speed12_2;
        private String act_Speed12_3;
        private String act_Speed12_4;
        private String act_Speed12_5;
        private String act_Speed12_6;
        private String act_Speed12_7;
        private String act_Speed12_8;
        private String act_Speed12_9;
        private String act_pos13_2;
        private String act_pos13_3;
        private String act_pos13_4;
        private String act_pos13_5;
        private String act_pos13_6;
        private String act_pos13_7;
        private String act_pos13_8;
        private String act_pos13_9;
        private String act_Speed13_2;
        private String act_Speed13_3;
        private String act_Speed13_4;
        private String act_Speed13_5;
        private String act_Speed13_6;
        private String act_Speed13_7;
        private String act_Speed13_8;
        private String act_Speed13_9;
        private String act_pos14_2;
        private String act_pos14_3;
        private String act_pos14_4;
        private String act_pos14_5;
        private String act_pos14_6;
        private String act_pos14_7;
        private String act_pos14_8;
        private String act_pos14_9;
        private String act_Speed14_2;
        private String act_Speed14_3;
        private String act_Speed14_4;
        private String act_Speed14_5;
        private String act_Speed14_6;
        private String act_Speed14_7;
        private String act_Speed14_8;
        private String act_Speed14_9;
        private String act_pos15_2;
        private String act_pos15_3;
        private String act_pos15_4;
        private String act_pos15_5;
        private String act_pos15_6;
        private String act_pos15_7;
        private String act_pos15_8;
        private String act_pos15_9;
        private String act_Speed15_2;
        private String act_Speed15_3;
        private String act_Speed15_4;
        private String act_Speed15_5;
        private String act_Speed15_6;
        private String act_Speed15_7;
        private String act_Speed15_8;
        private String act_Speed15_9;
        private String act_pos16_2;
        private String act_pos16_3;
        private String act_pos16_4;
        private String act_pos16_5;
        private String act_pos16_6;
        private String act_pos16_7;
        private String act_pos16_8;
        private String act_pos16_9;
        private String act_Speed16_2;
        private String act_Speed16_3;
        private String act_Speed16_4;
        private String act_Speed16_5;
        private String act_Speed16_6;
        private String act_Speed16_7;
        private String act_Speed16_8;
        private String act_Speed16_9;
        #endregion
        #region readitems
        private void readitems()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    #region
                    //#region 0
                    //Error_Code0 = Lib.ConnectPlc1.plcitems.Erroor_Code0.ToString("f3");
                    //Act_Pos0 = Lib.Connect_Plc.plcitems.Act_Pos0.ToString("f3");
                    //Act_acc0 = Lib.Connect_Plc.plcitems.Act_acc0.ToString("f3");
                    //Act_dec0 = Lib.Connect_Plc.plcitems.Act_dec0.ToString("f3");
                    //Act_autoSpeed0 = Lib.Connect_Plc.plcitems.Act_autoSpeed0.ToString("f3");
                    //Act_manauSpeed0= Lib.Connect_Plc.plcitems.Act_manauSpeed0.ToString("f3");
                    //Act_pos0 = Lib.Connect_Plc.plcitems.Act_pos0.ToString("f3");
                    //Act_pos1 = Lib.Connect_Plc.plcitems.Act_pos1_0.ToString("f3");
                    //Act_pos2 = Lib.Connect_Plc.plcitems.Act_pos2_0.ToString("f3");
                    //#endregion
                    //#region 1
                    //Error_Code1 = Lib.Connect_Plc.plcitems.Erroor_Code0.ToString("f3");
                    //Act_Pos1 = Lib.Connect_Plc.plcitems.Act_Pos1.ToString("f3");
                    //Act_acc1 = Lib.Connect_Plc.plcitems.Act_acc1.ToString("f3");
                    //Act_dec1 = Lib.Connect_Plc.plcitems.Act_dec1.ToString("f3");
                    //Act_autoSpeed1 = Lib.Connect_Plc.plcitems.Act_autoSpeed1.ToString("f3");
                    //Act_manauSpeed1 = Lib.Connect_Plc.plcitems.Act_manauSpeed1.ToString("f3");
                    //Act_pos1 = Lib.Connect_Plc.plcitems.Act_pos1.ToString("f3");
                    //Act_pos1_1 = Lib.Connect_Plc.plcitems.Act_pos1_1.ToString("f3");
                    //Act_pos2_1 = Lib.Connect_Plc.plcitems.Act_pos2_1.ToString("f3");
                    //#endregion
                    //#region 2
                    //Error_Code2 = Lib.Connect_Plc.plcitems.Erroor_Code2.ToString("f3");
                    //Act_Pos2 = Lib.Connect_Plc.plcitems.Act_Pos2.ToString("f3");
                    //Act_acc2 = Lib.Connect_Plc.plcitems.Act_acc2.ToString("f3");
                    //Act_dec2 = Lib.Connect_Plc.plcitems.Act_dec2.ToString("f3");
                    //Act_autoSpeed2 = Lib.Connect_Plc.plcitems.Act_autoSpeed2.ToString("f3");
                    //Act_manauSpeed2 = Lib.Connect_Plc.plcitems.Act_manauSpeed2.ToString("f3");
                    //Act_pos2 = Lib.Connect_Plc.plcitems.Act_pos2.ToString("f3");
                    //Act_pos1_2 = Lib.Connect_Plc.plcitems.Act_pos1_2.ToString("f3");
                    //Act_pos2_2 = Lib.Connect_Plc.plcitems.Act_pos2_2.ToString("f3");
                    //#endregion
                    //#region 3
                    //Error_Code3 = Lib.Connect_Plc.plcitems.Erroor_Code3.ToString("f3");
                    //Act_Pos3 = Lib.Connect_Plc.plcitems.Act_Pos3.ToString("f3");
                    //Act_acc3 = Lib.Connect_Plc.plcitems.Act_acc3.ToString("f3");
                    //Act_dec3 = Lib.Connect_Plc.plcitems.Act_dec3.ToString("f3");
                    //Act_autoSpeed3 = Lib.Connect_Plc.plcitems.Act_autoSpeed3.ToString("f3");
                    //Act_manauSpeed3 = Lib.Connect_Plc.plcitems.Act_manauSpeed3.ToString("f3");
                    //Act_pos3 = Lib.Connect_Plc.plcitems.Act_pos3.ToString("f3");
                    //Act_pos1_3 = Lib.Connect_Plc.plcitems.Act_pos1_3.ToString("f3");
                    //Act_pos2_3 = Lib.Connect_Plc.plcitems.Act_pos2_3.ToString("f3");
                    //#endregion
                    //#region 4
                    //Error_Code4 = Lib.Connect_Plc.plcitems.Erroor_Code4.ToString("f3");
                    //Act_Pos4 = Lib.Connect_Plc.plcitems.Act_Pos4.ToString("f3");
                    //Act_acc4 = Lib.Connect_Plc.plcitems.Act_acc4.ToString("f3");
                    //Act_dec4 = Lib.Connect_Plc.plcitems.Act_dec4.ToString("f3");
                    //Act_autoSpeed4 = Lib.Connect_Plc.plcitems.Act_autoSpeed4.ToString("f3");
                    //Act_manauSpeed4 = Lib.Connect_Plc.plcitems.Act_manauSpeed4.ToString("f3");
                    //Act_pos4 = Lib.Connect_Plc.plcitems.Act_pos4.ToString("f3");
                    //Act_pos1_4 = Lib.Connect_Plc.plcitems.Act_pos1_4.ToString("f3");
                    //Act_pos2_4 = Lib.Connect_Plc.plcitems.Act_pos2_4.ToString("f3");
                    //#endregion
                    //#region 5
                    //Error_Code5 = Lib.Connect_Plc.plcitems.Erroor_Code5.ToString("f3");
                    //Act_Pos5 = Lib.Connect_Plc.plcitems.Act_Pos5.ToString("f3");
                    //Act_acc5 = Lib.Connect_Plc.plcitems.Act_acc5.ToString("f3");
                    //Act_dec5 = Lib.Connect_Plc.plcitems.Act_dec5.ToString("f3");
                    //Act_autoSpeed5 = Lib.Connect_Plc.plcitems.Act_autoSpeed5.ToString("f3");
                    //Act_manauSpeed5 = Lib.Connect_Plc.plcitems.Act_manauSpeed5.ToString("f3");
                    //Act_pos5 = Lib.Connect_Plc.plcitems.Act_pos5.ToString("f3");
                    //Act_pos1_5 = Lib.Connect_Plc.plcitems.Act_pos1_5.ToString("f3");
                    //Act_pos2_5 = Lib.Connect_Plc.plcitems.Act_pos2_5.ToString("f3");
                    //#endregion
                    //#region 6
                    //Error_Code6 = Lib.Connect_Plc.plcitems.Erroor_Code6.ToString("f3");
                    //Act_Pos6 = Lib.Connect_Plc.plcitems.Act_Pos6.ToString("f3");
                    //Act_acc6 = Lib.Connect_Plc.plcitems.Act_acc6.ToString("f3");
                    //Act_dec6 = Lib.Connect_Plc.plcitems.Act_dec6.ToString("f3");
                    //Act_autoSpeed6 = Lib.Connect_Plc.plcitems.Act_autoSpeed6.ToString("f3");
                    //Act_manauSpeed6 = Lib.Connect_Plc.plcitems.Act_manauSpeed6.ToString("f3");
                    //Act_pos6 = Lib.Connect_Plc.plcitems.Act_pos6.ToString("f3");
                    //Act_pos1_6 = Lib.Connect_Plc.plcitems.Act_pos1_6.ToString("f3");
                    //Act_pos2_6 = Lib.Connect_Plc.plcitems.Act_pos2_6.ToString("f3");
                    //#endregion
                    //#region 7
                    //Error_Code7 = Lib.Connect_Plc.plcitems.Erroor_Code7.ToString("f3");
                    //Act_Pos7 = Lib.Connect_Plc.plcitems.Act_Pos7.ToString("f3");
                    //Act_acc7 = Lib.Connect_Plc.plcitems.Act_acc7.ToString("f3");
                    //Act_dec7 = Lib.Connect_Plc.plcitems.Act_dec7.ToString("f3");
                    //Act_autoSpeed7 = Lib.Connect_Plc.plcitems.Act_autoSpeed7.ToString("f3");
                    //Act_manauSpeed7 = Lib.Connect_Plc.plcitems.Act_manauSpeed7.ToString("f3");
                    //Act_pos7 = Lib.Connect_Plc.plcitems.Act_pos7.ToString("f3");
                    //Act_pos1_7 = Lib.Connect_Plc.plcitems.Act_pos1_7.ToString("f3");
                    //Act_pos2_7 = Lib.Connect_Plc.plcitems.Act_pos2_7.ToString("f3");
                    //#endregion
                    //#region 8
                    //Error_Code8 = Lib.Connect_Plc.plcitems.Erroor_Code8.ToString("f3");
                    //Act_Pos8 = Lib.Connect_Plc.plcitems.Act_Pos8.ToString("f3");
                    //Act_acc8 = Lib.Connect_Plc.plcitems.Act_acc8.ToString("f3");
                    //Act_dec8 = Lib.Connect_Plc.plcitems.Act_dec8.ToString("f3");
                    //Act_autoSpeed8 = Lib.Connect_Plc.plcitems.Act_autoSpeed8.ToString("f3");
                    //Act_manauSpeed8 = Lib.Connect_Plc.plcitems.Act_manauSpeed8.ToString("f3");
                    //Act_pos8 = Lib.Connect_Plc.plcitems.Act_pos8.ToString("f3");
                    //Act_pos1_8 = Lib.Connect_Plc.plcitems.Act_pos1_8.ToString("f3");
                    //Act_pos2_8 = Lib.Connect_Plc.plcitems.Act_pos2_8.ToString("f3");
                    //#endregion
                    //#region 9
                    //Error_Code9 = Lib.Connect_Plc.plcitems.Erroor_Code9.ToString("f3");
                    //Act_Pos9 = Lib.Connect_Plc.plcitems.Act_Pos9.ToString("f3");
                    //Act_acc9 = Lib.Connect_Plc.plcitems.Act_acc9.ToString("f3");
                    //Act_dec9 = Lib.Connect_Plc.plcitems.Act_dec9.ToString("f3");
                    //Act_autoSpeed9 = Lib.Connect_Plc.plcitems.Act_autoSpeed9.ToString("f3");
                    //Act_manauSpeed9 = Lib.Connect_Plc.plcitems.Act_manauSpeed9.ToString("f3");
                    //Act_pos9 = Lib.Connect_Plc.plcitems.Act_pos9.ToString("f3");
                    //Act_pos1_9 = Lib.Connect_Plc.plcitems.Act_pos1_9.ToString("f3");
                    //Act_pos2_9 = Lib.Connect_Plc.plcitems.Act_pos2_9.ToString("f3");
                    //#endregion
                    //#region 10
                    //Error_Code10 = Lib.Connect_Plc.plcitems.Erroor_Code10.ToString("f3");
                    //Act_Pos10 = Lib.Connect_Plc.plcitems.Act_Pos10.ToString("f3");
                    //Act_acc10 = Lib.Connect_Plc.plcitems.Act_acc10.ToString("f3");
                    //Act_dec10 = Lib.Connect_Plc.plcitems.Act_dec10.ToString("f3");
                    //Act_autoSpeed10 = Lib.Connect_Plc.plcitems.Act_autoSpeed10.ToString("f3");
                    //Act_manauSpeed10 = Lib.Connect_Plc.plcitems.Act_manauSpeed10.ToString("f3");
                    //Act_pos10 = Lib.Connect_Plc.plcitems.Act_pos10.ToString("f3");
                    //Act_pos1_10 = Lib.Connect_Plc.plcitems.Act_pos1_10.ToString("f3");
                    //Act_pos2_10 = Lib.Connect_Plc.plcitems.Act_pos2_10.ToString("f3");
                    //#endregion
                    //#region 11
                    //Error_Code11 = Lib.Connect_Plc.plcitems.Erroor_Code11.ToString("f3");
                    //Act_Pos11 = Lib.Connect_Plc.plcitems.Act_Pos11.ToString("f3");
                    //Act_acc11 = Lib.Connect_Plc.plcitems.Act_acc11.ToString("f3");
                    //Act_dec11 = Lib.Connect_Plc.plcitems.Act_dec11.ToString("f3");
                    //Act_autoSpeed11 = Lib.Connect_Plc.plcitems.Act_autoSpeed11.ToString("f3");
                    //Act_manauSpeed11 = Lib.Connect_Plc.plcitems.Act_manauSpeed11.ToString("f3");
                    //Act_pos11 = Lib.Connect_Plc.plcitems.Act_pos11.ToString("f3");
                    //Act_pos1_11 = Lib.Connect_Plc.plcitems.Act_pos1_11.ToString("f3");
                    //Act_pos2_11 = Lib.Connect_Plc.plcitems.Act_pos2_11.ToString("f3");
                    //#endregion
                    //#region 12
                    //Error_Code12 = Lib.Connect_Plc.plcitems.Erroor_Code12.ToString("f3");
                    //Act_Pos12 = Lib.Connect_Plc.plcitems.Act_Pos12.ToString("f3");
                    //Act_acc12 = Lib.Connect_Plc.plcitems.Act_acc12.ToString("f3");
                    //Act_dec12 = Lib.Connect_Plc.plcitems.Act_dec12.ToString("f3");
                    //Act_autoSpeed12 = Lib.Connect_Plc.plcitems.Act_autoSpeed12.ToString("f3");
                    //Act_manauSpeed12 = Lib.Connect_Plc.plcitems.Act_manauSpeed12.ToString("f3");
                    //Act_pos12 = Lib.Connect_Plc.plcitems.Act_pos12.ToString("f3");
                    //Act_pos1_12 = Lib.Connect_Plc.plcitems.Act_pos1_12.ToString("f3");
                    //Act_pos2_12 = Lib.Connect_Plc.plcitems.Act_pos2_12.ToString("f3");
                    //#endregion
                    //#region 13
                    //Error_Code13 = Lib.Connect_Plc.plcitems.Erroor_Code13.ToString("f3");
                    //Act_Pos13 = Lib.Connect_Plc.plcitems.Act_Pos13.ToString("f3");
                    //Act_acc13 = Lib.Connect_Plc.plcitems.Act_acc13.ToString("f3");
                    //Act_dec13 = Lib.Connect_Plc.plcitems.Act_dec13.ToString("f3");
                    //Act_autoSpeed13 = Lib.Connect_Plc.plcitems.Act_autoSpeed13.ToString("f3");
                    //Act_manauSpeed13 = Lib.Connect_Plc.plcitems.Act_manauSpeed13.ToString("f3");
                    //Act_pos13 = Lib.Connect_Plc.plcitems.Act_pos13.ToString("f3");
                    //Act_pos1_13 = Lib.Connect_Plc.plcitems.Act_pos1_13.ToString("f3");
                    //Act_pos2_13 = Lib.Connect_Plc.plcitems.Act_pos2_13.ToString("f3");
                    //#endregion
                    //#region 14
                    //Error_Code14 = Lib.Connect_Plc.plcitems.Erroor_Code14.ToString("f3");
                    //Act_Pos14 = Lib.Connect_Plc.plcitems.Act_Pos14.ToString("f3");
                    //Act_acc14 = Lib.Connect_Plc.plcitems.Act_acc14.ToString("f3");
                    //Act_dec14 = Lib.Connect_Plc.plcitems.Act_dec14.ToString("f3");
                    //Act_autoSpeed14 = Lib.Connect_Plc.plcitems.Act_autoSpeed14.ToString("f3");
                    //Act_manauSpeed14 = Lib.Connect_Plc.plcitems.Act_manauSpeed14.ToString("f3");
                    //Act_pos14 = Lib.Connect_Plc.plcitems.Act_pos14.ToString("f3");
                    //Act_pos1_14 = Lib.Connect_Plc.plcitems.Act_pos1_14.ToString("f3");
                    //Act_pos2_14 = Lib.Connect_Plc.plcitems.Act_pos2_14.ToString("f3");
                    //#endregion
                    //#region 15
                    //Error_Code15 = Lib.Connect_Plc.plcitems.Erroor_Code15.ToString("f3");
                    //Act_Pos15 = Lib.Connect_Plc.plcitems.Act_Pos15.ToString("f3");
                    //Act_acc15 = Lib.Connect_Plc.plcitems.Act_acc15.ToString("f3");
                    //Act_dec15 = Lib.Connect_Plc.plcitems.Act_dec15.ToString("f3");
                    //Act_autoSpeed15 = Lib.Connect_Plc.plcitems.Act_autoSpeed15.ToString("f3");
                    //Act_manauSpeed15 = Lib.Connect_Plc.plcitems.Act_manauSpeed15.ToString("f3");
                    //Act_pos15 = Lib.Connect_Plc.plcitems.Act_pos15.ToString("f3");
                    //Act_pos1_15 = Lib.Connect_Plc.plcitems.Act_pos1_15.ToString("f3");
                    //Act_pos2_15 = Lib.Connect_Plc.plcitems.Act_pos2_15.ToString("f3");
                    //#endregion
                    //#region 16
                    //Error_Code16 = Lib.Connect_Plc.plcitems.Erroor_Code16.ToString("f3");
                    //Act_Pos16 = Lib.Connect_Plc.plcitems.Act_Pos16.ToString("f3");
                    //Act_acc16 = Lib.Connect_Plc.plcitems.Act_acc16.ToString("f3");
                    //Act_dec16 = Lib.Connect_Plc.plcitems.Act_dec16.ToString("f3");
                    //Act_autoSpeed16 = Lib.Connect_Plc.plcitems.Act_autoSpeed16.ToString("f3");
                    //Act_manauSpeed16 = Lib.Connect_Plc.plcitems.Act_manauSpeed16.ToString("f3");
                    //Act_pos16 = Lib.Connect_Plc.plcitems.Act_pos16.ToString("f3");
                    //Act_pos1_16 = Lib.Connect_Plc.plcitems.Act_pos1_16.ToString("f3");
                    //Act_pos2_16 = Lib.Connect_Plc.plcitems.Act_pos2_16.ToString("f3");
                    //#endregion
                    #endregion
                    #region 0
                    Error_Code0 = Lib.ConnectPlc1.plcitems.Erroor_Code0.ToString("f3");
                    Act_Posion0 = Lib.ConnectPlc1.plcitems.Act_Pos0.ToString("f3");
                    //Act_acc0 = Lib.ConnectPlc1.plcitems.Act_acc0.ToString("f3");
                    //Act_dec0 = Lib.ConnectPlc1.plcitems.Act_dec0.ToString("f3");

                    #endregion
                    #region 1
                    Error_Code1 = Lib.ConnectPlc1.plcitems.Erroor_Code0.ToString("f3");
                    Act_Posion1 = Lib.ConnectPlc1.plcitems.Act_Pos1.ToString("f3");
                    //Act_acc1 = Lib.ConnectPlc1.plcitems.Act_acc1.ToString("f3");
                    //Act_dec1 = Lib.ConnectPlc1.plcitems.Act_dec1.ToString("f3");

                    #endregion
                    #region 2
                    Error_Code2 = Lib.ConnectPlc1.plcitems.Erroor_Code2.ToString("f3");
                    Act_Posion2 = Lib.ConnectPlc1.plcitems.Act_Pos2.ToString("f3");
                    //Act_acc2 = Lib.ConnectPlc1.plcitems.Act_acc2.ToString("f3");
                    //Act_dec2 = Lib.ConnectPlc1.plcitems.Act_dec2.ToString("f3");

                    #endregion
                    #region 3
                    Error_Code3 = Lib.ConnectPlc1.plcitems.Erroor_Code3.ToString("f3");
                    Act_Posion3 = Lib.ConnectPlc1.plcitems.Act_Pos3.ToString("f3");
                    //Act_acc3 = Lib.ConnectPlc1.plcitems.Act_acc3.ToString("f3");
                    //Act_dec3 = Lib.ConnectPlc1.plcitems.Act_dec3.ToString("f3");

                    #endregion
                    #region 4
                    Error_Code4 = Lib.ConnectPlc1.plcitems.Erroor_Code4.ToString("f3");
                    Act_Posion4 = Lib.ConnectPlc1.plcitems.Act_Pos4.ToString("f3");
                    //Act_acc4 = Lib.ConnectPlc1.plcitems.Act_acc4.ToString("f3");
                    //Act_dec4 = Lib.ConnectPlc1.plcitems.Act_dec4.ToString("f3");

                    #endregion
                    #region 5
                    Error_Code5 = Lib.ConnectPlc1.plcitems.Erroor_Code5.ToString("f3");
                    Act_Posion5 = Lib.ConnectPlc1.plcitems.Act_Pos5.ToString("f3");
                    //Act_acc5 = Lib.ConnectPlc1.plcitems.Act_acc5.ToString("f3");
                    //Act_dec5 = Lib.ConnectPlc1.plcitems.Act_dec5.ToString("f3");

                    #endregion
                    #region 6
                    Error_Code6 = Lib.ConnectPlc1.plcitems.Erroor_Code6.ToString("f3");
                    Act_Posion6 = Lib.ConnectPlc1.plcitems.Act_Pos6.ToString("f3");
                    //Act_acc6 = Lib.ConnectPlc1.plcitems.Act_acc6.ToString("f3");
                    //Act_dec6 = Lib.ConnectPlc1.plcitems.Act_dec6.ToString("f3");

                    #endregion
                    #region 7
                    Error_Code7 = Lib.ConnectPlc1.plcitems.Erroor_Code7.ToString("f3");
                    Act_Posion7 = Lib.ConnectPlc1.plcitems.Act_Pos7.ToString("f3");
                    //Act_acc7 = Lib.ConnectPlc1.plcitems.Act_acc7.ToString("f3");
                    //Act_dec7 = Lib.ConnectPlc1.plcitems.Act_dec7.ToString("f3");

                    #endregion
                    #region 8
                    Error_Code8 = Lib.ConnectPlc1.plcitems.Erroor_Code8.ToString("f3");
                    Act_Posion8 = Lib.ConnectPlc1.plcitems.Act_Pos8.ToString("f3");
                    //Act_acc8 = Lib.ConnectPlc1.plcitems.Act_acc8.ToString("f3");
                    //Act_dec8 = Lib.ConnectPlc1.plcitems.Act_dec8.ToString("f3");

                    #endregion
                    #region 9
                    Error_Code9 = Lib.ConnectPlc1.plcitems.Erroor_Code9.ToString("f3");
                    Act_Posion9 = Lib.ConnectPlc1.plcitems.Act_Pos9.ToString("f3");
                    //Act_acc9 = Lib.ConnectPlc1.plcitems.Act_acc9.ToString("f3");
                    //Act_dec9 = Lib.ConnectPlc1.plcitems.Act_dec9.ToString("f3");

                    #endregion
                    #region 10
                    Error_Code10 = Lib.ConnectPlc1.plcitems.Erroor_Code10.ToString("f3");
                    Act_Posion10 = Lib.ConnectPlc1.plcitems.Act_Pos10.ToString("f3");
                    //Act_acc10 = Lib.ConnectPlc1.plcitems.Act_acc10.ToString("f3");
                    //Act_dec10 = Lib.ConnectPlc1.plcitems.Act_dec10.ToString("f3");

                    #endregion
                    #region 11
                    Error_Code11 = Lib.ConnectPlc1.plcitems.Erroor_Code11.ToString("f3");
                    Act_Posion11 = Lib.ConnectPlc1.plcitems.Act_Pos11.ToString("f3");
                    //Act_acc11 = Lib.ConnectPlc1.plcitems.Act_acc11.ToString("f3");
                    //Act_dec11 = Lib.ConnectPlc1.plcitems.Act_dec11.ToString("f3");

                    #endregion
                    #region 12
                    Error_Code12 = Lib.ConnectPlc1.plcitems.Erroor_Code12.ToString("f3");
                    Act_Posion12 = Lib.ConnectPlc1.plcitems.Act_Pos12.ToString("f3");
                    //Act_acc12 = Lib.ConnectPlc1.plcitems.Act_acc12.ToString("f3");
                    //Act_dec12 = Lib.ConnectPlc1.plcitems.Act_dec12.ToString("f3");

                    #endregion
                    #region 13
                    Error_Code13 = Lib.ConnectPlc1.plcitems.Erroor_Code13.ToString("f3");
                    Act_Posion13 = Lib.ConnectPlc1.plcitems.Act_Pos13.ToString("f3");
                    //Act_acc13 = Lib.ConnectPlc1.plcitems.Act_acc13.ToString("f3");
                    //Act_dec13 = Lib.ConnectPlc1.plcitems.Act_dec13.ToString("f3");

                    #endregion
                    #region 14
                    Error_Code14 = Lib.ConnectPlc1.plcitems.Erroor_Code14.ToString("f3");
                    Act_Posion14 = Lib.ConnectPlc1.plcitems.Act_Pos14.ToString("f3");
                    //Act_acc14 = Lib.ConnectPlc1.plcitems.Act_acc14.ToString("f3");
                    //Act_dec14 = Lib.ConnectPlc1.plcitems.Act_dec14.ToString("f3");

                    #endregion
                    #region 15
                    Error_Code15 = Lib.ConnectPlc1.plcitems.Erroor_Code15.ToString("f3");
                    Act_Posion15 = Lib.ConnectPlc1.plcitems.Act_Pos15.ToString("f3");
                    //Act_acc15 = Lib.ConnectPlc1.plcitems.Act_acc15.ToString("f3");
                    //Act_dec15 = Lib.ConnectPlc1.plcitems.Act_dec15.ToString("f3");

                    #endregion
                    #region 16
                    Error_Code16 = Lib.ConnectPlc1.plcitems.Erroor_Code16.ToString("f3");
                    Act_Posion16 = Lib.ConnectPlc1.plcitems.Act_Pos16.ToString("f3");
                    //Act_acc16 = Lib.ConnectPlc1.plcitems.Act_acc16.ToString("f3");
                    //Act_dec16 = Lib.ConnectPlc1.plcitems.Act_dec16.ToString("f3");

                    #endregion
                    Thread.Sleep(200);
                }


            });


        }
        #endregion
        #region
        private void readplc()
        {
            Task.Run(() =>
            {
                while (false)
                {
                    Act_Posion0 = Lib.Connect_Plc.plcitems.Act_Pos0.ToString("f3");
                    Act_Posion1 = Lib.Connect_Plc.plcitems.Act_Pos1.ToString("f3");
                    Act_Posion2 = Lib.Connect_Plc.plcitems.Act_Pos2.ToString("f3");
                    Act_Posion3 = Lib.Connect_Plc.plcitems.Act_Pos3.ToString("f3");
                    Act_Posion4 = Lib.Connect_Plc.plcitems.Act_Pos4.ToString("f3");
                    Act_Posion5 = Lib.Connect_Plc.plcitems.Act_Pos5.ToString("f3");
                    Act_Posion6 = Lib.Connect_Plc.plcitems.Act_Pos6.ToString("f3");
                    Act_Posion7 = Lib.Connect_Plc.plcitems.Act_Pos7.ToString("f3");
                    Act_Posion8 = Lib.Connect_Plc.plcitems.Act_Pos8.ToString("f3");
                    Act_Posion9 = Lib.Connect_Plc.plcitems.Act_Pos9.ToString("f3");
                    Act_Posion10 = Lib.Connect_Plc.plcitems.Act_Pos10.ToString("f3");
                    Act_Posion11 = Lib.Connect_Plc.plcitems.Act_Pos11.ToString("f3");
                    Act_Posion12 = Lib.Connect_Plc.plcitems.Act_Pos12.ToString("f3");
                    Act_Posion13 = Lib.Connect_Plc.plcitems.Act_Pos13.ToString("f3");
                    Act_Posion14 = Lib.Connect_Plc.plcitems.Act_Pos14.ToString("f3");
                    Act_Posion15 = Lib.Connect_Plc.plcitems.Act_Pos15.ToString("f3");
                    Act_Posion16 = Lib.Connect_Plc.plcitems.Act_Pos16.ToString("f3");
                    //  Error_Code0 = Lib.Connect_Plc.plcitems.Erroor_Code0.ToString("F3") ;
                    Error_Code1 = Lib.Connect_Plc.plcitems.Erroor_Code1.ToString("F3");
                    Error_Code2 = Lib.Connect_Plc.plcitems.Erroor_Code2.ToString("F3");
                    Error_Code3 = Lib.Connect_Plc.plcitems.Erroor_Code3.ToString("F3");



                }


            });


        }

        #endregion
    }

}
