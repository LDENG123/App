using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfApp1.ViewModels
{
    class MannualViewMoedel : Screen, INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;
        //protected virtual void OnPropertyChanged(string propertyName = null)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        #region List收集
        private ObservableCollection<Lib.Alm> alarmItems = new ObservableCollection<Lib.Alm>();
        public ObservableCollection<Lib.Alm> AlarmItems
        {
            get
            { return alarmItems; }
            set
            {
                alarmItems = value;
                //OnPropertyChanged("AlarmItems");
                NotifyOfPropertyChange(() => AlarmItems);
            }
        }

        #endregion

        private void AddAlarmItem(Lib.Alm t)
        {
            foreach (Lib.Alm item in AlarmItems)
            {
                if (item.ID == t.ID) return;
            }
            AlarmItems.Add(t);
        }
        public MannualViewMoedel()
        {

            AddAlarmItem(new Lib.Alm(2, DateTime.Now.ToString(), "急停按下"));
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

                                i++;
                                AlarmItems.Insert(0, new Lib.Alm(i, DateTime.Now.ToString(), i.ToString()));

                            }));
                return _Add;
            }
        }




        #region List收集
        private ObservableCollection<Lib.Xml_helper> alarmItems1 = new ObservableCollection<Lib.Xml_helper>();
        public ObservableCollection<Lib.Xml_helper> AlarmItems1
        {
            get
            { return alarmItems1; }
            set
            {
                alarmItems1 = value;
                //OnPropertyChanged("AlarmItems1");
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


        public void ChanguageLanguage1(string lan)
        {
            System.Windows.MessageBox.Show(lan);
        }
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
                                        //    /* p.Element("POsition2").Value.ToString())*/
                                        //    p.Element("POsition2").Attribute("AGE").Value.ToString()));

                                    }

                                }


                            }));
                return _Add1;
            }
        }
    }
}


