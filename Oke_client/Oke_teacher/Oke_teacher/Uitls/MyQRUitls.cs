using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace Oke_teacher.Uitls
{
    public class MyQRUitls
    {
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="barcodeText">文本</param>
        /// <returns>图片</returns>
        public static Bitmap BarcodeImage(String barcodeText)
        {

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeVersion = 0;
            Bitmap img = qrCodeEncoder.Encode(barcodeText, Encoding.UTF8);//指定utf-8编码， 支持中文
            return img;

            //string httpFileName = System.Environment.CurrentDirectory;
            //string fileName = "/a.jpg";
            //img.Save(httpFileName + fileName);//保存位图 
        }

        /// <summary>
        /// 解析二维码文本
        /// </summary>
        /// <param name="bitmap">图片对象</param>
        /// <returns></returns>
        public string QRCodeDecoderUtil(Bitmap bitmap)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            string decodedString = "";
            try
            {
                decodedString = decoder.decode(new QRCodeBitmapImage(bitmap), Encoding.UTF8);//指定utf-8编码， 支持中文  
            }
            catch (Exception)
            {
                return "请先生成二维码！";
            }
            return decodedString;
        }
    }
}
