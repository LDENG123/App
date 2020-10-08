using System;
using OmronFinsTCP.Net;
using HslCommunication;
using HslCommunication.Profinet.Omron;
using System.ComponentModel;
using Panuon.UI.Silver;
using System.Threading.Tasks;
using System.Threading;

namespace WpfApp1.Lib
{
    class Connect_Plc : INotifyPropertyChanged
    {
        #region 通知
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #region
        public static Lib.Plcitems plcitems = new Plcitems();
        #endregion
        #region "PLC连接"
        /// <summary>
        /// 字段连接PLC
        /// </summary>
        EtherNetPLC EtherNetPLC;
        bool EtherNetPLC_State;
        private OmronFinsNet omronFinsNet;
        /// <summary>
        /// 连接PLC
        /// </summary>
        /// <param name="IPaddres0">远程PLC IP地址</param>
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
                                         //       OperateResult operateResult = omronFinsNet.ConnectServer();
                short return_value = EtherNetPLC.Link(IPaddress, short.Parse(IPPort), 1000);
                if (return_value == 0)//&& operateResult.IsSuccess
                {
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
        /// <summary>
        /// 读取real
        /// </summary>
        /// <param name="address">eg100:D100</param>
        /// <param name="return_value0">返回实数</param>
        public float PLC_ReadReal(short address)
        {
            float data0;
            short re = EtherNetPLC.ReadReal(PlcMemory.DM, address, out data0);
            return data0;
        }
        public void PLC_Readitems(bool EtherNetPLC_State)
        {

            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    while (EtherNetPLC_State)
                    {

                        #region word
                        //plcitems.outputCio_0 = PLC_ReadWords("10", 1)[0];
                        plcitems.outputCio_1 = PLC_ReadWord("300");
                        //plcitems.outputCio_2 = PLC_ReadWord1("12");
                        //plcitems.outputCio_3 = PLC_ReadWords("13", 1)[0];
                        //plcitems.outputCio_4 = PLC_ReadWords("14", 1)[0];
                        //plcitems.outputCio_0 = PLC_ReadWords("15", 1)[0];
                        plcitems.Vision_Command0 = PLC_ReadWordD("30000");
                        plcitems.Vision_Command0_1 = PLC_ReadWordD("30001");
                        plcitems.Vision_Command0_2 = PLC_ReadWordD("30002");
                        plcitems.Vision_Command1 = PLC_ReadWordD("30050");
                        plcitems.Vision_Command1_1 = PLC_ReadWordD("30051");
                        plcitems.Vision_Command1_2 = PLC_ReadWordD("30052");
                        plcitems.Vision_Command2 = PLC_ReadWordD("30100");
                        plcitems.Vision_Command2_1 = PLC_ReadWordD("30101");
                        plcitems.Vision_Command2_2 = PLC_ReadWordD("30102");
                        #endregion

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
                        plcitems.Act_Pos0 = PLC_ReadReal(20082);
                        plcitems.Act_Pos1 = PLC_ReadReal(20182);
                        plcitems.Act_Pos2 = PLC_ReadReal(20282);
                        plcitems.Act_Pos3 = PLC_ReadReal(20382);
                        plcitems.Act_Pos4 = PLC_ReadReal(20482);
                        plcitems.Act_Pos5 = PLC_ReadReal(20582);
                        plcitems.Act_Pos6 = PLC_ReadReal(20682);
                        plcitems.Act_Pos7 = PLC_ReadReal(20782);
                        plcitems.Act_Pos8 = PLC_ReadReal(20882);
                        plcitems.Act_Pos9 = PLC_ReadReal(20982);
                        plcitems.Act_Pos10 = PLC_ReadReal(21082);
                        plcitems.Act_Pos11 = PLC_ReadReal(21182);
                        plcitems.Act_Pos12 = PLC_ReadReal(21282);
                        plcitems.Act_Pos13 = PLC_ReadReal(21382);
                        plcitems.Act_Pos14 = PLC_ReadReal(21482);
                        plcitems.Act_Pos15 = PLC_ReadReal(21582);
                        plcitems.Act_Pos16 = PLC_ReadReal(21682);
                        #endregion
                        Thread.Sleep(200);
                    }

                    ;


                });

            }



        }
        public void PLC_Readitems1s(bool EtherNetPLC_State)
        {


            if (EtherNetPLC_State)
            {
                Task.Run(() =>
                {

                    while (EtherNetPLC_State)
                    {

                        #region real
                        #region 0
                        plcitems.Erroor_Code0 = PLC_ReadReal(20080);
                        plcitems.Act_acc0 = PLC_ReadReal(20004);
                        plcitems.Act_dec0 = PLC_ReadReal(20004);
                        plcitems.Act_autoSpeed0 = PLC_ReadReal(20060);
                        plcitems.Act_manauSpeed0 = PLC_ReadReal(20062);
                        plcitems.Act_pos0 = PLC_ReadReal(20040);
                        plcitems.Act_pos1_0 = PLC_ReadReal(20042);
                        plcitems.Act_pos2_0 = PLC_ReadReal(20044);
                        #endregion
                        #region 1
                        plcitems.Erroor_Code1 = PLC_ReadReal(20180);
                        plcitems.Act_acc1 = PLC_ReadReal(20004);
                        plcitems.Act_dec1 = PLC_ReadReal(20004);
                        plcitems.Act_autoSpeed1 = PLC_ReadReal(20160);
                        plcitems.Act_manauSpeed1 = PLC_ReadReal(20162);
                        plcitems.Act_pos1 = PLC_ReadReal(20140);
                        plcitems.Act_pos1_1 = PLC_ReadReal(20142);
                        plcitems.Act_pos2_1 = PLC_ReadReal(20144);
                        #endregion
                        #region 2
                        plcitems.Erroor_Code2 = PLC_ReadReal(20280);
                        plcitems.Act_acc2 = PLC_ReadReal(20004);
                        plcitems.Act_dec2 = PLC_ReadReal(20004);
                        plcitems.Act_autoSpeed2 = PLC_ReadReal(20260);
                        plcitems.Act_manauSpeed2 = PLC_ReadReal(20262);
                        plcitems.Act_pos2 = PLC_ReadReal(20240);
                        plcitems.Act_pos1_2 = PLC_ReadReal(20242);
                        plcitems.Act_pos2_2 = PLC_ReadReal(20244);
                        #endregion
                        #region 3
                        plcitems.Erroor_Code3 = PLC_ReadReal(20380);
                        plcitems.Act_acc3 = PLC_ReadReal(20004);
                        plcitems.Act_dec3 = PLC_ReadReal(20004);
                        plcitems.Act_autoSpeed3 = PLC_ReadReal(20360);
                        plcitems.Act_manauSpeed3 = PLC_ReadReal(20362);
                        plcitems.Act_pos3 = PLC_ReadReal(20340);
                        plcitems.Act_pos1_3 = PLC_ReadReal(20342);
                        plcitems.Act_pos2_3 = PLC_ReadReal(20344);
                        #endregion
                        #region 4
                        plcitems.Erroor_Code4 = PLC_ReadReal(20480);
                        plcitems.Act_acc4 = PLC_ReadReal(20004);
                        plcitems.Act_dec4 = PLC_ReadReal(20004);
                        plcitems.Act_autoSpeed4 = PLC_ReadReal(20460);
                        plcitems.Act_manauSpeed4 = PLC_ReadReal(20462);
                        plcitems.Act_pos4 = PLC_ReadReal(20440);
                        plcitems.Act_pos1_4 = PLC_ReadReal(20442);
                        plcitems.Act_pos2_4 = PLC_ReadReal(20444);
                        #endregion
                        #region 5
                        plcitems.Erroor_Code5 = PLC_ReadReal(20580);
                        plcitems.Act_acc5 = PLC_ReadReal(20504);
                        plcitems.Act_dec5 = PLC_ReadReal(20504);
                        plcitems.Act_autoSpeed5 = PLC_ReadReal(20560);
                        plcitems.Act_manauSpeed5 = PLC_ReadReal(20562);
                        plcitems.Act_pos5 = PLC_ReadReal(20540);
                        plcitems.Act_pos1_5 = PLC_ReadReal(20542);
                        plcitems.Act_pos2_5 = PLC_ReadReal(20544);
                        #endregion
                        #region 6
                        plcitems.Erroor_Code6 = PLC_ReadReal(20680);
                        plcitems.Act_acc6 = PLC_ReadReal(20604);
                        plcitems.Act_dec6 = PLC_ReadReal(20604);
                        plcitems.Act_autoSpeed6 = PLC_ReadReal(20660);
                        plcitems.Act_manauSpeed6 = PLC_ReadReal(20662);
                        plcitems.Act_pos6 = PLC_ReadReal(20640);
                        plcitems.Act_pos1_6 = PLC_ReadReal(20642);
                        plcitems.Act_pos2_6 = PLC_ReadReal(20644);
                        #endregion
                        #region 7
                        plcitems.Erroor_Code7 = PLC_ReadReal(20780);
                        plcitems.Act_acc7 = PLC_ReadReal(20704);
                        plcitems.Act_dec7 = PLC_ReadReal(20704);
                        plcitems.Act_autoSpeed7 = PLC_ReadReal(20760);
                        plcitems.Act_manauSpeed7 = PLC_ReadReal(20762);
                        plcitems.Act_pos7 = PLC_ReadReal(20740);
                        plcitems.Act_pos1_7 = PLC_ReadReal(20742);
                        plcitems.Act_pos2_7 = PLC_ReadReal(20744);
                        #endregion
                        #region 8
                        plcitems.Erroor_Code8 = PLC_ReadReal(20880);
                        plcitems.Act_acc8 = PLC_ReadReal(20804);
                        plcitems.Act_dec8 = PLC_ReadReal(20804);
                        plcitems.Act_autoSpeed8 = PLC_ReadReal(20860);
                        plcitems.Act_manauSpeed8 = PLC_ReadReal(20862);
                        plcitems.Act_pos8 = PLC_ReadReal(20840);
                        plcitems.Act_pos1_8 = PLC_ReadReal(20842);
                        plcitems.Act_pos2_8 = PLC_ReadReal(20844);
                        #endregion
                        #region 9
                        plcitems.Erroor_Code9 = PLC_ReadReal(20980);
                        plcitems.Act_acc9 = PLC_ReadReal(20904);
                        plcitems.Act_dec9 = PLC_ReadReal(20904);
                        plcitems.Act_autoSpeed9 = PLC_ReadReal(20960);
                        plcitems.Act_manauSpeed9 = PLC_ReadReal(20962);
                        plcitems.Act_pos9 = PLC_ReadReal(20940);
                        plcitems.Act_pos1_9 = PLC_ReadReal(20942);
                        plcitems.Act_pos2_9 = PLC_ReadReal(20944);
                        #endregion
                        #region 10
                        plcitems.Erroor_Code10 = PLC_ReadReal(21080);
                        plcitems.Act_acc10 = PLC_ReadReal(21004);
                        plcitems.Act_dec10 = PLC_ReadReal(21004);
                        plcitems.Act_autoSpeed10 = PLC_ReadReal(21060);
                        plcitems.Act_manauSpeed10 = PLC_ReadReal(21062);
                        plcitems.Act_pos10 = PLC_ReadReal(21040);
                        plcitems.Act_pos1_10 = PLC_ReadReal(21042);
                        plcitems.Act_pos2_10 = PLC_ReadReal(21044);
                        #endregion
                        #region 11
                        plcitems.Erroor_Code11 = PLC_ReadReal(21180);
                        plcitems.Act_acc11 = PLC_ReadReal(21104);
                        plcitems.Act_dec11 = PLC_ReadReal(21104);
                        plcitems.Act_autoSpeed11 = PLC_ReadReal(21160);
                        plcitems.Act_manauSpeed11 = PLC_ReadReal(21162);
                        plcitems.Act_pos11 = PLC_ReadReal(21140);
                        plcitems.Act_pos1_11 = PLC_ReadReal(21142);
                        plcitems.Act_pos2_11 = PLC_ReadReal(21144);
                        #endregion
                        #region 12
                        plcitems.Erroor_Code12 = PLC_ReadReal(21280);
                        plcitems.Act_acc12 = PLC_ReadReal(21204);
                        plcitems.Act_dec12 = PLC_ReadReal(21204);
                        plcitems.Act_autoSpeed12 = PLC_ReadReal(21260);
                        plcitems.Act_manauSpeed12 = PLC_ReadReal(21262);
                        plcitems.Act_pos12 = PLC_ReadReal(21240);
                        plcitems.Act_pos1_12 = PLC_ReadReal(21242);
                        plcitems.Act_pos2_12 = PLC_ReadReal(21244);
                        #endregion
                        #region 13
                        plcitems.Erroor_Code13 = PLC_ReadReal(21380);
                        plcitems.Act_acc13 = PLC_ReadReal(21304);
                        plcitems.Act_dec13 = PLC_ReadReal(21304);
                        plcitems.Act_autoSpeed13 = PLC_ReadReal(21360);
                        plcitems.Act_manauSpeed13 = PLC_ReadReal(21362);
                        plcitems.Act_pos13 = PLC_ReadReal(21340);
                        plcitems.Act_pos1_13 = PLC_ReadReal(21342);
                        plcitems.Act_pos2_13 = PLC_ReadReal(21344);
                        #endregion
                        #region 14
                        plcitems.Erroor_Code14 = PLC_ReadReal(21480);
                        plcitems.Act_acc14 = PLC_ReadReal(21404);
                        plcitems.Act_dec14 = PLC_ReadReal(21404);
                        plcitems.Act_autoSpeed14 = PLC_ReadReal(21360);
                        plcitems.Act_manauSpeed14 = PLC_ReadReal(21362);
                        plcitems.Act_pos14 = PLC_ReadReal(21440);
                        plcitems.Act_pos1_14 = PLC_ReadReal(21442);
                        plcitems.Act_pos2_14 = PLC_ReadReal(21444);
                        #endregion
                        #region 15
                        plcitems.Erroor_Code15 = PLC_ReadReal(21580);
                        plcitems.Act_acc15 = PLC_ReadReal(21404);
                        plcitems.Act_dec15 = PLC_ReadReal(21404);
                        plcitems.Act_autoSpeed15 = PLC_ReadReal(21460);
                        plcitems.Act_manauSpeed15 = PLC_ReadReal(21462);
                        plcitems.Act_pos15 = PLC_ReadReal(21540);
                        plcitems.Act_pos1_15 = PLC_ReadReal(21542);
                        plcitems.Act_pos2_15 = PLC_ReadReal(21544);
                        #endregion
                        #region 16
                        plcitems.Erroor_Code16 = PLC_ReadReal(21680);
                        plcitems.Act_acc16 = PLC_ReadReal(21504);
                        plcitems.Act_dec16 = PLC_ReadReal(21504);
                        plcitems.Act_autoSpeed16 = PLC_ReadReal(21560);
                        plcitems.Act_manauSpeed16 = PLC_ReadReal(21562);
                        plcitems.Act_pos16 = PLC_ReadReal(21640);
                        plcitems.Act_pos1_16 = PLC_ReadReal(21642);
                        plcitems.Act_pos2_16 = PLC_ReadReal(21644);
                        #endregion
                        #endregion
                        Thread.Sleep(1000);
                    }




                });

            }



        }
        /// <summary>
        /// 写入real
        /// </summary>
        /// <param name="address">eg100:D100</param>
        /// <param name="return_value0">写入实数</param>
        public void PLC_WriteReal(string address, float return_value1)
        {

            OperateResult return_date = omronFinsNet.Write(address, return_value1);
            if (return_date.IsSuccess)
            {
                Notice.Show("Success",
                                      "Plc 写入实数成功",
                                      1,
                                      MessageBoxIcon.Success);

            }
            else
            {
                Notice.Show("Warn",
                                       "Plc 写入实数失败",
                                       1,
                                       MessageBoxIcon.Warning);
            }

        }

        /// <summary>
        /// 连续读取16位的WORD
        /// </summary>
        /// <param name="address"> 读取地址D区偏移量eg:100为D100</param>
        /// <param name="count">读取偏移量多少eg:3;D100-D103</param>
        /// <param name="rd">返回数据16位的数组</param>
        public short[] PLC_ReadWords(string address, short count)
        {
            short[] rd;
            short re = EtherNetPLC.ReadWords(PlcMemory.WR, short.Parse(address), count, out rd);
            return rd;
        }
        /// <summary>
        /// 连续读取16位的WORD
        /// </summary>
        /// <param name="address"> 读取地址D区偏移量eg:100为D100</param>
        /// <param name="count">读取偏移量多少eg:3;D100-D103</param>
        /// <param name="rd">返回数据16位的数组</param>
        public short PLC_ReadWord(string address)
        {
            short rd;
            short re = EtherNetPLC.ReadWord(PlcMemory.WR, short.Parse(address), out rd);
            return rd;
        }
        public short PLC_ReadWordD(string address)
        {
            short rd;
            short re = EtherNetPLC.ReadWord(PlcMemory.DM, short.Parse(address), out rd);
            return rd;
        }
        public short PLC_ReadWord1(string address)
        {
            short rd;
            short re = EtherNetPLC.ReadWord(PlcMemory.DM, short.Parse(address), out rd);
            return rd;
        }
        /// <summary>
        /// 连续写入16位的WORD
        /// </summary>
        /// <param name="address"> 读取地址D区偏移量eg:100为D100</param>
        /// <param name="count">读取偏移量多少eg:3;D100-D103</param>
        /// <param name="wt">写入数据16位的数组</param>
        public void PLC_WriteWords(string address, string count, short[] wt)
        {

            short re = EtherNetPLC.WriteWords(PlcMemory.DM, short.Parse(address), short.Parse(count), wt);
            if (re == 0)
            {
                Notice.Show("Success",
                                      "Plc 连续写入Word成功",
                                      1,
                                      MessageBoxIcon.Success);

            }
            else
            {
                Notice.Show("Warn",
                                       "Plc 连续写入Word失败",
                                       1,
                                       MessageBoxIcon.Warning);
            }
        }/// <summary>
         /// 置位一个bit位
         /// </summary>
         /// <param name="bitAdd">eg102.00;w102.00 </param>
        public void PLC_SetBitState(string bitAdd)
        {

            short re = EtherNetPLC.SetBitState(PlcMemory.WR, bitAdd, BitState.OFF);
            if (re == 0)
            {
                Notice.Show("Success",
                                      "Plc 置位一个bit成功",
                                      1,
                                      MessageBoxIcon.Success);

            }
            else
            {
                Notice.Show("Warn",
                                       "Plc 置位一个bit失败",
                                       1,
                                       MessageBoxIcon.Warning);
            }

        }
        /// <summary>
        /// 读取一个BIT位
        /// </summary>
        /// <param name="bitAdd">eg102.00;w102.00 </param>
        /// <param name="bs"> 返回结果16位WORD</param>
        public short PLC_GetBitState(string bitAdd)
        {
            short value0;
            short re = EtherNetPLC.GetBitState(PlcMemory.WR, bitAdd, out value0);
            return value0;

        }
        #endregion

        public Connect_Plc()
        {

            Plc_EtherNetPLC("192.168.250.100");
            PLC_Readitems(EtherNetPLC_State);
            PLC_Readitems_2s(EtherNetPLC_State);
            PLC_Readitems1s(EtherNetPLC_State);


        }
    }
}
