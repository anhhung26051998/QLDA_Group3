using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Model
{
    public class TongMucDauTuModelOutput
    {
        public int Id { get; set; }
        public string Tenduan { get; set; }
        public string Nguonvon { get; set; }
        public string Landieuchinh { get; set; }
        public decimal? Thietbi { get; set; }
        public decimal? Xaylap { get; set; }
        public decimal? Tuvan { get; set; }
        public decimal? Quanliduan { get; set; }

        public decimal? Khac { get; set; }
        public decimal? Duphong { get; set; }
        public decimal? GPMB { get; set; }
        public decimal? Tongcong { get { return Thietbi + Xaylap + Tuvan + Quanliduan + Khac + Duphong + GPMB; } }
        public string Chitiet { get; set; }
      
    }
}