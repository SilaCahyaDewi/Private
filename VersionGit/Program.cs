using VersionGit;

internal class Program
{
    private static void Main(string[] args)
    {
        Dosen dosen = new Dosen();

        Console.WriteLine("Deafult Dosen Pengampu:");
        dosen.display();

        Console.WriteLine("\nMasukkan Nama dan NIK Dosen Baru:");
        dosen.attDosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
        dosen.display();

        Console.WriteLine("\nMasukkan Mata Kuliah Baru:");
        dosen.addCourse(Console.ReadLine());
        dosen.display();

        Console.ReadLine();
    }
}