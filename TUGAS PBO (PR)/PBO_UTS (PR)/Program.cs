using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_UTS__PR_
{
    class Program
    {
        static void Main(string[] args)
        {
            Perpustakaan perpus = new Perpustakaan();

            Novel novelFiksiKali = new Novel("Novel Fiksi", 1945, "Ir Soekarno");
            MajalahTeknologi majalahIlmuKomputer = new MajalahTeknologi("IlmuKomputer", 2025, 160);
            Komik komikNaruto = new Komik("Naruto Vol 1", 1999, "Masashi Kishimoto");

            perpus.TambahItem(novelFiksiKali);
            perpus.TambahItem(majalahIlmuKomputer);
            perpus.TambahItem(komikNaruto);

            perpus.DaftarItem();

            //Console.WriteLine("JAWABAN");

            //novelFiksiKali.Deskripsi();
            //majalahIlmuKomputer.Deskripsi();

            //novelFiksiKali.BacaSinopsis();

            //Console.WriteLine($"Informasi Lengkap Novel - Judul: {novelFiksiKali.judul}, Tahun: {novelFiksiKali.tahun}, Penulis: {novelFiksiKali.penulis}");

            //majalahIlmuKomputer.TopikTeknologi();

            //Item itemKomik = new Komik("One Piece", 1997, "Oda");
            //itemKomik.Deskripsi();
        }
    }
}
