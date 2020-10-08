using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Lib
{
    class Plcitems : INotifyPropertyChanged
    {
        #region 通知
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        public float FH_U { get; set; }
        public float Tab_U { get; set; }
        public float FH_V { get; set; }
        public float Tab_V { get; set; }
        public float FH_W { get; set; }
        public float Tab_W { get; set; }
        public float OK0 { get; set; }
        public float OK1 { get; set; }
        #region asix_par 
        #region 0
        public float Erroor_Code0 { get; set; }
        public float Act_Pos0 { get; set; }
        public float Act_autoSpeed0 { get; set; }
        public float Act_manauSpeed0 { get; set; }
        public float Act_acc0 { get; set; }
        public float Act_dec0 { get; set; }
        public float Act_pos0 { get; set; }
        public float Act_pos1_0 { get; set; }
        public float Act_pos2_0 { get; set; }
        public float Act_pos00_2 { get; set; }
        public float Act_pos00_3 { get; set; }
        public float Act_pos00_4 { get; set; }
        public float Act_pos00_5 { get; set; }
        public float Act_pos00_6 { get; set; }
        public float Act_pos00_7 { get; set; }
        public float Act_pos00_8 { get; set; }
        public float Act_pos00_9 { get; set; }
        public float Act_Speed00_2 { get; set; }
        public float Act_Speed00_3 { get; set; }
        public float Act_Speed00_4 { get; set; }
        public float Act_Speed00_5 { get; set; }
        public float Act_Speed00_6 { get; set; }
        public float Act_Speed00_7 { get; set; }
        public float Act_Speed00_8 { get; set; }
        public float Act_Speed00_9 { get; set; }


        #endregion
        #region 1
        public float Erroor_Code1 { get; set; }
        public float Act_Pos1 { get; set; }
        public float Act_autoSpeed1 { get; set; }
        public float Act_manauSpeed1 { get; set; }
        public float Act_acc1 { get; set; }
        public float Act_dec1 { get; set; }
        public float Act_pos1 { get; set; }
        public float Act_pos1_1 { get; set; }
        public float Act_pos2_1 { get; set; }
        public float Act_pos01_2 { get; set; }
        public float Act_pos01_3 { get; set; }
        public float Act_pos01_4 { get; set; }
        public float Act_pos01_5 { get; set; }
        public float Act_pos01_6 { get; set; }
        public float Act_pos01_7 { get; set; }
        public float Act_pos01_8 { get; set; }
        public float Act_pos01_9 { get; set; }
        public float Act_Speed01_2 { get; set; }
        public float Act_Speed01_3 { get; set; }
        public float Act_Speed01_4 { get; set; }
        public float Act_Speed01_5 { get; set; }
        public float Act_Speed01_6 { get; set; }
        public float Act_Speed01_7 { get; set; }
        public float Act_Speed01_8 { get; set; }
        public float Act_Speed01_9 { get; set; }



        #endregion
        #region 2
        public float Erroor_Code2 { get; set; }
        public float Act_Pos2 { get; set; }
        public float Act_autoSpeed2 { get; set; }
        public float Act_manauSpeed2 { get; set; }
        public float Act_acc2 { get; set; }
        public float Act_dec2 { get; set; }
        public float Act_pos2 { get; set; }
        public float Act_pos1_2 { get; set; }
        public float Act_pos2_2 { get; set; }
        public float Act_pos02_2 { get; set; }
        public float Act_pos02_3 { get; set; }
        public float Act_pos02_4 { get; set; }
        public float Act_pos02_5 { get; set; }
        public float Act_pos02_6 { get; set; }
        public float Act_pos02_7 { get; set; }
        public float Act_pos02_8 { get; set; }
        public float Act_pos02_9 { get; set; }
        public float Act_Speed02_2 { get; set; }
        public float Act_Speed02_3 { get; set; }
        public float Act_Speed02_4 { get; set; }
        public float Act_Speed02_5 { get; set; }
        public float Act_Speed02_6 { get; set; }
        public float Act_Speed02_7 { get; set; }
        public float Act_Speed02_8 { get; set; }
        public float Act_Speed02_9 { get; set; }


        #endregion
        #region 3
        public float Erroor_Code3 { get; set; }
        public float Act_Pos3 { get; set; }
        public float Act_autoSpeed3 { get; set; }
        public float Act_manauSpeed3 { get; set; }
        public float Act_acc3 { get; set; }
        public float Act_dec3 { get; set; }
        public float Act_pos3 { get; set; }
        public float Act_pos1_3 { get; set; }
        public float Act_pos2_3 { get; set; }
        public float Act_pos03_2 { get; set; }
        public float Act_pos03_3 { get; set; }
        public float Act_pos03_4 { get; set; }
        public float Act_pos03_5 { get; set; }
        public float Act_pos03_6 { get; set; }
        public float Act_pos03_7 { get; set; }
        public float Act_pos03_8 { get; set; }
        public float Act_pos03_9 { get; set; }
        public float Act_Speed03_2 { get; set; }
        public float Act_Speed03_3 { get; set; }
        public float Act_Speed03_4 { get; set; }
        public float Act_Speed03_5 { get; set; }
        public float Act_Speed03_6 { get; set; }
        public float Act_Speed03_7 { get; set; }
        public float Act_Speed03_8 { get; set; }
        public float Act_Speed03_9 { get; set; }

        #endregion
        #region 4
        public float Erroor_Code4 { get; set; }
        public float Act_Pos4 { get; set; }
        public float Act_autoSpeed4 { get; set; }
        public float Act_manauSpeed4 { get; set; }
        public float Act_acc4 { get; set; }
        public float Act_dec4 { get; set; }
        public float Act_pos4 { get; set; }
        public float Act_pos1_4 { get; set; }
        public float Act_pos2_4 { get; set; }
        public float Act_pos04_2 { get; set; }
        public float Act_pos04_3 { get; set; }
        public float Act_pos04_4 { get; set; }
        public float Act_pos04_5 { get; set; }
        public float Act_pos04_6 { get; set; }
        public float Act_pos04_7 { get; set; }
        public float Act_pos04_8 { get; set; }
        public float Act_pos04_9 { get; set; }
        public float Act_Speed04_2 { get; set; }
        public float Act_Speed04_3 { get; set; }
        public float Act_Speed04_4 { get; set; }
        public float Act_Speed04_5 { get; set; }
        public float Act_Speed04_6 { get; set; }
        public float Act_Speed04_7 { get; set; }
        public float Act_Speed04_8 { get; set; }
        public float Act_Speed04_9 { get; set; }

        #endregion
        #region 5
        public float Erroor_Code5 { get; set; }
        public float Act_Pos5 { get; set; }
        public float Act_autoSpeed5 { get; set; }
        public float Act_manauSpeed5 { get; set; }
        public float Act_acc5 { get; set; }
        public float Act_dec5 { get; set; }
        public float Act_pos5 { get; set; }
        public float Act_pos1_5 { get; set; }
        public float Act_pos2_5 { get; set; }
        public float Act_pos05_2 { get; set; }
        public float Act_pos05_3 { get; set; }
        public float Act_pos05_4 { get; set; }
        public float Act_pos05_5 { get; set; }
        public float Act_pos05_6 { get; set; }
        public float Act_pos05_7 { get; set; }
        public float Act_pos05_8 { get; set; }
        public float Act_pos05_9 { get; set; }
        public float Act_Speed05_2 { get; set; }
        public float Act_Speed05_3 { get; set; }
        public float Act_Speed05_4 { get; set; }
        public float Act_Speed05_5 { get; set; }
        public float Act_Speed05_6 { get; set; }
        public float Act_Speed05_7 { get; set; }
        public float Act_Speed05_8 { get; set; }
        public float Act_Speed05_9 { get; set; }

        #endregion
        #region 6
        public float Erroor_Code6 { get; set; }
        public float Act_Pos6 { get; set; }
        public float Act_autoSpeed6 { get; set; }
        public float Act_manauSpeed6 { get; set; }
        public float Act_acc6 { get; set; }
        public float Act_dec6 { get; set; }
        public float Act_pos6 { get; set; }
        public float Act_pos1_6 { get; set; }
        public float Act_pos2_6 { get; set; }
        public float Act_pos06_2 { get; set; }
        public float Act_pos06_3 { get; set; }
        public float Act_pos06_4 { get; set; }
        public float Act_pos06_5 { get; set; }
        public float Act_pos06_6 { get; set; }
        public float Act_pos06_7 { get; set; }
        public float Act_pos06_8 { get; set; }
        public float Act_pos06_9 { get; set; }
        public float Act_Speed06_2 { get; set; }
        public float Act_Speed06_3 { get; set; }
        public float Act_Speed06_4 { get; set; }
        public float Act_Speed06_5 { get; set; }
        public float Act_Speed06_6 { get; set; }
        public float Act_Speed06_7 { get; set; }
        public float Act_Speed06_8 { get; set; }
        public float Act_Speed06_9 { get; set; }

        #endregion
        #region 7
        public float Erroor_Code7 { get; set; }
        public float Act_Pos7 { get; set; }
        public float Act_autoSpeed7 { get; set; }
        public float Act_manauSpeed7 { get; set; }
        public float Act_acc7 { get; set; }
        public float Act_dec7 { get; set; }
        public float Act_pos7 { get; set; }
        public float Act_pos1_7 { get; set; }
        public float Act_pos2_7 { get; set; }
        public float Act_pos07_2 { get; set; }
        public float Act_pos07_3 { get; set; }
        public float Act_pos07_4 { get; set; }
        public float Act_pos07_5 { get; set; }
        public float Act_pos07_6 { get; set; }
        public float Act_pos07_7 { get; set; }
        public float Act_pos07_8 { get; set; }
        public float Act_pos07_9 { get; set; }
        public float Act_Speed07_2 { get; set; }
        public float Act_Speed07_3 { get; set; }
        public float Act_Speed07_4 { get; set; }
        public float Act_Speed07_5 { get; set; }
        public float Act_Speed07_6 { get; set; }
        public float Act_Speed07_7 { get; set; }
        public float Act_Speed07_8 { get; set; }
        public float Act_Speed07_9 { get; set; }

        #endregion
        #region 8
        public float Erroor_Code8 { get; set; }
        public float Act_Pos8 { get; set; }
        public float Act_autoSpeed8 { get; set; }
        public float Act_manauSpeed8 { get; set; }
        public float Act_acc8 { get; set; }
        public float Act_dec8 { get; set; }
        public float Act_pos8 { get; set; }
        public float Act_pos1_8 { get; set; }
        public float Act_pos2_8 { get; set; }
        public float Act_pos08_2 { get; set; }
        public float Act_pos08_3 { get; set; }
        public float Act_pos08_4 { get; set; }
        public float Act_pos08_5 { get; set; }
        public float Act_pos08_6 { get; set; }
        public float Act_pos08_7 { get; set; }
        public float Act_pos08_8 { get; set; }
        public float Act_pos08_9 { get; set; }
        public float Act_Speed08_2 { get; set; }
        public float Act_Speed08_3 { get; set; }
        public float Act_Speed08_4 { get; set; }
        public float Act_Speed08_5 { get; set; }
        public float Act_Speed08_6 { get; set; }
        public float Act_Speed08_7 { get; set; }
        public float Act_Speed08_8 { get; set; }
        public float Act_Speed08_9 { get; set; }

        #endregion
        #region 9
        public float Erroor_Code9 { get; set; }
        public float Act_Pos9 { get; set; }
        public float Act_autoSpeed9 { get; set; }
        public float Act_manauSpeed9 { get; set; }
        public float Act_acc9 { get; set; }
        public float Act_dec9 { get; set; }
        public float Act_pos9 { get; set; }
        public float Act_pos1_9 { get; set; }
        public float Act_pos2_9 { get; set; }
        public float Act_pos09_2 { get; set; }
        public float Act_pos09_3 { get; set; }
        public float Act_pos09_4 { get; set; }
        public float Act_pos09_5 { get; set; }
        public float Act_pos09_6 { get; set; }
        public float Act_pos09_7 { get; set; }
        public float Act_pos09_8 { get; set; }
        public float Act_pos09_9 { get; set; }
        public float Act_Speed09_2 { get; set; }
        public float Act_Speed09_3 { get; set; }
        public float Act_Speed09_4 { get; set; }
        public float Act_Speed09_5 { get; set; }
        public float Act_Speed09_6 { get; set; }
        public float Act_Speed09_7 { get; set; }
        public float Act_Speed09_8 { get; set; }
        public float Act_Speed09_9 { get; set; }

        #endregion
        #region 10
        public float Erroor_Code10 { get; set; }
        public float Act_Pos10 { get; set; }
        public float Act_autoSpeed10 { get; set; }
        public float Act_manauSpeed10 { get; set; }
        public float Act_acc10 { get; set; }
        public float Act_dec10 { get; set; }
        public float Act_pos10 { get; set; }
        public float Act_pos1_10 { get; set; }
        public float Act_pos2_10 { get; set; }
        public float Act_pos10_2 { get; set; }
        public float Act_pos10_3 { get; set; }
        public float Act_pos10_4 { get; set; }
        public float Act_pos10_5 { get; set; }
        public float Act_pos10_6 { get; set; }
        public float Act_pos10_7 { get; set; }
        public float Act_pos10_8 { get; set; }
        public float Act_pos10_9 { get; set; }
        public float Act_Speed10_2 { get; set; }
        public float Act_Speed10_3 { get; set; }
        public float Act_Speed10_4 { get; set; }
        public float Act_Speed10_5 { get; set; }
        public float Act_Speed10_6 { get; set; }
        public float Act_Speed10_7 { get; set; }
        public float Act_Speed10_8 { get; set; }
        public float Act_Speed10_9 { get; set; }

        #endregion
        #region 11
        public float Erroor_Code11 { get; set; }
        public float Act_Pos11 { get; set; }
        public float Act_autoSpeed11 { get; set; }
        public float Act_manauSpeed11 { get; set; }
        public float Act_acc11 { get; set; }
        public float Act_dec11 { get; set; }
        public float Act_pos11 { get; set; }
        public float Act_pos1_11 { get; set; }
        public float Act_pos2_11 { get; set; }
        public float Act_pos11_2 { get; set; }
        public float Act_pos11_3 { get; set; }
        public float Act_pos11_4 { get; set; }
        public float Act_pos11_5 { get; set; }
        public float Act_pos11_6 { get; set; }
        public float Act_pos11_7 { get; set; }
        public float Act_pos11_8 { get; set; }
        public float Act_pos11_9 { get; set; }
        public float Act_Speed11_2 { get; set; }
        public float Act_Speed11_3 { get; set; }
        public float Act_Speed11_4 { get; set; }
        public float Act_Speed11_5 { get; set; }
        public float Act_Speed11_6 { get; set; }
        public float Act_Speed11_7 { get; set; }
        public float Act_Speed11_8 { get; set; }
        public float Act_Speed11_9 { get; set; }

        #endregion
        #region 12
        public float Erroor_Code12 { get; set; }
        public float Act_Pos12 { get; set; }
        public float Act_autoSpeed12 { get; set; }
        public float Act_manauSpeed12 { get; set; }
        public float Act_acc12 { get; set; }
        public float Act_dec12 { get; set; }
        public float Act_pos12 { get; set; }
        public float Act_pos1_12 { get; set; }
        public float Act_pos2_12 { get; set; }
        public float Act_pos12_2 { get; set; }
        public float Act_pos12_3 { get; set; }
        public float Act_pos12_4 { get; set; }
        public float Act_pos12_5 { get; set; }
        public float Act_pos12_6 { get; set; }
        public float Act_pos12_7 { get; set; }
        public float Act_pos12_8 { get; set; }
        public float Act_pos12_9 { get; set; }
        public float Act_Speed12_2 { get; set; }
        public float Act_Speed12_3 { get; set; }
        public float Act_Speed12_4 { get; set; }
        public float Act_Speed12_5 { get; set; }
        public float Act_Speed12_6 { get; set; }
        public float Act_Speed12_7 { get; set; }
        public float Act_Speed12_8 { get; set; }
        public float Act_Speed12_9 { get; set; }

        #endregion
        #region 13
        public float Erroor_Code13 { get; set; }
        public float Act_Pos13 { get; set; }
        public float Act_autoSpeed13 { get; set; }
        public float Act_manauSpeed13 { get; set; }
        public float Act_acc13 { get; set; }
        public float Act_dec13 { get; set; }
        public float Act_pos13 { get; set; }
        public float Act_pos1_13 { get; set; }
        public float Act_pos2_13 { get; set; }
        public float Act_pos13_2 { get; set; }
        public float Act_pos13_3 { get; set; }
        public float Act_pos13_4 { get; set; }
        public float Act_pos13_5 { get; set; }
        public float Act_pos13_6 { get; set; }
        public float Act_pos13_7 { get; set; }
        public float Act_pos13_8 { get; set; }
        public float Act_pos13_9 { get; set; }
        public float Act_Speed13_2 { get; set; }
        public float Act_Speed13_3 { get; set; }
        public float Act_Speed13_4 { get; set; }
        public float Act_Speed13_5 { get; set; }
        public float Act_Speed13_6 { get; set; }
        public float Act_Speed13_7 { get; set; }
        public float Act_Speed13_8 { get; set; }
        public float Act_Speed13_9 { get; set; }

        #endregion
        #region 14
        public float Erroor_Code14 { get; set; }
        public float Act_Pos14 { get; set; }
        public float Act_autoSpeed14 { get; set; }
        public float Act_manauSpeed14 { get; set; }
        public float Act_acc14 { get; set; }
        public float Act_dec14 { get; set; }
        public float Act_pos14 { get; set; }
        public float Act_pos1_14 { get; set; }
        public float Act_pos2_14 { get; set; }
        public float Act_pos14_2 { get; set; }
        public float Act_pos14_3 { get; set; }
        public float Act_pos14_4 { get; set; }
        public float Act_pos14_5 { get; set; }
        public float Act_pos14_6 { get; set; }
        public float Act_pos14_7 { get; set; }
        public float Act_pos14_8 { get; set; }
        public float Act_pos14_9 { get; set; }
        public float Act_Speed14_2 { get; set; }
        public float Act_Speed14_3 { get; set; }
        public float Act_Speed14_4 { get; set; }
        public float Act_Speed14_5 { get; set; }
        public float Act_Speed14_6 { get; set; }
        public float Act_Speed14_7 { get; set; }
        public float Act_Speed14_8 { get; set; }
        public float Act_Speed14_9 { get; set; }

        #endregion
        #region 15
        public float Erroor_Code15 { get; set; }
        public float Act_Pos15 { get; set; }
        public float Act_autoSpeed15 { get; set; }
        public float Act_manauSpeed15 { get; set; }
        public float Act_acc15 { get; set; }
        public float Act_dec15 { get; set; }
        public float Act_pos15 { get; set; }
        public float Act_pos1_15 { get; set; }
        public float Act_pos2_15 { get; set; }
        public float Act_pos15_2 { get; set; }
        public float Act_pos15_3 { get; set; }
        public float Act_pos15_4 { get; set; }
        public float Act_pos15_5 { get; set; }
        public float Act_pos15_6 { get; set; }
        public float Act_pos15_7 { get; set; }
        public float Act_pos15_8 { get; set; }
        public float Act_pos15_9 { get; set; }
        public float Act_Speed15_2 { get; set; }
        public float Act_Speed15_3 { get; set; }
        public float Act_Speed15_4 { get; set; }
        public float Act_Speed15_5 { get; set; }
        public float Act_Speed15_6 { get; set; }
        public float Act_Speed15_7 { get; set; }
        public float Act_Speed15_8 { get; set; }
        public float Act_Speed15_9 { get; set; }

        #endregion
        #region  16
        public float Erroor_Code16 { get; set; }
        public float Act_Pos16 { get; set; }
        public float Act_autoSpeed16 { get; set; }
        public float Act_manauSpeed16 { get; set; }
        public float Act_acc16 { get; set; }
        public float Act_dec16 { get; set; }
        public float Act_pos16 { get; set; }
        public float Act_pos1_16 { get; set; }
        public float Act_pos2_16 { get; set; }
        public float Act_pos16_2 { get; set; }
        public float Act_pos16_3 { get; set; }
        public float Act_pos16_4 { get; set; }
        public float Act_pos16_5 { get; set; }
        public float Act_pos16_6 { get; set; }
        public float Act_pos16_7 { get; set; }
        public float Act_pos16_8 { get; set; }
        public float Act_pos16_9 { get; set; }
        public float Act_Speed16_2 { get; set; }
        public float Act_Speed16_3 { get; set; }
        public float Act_Speed16_4 { get; set; }
        public float Act_Speed16_5 { get; set; }
        public float Act_Speed16_6 { get; set; }
        public float Act_Speed16_7 { get; set; }
        public float Act_Speed16_8 { get; set; }
        public float Act_Speed16_9 { get; set; }

        #endregion
        #endregion

        #region I/O
        public int inputCio_0 { get; set; }
        public short inputCio_1 { get; set; }
        public int inputCio_2 { get; set; }
        public int inputCio_3 { get; set; }
        public int inputCio_4 { get; set; }
        public int inputCio_5 { get; set; }
        public int outputCio_0 { get; set; }
        public long outputCio_1 { get; set; }
        public int outputCio_2 { get; set; }
        public int outputCio_3 { get; set; }
        public int outputCio_4 { get; set; }
        public int outputCio_5 { get; set; }
        public int Vision_Tab0_0 { get; set; }
        public int Vision_Tab0_1 { get; set; }
        public int Vision_Tab0 { get; set; }
        public int Vision_Tab1_0 { get; set; }
        public int Vision_Tab1_1 { get; set; }
        public int Vision_Tab1 { get; set; }
        public int Vision_FM0_0 { get; set; }
        public int Vision_FM0_1 { get; set; }

        public int Vision_CM0_0 { get; set; }
        public int Vision_Command0 { get; set; }
        public int Vision_Command0_1 { get; set; }
        public int Vision_Command0_2 { get; set; }
        public int Vision_Command0_3 { get; set; }
        public int Vision_Command1 { get; set; }
        public int Vision_Command1_1 { get; set; }
        public int Vision_Command1_2 { get; set; }
        public int Vision_Command1_3 { get; set; }
        public int Vision_Command2 { get; set; }
        public int Vision_Command2_1 { get; set; }
        public int Vision_Command2_2 { get; set; }
        public int Vision_Command2_3 { get; set; }
        public int Vision_Triger { get; set; }

        #endregion

        #region  time
        public float Tab0_0 { get; set; }
        public float Tab0_1 { get; set; }
        public float Tab0_2 { get; set; }
        public float Tab0_3 { get; set; }
        public float Tab0_4 { get; set; }
        public float Tab0_5 { get; set; }
        public float Tab0_6 { get; set; }
        public float Tab0_7 { get; set; }
        public float Tab0_8 { get; set; }
        public float Tab0_9 { get; set; }
        public float Tab1_0 { get; set; }
        public float Tab1_1 { get; set; }
        public float Tab1_2 { get; set; }
        public float Tab1_3 { get; set; }
        public float Tab1_4 { get; set; }
        public float Tab1_5 { get; set; }
        public float Tab1_6 { get; set; }
        public float Tab1_7 { get; set; }
        public float Tab1_8 { get; set; }
        public float Tab1_9 { get; set; }
        #endregion
        #region  Count
        public float Count0_0 { get; set; }
        public float Count0_1 { get; set; }
        public float Count0_2 { get; set; }
        public float Count0_3 { get; set; }
        public float Count0_4 { get; set; }
        public float Count0_5 { get; set; }
        public float Count0_6 { get; set; }
        public float Count0_7 { get; set; }
        public float Count0_8 { get; set; }
        public float Count0_9 { get; set; }
        public float Count0_10 { get; set; }
        public float Count0_11 { get; set; }
        public float Count0_12 { get; set; }
        public float Count0_13 { get; set; }
        public float Count0_14 { get; set; }
        public float Count0_15 { get; set; }
        public float Count0_16 { get; set; }
        public float Count0_17 { get; set; }
        public float Count0_18 { get; set; }
        public float Count0_19 { get; set; }
        public float Count0_20 { get; set; }
        public float Count0_21 { get; set; }
        public float Count0_22 { get; set; }
        public float Count0_23 { get; set; }
        public float Count1_0 { get; set; }
        public float Count1_1 { get; set; }
        public float Count1_2 { get; set; }
        public float Count1_3 { get; set; }
        public float Count1_4 { get; set; }
        public float Count1_5 { get; set; }
        public float Count1_6 { get; set; }
        public float Count1_7 { get; set; }
        public float Count1_8 { get; set; }
        public float Count1_9 { get; set; }
        public float Count1_10 { get; set; }
        public float Count1_11 { get; set; }
        public float Count1_12 { get; set; }
        public float Count1_13 { get; set; }
        public float Count1_14 { get; set; }
        public float Count1_15 { get; set; }
        public float Count1_16 { get; set; }
        public float Count1_17 { get; set; }
        public float Count1_18 { get; set; }
        public float Count1_19 { get; set; }
        public float Count1_20 { get; set; }
        public float Count1_21 { get; set; }
        public float Count1_22 { get; set; }
        public float Count1_23 { get; set; }
        #endregion
        #region GET string 
      
        private string get1_Asix00;
        public string Get1_Asix00
        {
            get { return get1_Asix00; }
            set
            {

                get1_Asix00 = value;

                OnPropertyChanged(" Get1_Asix00");
            }
        }
        private string get1_Asix01;
        public string Get1_Asix01
        {
            get { return get1_Asix01; }
            set
            {

                get1_Asix01 = value;

                OnPropertyChanged(" Get1_Asix01");
            }
        }
        private string get1_Asix02;
        public string Get1_Asix02
        {
            get { return get1_Asix02; }
            set
            {

                get1_Asix02 = value;

                OnPropertyChanged(" Get1_Asix02");
            }
        }
        private string get1_Asix03;
        public string Get1_Asix03
        {
            get { return get1_Asix03; }
            set
            {

                get1_Asix03 = value;

                OnPropertyChanged(" Get1_Asix03");
            }
        }
        private string get1_Asix04;
        public string Get1_Asix04
        {
            get { return get1_Asix04; }
            set
            {

                get1_Asix04 = value;

                OnPropertyChanged(" Get1_Asix04");
            }
        }
        private string get1_Asix05;
        public string Get1_Asix05
        {
            get { return get1_Asix05; }
            set
            {

                get1_Asix05 = value;

                OnPropertyChanged(" Get1_Asix05");
            }
        }
        private string get1_Asix06;
        public string Get1_Asix06
        {
            get { return get1_Asix06; }
            set
            {

                get1_Asix06 = value;

                OnPropertyChanged(" Get1_Asix06");
            }
        }
        private string get1_Asix07;
        public string Get1_Asix07
        {
            get { return get1_Asix07; }
            set
            {

                get1_Asix07 = value;

                OnPropertyChanged(" Get1_Asix07");
            }
        }
        private string get1_Asix08;
        public string Get1_Asix08
        {
            get{ return get1_Asix08; }
            set
            {

                get1_Asix08 = value;

                OnPropertyChanged(" Get1_Asix08");
            }
        }
        private string get1_Asix09;
        public string Get1_Asix09
        {
            get { return get1_Asix09; }
            set
            {

                get1_Asix09 = value;

                OnPropertyChanged(" Get1_Asix09");
            }
        }
        private string get1_Asix10;
        public string Get1_Asix10
        {
            get { return get1_Asix10; }
            set
            {

                get1_Asix10 = value;

                OnPropertyChanged(" Get1_Asix10");
            }
        }


        private string get1_Asix11;
        public string Get1_Asix11
        {
            get { return get1_Asix11; }
            set
            {

                get1_Asix04 = value;

                OnPropertyChanged(" Get1_Asix11");
            }
        }

        private string get1_Asix12;
        public string Get1_Asix12
        {
            get { return get1_Asix12; }
            set
            {

                get1_Asix12 = value;

                OnPropertyChanged(" Get1_Asix12");
            }
        }
        private string get1_Asix13;
        public string Get1_Asix13
        {
            get { return get1_Asix13; }
            set
            {

                get1_Asix13 = value;

                OnPropertyChanged(" Get1_Asix13");
            }
        }
        private string get1_Asix14;
        public string Get1_Asix14
        {
            get { return get1_Asix14; }
            set
            {

                get1_Asix14 = value;

                OnPropertyChanged(" Get1_Asix14");
            }
        }
        private string get1_Asix15;
        public string Get1_Asix15
        {
            get { return get1_Asix15; }
            set
            {

                get1_Asix15 = value;

                OnPropertyChanged(" Get1_Asix15");
            }
        }
        private string get1_Asix16;
        public string Get1_Asix16
        {
            get { return get1_Asix16; }
            set
            {

                get1_Asix16 = value;

                OnPropertyChanged(" Get1_Asix16");
            }
        }

        #endregion
        #region SET string 

        private string set1_Asix00;
        public string Set1_Asix00
        {
            get { return set1_Asix00; }
            set
            {

                set1_Asix00 = value;

                OnPropertyChanged(" Set1_Asix00");
            }
        }
        private string set1_Asix01;
        public string Set1_Asix01
        {
            get { return set1_Asix01; }
            set
            {

                set1_Asix01 = value;

                OnPropertyChanged(" Set1_Asix01");
            }
        }
        private string set1_Asix02;
        public string Set1_Asix02
        {
            get { return set1_Asix02; }
            set
            {

                set1_Asix02 = value;

                OnPropertyChanged(" Set1_Asix02");
            }
        }
        private string set1_Asix03;
        public string Set1_Asix03
        {
            get { return set1_Asix03; }
            set
            {

                set1_Asix03 = value;

                OnPropertyChanged(" Set1_Asix03");
            }
        }
        private string set1_Asix04;
        public string Set1_Asix04
        {
            get { return set1_Asix04; }
            set
            {

                set1_Asix04 = value;

                OnPropertyChanged(" Set1_Asix04");
            }
        }
        private string set1_Asix05;
        public string Set1_Asix05
        {
            get { return set1_Asix05; }
            set
            {

                set1_Asix05 = value;

                OnPropertyChanged(" Set1_Asix05");
            }
        }
        private string set1_Asix06;
        public string Set1_Asix06
        {
            get { return set1_Asix06; }
            set
            {

                set1_Asix06 = value;

                OnPropertyChanged(" Set1_Asix06");
            }
        }
        private string set1_Asix07;
        public string Set1_Asix07
        {
            get { return set1_Asix07; }
            set
            {

                set1_Asix07 = value;

                OnPropertyChanged(" Set1_Asix07");
            }
        }
        private string set1_Asix08;
        public string Set1_Asix08
        {
            get { return set1_Asix08; }
            set
            {

                set1_Asix08 = value;

                OnPropertyChanged(" Set1_Asix08");
            }
        }
        private string set1_Asix09;
        public string Set1_Asix09
        {
            get { return set1_Asix09; }
            set
            {

                set1_Asix09 = value;

                OnPropertyChanged(" Set1_Asix09");
            }
        }
        private string set1_Asix10;
        public string Set1_Asix10
        {
            get { return set1_Asix10; }
            set
            {

                set1_Asix10 = value;

                OnPropertyChanged(" Set1_Asix10");
            }
        }


        private string set1_Asix11;
        public string Set1_Asix11
        {
            get { return set1_Asix11; }
            set
            {

                set1_Asix04 = value;

                OnPropertyChanged(" Set1_Asix11");
            }
        }

        private string set1_Asix12;
        public string Set1_Asix12
        {
            get { return set1_Asix12; }
            set
            {

                set1_Asix12 = value;

                OnPropertyChanged(" Set1_Asix12");
            }
        }
        private string set1_Asix13;
        public string Set1_Asix13
        {
            get { return set1_Asix13; }
            set
            {

                set1_Asix13 = value;

                OnPropertyChanged(" Set1_Asix13");
            }
        }
        private string set1_Asix14;
        public string Set1_Asix14
        {
            get { return set1_Asix14; }
            set
            {

                set1_Asix14 = value;

                OnPropertyChanged(" Set1_Asix14");
            }
        }
        private string set1_Asix15;
        public string Set1_Asix15
        {
            get { return set1_Asix15; }
            set
            {

                set1_Asix15 = value;

                OnPropertyChanged(" Set1_Asix15");
            }
        }
        private string set1_Asix16;
        public string Set1_Asix16
        {
            get { return set1_Asix16; }
            set
            {

                set1_Asix16 = value;

                OnPropertyChanged(" Set1_Asix16");
            }
        }

        #endregion
    }
}
