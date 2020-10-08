using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;
using WpfApp1.Resource;


namespace WpfApp1.Command
{
    public class MyResourceExtension : MarkupExtension, INotifyPropertyChanged, IHandle<LanguageChangedMessage>
    {
        public string Key
        {
            get;
            set;
        }
        public string Value
        {
            get
            {
                if (Key == null)
                {
                    return null;
                }
                IResourceTask result = IoC.Get<IResourceTask>();
                string s = result.GetString(Key);
                return s;
            }
        }
        public MyResourceExtension()
        {

            if (!Execute.InDesignMode)
            {
                IoC.Get<IEventAggregator>().Subscribe(this);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void PropertyChanted()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Value"));
            }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            IProvideValueTarget target = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
            Binding binding = new Binding("Value") { Source = this, Mode = BindingMode.OneWay };
            return binding.ProvideValue(serviceProvider) as BindingExpression;
        }

        public void Handle(LanguageChangedMessage message)
        {
            PropertyChanted();
        }
    }
}
