﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Oke_teacher.Uitls
{
    public static class HttpUitls
    {
        #region 发送Get请求，携带JSON数据
        /// <summary>
        /// 发送Get请求，携带JSON数据
        /// </summary>
        /// <param name="url">服务接口地址</param>
        /// <param name="data">json格式数据</param>
        /// <returns></returns>
        public static string Get(string url, string data)
        {
            string _url = url;
            string jsonParam = data;
            var request = (HttpWebRequest)WebRequest.Create(_url);
            request.Method = "GET";
            request.ContentType = "application/json;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(myResponseStream);
            string retString = streamReader.ReadToEnd();
            streamReader.Close();
            myResponseStream.Close();
            return retString;
        }
        #endregion

        #region 发送Post请求，携带JSON数据
        /// <summary>
        /// 发送Post请求，携带JSON数据
        /// </summary>
        /// <param name="url">服务接口地址</param>
        /// <param name="data">json格式数据</param>
        /// <returns></returns>
        public static string POST(string url, string data)
        {
            string _url = url;
            string jsonParam = data;
            var request = (HttpWebRequest)WebRequest.Create(_url);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteData = Encoding.UTF8.GetBytes(jsonParam);
            int length = byteData.Length;
            request.ContentLength = length;
            Stream writer = request.GetRequestStream();
            writer.Write(byteData, 0, length);
            writer.Close();
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8")).ReadToEnd();
            return responseString.ToString();
        }
        #endregion
    }
}
