using LiveCharts.Wpf;
using System.Windows.Controls;


namespace WpfApp1.Views
{
    /// <summary>
    /// LiveChart.xaml 的交互逻辑
    /// </summary>
    public partial class LiveChartView : UserControl
    {
        #region 注释掉
        ///// <summary>
        ///// 字段属性声明
        ///// </summary>
        ///// 实时曲线字段声明
        //private double _axisMin;
        //private double _axisMax;
        //private double _trend;
        //double d0 = 4.0;
        //double d2 = 3.0;
        //double d1 = 2.0;
        //double d3 = 1.0;
        //double d4 = 4.0;
        //double d5 = 3.0;
        //double d6 = 2.0;
        //double d7 = 1.0;
        #endregion
        public LiveChartView()
        {
            InitializeComponent();
        }
        #region 没用
        //Growl.Success("cg");//成功////To handle live data easily, in this case we built a specialized type////the MeasureModel class, it only contains 2 properties////DateTime and Value////We need to configure LiveCharts to handle MeasureModel class////The next code configures MeasureModel  globally, this means////that LiveCharts learns to plot MeasureModel and will use this config every time////a IChartValues instance uses this type.////this code ideally should only run once////you can configure series in many ways, learn more at ////http://lvcharts.net/App/examples/v1/wpf/Types%20and%20Configuration//var mapper = Mappers.Xy<MeasureModel>()//    .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X//    .Y(model => model.Value);           //use the value property as Y////lets save the mapper globally.//Charting.For<MeasureModel>(mapper);////the values property will store our values array//ChartValues = new ChartValues<MeasureModel>();////lets set how to display the X Labels//DateTimeFormatter = value => new DateTime((long)value).ToString("hh.mm:ss");////AxisStep forces the distance between each separator in the X axis//AxisStep = TimeSpan.FromSeconds(1).Ticks;////AxisUnit forces lets the axis know that we are plotting seconds////this is not always necessary, but it can prevent wrong labeling//AxisUnit = TimeSpan.TicksPerSecond;//SetAxisLimits(DateTime.Now);////The next code simulates data changes every 300 ms//IsReading = false;////  read_file(@"I:\SIMPLE_WPF\WpfHandyControlDemo\WpfHandyControlDemo\WpfHandyControlDemo\xml_repice");//// Value = 100;//SeriesCollection = new SeriesCollection//{//    new ColumnSeries//    {//        Title = "2015",//        Values = new ChartValues<double> { 10, 50, 39, 50 }//    }//};////adding series will update and animate the chart automatically//SeriesCollection.Add(new ColumnSeries//{//    Title = "2016",//    Values = new ChartValues<double> { 11, 56, 42 }//});////also adding values updates and animates the chart automatically//SeriesCollection[1].Values.Add(48d);//Labels = new[] { "Maria", "Susan", "Charles", "Frida" };//Formatter = value => value.ToString("N");//PointLabel = chartPoint =>//   string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);//InjectStopOnClick();//DataContext = this;
        #endregion

        #region 没用
        //#region 实时曲线
        //public ChartValues<MeasureModel> ChartValues { get; set; }
        //public Func<double, string> DateTimeFormatter { get; set; }
        //public double AxisStep { get; set; }
        //public double AxisUnit { get; set; }


        //public double AxisMax
        //{
        //    get { return _axisMax; }
        //    set
        //    {
        //        _axisMax = value;
        //        OnPropertyChanged1("AxisMax");
        //    }
        //}
        //public double AxisMin
        //{
        //    get { return _axisMin; }
        //    set
        //    {
        //        _axisMin = value;
        //        OnPropertyChanged1("AxisMin");
        //    }
        //}

        //public bool IsReading { get; set; }

        //private void Read()
        //{
        //    var r = new Random();

        //    while (IsReading)
        //    {
        //        Thread.Sleep(150);
        //        var now = DateTime.Now;

        //        _trend += r.Next(-8, 10);

        //        ChartValues.Add(new MeasureModel
        //        {
        //            DateTime = now,
        //            Value = _trend

        //    });

        //        SetAxisLimits(now);

        //        //lets only use the last 150 values
        //        if (ChartValues.Count > 50) ChartValues.RemoveAt(0);
        //    }
        //}

        //private  void SetAxisLimits(DateTime now)
        //{
        //    AxisMax = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 1 second ahead
        //    AxisMin = now.Ticks - TimeSpan.FromSeconds(8).Ticks; // and 8 seconds behind

