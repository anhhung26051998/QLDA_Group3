using Data.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Model;
using QLDA.Common;
using System.Web.Mvc;
using OfficeOpenXml;
using System.IO;

namespace Data.Business
{
    public class DuanBusiness : GenericBusiness
    {
        public DuanBusiness(QLDAEntities context = null) : base()
        {

        }
        public List<DuanModelOutput> Search(string tenda, string mada, int? tinh = null, int? chudatu = null)
        {
            try
            {
                var data = cnn.tbl_duan.Where(u => u.status != 0 &&
             (tenda.Length > 0 ? u.Tenduan.Contains(tenda) : true) &&
             (mada.Length > 0 ? u.Maduan.Equals(mada) : true) &&
             (tinh.HasValue ? u.tbl_tinh.Where(x => x.ID == tinh).Count() > 0 : true) &&
             (chudatu.HasValue ? u.IdChudautu == chudatu : true)
             ).Select(c => new DuanModelOutput
             {
                 Id = c.Id,
                 TenDa = c.Tenduan,
                 DiaDiem = c.Diadiemthuchien,
                 UrlImage = c.Urlfile,
                 Maduan = c.Maduan
             }
             ).OrderByDescending(d => d.Id).ToList();
                return data;
            }
            catch
            {
                return new List<DuanModelOutput>();
            }
        }

        public List<DuanNoiBatOutputModel> SearchSpecail(int? tinh = null)
        {
            var data = cnn.tbl_duan.Where(u => (tinh.HasValue ? u.tbl_tinh.Select(c => c.ID).FirstOrDefault() == tinh : true) && u.status != 0).Select(t => new DuanNoiBatOutputModel
            {
                Id = t.Id,
                TenDa = t.Tenduan,
                DiaDiem = t.Diadiemthuchien,
                UrlImage = t.Urlfile,
                Date=t.Thoigianhoanthanh,
                //DateComplete = (t.Thoigianhoanthanh.HasValue) ? "Đã Hoàn Thành" : "Chưa Hoàn Thành",
                Tongdautu = t.Tongmucdautu,
                Maduan = t.Maduan,
                Chudautu = cnn.tbl_chudautu.Where(u => u.ID == t.IdChudautu).Select(c => c.TenCDT).FirstOrDefault()

            }).OrderByDescending(x => x.Id).ToList();
            return data;
        }

        public DuaDetailModelOutput DaDetail(int? id = null)
        {
            try
            {
                var data = cnn.tbl_duan.Where(u => u.Id == id && u.status != 0).Select(c => new DuaDetailModelOutput
                {
                    Id = c.Id,
                    TenDa = c.Tenduan,
                    DiaDiem = c.Diadiemthuchien,
                    UrlImage = c.UrlMaps,
                    Code = c.code,
                    Maduan = c.Maduan,
                    Datethicong=c.Thoigiankhoicong,
                    Tongdautu = c.Tongmucdautu,
                    //DateComplete = c.Thoigianhoanthanh.HasValue ? c.Thoigianhoanthanh.Value.ToString() : "Chưa Hoàn Thành",
                    Date=c.Thoigianhoanthanh,
                    Chudautu = c.IdChudautu.HasValue ? cnn.tbl_chudautu.Where(k => k.ID == c.IdChudautu).Select(b => b.TenCDT).FirstOrDefault() : "Chưa Cập Nhật",
                    QuyetDinh = c.QDpheduyetDADT,
                    NgayPheDuyet = c.Ngaypheduyet.Value.ToString(),
                    Diadiemkhobac = c.Diadiemkhobac,
                    Hinhthucquanli = c.tbl_hinhthucqlda.TenhinhthucQLDA,
                    Loaivon = c.tbl_von.Select(x => x.Tenvon).FirstOrDefault(),
                    Urlfile=c.Urlfile,
                    Urlmap=c.UrlMaps,
                    Mota=c.Motaduan,
                    listtieuduan = c.tbl_tieuduan.Where(x=>x.status!=0).Select(t => new TieuDaModelOuput
                    {
                        Id = t.ID,
                        Tentieuda = t.Tentieuduan,
                        Chudautu = t.tbl_chudautu.TenCDT

                    }).ToList()

                }).SingleOrDefault();
                return data;
            }
            catch
            {
                return new DuaDetailModelOutput();
            }





        }

