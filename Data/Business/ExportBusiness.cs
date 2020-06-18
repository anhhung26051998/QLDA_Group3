using Data.Connect;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Data.Business
{
    public class ExportBusiness:GenericBusiness
    {
        public ExportBusiness(QLDAEntities context = null):base()
        {
        }

        public ExcelPackage Export()
        {
            FileInfo file = new FileInfo(HttpContext.Current.Server.MapPath(@"/Template/Tonghopduan.xlsx"));
            ExcelPackage pack = new ExcelPackage(file);
            ExcelWorksheet sheet = pack.Workbook.Worksheets[0];
            int row = 13;
            int no = 1;
            var data = cnn.tbl_duan.Select(u => u).ToList();
            if (data != null && data.Count() > 0)
            {
                foreach (var dt in data)
                {
                    sheet.Cells[row, 1].Value = no;
                    sheet.Cells[row, 2].Value = dt.Tenduan;
                    sheet.Cells[row, 3].Value = dt.Diadiemthuchien;
                    sheet.Cells[row, 4].Value = dt.code;
                    sheet.Cells[row, 5].Value = dt.tbl_hinhthucqlda.TenhinhthucQLDA;
                    sheet.Cells[row, 6].Value = cnn.tbl_chudautu.Where(u=>u.ID==dt.IdChudautu).Select(c=>c.TenCDT);
                    sheet.Cells[row, 7].Value = dt.QDduyetCTDT;
                    sheet.Cells[row, 8].Value = dt.tbl_von.Select(u=>u.Tenvon);
                    sheet.Cells[row, 9].Value = dt.QDpheduyetDADT;
                    sheet.Cells[row, 10].Value = dt.Tongmucdautu;
                    sheet.Cells[row, 11].Value = dt.Tongmucdautu;
                    sheet.Cells[row, 12].Value = dt.tbl_von.Select(u=>u.Landieuchinh);
                    sheet.Cells[row, 13].Value = dt.QDpheduyetDADT;
                    sheet.Cells[row, 14].Value = dt.Tongmucdautu;
                    sheet.Cells[row, 15].Value = dt.Tongmucdautu;
                    sheet.Cells[row, 16].Value = dt.nam_khoicong+" - "+dt.nam_hoanthanh;
                    sheet.Cells[row, 17].Value = dt.Tongmucdautu;
                    sheet.Cells[row, 18].Value = dt.Tongmucdautu;
                    row++;
                    no++;
                }
            }
            return pack;
        }
    }
}