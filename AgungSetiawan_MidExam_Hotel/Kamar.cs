using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgungSetiawan_MidExam_Hotel
{
    public class Kamar
    {
        public string NomorKamar { get; set; }
        public int LantaiKamar { get; set; }
        public string TipeKamar { get; set; }
        public decimal HargaKamar { get; set; }

        public Biodata Biodata { get; set; }
        public List<Kamar> ListNomorKamar { get; set; }

        public Kamar() { }

        public Kamar(string nomorKamar, int lantaiKamar, string tipeKamar, decimal hargaKamar)
        {
            this.NomorKamar = nomorKamar;
            this.LantaiKamar = lantaiKamar;
            this.TipeKamar = tipeKamar;
            this.HargaKamar = hargaKamar;
        }

        public Kamar(List<Kamar> listKamar)
        {
            this.ListNomorKamar = listKamar;
        }

        public void PrintInformasiKamar()
        {
            Console.WriteLine("Menginap di");
            Console.WriteLine("Room Number \t: {0}", this.NomorKamar);
            Console.WriteLine("Floor \t\t: {0}", this.LantaiKamar);
            Console.WriteLine("Room Type \t: {0}", this.TipeKamar);
            Console.WriteLine("Price \t\t: {0}", this.HargaKamar.ToString("C2"));
            Console.WriteLine("\nReservation History:");
        }



    }
}
