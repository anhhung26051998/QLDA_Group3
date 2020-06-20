using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Model
{
    public class VonDieuChinhModelOutput
    {
        public int ID { get; set; }
        public Nullable<int> Mavon { get; set; }
        public Nullable<int> Landieuchinh { get; set; }
        public Nullable<int> state { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Ngaytao { get { return Date.HasValue ? Date.Value.ToString("dd/MM/yyyy") : ""; } }
        public Nullable<decimal> Giatritien { get; set; }
    }
}