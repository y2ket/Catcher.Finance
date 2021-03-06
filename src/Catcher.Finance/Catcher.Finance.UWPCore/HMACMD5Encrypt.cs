﻿using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;


namespace Catcher.Finance.UWPCore
{
    class HMACMD5Encrypt
    {
        const string encryptKey = "c1a2t3c4h5e6r.";

        /// <summary>
        /// HMACMD5 encrypt
        /// </summary>
        /// <param name="data">the date to encrypt</param>
        /// <param name="key">the key used in HMACMD5</param>
        /// <returns></returns>
        public static string GetEncryptResult(string data, string key = encryptKey)
        {
            string str_alg_name = MacAlgorithmNames.HmacMd5;
            MacAlgorithmProvider obj_mac_prov = MacAlgorithmProvider.OpenAlgorithm(str_alg_name);
            IBuffer buff_msg = CryptographicBuffer.CreateFromByteArray(Encoding.UTF8.GetBytes(data));
            IBuffer buff_key_material = CryptographicBuffer.CreateFromByteArray(Encoding.UTF8.GetBytes(key));
            CryptographicKey hmac_key = obj_mac_prov.CreateKey(buff_key_material);
            IBuffer hmac = CryptographicEngine.Sign(hmac_key, buff_msg);
            byte[] digest = hmac.ToArray();
            return "";
        }
    }
}
