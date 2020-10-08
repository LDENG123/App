using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.Command_film
{
    /// <summary>
    /// 定义command类继承Icommand接口
    /// </summary>
        public class MyCommand : ICommand
        {
            /// <summary>
            /// 检查命令是否可以执行的事件，在UI事件发生导致控件状态或数据发生变化时触发
            /// </summary>
            public event EventHandler CanExecuteChanged
            {
                add
                {
                    if (_canExecute != null)
                    {
                        CommandManager.RequerySuggested += value;
                    }
                }
                remove
                {
                    if (_canExecute != null)
                    {
                        CommandManager.RequerySuggested -= value;
                    }
                }
            }

            /// <summary>
            /// 判断命令是否可以执行的方法
            /// </summary>
            /// func委托  定义函数一个参数一个返回值
            private Func<object, bool> _canExecute;

            /// <summary>
            /// 命令需要执行的方法
            /// </summary>
            /// action定义委托没有返回只有参数
            private Action<object> _execute;

            /// <summary>
            /// 创建一个命令
            /// </summary>
            /// <param name="execute">命令要执行的方法</param>
            public MyCommand(Action<object> execute) : this(execute, null)
            {
            }

            /// <summary>
            /// 创建一个命令
            /// </summary>
            /// <param name="execute">命令要执行的方法</param>
            /// <param name="canExecute">判断命令是否能够执行的方法</param>
            public MyCommand(Action<object> execute, Func<object, bool> canExecute)
            {
                _execute = execute;
                _canExecute = canExecute;
            }

            /// <summary>
            /// 判断命令是否可以执行
            /// </summary>
            /// <param name="parameter">命令传入的参数</param>
            /// <returns>是否可以执行</returns>
            public bool CanExecute(object parameter)
            {
                if (_canExecute == null) return true;
                return _canExecute(parameter);
            }

            /// <summary>
            /// 执行命令
            /// </summary>
            /// <param name="parameter"></param>
            public void Execute(object parameter)
            {
                if (_execute != null && CanExecute(parameter))
                {
                    _execute(parameter);
                }
            }
        }

   
}
