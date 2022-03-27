using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart04
{
    internal class Helper
    {
        public static void message(string mes)
        {
            MessageBox.Show(mes,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static string PathProfile = Directory.GetCurrentDirectory().Replace(@"bin\Debug", string.Empty) + @"images\profile_pictures\";
        public static string PathProduct = Directory.GetCurrentDirectory().Replace(@"bin\Debug", string.Empty) + @"images\products\";
        public static string GetProfile(string name)
        {
            FileInfo[] fileInfos = new DirectoryInfo(PathProfile).GetFiles("*"+name+"*.*");
            if(fileInfos.Length > 0) return fileInfos[0].FullName;
            else return null;
        }
        public static string GetRandomString(int a)
        {
            Random random = new Random();
            var ran = new string(Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890", a)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return ran;
        }
        public static string GetProduct(string name)
        {
            FileInfo[] fileInfos = new DirectoryInfo(PathProduct).GetFiles("*"+name+"*.*");
            if(fileInfos.Length > 0) return fileInfos[0].FullName;
            else return null;
          
        }
        public static Regex validPIN = new Regex(@"[\w]{6}");
        public static int id, stock, qty, price;
        public static string name, imagename, category, namePayment, code;
        public static List<Model> models = new List<Model>();
        public static Model model;
    }
}
