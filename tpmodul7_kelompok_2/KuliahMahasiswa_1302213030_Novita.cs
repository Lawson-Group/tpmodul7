using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_2
{
    internal class KuliahMahasiswa_1302213030_Novita
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"D:\Documents\Semester 4\Software Construction\Tugas Pendahuluan\Modul 7\tpmodul7\tp7_2_1302213030.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for (int i = 0; i < jsonObject.courses.Count; i++)
            {
                Console.WriteLine($"MK {i + 1} {jsonObject.courses[i].code} - {jsonObject.courses[i].name}");
            }
        }
    }
}
