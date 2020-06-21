using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Model
{
    public class DuAnModelInput
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string Maduan { get; set; }
        public string Diadiemkhobac { get; set; }
        public Nullable<int> IdChudautu { get; set; }
        public string Tenduan { get; set; }
        public int IdhinhthucQLDA { get; set; }
        public int Idloainguonvon { get; set; }
        public string Diadiemthuchien { get; set; }
        public string QDpheduyetDADT { get; set; }
        public string QDduyetCTDT { get; set; }
        public string Ngaypheduyet { get; set; }
        public string NgaypheduyetCTDT { get; set; }
        public decimal Tongmucdautu { get; set; }
        public string Urlfile { get; set; }
        public string Motaduan { get; set; }
        public Nullable<int> thang_khoicong { get; set; }
        public Nullable<int> nam_khoicong { get; set; }
        public Nullable<int> thang_hoanthanh { get; set; }
        public Nullable<int> nam_hoanthanh { get; set; }
        public string Thoigiankhoicong { get; set; }
        public string Thoigianhoanthanh { get; set; }
        public string UrlMaps { get; set; }
        public Nullable<int> stt { get; set; }
        public Nullable<int> status { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
    }
}