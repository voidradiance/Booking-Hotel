using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgungSetiawan_MidExam_Hotel
{
    class Program
    {

        public static Dictionary<string, Tamu> listTamu = new Dictionary<string, Tamu>();
        public static Dictionary<string, Kamar> listKamar = new Dictionary<string, Kamar>();

        static void Main(string[] args)
        {

            #region datadummy
            Biodata biodataDanny = new Biodata("Danny", "Tan", new DateTime(1990, 11, 23), "Beijing", "Laki-laki", 312008923111990002, "A021");
            Biodata biodataDessy = new Biodata("Dessy", "Wang", new DateTime(1990, 11, 11), "Beijing", "Perempuan", 312008911111990002, "A022");
            Biodata biodataSunarti = new Biodata("Sunarti", "Wijaya ", new DateTime(1985, 4, 18), "Bandung", "Perempuan", 312008923111990002, "A023");
            Biodata biodataArdi = new Biodata("Ardi", "Sanjaya", new DateTime(1985, 8, 1), "Jakarta", "Laki-laki", 312008901081990002, "A024");
            Biodata biodataMuliawan = new Biodata("Muliawan", "Sanjaya", new DateTime(2000, 10, 10), "Jakarta", "Laki-laki", 3120089010102000002, "A025");
            Biodata biodataTirta = new Biodata("Tirta", "Raharja", new DateTime(1988, 10, 14), "Jakarta", "Laki-laki", 3120089014101988002, "A026");

            Kamar kamar301 = new Kamar("301", 3, "Regular single bed", 800000m);
            Kamar kamar302 = new Kamar("302", 3, "Regular double bed", 1000000m);
            Kamar kamar303 = new Kamar("303", 3, "Regular twin bed", 1200000m);
            Kamar kamar401 = new Kamar("401", 4, "VIP single bed", 1000000m);
            Kamar kamar402 = new Kamar("402", 4, "VIP double bed", 1200000m);
            Kamar kamar403 = new Kamar("403", 4, "VIP twin bed", 1400000m);

            Tamu danny = new Tamu(biodataDanny, "A021", new DateTime(2018, 4, 12), new DateTime(2018, 4, 14), kamar301);
            Tamu dessy = new Tamu(biodataDessy, "A022", new DateTime(2018, 4, 12), new DateTime(2018, 4, 14), kamar301);
            Tamu sunarti = new Tamu(biodataSunarti, "A023", new DateTime(2018, 5, 15), new DateTime(2018, 5, 17), kamar302);
            Tamu muliawan = new Tamu(biodataMuliawan, "A025", new DateTime(2018, 5, 15), new DateTime(2018, 5, 17), kamar302);
            Tamu ardi = new Tamu(biodataArdi, "A024", new DateTime(2018, 5, 15), new DateTime(2018, 5, 17), kamar302);
            Tamu tirta = new Tamu(biodataTirta, "A026", new DateTime(2018, 5, 15), new DateTime(2018, 5, 18), kamar401);


            listKamar.Add("301", new Kamar("301", 3, "Regular single bed", 800000m));
            listKamar.Add("302", new Kamar("302", 3, "Regular double bed", 1000000m));
            listKamar.Add("303", new Kamar("303", 3, "Regular twin bed", 1200000m));
            listKamar.Add("401", new Kamar("401", 4, "VIP single bed", 1000000m));
            listKamar.Add("402", new Kamar("402", 4, "VIP double bed", 1200000m));
            listKamar.Add("403", new Kamar("403", 4, "VIP twin bed", 1400000m));

            listTamu.Add("A021", danny);
            listTamu.Add("A022", dessy);
            listTamu.Add("A023", sunarti);
            listTamu.Add("A024", muliawan);
            listTamu.Add("A025", ardi);
            listTamu.Add("A026", tirta);

            listTamu["A021"].Keluarga.Add(dessy);
            listTamu["A022"].Keluarga.Add(danny);
            listTamu["A023"].Keluarga.Add(ardi);
            listTamu["A023"].Keluarga.Add(muliawan);
            listTamu["A024"].Keluarga.Add(sunarti);
            listTamu["A024"].Keluarga.Add(muliawan);
            listTamu["A025"].Keluarga.Add(sunarti);
            listTamu["A025"].Keluarga.Add(ardi);

            #endregion

            string input = String.Empty;
            input = MenuUtama(input);

        }

        private static string MenuUtama(string input)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Selamat Datang di Hotel Indocyber");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Semua data pengunjung");
            Console.WriteLine("2. Semua data kamar");
            Console.WriteLine("3. Tentang hotel");
            Console.WriteLine("4. Keluar aplikasi");
            Console.Write("Pilih nomor menu untuk masuk ke menunya (1/2/3/4) : ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    DataPengunjung(input);

                    return input;
                case "2":
                    Console.Clear();
                    DataKamar(input);

                    return input;
                case "3":
                    Console.Clear();
                    TentangHotel(input);

                    return input;
                case "4":
                    //Console.Clear();
                    //Console.Write("Yakin ingin keluar aplikasi ini? (y/n) ");
                    //input = Console.ReadLine();
                    //while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    //{
                    //    Console.Write("hanya input yes atau no (y/n) ");
                    //    input = Console.ReadLine().Trim();
                    //}
                    //if (input.ToLower().Equals("n"))
                    //{
                    //    Console.Clear();
                    //    MenuUtama(input);
                    //}
                    //else
                    //{
                    //    Console.Clear();
                    //    Console.WriteLine("------------------------------------------");
                    //    Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                    //    Console.WriteLine("------------------------------------------");
                    //}
                    //break;

                    //total penghasilan hotel
                    List<Tamu> listTamuNew = new List<Tamu>();
                    foreach (Tamu item in listTamu.Values)
                    {
                        if (listTamu.Count == 0 || item.Keluarga.Count == 0)
                        {
                            listTamuNew.Add(item);
                            break;
                        }
                        foreach (Tamu tamu in item.Keluarga)
                        {
                            if (listTamuNew.Contains(tamu))
                            {
                                break;
                            }
                            else
                            {
                                listTamuNew.Add(item);
                            }
                        }
                    }

                    for (int i = 0; i < listTamuNew.Count; i++)
                    {
                        try
                        {
                            if (listTamuNew[i] == listTamuNew[i + 1])
                            {
                                listTamuNew.RemoveAt(i);
                            }
                        }
                        catch
                        {
                            if (listTamuNew[i] == listTamuNew[0])
                            {
                                listTamuNew.RemoveAt(0);
                            }
                            
                        }
                    }

                    //foreach (Tamu item in listTamuNew)
                    //{
                    //    Console.WriteLine(item.Biodata.FullName());
                    //}

                    decimal penghasilan = 0;
                    foreach (Tamu item in listTamuNew)
                    {
                        penghasilan += item.BiayaNginap();
                    }
                    Console.WriteLine(penghasilan.ToString("C2"));
                    MenuUtama(input);
                    break;


                default:
                    Console.Clear();
                    Console.WriteLine("Pilihan tidak tersedia!");
                    MenuUtama(input);
                    break;
            }
            return input;
        }

        private static void DataPengunjung(string input)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Berikut adalah daftar pengunjung hotel");
            Console.WriteLine("--------------------------------------");
            foreach (Tamu item in listTamu.Values)
            {
                item.PrintTamu();
            }
            Console.WriteLine("\nPilih nomor menu untuk ke menunya (1/2/3) : ");
            Console.WriteLine("\t1. Informasi pengunjung");
            Console.WriteLine("\t2. Kembali ke menu utama");
            Console.WriteLine("\t3. Keluar aplikasi");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //Console.Clear();
                    InformasiPengunjung(input);
                    break;
                case "2":
                    Console.Clear();
                    MenuUtama(input);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Yakin ingin keluar aplikasi ini? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("hanya input yes atau no (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MenuUtama(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Pilihan tidak tersedia!\n");
                    DataPengunjung(input);
                    break;
            }
        }

        private static void InformasiPengunjung(string input)
        {
            Console.Write("Masukkan nomor Register yang ingin anda lihat informasinya : ");
            input = Console.ReadLine().Trim();
            if (!(listTamu.Keys.Contains(input)))
            {
                Console.Clear();
                Console.WriteLine("Maaf nomor register yang anda masukan tidak valid! masukan lagi\n");
                InformasiPengunjung(input);
            }

            Console.Clear();
            //kriteria untuk tamu yang sendiri, dia akan mendapatkan diskon 50%
            foreach (Tamu item in listTamu.Values)
            {
                if (input.Equals(item.NomorRegister))
                {
                    item.InfoBiodata();
                    item.PrintInformasiTamu();
                    item.InfoKamar();
                    item.AnggotaKeluarga();
                }
            }
            Console.WriteLine("\nPilih nomor menu untuk ke menunya (1/2/3) : ");
            Console.WriteLine("\t1. Kembali ke semua data pengunjung");
            Console.WriteLine("\t2. Kembali ke menu utama");
            Console.WriteLine("\t3. Keluar aplikasi");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    DataPengunjung(input);
                    break;
                case "2":
                    Console.Clear();
                    MenuUtama(input);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Yakin ingin keluar aplikasi ini? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("hanya input yes atau no (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MenuUtama(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Pilihan tidak tersedia!\n");
                    break;
            }
        }

        private static void DataKamar(string input)
        {
            Console.Write("Lantai 3 : ");
            foreach (Kamar item in listKamar.Values)
            {
                if (item.LantaiKamar == 3)
                {
                    Console.Write($"{item.NomorKamar} ");
                }
            }
            Console.Write("\nLantai 4 : ");
            foreach (Kamar item in listKamar.Values)
            {
                if (item.LantaiKamar == 4)
                {
                    Console.Write($"{item.NomorKamar} ");
                }
            }

            Console.WriteLine("\n\nPilih nomor menu untuk ke menunya (1/2/3) : ");
            Console.WriteLine("\t1. Informasi kamar");
            Console.WriteLine("\t2. Kembali ke menu utama");
            Console.WriteLine("\t3. Keluar aplikasi");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //Console.Clear();
                    InformasiKamar(input);
                    break;
                case "2":
                    Console.Clear();
                    MenuUtama(input);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Yakin ingin keluar aplikasi ini? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("hanya input yes atau no (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MenuUtama(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Pilihan tidak tersedia!");
                    DataKamar(input);
                    break;
            }
        }

        private static void InformasiKamar(string input)
        {
            Console.Write("Masukkan nomor kamar yang ingin anda lihat informasinya : ");
            input = Console.ReadLine().Trim();

            if (!(listKamar.Keys.Contains(input)))
            {
                Console.Clear();
                Console.WriteLine("Maaf nomor kamar yang anda masukan tidak valid! masukan lagi\n");
                InformasiKamar(input);
            }
            Console.Clear();
            foreach (Kamar item in listKamar.Values)
            {
                if (input.Equals(item.NomorKamar))
                {
                    item.PrintInformasiKamar();
                }
            }
            foreach (Tamu item in listTamu.Values)
            {
                if (input.Equals(item.Kamar.NomorKamar))
                {
                    item.ReservationHistory();
                }
            }

            Console.WriteLine("\nPilih nomor menu untuk ke menunya (1/2/3) : ");
            Console.WriteLine("\t1. Kembali ke data kamar");
            Console.WriteLine("\t2. Kembali ke menu utama");
            Console.WriteLine("\t3. Keluar aplikasi");
            input = Console.ReadLine().Trim();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    DataKamar(input);
                    break;
                case "2":
                    Console.Clear();
                    MenuUtama(input);
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Yakin ingin keluar aplikasi ini? (y/n) ");
                    input = Console.ReadLine();
                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                    {
                        Console.Write("hanya input yes atau no (y/n) ");
                        input = Console.ReadLine().Trim();
                    }
                    if (input.ToLower().Equals("n"))
                    {
                        Console.Clear();
                        MenuUtama(input);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                        Console.WriteLine("------------------------------------------");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Pilihan tidak tersedia!\n");
                    InformasiKamar(input);
                    break;
            }
        }

        private static void TentangHotel(string input)
        {
            Console.WriteLine("Hotel ini bernama Silver Coast Hotel. \nSudah didirikan sejak  12 May 1990 di Australia, \nQueensland, di kota Gold Coast.\n");
            Console.Write("Ingin kembali ke menu utama? (y/n) ");
            input = Console.ReadLine();
            while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
            {
                Console.Write("hanya input yes atau no (y/n) ");
                input = Console.ReadLine().Trim();
            }
            if (input.ToLower().Equals("y"))
            {
                Console.Clear();
                MenuUtama(input);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Terimakasih telah menggunakan aplikasi ini");
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}
