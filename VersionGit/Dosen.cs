using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionGit
{
    class Dosen
    {
        private int id, Nik;
        private string nama, gender, course;

        public Dosen ()
        {
            id = 1;
            Nik = 12345678;
            nama = "Dosen Pengampu";
            gender = "Male";
            course = "Pemrogramanan Berorientasi Objek";
        }

        public void attDosen (string name, int nik)
        {
            nama = name;
            Nik = nik;
        }

        public void addCourse (string newCourse)
        {
            course += " ," + newCourse;
        }

        public void display()
        {
            Console.WriteLine("id       : " + id);
            Console.WriteLine("Nik      : " + Nik);
            Console.WriteLine("Nama     : " + nama);
            Console.WriteLine("Gender   : " + gender);
            Console.WriteLine("Course   : " + course);
        }
    }
}
