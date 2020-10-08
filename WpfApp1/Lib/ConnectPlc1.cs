using Caliburn.Micro;
using HslCommunication;
using HslCommunication.Profinet.Omron;
using OmronFinsTCP.Net;
using Panuon.UI.Silver;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Lib
{
    class ConnectPlc1 : INotifyPropertyChanged, IHandle<string>
    {
        #region 通知
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region 字段属性
        bool mark00 = false;
        #region get
        private string get_Asix00;
        public string Get_Asix00 { 
            get { return get_Asix00; }
            set { 
                if(value== "5" )
                {
                    plcitems.Get1_Asix00 = "0";  
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue00(EtherNetPLC_State);
                       
                    }));
                    
                }
                get_Asix00 = value;
               
                OnPropertyChanged(" Get_Asix00"); } }
        private string get_Asix01;
        public string Get_Asix01
        {
            get { return get_Asix01; }
            set
            {
                if (value == "5")
                {
               
                    plcitems.Get1_Asix01 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue01(EtherNetPLC_State);

                    }));
                }
                get_Asix01 = value;

                OnPropertyChanged(" Get_Asix01");
            }
        }
        private string get_Asix02;
        public string Get_Asix02
        {
            get { return get_Asix02; }
            set
            {
                if (value == "5")
                {

                    plcitems.Get1_Asix02 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue02(EtherNetPLC_State);

                    }));
                }
                get_Asix01 = value;

                OnPropertyChanged(" Get_Asix02");
            }
        }
        private string get_Asix03;
        public string Get_Asix03
        {
            get { return get_Asix03; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix03 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {

                        GET_AsixValue03(EtherNetPLC_State);
                    }));
                }
                get_Asix03 = value;

                OnPropertyChanged(" Get_Asix03");
            }
        }
        private string get_Asix04;
        public string Get_Asix04
        {
            get { return get_Asix04; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix04 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue04(EtherNetPLC_State);

                    }));
                }
                get_Asix04 = value;

                OnPropertyChanged(" Get_Asix04");
            }
        }
        private string get_Asix05;
        public string Get_Asix05
        {
            get { return get_Asix05; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix05 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue05(EtherNetPLC_State);

                    }));
                }
                get_Asix05 = value;

                OnPropertyChanged(" Get_Asix05");
            }
        }
        private string get_Asix06;
        public string Get_Asix06
        {
            get { return get_Asix06; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix06 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {

                        GET_AsixValue06(EtherNetPLC_State);
                    }));
                }
                get_Asix06 = value;

                OnPropertyChanged(" Get_Asix06");
            }
        }
        private string get_Asix07;
        public string Get_Asix07
        {
            get { return get_Asix07; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix07 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue07(EtherNetPLC_State);


                    }));
                }
                get_Asix07 = value;

                OnPropertyChanged(" Get_Asix07");
            }
        }
        private string get_Asix08;
        public string Get_Asix08
        {
            get { return get_Asix08; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix08 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue08(EtherNetPLC_State);

                    }));
                }
                get_Asix08 = value;

                OnPropertyChanged(" Get_Asix08");
            }
        }
        private string get_Asix09;
        public string Get_Asix09
        {
            get { return get_Asix09; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix09 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue09(EtherNetPLC_State);

                    }));
                }
                get_Asix09 = value;

                OnPropertyChanged(" Get_Asix09");
            }
        }
        private string get_Asix10;
        public string Get_Asix10
        {
            get { return get_Asix10; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix10 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue10(EtherNetPLC_State);

                    }));
                }
                get_Asix10 = value;

                OnPropertyChanged(" Get_Asix10");
            }
        }


        private string get_Asix11;
        public string Get_Asix11
        {
            get { return get_Asix11; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix11 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue11(EtherNetPLC_State);

                    }));
                }
                get_Asix12 = value;

                OnPropertyChanged(" Get_Asix11");
            }
        }

        private string get_Asix12;
        public string Get_Asix12
        {
            get { return get_Asix12; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix12 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue12(EtherNetPLC_State);

                    }));
                }
                get_Asix12 = value;

                OnPropertyChanged(" Get_Asix12");
            }
        }
        private string get_Asix13;
        public string Get_Asix13
        {
            get { return get_Asix13; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix13 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue13(EtherNetPLC_State);

                    }));
                }
                get_Asix13 = value;

                OnPropertyChanged(" Get_Asix13");
            }
        }
        private string get_Asix14;
        public string Get_Asix14
        {
            get { return get_Asix14; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix14 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue14(EtherNetPLC_State);

                    }));
                }
                get_Asix14 = value;

                OnPropertyChanged(" Get_Asix14");
            }
        }
        private string get_Asix15;
        public string Get_Asix15
        {
            get { return get_Asix15; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix15 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue15(EtherNetPLC_State);

                    }));
                }
                get_Asix15 = value;

                OnPropertyChanged(" Get_Asix15");
            }
        }
        private string get_Asix16;
        public string Get_Asix16
        {
            get { return get_Asix16; }
            set
            {
                if (value == "5")
                {
                    plcitems.Get1_Asix16 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        GET_AsixValue16(EtherNetPLC_State);

                    }));
                }
                get_Asix16 = value;

                OnPropertyChanged(" Get_Asix16");
            }
        }
        #endregion
        #region set
        private string set_Asix00;
        public string Set_Asix00
        {
            get { return set_Asix00; }
            set
            {
                if (value == "5")
                {
                    plcitems.Set1_Asix00 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue00(EtherNetPLC_State);  
                        
                    }));

                   
                }
                set_Asix00 = value;

                OnPropertyChanged(" Set_Asix00");
            }
        }
        private string set_Asix01;
        public string Set_Asix01
        {
            get { return set_Asix01; }
            set
            {
                if (value == "5")
                {
                    plcitems.Set1_Asix01 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue01(EtherNetPLC_State);

                    }));
                }
                set_Asix01 = value;

                OnPropertyChanged(" Set_Asix01");
            }
        }
        private string set_Asix02;
        public string Set_Asix02
        {
            get { return set_Asix02; }
            set
            {
                if (value == "5")
                {
                    plcitems.Set1_Asix02 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue02(EtherNetPLC_State);
                    })); ;
                }
                set_Asix02 = value;

                OnPropertyChanged(" Set_Asix02");
            }
        }
        private string set_Asix03;
        public string Set_Asix03
        {
            get { return set_Asix03; }
            set
            {
                if (value == "5")
                {
                    plcitems.Set1_Asix03 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue03(EtherNetPLC_State);

                    }));
                }
                set_Asix03 = value;

                OnPropertyChanged(" Set_Asix03");
            }
        }
        private string set_Asix04;
        public string Set_Asix04
        {
            get { return set_Asix04; }
            set
            {
                if (value == "5")
                {
                    plcitems.Set1_Asix04 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue04(EtherNetPLC_State);
                    }));
                }
                set_Asix04 = value;

                OnPropertyChanged(" Set_Asix04");
            }
        }
        private string set_Asix05;
        public string Set_Asix05
        {
            get { return set_Asix05; }
            set
            {
                if (value == "5")
                {
                    plcitems.Set1_Asix05 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue05(EtherNetPLC_State);

                    }));
                }
                set_Asix05 = value;

                OnPropertyChanged(" Set_Asix05");
            }
        }
        private string set_Asix06;
        public string Set_Asix06
        {
            get { return set_Asix06; }
            set
            {
                if (value == "5")
                {
                    plcitems.Set1_Asix06 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {

                        SET_AsixValue06(EtherNetPLC_State);
                    })); ;
                }
                set_Asix06 = value;

                OnPropertyChanged(" Set_Asix06");
            }
        }
        private string set_Asix07;
        public string Set_Asix07
        {
            get { return set_Asix07; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix07 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue07(EtherNetPLC_State);
                    })); ;
                }
                set_Asix07 = value;

                OnPropertyChanged(" Set_Asix07");
            }
        }
        private string set_Asix08;
        public string Set_Asix08
        {
            get { return set_Asix08; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix08 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue08(EtherNetPLC_State);
                    }));
                }
                set_Asix08 = value;

                OnPropertyChanged(" Set_Asix08");
            }
        }
        private string set_Asix09;
        public string Set_Asix09
        {
            get { return set_Asix09; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix09 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue09(EtherNetPLC_State);
                    }));
                }
                set_Asix09= value;

                OnPropertyChanged(" Set_Asix09");
            }
        }
        private string set_Asix10;
        public string Set_Asix10
        {
            get { return set_Asix10; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix10 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue10(EtherNetPLC_State);
                    }));
                }
                set_Asix10 = value;

                OnPropertyChanged(" Set_Asix10");
            }
        }


        private string set_Asix11;
        public string Set_Asix11
        {
            get { return set_Asix11; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix11 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue11(EtherNetPLC_State);
                    }));
                }
                set_Asix11 = value;

                OnPropertyChanged(" Set_Asix11");
            }
        }

        private string set_Asix12;
        public string Set_Asix12
        {
            get { return set_Asix12; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix12 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue12(EtherNetPLC_State);
                    })); ;
                }
                set_Asix12 = value;

                OnPropertyChanged(" Set_Asix12");
            }
        }
        private string set_Asix13;
        public string Set_Asix13
        {
            get { return set_Asix13; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix13 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue13(EtherNetPLC_State);
                    }));
                }
                set_Asix13 = value;

                OnPropertyChanged(" Set_Asix13");
            }
        }
        private string set_Asix14;
        public string Set_Asix14
        {
            get { return set_Asix14; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix14 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue14(EtherNetPLC_State);
                    }));
                }
                set_Asix14 = value;

                OnPropertyChanged(" Set_Asix14");
            }
        }
        private string set_Asix15;
        public string Set_Asix15
        {
            get { return set_Asix15; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix15 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue15(EtherNetPLC_State);
                    }));
                }
                set_Asix15 = value;

                OnPropertyChanged(" Set_Asix15");
            }
        }
        private string set_Asix16;
        public string Set_Asix16
        {
            get { return set_Asix16; }
            set
            {
                if (value == "5")
                {
                        plcitems.Set1_Asix16 = "0";
                    Application.Current.Dispatcher.Invoke((System.Action)(() =>
                    {
                        SET_AsixValue16(EtherNetPLC_State);
                    }));
                }
                set_Asix16 = value;

                OnPropertyChanged(" Set_Asix16");
            }
        }
        #endregion
        #endregion
        //private readonly IEventAggregator _eventAggregator;
      
        #region 固定内存
        public static Lib.Plcitems plcitems = new Plcitems();
        #endregion
        #region "PLC连接"
        /// <summary>
        /// 字段连接PLC
        /// </summary>
        EtherNetPLC EtherNetPLC;
        bool EtherNetPLC_State;
        private OmronFinsNet omronFinsNet;
       
        public void Plc_EtherNetPLC(string IPaddres0)
        {

            String IPaddress = IPaddres0;
            EtherNetPLC = new EtherNetPLC();
            string IPPort = "9600";

            try
            {
                omronFinsNet = new OmronFinsNet(IPaddress, short.Parse(IPPort));
                omronFinsNet.SA1 = 0xEF; // PC网络号，PC的IP地址的最后一个数
                omronFinsNet.DA1 = 0x64; // PLC网络号，PLC的IP地址的最后一个数
                omronFinsNet.DA2 = 0x00; // PLC单元号，通常为0
                OperateResult operateResult = omronFinsNet.ConnectServer();
              
                if (operateResult.IsSuccess)//&& operateResult.IsSuccess
                {
                   
                        Notice.Show("Success",
                                              "Plc 连接成功",
                                              1,
                                              MessageBoxIcon.Success);

                   
                    EtherNetPLC_State = true;
                }
                else
                {

                    EtherNetPLC_State = false;
                }


            }
            catch (Exception k)
            {
                EtherNetPLC_State = false;
                Notice.Show("Error",
                                       "Plc Not Find" + k.ToString(),
                                       10,
                                       MessageBoxIcon.Success);
            };

        }
        #endregion
        #region PLC函数
        public void PLC_WriteReal(string address, float return_value1)
        {

            OperateResult return_date = omronFinsNet.Write(address, return_value1);
          
        }
        public async Task<float> PLC_ReadReal(string adress)
        {
            OperateResult<float> return_date = await omronFinsNet.ReadFloatAsync(adress);
            return  return_date.Content;
        }
        public async Task<long> PLC_ReadWordD(string adress)
        {
            OperateResult<long> return_date = await omronFinsNet.ReadInt64Async(adress);
            return return_date.Content;
        }
        #endregion
        #region SET_AsixValue
        private void SET_AsixValue00(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(  () =>
                {

                    if (EtherNetPLC_State)
                    {
                        #region real  
                        PLC_WriteReal("D20040", plcitems.Act_pos0);
                        PLC_WriteReal("D20042", plcitems.Act_pos1_0);
                        PLC_WriteReal("D20044", plcitems.Act_pos2_0);
                        PLC_WriteReal("D20064", plcitems.Act_pos00_2);
                        PLC_WriteReal("D20066", plcitems.Act_pos00_3);
                        PLC_WriteReal("D20068", plcitems.Act_pos00_4);
                        PLC_WriteReal("D20070", plcitems.Act_pos00_5);
                        PLC_WriteReal("D20072", plcitems.Act_pos00_6);
                        PLC_WriteReal("D20074", plcitems.Act_pos00_7);
                        PLC_WriteReal("D20076", plcitems.Act_pos00_8);
                        PLC_WriteReal("D20078", plcitems.Act_pos00_9);
                        PLC_WriteReal("D20060", plcitems.Act_autoSpeed0);
                        PLC_WriteReal("D20062", plcitems.Act_manauSpeed0);
                        PLC_WriteReal("D20046", plcitems.Act_Speed00_2);
                        PLC_WriteReal("D20048", plcitems.Act_Speed00_3);
                        PLC_WriteReal("D20050", plcitems.Act_Speed00_4);
                        PLC_WriteReal("	D20052", plcitems.Act_Speed00_5);
                        PLC_WriteReal("	D20054", plcitems.Act_Speed00_6);
                        PLC_WriteReal("	D20056", plcitems.Act_Speed00_7);
                        PLC_WriteReal("	D20058", plcitems.Act_Speed00_8);
                        #endregion

                    }
                });

            }



        }
        private void SET_AsixValue01(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {



                        PLC_WriteReal("D20004",plcitems.Act_acc1);
                         PLC_WriteReal("D20004",plcitems.Act_dec1);
                         PLC_WriteReal("D20160",plcitems.Act_autoSpeed1);
                         PLC_WriteReal("D20162",plcitems.Act_manauSpeed1);
                         PLC_WriteReal("D20140",plcitems.Act_pos1);
                        PLC_WriteReal("D20142", plcitems.Act_pos1_1);
                        PLC_WriteReal("D20144", plcitems.Act_pos2_1);
                       PLC_WriteReal("	D20166	" , plcitems.Act_pos01_3);
                        PLC_WriteReal("	D20168	", plcitems.Act_pos01_4);
                       PLC_WriteReal("D20170	" , plcitems.Act_pos01_5);
                       PLC_WriteReal("D20172	", plcitems.Act_pos01_6 );
                        PLC_WriteReal("D20174	" ,plcitems.Act_pos01_7);
                         PLC_WriteReal("D20176	",plcitems.Act_pos01_8);
                        PLC_WriteReal("D20178	",plcitems.Act_pos01_9 );
                        PLC_WriteReal("	D20146	",plcitems.Act_Speed01_2 );
                        PLC_WriteReal("	D20148	", plcitems.Act_Speed01_3);
                         PLC_WriteReal("	D20150	",plcitems.Act_Speed01_4);
                        PLC_WriteReal("	D20152	", plcitems.Act_Speed01_5);
                        PLC_WriteReal("	D20154	", plcitems.Act_Speed01_6);
                         PLC_WriteReal("	D20156	",plcitems.Act_Speed01_7);
                        PLC_WriteReal("	D20158	" ,plcitems.Act_Speed01_8);


                    }
                });

            }



        }
        private void SET_AsixValue02(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    { 
                        PLC_WriteReal("D20004", plcitems.Act_acc2);
                        PLC_WriteReal("D20004",plcitems.Act_dec2 );
                         PLC_WriteReal("D20260",plcitems.Act_autoSpeed2);
                         PLC_WriteReal("D20262",plcitems.Act_manauSpeed2);
                        PLC_WriteReal("D20240", plcitems.Act_pos2);
                         PLC_WriteReal("D20242",plcitems.Act_pos1_2);
                         PLC_WriteReal("D20244",plcitems.Act_pos2_2);
                         PLC_WriteReal("	D20264	",plcitems.Act_pos02_2);
                        PLC_WriteReal("	D20266	" ,plcitems.Act_pos02_3);
                         PLC_WriteReal("	D20268	",plcitems.Act_pos02_4);
                        PLC_WriteReal("	D20270	", plcitems.Act_pos02_5);
                       PLC_WriteReal("	D20272	" ,plcitems.Act_pos02_6 );
                         PLC_WriteReal("	D20274	",plcitems.Act_pos02_7);
                        PLC_WriteReal("	D20276	", plcitems.Act_pos02_8);
                         PLC_WriteReal("	D20278	",plcitems.Act_pos02_9);
                         PLC_WriteReal("	D20246	",plcitems.Act_Speed02_2);
                         PLC_WriteReal("	D20248	",plcitems.Act_Speed02_3);
                         PLC_WriteReal("	D20250	",plcitems.Act_Speed02_4);
                        PLC_WriteReal("	D20252	", plcitems.Act_Speed02_5);
                        PLC_WriteReal("	D20254	", plcitems.Act_Speed02_6);
                         PLC_WriteReal("	D20256	",plcitems.Act_Speed02_7);
                         PLC_WriteReal("	D20258	",plcitems.Act_Speed02_8);


                    }
                });

            }



        }
        private void SET_AsixValue03(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                         
                        PLC_WriteReal("D20004",plcitems.Act_acc3 );
                         PLC_WriteReal("D20004",plcitems.Act_dec3);
                        PLC_WriteReal("D20360", plcitems.Act_autoSpeed3);
                        PLC_WriteReal("D20362", plcitems.Act_manauSpeed3);
                        PLC_WriteReal("D20340" ,plcitems.Act_pos3);
                        PLC_WriteReal("D20342", plcitems.Act_pos1_3);
                        PLC_WriteReal("D20344" ,plcitems.Act_pos2_3);

                        PLC_WriteReal("	D20366	", plcitems.Act_pos03_3);
                      PLC_WriteReal("	D20368	" , plcitems.Act_pos03_4 );
                        PLC_WriteReal("D20370	", plcitems.Act_pos03_5);
                       PLC_WriteReal("D20372	" , plcitems.Act_pos03_6);
                        PLC_WriteReal("D20374	", plcitems.Act_pos03_7);
                       PLC_WriteReal("D20376	" , plcitems.Act_pos03_8);
                        PLC_WriteReal("D20378	", plcitems.Act_pos03_9);
                        PLC_WriteReal("	D20346	", plcitems.Act_Speed03_2);
                        PLC_WriteReal("	D20348	" ,plcitems.Act_Speed03_3);
                         PLC_WriteReal("	D20350	",plcitems.Act_Speed03_4);
                       PLC_WriteReal("	D20352	" , plcitems.Act_Speed03_5);
                        PLC_WriteReal("	D20354	", plcitems.Act_Speed03_6);
                       PLC_WriteReal("	D20356	" , plcitems.Act_Speed03_7);
                      PLC_WriteReal("	D20358	"  , plcitems.Act_Speed03_8);


                    }
                });

            }



        }
        private void SET_AsixValue04(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 4
                        
                      PLC_WriteReal("D20004" ,  plcitems.Act_acc4);
                        PLC_WriteReal("D20004", plcitems.Act_dec4);
                       PLC_WriteReal("D20460", plcitems.Act_autoSpeed4);
                       PLC_WriteReal("D20462",  plcitems.Act_manauSpeed4);
                       PLC_WriteReal("D20440", plcitems.Act_pos4);
                       PLC_WriteReal("D20442",  plcitems.Act_pos1_4);
                      PLC_WriteReal("D20444" , plcitems.Act_pos2_4);
                        #endregion
                       PLC_WriteReal("	D20464	" , plcitems.Act_pos04_2);
                       PLC_WriteReal("	D20466	", plcitems.Act_pos04_3);
                      PLC_WriteReal("	D20468	", plcitems.Act_pos04_4 );
                      PLC_WriteReal("	D20470	", plcitems.Act_pos04_5 );
                       PLC_WriteReal("	D20472	", plcitems.Act_pos04_6);
                       PLC_WriteReal("	D20474	", plcitems.Act_pos04_7);
                       PLC_WriteReal("	D20476	" , plcitems.Act_pos04_8);
                       PLC_WriteReal("	D20478	" , plcitems.Act_pos04_9);
                       PLC_WriteReal("	D20446	" , plcitems.Act_Speed04_2);
                       PLC_WriteReal("	D20448	"  ,plcitems.Act_Speed04_3);
                       PLC_WriteReal("	D20450	" , plcitems.Act_Speed04_4);
                       PLC_WriteReal("	D20452	" , plcitems.Act_Speed04_5);
                      PLC_WriteReal("	D20454	" , plcitems.Act_Speed04_6 );
                        PLC_WriteReal("	D20456	", plcitems.Act_Speed04_7);
                         PLC_WriteReal("	D20458	",plcitems.Act_Speed04_8);


                    }
                });

            }



        }
        private void SET_AsixValue05(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {
                        #region 5
                         
                         PLC_WriteReal("D20504",plcitems.Act_acc5);
                        PLC_WriteReal("D20504 ",plcitems.Act_dec5);
                       PLC_WriteReal("D20560" ,plcitems.Act_autoSpeed5);
                         PLC_WriteReal("D20562",plcitems.Act_manauSpeed5);
                         PLC_WriteReal("D20540",plcitems.Act_pos5);
                         PLC_WriteReal("D20542",plcitems.Act_pos1_5);
                         PLC_WriteReal("D20544",plcitems.Act_pos2_5);
                        #endregion
                        ;
                        PLC_WriteReal("	D20566	",plcitems.Act_pos05_3);
                       PLC_WriteReal("	D20568	" ,plcitems.Act_pos05_4 );
                         PLC_WriteReal("D20570	",plcitems.Act_pos05_5);
                        PLC_WriteReal("D20572	" ,plcitems.Act_pos05_6);
                         PLC_WriteReal("D20574	",plcitems.Act_pos05_7);
                         PLC_WriteReal("D20576	",plcitems.Act_pos05_8);
                         PLC_WriteReal("D20578	",plcitems.Act_pos05_9);
                         PLC_WriteReal("	D20546	",plcitems.Act_Speed05_2);
                        PLC_WriteReal("	D20548"	,plcitems.Act_Speed05_3 );
                        PLC_WriteReal("	D20550	",plcitems.Act_Speed05_4 );
                         PLC_WriteReal("	D20552	",plcitems.Act_Speed05_5);
                         PLC_WriteReal("	D20554	",plcitems.Act_Speed05_6);
                         PLC_WriteReal("	D20556	",plcitems.Act_Speed05_7);
                        PLC_WriteReal("	D20558	" ,plcitems.Act_Speed05_8);


                    }
                });

            }



        }
        private void SET_AsixValue06(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 6
                        
                         PLC_WriteReal("D20604",plcitems.Act_acc6);
                       PLC_WriteReal("D20604" ,plcitems.Act_dec6 );
                        PLC_WriteReal("D20660" ,plcitems.Act_autoSpeed6);
                         PLC_WriteReal("D20662",plcitems.Act_manauSpeed6);
                         PLC_WriteReal("D20640",plcitems.Act_pos6);
                        PLC_WriteReal("D20642" ,plcitems.Act_pos1_6);
                        PLC_WriteReal("D20644",plcitems.Act_pos2_6 );
                        #endregion
                        
                       PLC_WriteReal("	D20664	"  ,plcitems.Act_pos06_2);
                        PLC_WriteReal("	D20666	" ,plcitems.Act_pos06_3);
                         PLC_WriteReal("	D20668"	,plcitems.Act_pos06_4);
                        PLC_WriteReal("	D20670	" ,plcitems.Act_pos06_5);
                         PLC_WriteReal("	D20672	",plcitems.Act_pos06_6);
                         PLC_WriteReal("	D20674	",plcitems.Act_pos06_7);
                       PLC_WriteReal("	D20676	" ,plcitems.Act_pos06_8 );
                         PLC_WriteReal("	D20678	",plcitems.Act_pos06_9);
                         PLC_WriteReal("	D20646	",plcitems.Act_Speed06_2);
                        PLC_WriteReal("	D20648	" ,plcitems.Act_Speed06_3);
                       PLC_WriteReal("	D20650	"  ,plcitems.Act_Speed06_4);
                         PLC_WriteReal("	D20652	",plcitems.Act_Speed06_5);
                        PLC_WriteReal("	D20654	" ,plcitems.Act_Speed06_6);
                        PLC_WriteReal("	D20656	",plcitems.Act_Speed06_7);
                       PLC_WriteReal("	D20658	" ,plcitems.Act_Speed06_8 );


                    }
                });

            }



        }
        private void SET_AsixValue07(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 7
                         
                        PLC_WriteReal("D20704",plcitems.Act_acc7);
                         PLC_WriteReal("D20704",plcitems.Act_dec7);
                        PLC_WriteReal("D20760" ,plcitems.Act_autoSpeed7);
                        PLC_WriteReal("D20762",plcitems.Act_manauSpeed7 );
                         PLC_WriteReal("D20740",plcitems.Act_pos7);
                        PLC_WriteReal("D20742" ,plcitems.Act_pos1_7);
                        PLC_WriteReal("D20744" ,plcitems.Act_pos2_7);
                        #endregion
                         PLC_WriteReal("	D20764	", plcitems.Act_pos07_2);
                         PLC_WriteReal("	D20766	",plcitems.Act_pos07_3);
                         PLC_WriteReal("	D20768	",plcitems.Act_pos07_4);
                         PLC_WriteReal("D20770	",plcitems.Act_pos07_5);
                         PLC_WriteReal("D20772	",plcitems.Act_pos07_6);
                         PLC_WriteReal("D20774	",plcitems.Act_pos07_7);
                         PLC_WriteReal("D20776	",plcitems.Act_pos07_8);
                         PLC_WriteReal("D20778	",plcitems.Act_pos07_9);
                         PLC_WriteReal("	D20746	",plcitems.Act_Speed07_2);
                       PLC_WriteReal("	D20748	"  ,plcitems.Act_Speed07_3);
                         PLC_WriteReal("	D20750	",plcitems.Act_Speed07_4);
                         PLC_WriteReal("	D20752	",plcitems.Act_Speed07_5);
                        PLC_WriteReal("	D20754	" ,plcitems.Act_Speed07_6);
                        PLC_WriteReal("	D20756	" ,plcitems.Act_Speed07_7);
                         PLC_WriteReal("	D20758	",plcitems.Act_Speed07_8);


                    }
                });

            }



        }
        private void SET_AsixValue08(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        #region 8
                         
                        PLC_WriteReal("D20804" ,plcitems.Act_acc8);
                         PLC_WriteReal("D20804",plcitems.Act_dec8);
                         PLC_WriteReal("D20860",plcitems.Act_autoSpeed8);
                        PLC_WriteReal("D20862",plcitems.Act_manauSpeed8 );
                         PLC_WriteReal("D20840",plcitems.Act_pos8);
                       PLC_WriteReal("D20842" ,plcitems.Act_pos1_8);
                        PLC_WriteReal("D20844" ,plcitems.Act_pos2_8);
                        #endregion

                        PLC_WriteReal("	D20864	",plcitems.Act_pos08_2 );
                      PLC_WriteReal("	D20866	" ,plcitems.Act_pos08_3 );
                         PLC_WriteReal("	D20868	",plcitems.Act_pos08_4);
                         PLC_WriteReal("	D20870	",plcitems.Act_pos08_5);
                         PLC_WriteReal("	D20872	",plcitems.Act_pos08_6);
                       PLC_WriteReal("	D20874	",plcitems.Act_pos08_7 );
                        PLC_WriteReal("	D20876	" ,plcitems.Act_pos08_8);
                        PLC_WriteReal("	D20878	" ,plcitems.Act_pos08_9);
                         PLC_WriteReal("	D20846	",plcitems.Act_Speed08_2);
                         PLC_WriteReal("	D20848	",plcitems.Act_Speed08_3);
                        PLC_WriteReal("	D20850	" ,plcitems.Act_Speed08_4);
                         PLC_WriteReal("	D20852	",plcitems.Act_Speed08_5);
                         PLC_WriteReal("	D20854	",plcitems.Act_Speed08_6);
                        PLC_WriteReal("	D20856	" ,plcitems.Act_Speed08_7);
                        PLC_WriteReal("	D20858	" ,plcitems.Act_Speed08_8);

                    }
                });

            }



        }
        private void SET_AsixValue09(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        #region 9
                         
                         PLC_WriteReal("D20904",plcitems.Act_acc9);
                         PLC_WriteReal("D20904",plcitems.Act_dec9);
                       PLC_WriteReal("D20960" ,plcitems.Act_autoSpeed9 );
                        PLC_WriteReal("D20962" ,plcitems.Act_manauSpeed9);
                        PLC_WriteReal("D20940" ,plcitems.Act_pos9);
                         PLC_WriteReal("D20942",plcitems.Act_pos1_9);
                         PLC_WriteReal("D20944",plcitems.Act_pos2_9);
                        #endregion

                         PLC_WriteReal("	D20966	",plcitems.Act_pos09_3);
                        PLC_WriteReal("	D20968	" ,plcitems.Act_pos09_4);
                        PLC_WriteReal("D20970	",plcitems.Act_pos09_5) ;
                       PLC_WriteReal("D20972	" ,plcitems.Act_pos09_6);
                        PLC_WriteReal("D20974	" ,plcitems.Act_pos09_7);
                       PLC_WriteReal("D20976	" ,plcitems.Act_pos09_8 );
                         PLC_WriteReal("D20978	",plcitems.Act_pos09_9);
                        PLC_WriteReal("	D20946	" ,plcitems.Act_Speed09_2);
                         PLC_WriteReal("	D20948	",plcitems.Act_Speed09_3);
                        PLC_WriteReal("	D20950	" ,plcitems.Act_Speed09_4);
                       PLC_WriteReal("	D20952	" ,plcitems.Act_Speed09_5);
                         PLC_WriteReal("	D20954	",plcitems.Act_Speed09_6);
                         PLC_WriteReal("	D20956	",plcitems.Act_Speed09_7);
                         PLC_WriteReal("	D20958	",plcitems.Act_Speed09_8);

                    }
                });

            }



        }
        private void SET_AsixValue10(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 10
                         
                        PLC_WriteReal("D21004" ,plcitems.Act_acc10);
                       PLC_WriteReal("D21004"  ,plcitems.Act_dec10);
                        PLC_WriteReal("D21060" ,plcitems.Act_autoSpeed10);
                        PLC_WriteReal("D21062" ,plcitems.Act_manauSpeed10);
                         PLC_WriteReal("D21040",plcitems.Act_pos10);
                        PLC_WriteReal("D21042" ,plcitems.Act_pos1_10);
                       PLC_WriteReal("D21044" ,plcitems.Act_pos2_10 );
                        #endregion

                         PLC_WriteReal("	D21064	",plcitems.Act_pos10_2);
                        PLC_WriteReal("	D21066	" ,plcitems.Act_pos10_3);
                        PLC_WriteReal("	D21068	" ,plcitems.Act_pos10_4);
                        PLC_WriteReal("	D21070	" ,plcitems.Act_pos10_5);
                         PLC_WriteReal("	D21072	",plcitems.Act_pos10_6);
                        PLC_WriteReal("	D21074	" ,plcitems.Act_pos10_7);
                        PLC_WriteReal("	D21076	",plcitems.Act_pos10_8 );
                       PLC_WriteReal("	D21078	" ,plcitems.Act_pos10_9 );
                        PLC_WriteReal("	D21046	" ,plcitems.Act_Speed10_2);
                        PLC_WriteReal("	D21048	" ,plcitems.Act_Speed10_3);
                       PLC_WriteReal("	D21050	" ,plcitems.Act_Speed10_4 );
                         PLC_WriteReal("	D21052	",plcitems.Act_Speed10_5);
                        PLC_WriteReal("	D21054	" ,plcitems.Act_Speed10_6);
                        PLC_WriteReal("	D21056	",plcitems.Act_Speed10_7 );
                        PLC_WriteReal("	D21058	" ,plcitems.Act_Speed10_8);

                    }
                });

            }



        }
        private void SET_AsixValue11(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 11
                        
                         PLC_WriteReal("D21104",plcitems.Act_acc11);
                         PLC_WriteReal("D21104",plcitems.Act_dec11);
                         PLC_WriteReal("D21160",plcitems.Act_autoSpeed11);
                         PLC_WriteReal("D21162",plcitems.Act_manauSpeed11);
                       PLC_WriteReal("D21140" ,plcitems.Act_pos11 );
                         PLC_WriteReal("D21142",plcitems.Act_pos1_11);
                         PLC_WriteReal("D21144",plcitems.Act_pos2_11);
                        #endregion
                        PLC_WriteReal("	D21166	" ,plcitems.Act_pos11_3);
                       PLC_WriteReal("	D21168	"  ,plcitems.Act_pos11_4);
                        PLC_WriteReal("D21170	" ,plcitems.Act_pos11_5);
                        PLC_WriteReal("D21172	" ,plcitems.Act_pos11_6);
                        PLC_WriteReal("D21174	" ,plcitems.Act_pos11_7);
                       PLC_WriteReal("D21176	" ,plcitems.Act_pos11_8 );
                       PLC_WriteReal("D21178	" , plcitems.Act_pos11_9);
                        PLC_WriteReal("	D21146	" ,plcitems.Act_Speed11_2);
                        PLC_WriteReal("	D21148	" ,plcitems.Act_Speed11_3);
                        PLC_WriteReal("	D21150	",plcitems.Act_Speed11_4 );
                       PLC_WriteReal("	D21152	" ,plcitems.Act_Speed11_5 );
                       PLC_WriteReal("	D21154	" ,plcitems.Act_Speed11_6);
                      PLC_WriteReal("	D21156	" ,plcitems.Act_Speed11_7);
                         PLC_WriteReal("	D21158	",plcitems.Act_Speed11_8);
                    }
                });

            }



        }
        private void SET_AsixValue12(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        #region 12
                        
                        PLC_WriteReal("D21204",plcitems.Act_acc12 );
                         PLC_WriteReal("D21204",plcitems.Act_dec12);
                         PLC_WriteReal("D21260",plcitems.Act_autoSpeed12);
                        PLC_WriteReal("D21262",plcitems.Act_manauSpeed12);
                         PLC_WriteReal("D21240",plcitems.Act_pos12);
                        PLC_WriteReal("D21242",plcitems.Act_pos1_12 );
                        PLC_WriteReal("D21244",plcitems.Act_pos2_12 );
                        #endregion
                        PLC_WriteReal("	D21264	" ,plcitems.Act_pos12_2);
                        PLC_WriteReal("	D21266	" ,plcitems.Act_pos12_3);
                         PLC_WriteReal("	D21268	",plcitems.Act_pos12_4);
                      PLC_WriteReal("	D21270	"  ,plcitems.Act_pos12_5);
                        PLC_WriteReal("	D21272	" ,plcitems.Act_pos12_6);
                         PLC_WriteReal("	D21274	",plcitems.Act_pos12_7);
                        PLC_WriteReal("	D21276	" ,plcitems.Act_pos12_8);
                         PLC_WriteReal("	D21278	",plcitems.Act_pos12_9);
                         PLC_WriteReal("	D21246	",plcitems.Act_Speed12_2);
                        PLC_WriteReal("	D21248	",plcitems.Act_Speed12_3 );
                         PLC_WriteReal("	D21250	",plcitems.Act_Speed12_4);
                        PLC_WriteReal("	D21252	" ,plcitems.Act_Speed12_5);
                        PLC_WriteReal("	D21254	" ,plcitems.Act_Speed12_6);
                        PLC_WriteReal("	D21256	" ,plcitems.Act_Speed12_7);
                        PLC_WriteReal("	D21258	" ,plcitems.Act_Speed12_8);
                    }
                });

            }



        }
        private void SET_AsixValue13(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {



                        #region 13
                        PLC_WriteReal("D21380",plcitems.Erroor_Code13 );
                       PLC_WriteReal("D21304" ,plcitems.Act_acc13 );
                        PLC_WriteReal("D21304" ,plcitems.Act_dec13);
                         PLC_WriteReal("D21360",plcitems.Act_autoSpeed13);
                        PLC_WriteReal("D21362" ,plcitems.Act_manauSpeed13);
                        PLC_WriteReal("D21340" ,plcitems.Act_pos13);
                      PLC_WriteReal("D21342"  ,plcitems.Act_pos1_13 );
                        PLC_WriteReal("D21344",plcitems.Act_pos2_13);
                        #endregion

                        PLC_WriteReal("	D21366	" ,plcitems.Act_pos13_3);
                        PLC_WriteReal("	D21368	" ,plcitems.Act_pos13_4);
                        PLC_WriteReal("D21370	", plcitems.Act_pos13_5);
                        PLC_WriteReal("D21372	",plcitems.Act_pos13_6 );
                       PLC_WriteReal("D21374	" , plcitems.Act_pos13_7);
                       PLC_WriteReal("D21376	" , plcitems.Act_pos13_8);
                         PLC_WriteReal("D21378"	,plcitems.Act_pos13_9);
                        PLC_WriteReal("	D21346	",plcitems.Act_Speed13_2);
                        PLC_WriteReal("	D21348	",plcitems.Act_Speed13_3 );
                         PLC_WriteReal("	D21350	",plcitems.Act_Speed13_4);
                         PLC_WriteReal("	D21352	",plcitems.Act_Speed13_5);
                        PLC_WriteReal("	D21354	",plcitems.Act_Speed13_6);
                         PLC_WriteReal("	D21356	",plcitems.Act_Speed13_7);
                       PLC_WriteReal("	D21358	" ,plcitems.Act_Speed13_8);
                    }
                });

            }



        }
        private void SET_AsixValue14(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        #region 14
                     
                       PLC_WriteReal("D21404" ,plcitems.Act_acc14 );
                        PLC_WriteReal("D21404" ,plcitems.Act_dec14);
                        PLC_WriteReal("D21360" ,plcitems.Act_autoSpeed14);
                         PLC_WriteReal("D21362",plcitems.Act_manauSpeed14);
                         PLC_WriteReal("D21440",plcitems.Act_pos14);
                       PLC_WriteReal("D21442" , plcitems.Act_pos1_14);
                        PLC_WriteReal("D21444",plcitems.Act_pos2_14 );
                        #endregion

                         PLC_WriteReal("	D21464	",plcitems.Act_pos14_2);
                       PLC_WriteReal("	D21466	"  ,plcitems.Act_pos14_3);
                        PLC_WriteReal("	D21468	" ,plcitems.Act_pos14_4);
                       PLC_WriteReal("	D21470	" ,plcitems.Act_pos14_5 );
                       PLC_WriteReal("	D21472	" ,plcitems.Act_pos14_6 );
                         PLC_WriteReal("	D21474	",plcitems.Act_pos14_7);
                        PLC_WriteReal("	D21476	",plcitems.Act_pos14_8 );
                         PLC_WriteReal("	D21478	",plcitems.Act_pos14_9);
                        PLC_WriteReal(" D21446	" ,plcitems.Act_Speed14_2);
                         PLC_WriteReal("	D21448	",plcitems.Act_Speed14_3);
                         PLC_WriteReal("	D21450	",plcitems.Act_Speed14_4);
                        PLC_WriteReal("	D21452	" ,plcitems.Act_Speed14_5);
                        PLC_WriteReal("	D21454	" ,plcitems.Act_Speed14_6);
                        PLC_WriteReal("	D21456	" ,plcitems.Act_Speed14_7);
                         PLC_WriteReal("	D21458	",plcitems.Act_Speed14_8);
                    }
                });

            }



        }
        private void SET_AsixValue15(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 15
                         PLC_WriteReal("D21580",plcitems.Erroor_Code15);
                         PLC_WriteReal("D21404",plcitems.Act_acc15);
                         PLC_WriteReal("D21404",plcitems.Act_dec15);
                        PLC_WriteReal("D21460" ,plcitems.Act_autoSpeed15);
                         PLC_WriteReal("D21462",plcitems.Act_manauSpeed15);
                         PLC_WriteReal("D21540",plcitems.Act_pos15);
                        PLC_WriteReal("D21542" ,plcitems.Act_pos1_15);
                       PLC_WriteReal("D21544" ,plcitems.Act_pos2_15 );
                        #endregion

                        PLC_WriteReal("	D21566	",plcitems.Act_pos15_3 );
                         PLC_WriteReal("	D21568	",plcitems.Act_pos15_4);
                         PLC_WriteReal("D21570	",plcitems.Act_pos15_5);
                        PLC_WriteReal("D21572	", plcitems.Act_pos15_6);
                         PLC_WriteReal("D21574	",plcitems.Act_pos15_7);
                        PLC_WriteReal("D21576"	 ,plcitems.Act_pos15_8);
                         PLC_WriteReal("D21578"	,plcitems.Act_pos15_9);
                        PLC_WriteReal("	D21546	" ,plcitems.Act_Speed15_2);
                        PLC_WriteReal("	D21548"	,plcitems.Act_Speed15_3);
                       PLC_WriteReal("	D21550	" , plcitems.Act_Speed15_4);
                       PLC_WriteReal("	D21552	", plcitems.Act_Speed15_5 );
                         PLC_WriteReal("	D21554	",plcitems.Act_Speed15_6);
                         PLC_WriteReal("	D21556	",plcitems.Act_Speed15_7);
                         PLC_WriteReal(" D21558 ",plcitems.Act_Speed15_8);
                    }
                });

            }



        }
        private void SET_AsixValue16(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 16
                        
                        PLC_WriteReal("D21504" ,plcitems.Act_acc16);
                         PLC_WriteReal("D21504",plcitems.Act_dec16);
                         PLC_WriteReal("D21560",plcitems.Act_autoSpeed16);
                         PLC_WriteReal("D21562",plcitems.Act_manauSpeed16);
                        PLC_WriteReal("D21640",plcitems.Act_pos16 );
                         PLC_WriteReal("D21642",plcitems.Act_pos1_16);
                         PLC_WriteReal("D21644",plcitems.Act_pos2_16);
                        #endregion


                       PLC_WriteReal("	D21664	" , plcitems.Act_pos16_2);
                         PLC_WriteReal("	D21666	",plcitems.Act_pos16_3);
                         PLC_WriteReal("	D21668	",plcitems.Act_pos16_4);
                        PLC_WriteReal("	D21670	" ,plcitems.Act_pos16_5);
                       PLC_WriteReal("	D21672	" , plcitems.Act_pos16_6);
                       PLC_WriteReal("	D21674"	 ,plcitems.Act_pos16_7);
                         PLC_WriteReal("	D21676	",plcitems.Act_pos16_8);
                       PLC_WriteReal("	D21678	" ,plcitems.Act_pos16_9 );
                        PLC_WriteReal("	D21646	",plcitems.Act_Speed16_2);
                         PLC_WriteReal("	D21648	",plcitems.Act_Speed16_3);
                        PLC_WriteReal("	D21650	", plcitems.Act_Speed16_4);
                         PLC_WriteReal("	D21652	",plcitems.Act_Speed16_5);
                         PLC_WriteReal("	D21654	",plcitems.Act_Speed16_6);
                        PLC_WriteReal("	D21656	",plcitems.Act_Speed16_7 );
                         PLC_WriteReal("	D21658	",plcitems.Act_Speed16_8);
                    }
                });

            }



        }
        #endregion
        #region GET_AsixValue
        private void GET_AsixValue00(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run( () =>
                {

                    if (EtherNetPLC_State)
                    {
                         
                        
                        plcitems.Act_acc0 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_dec0 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_autoSpeed0 = PLC_ReadReal("D20060").Result;
                        plcitems.Act_manauSpeed0 = PLC_ReadReal("D20062").Result;
                        plcitems.Act_pos0 = PLC_ReadReal("D20040").Result;
                        plcitems.Act_pos1_0 = PLC_ReadReal("D20042").Result;
                        plcitems.Act_pos2_0 = PLC_ReadReal("D20044").Result;
                        plcitems.Act_pos00_2 = PLC_ReadReal("	D20064	").Result;
                        plcitems.Act_pos00_3 = PLC_ReadReal("	D20066	").Result;
                        plcitems.Act_pos00_4 = PLC_ReadReal("	D20068	").Result;
                        plcitems.Act_pos00_5 = PLC_ReadReal("	D20070	").Result;
                        plcitems.Act_pos00_6 = PLC_ReadReal("	D20072	").Result;
                        plcitems.Act_pos00_7 = PLC_ReadReal("	D20074	").Result;
                        plcitems.Act_pos00_8 = PLC_ReadReal("	D20076	").Result;
                        plcitems.Act_pos00_9 = PLC_ReadReal("	D20078	").Result;
                        plcitems.Act_Speed00_2 = PLC_ReadReal("	D20046	").Result;
                        plcitems.Act_Speed00_3 = PLC_ReadReal("	D20048	").Result;
                        plcitems.Act_Speed00_4 = PLC_ReadReal("	D20050	").Result;
                        plcitems.Act_Speed00_5 = PLC_ReadReal("	D20052	").Result;
                        plcitems.Act_Speed00_6 = PLC_ReadReal("	D20054	").Result;
                        plcitems.Act_Speed00_7 = PLC_ReadReal("	D20056	").Result;
                        plcitems.Act_Speed00_8 = PLC_ReadReal("	D20058	").Result;


                    }
                });

            }



        }
        private void GET_AsixValue01(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        
                        plcitems.Act_acc1 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_dec1 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_autoSpeed1 = PLC_ReadReal("D20160").Result;
                        plcitems.Act_manauSpeed1 = PLC_ReadReal("D20162").Result;
                        plcitems.Act_pos1 = PLC_ReadReal("D20140").Result;
                        plcitems.Act_pos1_1 = PLC_ReadReal("D20142").Result;
                        plcitems.Act_pos2_1 = PLC_ReadReal("D20144").Result;
                        plcitems.Act_pos01_3 = PLC_ReadReal("	D20166	").Result;
                        plcitems.Act_pos01_4 = PLC_ReadReal("	D20168	").Result;
                        plcitems.Act_pos01_5 = PLC_ReadReal("D20170	").Result;
                        plcitems.Act_pos01_6 = PLC_ReadReal("D20172	").Result;
                        plcitems.Act_pos01_7 = PLC_ReadReal("D20174	").Result;
                        plcitems.Act_pos01_8 = PLC_ReadReal("D20176	").Result;
                        plcitems.Act_pos01_9 = PLC_ReadReal("D20178	").Result;
                        plcitems.Act_Speed01_2 = PLC_ReadReal("	D20146	").Result;
                        plcitems.Act_Speed01_3 = PLC_ReadReal("	D20148	").Result;
                        plcitems.Act_Speed01_4 = PLC_ReadReal("	D20150	").Result;
                        plcitems.Act_Speed01_5 = PLC_ReadReal("	D20152	").Result;
                        plcitems.Act_Speed01_6 = PLC_ReadReal("	D20154	").Result;
                        plcitems.Act_Speed01_7 = PLC_ReadReal("	D20156	").Result;
                        plcitems.Act_Speed01_8 = PLC_ReadReal("	D20158	").Result;


                    }
                });

            }



        }
        private void GET_AsixValue02(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                     
                        plcitems.Act_acc2 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_dec2 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_autoSpeed2 = PLC_ReadReal("D20260").Result;
                        plcitems.Act_manauSpeed2 = PLC_ReadReal("D20262").Result;
                        plcitems.Act_pos2 = PLC_ReadReal("D20240").Result;
                        plcitems.Act_pos1_2 = PLC_ReadReal("D20242").Result;
                        plcitems.Act_pos2_2 = PLC_ReadReal("D20244").Result;
                        plcitems.Act_pos02_2 = PLC_ReadReal("	D20264	").Result;
                        plcitems.Act_pos02_3 = PLC_ReadReal("	D20266	").Result;
                        plcitems.Act_pos02_4 = PLC_ReadReal("	D20268	").Result;
                        plcitems.Act_pos02_5 = PLC_ReadReal("	D20270	").Result;
                        plcitems.Act_pos02_6 = PLC_ReadReal("	D20272	").Result;
                        plcitems.Act_pos02_7 = PLC_ReadReal("	D20274	").Result;
                        plcitems.Act_pos02_8 = PLC_ReadReal("	D20276	").Result;
                        plcitems.Act_pos02_9 = PLC_ReadReal("	D20278	").Result;
                        plcitems.Act_Speed02_2 = PLC_ReadReal("	D20246	").Result;
                        plcitems.Act_Speed02_3 = PLC_ReadReal("	D20248	").Result;
                        plcitems.Act_Speed02_4 = PLC_ReadReal("	D20250	").Result;
                        plcitems.Act_Speed02_5 = PLC_ReadReal("	D20252	").Result;
                        plcitems.Act_Speed02_6 = PLC_ReadReal("	D20254	").Result;
                        plcitems.Act_Speed02_7 = PLC_ReadReal("	D20256	").Result;
                        plcitems.Act_Speed02_8 = PLC_ReadReal("	D20258	").Result;


                    }
                });

            }



        }
        private void GET_AsixValue03(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                       
                        
                        plcitems.Act_acc3 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_dec3 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_autoSpeed3 = PLC_ReadReal("D20360").Result;
                        plcitems.Act_manauSpeed3 = PLC_ReadReal("D20362").Result;
                        plcitems.Act_pos3 = PLC_ReadReal("D20340").Result;
                        plcitems.Act_pos1_3 = PLC_ReadReal("D20342").Result;
                        plcitems.Act_pos2_3 = PLC_ReadReal("D20344").Result;

                        plcitems.Act_pos03_3 = PLC_ReadReal("	D20366	").Result;
                        plcitems.Act_pos03_4 = PLC_ReadReal("	D20368	").Result;
                        plcitems.Act_pos03_5 = PLC_ReadReal("D20370	").Result;
                        plcitems.Act_pos03_6 = PLC_ReadReal("D20372	").Result;
                        plcitems.Act_pos03_7 = PLC_ReadReal("D20374	").Result;
                        plcitems.Act_pos03_8 = PLC_ReadReal("D20376	").Result;
                        plcitems.Act_pos03_9 = PLC_ReadReal("D20378	").Result;
                        plcitems.Act_Speed03_2 = PLC_ReadReal("	D20346	").Result;
                        plcitems.Act_Speed03_3 = PLC_ReadReal("	D20348	").Result;
                        plcitems.Act_Speed03_4 = PLC_ReadReal("	D20350	").Result;
                        plcitems.Act_Speed03_5 = PLC_ReadReal("	D20352	").Result;
                        plcitems.Act_Speed03_6 = PLC_ReadReal("	D20354	").Result;
                        plcitems.Act_Speed03_7 = PLC_ReadReal("	D20356	").Result;
                        plcitems.Act_Speed03_8 = PLC_ReadReal("	D20358	").Result;


                    }
                });

            }



        }
        private void GET_AsixValue04(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 4
                         
                        plcitems.Act_acc4 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_dec4 = PLC_ReadReal("D20004").Result;
                        plcitems.Act_autoSpeed4 = PLC_ReadReal("D20460").Result;
                        plcitems.Act_manauSpeed4 = PLC_ReadReal("D20462").Result;
                        plcitems.Act_pos4 = PLC_ReadReal("D20440").Result;
                        plcitems.Act_pos1_4 = PLC_ReadReal("D20442").Result;
                        plcitems.Act_pos2_4 = PLC_ReadReal("D20444").Result;
                        #endregion
                        plcitems.Act_pos04_2 = PLC_ReadReal("	D20464	").Result;
                        plcitems.Act_pos04_3 = PLC_ReadReal("	D20466	").Result;
                        plcitems.Act_pos04_4 = PLC_ReadReal("	D20468	").Result;
                        plcitems.Act_pos04_5 = PLC_ReadReal("	D20470	").Result;
                        plcitems.Act_pos04_6 = PLC_ReadReal("	D20472	").Result;
                        plcitems.Act_pos04_7 = PLC_ReadReal("	D20474	").Result;
                        plcitems.Act_pos04_8 = PLC_ReadReal("	D20476	").Result;
                        plcitems.Act_pos04_9 = PLC_ReadReal("	D20478	").Result;
                        plcitems.Act_Speed04_2 = PLC_ReadReal("	D20446	").Result;
                        plcitems.Act_Speed04_3 = PLC_ReadReal("	D20448	").Result;
                        plcitems.Act_Speed04_4 = PLC_ReadReal("	D20450	").Result;
                        plcitems.Act_Speed04_5 = PLC_ReadReal("	D20452	").Result;
                        plcitems.Act_Speed04_6 = PLC_ReadReal("	D20454	").Result;
                        plcitems.Act_Speed04_7 = PLC_ReadReal("	D20456	").Result;
                        plcitems.Act_Speed04_8 = PLC_ReadReal("	D20458	").Result;


                    }
                });

            }



        }
        private void GET_AsixValue05(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {
                        #region 5
                        
                        plcitems.Act_acc5 = PLC_ReadReal("D20504").Result;
                        plcitems.Act_dec5 = PLC_ReadReal("D20504").Result;
                        plcitems.Act_autoSpeed5 = PLC_ReadReal("D20560").Result;
                        plcitems.Act_manauSpeed5 = PLC_ReadReal("D20562").Result;
                        plcitems.Act_pos5 = PLC_ReadReal("D20540").Result;
                        plcitems.Act_pos1_5 = PLC_ReadReal("D20542").Result;
                        plcitems.Act_pos2_5 = PLC_ReadReal("D20544").Result;
                        #endregion
                        ;
                        plcitems.Act_pos05_3 = PLC_ReadReal("	D20566	").Result;
                        plcitems.Act_pos05_4 = PLC_ReadReal("	D20568	").Result;
                        plcitems.Act_pos05_5 = PLC_ReadReal("D20570	").Result;
                        plcitems.Act_pos05_6 = PLC_ReadReal("D20572	").Result;
                        plcitems.Act_pos05_7 = PLC_ReadReal("D20574	").Result;
                        plcitems.Act_pos05_8 = PLC_ReadReal("D20576	").Result;
                        plcitems.Act_pos05_9 = PLC_ReadReal("D20578	").Result;
                        plcitems.Act_Speed05_2 = PLC_ReadReal("	D20546	").Result;
                        plcitems.Act_Speed05_3 = PLC_ReadReal("	D20548	").Result;
                        plcitems.Act_Speed05_4 = PLC_ReadReal("	D20550	").Result;
                        plcitems.Act_Speed05_5 = PLC_ReadReal("	D20552	").Result;
                        plcitems.Act_Speed05_6 = PLC_ReadReal("	D20554	").Result;
                        plcitems.Act_Speed05_7 = PLC_ReadReal("	D20556	").Result;
                        plcitems.Act_Speed05_8 = PLC_ReadReal("	D20558	").Result;


                    }
                });

            }



        }
        private void GET_AsixValue06(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 6
                         
                        plcitems.Act_acc6 = PLC_ReadReal("D20604").Result;
                        plcitems.Act_dec6 = PLC_ReadReal("D20604").Result;
                        plcitems.Act_autoSpeed6 = PLC_ReadReal("D20660").Result;
                        plcitems.Act_manauSpeed6 = PLC_ReadReal("D20662").Result;
                        plcitems.Act_pos6 = PLC_ReadReal("D20640").Result;
                        plcitems.Act_pos1_6 = PLC_ReadReal("D20642").Result;
                        plcitems.Act_pos2_6 = PLC_ReadReal("D20644").Result;
                        #endregion
                        ;
                        plcitems.Act_pos06_2 = PLC_ReadReal("	D20664	").Result;
                        plcitems.Act_pos06_3 = PLC_ReadReal("	D20666	").Result;
                        plcitems.Act_pos06_4 = PLC_ReadReal("	D20668	").Result;
                        plcitems.Act_pos06_5 = PLC_ReadReal("	D20670	").Result;
                        plcitems.Act_pos06_6 = PLC_ReadReal("	D20672	").Result;
                        plcitems.Act_pos06_7 = PLC_ReadReal("	D20674	").Result;
                        plcitems.Act_pos06_8 = PLC_ReadReal("	D20676	").Result;
                        plcitems.Act_pos06_9 = PLC_ReadReal("	D20678	").Result;
                        plcitems.Act_Speed06_2 = PLC_ReadReal("	D20646	").Result;
                        plcitems.Act_Speed06_3 = PLC_ReadReal("	D20648	").Result;
                        plcitems.Act_Speed06_4 = PLC_ReadReal("	D20650	").Result;
                        plcitems.Act_Speed06_5 = PLC_ReadReal("	D20652	").Result;
                        plcitems.Act_Speed06_6 = PLC_ReadReal("	D20654	").Result;
                        plcitems.Act_Speed06_7 = PLC_ReadReal("	D20656	").Result;
                        plcitems.Act_Speed06_8 = PLC_ReadReal("	D20658	").Result;


                    }
                });

            }



        }
        private void GET_AsixValue07(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 7
                        
                        plcitems.Act_acc7 = PLC_ReadReal("D20704").Result;
                        plcitems.Act_dec7 = PLC_ReadReal("D20704").Result;
                        plcitems.Act_autoSpeed7 = PLC_ReadReal("D20760").Result;
                        plcitems.Act_manauSpeed7 = PLC_ReadReal("D20762").Result;
                        plcitems.Act_pos7 = PLC_ReadReal("D20740").Result;
                        plcitems.Act_pos1_7 = PLC_ReadReal("D20742").Result;
                        plcitems.Act_pos2_7 = PLC_ReadReal("D20744").Result;
                        #endregion

                        plcitems.Act_pos07_3 = PLC_ReadReal("	D20766	").Result;
                        plcitems.Act_pos07_4 = PLC_ReadReal("	D20768	").Result;
                        plcitems.Act_pos07_5 = PLC_ReadReal("D20770	").Result;
                        plcitems.Act_pos07_6 = PLC_ReadReal("D20772	").Result;
                        plcitems.Act_pos07_7 = PLC_ReadReal("D20774	").Result;
                        plcitems.Act_pos07_8 = PLC_ReadReal("D20776	").Result;
                        plcitems.Act_pos07_9 = PLC_ReadReal("D20778	").Result;
                        plcitems.Act_Speed07_2 = PLC_ReadReal("	D20746	").Result;
                        plcitems.Act_Speed07_3 = PLC_ReadReal("	D20748	").Result;
                        plcitems.Act_Speed07_4 = PLC_ReadReal("	D20750	").Result;
                        plcitems.Act_Speed07_5 = PLC_ReadReal("	D20752	").Result;
                        plcitems.Act_Speed07_6 = PLC_ReadReal("	D20754	").Result;
                        plcitems.Act_Speed07_7 = PLC_ReadReal("	D20756	").Result;
                        plcitems.Act_Speed07_8 = PLC_ReadReal("	D20758	").Result;


                    }
                });

            }



        }
        private void GET_AsixValue08(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        #region 8
                        
                        plcitems.Act_acc8 = PLC_ReadReal("D20804").Result;
                        plcitems.Act_dec8 = PLC_ReadReal("D20804").Result;
                        plcitems.Act_autoSpeed8 = PLC_ReadReal("D20860").Result;
                        plcitems.Act_manauSpeed8 = PLC_ReadReal("D20862").Result;
                        plcitems.Act_pos8 = PLC_ReadReal("D20840").Result;
                        plcitems.Act_pos1_8 = PLC_ReadReal("D20842").Result;
                        plcitems.Act_pos2_8 = PLC_ReadReal("D20844").Result;
                        #endregion

                        plcitems.Act_pos08_2 = PLC_ReadReal("	D20864	").Result;
                        plcitems.Act_pos08_3 = PLC_ReadReal("	D20866	").Result;
                        plcitems.Act_pos08_4 = PLC_ReadReal("	D20868	").Result;
                        plcitems.Act_pos08_5 = PLC_ReadReal("	D20870	").Result;
                        plcitems.Act_pos08_6 = PLC_ReadReal("	D20872	").Result;
                        plcitems.Act_pos08_7 = PLC_ReadReal("	D20874	").Result;
                        plcitems.Act_pos08_8 = PLC_ReadReal("	D20876	").Result;
                        plcitems.Act_pos08_9 = PLC_ReadReal("	D20878	").Result;
                        plcitems.Act_Speed08_2 = PLC_ReadReal("	D20846	").Result;
                        plcitems.Act_Speed08_3 = PLC_ReadReal("	D20848	").Result;
                        plcitems.Act_Speed08_4 = PLC_ReadReal("	D20850	").Result;
                        plcitems.Act_Speed08_5 = PLC_ReadReal("	D20852	").Result;
                        plcitems.Act_Speed08_6 = PLC_ReadReal("	D20854	").Result;
                        plcitems.Act_Speed08_7 = PLC_ReadReal("	D20856	").Result;
                        plcitems.Act_Speed08_8 = PLC_ReadReal("	D20858	").Result;

                    }
                });

            }



        }
        private void GET_AsixValue09(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        #region 9
                         
                        plcitems.Act_acc9 = PLC_ReadReal("D20904").Result;
                        plcitems.Act_dec9 = PLC_ReadReal("D20904").Result;
                        plcitems.Act_autoSpeed9 = PLC_ReadReal("D20960").Result;
                        plcitems.Act_manauSpeed9 = PLC_ReadReal("D20962").Result;
                        plcitems.Act_pos9 = PLC_ReadReal("D20940").Result;
                        plcitems.Act_pos1_9 = PLC_ReadReal("D20942").Result;
                        plcitems.Act_pos2_9 = PLC_ReadReal("D20944").Result;
                        #endregion

                        plcitems.Act_pos09_3 = PLC_ReadReal("	D20966	").Result;
                        plcitems.Act_pos09_4 = PLC_ReadReal("	D20968	").Result;
                        plcitems.Act_pos09_5 = PLC_ReadReal("D20970	").Result;
                        plcitems.Act_pos09_6 = PLC_ReadReal("D20972	").Result;
                        plcitems.Act_pos09_7 = PLC_ReadReal("D20974	").Result;
                        plcitems.Act_pos09_8 = PLC_ReadReal("D20976	").Result;
                        plcitems.Act_pos09_9 = PLC_ReadReal("D20978	").Result;
                        plcitems.Act_Speed09_2 = PLC_ReadReal("	D20946	").Result;
                        plcitems.Act_Speed09_3 = PLC_ReadReal("	D20948	").Result;
                        plcitems.Act_Speed09_4 = PLC_ReadReal("	D20950	").Result;
                        plcitems.Act_Speed09_5 = PLC_ReadReal("	D20952	").Result;
                        plcitems.Act_Speed09_6 = PLC_ReadReal("	D20954	").Result;
                        plcitems.Act_Speed09_7 = PLC_ReadReal("	D20956	").Result;
                        plcitems.Act_Speed09_8 = PLC_ReadReal("	D20958	").Result;

                    }
                });

            }



        }
        private void GET_AsixValue10(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 10
                         
                        plcitems.Act_acc10 = PLC_ReadReal("D21004").Result;
                        plcitems.Act_dec10 = PLC_ReadReal("D21004").Result;
                        plcitems.Act_autoSpeed10 = PLC_ReadReal("D21060").Result;
                        plcitems.Act_manauSpeed10 = PLC_ReadReal("D21062").Result;
                        plcitems.Act_pos10 = PLC_ReadReal("D21040").Result;
                        plcitems.Act_pos1_10 = PLC_ReadReal("D21042").Result;
                        plcitems.Act_pos2_10 = PLC_ReadReal("D21044").Result;
                        #endregion

                        plcitems.Act_pos10_2 = PLC_ReadReal("	D21064	").Result;
                        plcitems.Act_pos10_3 = PLC_ReadReal("	D21066	").Result;
                        plcitems.Act_pos10_4 = PLC_ReadReal("	D21068	").Result;
                        plcitems.Act_pos10_5 = PLC_ReadReal("	D21070	").Result;
                        plcitems.Act_pos10_6 = PLC_ReadReal("	D21072	").Result;
                        plcitems.Act_pos10_7 = PLC_ReadReal("	D21074	").Result;
                        plcitems.Act_pos10_8 = PLC_ReadReal("	D21076	").Result;
                        plcitems.Act_pos10_9 = PLC_ReadReal("	D21078	").Result;
                        plcitems.Act_Speed10_2 = PLC_ReadReal("	D21046	").Result;
                        plcitems.Act_Speed10_3 = PLC_ReadReal("	D21048	").Result;
                        plcitems.Act_Speed10_4 = PLC_ReadReal("	D21050	").Result;
                        plcitems.Act_Speed10_5 = PLC_ReadReal("	D21052	").Result;
                        plcitems.Act_Speed10_6 = PLC_ReadReal("	D21054	").Result;
                        plcitems.Act_Speed10_7 = PLC_ReadReal("	D21056	").Result;
                        plcitems.Act_Speed10_8 = PLC_ReadReal("	D21058	").Result;

                    }
                });

            }



        }
        private void GET_AsixValue11(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 11
                        
                        plcitems.Act_acc11 = PLC_ReadReal("D21104").Result;
                        plcitems.Act_dec11 = PLC_ReadReal("D21104").Result;
                        plcitems.Act_autoSpeed11 = PLC_ReadReal("D21160").Result;
                        plcitems.Act_manauSpeed11 = PLC_ReadReal("D21162").Result;
                        plcitems.Act_pos11 = PLC_ReadReal("D21140").Result;
                        plcitems.Act_pos1_11 = PLC_ReadReal("D21142").Result;
                        plcitems.Act_pos2_11 = PLC_ReadReal("D21144").Result;
                        #endregion
                        plcitems.Act_pos11_3 = PLC_ReadReal("	D21166	").Result;
                        plcitems.Act_pos11_4 = PLC_ReadReal("	D21168	").Result;
                        plcitems.Act_pos11_5 = PLC_ReadReal("D21170	").Result;
                        plcitems.Act_pos11_6 = PLC_ReadReal("D21172	").Result;
                        plcitems.Act_pos11_7 = PLC_ReadReal("D21174	").Result;
                        plcitems.Act_pos11_8 = PLC_ReadReal("D21176	").Result;
                        plcitems.Act_pos11_9 = PLC_ReadReal("D21178	").Result;
                        plcitems.Act_Speed11_2 = PLC_ReadReal("	D21146	").Result;
                        plcitems.Act_Speed11_3 = PLC_ReadReal("	D21148	").Result;
                        plcitems.Act_Speed11_4 = PLC_ReadReal("	D21150	").Result;
                        plcitems.Act_Speed11_5 = PLC_ReadReal("	D21152	").Result;
                        plcitems.Act_Speed11_6 = PLC_ReadReal("	D21154	").Result;
                        plcitems.Act_Speed11_7 = PLC_ReadReal("	D21156	").Result;
                        plcitems.Act_Speed11_8 = PLC_ReadReal("	D21158	").Result;
                    }
                });

            }



        }
        private void GET_AsixValue12(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        #region 12
                        
                        plcitems.Act_acc12 = PLC_ReadReal("D21204").Result;
                        plcitems.Act_dec12 = PLC_ReadReal("D21204").Result;
                        plcitems.Act_autoSpeed12 = PLC_ReadReal("D21260").Result;
                        plcitems.Act_manauSpeed12 = PLC_ReadReal("D21262").Result;
                        plcitems.Act_pos12 = PLC_ReadReal("D21240").Result;
                        plcitems.Act_pos1_12 = PLC_ReadReal("D21242").Result;
                        plcitems.Act_pos2_12 = PLC_ReadReal("D21244").Result;
                        #endregion
                        plcitems.Act_pos12_2 = PLC_ReadReal("	D21264	").Result;
                        plcitems.Act_pos12_3 = PLC_ReadReal("	D21266	").Result;
                        plcitems.Act_pos12_4 = PLC_ReadReal("	D21268	").Result;
                        plcitems.Act_pos12_5 = PLC_ReadReal("	D21270	").Result;
                        plcitems.Act_pos12_6 = PLC_ReadReal("	D21272	").Result;
                        plcitems.Act_pos12_7 = PLC_ReadReal("	D21274	").Result;
                        plcitems.Act_pos12_8 = PLC_ReadReal("	D21276	").Result;
                        plcitems.Act_pos12_9 = PLC_ReadReal("	D21278	").Result;
                        plcitems.Act_Speed12_2 = PLC_ReadReal("	D21246	").Result;
                        plcitems.Act_Speed12_3 = PLC_ReadReal("	D21248	").Result;
                        plcitems.Act_Speed12_4 = PLC_ReadReal("	D21250	").Result;
                        plcitems.Act_Speed12_5 = PLC_ReadReal("	D21252	").Result;
                        plcitems.Act_Speed12_6 = PLC_ReadReal("	D21254	").Result;
                        plcitems.Act_Speed12_7 = PLC_ReadReal("	D21256	").Result;
                        plcitems.Act_Speed12_8 = PLC_ReadReal("	D21258	").Result;
                    }
                });

            }



        }
        private void GET_AsixValue13(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {



                        #region 13
                        
                        plcitems.Act_acc13 = PLC_ReadReal("D21304").Result;
                        plcitems.Act_dec13 = PLC_ReadReal("D21304").Result;
                        plcitems.Act_autoSpeed13 = PLC_ReadReal("D21360").Result;
                        plcitems.Act_manauSpeed13 = PLC_ReadReal("D21362").Result;
                        plcitems.Act_pos13 = PLC_ReadReal("D21340").Result;
                        plcitems.Act_pos1_13 = PLC_ReadReal("D21342").Result;
                        plcitems.Act_pos2_13 = PLC_ReadReal("D21344").Result;
                        #endregion

                        plcitems.Act_pos13_3 = PLC_ReadReal("	D21366	").Result;
                        plcitems.Act_pos13_4 = PLC_ReadReal("	D21368	").Result;
                        plcitems.Act_pos13_5 = PLC_ReadReal("D21370	").Result;
                        plcitems.Act_pos13_6 = PLC_ReadReal("D21372	").Result;
                        plcitems.Act_pos13_7 = PLC_ReadReal("D21374	").Result;
                        plcitems.Act_pos13_8 = PLC_ReadReal("D21376	").Result;
                        plcitems.Act_pos13_9 = PLC_ReadReal("D21378	").Result;
                        plcitems.Act_Speed13_2 = PLC_ReadReal("	D21346	").Result;
                        plcitems.Act_Speed13_3 = PLC_ReadReal("	D21348	").Result;
                        plcitems.Act_Speed13_4 = PLC_ReadReal("	D21350	").Result;
                        plcitems.Act_Speed13_5 = PLC_ReadReal("	D21352	").Result;
                        plcitems.Act_Speed13_6 = PLC_ReadReal("	D21354	").Result;
                        plcitems.Act_Speed13_7 = PLC_ReadReal("	D21356	").Result;
                        plcitems.Act_Speed13_8 = PLC_ReadReal("	D21358	").Result;
                    }
                });

            }



        }
        private void GET_AsixValue14(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {


                        #region 14
                       
                        plcitems.Act_acc14 = PLC_ReadReal("D21404").Result;
                        plcitems.Act_dec14 = PLC_ReadReal("D21404").Result;
                        plcitems.Act_autoSpeed14 = PLC_ReadReal("D21360").Result;
                        plcitems.Act_manauSpeed14 = PLC_ReadReal("D21362").Result;
                        plcitems.Act_pos14 = PLC_ReadReal("D21440").Result;
                        plcitems.Act_pos1_14 = PLC_ReadReal("D21442").Result;
                        plcitems.Act_pos2_14 = PLC_ReadReal("D21444").Result;
                        #endregion

                        plcitems.Act_pos14_2 = PLC_ReadReal("	D21464	").Result;
                        plcitems.Act_pos14_3 = PLC_ReadReal("	D21466	").Result;
                        plcitems.Act_pos14_4 = PLC_ReadReal("	D21468	").Result;
                        plcitems.Act_pos14_5 = PLC_ReadReal("	D21470	").Result;
                        plcitems.Act_pos14_6 = PLC_ReadReal("	D21472	").Result;
                        plcitems.Act_pos14_7 = PLC_ReadReal("	D21474	").Result;
                        plcitems.Act_pos14_8 = PLC_ReadReal("	D21476	").Result;
                        plcitems.Act_pos14_9 = PLC_ReadReal("	D21478	").Result;
                        plcitems.Act_Speed14_2 = PLC_ReadReal(" D21446	").Result;
                        plcitems.Act_Speed14_3 = PLC_ReadReal("	D21448	").Result;
                        plcitems.Act_Speed14_4 = PLC_ReadReal("	D21450	").Result;
                        plcitems.Act_Speed14_5 = PLC_ReadReal("	D21452	").Result;
                        plcitems.Act_Speed14_6 = PLC_ReadReal("	D21454	").Result;
                        plcitems.Act_Speed14_7 = PLC_ReadReal("	D21456	").Result;
                        plcitems.Act_Speed14_8 = PLC_ReadReal("	D21458	").Result;
                    }
                });

            }



        }
        private void GET_AsixValue15(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 15
                       
                        plcitems.Act_acc15 = PLC_ReadReal("D21404").Result;
                        plcitems.Act_dec15 = PLC_ReadReal("D21404").Result;
                        plcitems.Act_autoSpeed15 = PLC_ReadReal("D21460").Result;
                        plcitems.Act_manauSpeed15 = PLC_ReadReal("D21462").Result;
                        plcitems.Act_pos15 = PLC_ReadReal("D21540").Result;
                        plcitems.Act_pos1_15 = PLC_ReadReal("D21542").Result;
                        plcitems.Act_pos2_15 = PLC_ReadReal("D21544").Result;
                        #endregion

                        plcitems.Act_pos15_3 = PLC_ReadReal("	D21566	").Result;
                        plcitems.Act_pos15_4 = PLC_ReadReal("	D21568	").Result;
                        plcitems.Act_pos15_5 = PLC_ReadReal("D21570	").Result;
                        plcitems.Act_pos15_6 = PLC_ReadReal("D21572	").Result;
                        plcitems.Act_pos15_7 = PLC_ReadReal("D21574	").Result;
                        plcitems.Act_pos15_8 = PLC_ReadReal("D21576	").Result;
                        plcitems.Act_pos15_9 = PLC_ReadReal("D21578	").Result;
                        plcitems.Act_Speed15_2 = PLC_ReadReal("	D21546	").Result;
                        plcitems.Act_Speed15_3 = PLC_ReadReal("	D21548	").Result;
                        plcitems.Act_Speed15_4 = PLC_ReadReal("	D21550	").Result;
                        plcitems.Act_Speed15_5 = PLC_ReadReal("	D21552	").Result;
                        plcitems.Act_Speed15_6 = PLC_ReadReal("	D21554	").Result;
                        plcitems.Act_Speed15_7 = PLC_ReadReal("	D21556	").Result;
                        plcitems.Act_Speed15_8 = PLC_ReadReal("	D21558	").Result;
                    }
                });

            }



        }
        private void GET_AsixValue16(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    if (EtherNetPLC_State)
                    {

                        #region 16
                       
                        plcitems.Act_acc16 = PLC_ReadReal("D21504").Result;
                        plcitems.Act_dec16 = PLC_ReadReal("D21504").Result;
                        plcitems.Act_autoSpeed16 = PLC_ReadReal("D21560").Result;
                        plcitems.Act_manauSpeed16 = PLC_ReadReal("D21562").Result;
                        plcitems.Act_pos16 = PLC_ReadReal("D21640").Result;
                        plcitems.Act_pos1_16 = PLC_ReadReal("D21642").Result;
                        plcitems.Act_pos2_16 = PLC_ReadReal("D21644").Result;
                        #endregion


                        plcitems.Act_pos16_2 = PLC_ReadReal("	D21664	").Result;
                        plcitems.Act_pos16_3 = PLC_ReadReal("	D21666	").Result;
                        plcitems.Act_pos16_4 = PLC_ReadReal("	D21668	").Result;
                        plcitems.Act_pos16_5 = PLC_ReadReal("	D21670	").Result;
                        plcitems.Act_pos16_6 = PLC_ReadReal("	D21672	").Result;
                        plcitems.Act_pos16_7 = PLC_ReadReal("	D21674	").Result;
                        plcitems.Act_pos16_8 = PLC_ReadReal("	D21676	").Result;
                        plcitems.Act_pos16_9 = PLC_ReadReal("	D21678	").Result;
                        plcitems.Act_Speed16_2 = PLC_ReadReal("	D21646	").Result;
                        plcitems.Act_Speed16_3 = PLC_ReadReal("	D21648	").Result;
                        plcitems.Act_Speed16_4 = PLC_ReadReal("	D21650	").Result;
                        plcitems.Act_Speed16_5 = PLC_ReadReal("	D21652	").Result;
                        plcitems.Act_Speed16_6 = PLC_ReadReal("	D21654	").Result;
                        plcitems.Act_Speed16_7 = PLC_ReadReal("	D21656	").Result;
                        plcitems.Act_Speed16_8 = PLC_ReadReal("	D21658	").Result;
                    }
                });

            }



        }
        #endregion
        #region 
        public ConnectPlc1()
        {
            dataflash();
            Plc_EtherNetPLC("192.168.250.100");
            PLC_Readitems(EtherNetPLC_State);
            PLC_Readitems5S(EtherNetPLC_State);
            PLC_Readitem(EtherNetPLC_State);
            PLC_Readitems_2s(EtherNetPLC_State);

        }
        private void  PLC_Readitems(bool EtherNetPLC_State)
        {
           
            if(EtherNetPLC_State)
            {
              Task.Run(async () =>
                {

                    while (EtherNetPLC_State)
                    {
                        plcitems.Erroor_Code0 = PLC_ReadReal("D20080").Result;
                        plcitems.Erroor_Code1 = PLC_ReadReal("D20180").Result;
                        plcitems.Erroor_Code2 = PLC_ReadReal("D20280").Result;
                        plcitems.Erroor_Code3 = PLC_ReadReal("D20380").Result;
                        plcitems.Erroor_Code4 = PLC_ReadReal("D20480").Result;
                        plcitems.Erroor_Code5 = PLC_ReadReal("D20580").Result;
                        plcitems.Erroor_Code6 = PLC_ReadReal("D20680").Result;
                        plcitems.Erroor_Code7 = PLC_ReadReal("D20780").Result;
                        plcitems.Erroor_Code8 = PLC_ReadReal("D20880").Result;
                        plcitems.Erroor_Code9 = PLC_ReadReal("D20980").Result;
                        plcitems.Erroor_Code10 = PLC_ReadReal("D21080").Result;
                        plcitems.Erroor_Code11 = PLC_ReadReal("D21180").Result;
                        plcitems.Erroor_Code12 = PLC_ReadReal("D21280").Result;
                        plcitems.Erroor_Code13 = PLC_ReadReal("D21380").Result;
                        plcitems.Erroor_Code14 = PLC_ReadReal("D21480").Result;
                        plcitems.Erroor_Code15 = PLC_ReadReal("D21580").Result;
                        plcitems.Erroor_Code16 = PLC_ReadReal("D21680").Result;
                        Thread.Sleep(1000);

                    }




                });

            }



        }
        private void PLC_Readitems5S(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(async () =>
                {

                    while (EtherNetPLC_State)
                    {

                        plcitems.FH_U = PLC_ReadReal("D30076").Result;
                        plcitems.FH_V = PLC_ReadReal("D30078").Result;
                        plcitems.FH_W = PLC_ReadReal("D30080").Result;
                        plcitems.Tab_U = PLC_ReadReal("D30126").Result;
                        plcitems.Tab_V = PLC_ReadReal("D30128").Result;
                        plcitems.Tab_W = PLC_ReadReal("D30130").Result;
                        Thread.Sleep(500);

                    }




                });

            }



        }
        public void PLC_Readitems_2s(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    while (EtherNetPLC_State)
                    {
                        #region
                        plcitems.Act_Pos0 = PLC_ReadReal("D20082").Result;
                        plcitems.Act_Pos1 = PLC_ReadReal("D20182").Result;
                        plcitems.Act_Pos2 = PLC_ReadReal("D20282").Result;
                        plcitems.Act_Pos3 = PLC_ReadReal("D20382").Result;
                        plcitems.Act_Pos4 = PLC_ReadReal("D20482").Result;
                        plcitems.Act_Pos5 = PLC_ReadReal("D20582").Result;
                        plcitems.Act_Pos6 = PLC_ReadReal("D20682").Result;
                        plcitems.Act_Pos7 = PLC_ReadReal("D20782").Result;
                        plcitems.Act_Pos8 = PLC_ReadReal("D20882").Result;
                        plcitems.Act_Pos9 = PLC_ReadReal("D20982").Result;
                        plcitems.Act_Pos10 = PLC_ReadReal("D21082").Result;
                        plcitems.Act_Pos11 = PLC_ReadReal("D21182").Result;
                        plcitems.Act_Pos12 = PLC_ReadReal("D21282").Result;
                        plcitems.Act_Pos13 = PLC_ReadReal("D21382").Result;
                        plcitems.Act_Pos14 = PLC_ReadReal("D21482").Result;
                        plcitems.Act_Pos15 = PLC_ReadReal("D21582").Result;
                        plcitems.Act_Pos16 = PLC_ReadReal("D21682").Result;
                        #endregion
                        Thread.Sleep(200);
                    }

                    ;


                });

            }



        }
        public void PLC_Readitem(bool EtherNetPLC_State)
        {

            if (true) //EtherNetPLC_State
            {
                Task.Run(() =>
                {

                    while (EtherNetPLC_State)//true
                    {

                        #region word
                        ////plcitems.outputCio_0 = PLC_ReadWords("10", 1)[0];
                        //  plcitems.outputCio_1 = PLC_ReadWordD("W313").Result;
                        //plcitems.outputCio_2 = PLC_ReadWordD("W12").Result;
                        //////plcitems.outputCio_3 = PLC_ReadWords("13", 1)[0];
                        //////plcitems.outputCio_4 = PLC_ReadWords("14", 1)[0];
                        //////plcitems.outputCio_0 = PLC_ReadWords("15", 1)[0];
                        //plcitems.Vision_Command0 = PLC_ReadWordD("D30000").Result;
                        //plcitems.Vision_Command0_1 = PLC_ReadWordD("D30001").Result;
                        //plcitems.Vision_Command0_2 = PLC_ReadWordD("D30002").Result;
                        //plcitems.Vision_Command1 = PLC_ReadWordD("D30050").Result;
                        //plcitems.Vision_Command1_1 = PLC_ReadWordD("D30051").Result;
                        //plcitems.Vision_Command1_2 = PLC_ReadWordD("D30052").Result;
                        //plcitems.Vision_Command2 = PLC_ReadWordD("D30100").Result;
                        //plcitems.Vision_Command2_1 = PLC_ReadWordD("D30101").Result;
                        //plcitems.Vision_Command2_2 = PLC_ReadWordD("D30102").Result;
                      //  Get_Asix00 = plcitems.Get1_Asix00;
                        #endregion
                        Thread.Sleep(500);
                    }




                });

            }



        }
        #endregion
        #region 刷新数据
        private void dataflash()
        {
            Task.Run(() =>
            {

                while (EtherNetPLC_State)
                {
                    Get_Asix00 = plcitems.Get1_Asix00;
                    Get_Asix01 = plcitems.Get1_Asix01;
                    Get_Asix02 = plcitems.Get1_Asix02;
                    Get_Asix03 = plcitems.Get1_Asix03;
                    Get_Asix04 = plcitems.Get1_Asix04;
                    Get_Asix05 = plcitems.Get1_Asix05;
                    Get_Asix06 = plcitems.Get1_Asix06;
                    Get_Asix07 = plcitems.Get1_Asix07;
                    Get_Asix08 = plcitems.Get1_Asix08;
                    Get_Asix09 = plcitems.Get1_Asix09;
                    Get_Asix10 = plcitems.Get1_Asix10;
                    Get_Asix11 = plcitems.Get1_Asix11;
                    Get_Asix12 = plcitems.Get1_Asix12;
                    Get_Asix13 = plcitems.Get1_Asix13;
                    Get_Asix14 = plcitems.Get1_Asix14;
                    Get_Asix15 = plcitems.Get1_Asix15;
                    Get_Asix16 = plcitems.Get1_Asix16;
                    Set_Asix00 = plcitems.Set1_Asix00;
                    Set_Asix00 = plcitems.Set1_Asix00;
                    Set_Asix01 = plcitems.Set1_Asix01;
                    Set_Asix02 = plcitems.Set1_Asix02;
                    Set_Asix03 = plcitems.Set1_Asix03;
                    Set_Asix04 = plcitems.Set1_Asix04;
                    Set_Asix05 = plcitems.Set1_Asix05;
                    Set_Asix06 = plcitems.Set1_Asix06;
                    Set_Asix07 = plcitems.Set1_Asix07;
                    Set_Asix08 = plcitems.Set1_Asix08;
                    Set_Asix09 = plcitems.Set1_Asix09;
                    Set_Asix10 = plcitems.Set1_Asix10;
                    Set_Asix11 = plcitems.Set1_Asix11;
                    Set_Asix12 = plcitems.Set1_Asix12;
                    Set_Asix13 = plcitems.Set1_Asix13;
                    Set_Asix14 = plcitems.Set1_Asix14;
                    Set_Asix15 = plcitems.Set1_Asix15;
                    Set_Asix16 = plcitems.Set1_Asix16;
                    Thread.Sleep(500);
                }
            });

        }
    
        #endregion
        public void Handle(string message)
        {
            Get_Asix00= message;
        }

       
        }
}