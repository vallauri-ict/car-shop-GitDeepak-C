using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace VenditaVeicoliDllProject
{
    [Serializable]
    public class SerializableBindingList<T> : BindingList<T> { }

    public class Utils
    {
        public static Random rnd = new Random();
        public static IEnumerable<string> ToCsv<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                yield return string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
            }
        }

        public static string ToCsvString<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            StringBuilder csvdata = new StringBuilder();
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                csvdata.AppendLine(string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray()));
            }
            return csvdata.ToString();
        }

        public static void SerializeToCsv<T>(IEnumerable<T> objectlist, string pathName, string separator = "|")
        {
            IEnumerable<string> dataToSave = Utils.ToCsv(objectlist, separator);
            File.WriteAllLines(pathName, dataToSave);
        }

        public static SerializableBindingList<Veicolo> deserializeObject(IEnumerable<object> objectlist)
        {
            SerializableBindingList<Veicolo> list = new SerializableBindingList<Veicolo>();
            foreach (var item in objectlist)
            {
                //list.Add(item);
            }

            return list;
        }

        public static void SerializeToXml<T>(SerializableBindingList<T> objectlist, string pathName)
        {
            XmlSerializer x = new XmlSerializer(typeof(SerializableBindingList<T>));
            TextWriter writer = new StreamWriter(pathName);
            x.Serialize(writer, objectlist);
            writer.Close();
        }

        public static void SerializeToJson<T>(IEnumerable<T> objectlist, string pathName)
        {
            string json = JsonConvert.SerializeObject(objectlist, Formatting.Indented);
            File.WriteAllText(pathName, json);
        }

        public static void createHtml(SerializableBindingList<Veicolo> lista, string pathName, string skeletonPathName = @".\www\index-skeleton.html")
        {
            string html = File.ReadAllText(skeletonPathName);
            html = html.Replace("{{head-title}}", "ALBUM VEICOLI");
            html = html.Replace("{{body-title}}", "SALONE VEICOLI NUOVI E USATI");


            string aus = "<h3>  </h3>";
            for (int i = 0; i < lista.Count; i++)
                createBody(ref aus, lista, i);

            html = html.Replace("{{main-content}}", aus);
            File.WriteAllText(pathName, html);
        }

        private static void createBody(ref string aus, SerializableBindingList<Veicolo> lista, int i)
        {
            string veicoloImg = string.Empty;
            string tipo = string.Empty;
            string num = "";

            if (lista[i] is Auto)
            {
                veicoloImg = selectImage("auto");
                tipo = "Numero airbag";
                num = (lista[i] as Auto).NumAirbag.ToString();
            }
            else
            {
                veicoloImg = selectImage("moto");
                tipo = "Marca sella";
                num = (lista[i] as Moto).MarcaSella;
            }

            aus += "<div class = \"veicolo\">";
            aus += $"<img src = \"img/{veicoloImg}\">";
            aus += $"<div class = \"titolo\">{lista[i].Marca} {lista[i].Modello}";
            aus += $"<div class = \"didascalia\"> Cilindrata: {lista[i].Cilindrata}<br> Potenza(KW): {lista[i].PotenzaKw}<br> {tipo}: {num} </div>";
            aus += "</div>";
            aus += "</div>";
        }

        private static string selectImage(string v)
        {
            int nImg = rnd.Next(1, 11); 
            if (v == "auto") 
                return "auto/auto" + nImg + ".jpg";
            else
                return "moto/moto" + nImg + ".jpg";
        }

        public static void LoadJson(string name)
        {
            using (StreamReader r = new StreamReader(name))
            {
                string json = r.ReadToEnd();
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
            }
        }
    }
    public class Item
    {
        public int millis;
        public string stamp;
        public DateTime datetime;
        public string light;
        public float temp;
        public float vcc;
    }
}
