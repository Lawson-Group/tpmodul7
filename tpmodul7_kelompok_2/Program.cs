using tpmodul7_kelompok_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Datamahasiswa_1302213062 Alvian = new Datamahasiswa_1302213062();
        Alvian.ReadJSON();

        KuliahMahasiswa_1302213062 Supriadi = new KuliahMahasiswa_1302213062();
        Supriadi.ReadJSON();
    }
}