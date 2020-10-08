using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Lib
{
    class Logtext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region 属性
        private string name;
        public string Name {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        private string path_Name;
        public string Path_Name
        {
            get { return path_Name; }
            set
            {
                path_Name = value;
                OnPropertyChanged("Path_Name");
            }
        }


        #endregion
        #region 构造函数
        public Logtext(string _name,string _pathname  )
        {
            name = _name;
            path_Name = _pathname;
        }
        #endregion


    }
}
