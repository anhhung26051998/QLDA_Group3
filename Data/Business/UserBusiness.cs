using Data.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Utils;
using Newtonsoft.Json;
using QLDA.Common;
using Data.Model;
using IdeaBlade.Linq;
using System.Text.RegularExpressions;

namespace Data.Business
{     
    public class UserBusiness:GenericBusiness
    {
            
        public UserBusiness(QLDAEntities context =null):base()
        {

        }
        public bool CheckRole()
        {
            var roleid = Int16.Parse(HttpContext.Current.Request.Headers["Role"].ToString());
            var Role = cnn.tbl_z_roles.Find(roleid);
            return Role.IsSysAdmin.HasValue?(Role.IsSysAdmin==true?true:false):false;
        }

        public LoginModelOutput Login(string UserName, string PassWord)
        {



            try
            {
                var Pass = Util.CreateMD5(PassWord).ToLower();
                var user = cnn.tbl_z_users.Where(u => u.Username==UserName && u.Password==Pass&&(u.Inactive.HasValue?u.Inactive!=true:true)).FirstOrDefault();
                if (user == null)
                {
                    return (new LoginModelOutput { token = "", UserId = -1 });
                }
                else
                {
                    user.token = Util.CreateMD5(DateTime.Now.ToString());
                    tbl_z_logaccess log = new tbl_z_logaccess();
                    log.User_Id = user.User_Id;
                    log.UserName = user.Username;
                    log.status = true;
                    log.created_at = DateTime.Now;
                    cnn.tbl_z_logaccess.Add(log);
                    cnn.SaveChanges();
                    var token = cnn.tbl_z_users.Find(user.User_Id).token.ToString();
                    
                    return (new LoginModelOutput { token = token, UserId = user.User_Id,Role=user.IdRole,IdCDT=user.IdChudautu});
                }
            }
            catch (Exception ex)
            {
                return (new LoginModelOutput { token = ex.ToString(), UserId = -1 });
            }
        }

