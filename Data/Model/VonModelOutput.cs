using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Model
{
    public class VonModelOutput
    {
        public int ID { get; set; }
        public string Mavon { get; set; }
        public string Tenvon { get; set; }
        public string Tenduan { get; set; }
        public Nullable<int> Maduan { get; set; }
        public Nullable<int> Matieuduan { get; set; }
        public Nullable<int> Magiaidoan { get; set; }
        public string Tentieuduan { get; set; }
        public string Tengiaidoan { get; set; }
        public Nullable<decimal> Giatritien { get; set; }
        public Nullable<int> Landieuchinh { get; set; }
        public DateTime? Date { get; set; }
        public string Nguoitao { get; set; }
        public string Ngaytao
        {
            get { return Date.Value.ToString("dd/MM/yyyy"); }
        }
    }
}