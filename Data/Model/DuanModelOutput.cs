using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Utils;
using Data.Model;

namespace Data.Model
{
    public class DuanModelOutput
    {
        public int Id { get; set; }
        public string TenDa { get; set; }
        public string DiaDiem { get; set; }
        public string UrlImage { get; set; }
        public string Maduan { get; set; }
    }

    public class DuanNoiBatOutputModel : DuanModelOutput
    {
        public DateTime? Date { get; set; }
        public string DateComplete { get { return Date.HasValue ? Date.Value.ToString("dd/MM/yyyy") :"Chưa cập nhật"; } } 
      
        public decimal Tongdautu { get; set; }
        public string Chudautu { get; set; }
    }
    public class DuaDetailModelOutput:DuanNoiBatOutputModel
    {  public string Code { get; set; }
        public string QuyetDinh { get; set; }
        public string NgayPheDuyet { get; set; }
        public string Diadiemkhobac { get; set; }
        public DateTime? Datethicong { get; set; }
        public string Thoigianthicong { get { return Datethicong.HasValue ? Datethicong.Value.ToString("dd/MM/yyyy"):"Chưa cập nhật"; } }
        public int Idhinhthucquanli { get; set; }
        public string Hinhthucquanli { get; set; }
        public string Mota { get; set; }
        public string Loaivon { get; set; }
        public string Urlmap { get; set; }
        public string Urlfile { get; set; }
        public int Idloainguonvon { get; set; }
        public int? Idchudautu { get; set; }
        public int idtinh { get; set; }
        
        public List<TieuDaModelOuput> listtieuduan { get; set; }
    }
}