        public void Logout(int? Userid)
        {
            try
            {
                var user = cnn.tbl_z_users.Find(Userid);
                tbl_z_logaccess log = new tbl_z_logaccess();
                log.User_Id = user.User_Id;
                log.UserName = user.Username;
                log.status = false;
                log.created_at = DateTime.Now;
                cnn.tbl_z_logaccess.Add(log);
                cnn.SaveChanges();
                return;
            }
            catch
            {
                return;
            }
        }

        
        public ResultModel AddUser(tbl_z_users us)
        {
            try
            {
                
                if (CheckRole())
                { if(cnn.tbl_z_users.Where(x=>x.Username.Equals(us.Username) &&( x.Inactive.HasValue ? x.Inactive != true : true)).Count()>0|| cnn.tbl_z_users.Where(x => x.IdChudautu==us.IdChudautu && (x.Inactive.HasValue ? x.Inactive != true : true)).Count()>0)
                    {
                        return new ResultModel { Status = 0, Messege = "Tài khoản đã tồn tại!" };
                    }    
                   else
                    {
                       
                        if (Regex.IsMatch(us.Password.ToString(), @"^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#\$%\.\\/^\&*\)\(+=._-]).{8,20}$"))
                        {
                            us.Password = Util.CreateMD5(us.Password).ToLower();
                            us.tbl_z_roles1.Add(cnn.tbl_z_roles.Where(u => u.Role_Id == us.IdRole).FirstOrDefault());
                            cnn.tbl_z_users.Add(us);
                            cnn.SaveChanges();
                            return new ResultModel { Status = 1, Messege = "Thêm tài khoản thành công!" };
                        }
                        else
                        {
                            return  new ResultModel { Status = 0, Messege = "Mật khẩu không hợp lệ!" };
                        }    
                    }    
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Chỉ có admin mới có quyền thêm!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Thêm tài khoản thất bại!" };
            }
        }


        public ResultModel EditUser(tbl_z_users us)
        {
            try
            {
                var roleid = Int16.Parse(HttpContext.Current.Request.Headers["Role"].ToString());
                var Role = cnn.tbl_z_roles.Find(roleid);
                var data = cnn.tbl_z_users.Find(us.User_Id);
                if ( (data.IdChudautu!=us.IdChudautu&&us.IdChudautu!=null)?cnn.tbl_z_users.Where(u=>u.IdChudautu==us.IdChudautu).Count()>0:false)
                {
                    return new ResultModel { Status = 0, Messege = "Tài khoản đã tồn tại!" };
                }    
                else if (Role.IsSysAdmin == true)
                {
                  
                    data.Title = us.Title;
                    data.Mail = us.Mail;
                    data.Lastname = us.Lastname;
                    data.LastModified = DateTime.Now;
                    data.Initial = us.Initial;
                    data.IdRole = us.IdRole;
                    data.IdChudautu = us.IdChudautu;
                    data.Firstname = us.Firstname;
                    if(data.tbl_z_roles1.Count>0)
                    {
                        data.tbl_z_roles1.Clear();
                        data.tbl_z_roles1.Add(cnn.tbl_z_roles.Where(u => u.Role_Id == us.IdRole).FirstOrDefault());
                    }    
                    else
                    {
                        data.tbl_z_roles1.Add(cnn.tbl_z_roles.Where(u => u.Role_Id == us.IdRole).FirstOrDefault());
                    }   
                    cnn.SaveChanges();
                    return new ResultModel { Status = 1, Messege = "Sửa tài khoản thành công!" };
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Chỉ có admin mới có quyền sửa!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Sửa tài khoản thất bại!" };
            }
        }



        public ResultModel DeleteUser(int? id)
        {
            try
            {
                var roleid = Int16.Parse(HttpContext.Current.Request.Headers["Role"].ToString());
                var Role = cnn.tbl_z_roles.Find(roleid);
                var data = cnn.tbl_z_users.Find(id);
                if (Role.IsSysAdmin == true)
                {
                   
                  if(data==null||!id.HasValue)
                    {
                        return new ResultModel { Status = 0, Messege = "Tài khoản không tồn tại vui lòng thử lại!" };
                    }
                    else
                    { if (cnn.tbl_z_roles.Where(u => u.Role_Id == data.IdRole).Select(u => u.IsSysAdmin).FirstOrDefault() == true)
                        {
                            return new ResultModel { Status = 0, Messege = "Không thể xóa tài khoản admin vui lòng thử lại!" };
                        }
                        else
                        {
                            data.Inactive = true;
                            cnn.SaveChanges();
                            return new ResultModel { Status = 1, Messege = "Sửa tài khoản thành công!" };
                        }
                    }
                    
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Chỉ có admin mới có quyền sửa!" };
                }
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Sửa tài khoản thất bại!" };
            }
        }


        public List<UserModelOutput> SearchUser(string name )
        {
            try
            {
                return cnn.tbl_z_users.Where(u => name.Length > 0 ? (u.Firstname.Contains(name) || u.Lastname.Contains(name)) : true && u.Inactive.HasValue ? u.Inactive != true : true ).Select(c => new UserModelOutput {
                    User_Id = c.User_Id,
                    Firstname = c.Firstname,
                    Lastname = c.Lastname,
                    IdChudautu = c.IdChudautu,
                    IdRole = c.IdRole,
                    Mail = c.Mail,
                    Username = c.Username,
                    Initial = c.Initial,
                    Title = c.Title,
                    RoleName = cnn.tbl_z_roles.Where(x => x.Role_Id == c.IdRole).Select(x => x.RoleName).FirstOrDefault()


                }).ToList();
            }catch
            {
                return new List<UserModelOutput>();
            }
        }
        public UserModelOutput Userdetail(int?User_Id)
        {
            try
            {
                if (User_Id.HasValue)
                {
                    return cnn.tbl_z_users.Where(u => u.User_Id == User_Id && (u.Inactive.HasValue ? u.Inactive != true : true)).Select(c => new UserModelOutput
                    {
                        User_Id = c.User_Id,
                        Firstname = c.Firstname,
                        Lastname = c.Lastname,
                        IdChudautu = c.IdChudautu,
                        IdRole = c.IdRole,
                        Mail = c.Mail,
                        Username = c.Username,
                        Initial = c.Initial,
                        Title = c.Title,
                        RoleName = cnn.tbl_z_roles.Where(x=>x.Role_Id==c.IdRole).Select(x=>x.RoleName).FirstOrDefault()
                    }).FirstOrDefault();
                }
                else
                {
                    return new UserModelOutput();
                }
            }
            catch
            {
                return new UserModelOutput();
            }
        }


        public ResultModel ChangPass( string UserName, string PassWord,string PassWordNew)
        {
           try
            {
                if (UserName.Length <= 0 || PassWord.Length <= 0)
                {
                    return new ResultModel { Status = 0, Messege = "Tài khoản không tồn tại!" };
                }
                else if (Regex.IsMatch(PassWord, @"^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#\$%\.\\/^\&*\)\(+=._-]).{8,20}$"))
                {
                    var pass = Util.CreateMD5(PassWord).ToLower();
                    var data = cnn.tbl_z_users.Where(u => u.Username.Equals(UserName) && u.Password.Equals(pass)).FirstOrDefault();
                    if (data != null)
                    {
                        data.Password = Util.CreateMD5(PassWordNew).ToLower();
                        cnn.SaveChanges();
                        return new ResultModel { Status = 1, Messege = "Đổi mật khẩu thành công!" };
                    }
                    else
                    {
                        return new ResultModel { Status = 0, Messege = "Tài khoản không tồn tại!" };
                    }
                }
                else
                {
                    return new ResultModel { Status = 0, Messege = "Mật khẩu không hợp lệ!" };
                }    
                
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Đổi mật khẩu thất bại!" };
            }
        }


        public ResultModel ResetPass (int ?id)
        {
            try
            { if(CheckRole())
                {
                    var data = cnn.tbl_z_users.Where(u => u.User_Id == id && (u.Inactive.HasValue ? u.Inactive != true : true)).FirstOrDefault();
                    if (id.HasValue || data != null)
                    {
                        data.Password = Util.CreateMD5("Abc@12345").ToLower();
                        cnn.SaveChanges();
                        return new ResultModel { Status = 1, Messege = "Reset mật khẩu thành công!" };
                    }
                    else
                    {
                        return new ResultModel { Status = 0, Messege = "Tài khoản không tồn tại" };
                    }
                }
            else
                {
                    return new ResultModel { Status = 0, Messege = "Chỉ có admin mới có quyền thêm!" };
                }    
            }
            catch
            {
                return new ResultModel { Status = 0, Messege = "Reset mật khẩu thất bại" };
            }
        }
    }
}