        public List<TieuDaModelOuput> SreachTieuDuan(int?idduan,int? chudautu,string name)
        {
            try
            {
                var data = cnn.tbl_tieuduan.Where(u => (idduan.HasValue ? u.Maduan == idduan : true) && (chudautu.HasValue ? u.MaCDT == chudautu : true) &&( name.Length > 0 ? u.Tentieuduan.Contains(name) : true) && (u.status.HasValue?u.status!= 0:true)).Select(c => new TieuDaModelOuput
                {
                    Id = c.ID,
                    code = c.Matieuduan,
                    Maduan = c.Maduan.ToString(),
                    Tentieuda = c.Tentieuduan,
                    Diadiem = c.tbl_duan.Diadiemthuchien,
                    Mota = c.Mota,
                    Chudautu = cnn.tbl_chudautu.Where(x => x.ID == c.MaCDT).Select(u => u.TenCDT).FirstOrDefault()

                }).OrderByDescending(t => t.Id).ToList();
                return data;
            }
            catch
            {
                return new List<TieuDaModelOuput>();
            }
        }
        public List<TongMucDauTuModelOutput> Gettongdautu(int? id, int? type)
        {
            try
            {
                switch (type)
                {
                    case 1:
                        {
                            if (!id.HasValue)
                            {
                                return new List<TongMucDauTuModelOutput>();
                            }
                            else
                            {
                                var query = cnn.tbl_tongmucdautu.Where(u => u.IdDuan == id).Select(u => u.ID);
                                List<TongMucDauTuModelOutput> list = new List<TongMucDauTuModelOutput>();
                                foreach (var item in query)
                                {
                                    var data = cnn.tbl_cocauTMDT.Where(x => x.IdTMDT == item).Select(c => new TongMucDauTuModelOutput
                                    {
                                        Id = c.ID,
                                        Tenduan = cnn.tbl_tieuduan.Where(x => x.ID == c.tbl_tongmucdautu.IdTieuduan&&x.status!=0).Select(x => x.Tentieuduan).FirstOrDefault(),
                                        Nguonvon = cnn.tbl_nguonvon.Where(u => u.ID == c.Idnguonvon).Select(u => u.Tennguonvon).FirstOrDefault(),
                                        Landieuchinh = !c.Landieuchinh.HasValue ? "Tổng mức đầu tư gốc" : "Lần Thứ " + c.Landieuchinh.ToString(),
                                        Thietbi = c.Thietbi,
                                        Duphong = c.Duphong,
                                        GPMB = c.Denbugpmb,
                                        Khac = c.Khac,
                                        Xaylap = c.Xaylap,
                                        Tuvan = c.Tuvan,
                                        Quanliduan = c.Quanlyduan,
                                        Chitiet = c.Mota

                                    }).FirstOrDefault();
                                    if (data != null)
                                        list.Add(data);
                                }
                                return list;

                            }
                        }

                    case 2:
                        {
                            if (!id.HasValue)
                            {
                                return new List<TongMucDauTuModelOutput>();
                            }
                            else
                            {
                                var query = cnn.tbl_tongmucdautu.Where(u => u.IdDuan == id).Select(u => u.ID);
                                List<TongMucDauTuModelOutput> list = new List<TongMucDauTuModelOutput>();
                                foreach (var item in query)
                                {
                                    var data = cnn.tbl_cocauTMDT.Where(x => x.IdTMDT == item).Select(c => new TongMucDauTuModelOutput
                                    {
                                        Id = c.ID,
                                        Tenduan = cnn.tbl_duan.Where(x => x.Id == id).Select(x => x.Tenduan).FirstOrDefault(),
                                        Nguonvon = cnn.tbl_nguonvon.Where(u => u.ID == c.Idnguonvon).Select(u => u.Tennguonvon).FirstOrDefault(),
                                        Landieuchinh = !c.Landieuchinh.HasValue ? "Tổng mức đầu tư gốc" : "Lần Thứ " + c.Landieuchinh.ToString(),
                                        Thietbi = c.Thietbi,
                                        Duphong = c.Duphong,
                                        GPMB = c.Denbugpmb,
                                        Khac = c.Khac,
                                        Xaylap = c.Xaylap,
                                        Tuvan = c.Tuvan,
                                        Quanliduan = c.Quanlyduan,
                                        Chitiet = c.Mota

                                    }).FirstOrDefault();
                                    if (data != null)
                                        list.Add(data);
                                }
                                return list;
                            }
                        }
                    default:
                        {
                            return new List<TongMucDauTuModelOutput>();
                        }
                }



            }
            catch
            {
                return new List<TongMucDauTuModelOutput>();
            }
        }
        /// <summary>
        /// Xuân Hùng tạo để sreach dự án và tiểu dự án trong admin
        /// </summary>
        /// <param name="tenda"></param>
        /// <param name="mada"></param>
        /// <param name="tinh"></param>
        /// <param name="chudatu"></param>
        /// <returns></returns>
        public List<DuaDetailModelOutput> SearchDaAdmin(string nameandkey, int? tinh = null, int? chudatu = null, int? id = null)
        {
            try
            {

                var data = cnn.tbl_duan.Where(u => id.HasValue ? u.Id == id : true && u.status != 0 &&
              (nameandkey.Length > 0 ? u.Tenduan.Contains(nameandkey) || u.Maduan.Contains(nameandkey) : true) &&
              (tinh.HasValue ? u.tbl_tinh.Where(x => x.ID == tinh).Count() > 0 : true) &&
              (chudatu.HasValue ? u.IdChudautu == chudatu : true)
              ).Select(c => new DuaDetailModelOutput
              {
                  Id = c.Id,
                  TenDa = c.Tenduan,
                  DiaDiem = c.Diadiemthuchien,
                  Maduan = c.Maduan,
                  Chudautu = cnn.tbl_chudautu.Where(x => x.ID == c.IdChudautu).Select(x => x.TenCDT).FirstOrDefault(),
                  NgayPheDuyet = c.Ngaypheduyet.Value.ToString(),
                  Date = c.Thoigianhoanthanh,
                  Tongdautu = c.Tongmucdautu,
                  QuyetDinh = c.QDduyetCTDT,
                  Diadiemkhobac = c.Diadiemkhobac,
                  Urlmap = c.UrlMaps,
                Datethicong=c.Thoigiankhoicong,
                  Idhinhthucquanli = c.tbl_hinhthucqlda.ID,
                  Idloainguonvon = c.Idloainguonvon,
                  Idchudautu = c.IdChudautu,
                  Urlfile = c.Urlfile,
                  Mota = c.Motaduan,
                  Code = c.code,
                  idtinh = c.tbl_tinh.Select(u => u.ID).FirstOrDefault(),
                  Hinhthucquanli = c.tbl_hinhthucqlda.TenhinhthucQLDA,
                  Loaivon = c.tbl_nguonvon.Tennguonvon,
                  listtieuduan = c.tbl_tieuduan.Where(x=>x.status!=0).Select(n => new TieuDaModelOuput
                  {
                      Id = n.ID,
                      Tentieuda = n.Tentieuduan,
                      Mota = n.Mota,
                      Chudautu = n.tbl_chudautu.TenCDT

                  }).OrderByDescending(t => t.Id).ToList()

              }
              ).OrderByDescending(d => d.Id).ToList();
                return data;

            }
            catch (Exception ex)
            {

                return new List<DuaDetailModelOutput>();
            }


        }

