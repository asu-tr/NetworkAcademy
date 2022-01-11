using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_11_Encapsulation
{
    public class Kullanici
    {
        public int IDUret()
        {
            Random random = new Random();
            return random.Next(10, 90);
        }

        public Kullanici()
        {
            _id = IDUret();
        }

        //Field
        private int _id;
        private string ad;
        private string soyad;
        private string _email;
        private string _tcno;
        private string _adres;
        private string _telno;
        private decimal _fiyat;


        //Property
        public int ID
        {
            get
            { return this._id; }

            private set { }
        }

        public string Ad
        {
            get { return this.ad; }
            set { this.ad = value; }
        }

        public string Soyad
        {
            get { return this.soyad; }
            set
            {
                this.soyad = value;
                this._email = string.Format("{0}.{1}@hotmail.com", ad, soyad);
            }
        }

        public string Email
        {
            get
            { return this._email; }

            private set
            { this._email = value; }
        }

        bool hepsisayi = false;
        public string TCNO
        {
            get
            {
                if (_tcno != null)
                    return _tcno.Substring(0, 3);

                else
                    return String.Empty;
            }
            set
            {
                if (value.Length == 11)
                {
                    int kontrol = 0;
                    hepsisayi = true;

                    for (int i = 0; i < 11; i++)
                    {
                        if (hepsisayi == false)
                            kontrol = 1;
                        hepsisayi = char.IsNumber(value[i]);
                    }

                    if (kontrol == 1) Console.WriteLine("TCNO rakam dışında bir şey içeremez.");
                    else
                        this._tcno = value;
                }
                else
                {
                    Console.WriteLine("TCNO 11 haneden oluşmalıdır.");
                }
            }
        }

        public string Adres
        {
            // get; // database veya farklı bir veri kaynagı .. class çağıran programcıya datayı gösteridiğimiz kısım... 
            //  set; // dış dünyadan alınan datanın içeride private olarak saklanan field içerisine değer atandığı kısım.. 
            get
            {
                return this._adres;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Adres boş olamaz .");
                else
                    this._adres = value;
            }
        }

        public string TelNo
        {
            get
            {
                if (hepsisayi)
                    return _telno;

                else
                    return string.Empty;
            }

            set
            {
                if (value.Length == 10)
                {
                    int count = 0;
                    do
                    {
                        hepsisayi = char.IsNumber(value[count++]);
                        if (!hepsisayi)
                        {
                            Console.WriteLine("Telefon numarası rakamlardan oluşmalıdır.");
                        }
                    } while (hepsisayi && count < 10);

                    if (count == 10)
                    {
                        this._telno = value;
                    }
                }

                else
                    Console.WriteLine("Tel no 10 haneden oluşmalıdır. (5xx-xxx-xx-xx)");
            }
        }

        public decimal Fiyat
        {
            get
            {
                return this._fiyat;
            }
            set
            {
                _fiyat = value;
            }
        }
        public decimal KDVli
        {
            get
            {
                return this._fiyat * 1.18m;
            }
            private set { }
        }
    }
}