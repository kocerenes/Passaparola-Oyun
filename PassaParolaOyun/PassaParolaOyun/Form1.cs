using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParolaOyun
{
    public partial class oyunPanel : Form
    {
        public oyunPanel()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        // sonraki soru
        private void lnkCevapla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            soruno++; // sonraki soruya geçtikçe soru numarasını 1 arttır
            this.Text = soruno.ToString(); // forma soru numarasını yazdır
            soruGetir(); //soruları richtextboxa getirmesi için method
            txtCevap.Text = ""; //her sonraki soruya geçişte yazılan cevabı temizle
            lnkCevapla.Enabled = true; //cevapla linki aktifleşsin

            // 24. soruya geldikten sonra bunlar olsun
            if (this.Text == "24")
            {
                lnkSonraki.Enabled = false; //24. sorudan sonra cevapla yazısına tıklanamasın
                btnHesapla.Enabled = true; // tüm sorular bittikten sonra hesapla butonu aktifleşsin
                btnBasla.Enabled = true;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); // uygulamadan çıkış
        }

        // cevaplar
        private void lnkCevapla_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch(soruno) //soru numarasına göre şartlar
            {
                //cevap 1
                case 1:
                    if(txtCevap.Text=="akdeniz")
                    {
                        btnA.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnA.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 2
                case 2:
                    if (txtCevap.Text == "bursa")
                    {
                        btnB.BackColor = Color.Green;
                        dogru++;      
                    }
                    else
                    {
                        btnB.BackColor = Color.Red;
                        yanlis++;                       
                    }
                    break;

                //cevap 3
                case 3:
                    if (txtCevap.Text == "cuma")
                    {
                        btnC.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnC.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 4
                case 4:
                    if (txtCevap.Text == "diyarbakır")
                    {
                        btnD.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnD.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 5
                case 5:
                    if (txtCevap.Text == "eski")
                    {
                        btnE.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnE.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 6
                case 6:
                    if (txtCevap.Text == "ferman")
                    {
                        btnF.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnF.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 7
                case 7:
                    if (txtCevap.Text == "güneş")
                    {
                        btnG.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnG.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 8
                case 8:
                    if (txtCevap.Text == "hafız")
                    {
                        btnH.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnH.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 9
                case 9:
                    if (txtCevap.Text == "ısparta")
                    {
                        btnI.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnI.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 10
                case 10:
                    if (txtCevap.Text == "izmit")
                    {
                        btnİ.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnİ.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 11
                case 11:
                    if (txtCevap.Text == "jandarma")
                    {
                        btnJ.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnJ.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 12
                case 12:
                    if (txtCevap.Text == "kayısı")
                    {
                        btnK.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnK.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 13
                case 13:
                    if (txtCevap.Text == "lale festivali")
                    {
                        btnL.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnL.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 14
                case 14:
                    if (txtCevap.Text == "march")
                    {
                        btnM.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnM.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 15
                case 15:
                    if (txtCevap.Text == "ney")
                    {
                        btnN.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnN.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 16
                case 16:
                    if (txtCevap.Text == "ozan")
                    {
                        btnO.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnO.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 17
                case 17:
                    if (txtCevap.Text == "pırasa")
                    {
                        btnP.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnP.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 18
                case 18:
                    if (txtCevap.Text == "ramazan")
                    {
                        btnR.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnR.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 19
                case 19:
                    if (txtCevap.Text == "snake")
                    {
                        btnS.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnS.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 20
                case 20:
                    if (txtCevap.Text == "traktör")
                    {
                        btnT.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnT.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 21
                case 21:
                    if (txtCevap.Text == "umut")
                    {
                        btnU.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnU.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 22
                case 22:
                    if (txtCevap.Text == "van")
                    {
                        btnV.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnV.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 23
                case 23:
                    if (txtCevap.Text == "yıldırım")
                    {
                        btnY.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnY.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;

                //cevap 24
                case 24:
                    if (txtCevap.Text == "zeytin")
                    {
                        btnZ.BackColor = Color.Green;
                        dogru++;
                    }
                    else
                    {
                        btnZ.BackColor = Color.Red;
                        yanlis++;
                    }
                    break;
            }

            lnkCevapla.Enabled = false;

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblDogru.Text = dogru.ToString(); // doğru sayısını yazdırır
            lblYanlis.Text = yanlis.ToString(); // yanlış sayısını yazdırır
            lblBos.Text = (24 - (dogru + yanlis)).ToString(); // boş sayısını yazdırır.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHesapla.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e) // Başla butonu
        {
            lnkSonraki.Enabled = true; // oyun baslamadan sonraki soruya geçilmez
            lnkCevapla.Enabled = true; //oyun baslamadan cevapla linkine tıklanamaz
            soruno = 1;
            this.Text = soruno.ToString(); //forma sorunoya yazdırdık
            btnBasla.Enabled = false; // oyun bitene kadar tekrar basla butonuna basılamaz.
            

            foreach (Control buton in this.Controls)
            {
                if (buton is Button)
                {
                    if (Convert.ToInt32(buton.Tag) >= 0 && Convert.ToInt32(buton.Tag) <= 23)
                    {
                        buton.BackColor = Color.Gainsboro;
                    }
                }
            }
            soruGetir(); // soruları getirmek için metod

        }

        private void soruGetir()
        {
            //soru 1
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi neresidir?";
                btnA.BackColor = Color.Yellow;
                btnHarf.Text = "A";
            }

            //soru 2
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz neresidir?";
                btnB.BackColor = Color.Yellow;
                btnHarf.Text = "B";
            }

            //soru 3
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü nedir?";
                btnC.BackColor = Color.Yellow;
                btnHarf.Text = "C";
            }

            //soru 4
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz neresidir?";
                btnD.BackColor = Color.Yellow;
                btnHarf.Text = "D";
            }

            //soru 5
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı nedir?";
                btnE.BackColor = Color.Yellow;
                btnHarf.Text = "E";
            }

            //soru 6
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı haline ne denir?";
                btnF.BackColor = Color.Yellow;
                btnHarf.Text = "F";
            }

            //soru 7
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı nedir?";
                btnG.BackColor = Color.Yellow;
                btnHarf.Text = "G";
            }

            //soru 8
            if (soruno == 8)
            {
                richTextBox1.Text = "Kuranı ezbere bilen kişilere ne denir?";
                btnH.BackColor = Color.Yellow;
                btnHarf.Text = "H";
            }

            //soru 9
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz neresidir?";
                btnI.BackColor = Color.Yellow;
                btnHarf.Text = "I";
            }

            //soru 10
            if (soruno == 10)
            {
                richTextBox1.Text = "Pişmaniyenin en meşhur olduğu şehrimiz neresidir?";
                btnİ.BackColor = Color.Yellow;
                btnHarf.Text = "İ";
            }

            //soru 11
            if (soruno == 11)
            {
                richTextBox1.Text = "Emniyet ve asayiş ile kamu düzeninin korunmasını sağlayan silahlı bir kolluk kuvvetidir?";
                btnJ.BackColor = Color.Yellow;
                btnHarf.Text = "J";
            }

            //soru 12
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatya'nın meşhur meyvesi nedir?";
                btnK.BackColor = Color.Yellow;
                btnHarf.Text = "K";
            }

            //soru 13
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali nedir?";
                btnL.BackColor = Color.Yellow;
                btnHarf.Text = "L";
            }

            //soru 14
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayının ingilizce karşılığı nedir?";
                btnM.BackColor = Color.Yellow;
                btnHarf.Text = "M";
            }

            //soru 15
            if (soruno == 15)
            {
                richTextBox1.Text = "Kamıştan yapılan, kaval biçiminde ve yanık sesli bir üflemeli çalgı? ";
                btnN.BackColor = Color.Yellow;
                btnHarf.Text = "N";
            }

            //soru 16
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairine ne denir?";
                btnO.BackColor = Color.Yellow;
                btnHarf.Text = "O";
            }

            //soru 17
            if (soruno == 17)
            {
                richTextBox1.Text = "40–50 cm uzunluğunda olabilen sapı sebze olarak yenilen, vitamince çok zengin, çok yıllık bir bitki.?";
                btnP.BackColor = Color.Yellow;
                btnHarf.Text = "P";
            }

            //soru 18
            if (soruno == 18)
            {
                richTextBox1.Text = "Bin aydan daha hayırlı olan ve 11 ayın sultanı olarak tabir edilen ayın adı nedir?";
                btnR.BackColor = Color.Yellow;
                btnHarf.Text = "R";
            }

            //soru 19
            if (soruno == 19)
            {
                richTextBox1.Text = "Yılan kelimesinin ingilizce karşılığı nedir?";
                btnS.BackColor = Color.Yellow;
                btnHarf.Text = "S";
            }

            //soru 20
            if (soruno == 20)
            {
                richTextBox1.Text = "Tarımsal işletmelerde çeşitli iş makinelerinin çalıştırılması için kullanılan kuvvet makinesi nedir?";
                btnT.BackColor = Color.Yellow;
                btnHarf.Text = "T";
            }

            //soru 21
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı ve aynı zamanda isim olarak kullanılan kelime?";
                btnU.BackColor = Color.Yellow;
                btnHarf.Text = "U";
            }

            //soru 22
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz neresidir?";
                btnV.BackColor = Color.Yellow;
                btnHarf.Text = "V";
            }

            //soru 23
            if (soruno == 23)
            {
                richTextBox1.Text = "Elektrik yüklü bir bulut ile toprak arasındaki elektriksel deşarja ne denir?";
                btnY.BackColor = Color.Yellow;
                btnHarf.Text = "Y";
            }

            //soru 24
            if (soruno == 24)
            {
                richTextBox1.Text = "Anayurdu Akdeniz çevresi olan ve kahvaltıların vazgeçilmesi olan besinimiz nedir?";
                btnZ.BackColor = Color.Yellow;
                btnHarf.Text = "Z";
            }
        }
    }
}
