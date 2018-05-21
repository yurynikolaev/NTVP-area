using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using WindowsFormsApplication1.Figures;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public static class Serializer
    {
        public static void Serialize(string filename, List<IFigure> figures)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.TypeNameHandling = TypeNameHandling.All;

            using (StreamWriter sw = new StreamWriter(filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, figures);
            }
        }

        public static List<IFigure> Deserialize(string filename)
        {
            var figures = new List<IFigure>();
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.TypeNameHandling = TypeNameHandling.All;

            using (StreamReader sw = new StreamReader(filename))
            using (JsonReader writer = new JsonTextReader(sw))
            {
                serializer.Deserialize(writer, typeof(List<IFigure>));
            }
            return figures;
        }
    }
}