using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Lib
{
    class Recipe_Process : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Recipe_Process(
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
        public Recipe_Process(int _id, string _name, string _creattime
         )
        {
            id = _id;name = _name;creatTime = _creattime;
           
        }
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
        #region
      

        #endregion
    }
}
