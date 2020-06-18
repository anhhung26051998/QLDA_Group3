using Data.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using Data.Model;
using QLDA.Common;
using System.Web.Http;

namespace Data.Business
{
    public class ChuDauTuBusiness:GenericBusiness
    {
        public ChuDauTuBusiness(QLDAEntities context=null ):base()
        {

        }
        public List<SreachChuDauTuModelOuput> Search(string name="")
        {
           try
            {
                var data = cnn.tbl_chudautu.Where(u => name.Length > 0 ? u.TenCDT.Contains(name)||u.Phone.Contains(name) : true&&u.status!=0).Select(c => new SreachChuDauTuModelOuput
                {
                    Id = c.ID,
                    Tenchudautu = c.TenCDT,
                    Diachi = c.Diachi,
                    Phone = c.Phone,
                    Email = c.Email
                }).OrderByDescending(t => t.Id).ToList();
                return data;
            }
            catch
            {
                return new List<SreachChuDauTuModelOuput>();
            }

        }


        public DeTailChuDauTuModelOutput ChuDauTuDetail(int?id=null)
        {
            try
            {
                if(!id.HasValue)
                {
                    return new DeTailChuDauTuModelOutput();
                }    
                else
                {
                    var data = cnn.tbl_chudautu.Where(u => u.ID == id&&u.status!=0).Select(t => new DeTailChuDauTuModelOutput
                    {
                        Id = t.ID,
                        
                        Tenchudautu = t.TenCDT,
                        Diachi = t.Diachi,
                        MaCDT=t.MaCDT,
                        IdLoaiCDT=t.IdLoaiCDT,
                        Fax = t.Fax,
                        Email = t.Email,
                        Phone = t.Phone,
                        Website = t.Website,
                        Nguoitao = (t.Nguoitao == null || t.Nguoitao.Length <= 0) ? "Chưa Cập Nhật" : t.Nguoitao,
                        Emailnguoitao = (t.Nguoitao == null || t.Nguoitao.Length <= 0) ? "Chưa Cập Nhật" : cnn.tbl_z_users.Where(x => x.Username == t.Nguoitao).Select(x => x.Mail).FirstOrDefault()

                    }).FirstOrDefault();
                    return data;
                }    
            }
            catch
            {
                return new DeTailChuDauTuModelOutput();
            }
        }


        public List<TieuDaCDTModelOutput> SearchTieuDaByDa(int? idda)
        {
            try
            {
                var data = cnn.tbl_tieuduan.Where(u => u.Maduan == idda&&u.tbl_duan.status!=0).Select(c => new TieuDaCDTModelOutput
                {
                    Id = c.ID,
                    Loaivon = cnn.tbl_von.Where(x => x.Matieuduan == c.ID).Select(x => x.Tenvon).FirstOrDefault(),
                    Tentieuda = c.Tentieuduan,
                    Landieuchinh = cnn.tbl_von.Where(x => x.Matieuduan == c.ID).Select(x => x.Landieuchinh).FirstOrDefault().HasValue ? "Tổng mức đầu tư gốc" : "Lần thứ " + cnn.tbl_von.Where(x => x.Matieuduan == c.ID).Select(x => x.Landieuchinh).FirstOrDefault(),
                    Thoidoan = cnn.tbl_von_giaidoan.Where(k => k.ID == cnn.tbl_von.Where(x => x.Matieuduan == c.ID).Select(x => x.Magiaidoan).FirstOrDefault()).Select(k => k.Tengiaidoan).FirstOrDefault(),
                    Giatri = (int)cnn.tbl_von.Where(x => x.Matieuduan == c.ID).Select(x => x.Giatritien).FirstOrDefault()
                }).OrderByDescending(t => t.Id).ToList();
                return data;
            }
            catch
            {
                return new List<TieuDaCDTModelOutput>();
            }
        }


        public ResultModel AddCDT(tbl_chudautu cdt)
        {
            try
            {
                if (cdt == null)
                {
                    return new ResultModel { Status = 0, Messege = "Thêm chủ đầu tư thất bại vui lòng thử lại!" };
                }
                else if(cnn.tbl_chudautu.Where(u=>u.MaCDT==cdt.MaCDT).Count()>0)
                {
                    return new ResultModel { Status = 0, Messege = "Chủ đầu tư đã tồn tại vui lòng thử lại!" };
                }
                else
                {
                    Random rd = new Random();
                    var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                    var Nguoitao = cnn.tbl_z_users.Where(u => u.User_Id == userid).Select(u => u.Username).FirstOrDefault();
                    cdt.Ngaytao = DateTime.Now;
                    cdt.code="CDT"+ rd.Next(0, 99999999).ToString();
                    cdt.Nguoitao = Nguoitao;
                    cnn.tbl_chudautu.Add(cdt);
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Thêm chủ đầu tư thành công!" };
                }    
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Thêm chủ đầu tư thất bại vui lòng thử lại!" };
            }


        }

        public ResultModel EditCDT(tbl_chudautu cdt)
        {
            try
            {
                if (cdt == null)
                {
                    return new ResultModel { Status = 0, Messege = "Chủ đầu tư không tồn tại vui lòng thử lại!" };
                }
                else if (cnn.tbl_chudautu.Where(u => u.ID == cdt.ID).Count() <= 0)
                {
                    return new ResultModel { Status = 0, Messege = "Chủ đầu tư không tồn tại vui lòng thử lại!" };
                }
                else
                {
                    var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                    var Nguoisua = cnn.tbl_z_users.Where(u => u.User_Id == userid).Select(u => u.Username).FirstOrDefault();
                    var data = cnn.tbl_chudautu.Find(cdt.ID);
                    data.IdLoaiCDT = cdt.IdLoaiCDT;
                    data.MaCDT = cdt.MaCDT;
                    data.Mota = cdt.Mota;
                    data.Phone = cdt.Phone;
                    data.TenCDT = cdt.TenCDT;
                    data.TenCDTfull = cdt.TenCDTfull;
                    data.Website = cdt.Website;
                    data.Diachi = cdt.Diachi;
                    data.Email = cdt.Email;
                    data.Fax = cdt.Fax;
                    cdt.Ngaysua = DateTime.Now;
                    cdt.Nguoisua = Nguoisua;
         
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Sửa chủ đầu tư thành công!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Sửa chủ đầu tư thất bại vui lòng thử lại!" };
            }


        }

        public ResultModel DeleteCDT(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new ResultModel { Status = 0, Messege = "Chủ đầu tư không tồn tại vui lòng thử lại!" };
                }
                else if (cnn.tbl_chudautu.Where(u => u.ID == id).Count() <= 0)
                {
                    return new ResultModel { Status = 0, Messege = "Chủ đầu tư không tồn tại vui lòng thử lại!" };
                }
                else
                {
                    var dt = cnn.tbl_chudautu.Where(u => u.ID == id).FirstOrDefault();
                    dt.status = 0;
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Xóa chủ đầu tư thành công!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Xóa chủ đầu tư thất bại vui lòng thử lại!" };
            }


        }
    }
}