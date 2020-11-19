using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace RSA注册机
{
    public class Rsa2Helper
    {
        #region 公开方法

        /// <summary>
        /// 使用私钥生成激活码
        /// </summary>
        /// <param name="machCode">机器码</param>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string CreateUseCode(string machCode, string privateKey)
        {
            try
            {
                return string.IsNullOrEmpty(machCode) ? "请输入正确的机器码!" : EncryptByPrivateKey(machCode, privateKey);
            }
            catch
            {
                return "生成失败";
            }
        }

        /// <summary>
        /// 客户端解密
        /// </summary>
        /// <param name="s"></param>
        /// <param name="publicKdy"></param>
        /// <returns></returns>
        public static string DecryptByPublicKey(string s, string publicKdy)
        {
            s = s.Replace("\r", "").Replace("\n", "").Replace(" ", "");
            //非对称加密算法，加解密用
            IAsymmetricBlockCipher engine = new Pkcs1Encoding(new RsaEngine());
            //解密
            try
            {
                engine.Init(false, GetPublicKeyParameter(publicKdy));
                byte[] byteData = Convert.FromBase64String(s);
                var resultData = engine.ProcessBlock(byteData, 0, byteData.Length);
                return System.Text.Encoding.UTF8.GetString(resultData);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 验证激活码
        /// </summary>
        /// <param name="machCode">机器码</param>
        /// <param name="useCode">激活码</param>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static bool Verify(string machCode, string useCode, string publicKey)
        {
            try
            {
                if (string.IsNullOrEmpty(machCode)) return false;

                var enCode = DecryptByPublicKey(useCode, publicKey);
                return !string.IsNullOrEmpty(enCode) && machCode.Equals(enCode);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 将字符串进行md5加密
        /// </summary>
        /// <param name="str">返回16位字符串</param>
        /// <returns></returns>
        public static string GetMd5Length16(string str)
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var t2 = BitConverter.ToString(md5.ComputeHash(buffer: Encoding.Default.GetBytes(str)), 4, 8);
            t2 = t2.Replace("-", "");
            md5.Dispose();
            return t2;
        }

        /// <summary>
        /// 生成公钥和私钥
        /// </summary>
        /// <param name="publicKey"></param>
        /// <param name="privateKey"></param>
        public static void GenerateSecretKey(out string publicKey, out string privateKey)
        {
            //RSA密钥对的构造器
            var keyGenerator = new RsaKeyPairGenerator();
            //RSA密钥构造器的参数
            var param = new RsaKeyGenerationParameters(
                    Org.BouncyCastle.Math.BigInteger.ValueOf(3),
                new Org.BouncyCastle.Security.SecureRandom(),
                1024,   //密钥长度
                25);
            //用参数初始化密钥构造器
            keyGenerator.Init(param);
            //产生密钥对
            var keyPair = keyGenerator.GenerateKeyPair();

            if (((RsaKeyParameters)keyPair.Public).Modulus.BitLength < 1024)
            {
                throw new OutputLengthException("failed key generation (1024) length test");
            }

            var subjectPublicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(keyPair.Public);
            var privateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(keyPair.Private);

            var asn1ObjectPublic = subjectPublicKeyInfo.ToAsn1Object();
            var publicInfoByte = asn1ObjectPublic.GetEncoded("UTF-8");
            var asn1ObjectPrivate = privateKeyInfo.ToAsn1Object();
            var privateInfoByte = asn1ObjectPrivate.GetEncoded("UTF-8");

            publicKey = Convert.ToBase64String(publicInfoByte);
            privateKey = Convert.ToBase64String(privateInfoByte);

            //TextWriter textWriter = new StringWriter();
            //var pemWriter = new PemWriter(textWriter);
            //pemWriter.WriteObject(keyPair.Private);
            //pemWriter.Writer.Flush();

            //privateKey = textWriter.ToString();

            //textWriter = new StringWriter();
            //pemWriter = new PemWriter(textWriter);
            //pemWriter.WriteObject(keyPair.Public);
            //pemWriter.Writer.Flush();
            //publicKey = textWriter.ToString();
        }

        #endregion 公开方法

        #region 私有方法

        private static AsymmetricKeyParameter GetPublicKeyParameter(string publicKdy)
        {
            publicKdy = publicKdy.Replace("\r", "").Replace("\n", "").Replace(" ", "");
            byte[] publicInfoByte = Convert.FromBase64String(publicKdy);
            //Asn1Object pubKeyObj = Asn1Object.FromByteArray(publicInfoByte);//这里也可以从流中读取，从本地导入
            AsymmetricKeyParameter pubKey = PublicKeyFactory.CreateKey(publicInfoByte);

            return pubKey;
        }

        private static AsymmetricKeyParameter GetPrivateKeyParameter(string s)
        {
            s = s.Replace("\r", "").Replace("\n", "").Replace(" ", "");
            var privateInfoByte = Convert.FromBase64String(s);
            var priKey = PrivateKeyFactory.CreateKey(privateInfoByte);
            return priKey;
        }

        private static string EncryptByPrivateKey(string s, string privateKey)
        {
            //非对称加密算法，加解密用
            IAsymmetricBlockCipher engine = new Pkcs1Encoding(new RsaEngine());
            engine.Init(true, GetPrivateKeyParameter(privateKey));
            var byteData = System.Text.Encoding.UTF8.GetBytes(s);
            var resultData = engine.ProcessBlock(byteData, 0, byteData.Length);
            return Convert.ToBase64String(resultData);
        }


        #endregion 私有方法
    }
}