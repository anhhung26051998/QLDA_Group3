using Data.Connect;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QLDA.Common;

namespace Data.Business
{
    public class DropDownBusiness:GenericBusiness
    {
        public DropDownBusiness (QLDAEntities context=null):base()
        {

        }
        public List<TinhModelOutput> GetTinh()
        {
            try
            {
                var data = cnn.tbl_tinh.Select(c => new TinhModelOutput
                {
                    Id = c.ID,
                    TenTinh = c.TenTinh
                }).OrderBy(t => t.TenTinh).ToList();
                return data;
            }
            catch
            {
                return new List<TinhModelOutput>();
            }
        }
        public List<ChuDauTuModelOutput> Getchudautu()
        {
            try
            {
                var data = cnn.tbl_chudautu.Where(u=>u.status!=0).Select(u => new ChuDauTuModelOutput
                {
                    Id = u.ID,
                    Tenchudautu = u.TenCDT
                }).OrderBy(c => c.Tenchudautu).ToList();
                return data;
            }
            catch
            {
                return new List<ChuDauTuModelOutput>();
            }
        }


        public List<DropDownModelOutput> GetallHTQL()
        {
            try
            {
                var data = cnn.tbl_hinhthucqlda.Select(u => new DropDownModelOutput
                {
                    Id = u.ID,
                    Value = u.TenhinhthucQLDA
                }).OrderByDescending(t => t.Id).ToList();
                return data;
            }
            catch
            {
                return new List<DropDownModelOutput>();
            }
        }
        public List<DropDownModelOutput> GetallLoaivon()
        {
            try
            {
                var data = cnn.tbl_nguonvon.Select(u => new DropDownModelOutput
                {
                    Id = u.ID,
                    Value = u.Tennguonvon
                }).OrderByDescending(t => t.Id).ToList();
                return data;
            }
            catch
            {
                return new List<DropDownModelOutput>();
            }
        }
        public List <DropDownModelOutput> GetloaiCDT()
        {
            try
            {
                return cnn.tbl_loaiCDT.Select(c => new DropDownModelOutput
                {
                    Id = c.ID,
                    Value = c.TenloaiCDT
                }).OrderByDescending(t => t.Value).ToList();
            }
            catch
            {
                return new List<DropDownModelOutput>();
            }
        }

        public List<DropDownModelOutput>GetRole()
        {
            try
            {
                return (cnn.tbl_z_roles.Select(c => new DropDownModelOutput {
                    Id = c.Role_Id,
                    Value = c.RoleName
                })).OrderBy(t => t.Id).ToList();
            }
            catch
            {
                return new List<DropDownModelOutput>();
            }
        }


        public int GetOverview(int?type)
        {
            switch (type)
            {

                //duan
                case 1:
                    {
                        return cnn.tbl_duan.Where(u => u.status.HasValue ? u.status != 0 : true).Count();
                    }
                //chủ đầu tư
                case 2:
                    {
                        return cnn.tbl_chudautu.Where(u => u.status.HasValue ? u.status != 0 : true).Count();
                    }

                    /// tiểu dự ấn
                case 3:
                    {
                        return cnn.tbl_tieuduan.Where(u => u.status.HasValue ? u.status != 0 : true).Count();
                    }
                    //user
                case 4:
                    {
                        return cnn.tbl_z_users.Where(u => (u.Inactive.HasValue ? u.Inactive != true : true)).Count();
                    }
                    

                default:
                    return 0;
                 

                        


               
            }    
        }

        public List<DropDownModelOutput>GetDuan()
        {
            return cnn.tbl_duan.Where(u => (u.status.HasValue ? u.status != 0 : true)).Select(c => new DropDownModelOutput
            {
                Id = c.Id,
                Value = c.Tenduan
            }).OrderByDescending(t=>t.Value).ToList();
        }
        public List<DropDownModelOutput> GetTieuDuan()
        {
            return cnn.tbl_tieuduan.Where(u => (u.status.HasValue ? u.status != 0 : true)).Select(c => new DropDownModelOutput
            {
                Id = c.ID,
                Value = c.Tentieuduan
            }).OrderByDescending(t => t.Value).ToList();
        }
    }
}