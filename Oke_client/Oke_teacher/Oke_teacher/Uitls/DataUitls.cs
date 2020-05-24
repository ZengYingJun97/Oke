using Oke_teacher.Dto;
using Oke_teacher.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Uitls
{
    public static class DataUitls
    {

        #region 将数据存入data.bin
        /// <summary>
        /// 将数据存入data.bin
        /// </summary>
        /// <param name="userData"></param>
        public static void saveData(UserData userData)
        {
            string path = Environment.SpecialFolder.MyDocuments.ToString() + @"\Oke";
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            FileStream fs = new FileStream(path + @"\data.bin", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, userData);
            fs.Close();
        }
        #endregion

        #region 从data.bin获得数据
        /// <summary>
        /// 从data.bin获得数据
        /// </summary>
        /// <returns></returns>
        public static UserData loadData()
        {
            string path = Environment.SpecialFolder.MyDocuments.ToString() + @"\Oke";
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            FileStream fs = new FileStream(path + @"\data.bin", FileMode.OpenOrCreate);

            UserData userData = null;
            if (fs.Length > 0)
            {
                BinaryFormatter bf = new BinaryFormatter();
                userData = bf.Deserialize(fs) as UserData;
            }
            fs.Close();

            if (userData == null)
            {
                userData = new UserData();
                User user = new User();
                userData.isSaveUser = false;
                userData.user = user;
            }

            return userData;
        }
        #endregion
    }
}
