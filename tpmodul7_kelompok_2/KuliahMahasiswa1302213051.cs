using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_2
{
    internal class KuliahMahasiswa1302213051
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"D:\Kuliah\C#\tpmodul7_kelompok_2\tpmodul7_kelompok_2\tp7_2_1302213051.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);

            //Console.WriteLine($"MK %d {kode} - {matkul}");
            Console.WriteLine("Daftar mata kuliah yang diambil: ");
            for (int i = 0; i < jsonObj.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {jsonObj.courses[i].code} - {jsonObj.courses[i].name}");
            }

        }
    }
}