        //}

        //private void InjectStopOnClick()
        //{
        //    IsReading = !IsReading;
        //    if (IsReading) Task.Factory.StartNew(Read);

        //}
        //#endregion

        //#region INotifyPropertyChanged implementation


        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged1(string propertyName = null)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}




        //#endregion

        //#region 图形字段声明
        //public SeriesCollection SeriesCollection { get; set; }
        //public string[] Labels { get; set; }
        //public Func<ChartPoint, string> PointLabel { get; set; }
        //public Func<double, string> Formatter { get; set; }
        //#endregion
        //#region 饼图刷新
        //private async Task Async(double d00, Double d01, double d02, double d03)
        //{
        //    PointLabel = chartPoint =>
        //     string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
        //    Pie_chart0.Series = new SeriesCollection
        //    {
        //        new PieSeries
        //        {
        //            Title = "Maria",
        //            Values = new ChartValues<double> {d00},
        //            DataLabels = true,
        //            LabelPoint = PointLabel
        //        },
        //        new PieSeries
        //        {
        //            Title = "Charles",
        //            Values = new ChartValues<double> {d01},
        //            DataLabels = true,
        //            LabelPoint = PointLabel
        //        },
        //        new PieSeries
        //        {
        //            Title = "Frida",
        //            Values = new ChartValues<double> {d02},
        //            DataLabels = true,
        //            LabelPoint = PointLabel
        //        },
        //        new PieSeries
        //        {
        //            Title = "Frederic",
        //            Values = new ChartValues<double> {d03},
        //            DataLabels = true,
        //            LabelPoint = PointLabel
        //        }

        //    };

        //}
        //#endregion
        //#region 柱形图刷新
        //private async Task asynt_column(params double[] ps)
        //{
        //    SeriesCollection = new SeriesCollection
        //    {
        //        new ColumnSeries
        //        {
        //            Title = "2015",
        //            FontSize=10,
        //            Values = new ChartValues<double> { ps[0], ps[1], ps[2], ps[3] }
        //        }
        //    };

        //    //adding series will update and animate the chart automatically
        //    SeriesCollection.Add(new ColumnSeries
        //    {
        //        Title = "2016",
        //        FontSize = 10,
        //        Values = new ChartValues<double> { ps[4], ps[5], ps[6], ps[7] }
        //    });

        //    //also adding values updates and animates the chart automatically
        //    SeriesCollection[1].Values.Add(48d);
        //    if (Tem_collection != null)
        //    {
        //        Tem_collection.Series.Clear();
        //        Tem_collection.Series = SeriesCollection;
        //    }

        //}
        //#endregion
        //#region 指针图刷新
        //private double _value;
        //public double Value
        //{
        //    get { return _value; }
        //    set
        //    {
        //        _value = value;
        //        OnPropertyChanged1("Value");
        //        System.Windows.MessageBox.Show("1");
        //    }
        //}
        //private async Task TaskAsync0()
        //{

        //    Value = new Random().Next(50, 250);

        //}

        //#endregion

        //#region 数据刷新事件
        //private async void Tem_collection_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{

        //    Growl.Info("失败");//信息
        //    Growl.Success("cg");//成功
        //    Growl.Warning("warn");//警告
        //    Growl.Error("error");//错误
        //    Growl.Ask("ask", isConfirmed =>
        //    {
        //        Growl.Info(isConfirmed.ToString());
        //        return true;
        //    });//询问
        //    Growl.Fatal("bk");//重大故障

        //    Random random = new Random();


        //    App.Current.Dispatcher.Invoke((Action)(async () =>
        //    {

        //        d0 = random.NextDouble() * 10;
        //        d1 = random.NextDouble() * 7;
        //        d2 = random.NextDouble() * 9;
        //        d3 = random.NextDouble() * 14;
        //        d4 = random.NextDouble() * 8;
        //        d5 = random.NextDouble() * 17;
        //        d6 = random.NextDouble() * 19;
        //        d7 = random.NextDouble() * 13;

        //        await Async(d0, d1, d2, d3);

        //        await asynt_column(d4, d5, d6, d7, d0, d1, d2, d3);
        //        await TaskAsync0();

        //    }));
        //    #endregion
        //}

        #endregion

        private void pie_DataClick(object sender, LiveCharts.ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartPoint.SeriesView;
            selectedSeries.PushOut = 8;
        }
    }

    
}
