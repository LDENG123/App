using Caliburn.Micro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Panuon.UI.Silver;
using System;
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

namespace WpfApp1.ViewModels
{
    class RecipeViewModel:Screen,INotifyPropertyChanged
    {
        Lib.Repice_Xml repice_Xml;
        private readonly IEventAggregator _eventAggregator;
        public RecipeViewModel()
        {
            _eventAggregator = IoC.Get<IEventAggregator>();
            _eventAggregator.Subscribe(this);
             repice_Xml = new Repice_Xml();
            #region 刷新配方
            string filename = "Repice_Xml";
            DirectoryInfo folder = new DirectoryInfo(filename);
            Getfie.Clear();
          
            Ts.Clear();
            foreach (FileInfo file in folder.GetFiles("*.xml"))
            {

                Getfie.Add(new Lib.Alm(Getfie.Count, System.IO.Path.GetFileNameWithoutExtension(file.FullName),
                                                         file.FullName));
                Ts.Add(System.IO.Path.GetFileNameWithoutExtension(file.FullName));
            }
            #endregion
        }
        #region List收集
        private List<string> ts = new List<string>();
    public List<string> Ts
        {
            get
            {
                return ts;
            }
            set
            {
                ts = value;
                NotifyOfPropertyChange(() => Ts);

            }
        }
        private int selectindex = 1;
        public int Selectindex
        {
            get
            {
                return selectindex;
            }
            set
            {
                selectindex = value;
                NotifyOfPropertyChange(() => Selectindex);

            }
        }

        private ObservableCollection<Lib.Xml_helper> xmlItems = new ObservableCollection<Lib.Xml_helper>();
        public ObservableCollection<Lib.Xml_helper> XmlItems
        {
            get
            {
                return xmlItems;
            }
            set
            {
                xmlItems = value;
              NotifyOfPropertyChange(()=> XmlItems) ; 

            }
        }
        private void AddXmlItem(Lib.Xml_helper t)
        {
            foreach (Lib.Xml_helper item in XmlItems)
            {
                if (item.ID == t.ID) return;
            }
            XmlItems.Add(t);
        }
        private ObservableCollection<Lib.Alm> getfile = new ObservableCollection<Lib.Alm>();
        public ObservableCollection<Lib.Alm> Getfie
        {
            get
            {
                return getfile;
            }
            set
            {
                getfile = value;
                NotifyOfPropertyChange(() => Getfie);

            }
        }
        private ObservableCollection<Lib.Alm> xmlItems0 = new ObservableCollection<Lib.Alm>();
        public ObservableCollection<Lib.Alm> XmlItems0
        {
            get
            {
                return xmlItems0;
            }
            set
            {
                xmlItems0 = value;
                NotifyOfPropertyChange(() => XmlItems0);

            }
        }
        private ObservableCollection<Lib.Recipe_Process> xmlItems1 = new ObservableCollection<Lib.Recipe_Process>();
        public ObservableCollection<Lib.Recipe_Process> XmlItems1
        {
            get
            {
                return xmlItems1;
            }
            set
            {
                xmlItems1 = value;
                NotifyOfPropertyChange(() => XmlItems1);

            }
        }
        #endregion
        #region Command
        private Command_film.MyCommand _NewCreatFile;
        public Command_film.MyCommand NewCreatFile
        {
            get
            {
                if (_NewCreatFile == null)
                    _NewCreatFile = new Command_film.MyCommand(
                        new Action<object>(
                         async e =>
                        {
                          await  repice_Xml.Xml_Creat(); 

                        }));
                return _NewCreatFile;
            }
        }
        private Command_film.MyCommand _saveDateFiler;
        public Command_film.MyCommand SaveDateFile
        {
            get
            {
                if (_saveDateFiler == null)
                    _saveDateFiler = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix01 = "5";

                        }));
                return _saveDateFiler;
            }
        }
        private Command_film.MyCommand _loadXmlFile;
        public Command_film.MyCommand LoadXmlFile
        {
            get
            {
                if (_loadXmlFile == null)
                    _loadXmlFile = new Command_film.MyCommand(
                        new Action<object>(
                        async e =>
                        {
                           
                            XmlItems =  await repice_Xml.Xml_Read(Getfie[Selectindex].Message);
                            XmlItems0 = repice_Xml.XmlItems0;
                            XmlItems1 = repice_Xml.XmlItems1;

                        }));
                return _loadXmlFile;
            }
        }
        private Command_film.MyCommand _deleteXmlFile;
        public Command_film.MyCommand DeleteXmlFile
        {
            get
            {
                if (_deleteXmlFile == null)
                    _deleteXmlFile = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            Lib.ConnectPlc1.plcitems.Set1_Asix03 = "5";

                        }));
                return _deleteXmlFile;
            }
        }
        private Command_film.MyCommand recipeCbxDropDownOpened;
        public Command_film.MyCommand RecipeCbxDropDownOpened
        {
            get
            {
                if (recipeCbxDropDownOpened == null)
                    recipeCbxDropDownOpened = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            string filename = "Repice_Xml";
                            DirectoryInfo folder = new DirectoryInfo(filename);
                            Getfie.Clear();
                          
                            Ts.Clear();
                            foreach (FileInfo file in folder.GetFiles("*.xml"))
                            {

                                Getfie.Add(new Lib.Alm(Getfie.Count, System.IO.Path.GetFileNameWithoutExtension(file.FullName),
                                                                         file.FullName));
                                Ts.Add(System.IO.Path.GetFileNameWithoutExtension(file.FullName));
                            }

                        }));
                return recipeCbxDropDownOpened;
            }
        }
        private Command_film.MyCommand recipeCbxDropDownClosed;
        public Command_film.MyCommand RecipeCbxDropDownClosed
        {
            get
            {
                if (recipeCbxDropDownClosed == null)
                    recipeCbxDropDownClosed = new Command_film.MyCommand(
                        new Action<object>(
                        e =>
                        {
                            string filename = "Repice_Xml";
                            DirectoryInfo folder = new DirectoryInfo(filename);
                            Ts.Clear();
                            Getfie.Clear();
                            foreach (FileInfo file in folder.GetFiles("*.xml"))
                            {
                                Ts.Add(System.IO.Path.GetFileNameWithoutExtension(file.FullName));
                                Getfie.Add( new Lib.Alm(Getfie.Count, System.IO.Path.GetFileNameWithoutExtension(file.FullName),
                                                                         file.FullName));
                            }

                        }));
                return recipeCbxDropDownClosed;
            }
        }
        private Command_film.MyCommand recipeCbxSelectionChanged;
        public Command_film.MyCommand RecipeCbxSelectionChanged
        {
            get
            {
                if (recipeCbxSelectionChanged == null)
                    recipeCbxSelectionChanged = new Command_film.MyCommand(
                        new Action<object>(
                        async e =>
                        {
                            XmlItems = await repice_Xml.Xml_Read(Getfie[Selectindex].Message);
                            XmlItems0 = repice_Xml.XmlItems0;
                            XmlItems1 = repice_Xml.XmlItems1;

                        }));
                return recipeCbxSelectionChanged;
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
        #endregion

    }
}
