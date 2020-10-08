using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using Panuon.UI.Silver;

namespace WpfApp1.ViewModels
{
    [Export(typeof(LiveChartViewModel))]
    class LiveChartViewModel : Screen, INotifyPropertyChanged, IHandle<string>
    {
        ///继承通知消息接口
        #region INotifyPropertyChanged implementation
        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged1(string propertyName = null)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        #endregion
        #region 指针图属性字段说明
        private double _value;
        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                // OnPropertyChanged1("Value");
                NotifyOfPropertyChange(() => Value);

            }
        }
        #endregion 
        #region 实时曲线属性字段声明
        public ChartValues<MeasureModel> ChartValues { get; set; }
        public Func<double, string> DateTimeFormatter { get; set; }
        public double AxisStep { get; set; }
        public double AxisUnit { get; set; }
        private double _axisMin;
        private double _axisMax;
        private double _trend;
        public double AxisMax
        {
            get { return _axisMax; }
            set
            {
                _axisMax = value;
                //OnPropertyChanged1("AxisMax");
                NotifyOfPropertyChange(() => AxisMax);
            }
        }
        public double AxisMin
        {
            get { return _axisMin; }
            set
            {
                _axisMin = value;
                // OnPropertyChanged1("AxisMin");
                NotifyOfPropertyChange(() => AxisMin);
            }
        }
        public bool IsReading { get; set; }
        #endregion

        /// <summary>
        /// 饼图属性
        /// </summary>
        #region 饼图属性说明
        private double _pie_values0;
        public double Pie_values0
        {
            get { return _pie_values0; }
            set
            {
                _pie_values0 = value;
                // OnPropertyChanged1("");
                NotifyOfPropertyChange(() => Pie_values0);
            }

        }
        private double _pie_values1;
        public double Pie_values1
        {
            get { return _pie_values1; }
            set
            {
                _pie_values1 = value;
                // OnPropertyChanged1("Pie_values1");
                NotifyOfPropertyChange(() => Pie_values1);
            }

        }
        private double _pie_values2;
        public double Pie_values2
        {
            get { return _pie_values2; }
            set
            {
                _pie_values2 = value;
                // OnPropertyChanged1("Pie_values2");
                NotifyOfPropertyChange(() => Pie_values2);
            }

        }
        private double _pie_values3;
        public double Pie_values3
        {
            get { return _pie_values3; }
            set
            {
                _pie_values3 = value;
                //OnPropertyChanged1("Pie_values3");
                NotifyOfPropertyChange(() => Pie_values3);
            }

        }
        private string name_mum;
        public string Name_mum
        {
            get { return name_mum; }
            set
            {
                name_mum = value;
                // OnPropertyChanged1("Name_mum");
                NotifyOfPropertyChange(() => Name_mum);

            }

        }
        #endregion
        #region 图形字段声明
        private SeriesCollection seriesCollection;
        public SeriesCollection SeriesCollection
        {
            get { return seriesCollection; }
            set
            {
                seriesCollection = value;

                NotifyOfPropertyChange(() => SeriesCollection);
            }
        }
        private SeriesCollection seriesCollection1;
        public SeriesCollection SeriesCollection1
        {
            get { return seriesCollection1; }
            set
            {
                seriesCollection1 = value;

                NotifyOfPropertyChange(() => SeriesCollection1);
            }
        }
        private SeriesCollection seriesCollection2;
        public SeriesCollection SeriesCollection2
        {
            get { return seriesCollection2; }
            set
            {
                seriesCollection2 = value;

                NotifyOfPropertyChange(() => SeriesCollection2);
            }
        }
        public string[] Labels { get; set; }
        public string[] Labels1 { get; set; }
        public Func<ChartPoint, string> PointLabel { get; set; }
        public Func<double, string> Formatter { get; set; }
        #endregion
        #region 构造函数声明
        private readonly IEventAggregator _eventAggregator;
        public LiveChartViewModel()
        {
            _eventAggregator = IoC.Get<IEventAggregator>();
            _eventAggregator.Subscribe(this);
            #region realchart
            var mapper = Mappers.Xy<MeasureModel>()
         .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
         .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            //the values property will store our values array
            ChartValues = new ChartValues<MeasureModel>();

            //lets set how to display the X Labels
            DateTimeFormatter = value => new DateTime((long)value).ToString("hh.mm:ss");

            //AxisStep forces the distance between each separator in the X axis
            AxisStep = TimeSpan.FromSeconds(1).Ticks;
            //AxisUnit forces lets the axis know that we are plotting seconds
            //this is not always necessary, but it can prevent wrong labeling
            AxisUnit = TimeSpan.TicksPerSecond;

            SetAxisLimits(DateTime.Now);

            //The next code simulates data changes every 300 ms

            IsReading = false;

            #endregion 

            Name_mum = "2";
            Value = 100;

            #region cloumn0
            SeriesCollection = new SeriesCollection
               {
                   new ColumnSeries
                   {
                       Title = "TAB0",
                       Values = new ChartValues<double> { 10, 50, 39, 50, 10, 50, 39, 50, 11, 56, 42, 10, 50, 39, 50, 50, 39, 50, 10, 50, 39, 50, 11, 56 }
                   }
               };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "TAB1",
                Values = new ChartValues<double> { 11, 56, 42, 10, 50, 39, 50, 11, 56, 42, 10, 50, 39, 50, 56, 42, 10, 50, 39, 50, 11, 56, 42, 10 }
            });

            //also adding values updates and animates the chart automatically
            SeriesCollection[1].Values.Add(48d);

            Labels = new[] { "00:00:00" , "01:00:00", "02:00:00", "03:00:00","04:00:00" , "05:00:00", "06:00:00", "07:00:00",
                "08:00:00" , "09:00:00", "10:00:00", "11:00:00","12:00:00" , "13:00:00", "14:00:00", "15:00:00",
                "16:00:00" , "17:00:00", "18:00:00", "19:00:00","20:00:00" , "21:00:00", "22:00:00", "23:00:00",
               };
            #endregion
            #region cloumn1
            SeriesCollection2 = new SeriesCollection
               {
                   new ColumnSeries
                   {
                       Title = "OK",
                       Values = new ChartValues<double> { 10, 50, 39, 50, 10, 50, 39, 50, 11, 56}
                   }
               };

            //adding series will update and animate the chart automatically
            SeriesCollection2.Add(new ColumnSeries
            {
                Title = "NG",
                Values = new ChartValues<double> { 11, 56, 42, 10, 50, 39, 50, 11, 56, 42 }
            });

            //also adding values updates and animates the chart automatically
            SeriesCollection2[1].Values.Add(48d);

            Labels1 = new[] { "00" , "01", "02", "03","04" , "05", "06", "07", "08" , "09"
               };
            #endregion
            #region pie
            Formatter = value => value.ToString("N");
            PointLabel = chartPoint =>
               string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection1 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {4},
                    DataLabels = true,
                    LabelPoint = PointLabel
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {3},
                    DataLabels = true,
                    LabelPoint = PointLabel
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {2},
                    DataLabels = true,
                    LabelPoint = PointLabel
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {3},
                    DataLabels = true,
                    LabelPoint = PointLabel
                }, };
            #endregion
            InjectStopOnClick();
        }
        #endregion
        #region 实时曲线
        private void Read()
        {
            var r = new Random();

            while (IsReading)
            {
                Thread.Sleep(150);
                var now = DateTime.Now;

                _trend += r.Next(-8, 10);

                ChartValues.Add(new MeasureModel
                {
                    DateTime = now,
                    Value = _trend

                });

                SetAxisLimits(now);

                //lets only use the last 150 values
                if (ChartValues.Count > 50) ChartValues.RemoveAt(0);
            }
        }

        private void SetAxisLimits(DateTime now)
        {
            AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 1 second ahead
            AxisMin = now.Ticks - TimeSpan.FromSeconds(8).Ticks; // and 8 seconds behind

        }

        private void InjectStopOnClick()
        {
            IsReading = !IsReading;
            if (IsReading) Task.Factory.StartNew(Read);

        }
        #endregion 
        #region 饼图刷新
        private async Task Async(double d00, Double d01, double d02, double d03)
        {
            PointLabel = chartPoint =>
             string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection1 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Maria",
                    Values = new ChartValues<double> {d00},
                    DataLabels = true,
                    LabelPoint = PointLabel
                },
                new PieSeries
                {
                    Title = "Charles",
                    Values = new ChartValues<double> {d01},
                    DataLabels = true,
                    LabelPoint = PointLabel
                },
                new PieSeries
                {
                    Title = "Frida",
                    Values = new ChartValues<double> {d02},
                    DataLabels = true,
                    LabelPoint = PointLabel
                },
                new PieSeries
                {
                    Title = "Frederic",
                    Values = new ChartValues<double> {d03},
                    DataLabels = true,
                    LabelPoint = PointLabel
                }


            };

        }
        #endregion
        #region 指针图刷新
        private async Task TaskAsync0()
        {

            Value = new Random().Next(50, 250);

        }

        #endregion
        #region 柱形图刷新
        private void asynt_column(params double[] ps)
        {
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "TAB0",
                    FontSize=10,
                    Values = new ChartValues<double> { ps[0], ps[1], ps[2], ps[3], ps[4], ps[5], ps[6], ps[7], ps[8], ps[9],
                                                       ps[10], ps[11], ps[12], ps[13], ps[14], ps[15], ps[16], ps[17], ps[18], ps[19],
                                                       ps[20], ps[21], ps[22], ps[23] }
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "TAB1",
                FontSize = 10,
                Values = new ChartValues<double> {     ps[24], ps[25], ps[26], ps[27], ps[28], ps[29],
                                                       ps[30], ps[31], ps[32], ps[33], ps[34], ps[35], ps[36], ps[37], ps[38], ps[39],
                                                       ps[40], ps[41], ps[42], ps[43], ps[44], ps[45], ps[46], ps[47]  }
            });

            //also adding values updates and animates the chart automatically
            SeriesCollection[1].Values.Add(48d);
            Labels = new[] { "00:00:00" , "01:00:00", "02:00:00", "03:00:00","04:00:00" , "05:00:00", "06:00:00", "07:00:00",
                "08:00:00" , "09:00:00", "10:00:00", "11:00:00","12:00:00" , "13:00:00", "14:00:00", "15:00:00",
                "16:00:00" , "17:00:00", "18:00:00", "19:00:00","20:00:00" , "21:00:00", "22:00:00", "23:00:00",
               };
        }
        private void asynt_column1(params double[] ps)
        {
            SeriesCollection2 = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "TT0",
                    FontSize=10,
                    Values = new ChartValues<double> { ps[0], ps[1], ps[2], ps[3], ps[4], ps[5], ps[6], ps[7], ps[8], ps[9]


                }
            }};

            //adding series will update and animate the chart automatically
            SeriesCollection2.Add(new ColumnSeries
            {
                Title = "TT1",
                FontSize = 10,
                Values = new ChartValues<double> { ps[10], ps[11], ps[12], ps[13], ps[14], ps[15], ps[16], ps[17], ps[18], ps[19] }
            });

            //also adding values updates and animates the chart automatically
            SeriesCollection2[1].Values.Add(48d);
            Labels1 = new[] { "00" , "01", "02", "03","04" , "05", "06", "07", "08" , "09"
               };
        }
        #endregion
        public void Handle(string message)
        {
            OneMessage = message;
        }
        #region Login_level  
        string oneMessage;
        public string OneMessage
        {
            get
            {
                return oneMessage;
            }
            set
            {
                oneMessage = value;
                switch (OneMessage)
                {
                    case "Level0":
                        _Enable = true;
                        break;
                    case "Level1":
                        _Enable1 = true;
                        break;
                    case "Level2":
                        _Enable2 = true;
                        break;
                    case "Cancellation":
                        _Enable = false;
                        _Enable1 = false;
                        _Enable2 = false;
                        break;

                }

                NotifyOfPropertyChange(() => OneMessage);
            }
        }
        private bool enable;
        public bool _Enable
        {
            get
            {
                return enable;
            }
            set
            {
                enable = value;
                NotifyOfPropertyChange(() => _Enable);
            }
        }
        private bool enable1;
        public bool _Enable1
        {
            get
            {
                return enable1;
            }
            set
            {
                enable1 = value;
                NotifyOfPropertyChange(() => _Enable1);
            }
        }
        private bool enable2;
        public bool _Enable2
        {
            get
            {
                return enable2;
            }
            set
            {
                enable2 = value;
                NotifyOfPropertyChange(() => _Enable2);
            }
        }
        #endregion
        
        #region 命令执行区
        double[] doublepar = new double[48];
        private Command_film.MyCommand _Triger_buton;
        public Command_film.MyCommand Triger_buton
        {
            get
            {
                if (_Triger_buton == null)
                    _Triger_buton = new Command_film.MyCommand(
                        new Action<object>(
                              e =>
                              {

                                  SeriesCollection = new SeriesCollection {
                   new ColumnSeries
                   {
                       Title = "OK",
                       Values = new ChartValues<double> { 10, 50, 39, 50,  0, 50, 39, 50, 11, 56, 42,  0, 50, 39, 50, 50, 39, 0, 10, 50, 39, 50, 11, 56 }
                   }
               };

                                  //adding series will update and animate the chart automatically
                                  SeriesCollection.Add(new ColumnSeries
                                  {
                                      Title = "NG",
                                      Values = new ChartValues<double> { 11, 56, 2, 10, 50, 39, 50, 11, 6, 42, 10, 50, 39, 50, 56, 2, 10, 0, 39, 50, 11, 6, 42, 10 }
                                  });

                                  //also adding values updates and animates the chart automatically
                                  SeriesCollection[1].Values.Add(48d);

                                  Labels = new[] { "00:00:00" , "01:00:00", "02:00:00", "03:00:00","04:00:00" , "05:00:00", "06:00:00", "07:00:00",
                "08:00:00" , "09:00:00", "10:00:00", "11:00:00","12:00:00" , "13:00:00", "14:00:00", "15:00:00",
                "16:00:00" , "17:00:00", "18:00:00", "19:00:00","20:00:00" , "21:00:00", "22:00:00", "23:00:00",
               };
                              }));
                return _Triger_buton;
            }
        }
        private Command_film.MyCommand _command7;
        public Command_film.MyCommand Command7
        {
            get
            {
                if (_command7 == null)
                    _command7 = new Command_film.MyCommand(
                        new Action<object>(
                        async e =>
                        {

                            for (int i = 1; i < 46; i++)
                            {
                                doublepar[i] = new Random().Next(1, 200);
                            }
                            asynt_column(doublepar[0], doublepar[1], doublepar[2], doublepar[3], doublepar[4], doublepar[5], doublepar[6], doublepar[7], doublepar[8], doublepar[9],
                                doublepar[10], doublepar[11], doublepar[12], doublepar[13], doublepar[14], doublepar[15], doublepar[16], doublepar[17], doublepar[18], doublepar[19],
                                doublepar[20], doublepar[21], doublepar[22], doublepar[23], doublepar[24], doublepar[25], doublepar[26], doublepar[27], doublepar[28], doublepar[29],
                                doublepar[30], doublepar[31], doublepar[32], doublepar[33], doublepar[34], doublepar[35], doublepar[36], doublepar[37], doublepar[38], doublepar[39],
                                doublepar[40], doublepar[41], doublepar[42], doublepar[43], doublepar[44], doublepar[45], doublepar[46]);

                        }));
                return _command7;
            }
        }
        private Command_film.MyCommand _RecipeCbxDropDownOpened;
        public Command_film.MyCommand RecipeCbxDropDownOpened
        {
            get
            {
                if (_RecipeCbxDropDownOpened == null)
                    _RecipeCbxDropDownOpened = new Command_film.MyCommand(
                        new Action<object>(
                         e =>
                         {

                             MessageBox.Show("wgag");

                         }));
                return _RecipeCbxDropDownOpened;
            }
        }
        #endregion
    }
}
