using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace WpfApp1.Lib
{
    class Repice_Xml : INotifyPropertyChanged
    {
        #region 通知
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region List收集
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
                 OnPropertyChanged("XmlItems");

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
                OnPropertyChanged("XmlItems0");

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
                OnPropertyChanged("XmlItems1");

            }
        }
        #endregion

        #region 字段声明
        private string iD0;
       public string ID0 {
            get
            { return iD0; }
            set
            {
                iD0 = value;
                 OnPropertyChanged("ID0"); 
            }
        }
        private string name0;
        public string Name0
        {
            get
            { return name0; }
            set
            {
                if (!(value == ""))
                { name0 = value; }
                else
                    name0 = DateTime.Now.ToString("d");
                OnPropertyChanged("Name0");
            }
        }
        private string accDeler0;
        public string AccDeler0
        {
            get
            { return accDeler0; }
            set
            {
                accDeler0 = value;
                OnPropertyChanged("AccDeler0");
            }
        }
        private string decDeler0;
        public string DecDeler0
        {
            get
            { return decDeler0; }
            set
            {
                decDeler0 = value;
                OnPropertyChanged("DecDeler0");
            }
        }
        private string pOsition0_0;
        public string POsition0_0
        {
            get
            { return pOsition0_0; }
            set
            {
                pOsition0_0 = value;
                OnPropertyChanged("POsition0_0");
            }
        }
        private string pOsition1_0;
        public string POsition1_0
        {
            get
            { return pOsition1_0; }
            set
            {
                pOsition1_0 = value;
                OnPropertyChanged("POsition1_0");
            }
        }
        private string pOsition2_0;
        public string POsition2_0
        {
            get
            { return pOsition2_0; }
            set
            {
                pOsition2_0 = value;
                OnPropertyChanged("POsition2_0");
            }
        }
        #endregion
        #region XML生成

        string xmlfilename;
        public  async Task Xml_Creat()
        {
            XDocument xDocument = new XDocument();//
            XDeclaration xDeclaration = xDocument.Declaration;
           ;
            XElement xElement = new XElement("asix",
               new XElement("RecipeParameter",
               new XElement("ID", "0000"),
               new XElement("Name", 123),
               new XElement("CreatTime", DateTime.Now.ToString("D"))
                ),
               new XElement("ProcessParameter",
               new XElement("Pressure0", "1.5"),
               new XElement("Pressure1", "1.2"),
               new XElement("Pressure2", "1.3"),
               new XElement("Pressure3", "1.2"),
               new XElement("Pressure4", "1.3"),
               new XElement("Temperature0", "20"),
               new XElement("Temperature1", "45"),
               new XElement("Temperature2", "32"),
               new XElement("Temperature3", "25"),
               new XElement("Temperature4", "13"),
               new XElement("SynchronousDistance0", "1.5"),
               new XElement("SynchronousDistance1", "1.2"),
               new XElement("SynchronousDistance2", "1.3"),
               new XElement("SynchronousDistance3", "1.2"),
               new XElement("SynchronousDistance4", "1.3"),
               new XElement("SynchronousSpeed0", "1.5"),
               new XElement("SynchronousSpeed1", "1.2"),
               new XElement("SynchronousSpeed2", "1.3"),
               new XElement("SynchronousSpeed3", "1.2"),
               new XElement("SynchronousSpeed4", "1.3")
              
                ),
            new XElement("Asix",
               new XElement("ID", "1"),
               new XElement("Name", "1_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
     new XElement("Asix",
                new XElement("ID", "2"),
               new XElement("Name", "2_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
    new XElement("Asix",
               new XElement("ID", "3"),
               new XElement("Name", "3_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
    new XElement("Asix",
               new XElement("ID", "4"),
               new XElement("Name", "4_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
  new XElement("Asix",
               new XElement("ID", "5"),
               new XElement("Name", "5_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
  new XElement("Asix",
               new XElement("ID", "6"),
               new XElement("Name", "6_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
 new XElement("Asix",
               new XElement("ID", "7"),
               new XElement("Name", "7_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
  new XElement("Asix",
               new XElement("ID", "8"),
               new XElement("Name", "8_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
new XElement("Asix",
               new XElement("ID", "9"),
               new XElement("Name", "9_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
 new XElement("Asix",
               new XElement("ID", "10"),
               new XElement("Name", "10_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
 new XElement("Asix",
               new XElement("ID", "11"),
               new XElement("Name", "11_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
 new XElement("Asix",
               new XElement("ID", "12"),
               new XElement("Name", "12_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
 new XElement("Asix",
               new XElement("ID", "13"),
               new XElement("Name", "13_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
 new XElement("Asix",
               new XElement("ID", "14"),
               new XElement("Name", "14_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
new XElement("Asix",
               new XElement("ID", "15"),
               new XElement("Name", "15_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000")),
  new XElement("Asix",
               new XElement("ID", "16"),
               new XElement("Name", "16_Asix"),
               new XElement("POsition0", "1000"),
               new XElement("Speed0", "1000"),
              new XElement("POsition1", "1000"),
               new XElement("Speed1", "1000"),
               new XElement("POsition2", "1000"),
               new XElement("Speed2", "1000"),
               new XElement("POsition3", "1000"),
               new XElement("Speed3", "1000"),
               new XElement("POsition4", "1000"),
               new XElement("Speed4", "1000"),
               new XElement("POsition5", "1000"),
               new XElement("Speed5", "1000"),
               new XElement("POsition6", "1000"),
               new XElement("Speed6", "1000"),
               new XElement("POsition7", "1000"),
               new XElement("Speed7", "1000"),
               new XElement("POsition8", "1000"),
               new XElement("Speed8", "1000"),
               new XElement("POsition9", "1000"),
               new XElement("Speed9", "1000"))
    //new XElement("Asix",//带属性
    //           new XElement("ID", "5"),
    //            new XElement("Name", "END_Asix"),
    //           new XElement("AccDeler", "1000"),
    //           new XElement("DecDeler", "1000"),
    //           new XElement("POsition0", "100"),
    //           new XElement("POsition1", "1000"),
    //           new XElement("POsition2", "150"))
            
               );
            xDocument.Add(xElement);

            xmlfilename ="Repice_Xml/"+DateTime.Now.ToString("D") + ".xml";
            if (File.Exists(xmlfilename))
            {
                //System.Windows.MessageBox.Show("该表已经存在"); //  new XElement("POsition2", new XAttribute("AGE", 20)
                await((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("Wow, you typed Return and got",xmlfilename +"已经存在");
            }
            else
            xDocument.Save(xmlfilename);
        }
        #endregion
        #region XML读取
        public async Task<ObservableCollection<Lib.Xml_helper>>  Xml_Read(string filepath0)
        {
            //Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            //dlg.FileName = ""; // Default file name
            //dlg.DefaultExt = ".xml";  // Default file extension
            //dlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* "; // Filter files by extension
            //// Show open file dialog box
            //Nullable<bool> result = dlg.ShowDialog();
            //// Process open file dialog box results
            //if (result == true)
            //{// Growl.Success("成功");
              if (filepath0!="")
            { 
            XmlItems.Clear();
            XmlItems0.Clear();
            XmlItems1.Clear();
                string filename = filepath0;//dig.filename
                XDocument xDocument = new XDocument();
                XElement xElement = XElement.Load(filename);
                
                IEnumerable<XElement> xElement1 = from p1 in xElement.Elements("RecipeParameter")
                                                  select p1;
                await Task.Run(() => {

                    foreach (XElement p1 in xElement1)
                    {
                        Application.Current.Dispatcher.Invoke((System.Action)(() =>
                        {
                            XmlItems0.Add(

                          new Lib.Alm(
                       Convert.ToInt32(p1.Element("ID").Value),
                       p1.Element("Name").Value.ToString(),
                       p1.Element("CreatTime").Value.ToString()
                      )  );
                        }));


                    }
                });
                ;
                IEnumerable<XElement> xElement2 = from p2 in xElement.Elements("ProcessParameter")
                                                  select p2;
                await Task.Run(() =>
                {

                    foreach (XElement p2 in xElement2)
                    {
                        Application.Current.Dispatcher.Invoke((System.Action)(() =>
                        {
                            XmlItems1.Add(

                         new Lib.Recipe_Process(
                          
                       p2.Element("Pressure0").Value.ToString(),
                      p2.Element("Pressure1").Value.ToString(),
                      p2.Element("Pressure2").Value.ToString(),
                      p2.Element("Pressure3").Value.ToString(),
                      p2.Element("Pressure4").Value.ToString(),
                      p2.Element("Temperature0").Value.ToString(),
                      p2.Element("Temperature1").Value.ToString(),
                      p2.Element("Temperature2").Value.ToString(),
                      p2.Element("Temperature3").Value.ToString(),
                      p2.Element("Temperature4").Value.ToString(),
                       p2.Element("SynchronousDistance0").Value.ToString(),
                      p2.Element("SynchronousDistance1").Value.ToString(),
                      p2.Element("SynchronousDistance2").Value.ToString(),
                      p2.Element("SynchronousDistance3").Value.ToString(),
                      p2.Element("SynchronousDistance4").Value.ToString(),
                      p2.Element("SynchronousSpeed0").Value.ToString(),
                      p2.Element("SynchronousSpeed1").Value.ToString(),
                      p2.Element("SynchronousSpeed2").Value.ToString(),
                      p2.Element("SynchronousSpeed3").Value.ToString(),
                      p2.Element("SynchronousSpeed4").Value.ToString()
                      ));
                        }));


                    }
                });
                ; IEnumerable<XElement> xElements = from p in xElement.Elements("Asix")
                                                    select p;
                await Task.Run(() =>
                {

                    foreach (XElement p in xElements)
                    {
                        Application.Current.Dispatcher.Invoke((System.Action)(() =>
                        {
                            XmlItems.Add(

                         new Lib.Xml_helper(
                     
                   Convert.ToInt32(  p.Element("ID").Value),
                       p.Element("POsition0").Value.ToString(),
                       p.Element("POsition1").Value.ToString(),
                       p.Element("POsition2").Value.ToString(),
                       p.Element("POsition3").Value.ToString(),
                       p.Element("POsition4").Value.ToString(),
                       p.Element("POsition5").Value.ToString(),
                       p.Element("POsition6").Value.ToString(),
                       p.Element("POsition7").Value.ToString(),
                       p.Element("POsition8").Value.ToString(),
                       p.Element("POsition9").Value.ToString(),
                        p.Element("Speed0").Value.ToString(),
                       p.Element("Speed1").Value.ToString(),
                       p.Element("Speed2").Value.ToString(),
                       p.Element("Speed3").Value.ToString(),
                       p.Element("Speed4").Value.ToString(),
                       p.Element("Speed5").Value.ToString(),
                       p.Element("Speed6").Value.ToString(),
                       p.Element("Speed7").Value.ToString(),
                       p.Element("Speed8").Value.ToString(),
                       p.Element("Speed9").Value.ToString())
                      );

                        }));


                    }
                });
           // } 
           
            }
            return XmlItems;
        }
        #endregion

    }
}
