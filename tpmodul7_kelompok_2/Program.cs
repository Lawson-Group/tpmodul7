using tpmodul7_kelompok_2;

class main
{
    public static void Main(String[] args)
    {
        DataMahasiswa_1302210004 dt = new DataMahasiswa_1302210004();
        dt.ReadJSON();
        KuliahMahasiswa_1302210004 km = new KuliahMahasiswa_1302210004();
        km.ReadJSON();
    }
}
