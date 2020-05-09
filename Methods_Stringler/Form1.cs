using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods_Stringler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string metin;

        private void btnCompareTo_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            int sonuc = metin.CompareTo("Negan");
            if (sonuc == -1)
            {
                MessageBox.Show("Yazdığınız değer parametredeki değerden sonradır.");
            }
            else if (sonuc == 0)
            {
                MessageBox.Show("Yazdığınız değer parametredeki değer ile aynı lokasyondadır..");
            }
            else
            {
                MessageBox.Show("Yazdığınız değer parametredeki değerden öncedir.");
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            bool varmi = metin.Contains('N');
            /*if (varmi) // If ve else kullanımının uzun hali.
              {
                  MessageBox.Show("Aradığınız değer metinde vardır.");
              }
              else
              {
                  MessageBox.Show("Aradığınız değer metinde yoktur.");
              } */
            MessageBox.Show(varmi ? "Aradığınız değer metinde vardır." : "Aradığınız değer metinde yoktur."); // Ternary If => Genellikle 2 koşul bulunan olaylarda kullanılır. Yukarıdaki if else sistemiyle aynı işi yapar.
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            bool basliyormu = metin.StartsWith("neg");
            MessageBox.Show(basliyormu ? "Metin \"neg\" ile başlamaktadır." : "Kelime \"neg\" ile başlamamaktadır."); // \"<text>\" : Bu kullanım texti yazdırır.
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            MessageBox.Show(metin.EndsWith("neg") ? "Kelime \"neg\" ile bitmektedir." : "Kelime \"neg\" ile bitmemektedir."); // Dahada kısasıdır.
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            int index = metin.IndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            int index = metin.LastIndexOf('g');
            MessageBox.Show(index.ToString());
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            // metin = metin.Remove(3); // İlk kullanımı.
            metin = metin.Remove(5, 3); // İkinci kullanımı.
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            // string degisen = metin.Replace('Y', 'D');
            string degisen_2 = metin.Replace("Negan", "Daryl");
            MessageBox.Show(degisen_2);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            /* string[] parcalar = metin.Split(' ');
               foreach (string item in parcalar)
               {
                   MessageBox.Show(item);
               } */
            string[] adresler = metin.Split(';');
            foreach (string item in adresler)
            {
                MessageBox.Show(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            metin = metin.Insert(2, "abc3463463");
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            MessageBox.Show(textBox1.Text.ToLower());
            this.Text = textBox1.Text.ToUpper();
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            // string veri = metin.Substring(2); // İlk kullanımı.
            string veri = metin.Substring(2, 5); // İkinci kullanımı.
        }

        private void btnToCharArray_Click(object sender, EventArgs e)
        {
            // metin = textBox1.Text;
            // char[] karakterler = metin.ToCharArray();
            // Dışarıdan girilen metindeki her bir karakterin ASCII değerleri toplamı.
            metin = textBox1.Text;
            char[] karakterler = metin.ToCharArray();
            int toplam = 0;
            /* foreach (char item in karakterler) // Foreach yöntemi
              {
                  toplam += Convert.ToInt32(item);
              } */
            for (int i = 0; i < karakterler.Length; i++) // Aynı işi for ile yapar.
            {
                toplam += Convert.ToInt32(karakterler[i]);
            }
            MessageBox.Show("Toplamları: " + toplam.ToString());
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            metin = textBox1.Text;
            string yeniDeger = metin.Trim();
            // MessageBox.Show("Boşluklarla hesaplanan karakter sayısı: " + metin.Length + ", boşluklar temizlenip hesaplanan karakter sayısı: " + yeniDeger.Length);
            MessageBox.Show(string.Format("Boşluklarla hesaplanan karakter sayısı: {0} , boşluklar temizenip hesaplanan karakter sayısı: {1}", metin.Length, yeniDeger.Length)); // Aynı mesajı verir. Farklı formatta yazma kuralıdır.
        }
    }
}
// String Methodlar: Sahip olduğumuz metinsel değerlerin özelliklerini değiştirmek için    kullanılan methodlardır. Örneğin; kelimeleri parçalamak, eklemek, harflerin yerlerini   değiştirmek, boşluk temizlemek, vb.

// Compare To:  Methodu kullandığınız string değerler methoda verdiğiniz parametredeki     string değeri  sözlük mantığıyla karşılaştırır. Eğer sözlükte aynı lokasyonlardaysa     0, parametredeki değer ana değerden sözlükten önceyse 1, sonraysa -1 değerini döner.

// Contains: Aranan char ya da string değer, arama yaptığınız metinsel ifade               içerisinde geçmekte mi geçmemekte mi cevabını "bool" olarak döndürür.

// StartsWith: Kelimenizin, parametrede gönderdiğiniz değerle başlayıp başlamadığını       "bool" olarak döndürür.

// EndsWith: Kelimenizin, parametrede gönderdiğiniz değerle bitip bitmediğini "bool"       olarak döndürür.

// IndexOf: Dizilerde gördüğümüz methodun aynı prensipleriyle çalışır. Eğer harf varsa     index numarasını, yoksa -1 döner. Harf birden fazla var ise ilk bulduğu harfin          indexini döner.

// LastIndexOf: Dizilerde gördüğümüz methodun aynı prensipleriyle çalışır. Eğer harf       varsa index numarasını, yoksa -1 döner. Harf birden fazla var ise son bulduğu harfin    indexini döner.

// Remove: Parametre olarak verdiğiniz index numarası dahil, o indexteki ve sonraki tüm    karakterleri siler. Diğer bir kullanımı ise parametre olarak verdiğiniz index           numarası dahil, o indexten başlayarak ikinci parametrede verdiğiniz değer kadar         eleman siler.

// Replace: Metniniz içerisindeki bir karakteri ya da bir bölümü yeni bir karakter veya    bölüm ile değiştirme olanağı sağlar. Yani char ve string olarak değiştirmeyi iki        farklı kullanım şekliyle sağlar.

// Split: Metni özel bir karakterden birden fazla parçaya ayırmaya olanak sağlar. Aynı     anda birden fazla özel karakterde verilebilir. Bu method "string[]" bir dizi dönüşü     yapar.

// Insert: Bir metinsel değerin herhangi bir indexine yeni bir değeri eklemek              isteniyorsa bu method kullanılır. İlk parametrede kaçıncı indexten sonra ekleneceği,    ikinci parametrede ise hangi metni ekleyeceğini sorar.

// ToLower: İlgili metnin tamamını küçük harfe çevirmeye yarar.

// ToUpper: İlgili metnin tamamını büyük harfe çevirmeye yarar.

// Substring : Metinden parametre gönderilen indexten başlayarak, geri kalan kısmını çekip alma olanağı sağlar. Diğer kullanımı ise metinden ilk parametre verilen indexten        başlayıp ikinci parametrede verilen değer kadarlık kısmı çekip alma olanağı sağlar.

// ToCharArray: Stringi charlarına ayırarak char[] dizisi verir.

// Trim: Metnin sağında ya da solundaki tüm boşlukları temizleme olanağı sağlar.

// Kullanıcıdan alınan ad soyad bilgisini(1 textBox'tan) kullanıcının soyadını büyük       karaktere çevirerek ekranda gösteren program.