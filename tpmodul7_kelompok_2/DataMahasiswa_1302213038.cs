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
                string namaDepan = mhs.Name.Depan;
                string namaBelakang = mhs.Name.Belakang;
                int nim = mhs.Nim;
                string fakultas = mhs.Fakultas;

                Console.WriteLine("Nama " + namaDepan + " " + namaBelakang 
                    + " dengan NIM " + nim + " dari fakultas " + fakultas);
            }
        }
    }

    public class Mahasiswa
    {
        public NamaLengkap Name { get; set; }
        public int Nim { get; set; }
        public string Fakultas { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(NamaLengkap nama, int nim, string fakultas)
        {
            if (nama != null && fakultas != null)
            {
                this.Name = nama;
                this.Nim = nim;
                this.Fakultas = fakultas;
            }
        }
    }

    public class NamaLengkap
    {
        public string Depan { get; set; }
        public string Belakang { get; set; }
        public NamaLengkap() { }
        public NamaLengkap(string depan, string belakang)
        {
            if (depan != null && belakang != null)
            {
                this.Depan = depan;
                this.Belakang = belakang;
            }
        }
    }
}
