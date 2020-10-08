using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Lib
{
    public static class MaterialDesignEx
    {
        public static readonly DependencyProperty ButtonDockProperty = DependencyProperty.RegisterAttached(
           "ButtonDock", typeof(Dock), typeof(MaterialDesignEx), new PropertyMetadata(default(Dock)));

        public static void SetButtonDock(DependencyObject element, Dock value)
        {
            element.SetValue(ButtonDockProperty, value);
        }

        public static Dock GetButtonDock(DependencyObject element)
        {
            return (Dock)element.GetValue(ButtonDockProperty);
        }
    }
}
