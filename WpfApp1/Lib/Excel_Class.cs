using System;
using Panuon.UI.Silver;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Enterwell.Clients.Wpf.Notifications;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Linq;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using WpfApp1.Resource;
using Notifications.Wpf;
using System.Windows.Input;
using System.Windows.Controls;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Threading;
using MaterialDesignThemes.Wpf;
using MaterialDesignColors;
using System.Windows.Media;

namespace WpfApp1.Lib
{
    class Excel_Class
    {
        #region  excel生成
        HSSFWorkbook HSSFWorkbook;
        HSSFWorkbook HSSFWorkbook_re;
        private FileStream FileStreamfile;
        string xlsfilename;
        public void xls_creat()
        {
            try
            {

                HSSFWorkbook = new HSSFWorkbook();
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "NPOI Team";
                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Subject = "NPOI SDK Example";
                HSSFWorkbook.DocumentSummaryInformation = dsi;
                HSSFWorkbook.SummaryInformation = si;
                ISheet hSSFSheet = HSSFWorkbook.CreateSheet("sheet1");
                xlsfilename = "excel/" + DateTime.Now.ToString("D") + ".xls";
                if (File.Exists(xlsfilename))
                {
                    //System.Windows.MessageBox.Show("该表已经存在");
                    //await ((MetroWindow)Application.Current.MainWindow).ShowMessageAsync("Wow, you typed Return and got", "该表已经存在");
                    ;
                }
                else //第一行数据设置
                {
                    ///创建单元格风格
                    ICellStyle hSSFCellStyle = HSSFWorkbook.CreateCellStyle();
                    //style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    hSSFCellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    hSSFCellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                    IRow rows = hSSFSheet.CreateRow(0);
                    rows.CreateCell(0).SetCellValue("Visition_XX");
                    rows.CreateCell(1).SetCellValue("Visition_YY");
                    rows.CreateCell(2).SetCellValue("Visition_UU");
                    rows.CreateCell(3).SetCellValue("XX");
                    rows.CreateCell(4).SetCellValue("YY");
                    rows.CreateCell(5).SetCellValue("UU");
                    //rows.CreateCell(6).SetCellValue("OK/NG");
                    using (FileStreamfile = new FileStream(xlsfilename, FileMode.Create))
                    {
                        HSSFWorkbook.Write(FileStreamfile);
                    };
                }
            }

            catch (Exception ex)
            {
                Log_Helper.Log_Error("", ex);
            }


        }
        #endregion
        public void Xls_write(int column_index, string data)
        {

            string str = "excel/" + DateTime.Now.ToString("D") + ".xls"; ;

            try
            {
                using (FileStream file = new FileStream(str, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    HSSFWorkbook_re = new HSSFWorkbook(file);//获取读取的文件
                    ISheet sheet = HSSFWorkbook_re.GetSheetAt(0);//读取第一个文档
                    int cellRows = sheet.LastRowNum;//读取最大行数 
                    ICell reult = sheet.GetRow(cellRows).GetCell(column_index);
                    IRow rows_frist = sheet.GetRow(cellRows);
                    ICellStyle HSSFCellStylecellStyle = HSSFWorkbook_re.CreateCellStyle();
                    HSSFCellStylecellStyle.DataFormat = HSSFDataFormat.GetBuiltinFormat("0.000");
                    if (reult == null)
                    {
                        ICellStyle cell_style = rows_frist.CreateCell(column_index).CellStyle;
                        rows_frist.CreateCell(column_index).SetCellValue(data);
                        cell_style = HSSFCellStylecellStyle;
                    }
                    else if (reult != null)
                    {
                        var cellrows1 = cellRows + 1;
                        IRow rows = sheet.CreateRow(cellrows1);
                        ICellStyle cell_style = rows.CreateCell(column_index).CellStyle;
                        cell_style = HSSFCellStylecellStyle;
                        rows.CreateCell(column_index).SetCellValue(data);
                    }

                    using (FileStreamfile = new FileStream(str, FileMode.Create))
                    {
                        HSSFWorkbook_re.Write(FileStreamfile);
                    };

                }
            }
            catch (Exception error)
            {
                Log_Helper.Log_Error("", error);
            }

        }
    }
}
