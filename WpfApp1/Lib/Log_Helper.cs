using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Lib
{
    class Log_Helper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");
        public static readonly log4net.ILog logdebug = log4net.LogManager.GetLogger("logdebug");
        public static void Log_Info(string message)
        {
            if (loginfo.IsInfoEnabled) loginfo.Info(message);
        }
        public static void Log_Error(string message,Exception exception)
        {
            if (logerror.IsErrorEnabled) logerror.Error(message, exception);
        }

        public static void Log_Run(string message)
        {
            if (logerror.IsDebugEnabled) logerror.Debug(message);
        }
    }
}
