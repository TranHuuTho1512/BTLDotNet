using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QuanLyPhongTro
{
    public static class RegularExpression
    {
        public static string LTrim(this string s)
        {
            //"    Le Tan Dung"
            int i = 0;
            while (s[i] == ' ')
            {
                i++;
            }
            s = s.Substring(i);
            return s;
            //"Le Tan Dung"
        }
        public static string RTrim(this string s)
        {
            //"Le Tan Dung    "
            int i = s.Length - 1;
            while (s[i] == ' ')
            {
                i--;
            }
            s = s.Substring(0, i + 1);
            return s;
            //"Le Tan Dung"
        }

        public static string MTrim(this string s)
        {
            //"    Le Tan      Dung"
            while (s.IndexOf("  ") >= 0)
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
        public static String PerfectString(this String s)
        {
            //"    Le Tan      Dung    "
            //s = s.LTrim();
            //s = s.MTrim();
            //s = s.RTrim();
            s = s.LTrim().MTrim().RTrim();
            s = " " + s;
            //" Le Tan Dung"
            s = s.ToLower();//" le tan dung" 
            foreach (Match item in Regex.Matches(s, @"\s\S"))
            {
                s = s.Replace(item.Value, item.Value.ToUpper());
            }
            // hoa dau moi tu
            //" Le Tan Dung" 
            return s.Substring(1);//==> "Le Tan Dung"
        }
        public static Boolean FulNameCheck(this String str)
        {

            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                "đ",
                "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                "í","ì","ỉ","ĩ","ị",
                "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                "d",
                "e","e","e","e","e","e","e","e","e","e","e",
                "i","i","i","i","i",
                "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                "u","u","u","u","u","u","u","u","u","u","u",
                "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                str = str.Replace(arr1[i], arr2[i]);
                str = str.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return Regex.Match(str, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$").Success;
        }
        public static Boolean EmailCheck(this String s)
        {
            return Regex.Match(s, @"^(\w+@\w+([.][a-zA-Z]+){1,4})$").Success;
        }
        public static Boolean PhoneCheck(this String s)
        {
            return Regex.Match(s, @"^([0][0-9]{9})$").Success;
        }
        public static bool IsNumber(this String s)
        {
            return Regex.Match(s, @"^\d*(\.\d)?$").Success;
        }
        public static Boolean TenPhongCheck(this String s)
        {
            return Regex.Match(s, @"(^[A-Z][1-9]{0,1}[.][1-9]{0,2})$").Success;
        }
        public static Boolean WordAndNumberCheck(this String s)
        {
            return Regex.Match(s, @"(^[A-Z][1-9]{10,15})$").Success;
        }
    }
}
