using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_2
{
    public class KuliahMahasiswa_1302213038
    {
        public void ReadJSON()
        {
            var jsonFolder = File.ReadAllText("D:\\aisha n\\Documents\\AISHA\\uni\\Semester 4\\" +
                "KPL\\Praktikum\\TP Mod 7\\tpmodul7\\tpmodul7_kelompok_2\\tp7_2_1302213038.json");
            listMatkul matKul = JsonSerializer.Deserialize<listMatkul>(jsonFolder);

            if (matKul != null)
            {
                Console.WriteLine("Daftar Mata Kuliah yang Diambil:");
                int i = 0;
                foreach (MatKul MK in matKul.courses)
                {
                    Console.WriteLine("MK " + (i+1) + " " 
                        + MK.Code + " - " + MK.Name);
                    i++;
                }
            }
        }
    }

    public class listMatkul
    {
        public List<MatKul> courses { get; set; }
        public listMatkul() { }
        public listMatkul(List<MatKul> courses)
        {
            this.courses = courses;
        }
    }

    public class MatKul
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public MatKul() { }

        public MatKul(string kode, string nama)
        {
            if (kode != null && nama != null)
            {
                this.Code = kode;
                this.Name = nama;
            }
        }
    }
}
