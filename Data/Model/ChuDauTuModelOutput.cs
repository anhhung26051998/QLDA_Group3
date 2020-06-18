using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Model
{
    public class ChuDauTuModelOutput
    {
        public int Id { get; set; }
        public string Tenchudautu { get; set; }
    }
    public class SreachChuDauTuModelOuput:ChuDauTuModelOutput
    {
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
    public class DeTailChuDauTuModelOutput:SreachChuDauTuModelOuput
    {
        public  string Fax { get; set; }
        public string Website { get; set; }
        public string Nguoitao { get; set; }
        public string Emailnguoitao { get; set; }
        public string MaCDT { get; set; }
        public int? IdLoaiCDT { get; set; }
    }
}