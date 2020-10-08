using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Lib
{
    class Xml_helper: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region 重载0
        public Xml_helper(int _id,
            string ps0,string ps1,string ps2, string ps3, string ps4, string ps5, string ps6, string ps7, string ps8, string ps9,
            string sp0, string sp1, string sp2, string sp3, string sp4, string sp5, string sp6, string sp7, string sp8, string sp9)
        {

            id = _id;
            pOsition0 = ps0;
            pOsition1 = ps1;
            pOsition2 = ps2;
            pOsition2 = ps2;
            pOsition3 = ps3;
            pOsition4 = ps4;
            pOsition5 = ps5;
            pOsition6 = ps6;
            pOsition7 = ps7;
            pOsition8 = ps8;
            pOsition9 = ps9;
            speed0 = sp0;
            speed1 = sp1;
            speed2 = sp2;
            speed3 = sp3;
            speed4 = sp4;
            speed5 = sp5;
            speed6 = sp6;
            speed7 = sp7;
            speed8 = sp8;
            speed9 = sp9;






        }
        #endregion
        #region 重载1
        public Xml_helper(int _id, string _name, string _creattime
        )
        {
            id = _id; name = _name; creatTime = _creattime;

        }
        #endregion
        #region 重载2
        public Xml_helper( 
           string prsuer0, string prsuer1, string prsuer2, string prsuer3, string prsuer4,
           string temper0, string temper1, string temper2, string temper3, string temper4,
            string syd0, string syd1, string syd2, string syd3, string syd4,
            string syp0, string syp1, string syp2, string syp3, string syp4)
        {
            //id = _id;name = _name;creatTime = _creattime;int _id, string _name, string _creattime,
            pressure0 = prsuer0; pressure1 = prsuer1; pressure2 = prsuer3; pressure3 = prsuer3; pressure4 = prsuer4;
            temperature0 = temper0; temperature1 = temper1; temperature2 = temper2; temperature3 = temper3; temperature4 = temper4;
            synchronousDistance0 = syd0; synchronousDistance1 = syd1; synchronousDistance2 = syd2; synchronousDistance3 = syd3; synchronousDistance4 = syd4;
            synchronousSpeed0 = syp0; synchronousSpeed1 = syp1; synchronousSpeed2 = syp2; synchronousSpeed3 = syp3; synchronousSpeed4 = syp4;
        }
        #endregion
        #region 字段声明
        public int id;
        public int ID
        {
            get
            {
                return id
                        ;
            }
            set
            {
                id = value;
                OnPropertyChanged("ID");
            }
        }
        private string name;
        public string Name
        {
            get
            { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        private string accDeler;
        public string AccDeler
        {
            get
            { return accDeler; }
            set
            {
                accDeler = value;
                OnPropertyChanged("AccDeler");
            }
        }
        private string decDeler;
        public string DecDeler
        {
            get
            { return decDeler; }
            set
            {
                decDeler = value;
                OnPropertyChanged("DecDeler");
            }
        }
        #region
        public String pOsition0;
        public String POsition0
        {
            get
            {
                return pOsition0
                        ;
            }
            set
            {
                pOsition0 = value;
                OnPropertyChanged("POsition0");
            }
        }
        public String pOsition1;
        public String POsition1
        {
            get
            {
                return pOsition1
                        ;
            }
            set
            {
                pOsition1 = value;
                OnPropertyChanged("POsition1");
            }
        }
        public String pOsition2;
        public String POsition2
        {
            get
            {
                return pOsition2
                        ;
            }
            set
            {
                pOsition2 = value;
                OnPropertyChanged("POsition2");
            }
        }
        public String pOsition3;
        public String POsition3
        {
            get
            {
                return pOsition3
                        ;
            }
            set
            {
                pOsition3 = value;
                OnPropertyChanged("POsition3");
            }
        }
        public String pOsition4;
        public String POsition4
        {
            get
            {
                return pOsition4
                        ;
            }
            set
            {
                pOsition4 = value;
                OnPropertyChanged("POsition4");
            }
        }
        public String pOsition5;
        public String POsition5
        {
            get
            {
                return pOsition5
                        ;
            }
            set
            {
                pOsition5 = value;
                OnPropertyChanged("POsition5");
            }
        }
        public String pOsition6;
        public String POsition6
        {
            get
            {
                return pOsition6
                        ;
            }
            set
            {
                pOsition6 = value;
                OnPropertyChanged("POsition6");
            }
        }
        public String pOsition7;
        public String POsition7
        {
            get
            {
                return pOsition7
                        ;
            }
            set
            {
                pOsition7 = value;
                OnPropertyChanged("POsition7");
            }
        }
        public String pOsition8;
        public String POsition8
        {
            get
            {
                return pOsition8
                        ;
            }
            set
            {
                pOsition8 = value;
                OnPropertyChanged("POsition8");
            }
        }
        public String pOsition9;
        public String POsition9
        {
            get
            {
                return pOsition9
                        ;
            }
            set
            {
                pOsition9 = value;
                OnPropertyChanged("POsition9");
            }
        }
        #endregion
        #region
        public String speed0;
        public String Speeed0
        {
            get
            {
                return speed0
                        ;
            }
            set
            {
                speed0 = value;
                OnPropertyChanged("Speeed0");
            }
        }
        public String speed1;
        public String Speeed1
        {
            get
            {
                return speed1
                        ;
            }
            set
            {
                speed1 = value;
                OnPropertyChanged("Speeed1");
            }
        }
        public String speed2;
        public String Speeed2
        {
            get
            {
                return speed2
                        ;
            }
            set
            {
                speed2 = value;
                OnPropertyChanged("Speeed2");
            }
        }
        public String speed3;
        public String Speeed3
        {
            get
            {
                return speed3
                        ;
            }
            set
            {
                speed3 = value;
                OnPropertyChanged("Speeed3");
            }
        }
        public String speed4;
        public String Speeed4
        {
            get
            {
                return speed4
                        ;
            }
            set
            {
                speed4 = value;
                OnPropertyChanged("Speeed4");
            }
        }
        public String speed5;
        public String Speeed5
        {
            get
            {
                return speed5
                        ;
            }
            set
            {
                speed5 = value;
                OnPropertyChanged("Speeed5");
            }
        }
        public String speed6;
        public String Speeed6
        {
            get
            {
                return speed6
                        ;
            }
            set
            {
                speed6 = value;
                OnPropertyChanged("Speeed6");
            }
        }
        public String speed7;
        public String Speeed7
        {
            get
            {
                return speed7
                        ;
            }
            set
            {
                speed7 = value;
                OnPropertyChanged("Speeed7");
            }
        }
        public String speed8;
        public String Speeed8
        {
            get
            {
                return speed8
                        ;
            }
            set
            {
                speed8 = value;
                OnPropertyChanged("Speeed8");
            }
        }
        public String speed9;
        public String Speeed9
        {
            get
            {
                return speed9
                        ;
            }
            set
            {
                speed9 = value;
                OnPropertyChanged("Speeed9");
            }
        }
        #endregion
        #endregion
        #region
        private string creatTime;
        public string CreatTime
        {
            get
            { return creatTime; }
            set
            {
                creatTime = value;
                OnPropertyChanged("CreatTime");
            }
        }
        private string pressure0;
        public string Pressure0
        {
            get
            { return pressure0; }
            set
            {
                pressure0 = value;
                OnPropertyChanged("Pressure0");
            }
        }
        private string pressure1;
        public string Pressure1
        {
            get
            { return pressure1; }
            set
            {
                pressure1 = value;
                OnPropertyChanged("Pressure1");
            }
        }
        private string pressure2;
        public string Pressure2
        {
            get
            { return pressure2; }
            set
            {
                pressure2 = value;
                OnPropertyChanged("Pressure2");
            }
        }
        private string pressure3;
        public string Pressure3
        {
            get
            { return pressure3; }
            set
            {
                pressure3 = value;
                OnPropertyChanged("Pressure3");
            }
        }
        private string pressure4;
        public string Pressure4
        {
            get
            { return pressure4; }
            set
            {
                pressure4 = value;
                OnPropertyChanged("Pressure4");
            }
        }
        #endregion
        #region
        private string temperature0;
        public string Temperature0
        {
            get
            { return temperature0; }
            set
            {
                temperature0 = value;
                OnPropertyChanged("Temperature0");
            }
        }
        private string temperature1;
        public string Temperature1
        {
            get
            { return temperature1; }
            set
            {
                temperature1 = value;
                OnPropertyChanged("Temperature1");
            }
        }
        private string temperature2;
        public string Temperature2
        {
            get
            { return temperature2; }
            set
            {
                temperature2 = value;
                OnPropertyChanged("Temperature2");
            }
        }
        private string temperature3;
        public string Temperature3
        {
            get
            { return temperature3; }
            set
            {
                temperature3 = value;
                OnPropertyChanged("Temperature3");
            }
        }
        private string temperature4;
        public string Temperature4
        {
            get
            { return temperature4; }
            set
            {
                temperature4 = value;
                OnPropertyChanged("Temperature4");
            }
        }
        #endregion
        #region
        private string synchronousDistance0;
        public string SynchronousDistance0
        {
            get
            { return synchronousDistance0; }
            set
            {
                synchronousDistance0 = value;
                OnPropertyChanged("SynchronousDistance0");
            }
        }
        private string synchronousDistance1;
        public string SynchronousDistance1
        {
            get
            { return synchronousDistance1; }
            set
            {
                synchronousDistance1 = value;
                OnPropertyChanged("SynchronousDistance1");
            }
        }
        private string synchronousDistance2;
        public string SynchronousDistance2
        {
            get
            { return synchronousDistance2; }
            set
            {
                synchronousDistance2 = value;
                OnPropertyChanged("SynchronousDistance2");
            }
        }
        private string synchronousDistance3;
        public string SynchronousDistance3
        {
            get
            { return synchronousDistance3; }
            set
            {
                synchronousDistance3 = value;
                OnPropertyChanged("SynchronousDistance3");
            }
        }
        private string synchronousDistance4;
        public string SynchronousDistance4
        {
            get
            { return synchronousDistance4; }
            set
            {
                synchronousDistance4 = value;
                OnPropertyChanged("SynchronousDistance4");
            }
        }
        private string synchronousSpeed0;
        public string SynchronousSpeed0
        {
            get
            { return synchronousSpeed0; }
            set
            {
                synchronousSpeed0 = value;
                OnPropertyChanged("SynchronousSpeed0");
            }
        }
        private string synchronousSpeed1;
        public string SynchronousSpeed1
        {
            get
            { return synchronousSpeed1; }
            set
            {
                synchronousSpeed1 = value;
                OnPropertyChanged("SynchronousSpeed1");
            }
        }
        private string synchronousSpeed2;
        public string SynchronousSpeed2
        {
            get
            { return synchronousSpeed2; }
            set
            {
                synchronousSpeed2 = value;
                OnPropertyChanged("SynchronousSpeed2");
            }
        }
        private string synchronousSpeed3;
        public string SynchronousSpeed3
        {
            get
            { return synchronousSpeed3; }
            set
            {
                synchronousSpeed3 = value;
                OnPropertyChanged("SynchronousSpeed3");
            }
        }
        private string synchronousSpeed4;
        public string SynchronousSpeed4
        {
            get
            { return synchronousSpeed4; }
            set
            {
                synchronousSpeed4 = value;
                OnPropertyChanged("SynchronousSpeed4");
            }
        }
#endregion

    }
}
