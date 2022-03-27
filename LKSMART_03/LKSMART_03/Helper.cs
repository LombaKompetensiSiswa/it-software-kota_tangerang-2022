using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMART_03
{
    internal class Helper
    {
        public static string pathProfile = Directory.GetCurrentDirectory().Replace(@"bin\Debug",string.Empty) + @"images\profile_pictures\";
        public static string pathProduct = Directory.GetCurrentDirectory().Replace(@"bin\Debug", string.Empty) + @"images\products\";
        public static void showMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void saveFile(string source,string dessource,bool v)
        {
            try
            {
                File.Copy(source, dessource, true);
            }
            catch
            { 
            }
        }
        public static Random rndm = new Random();
        public static string RandomCode(int a)
        {
            const string codess = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(codess, a).Select(s => s[rndm.Next(s.Length)]).ToArray());
        }
        public static string GetprofilePictures(string imageName)
        {
            try
            {
                FileInfo[] f = new DirectoryInfo(pathProfile).GetFiles("*" + imageName + "*.*");
                if (f.Length > 0)
                {
                    return f[0].FullName;
                }
                else
                {
                    return null;
                }
            }
            catch 
            {
                return null;
            }
        }
        public static string GetProductPictures(string imageName)
        {
            try
            {
                FileInfo[] f = new DirectoryInfo(pathProduct).GetFiles("*" + imageName + "*.*");
                if (f.Length > 0)
                {
                    return f[0].FullName;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        public static CartClass cc = new CartClass();
        public static List<CartClass> lc = new List<CartClass>();
        public static string paymentCode;
        public static string paymentType;

    }
}
