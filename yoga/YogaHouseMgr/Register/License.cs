using System;
using System.Collections.Generic;
using System.Text;

namespace Register
{
    class License
    {
        Random randomNumber = new Random();

        string arr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcedfghijklmnopqrstuvwxyz0123456789";

        public string confuse(int y, int m, int d)
        {
            char[] c = new char[10];         
            for (int i = 0; i < 10; i++)
            {
                int rand = randomNumber.Next(arr.Length);
                c[i] = arr[rand];
            }
            string m_ = string.Format("{0:00}", m);
            string y_ = string.Format("{0:00}", y);
            string d_ = string.Format("{0:00}", d);
            return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}",
                c[0],c[1],m_[0],c[2],
                m_[1],c[3],c[4],y_[0],
                y_[1],c[5],d_[0],c[6],
                d_[1],c[7],c[8],c[9]);
        }

        /// <summary>
        /// 服务器端Base64编码
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string base64Encode(string data)
        {
            try
            {
                byte[] encData_byte = new byte[data.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(data);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Encode" + e.Message);
            }
        }
        /// <summary>
        /// 服务器端Base64解码
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string base64Decode(string data)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();
                byte[] todecode_byte = Convert.FromBase64String(data);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Decode" + e.Message);
            }
        }

        public string encode(string src) {
            string m = base64Encode(src);
            return string.Format("{0}{1}{2}{3}{4}{5}-{6}{7}{8}{9}{10}{11}-{12}{13}{14}{15}{16}{17}-{18}{19}{20}{21}{22}{23}",
                m[0],m[1],m[2],m[3],m[4],m[5],
                m[6],m[7],m[8],m[9],m[10],m[11],
                m[12],m[13],m[14],m[15],m[16],m[17],
                m[18],m[19],m[20],m[21],m[22],m[23]);
        }

        public int[] decode(string src)
        {
            string tmp = "";
            for (int i = 0; i < src.Length; ++i)
            {
                if (i == 6 || i == 13 || i == 20)
                    continue;
                tmp += src[i];
            }
            string dst = base64Decode(tmp);
            string y = string.Format("{0}{1}", dst[7], dst[8]);
            string m = string.Format("{0}{1}", dst[2], dst[4]);
            string d = string.Format("{0}{1}", dst[10], dst[12]);
            int[] r = { Convert.ToInt32(y), Convert.ToInt32(m), Convert.ToInt32(d)};
            return r;
        }
    }
}
