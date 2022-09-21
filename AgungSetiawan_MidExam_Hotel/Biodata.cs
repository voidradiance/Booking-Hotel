using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgungSetiawan_MidExam_Hotel
{
    public class Biodata
    {
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string KotaLahir { get; set; }
        public string JenisKelamin { get; set; }
        public long NomorKTP { get; set; }
        public string NomorRegister { get; set; }

        public Biodata() { }

        public Biodata(string namaDepan, string namaBelakang, DateTime tanggalLahir, string kotaLahir, string jenisKelamin, long nomorKTP, string nomorRegister)
        {
            this.NamaDepan = namaDepan;
            this.NamaBelakang = namaBelakang;
            this.TanggalLahir = tanggalLahir;
            this.KotaLahir = kotaLahir;
            this.JenisKelamin = jenisKelamin;
            this.NomorKTP = nomorKTP;
            this.NomorRegister = nomorRegister;
        }

        public int Umur()
        {
            return DateTime.Now.Year - this.TanggalLahir.Year;
        }

        public string FullName()
        {
            return string.Format("{0} {1}",this.NamaDepan, this.NamaBelakang);
        }


    }
}
