using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Model
{
    public class TieuDaModelOuput
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string Tentieuda { get; set; }
        public string Chudautu { get; set; }
        public string Maduan { get; set; }
        public string Diadiem { get; set; }
        public string Ngaypheduyet { get; set; }
        public string Ngayhoanthan { get; set; }
        public decimal Tongmucdautu { get; set; }
        public string Mota { get; set; }

    }
    public class TieuDaCDTModelOutput
    {
        public int Id { get; set; }
        public string Tentieuda { get; set; }
        public string Loaivon { get; set; }
        public string Thoidoan { get; set; }
        public string Landieuchinh { get; set; }
        public int Giatri { get; set; }
    }
    public class TieuDuanDetailModelOuput
    {
        public int ID { get; set; }
        public Nullable<int> Maduan { get; set; }
        public Nullable<int> MaCDT { get; set; }
        public string Matieuduan { get; set; }
        public string Tentieuduan { get; set; }
        public string Diadiemkhobac { get; set; }
        public string Mota { get; set; }
        public string Nguoitao { get; set; }
        public string Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public string Ngaysua { get; set; }
        public Nullable<int> status { get; set; }
    }
    
}