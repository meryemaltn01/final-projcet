using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZZPROJE
{
    public partial class Form2 : Form
    {
        int dakika=0, saniye=1, salise=1;
        



        public Form2()
        {
            InitializeComponent();
        }



        
        int soruno = 0, doğru = 0, yanliş = 0;

        private void Form2_Load(object sender, EventArgs e)
        {

            timer1.Interval = 60000;
            timer2.Interval = 1000;
            timer3.Interval = 10;
            label4.Text="0" ; label5.Text="0"; label6.Text="0";
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika++;
            label4.Text =Convert.ToString(dakika);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (salise == 100)
            {
                salise = 0;
               
            }
            label6.Text = Convert.ToString(salise);
            salise++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {



            var result = MessageBox.Show("Bitirmek istediğinizden emin misiniz?",
                              "Bilgi",
                              MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Evet seçildiğinde yapılacak işlemler
                MessageBox.Show("süreniz bitmiştir.");
            }
            else
            {
                // Hayır seçildiğinde yapılacak işlemler
                MessageBox.Show("Hayır'a tıkladınız.");
            }

            


            timer1.Stop();timer2.Stop();timer3.Stop();
        }

        private void buttnA_Click(object sender, EventArgs e)
        {

            label8.Text = buttnA.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                lbldogru.Text = doğru.ToString();
            }
            else
            {
                yanliş++;
                lblyanlıs.Text=yanliş.ToString();
            }

            
            
        }

        private void bttnB_Click(object sender, EventArgs e)
        {

            label8.Text= bttnB.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                lbldogru.Text = doğru.ToString() ;

            }
            else
            {
                yanliş++;
                lblyanlıs.Text=yanliş.ToString() ;
            }
        }

        private void buttnC_Click(object sender, EventArgs e)
        {


            label8.Text = buttnC.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                lbldogru.Text = doğru.ToString();

            }
            else
            {
                yanliş++;
                lblyanlıs.Text = yanliş.ToString();
            }

        }

        private void buttnD_Click(object sender, EventArgs e)
        {



            label8.Text = buttnD.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                lbldogru.Text = doğru.ToString();

            }
            else
            {
                yanliş++;
                lblyanlıs.Text = yanliş.ToString();
            }
        }

        private void buttnE_Click(object sender, EventArgs e)
        {





            label8.Text = buttnE.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                lbldogru.Text = doğru.ToString();

            }
            else
            {
                yanliş++;
                lblyanlıs.Text = yanliş.ToString();
            }

        }

        private void buttnbasla_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("20 tane sorunuz var başarılar dilerim . Başlamak için Tamam'a tıklayın.",
                                          "Bilgi", MessageBoxButtons.OKCancel);
           
           timer1.Start();timer2.Start();timer3.Start();
   

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (saniye == 60)
            {
                saniye = 0;
            }
            label5.Text = Convert.ToString(saniye);
            saniye++;
            

          
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
           
            soruno--;
            lblsoruno.Text = soruno.ToString();
            

            if(soruno == 1)
            {

                richTextBox1.Text = "cumhuriyet kaç yılında ilan edildi?";
                buttnA.Text = "1920";
                bttnB.Text = "1921";
                buttnC.Text = "1922";
                buttnD.Text = "1923";
                buttnE.Text = "1924";
                label7.Text = "1923";

            }
            if(soruno == 2)
            {
                richTextBox1.Text = "İntikal ve reaksiyon uzunluğu ile fren uzunluğunun toplamı bize hangi uzunluğu verir?";
                buttnA.Text = "duruş görüş uzunluğu";
                bttnB.Text = "geçiş görüş uzunluğu";
                buttnC.Text = "yatay görüş uzunluğu";
                buttnD.Text = "yol uzunluğu";
                buttnE.Text = "iki yol mesafe arası uzunluk";
                label7.Text = "duruş görüş uzunluğu";
            }
            if(soruno == 3)
            {
                richTextBox1.Text = "Türkiye'de 1950-1997 yılları arasında karayolu uzunluğu % 80 oranında artarken, demiryolu uzunluğu yüzde kaç artış göstermiştir?";
                buttnA.Text = "%11";
                bttnB.Text = "%20";
                buttnC.Text = "%30";
                buttnD.Text = "%45";
                buttnE.Text = "%50";
                label7.Text = "%11";
                

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Tren trafiğine ilişkin bilgilerin tutulma sistemine ne ad verilir?";
                buttnA.Text = "orer";
                bttnB.Text = "seyir cetvelleri";
                buttnC.Text = "iltisak hattı";
                buttnD.Text = "gar";
                buttnE.Text = "lojistik köyü";
                label7.Text = "orer";
            }
            if(soruno == 5)
            {
                richTextBox1.Text = "Hızı saate 80 km ye yaklaşan raylı taşımacılık sistemine verilen ad nedir?";
                buttnA.Text = "monoray";
                bttnB.Text = "maglev";
                buttnC.Text = "orer";
                buttnD.Text = "feeder";
                buttnE.Text = "banliyö";
                label7.Text = "banliyö";


            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Üretildikleri yerde 25 kuruş olan bir tarım ürününün pazar yerlerine taşınıp 6 liradan satılması ulaştırmanın hangi alandaki etkisinin bir sonucudur?";
                buttnA.Text = "sosyal";
                bttnB.Text = "tarihsel";
                buttnC.Text = "ekonomik";
                buttnD.Text = "çevresel";
                buttnE.Text = "politik";
                label7.Text = "ekonomik";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi odaklanma stratejisini izleyen hava yolu işletmelerinden biridir?";
                buttnA.Text = "türk hava yolları";
                bttnB.Text = "lufthansa";
                buttnC.Text = "british airways";
                buttnD.Text = "pegasus";
                buttnE.Text = "fedEx";
                label7.Text = "fedEx";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Havaalanında gerçekleşen faaliyetlerden hangisi Temel havaalanı hizmetlerine örnek olarak verilebilir?";
                buttnA.Text = "meteoroloji";
                bttnB.Text = "yolcu hizmetleri";
                buttnC.Text = "ikram servisi";
                buttnD.Text = "uçuş operasyon";
                buttnE.Text = "reklam etkinlikleri";
                label7.Text = "uçuş operasyon";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi hıza etki eden en temel faktörlerden değildir ?";
                buttnA.Text = "sürücü faktörü";
                bttnB.Text = "yolcu faktörü";
                buttnC.Text = "taşıt faktörü";
                buttnD.Text = "hava durumu faktörü";
                buttnE.Text = "trafik faktörü";
                label7.Text = "trafik faktörü";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi havaalanı operasyonel hizmetlerinden biri değildir?";
                buttnA.Text = "hava trafik kontrol";
                bttnB.Text = "PAT sahaları bakımı";
                buttnC.Text = "uçuş operasyon";
                buttnD.Text = "güvenlik ve gümrük";
                buttnE.Text = "kurtarma ve ilk yardım";
                label7.Text = "PAT sahaları bakımı";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi seyir cetvellerinden yer alan bilgilerden biri değildir?";
                buttnA.Text = "tren numarası";
                bttnB.Text = "tren türü ve sınıfı";
                buttnC.Text = "istasyonlarda duruş süresi";
                buttnD.Text = "makinistin bilgileri";
                buttnE.Text = "duraklar";
                label7.Text = "makinistin bilgileri";

            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Hammadde-malzeme mamulün taşınması ile ilgili olarak yapılan giderlerin toplam üretim maliyeti içindeki oransal değeri olarak tanımlanan kavram aşağıdakilerden hangisidir?";
                buttnA.Text = "ulaştırma maliyeti";
                bttnB.Text = "endüstiryel trafik yönetimi";
                buttnC.Text = "işletme lojistiği";
                buttnD.Text = "lojistik yönetimi";
                buttnE.Text = "tedarik zinciri";
                label7.Text = "ulaştırma maliyeti";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi ulaştırma tanımının unsurları arasında yer almamaktadır?";
                buttnA.Text = "insan canlı ve cansız varlıkları kapsar";
                bttnB.Text = "belli bir zaman diliminde gerçekleşir";
                buttnC.Text = "belli bir amaç doğrultusunda yapılır";
                buttnD.Text = "bir yer değiştirme faaliyetidir";
                buttnE.Text = "yarar sağlama amacı gütmektir";
                label7.Text = "yarar sağlama amacı gütmektir";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Devletin ulaştırmadaki en önemli rolü nedir?";
                buttnA.Text = "yönlendirici ve düzenleyici olması";
                bttnB.Text = "maddi imkan sağlaması";
                buttnC.Text = "yol sağlaması";
                buttnD.Text = "yönetici ve yönlendirici olması";
                buttnE.Text = "imkan sağlayıcı ve düzenleyici olması";
                label7.Text = "yönlendirici ve düzenleyici olması";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Malların üretildiği yerden, onların gereksinim duyulduğu, talep edildiği yerlere ulaştırılması aşağıdakilerden hangisi ile ifade edilir?";
                buttnA.Text = "zaman faydası";
                bttnB.Text = "yer faydası";
                buttnC.Text = "yol faydası";
                buttnD.Text = "yer zararı";
                buttnE.Text = "zaman zararı";
                label7.Text = "yer faydası";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Demiryollarının yeni bir ulaştırma biçimi olarak ortaya çıkışı hangi dönemle eşzamanlı olarak gerçekleşmiştir?";
                buttnA.Text = "birinci dünya savaşı";
                bttnB.Text = "sanayi devrimi";
                buttnC.Text = "fransız devrimi";
                buttnD.Text = "ikinci dünya savaşı";
                buttnE.Text = "keşifler çağı";
                label7.Text = "sanayi devrimi";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Nehirler, göller ve kanallar kullanılarak yapılan taşımacılık türü aşağıdakilerden hangisidir?";
                buttnA.Text = "yerel taşımacılık";
                bttnB.Text = "bağlantı hatları ile aktarım";
                buttnC.Text = "sekonder taşımacılık";
                buttnD.Text = "iç su yollu taşımacılığı";
                buttnE.Text = "deniz taşımacılığı";
                label7.Text = "iç su  yollu taşımacılığı";

            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi \"taşınacak kargonun sahip olduğu özelliklere göre sınıflandırma\"da özel kargo alanına girer?";
                buttnA.Text = "diplomatik kargolar";
                bttnB.Text = "askılı tekstil";
                buttnC.Text = "yedek parçalar";
                buttnD.Text = "organlar";
                buttnE.Text = "ilaçlar";
                label7.Text = "diplomatik kargolar";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Ulaştırma faaliyetleri, aşağıdaki ekonomik faaliyet türlerinden hangisi kapsamında ele alınır?";
                buttnA.Text = "tarım";
                bttnB.Text = "sanayi";
                buttnC.Text = "hizmet";
                buttnD.Text = "üretim";
                buttnE.Text = "iktisat";
                label7.Text = "hizmet";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Yol kaplamasının iki yanında, kaplamaya bitişik ve kaplama kenarı ile şev başı arasında kalan kısım aşağıdaki seçeneklerin hangisinde doğru olarak verilmiştir?";
                buttnA.Text = "banket";
                bttnB.Text = "köprü";
                buttnC.Text = "tünel";
                buttnD.Text = "geçiş sistemleri";
                buttnE.Text = "kaldırım";
                label7.Text = "banket";
            }




        }

        private void buttnsonra_Click(object sender, EventArgs e)
        {


            soruno++;
            lblsoruno.Text = soruno.ToString();
            if(soruno == 1)
            {
                richTextBox1.Text = "cumhuriyet kaç yılında ilan edildi?";
                buttnA.Text = "1920";
                bttnB.Text = "1921";
                buttnC.Text = "1922";
                buttnD.Text = "1923";
                buttnE.Text = "1924";
                label7.Text = "1923";
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "İntikal ve reaksiyon uzunluğu ile fren uzunluğunun toplamı bize hangi uzunluğu verir?";
                buttnA.Text = "duruş görüş uzunluğu";
                bttnB.Text = "geçiş görüş uzunluğu";
                buttnC.Text = "yatay görüş uzunluğu";
                buttnD.Text = "yol uzunluğu";
                buttnE.Text = "iki yol mesafe arası uzunluk";
                label7.Text = "duruş görüş uzunluğu";

           
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Türkiye'de 1950-1997 yılları arasında karayolu uzunluğu % 80 oranında artarken, demiryolu uzunluğu yüzde kaç artış göstermiştir?";
                buttnA.Text = "%11";
                bttnB.Text  = "%20";
                buttnC.Text = "%30";
                buttnD.Text = "%45";
                buttnE.Text = "%50";
                label7.Text = "%11";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Tren trafiğine ilişkin bilgilerin tutulma sistemine ne ad verilir?";
                buttnA.Text = "orer";
                bttnB.Text  = "seyir cetvelleri";
                buttnC.Text = "iltisak hattı";
                buttnD.Text = "gar";
                buttnE.Text = "lojistik köyü";
                label7.Text = "orer";
            }
            if (soruno == 5) 
            {
                richTextBox1.Text = "Hızı saate 80 km ye yaklaşan raylı taşımacılık sistemine verilen ad nedir?";
                buttnA.Text = "monoray";
                bttnB.Text  = "maglev";
                buttnC.Text = "orer";
                buttnD.Text = "feeder";
                buttnE.Text = "banliyö";
                label7.Text = "banliyö";

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Üretildikleri yerde 25 kuruş olan bir tarım ürününün pazar yerlerine taşınıp 6 liradan satılması ulaştırmanın hangi alandaki etkisinin bir sonucudur?";
                buttnA.Text = "sosyal";
                bttnB.Text  = "tarihsel";
                buttnC.Text = "ekonomik";
                buttnD.Text = "çevresel";
                buttnE.Text = "politik";
                label7.Text = "ekonomik";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi odaklanma stratejisini izleyen hava yolu işletmelerinden biridir?";
                buttnA.Text = "türk hava yolları";
                bttnB.Text  = "lufthansa";
                buttnC.Text = "british airways";
                buttnD.Text = "pegasus";
                buttnE.Text = "fedEx";
                label7.Text = "fedEx";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Havaalanında gerçekleşen faaliyetlerden hangisi Temel havaalanı hizmetlerine örnek olarak verilebilir?";
                buttnA.Text = "meteoroloji";
                bttnB.Text  = "yolcu hizmetleri";
                buttnC.Text = "ikram servisi";
                buttnD.Text = "uçuş operasyon";
                buttnE.Text = "reklam etkinlikleri";
                label7.Text = "uçuş operasyon";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi hıza etki eden en temel faktörlerden değildir ?";
                buttnA.Text = "sürücü faktörü";
                bttnB.Text  = "yolcu faktörü";
                buttnC.Text = "taşıt faktörü";
                buttnD.Text = "hava durumu faktörü";
                buttnE.Text = "trafik faktörü";
                label7.Text = "trafik faktörü";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi havaalanı operasyonel hizmetlerinden biri değildir?";
                buttnA.Text = "hava trafik kontrol";
                bttnB.Text = "PAT sahaları bakımı";
                buttnC.Text = "uçuş operasyon";
                buttnD.Text = "güvenlik ve gümrük";
                buttnE.Text = "kurtarma ve ilk yardım";
                label7.Text = "PAT sahaları bakımı";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi seyir cetvellerinden yer alan bilgilerden biri değildir?";
                buttnA.Text = "tren numarası";
                bttnB.Text  = "tren türü ve sınıfı";
                buttnC.Text = "istasyonlarda duruş süresi";
                buttnD.Text = "makinistin bilgileri";
                buttnE.Text = "duraklar";
                label7.Text = "makinistin bilgileri";

            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Hammadde-malzeme mamulün taşınması ile ilgili olarak yapılan giderlerin toplam üretim maliyeti içindeki oransal değeri olarak tanımlanan kavram aşağıdakilerden hangisidir?";
                buttnA.Text = "ulaştırma maliyeti";
                bttnB.Text   = "endüstiryel trafik yönetimi";
                buttnC.Text = "işletme lojistiği";
                buttnD.Text = "lojistik yönetimi";
                buttnE.Text = "tedarik zinciri";
                label7.Text = "ulaştırma maliyeti";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi ulaştırma tanımının unsurları arasında yer almamaktadır?";
                buttnA.Text = "insan canlı ve cansız varlıkları kapsar";
                bttnB.Text  = "belli bir zaman diliminde gerçekleşir";
                buttnC.Text = "belli bir amaç doğrultusunda yapılır";
                buttnD.Text = "bir yer değiştirme faaliyetidir";
                buttnE.Text = "yarar sağlama amacı gütmektir";
                label7.Text = "yarar sağlama amacı gütmektir";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Devletin ulaştırmadaki en önemli rolü nedir?";
                buttnA.Text = "yönlendirici ve düzenleyici olması";
                bttnB.Text  = "maddi imkan sağlaması";
                buttnC.Text = "yol sağlaması";
                buttnD.Text = "yönetici ve yönlendirici olması";
                buttnE.Text = "imkan sağlayıcı ve düzenleyici olması";
                label7.Text = "yönlendirici ve düzenleyici olması";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Malların üretildiği yerden, onların gereksinim duyulduğu, talep edildiği yerlere ulaştırılması aşağıdakilerden hangisi ile ifade edilir?";
                buttnA.Text = "zaman faydası";
                bttnB.Text = "yer faydası";
                buttnC.Text = "yol faydası";
                buttnD.Text = "yer zararı";
                buttnE.Text = "zaman zararı";
                label7.Text = "yer faydası";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Demiryollarının yeni bir ulaştırma biçimi olarak ortaya çıkışı hangi dönemle eşzamanlı olarak gerçekleşmiştir?";
                buttnA.Text = "birinci dünya savaşı";
                bttnB.Text  = "sanayi devrimi";
                buttnC.Text = "fransız devrimi";
                buttnD.Text = "ikinci dünya savaşı";
                buttnE.Text = "keşifler çağı";
                label7.Text = "sanayi devrimi";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Nehirler, göller ve kanallar kullanılarak yapılan taşımacılık türü aşağıdakilerden hangisidir?";
                buttnA.Text = "yerel taşımacılık";
                bttnB.Text = "bağlantı hatları ile aktarım";
                buttnC.Text = "sekonder taşımacılık";
                buttnD.Text = "iç su yollu taşımacılığı";
                buttnE.Text = "deniz taşımacılığı";
                label7.Text = "iç su  yollu taşımacılığı";

            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi \"taşınacak kargonun sahip olduğu özelliklere göre sınıflandırma\"da özel kargo alanına girer?";
                buttnA.Text = "diplomatik kargolar";
                bttnB.Text = "askılı tekstil";
                buttnC.Text = "yedek parçalar";
                buttnD.Text = "organlar";
                buttnE.Text = "ilaçlar";
                label7.Text = "diplomatik kargolar";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Ulaştırma faaliyetleri, aşağıdaki ekonomik faaliyet türlerinden hangisi kapsamında ele alınır?";
                buttnA.Text = "tarım";
                bttnB.Text = "sanayi";
                buttnC.Text = "hizmet";
                buttnD.Text = "üretim";
                buttnE.Text = "iktisat";
                label7.Text = "hizmet";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Yol kaplamasının iki yanında, kaplamaya bitişik ve kaplama kenarı ile şev başı arasında kalan kısım aşağıdaki seçeneklerin hangisinde doğru olarak verilmiştir?";
                buttnA.Text = "banket";
                bttnB.Text = "köprü";
                buttnC.Text = "tünel";
                buttnD.Text = "geçiş sistemleri";
                buttnE.Text = "kaldırım";
                label7.Text = "banket";
                buttnsonra.Text = "sonuçlar";
            }
            if (soruno == 21)
            {
                buttnA.Enabled = false;
                bttnB.Enabled = false;
                buttnC.Enabled = false;
                buttnD.Enabled = false;
                buttnE.Enabled = false;
                buttnsonra.Enabled= false;
                MessageBox.Show("Doğru: " + lbldogru.Text + "\nYanlış: " + lblyanlıs.Text);

            }





        }
        

    }
    }

