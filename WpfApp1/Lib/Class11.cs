using Enterwell.Clients.Wpf.Notifications;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Messages;
using ToastNotifications.Position;
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1.Lib
{
    class Class11 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region List收集
        private ObservableCollection<Xml_helper> alarmItems = new ObservableCollection<Xml_helper>();
        public ObservableCollection<Xml_helper> AlarmItems
        {
            get
            { return alarmItems; }
            set
            {
                alarmItems = value;
                OnPropertyChanged("AlarmItems");
            }
        }

        #endregion

        private void AddAlarmItem(Xml_helper t)
        {
            foreach (Xml_helper item in AlarmItems)
            {
                if (item.ID == t.ID) return;
            }
            AlarmItems.Add(t);
        }
        
        int i = 0;
        private Command_film.MyCommand _Add;
        public Command_film.MyCommand _add
        {
            get
            {
                if (_Add == null)
                    _Add = new Command_film.MyCommand(
                        new Action<object>(
                            e =>
                            {
                                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                                dlg.FileName = ""; // Default file name
                                dlg.DefaultExt = ".xml";  // Default file extension
                                dlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* "; // Filter files by extension
                                                                                       // Show open file dialog box
                                Nullable<bool> result = dlg.ShowDialog();
                                // Process open file dialog box results
                                if (result == true)
                                {
                                 
                                    string filename = dlg.FileName;
                                    XDocument xDocument = new XDocument();
                                    XElement xElement = XElement.Load(filename);
                                    IEnumerable<XElement> xElements = from p in xElement.Elements("X_Asix")
                                                                     
                                                                      select p;
                                    foreach (XElement p in xElements)
                                    {
                                        //AlarmItems.Insert(0, new Xml_helper(
                                        // Convert.ToInt32( p.Element("ID").Value),
                                        //    p.Element("POsition0").Value.ToString(),
                                        //    p.Element("POsition1").Value.ToString(),
                                        //    p.Element("POsition2").Value.ToString())) ;
                                      
                                    }

                                }


                            }));
                return _Add;
            }
        }
        #region richbox
    //      <RichTextBox
    //MinWidth = "280"
    //AcceptsReturn="True"
    //IsDocumentEnabled="True"
    //IsReadOnly="{Binding IsChecked, ElementName=RichTextBoxIsReadOnlyCheckBox}"
    //VerticalScrollBarVisibility="Auto"
    //SpellCheck.IsEnabled="True"
    //materialDesign:HintAssist.Hint="Multiline text"
    //Margin="0,0,0,0"
    //  MaxHeight="300"
    // Grid.Row="1" Grid.Column="0" >
    //            <FlowDocument>
    //                <Paragraph>
    //                    <Run
    //      FontWeight = "Bold" >
    //                        Rich Text Box.
    //                    </Run>
    //                    <LineBreak />
    //                    <Run
    //      FontStyle = "Normal" Text= "{Binding Document}" >

    //                    </ Run >
    //                    < LineBreak />

    //                </ Paragraph >
    //            </ FlowDocument >
    //            < i:Interaction.Triggers> 
    //                <i:EventTrigger EventName = "MouseDown" >
    //                    < i:InvokeCommandAction Command = "{Binding SizeChanged}"
    //                                           CommandParameter= "{Binding RelativeSource={RelativeSource Self}}" />
    //                </ i:EventTrigger> 
    //            </i:Interaction.Triggers>
    //        </RichTextBox>
        #endregion
        #region "异步委托"
        static Stopwatch stopwatch;
        public delegate void read_book();
        private void delagate_click()
        {
            read_book read_Book = new read_book(read_book1);
            //stopwatch = new Stopwatch();
            while (true)
            {
                Task task = Task.Run(() =>
                {
                    IAsyncResult result = read_Book.BeginInvoke(Callback, null);
                    stopwatch.Start();
                    Thread.Sleep(200);
                });
            }

        }
        #region"回调函数"
        private void Callback(IAsyncResult ar)
        {
            AsyncResult AR = ar as AsyncResult;
            ((read_book)AR.AsyncDelegate).EndInvoke(ar);

            System.Windows.MessageBox.Show("异步调用完成");
        }
        #endregion
        private void read_book1()
        {
            int read_length;
            Byte[] byt0;
            using (FileStream file0 = new FileStream("1.txt", FileMode.OpenOrCreate))
            {
                read_length = Convert.ToInt32(file0.Length);
                byt0 = new Byte[file0.Length];
                int i = file0.Read(byt0, 0, read_length);
                string str = Encoding.UTF8.GetString(byt0);
                Action action1 = () =>
                {
                    stopwatch.Stop();

                    // result_text.Text = str+"??"+stopwatch.Elapsed.ToString();
                };
                // result_text.Dispatcher.BeginInvoke(action1);

            }
        }
        #region "刷新数据"
        private async void task_flsh()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    int read_length;
                    Byte[] byt0;
                    using (FileStream file0 = new FileStream("1.txt", FileMode.OpenOrCreate))
                    {
                        read_length = Convert.ToInt32(file0.Length);
                        byt0 = new Byte[file0.Length];
                        int i = file0.Read(byt0, 0, read_length);
                        int i1 = 0;
                        i1++;
                        string str = Encoding.UTF8.GetString(byt0);
                        Action action1 = () =>
                        {

                            DateTime.Now.ToString();

                            //rich_txt.AppendText ( str + "??"+i1.ToString()) ;
                        };
                        //rich_txt.Dispatcher.BeginInvoke(action1);

                    }
                    Thread.Sleep(100);
                }
            });
        }
        #endregion

        #endregion
        #region "土司消息"
        #region"土司消息1"
        public INotificationMessageManager Manager { get; } = new NotificationMessageManager();
        private void ERROR_MouseDown()
        {
            //this.Manager
            //     .CreateMessage()
            //     .Accent("#1751C3")
            //     .Background("#333")
            //     .HasBadge("Info")
            //     .Animates(true)//动画开启
            //     .AnimationInDuration(0.75)

            //     .AnimationOutDuration(2)
            //     .HasMessage("Update will be installed on next application restart.")
            //     .Dismiss().WithButton("Update now", button => { MessageBox.Show("11"); })
            //     .Dismiss().WithButton("Release notes", button => { MessageBox.Show("21"); })
            //     .Dismiss().WithButton("Later", button => { MessageBox.Show("31"); })
            //     .Dismiss().WithDelay(TimeSpan.FromSeconds(5))
            //     .Queue();
            try
            {


            }
            catch (Exception EX)
            {

            }
        }
        #endregion
        private void Button_MouseDown()
        {

            notifier.ShowInformation("Information");
            notifier.ShowSuccess("Success");
            notifier.ShowWarning("Warning");
            notifier.ShowError("Error");
        }
        #endregion
        #region"土司消息1"
        Notifier notifier = new Notifier(cfg =>
        {
            //cfg.PositionProvider = new WindowPositionProvider(
            //   parentWindow: Application.Current.MainWindow,
            //    corner: Corner.BottomCenter,
            //    offsetX: 10,
            //    offsetY: 10);

            //cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
            //    notificationLifetime: TimeSpan.FromSeconds(3),
            //    maximumNotificationCount: MaximumNotificationCount.FromCount(5));

           // cfg.Dispatcher = Application.Current.Dispatcher;
        });
        #endregion
        #region
        //#region 0
        //plcitems.Erroor_Code0 = await PLC_ReadReal("D20080") ;
        //plcitems.Act_acc0 = await PLC_ReadReal("D20004") ;
        //plcitems.Act_dec0 = await PLC_ReadReal("D20004");
        //plcitems.Act_autoSpeed0 = await PLC_ReadReal("D20060");
        //plcitems.Act_manauSpeed0 = await PLC_ReadReal("D20062");
        //plcitems.Act_pos0 = await PLC_ReadReal("D20040");
        //plcitems.Act_pos1_0 = await PLC_ReadReal("D20042");
        //plcitems.Act_pos2_0 = await PLC_ReadReal("D20044");
        //#endregion
        //#region 1
        //plcitems.Erroor_Code1 = await PLC_ReadReal("D20180");
        //plcitems.Act_acc1 = await PLC_ReadReal("D20004");
        //plcitems.Act_dec1 = await PLC_ReadReal("D20004");
        //plcitems.Act_autoSpeed1 = await PLC_ReadReal("D20160");
        //plcitems.Act_manauSpeed1 = await PLC_ReadReal("D20162");
        //plcitems.Act_pos1 = await PLC_ReadReal("D20140");
        //plcitems.Act_pos1_1 = await PLC_ReadReal("D20142");
        //plcitems.Act_pos2_1 = await PLC_ReadReal("D20144");
        //#endregion
        //#region 2
        //plcitems.Erroor_Code2 = await PLC_ReadReal("D20280");
        //plcitems.Act_acc2 = await PLC_ReadReal("D20004");
        //plcitems.Act_dec2 = await PLC_ReadReal("D20004");
        //plcitems.Act_autoSpeed2 = await PLC_ReadReal("D20260");
        //plcitems.Act_manauSpeed2 = await PLC_ReadReal("D20262");
        //plcitems.Act_pos2 = await PLC_ReadReal("D20240");
        //plcitems.Act_pos1_2 = await PLC_ReadReal("D20242");
        //plcitems.Act_pos2_2 = await PLC_ReadReal("D20244");
        //#endregion
        //#region 3
        //plcitems.Erroor_Code3 = await PLC_ReadReal("D20380");
        //plcitems.Act_acc3 = await PLC_ReadReal("D20004");
        //plcitems.Act_dec3 = await PLC_ReadReal("D20004");
        //plcitems.Act_autoSpeed3 = await PLC_ReadReal("D20360");
        //plcitems.Act_manauSpeed3 = await PLC_ReadReal("D20362");
        //plcitems.Act_pos3 = await PLC_ReadReal("D20340");
        //plcitems.Act_pos1_3 = await PLC_ReadReal("D20342");
        //plcitems.Act_pos2_3 = await PLC_ReadReal("D20344");
        //#endregion
        //#region 4
        //plcitems.Erroor_Code4 = await PLC_ReadReal("D20480");
        //plcitems.Act_acc4 = await PLC_ReadReal("D20004");
        //plcitems.Act_dec4 = await PLC_ReadReal("D20004");
        //plcitems.Act_autoSpeed4 = await PLC_ReadReal("D20460");
        //plcitems.Act_manauSpeed4 = await PLC_ReadReal("D20462");
        //plcitems.Act_pos4 = await PLC_ReadReal("D20440");
        //plcitems.Act_pos1_4 = await PLC_ReadReal("D20442");
        //plcitems.Act_pos2_4 = await PLC_ReadReal("D20444");
        //#endregion
        //#region 5
        //plcitems.Erroor_Code5 = await PLC_ReadReal("D20580");
        //plcitems.Act_acc5 = await PLC_ReadReal("D20504");
        //plcitems.Act_dec5 = await PLC_ReadReal("D20504");
        //plcitems.Act_autoSpeed5 = await PLC_ReadReal("D20560");
        //plcitems.Act_manauSpeed5 = await PLC_ReadReal("D20562");
        //plcitems.Act_pos5 = await PLC_ReadReal("D20540");
        //plcitems.Act_pos1_5 = await PLC_ReadReal("D20542");
        //plcitems.Act_pos2_5 = await PLC_ReadReal("D20544");
        //#endregion
        //#region 6
        //plcitems.Erroor_Code6 = await PLC_ReadReal("D20680");
        //plcitems.Act_acc6 = await PLC_ReadReal("D20604");
        //plcitems.Act_dec6 = await PLC_ReadReal("D20604");
        //plcitems.Act_autoSpeed6 = await PLC_ReadReal("D20660");
        //plcitems.Act_manauSpeed6 = await PLC_ReadReal("D20662");
        //plcitems.Act_pos6 = await PLC_ReadReal("D20640");
        //plcitems.Act_pos1_6 = await PLC_ReadReal("D20642");
        //plcitems.Act_pos2_6 = await PLC_ReadReal("D20644");
        //#endregion
        //#region 7
        //plcitems.Erroor_Code7 = await PLC_ReadReal("D20780");
        //plcitems.Act_acc7 = await PLC_ReadReal("D20704");
        //plcitems.Act_dec7 = await PLC_ReadReal("D20704");
        //plcitems.Act_autoSpeed7 = await PLC_ReadReal("D20760");
        //plcitems.Act_manauSpeed7 = await PLC_ReadReal("D20762");
        //plcitems.Act_pos7 = await PLC_ReadReal("D20740");
        //plcitems.Act_pos1_7 = await PLC_ReadReal("D20742");
        //plcitems.Act_pos2_7 = await PLC_ReadReal("D20744");
        //#endregion
        //#region 8
        //plcitems.Erroor_Code8 = await PLC_ReadReal("D20880");
        //plcitems.Act_acc8 = await PLC_ReadReal("D20804");
        //plcitems.Act_dec8 = await PLC_ReadReal("D20804");
        //plcitems.Act_autoSpeed8 = await PLC_ReadReal("D20860");
        //plcitems.Act_manauSpeed8 = await PLC_ReadReal("D20862");
        //plcitems.Act_pos8 = await PLC_ReadReal("D20840");
        //plcitems.Act_pos1_8 = await PLC_ReadReal("D20842");
        //plcitems.Act_pos2_8 = await PLC_ReadReal("D20844");
        //#endregion
        //#region 9
        //plcitems.Erroor_Code9 = await PLC_ReadReal("D20980");
        //plcitems.Act_acc9 = await PLC_ReadReal("D20904");
        //plcitems.Act_dec9 = await PLC_ReadReal("D20904");
        //plcitems.Act_autoSpeed9 = await PLC_ReadReal("D20960");
        //plcitems.Act_manauSpeed9 = await PLC_ReadReal("D20962");
        //plcitems.Act_pos9 = await PLC_ReadReal("D20940");
        //plcitems.Act_pos1_9 = await PLC_ReadReal("D20942");
        //plcitems.Act_pos2_9 = await PLC_ReadReal("D20944");
        //#endregion
        //#region 10
        //plcitems.Erroor_Code10 = await PLC_ReadReal("D21080");
        //plcitems.Act_acc10 = await PLC_ReadReal("D21004");
        //plcitems.Act_dec10 = await PLC_ReadReal("D21004");
        //plcitems.Act_autoSpeed10 = await PLC_ReadReal("D21060");
        //plcitems.Act_manauSpeed10 = await PLC_ReadReal("D21062");
        //plcitems.Act_pos10 = await PLC_ReadReal("D21040");
        //plcitems.Act_pos1_10 = await PLC_ReadReal("D21042");
        //plcitems.Act_pos2_10 = await PLC_ReadReal("D21044");
        //#endregion
        //#region 11
        //plcitems.Erroor_Code11 = await PLC_ReadReal("D21180");
        //plcitems.Act_acc11 = await PLC_ReadReal("D21104");
        //plcitems.Act_dec11 = await PLC_ReadReal("D21104");
        //plcitems.Act_autoSpeed11 = await PLC_ReadReal("D21160");
        //plcitems.Act_manauSpeed11 = await PLC_ReadReal("D21162");
        //plcitems.Act_pos11 = await PLC_ReadReal("D21140");
        //plcitems.Act_pos1_11 = await PLC_ReadReal("D21142");
        //plcitems.Act_pos2_11 = await PLC_ReadReal("D21144");
        //#endregion
        //#region 12
        //plcitems.Erroor_Code12 = await PLC_ReadReal("D21280");
        //plcitems.Act_acc12 = await PLC_ReadReal("D21204");
        //plcitems.Act_dec12 = await PLC_ReadReal("D21204");
        //plcitems.Act_autoSpeed12 = await PLC_ReadReal("D21260");
        //plcitems.Act_manauSpeed12 = await PLC_ReadReal("D21262");
        //plcitems.Act_pos12 = await PLC_ReadReal("D21240");
        //plcitems.Act_pos1_12 = await PLC_ReadReal("D21242");
        //plcitems.Act_pos2_12 = await PLC_ReadReal("D21244");
        //#endregion
        //#region 13
        //plcitems.Erroor_Code13 = await PLC_ReadReal("D21380");
        //plcitems.Act_acc13 = await PLC_ReadReal("D21304");
        //plcitems.Act_dec13 = await PLC_ReadReal("D21304");
        //plcitems.Act_autoSpeed13 = await PLC_ReadReal("D21360");
        //plcitems.Act_manauSpeed13 = await PLC_ReadReal("D21362");
        //plcitems.Act_pos13 = await PLC_ReadReal("D21340");
        //plcitems.Act_pos1_13 = await PLC_ReadReal("D21342");
        //plcitems.Act_pos2_13 = await PLC_ReadReal("D21344");
        //#endregion
        //#region 14
        //plcitems.Erroor_Code14 = await PLC_ReadReal("D21480");
        //plcitems.Act_acc14 = await PLC_ReadReal("D21404");
        //plcitems.Act_dec14 = await PLC_ReadReal("D21404");
        //plcitems.Act_autoSpeed14 = await PLC_ReadReal("D21360");
        //plcitems.Act_manauSpeed14 = await PLC_ReadReal("D21362");
        //plcitems.Act_pos14 = await PLC_ReadReal("D21440");
        //plcitems.Act_pos1_14 = await PLC_ReadReal("D21442");
        //plcitems.Act_pos2_14 = await PLC_ReadReal("D21444");
        //#endregion
        //#region 15
        //plcitems.Erroor_Code15 = await PLC_ReadReal("D21580");
        //plcitems.Act_acc15 = await PLC_ReadReal("D21404");
        //plcitems.Act_dec15 = await PLC_ReadReal("D21404");
        //plcitems.Act_autoSpeed15 = await PLC_ReadReal("D21460");
        //plcitems.Act_manauSpeed15 = await PLC_ReadReal("D21462");
        //plcitems.Act_pos15 = await PLC_ReadReal("D21540");
        //plcitems.Act_pos1_15 = await PLC_ReadReal("D21542");
        //plcitems.Act_pos2_15 = await PLC_ReadReal("D21544");
        //#endregion
        //#region 16
        //plcitems.Erroor_Code16 = await PLC_ReadReal("D21680");
        //plcitems.Act_acc16 = await PLC_ReadReal("D21504");
        //plcitems.Act_dec16 = await PLC_ReadReal("D21504");
        //plcitems.Act_autoSpeed16 = await PLC_ReadReal("D21560");
        //plcitems.Act_manauSpeed16 = await PLC_ReadReal("D21562");
        //plcitems.Act_pos16 = await PLC_ReadReal("D21640");
        //plcitems.Act_pos1_16 = await PLC_ReadReal("D21642");
        //plcitems.Act_pos2_16 = await PLC_ReadReal("D21644");
        //#endregion
        //#endregion
        //     #region
        //     #region 0
        //     await PLC_ReadReal("D20080");
        //    await PLC_ReadReal("D20004");
        //       await PLC_ReadReal("D20004");
        //  await PLC_ReadReal("D20060");
        //      await PLC_ReadReal("D20062");
        //      await PLC_ReadReal("D20040");
        //     await PLC_ReadReal("D20042");
        //     await PLC_ReadReal("D20044");
        //     #endregion
        //     #region 1
        //      await PLC_ReadReal("D20180");
        //       await PLC_ReadReal("D20004");
        //       await PLC_ReadReal("D20004");
        //       await PLC_ReadReal("D20160");
        //       await PLC_ReadReal("D20162");
        //     await PLC_ReadReal("D20140");
        //       await PLC_ReadReal("D20142");
        //       await PLC_ReadReal("D20144");
        //     #endregion
        //     #region 2
        //      await PLC_ReadReal("D20280");
        //      await PLC_ReadReal("D20004");
        //      await PLC_ReadReal("D20004");
        //       await PLC_ReadReal("D20260");
        //       await PLC_ReadReal("D20262");
        //      await PLC_ReadReal("D20240");
        //       await PLC_ReadReal("D20242");
        //      await PLC_ReadReal("D20244");
        //     #endregion
        //     #region 3
        //      await PLC_ReadReal("D20380");
        //      await PLC_ReadReal("D20004");
        //     await PLC_ReadReal("D20004");
        //       await PLC_ReadReal("D20360");
        //       await PLC_ReadReal("D20362");
        //       await PLC_ReadReal("D20340");
        //     await PLC_ReadReal("D20342");
        //    await PLC_ReadReal("D20344");
        //     #endregion
        //     #region 4
        //       await PLC_ReadReal("D20480");
        //       await PLC_ReadReal("D20004");
        //       await PLC_ReadReal("D20004");
        //    await PLC_ReadReal("D20460");
        //       await PLC_ReadReal("D20462");
        //       await PLC_ReadReal("D20440");
        //      await PLC_ReadReal("D20442");
        //       await PLC_ReadReal("D20444");
        //     #endregion
        //     #region 5
        //       await PLC_ReadReal("D20580");
        //      await PLC_ReadReal("D20504");
        //    await PLC_ReadReal("D20504");
        //      await PLC_ReadReal("D20560");
        //      await PLC_ReadReal("D20562");
        //     await PLC_ReadReal("D20540");
        //       await PLC_ReadReal("D20542");
        //       await PLC_ReadReal("D20544");
        //     #endregion
        //     #region 6
        //       await PLC_ReadReal("D20680");
        //    await PLC_ReadReal("D20604");
        //      await PLC_ReadReal("D20604");
        //     await PLC_ReadReal("D20660");
        //      await PLC_ReadReal("D20662");
        //       await PLC_ReadReal("D20640");
        //      await PLC_ReadReal("D20642");
        //     await PLC_ReadReal("D20644");
        //     #endregion
        //     #region 7
        //     await PLC_ReadReal("D20780");
        //      await PLC_ReadReal("D20704");
        //       await PLC_ReadReal("D20704");
        //       await PLC_ReadReal("D20760");
        //       await PLC_ReadReal("D20762");
        //      await PLC_ReadReal("D20740");
        //       await PLC_ReadReal("D20742");
        //       await PLC_ReadReal("D20744");
        //     #endregion
        //     #region 8
        //      await PLC_ReadReal("D20880");
        //     await PLC_ReadReal("D20804");
        //     await PLC_ReadReal("D20804");
        //     await PLC_ReadReal("D20860");
        //    await PLC_ReadReal("D20862");
        //    await PLC_ReadReal("D20840");
        //     await PLC_ReadReal("D20842");
        //       await PLC_ReadReal("D20844");
        //     #endregion
        //     #region 9
        //    await PLC_ReadReal("D20980");
        //  await PLC_ReadReal("D20904");
        //     await PLC_ReadReal("D20904");
        //       await PLC_ReadReal("D20960");
        //      await PLC_ReadReal("D20962");
        //      await PLC_ReadReal("D20940");
        //     await PLC_ReadReal("D20942");
        //      await PLC_ReadReal("D20944");
        //     #endregion
        //     #region 10
        //       await PLC_ReadReal("D21080");
        //     await PLC_ReadReal("D21004");
        //     await PLC_ReadReal("D21004");
        //      await PLC_ReadReal("D21060");
        //       await PLC_ReadReal("D21062");
        //      await PLC_ReadReal("D21040");
        //    await PLC_ReadReal("D21042");
        //       await PLC_ReadReal("D21044");
        //     #endregion
        //     #region 11
        //       await PLC_ReadReal("D21180");
        //   await PLC_ReadReal("D21104");
        //      await PLC_ReadReal("D21104");
        //     await PLC_ReadReal("D21160");
        //      await PLC_ReadReal("D21162");
        //      await PLC_ReadReal("D21140");
        //      await PLC_ReadReal("D21142");
        //     await PLC_ReadReal("D21144");
        //     #endregion
        //     #region 12
        //      await PLC_ReadReal("D21280");
        //      await PLC_ReadReal("D21204");
        //     await PLC_ReadReal("D21204");
        //      await PLC_ReadReal("D21260");
        //    await PLC_ReadReal("D21262");
        //      await PLC_ReadReal("D21240");
        //      await PLC_ReadReal("D21242");
        //      await PLC_ReadReal("D21244");
        //     #endregion
        //     #region 13
        //     await PLC_ReadReal("D21380");
        //     await PLC_ReadReal("D21304");
        //   await PLC_ReadReal("D21304");
        //     await PLC_ReadReal("D21360");
        //await PLC_ReadReal("D21362");
        //  await PLC_ReadReal("D21340");
        //    await PLC_ReadReal("D21342");
        //      await PLC_ReadReal("D21344");
        //     #endregion
        //     #region 14
        //      await PLC_ReadReal("D21480");
        //      await PLC_ReadReal("D21404");
        //   await PLC_ReadReal("D21404");
        //     await PLC_ReadReal("D21360");
        //       await PLC_ReadReal("D21362");
        //    await PLC_ReadReal("D21440");
        //     await PLC_ReadReal("D21442");
        //     await PLC_ReadReal("D21444");
        //     #endregion
        //     #region 15
        //    await PLC_ReadReal("D21580");
        //   await PLC_ReadReal("D21404");
        //   await PLC_ReadReal("D21404");
        //await PLC_ReadReal("D21460");
        //      await PLC_ReadReal("D21462");
        //    await PLC_ReadReal("D21540");
        //     await PLC_ReadReal("D21542");
        //      await PLC_ReadReal("D21544");
        //     #endregion
        //     #region 16
        //    await PLC_ReadReal("D21680");
        //     await PLC_ReadReal("D21504");
        //       await PLC_ReadReal("D21504");
        //    await PLC_ReadReal("D21560");
        //     await PLC_ReadReal("D21562");
        //       await PLC_ReadReal("D21640");
        //       await PLC_ReadReal("D21642");
        //      await PLC_ReadReal("D21644");
        //     #endregion
        //     #endregion
        #endregion
        #region xaml
        //   <!--<Border BorderThickness = "1,1,1,1" CornerRadius="0"  BorderBrush="Blue" Grid.Row="0"  Grid.Column="1">
        //    <lvc:AngularGauge Grid.Row="0"  Grid.Column= "1" Value= "{Binding Value}" FromValue= "0" ToValue= "350"
        //                  LabelsStep= "10" TicksStep= "10" Wedge= "360"
        //                  TicksForeground= "White" Foreground= "White"
        //                  FontWeight= "Bold" FontSize= "10"
        //                  SectionsInnerRadius= ".2" Margin= "14,0,10,28" >
        //        < lvc:AngularGauge.Sections>
        //            <lvc:AngularSection FromValue = "0" ToValue= "100" Fill= "Green" />
        //            < lvc:AngularSection FromValue = "100" ToValue= "200" Fill= "Yellow" />
        //            < lvc:AngularSection FromValue = "200" ToValue= "350" Fill= "#FF3939" />
        //        </ lvc:AngularGauge.Sections>

        //    </lvc:AngularGauge>
        //</Border>-->
        //<!--<Border BorderThickness = "1,0,1,1" CornerRadius= "0"  BorderBrush= "Blue"  Grid.Column= "0" >


        //    < lvc:CartesianChart x:Name= "Tem_collection" Series= "{Binding SeriesCollection}" LegendLocation= "Bottom"
        //                    Grid.Row= "1" Grid.Column= "0" Margin= "-1,244,0,5" >

        //        < lvc:CartesianChart.AxisX>
        //            <lvc:Axis Title = "Salesman" LabelsRotation= "13" Labels= "{Binding Labels}" >
        //                < lvc:Axis.Separator >
        //                    <lvc:Separator Step = "1" ></ lvc:Separator>
        //                </lvc:Axis.Separator>
        //            </lvc:Axis>
        //        </lvc:CartesianChart.AxisX>
        //        <lvc:CartesianChart.AxisY>
        //            <lvc:Axis Title = "Sold Apps" LabelFormatter= "{Binding Formatter}" ></ lvc:Axis>
        //        </lvc:CartesianChart.AxisY>
        //        <lvc:CartesianChart.DataTooltip>
        //            <lvc:DefaultTooltip SelectionMode = "SharedXInSeries" />
        //        </ lvc:CartesianChart.DataTooltip>
        //    </lvc:CartesianChart>

        //</Border>-->
        //<!--<Border BorderThickness = "0,0,1,1" CornerRadius= "0"  BorderBrush= "Blue" Grid.Row= "1"  Grid.Column= "1" >
        //    < lvc:CartesianChart Grid.Row= "1" Grid.Column= "1" AnimationsSpeed= "0:0:0.5" Hoverable= "False" DataTooltip= "{x:Null}" Margin= "5,0,0,48" >
        //        < lvc:CartesianChart.Series>
        //            <lvc:LineSeries Values = "{Binding ChartValues}"
        //                        PointGeometry= "{x:Null}"
        //                        LineSmoothness= "1"
        //                        StrokeThickness= "2"
        //                        Stroke= "#F34336"
        //                        Fill= "Transparent"
        //                        LabelPoint= "{Binding PointLabel}" />
        //        </ lvc:CartesianChart.Series>
        //        <lvc:CartesianChart.AxisX>
        //            <lvc:Axis LabelFormatter = "{Binding DateTimeFormatter}"
        //                  MaxValue= "{Binding AxisMax}"
        //                  MinValue= "{Binding AxisMin}"
        //                  Unit= "{Binding AxisUnit}" >
        //                < lvc:Axis.Separator>
        //                    <lvc:Separator Step = "{Binding AxisStep}" />
        //                </ lvc:Axis.Separator>
        //            </lvc:Axis>
        //        </lvc:CartesianChart.AxisX>
        //    </lvc:CartesianChart>
        //</Border>-->
        #endregion
    }
}
