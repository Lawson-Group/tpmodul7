using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;

namespace tpmodul7_kelompok_2
{
    public class DataMahasiswa_1302213038
    {
        public void ReadJSON()
        {
            var jsonFolder = File.ReadAllText("D:\\aisha n\\Documents\\AISHA\\uni\\Semester 4" +
                "\\KPL\\Praktikum\\TP Mod 7\\tpmodul7\\tpmodul7_kelompok_2\\tp7_1_1302213038.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonFolder);

            if (mhs != null)
            {
                string namaDepan = mhs.name.depan;
                string namaBelakang = mhs.name.belakang;
                int nim = mhs.nim;
                string fakultas = mhs.fakultas;

                Console.WriteLine("Nama " + namaDepan + " " + namaBelakang 
                    + " dengan NIM " + nim + " dari fakultas " + fakultas);
            }
        }
    }

    public class Mahasiswa
    {
        public namaLengkap name { get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(namaLengkap nama, int nim, string fakultas)
        {
            if (nama != null && fakultas != null)
            {
                this.name = nama;
                this.nim = nim;
                this.fakultas = fakultas;
            }
        }
    }

    public class namaLengkap
    {
        public string depan { get; set; }
        public string belakang { get; set; }
        public namaLengkap() { }
        public namaLengkap(string depan, string belakang)
        {
            if (depan != null && belakang != null)
            {
                this.depan = depan;
                this.belakang = belakang;
            }
        }
    }
}
