using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgungSetiawan_MidExam_Hotel
{
    public class Tamu
    {
        public string NomorRegister { get; set; }
        public DateTime TanggalCheckIn { get; set; }
        public DateTime TanggalCheckOut { get; set; }
        public int LamaMenginap { get; set; }

        public Biodata Biodata { get; set; }
        public List<Tamu> Keluarga { get; set; }
        public Kamar Kamar { get; set; }
        
        public Tamu() { }

        public Tamu(Biodata biodata, string nomorRegister, DateTime tanggalCheckIn, DateTime tanggalCheckOut ,Kamar kamar)
        {
            this.Biodata = biodata;
            this.NomorRegister = nomorRegister;
            this.TanggalCheckIn = tanggalCheckIn;
            this.TanggalCheckOut = tanggalCheckOut;
            this.LamaMenginap = this.TanggalCheckOut.Day - this.TanggalCheckIn.Day;
            this.Keluarga = new List<Tamu>();
            this.Kamar = kamar;
        }

        public decimal BiayaNginap()
        {
            if (this.Keluarga.Count == 0)
            {
                return this.Kamar.HargaKamar * LamaMenginap - ((this.Kamar.HargaKamar * LamaMenginap) * (Convert.ToDecimal(0.5)));
            }
            else
            {

                return this.Kamar.HargaKamar * LamaMenginap;
            }
            
        }

        public void PrintTamu()
        {
            Console.WriteLine("{0} dengan nomor register \t: {1}",Biodata.FullName(),this.NomorRegister);
        }

        public void PrintInformasiTamu()
        {
            Console.WriteLine("Menginap selama \t: {0} hari",this.LamaMenginap);
            Console.WriteLine("Biaya penginapan \t: {0}",BiayaNginap().ToString("C2"));
        }

        public void ReservationHistory()
        {
            Console.WriteLine("{0} - {1} ({2}, {3})", this.TanggalCheckIn.ToString("dd MMMM yyyy"), this.TanggalCheckOut.ToString("dd MMMM yyyy"), this.Biodata.FullName(), this.NomorRegister);
        }

        public void InfoBiodata()
        {
            Console.WriteLine("Berikut informasi tamu {0}", this.NomorRegister);
            Console.WriteLine("\nFirst Name \t\t: {0}", this.Biodata.NamaDepan);
            Console.WriteLine("Last Name \t\t: {0}", this.Biodata.NamaBelakang);
            Console.WriteLine("Gender \t\t\t: {0}", this.Biodata.JenisKelamin);
            Console.WriteLine("Birth Information \t: {0}, ({1} tahun)", this.Biodata.TanggalLahir.ToString("dd MMMM yyyy"), Biodata.Umur());
            Console.WriteLine("ID Card \t\t: {0}", this.Biodata.NomorKTP);
        }

        public void InfoKamar()
        {
            Console.WriteLine("\nMenginap di");
            Console.WriteLine("Room number \t\t: {0}", this.Kamar.NomorKamar);
            Console.WriteLine("Floor \t\t\t: {0}", this.Kamar.LantaiKamar);
            Console.WriteLine("Room type \t\t: {0}", this.Kamar.TipeKamar);
        }

        public void AnggotaKeluarga()
        {
            Console.WriteLine("\nAnggota keluarga:");
            foreach (Tamu item in Keluarga)
            {
                Console.WriteLine("{0} dengan Nomor Register \t: {1}", item.Biodata.FullName(), item.NomorRegister);
            }
        }

    }
}
