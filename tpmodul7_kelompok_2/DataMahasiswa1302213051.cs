using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_2
{
    internal class DataMahasiswa1302213051
    {
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"D:\\Kuliah\\C#\\tpmodul7_kelompok_2\\tpmodul7_kelompok_2\\tp7_1_1302213051.json");

            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);

            string namaDepan = jsonObj.nama.depan;
            string namaBelakang = jsonObj.nama.belakang;
            string nim = jsonObj.nim;
            string fakultas = jsonObj.fakultas;

            Console.WriteLine($"Nama {namaDepan} {namaBelakang} dengan NIM {nim} dari fakultas {fakultas}");
        }
    }
}
