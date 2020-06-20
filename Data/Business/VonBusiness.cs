using Data.Connect;
using Data.Model;
using IdeaBlade.Linq;
using OfficeOpenXml;
using QLDA.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Data.Business
{
    public class VonBusiness : GenericBusiness
    {
        public VonBusiness(QLDAEntities context = null) : base()
        {

        }
        public ResultModel AddVonGD(tbl_von_giaidoan vgd)
        {
            try
            {
                if (vgd != null)
                {
                    if (cnn.tbl_von_giaidoan.Where(u => u.Tengiaidoan.Equals(vgd.Tengiaidoan) && (u.status.HasValue ? u.status != 0 : true)).Count() > 0)
                    {
                        return new ResultModel { Status = 0, Messege = "Vốn đã tồn tại vui lòng thử lại!" };
                    }
                    else
                    {
                        var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                        var Nguoitao = cnn.tbl_z_users.Where(u => u.User_Id == userid).Select(u => u.Username).FirstOrDefault();
                        vgd.Ngaytao = DateTime.Now;
                        vgd.Nguoitao = Nguoitao;
                        cnn.tbl_von_giaidoan.Add(vgd);
                        cnn.SaveChanges();
                        return new ResultModel { Status = 1, Messege = "Thêm vốn thành công!" };
                    }
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Vốn không tồn tại vui lòng thử lại!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Thêm vốn thất bại vui lòng thử lại!" };
            }
        }


        public ResultModel AddVon(tbl_von v)
        {
            try
            {
                if (v != null)
                {
                    var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                    var Nguoitao = cnn.tbl_z_users.Where(u => u.User_Id == userid).Select(u => u.Username).FirstOrDefault();
                    if(cnn.tbl_von.Where(u=>u.Mavon==v.Mavon).Count()>0)
                    {
                        return new ResultModel { Status = 0, Messege = "Vốn đã tồn tại vui lòng thử lại!" };
                    }    
                    else
                    {
                        v.Ngaytao = DateTime.Now;
                        v.Nguoitao = Nguoitao;
                        cnn.tbl_von.Add(v);
                        cnn.SaveChanges();
                        tbl_von_dieuchinh dieuchinh = new tbl_von_dieuchinh();
                        dieuchinh.Mavon = cnn.tbl_von.Where(u => u.Mavon == v.Mavon).Select(u => u.ID).FirstOrDefault();
                        dieuchinh.Landieuchinh = 0;
                        dieuchinh.Nguoitao = Nguoitao;
                        dieuchinh.Ngaytao = DateTime.Now;
                        dieuchinh.state = 1;
                        cnn.tbl_von_dieuchinh.Add(dieuchinh);
                        cnn.SaveChanges();
                    }    
                  
                    return new ResultModel { Status = 1, Messege = "Thêm vốn thành công!" };
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Vốn không tồn tại vui lòng thử lại!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Thêm vốn thất bại vui lòng thử lại!" };
            }
        }

        public List<DropDownModelOutput> GetVonGD()
        {
            try
            {
                return cnn.tbl_von_giaidoan.Where(u => u.status.HasValue ? u.status != 0 : true).Select(c => new DropDownModelOutput
                {
                    Id = c.ID,
                    Value = c.Tengiaidoan
                }).OrderByDescending(t => t.Value).ToList();
            }
            catch
            {
                return new List<DropDownModelOutput>();
            }
        }


        public ResultModel EditVon(tbl_von v)
        {
            try
            {
                if (v.ID != 0)
                {
                    var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                    var Nguoitao = cnn.tbl_z_users.Where(u => u.User_Id == userid).Select(u => u.Username).FirstOrDefault();
                    var data = cnn.tbl_von.Where(u => u.ID == v.ID && (u.state.HasValue ? u.state != 0 : true)).FirstOrDefault();
                  
                    data.Magiaidoan = v.Magiaidoan;
               
                    data.Tenvon = v.Tenvon;
                    data.Ngaysua = DateTime.Now;
                    data.Nguoisua = Nguoitao;
                    if(data.Giatritien>v.Giatritien||data.Giatritien<v.Giatritien)
                    {
                        tbl_von_dieuchinh dieuchinh = new tbl_von_dieuchinh();
                        dieuchinh.Mavon = data.ID;
                        dieuchinh.Landieuchinh = cnn.tbl_von_dieuchinh.Where(u => u.Mavon == v.ID).Max(u => u.Landieuchinh).GetValueOrDefault() + 1;
                        dieuchinh.state = 1;
                        dieuchinh.Ngaytao = DateTime.Now;
                        dieuchinh.Nguoitao = Nguoitao;
                        dieuchinh.Giatritien = data.Giatritien;
                        data.Landieuchinh = dieuchinh.Landieuchinh;
                        cnn.tbl_von_dieuchinh.Add(dieuchinh);
                    }    
                    
                    data.Giatritien = v.Giatritien;
                    
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Sửa vốn thành công!" };
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Vốn không tồn tại vui lòng thử lại!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Sửa vốn tha vui lòng thử lại!" };
            }
           
        }

        public ResultModel DeleteVon(int? idvon)
        {
            try
            {
                var dt = cnn.tbl_von.Where(u => u.ID == idvon).FirstOrDefault();
                if (dt == null)
                {
                    return new ResultModel { Status = 0, Messege = "Vốn không tồn tại!" };
                }
                else
                {
                    dt.state = 0;
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Xóa vốn thành công!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Xóa vốn thất bại!" };
            }
        }


        public List<VonModelOutput> SearchVon(string tenvon, int? idduan, int? idtieuda)
        {
            try
            {
                return cnn.tbl_von.Where(u => (tenvon.Length > 0 ? u.Tenvon.Contains(tenvon) : true) && (idduan.HasValue ? u.Maduan == idduan : true )&& (idtieuda.HasValue ? u.Matieuduan == idtieuda : true )&& (u.state.HasValue ? u.state != 0 : true)).Select(c => new VonModelOutput {
                    ID = c.ID,
                    Giatritien = c.Giatritien,
                    Landieuchinh = c.Landieuchinh,
                    Tenduan = cnn.tbl_duan.Where(t => t.Id == c.Maduan).Select(x => x.Tenduan).FirstOrDefault(),
                    Tengiaidoan = cnn.tbl_von_giaidoan.Where(t => t.ID == c.Magiaidoan).Select(x => x.Tengiaidoan).FirstOrDefault(),
                    Tenvon = c.Tenvon,
                    Tentieuduan = cnn.tbl_tieuduan.Where(t => t.ID == c.Matieuduan).Select(x => x.Tentieuduan).FirstOrDefault(),
                    Mavon = c.Mavon,
                    Nguoitao = c.Nguoitao,
                    Date = c.Ngaytao,
                    Maduan = c.Maduan,
                    Matieuduan = c.Matieuduan,
                    Magiaidoan = c.Magiaidoan


                }).OrderByDescending(t => t.ID).ToList();
            }
            catch
            {
                return new List<VonModelOutput>();
            }
        }
        public VonModelOutput VonDetail(int? idvon)
        {
            try
            {
                return cnn.tbl_von.Where(u => u.ID == idvon && (u.state.HasValue ? u.state != 0 : true)).Select(c => new VonModelOutput
                {
                    ID = c.ID,
                    Giatritien = c.Giatritien,
                    Landieuchinh = c.Landieuchinh,
                    Tenduan = cnn.tbl_duan.Where(t => t.Id == c.Maduan).Select(x => x.Tenduan).FirstOrDefault(),
                    Tengiaidoan = cnn.tbl_von_giaidoan.Where(t => t.ID == c.Magiaidoan).Select(x => x.Tengiaidoan).FirstOrDefault(),
                    Tenvon = c.Tenvon,
                    Tentieuduan = cnn.tbl_tieuduan.Where(t => t.ID == c.Matieuduan).Select(x => x.Tentieuduan).FirstOrDefault(),
                    Mavon = c.Mavon,
                    Nguoitao = c.Nguoitao,
                    Date = c.Ngaytao,
                    Maduan = c.Maduan,
                    Matieuduan = c.Matieuduan,
                    Magiaidoan = c.Magiaidoan


                }).FirstOrDefault();
            }
            catch
            {
                return new VonModelOutput();
            }
        }
        public ExcelPackage ReportVon(string tenvon, int? idduan, int? idtieuda)
        {
            try
            {
                var data = SearchVon(tenvon, idduan, idtieuda);
                FileInfo file = new FileInfo(HttpContext.Current.Server.MapPath(@"/Template/ReportVon.xlsx"));
                ExcelPackage pack = new ExcelPackage(file);
                ExcelWorksheet sheet = pack.Workbook.Worksheets[0];
                int row = 3;
                int stt = 1;
                foreach (var item in data)
                {
                    sheet.Cells[row, 1].Value = stt;
                    sheet.Cells[row, 2].Value = item.Mavon;
                    sheet.Cells[row, 3].Value = item.Tenvon;
                    sheet.Cells[row, 4].Value = item.Tenduan;
                    sheet.Cells[row, 5].Value = item.Tentieuduan;
                    sheet.Cells[row, 6].Value = item.Tengiaidoan;
                    sheet.Cells[row, 7].Value = item.Landieuchinh;
                    sheet.Cells[row, 8].Value = item.Giatritien;

                    sheet.Cells.AutoFitColumns();
                    row++;
                    stt++;

                }
                return pack;
            }
            catch
            {
                return null;
            }
        }


        public List<tbl_von_giaidoan> GetGD()
        {
            return cnn.tbl_von_giaidoan.Where(u => u.status.HasValue ? u.status != 0 : true).ToList();
        }
        public List<VonDieuChinhModelOutput> GetHistoryVon(int? idvon)
        {
            try
            {
                if (idvon.HasValue)
                {
                    return cnn.tbl_von_dieuchinh.Where(u => u.Mavon == idvon).Select(c => new VonDieuChinhModelOutput {
                        Mavon = c.Mavon,
                        Landieuchinh = c.Landieuchinh,
                        Giatritien = c.Giatritien,
                        Date = c.Ngaytao,
                        Nguoitao=c.Nguoitao,



                    }).ToList();
                }    
                else
                { return new List<VonDieuChinhModelOutput>(); }    
            }
            catch
            {
                return new List<VonDieuChinhModelOutput>();
            }
        }
        public ResultModel AddVonGD(string tengd)
        {
            try
            {
                if(tengd.Length>0)
                {
                    tbl_von_giaidoan gd = new tbl_von_giaidoan();
                    gd.Tengiaidoan = tengd;
                    gd.status = 1;
                    cnn.tbl_von_giaidoan.Add(gd);
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Thêm giai đoạn thành công!" };
                } 
                else
                {
                    return new ResultModel { Status = 0, Messege = "Thêm giai đoạn thất bại!" };
                }    
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Thêm giai đoạn thất bại!" };
            }
        }


        public List<VonModelOutput> SearchVonByDa(int?magd,string name,int?idtieuda)
        {
            try
            {
                return cnn.tbl_von.Where(u => (name.Length > 0 ? u.Tenvon.Contains(name) : true) && (magd.HasValue ? u.Magiaidoan == magd : true) && (idtieuda.HasValue ? u.Matieuduan == idtieuda : true) && (u.state.HasValue ? u.state != 0 : true)).Select(c => new VonModelOutput
                {
                    ID = c.ID,
                    Giatritien = c.Giatritien,
                    Landieuchinh = c.Landieuchinh,
                    Tengiaidoan = cnn.tbl_von_giaidoan.Where(t => t.ID == c.Magiaidoan).Select(x => x.Tengiaidoan).FirstOrDefault(),
                    Tenvon = c.Tenvon,
                    Tentieuduan = cnn.tbl_tieuduan.Where(t => t.ID == c.Matieuduan).Select(x => x.Tentieuduan).FirstOrDefault(),
                    Mavon = c.Mavon,
                    Nguoitao = c.Nguoitao,
                    Date = c.Ngaytao,


                }).OrderByDescending(t => t.ID).ToList();
            }
            catch
            {
                return new List<VonModelOutput>();
            }
        }
    }
}