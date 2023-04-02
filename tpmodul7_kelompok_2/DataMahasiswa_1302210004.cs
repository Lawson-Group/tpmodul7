using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_2
{
    internal class DataMahasiswa_1302210004
    {

        public void ReadJSON()
        {
            string jsonText = File.ReadAllText(@"\Users\ASUS\source\repos\tpmodul7_kelompok_2\tp7_1_1302210004.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);
            string nmDepan = jsonObj.nama.depan;
            string nmBlkng = jsonObj.nama.belakang;
            string nim = jsonObj.nim;
            string fakultas = jsonObj.fakultas;

            Console.WriteLine("Nama "
                + nmDepan
                + " "
                + nmBlkng
                + " " + "dengan NIM "
                + nim + " dari Fakultas "
                + fakultas);

        }
        
    }
}
