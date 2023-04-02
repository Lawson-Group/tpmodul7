using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_2
{
    internal class DataMahasiswa_1302213030_Novita
    {
        public void ReadJSON()
        {
        string jsonString = File.ReadAllText(@"D:\Documents\Semester 4\Software Construction\Tugas Pendahuluan\Modul 7\tpmodul7\tp7_1_1302213030.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan} {jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");

        }
    }
}
