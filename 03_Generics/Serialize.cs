using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _03_Generics
{
    public class Serialize 
    {
        public static void Serializer(object obj) 
        {
            string fileName = @"C:\Projects_C#\Curso_CSharp\ArquivosC#\03_"+obj.GetType().Name+".txt";
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, jsonString);
        }

        public static T Derializer<T>()
        {
            string fileName = @"C:\Projects_C#\Curso_CSharp\ArquivosC#\03_"+typeof(T).Name+".txt";
            string jsonString = File.ReadAllText(fileName);
            T obj = (T) JsonSerializer.Deserialize(jsonString, typeof(T));
            return obj;
        }
    }
}