        public ResultModel AddDuan(tbl_duan da, int? idtinh)
        {
            try
            {
                var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                var Nguoitao = cnn.tbl_z_users.Where(u => u.User_Id == userid &&( u.Inactive.HasValue ? u.Inactive != true : true)).Select(u => u.Username).FirstOrDefault();
                if (da != null)
                {

                    if (cnn.tbl_duan.Where(u => u.Maduan == da.Maduan && u.status != 0).Count() > 0)
                    {
                        return new ResultModel { Status = 0, Messege = "Mã dự án đã tồn tại vui lòng kiểm tra lại!" };
                    }
                    else
                    {
                        Random rd = new Random();
                        da.tbl_tinh.Add(cnn.tbl_tinh.Where(u => u.ID == idtinh).FirstOrDefault());
                        da.code = "Code" + rd.Next(0, 99999999).ToString();
                        da.status = 1;
                        da.Ngaytao = DateTime.Now;
                        da.Nguoitao = Nguoitao;
                        cnn.tbl_duan.Add(da);
                        cnn.SaveChanges();
                        return new ResultModel { Status = 1, Messege = "Thêm dự án thành công!" };
                    }
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Thêm dự án thất bại vui lòng kiểm tra lại!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Thêm dự án thất bại vui lòng kiểm tra lại!" };
            }
        }

        public ResultModel EditDa(tbl_duan da, int? idtinh)
        {
          
            try
            {
                var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                var Nguoisua = cnn.tbl_z_users.Where(u => u.User_Id == userid&&(u.Inactive.HasValue ? u.Inactive != true : true)).FirstOrDefault();
              
                tbl_duan data = cnn.tbl_duan.Where(x => x.Maduan == da.Maduan && x.Id == da.Id && x.status != 0).FirstOrDefault();
                if (idtinh.HasValue && da != null&&Nguoisua.IdChudautu.HasValue?data.IdChudautu==Nguoisua.IdChudautu:true)
                {
                  
                    data.Diadiemkhobac = da.Diadiemkhobac;
                    data.Diadiemthuchien = da.Diadiemthuchien;
                    data.Tenduan = da.Tenduan;
                   if(!Nguoisua.IdChudautu.HasValue)
                    {
                        data.IdChudautu = da.IdChudautu;
                    }    
                    data.IdhinhthucQLDA = da.IdhinhthucQLDA;
                    data.Idloainguonvon = da.Idloainguonvon;
                    data.Motaduan = da.Motaduan;
                    data.nam_hoanthanh = da.nam_hoanthanh;
                    data.nam_khoicong = da.nam_khoicong;
                    data.tbl_tinh.Clear();
                    da.tbl_tinh.Add(cnn.tbl_tinh.Where(u => u.ID == idtinh).FirstOrDefault());
                    data.Ngaypheduyet = da.Ngaypheduyet;
                    data.Urlfile = da.Urlfile;
                    data.UrlMaps = da.UrlMaps;
                    data.Tongmucdautu = da.Tongmucdautu;
                    data.NgaypheduyetCTDT = da.NgaypheduyetCTDT;
                    data.Ngaysua = DateTime.Now;             
                    data.Ngaytao = da.Ngaytao;
                    data.QDduyetCTDT = da.QDduyetCTDT;
                    data.QDpheduyetDADT = da.QDpheduyetDADT;
                    data.Nguoisua = Nguoisua.Username;
                    data.status = da.status;
                    data.stt = data.stt;
                
                    if (data.tbl_tinh.Count > 0)
                    {
                        data.tbl_tinh.Remove(data.tbl_tinh.FirstOrDefault());
                        data.tbl_tinh.Add(cnn.tbl_tinh.Where(u => u.ID == idtinh).FirstOrDefault());
                    }
                    else
                    {
                        data.tbl_tinh.Add(cnn.tbl_tinh.Where(u => u.ID == idtinh).FirstOrDefault());
                    }
             


                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Sửa dự án thành công!" };
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Sửa dự án thất bại vui lòng kiểm tra lại!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "sửa dự án thất bại vui lòng kiểm tra lại!" };
            }
        }

        public ResultModel DeleteDuan(int? idda)
        {
            try
            {
                if (idda.HasValue)
                {
                    var data = cnn.tbl_duan.Find(idda);
                    data.status = 0;
                    var tieuduan = cnn.tbl_tieuduan.Where(u => u.Maduan == data.Id);
                    foreach (var item in tieuduan)
                    {
                        item.status = 0;
                    }
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Xóa dự án thành công!" };
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = " Dự án không tồn tại vui lòng kiểm tra lại!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Xóa dự án thất bại vui lòng kiểm tra lại!" };
            }
        }

        public ResultModel AddTieuDa(tbl_tieuduan tieuda)
        {
            try
            {
                var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                var Nguoitao = cnn.tbl_z_users.Where(u => u.User_Id == userid &&( u.Inactive.HasValue ? u.Inactive != true : true)).Select(u => u.Username).FirstOrDefault();
                var rs = new ResultModel { Status = 0, Messege = "Dự án không tồn tại vui lòng thử lại!" };
                if (tieuda.Maduan.HasValue)

                {
                    var duan = cnn.tbl_duan.Find(tieuda.Maduan);
                    if (duan == null)
                    {
                        return rs;
                    }else if(cnn.tbl_tieuduan.Where(x=>x.Matieuduan.Equals(tieuda.Matieuduan)).Count()>0)
                    {
                        return new ResultModel { Status = 0, Messege = "Mã tiểu dự án đã tồn tại bui lòng thử lại!" };
                    }    

                    else
                    {
                        tieuda.Ngaytao = DateTime.Now;
                        tieuda.Nguoitao = Nguoitao;
                        cnn.tbl_tieuduan.Add(tieuda);
                        cnn.SaveChanges();
                        return new ResultModel { Status = 1, Messege = "Thêm tiểu dự án thành công!" };
                    }

                }
                else
                {
                    return rs;
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Thêm tiểu dự án thất bại vui lòng thử lại!" };
            }
        }

        public ResultModel EditTieuDa(tbl_tieuduan tieuda)
        {
            try
            {
                var rs = new ResultModel { Status = 0, Messege = " Tiểu dự án không tồn tại vui lòng thử lại!" };
                var userid = Int16.Parse(HttpContext.Current.Request.Headers["UserId"].ToString());
                var Nguoitao = cnn.tbl_z_users.Where(u => u.User_Id == userid&&(u.Inactive.HasValue?u.Inactive!=true:true)).Select(u => u.Username).FirstOrDefault();
                if (tieuda.Maduan.HasValue)

                {
                    var duan = cnn.tbl_duan.Find(tieuda.Maduan);
                    if (duan == null)
                    {
                        return rs;
                    }
                    else if (cnn.tbl_tieuduan.Where(x => x.Matieuduan.Equals(tieuda.Matieuduan)).Count() <= 0)
                    {
                        return new ResultModel { Status = 0, Messege = "Mã tiểu dự án không tồn tại bui lòng thử lại!" };
                    }

                    else
                    {
                        var dt = cnn.tbl_tieuduan.Where(u => u.Matieuduan.Equals(tieuda.Matieuduan)).FirstOrDefault();
                        dt.Ngaysua = DateTime.Now;
                        dt.Nguoisua = Nguoitao;
                        dt.MaCDT = tieuda.MaCDT;
                        dt.Maduan = tieuda.Maduan;
                        dt.Mota = tieuda.Mota;
                        dt.Tentieuduan = tieuda.Tentieuduan;
                        cnn.SaveChanges();
                        return new ResultModel { Status = 1, Messege = "Sửa tiểu dự án thành công!" };
                    }

                }
                else
                {
                    return rs;
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Sửa tiểu dự án thất bại vui lòng thử lại!" };
             
                
                    
               
            }
        }

        public ResultModel DeleteTieuDa(int? id)
      {
           try
            {
                if (id.HasValue)
                {
                    var data = cnn.tbl_tieuduan.Where(x => x.ID == id).FirstOrDefault();
                    data.status = 0;
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Xóa tiểu dự án thành công!" };
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = " Tiểu dự án không tồn tại vui lòng thử lại!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = " Xóa tiểu dự án thất bại vui lòng thử lại!" };
            }
        }

        public TieuDuanDetailModelOuput TieuDaDetail (int? id)
        {
            try
            {
                if(id.HasValue)
                {
                    var data = cnn.tbl_tieuduan.Where(x => x.ID == id).Select(c => new TieuDuanDetailModelOuput
                    {
                        ID = c.ID,
                        Maduan = c.Maduan,
                        Matieuduan = c.Matieuduan,
                        MaCDT = c.MaCDT,
                        Tentieuduan = c.Tentieuduan,
                        Diadiemkhobac = c.Diadiemkhobac,
                        Mota = c.Mota,
                        Ngaytao =c.Ngaytao.HasValue? c.Ngaytao.ToString():"Chưa cập nhật",
                        Ngaysua =c.Ngaysua.HasValue?c.Ngaysua.ToString():"Chưa cập nhật",
                        Nguoisua = c.Nguoisua,
                        Nguoitao=c.Nguoitao

                    }).FirstOrDefault();
                    return data;
                }  
                else
                {
                    return new TieuDuanDetailModelOuput();
                }    
            }
            catch
            {
                return new TieuDuanDetailModelOuput();
            }
        }
        public ExcelPackage ReportDuan(string nameandkey, int? tinh = null, int? chudatu = null, int? id = null)
        {
            try
            {
                var data = SearchDaAdmin(nameandkey, tinh, chudatu, id);
                FileInfo file = new FileInfo(HttpContext.Current.Server.MapPath(@"/Template/ReportDuan.xlsx"));
                ExcelPackage pack = new ExcelPackage(file);
                ExcelWorksheet sheet = pack.Workbook.Worksheets[0];
                int row = 3;
                int stt = 1;
                foreach (var item in data)
                {
                    sheet.Cells[row, 1].Value = stt;
                    sheet.Cells[row, 2].Value = item.Code;
                    sheet.Cells[row, 3].Value = item.TenDa;
                    sheet.Cells[row, 4].Value = item.DiaDiem;
                    sheet.Cells[row, 5].Value = item.Chudautu;
                    sheet.Cells[row, 6].Value = item.Diadiemkhobac;
                    sheet.Cells[row, 7].Value = item.Hinhthucquanli;
                    sheet.Cells[row, 8].Value = cnn.tbl_nguonvon.Where(u => u.ID == item.Idloainguonvon).Select(u => u.Tennguonvon).SingleOrDefault();
                    sheet.Cells[row, 9].Value = item.Tongdautu;
                    sheet.Cells[row, 10].Value = item.Thoigianthicong;
                    sheet.Cells[row, 11].Value = item.DateComplete;
                    sheet.Cells.AutoFitColumns();
                    stt++;
                    row++;

                }
                return pack;
            }catch
            {
                return null;
            }

        }


        public ExcelPackage ReportTieuDuan(int? idduan, int? chudautu, string name)
        {
            try
            {
                var data = SreachTieuDuan(idduan,chudautu,name);
                FileInfo file = new FileInfo(HttpContext.Current.Server.MapPath(@"/Template/ReportTieuDuan.xlsx"));
                ExcelPackage pack = new ExcelPackage(file);
                ExcelWorksheet sheet = pack.Workbook.Worksheets[0];
                int row = 3;
                int stt = 1;
                foreach (var item in data)
                {
                    sheet.Cells[row, 1].Value = stt;
                    sheet.Cells[row, 2].Value = item.code;
                    sheet.Cells[row, 3].Value = item.Tentieuda;
                    sheet.Cells[row, 4].Value = cnn.tbl_duan.Where(u=>u.Id.ToString()==item.Maduan).Select(u=>u.Tenduan).FirstOrDefault();
                    sheet.Cells[row, 5].Value = item.Chudautu;
                    sheet.Cells[row, 6].Value = item.Diadiem;
                    sheet.Cells[row, 7].Value = item.Mota;
           
                    sheet.Cells.AutoFitColumns();
                    stt++;
                    row++;

                }
                return pack;
            }
            catch
            {
                return null;
            }

        }

        public List<tbl_von_dieuchinh> VonDieuChinh(int?idvon)
        {
            try
            {
                if(idvon.HasValue)
                {
                    var data = cnn.tbl_von_dieuchinh.Where(u => u.Mavon == idvon&&(cnn.tbl_von.FirstOrDefault(c=>c.ID==u.Mavon).state!=0)).ToList();
                    return data;
                }    
                else
                {
                    return new List<tbl_von_dieuchinh>();
                }    
            }
            catch
            {
                return new List<tbl_von_dieuchinh>();
            }
        }

    }
}