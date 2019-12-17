using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace DesignPatternSample.Prototype
{
    static class ExtentionMethods
    {
        public static T DeepCopyBinary<T>(this T self) where T : class
        {
            if (self is null)
                return default;

            using (var stream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);

                return (T) binaryFormatter.Deserialize(stream);
            }
        }

        public static T DeepCopyXml<T>(this T self) where T : class
        {
            if (self is null)
                return default;

            using (var stream = new MemoryStream())
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(stream, self);
                stream.Position = 0;

                return (T)xmlSerializer.Deserialize(stream);
            }
        }

        public static T DeepCopy<T>(this T self) where T : class
        {
            if (self is null)
                return default;

            // initialize inner objects individually
            // for example in default constructor some list property initialized with some values,
            // but in 'source' these items are cleaned -
            // without ObjectCreationHandling.Replace default constructor values will be added to result
            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(self), deserializeSettings);

        }
    }
}
