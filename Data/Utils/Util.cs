
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.IO;
using System.Web;

namespace Data.Utils
{
    public class Util
    {

        public static object Users { get; private set; }

        //public static TokenOutputModel checkToken(string token)
        //{
        //    CarRectEntities cnn = new CarRectEntities();
        //    TokenOutputModel output = cnn.Members.Where(u => u.Token.Equals(token) && u.IsActive.Equals(SystemParam.ACTIVE) && u.IsLogin.Value.Equals(SystemParam.ACTIVE)).Select(u => new TokenOutputModel { AgentID = u.AgentID, CustomerID = u.CustomerID, MemberID = u.ID }).FirstOrDefault();
        //    if (output != null && !String.IsNullOrEmpty(token) && token.Length > 0)
        //    {
        //        Wallet wallet = cnn.Wallets.Where(u => u.MemberID.Equals(output.MemberID) && u.IsActive.Equals(SystemParam.ACTIVE)).FirstOrDefault();
        //        if (wallet != null)
        //            return output;
        //        else
        //            return null;
        //    }
        //    else
        //        return null;

        //}
        public static void DeleteIamgeLocal(string url)
        {
            try
            {
                string rootFolder = HttpContext.Current.Server.MapPath(@"\Uploads\");
                string[] str = url.Split('/');
                string[] files = Directory.GetFiles(rootFolder);
                foreach (string file in files)
                {
                    string fileName = rootFolder + str[str.Length - 1];
                    if (file.Equals(fileName))
                    {
                        File.Delete(file);
                        Console.WriteLine($"{file} is deleted.");
                    }
                }
            }
            catch { }
        }
        public static double Distance(double la1, double lo1, double la2, double lo2)
        {
            double dLat = (la2 - la1) * (Math.PI / 180);
            double dLon = (lo2 - lo1) * (Math.PI / 180);
            double la1ToRad = la1 * (Math.PI / 180);
            double la2ToRad = la2 * (Math.PI / 180);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(la1ToRad) * Math.Cos(la2ToRad) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = 6371 * c;
            return Math.Round(d, 3);
        }

        //public static string ConvertDateTimeActual(DateTime dateTime, List<Shift> listShift)
        //{
        //    var listTime = listShift.Select(u => new
        //    {
        //        Date = DateTime.ParseExact(u.shift1, SystemParam.CONVERT_DATETIME_HOUR, null)
        //    }).Where(u => u.Date.TimeOfDay >= dateTime.TimeOfDay).FirstOrDefault();
        //    if (listTime == null)
        //    {
        //        listTime = listShift.Select(u => new
        //        {
        //            Date = DateTime.ParseExact(u.shift1, SystemParam.CONVERT_DATETIME_HOUR, null)
        //        }).FirstOrDefault();
        //    }
        //    DateTime time = dateTime.Date.AddHours(listTime.Date.Hour).AddMinutes(listTime.Date.Minute);
        //    return time.ToString(SystemParam.CONVERT_DATETIME_HAVE_HOUR);
        //}
        public static string CreateMD5(string input)
        {
            //bam du lieu
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public static string CheckNullString(string input)
        {
            string output = "";
            try
            {
                output = input.ToString();
            }
            catch
            {

            }
            return output;
        }
        private static readonly string[] VietNamChar = new string[]
        {
        "aAeEoOuUiIdDyY",
        "áàạảãâấầậẩẫăắằặẳẵ",
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
        "éèẹẻẽêếềệểễ",
        "ÉÈẸẺẼÊẾỀỆỂỄ",
        "óòọỏõôốồộổỗơớờợởỡ",
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
        "úùụủũưứừựửữ",
        "ÚÙỤỦŨƯỨỪỰỬỮ",
        "íìịỉĩ",
        "ÍÌỊỈĨ",
        "đ",
        "Đ",
        "ýỳỵỷỹ",
        "ÝỲỴỶỸ"
        };
        public static string Converts(string str)
        {
            try
            {
                if (!String.IsNullOrEmpty(str) && str.Length > 0)
                {
                    //Thay thế và lọc dấu từng char      
                    for (int i = 1; i < VietNamChar.Length; i++)
                    {
                        for (int j = 0; j < VietNamChar[i].Length; j++)
                            str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                    }
                    return str.ToLower();
                }
                return str;
            }
            catch
            {
                return "";
            }
        }
        public static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            else
                return builder.ToString().ToUpper();
        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public static string ConvertPhone(string phonenumber)
        {
            if (phonenumber.Contains("+84"))
            {
                int length = phonenumber.Length - 3;
                phonenumber = "0" + phonenumber.Substring(3, length);
            }
            return phonenumber;
        }

        /// <summary>
        /// Code SeriCard
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Code(string text)
        {
            char[] charArr = text.ToCharArray();
            byte[] input = Encoding.ASCII.GetBytes(charArr);
            List<string> lsoutput = new List<string>();
            foreach (byte by in input)
            {
                int value = (int)((by * SystemParam.KeyA) % SystemParam.KeyB + SystemParam.KeyC);
                string valuestr = Encoding.ASCII.GetString(new byte[] { (byte)value });
                lsoutput.Add(valuestr);
            }
            int balance1 = (int)((48 * SystemParam.KeyA) / SystemParam.KeyB);
            int balance2 = (int)((57 * SystemParam.KeyA) / SystemParam.KeyB);
            lsoutput.Add("!" + balance1.ToString());
            lsoutput.Add("!" + balance2.ToString());
            string output = DateTime.Now.ToString("HHyyyyssddmmMM!");
            foreach (string o in lsoutput)
            {
                output += o;
            }
            return output;
        }
        /// <summary>
        /// EnCode Card   
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EnCode(string text)
        {
            string[] lsString = text.Split('!');
            string inputstr = lsString[lsString.Length - 3];
            int balance1 = int.Parse(lsString[lsString.Length - 2]);
            int balance2 = int.Parse(lsString[lsString.Length - 1]);
            char[] charArr = inputstr.ToCharArray();
            byte[] input = Encoding.ASCII.GetBytes(charArr);
            string lsoutput = "";
            foreach (byte c in input)
            {
                float value = (c - SystemParam.KeyC + SystemParam.KeyB * balance1) / SystemParam.KeyA;
                if (value < 48 || value > 57 || value != (int)value)
                    value = (c - SystemParam.KeyC + SystemParam.KeyB * balance2) / SystemParam.KeyA;
                string output = Encoding.ASCII.GetString(new byte[] { (byte)value });
                lsoutput += output;
            }
            return lsoutput;
        }


        //Convert Datetime 
        public static DateTime? ConvertDate(string date)
        {
            try
            {
                return DateTime.ParseExact(date, SystemParam.CONVERT_DATETIME, null);
            }
            catch
            {
                return null;
            }
        }

        //get name TYPE_ADD 
        public static string GetNameType(int ID)
        {
            string result = "";
            switch (ID)
            {
                case 1: result = "Tích điểm"; break;
                case 2: result = "Tặng điểm"; break;
                case 3: result = "Được tặng điểm"; break;
                case 4: result = "Đổi quà"; break;
                case 5: result = "Hệ thống cộng điểm"; break;
                case 6: result = "Đổi thẻ"; break;
                case 7: result = "Hủy yêu cầu đổi quà"; break;
            }
            return result;
        }

        public static string GetNameStatusWarranty(int Status)
        {
            string result = "";
            switch (Status)
            {
                case 1: result = "Đã tích điểm"; break;
                case 2: result = "Chưa tích điểm"; break;
            }
            return result;
        }

    }

}
