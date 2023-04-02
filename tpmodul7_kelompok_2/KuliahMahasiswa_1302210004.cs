using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_2
{
    internal class KuliahMahasiswa_1302210004
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"C:\Users\ASUS\source\repos\tpmodul7_kelompok_2\tp7_2_1302210004.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);
            string code = jsonObj.courses.code;
            string namaMK = jsonObj.courses.name;
            string nim = jsonObj.nim;
            string fakultas = jsonObj.fakultas;

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            for(int i = 1; i < 8; i++)
            {
                Console.WriteLine("MK " + i + code
                + " - "
                + namaMK);
            }

        }
    }
}
