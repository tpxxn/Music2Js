using System;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;

namespace Music2Js
{
    public class XMLConvert
    {
        /// <summary>
        /// 创建 xml 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToXml<T>(T obj)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StringWriter writer = new StringWriter(CultureInfo.InvariantCulture);
                serializer.Serialize(writer, obj);

                string xml = writer.ToString();
                writer.Close();
                writer.Dispose();
                return xml;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        /// <summary>
        /// xml反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T GetT<T>(string xml)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StringReader reader = new StringReader(xml);

                T res = (T)serializer.Deserialize(reader);
                reader.Close();
                reader.Dispose();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}