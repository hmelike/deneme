using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
                
            soruno++;
            this.Text = soruno.ToString();
            textBox1.Clear();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin Güney kısmında ki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Kestane şekeri ile ünlü ilimiz hangisidir?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile meşhur ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin karşıt anlamlısı?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Müslümanlıkta, geçerli bir özür olmadıkça kesinlikle yapılması gereken, yapılmaması günah sayılan Tanrı buyruğu. ?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı nedir?";
                button7.BackColor = Color.Yellow;
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "Kabe ziyareti sonrası insanlara verilen isim?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Genellikle denizlere, göllere ya da bir başka büyük akarsuya dökülen, özellikle genişliği ve taşıdığı su miktarı bakımından büyük akarsulara verilen genel isim nedir?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Müslümanların dini nedir?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = " Mekanik enerjiyi elektrik enerjisine çeviren elektrik makinesi'dir. Mekanik enerjinin kaynağı buhar makinesi, su, içten yanmalı motor, rüzgâr türbini nedir?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = " Kahvede, çayda, yerba mate'de, guarana'da ve, az miktarda, kakao içinde bulunan maddenin adı?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = " Zambakgiller familyasından Tulipa cinsini oluşturan güzel çiçekleri ile süs bitkisi olarak yetiştirilen, soğanlı, çok yıllık otsu bitki türlerinin ortak adı?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = " ışıktan yaratıldığına ve Tanrı ile insan arasında aracılık yaptığına inanılan, gözle görülmeyen, tinsel varlık.?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = " Kaba kelimesinin karşıt isimlisi?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = " Okuyup yazma öğretiminden başlayarak en yüksek düzeyde bilim ve sanat bilgisi vermeye değin çeşitli derecede toplu öğretimin yapıldığı, verildiği yer.?";
                button16.BackColor = Color.Yellow;
            }

            if (soruno == 17)
            {
                richTextBox1.Text = "Çok büyük bir çeşitlilikteki aroma, tat, yapı ve şekle sahip bir grup süt ürünü için kullanılan genel isimdir.?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Işığın, kendi öz yapısına ya da cisimlerden yansımasına bağlı olarak gözde oluşturduğu duyum..?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Dünya üzerinde bol miktarda bulunan ve tüm canlıların yaşaması için vazgeçilmez olan, kokusuz ve tatsız bir kimyasal bileşiktir?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Kirlinin karşıt anlamlısı?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Kısanın karşıt anlamlısı?";
                button21.BackColor = Color.Yellow;
            }
           

            if (soruno == 22)
            {
                richTextBox1.Text = "İslam'da bir kavram olan ve Kur'an'da geçen Allah'ın 99 ismi'nden biridir?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Düşünme, kavrama, karşılaştırma, değerlendirme gibi yollara başvurularak, kişi, durum ya da nesnelerin eleştirici bir biçimde değerlendirilmesi.?";
                button23.BackColor = Color.Yellow;
            }

            if (soruno == 24)
            {
                richTextBox1.Text = "Bir kimsenin hakkını zorla elinden alan, haksızlık yapan, merhametsiz ve gaddar kimse.?";
                button24.BackColor = Color.Yellow;
            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                switch(soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            label2.Text = "1";
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!");
                            Application.Exit();
                            
                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            label2.Text = "2";
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 1 soru bildiniz");
                            Application.Exit();
                        }
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            label2.Text = "3";
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 2 soru bildiniz");
                            Application.Exit();
                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            label2.Text = "4";
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 3 soru bildiniz");
                            Application.Exit();
                        }
                        break;
                }

            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            label2.Text = "5";
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 4 soru bildiniz");
                            Application.Exit();


                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 6:
                        if (textBox1.Text == "farz")
                        {
                            button6.BackColor = Color.Green;
                            label2.Text = "6";
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 5 soru bildiniz");
                            Application.Exit();


                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            label2.Text = "7";
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 6 soru bildiniz");
                            Application.Exit();


                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 8:
                        if (textBox1.Text == "hacı")
                        {
                            button8.BackColor = Color.Green;
                            label2.Text = "8";
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 7 soru bildiniz");
                            Application.Exit();


                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 9:
                        if (textBox1.Text == "ırmak")
                        {
                            button9.BackColor = Color.Green;
                            label2.Text = "9";
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 8 soru bildiniz");
                            Application.Exit();
                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 10:
                        if (textBox1.Text == "islam")
                        {
                            button10.BackColor = Color.Green;
                            label2.Text = "10";
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 9 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 11:
                        if (textBox1.Text == "jeneratör")
                        {
                            button11.BackColor = Color.Green;
                            label2.Text = "11";
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 10 soru bildiniz");
                            Application.Exit();


                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 12:
                        if (textBox1.Text == "kafein")
                        {
                            button12.BackColor = Color.Green;
                            label2.Text = "12";
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 11 soru bildiniz");
                            Application.Exit();
                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            label2.Text = "13";
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 12 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 14:
                        if (textBox1.Text == "melek")
                        {
                            button14.BackColor = Color.Green;
                            label2.Text = "14";
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 13 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 15:
                        if (textBox1.Text == "nazik")
                        {
                            button15.BackColor = Color.Green;
                            label2.Text = "15";
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 14 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }


            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 16:
                        if (textBox1.Text == "okul")
                        {
                            button16.BackColor = Color.Green;
                            label2.Text = "16";
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 15 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }

            if(e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 17:
                        if (textBox1.Text == "peynir")
                        {
                            button17.BackColor = Color.Green;
                            label2.Text = "17";
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 16 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 18:
                        if (textBox1.Text == "renk")
                        {
                            button18.BackColor = Color.Green;
                            label2.Text = "18";
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 17 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 19:
                        if (textBox1.Text == "su")
                        {
                            button19.BackColor = Color.Green;
                            label2.Text = "19";
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 18 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 20:
                        if (textBox1.Text == "temiz")
                        {
                            button20.BackColor = Color.Green;
                            label2.Text = "20";
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 19 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }

            if(e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 21:
                        if (textBox1.Text == "uzun")
                        {
                            button21.BackColor = Color.Green;
                            label2.Text = "21";
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 20 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 22:
                        if (textBox1.Text == "veli")
                        {
                            button22.BackColor = Color.Green;
                            label2.Text = "22";
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 20 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 23:
                        if (textBox1.Text == "yargı")
                        {
                            button23.BackColor = Color.Green;
                            label2.Text = "23";
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 20 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 24:
                        if (textBox1.Text == "zalim")
                        {
                            button24.BackColor = Color.Green;
                            label2.Text = "24";
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            MessageBox.Show("KAYBETTİNİZ!!Sadece 20 soru bildiniz");
                            Application.Exit();

                        }
                        break;
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin Güney kısmında ki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Kestane şekeri ile ünlü ilimiz hangisidir?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile meşhur ilimiz?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin karşıt anlamlısı?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Müslümanlıkta, geçerli bir özür olmadıkça kesinlikle yapılması gereken, yapılmaması günah sayılan Tanrı buyruğu. ?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı nedir?";
                button7.BackColor = Color.Yellow;
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "Kabe ziyareti sonrası insanlara verilen isim?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Genellikle denizlere, göllere ya da bir başka büyük akarsuya dökülen, özellikle genişliği ve taşıdığı su miktarı bakımından büyük akarsulara verilen genel isim nedir?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Müslümanların dini nedir?";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = " Mekanik enerjiyi elektrik enerjisine çeviren elektrik makinesi'dir. Mekanik enerjinin kaynağı buhar makinesi, su, içten yanmalı motor, rüzgâr türbini nedir?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = " Kahvede, çayda, yerba mate'de, guarana'da ve, az miktarda, kakao içinde bulunan maddenin adı?";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = " Zambakgiller familyasından Tulipa cinsini oluşturan güzel çiçekleri ile süs bitkisi olarak yetiştirilen, soğanlı, çok yıllık otsu bitki türlerinin ortak adı?";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = " ışıktan yaratıldığına ve Tanrı ile insan arasında aracılık yaptığına inanılan, gözle görülmeyen, tinsel varlık.?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = " Kaba kelimesinin karşıt isimlisi?";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = " Okuyup yazma öğretiminden başlayarak en yüksek düzeyde bilim ve sanat bilgisi vermeye değin çeşitli derecede toplu öğretimin yapıldığı, verildiği yer.?";
                button16.BackColor = Color.Yellow;
            }

            if (soruno == 17)
            {
                richTextBox1.Text = "Çok büyük bir çeşitlilikteki aroma, tat, yapı ve şekle sahip bir grup süt ürünü için kullanılan genel isimdir.?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Işığın, kendi öz yapısına ya da cisimlerden yansımasına bağlı olarak gözde oluşturduğu duyum..?";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Dünya üzerinde bol miktarda bulunan ve tüm canlıların yaşaması için vazgeçilmez olan, kokusuz ve tatsız bir kimyasal bileşiktir?";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Kirlinin karşıt anlamlısı?";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Kısanın karşıt anlamlısı?";
                button21.BackColor = Color.Yellow;
            }


            if (soruno == 22)
            {
                richTextBox1.Text = "İslam'da bir kavram olan ve Kur'an'da geçen Allah'ın 99 ismi'nden biridir?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Düşünme, kavrama, karşılaştırma, değerlendirme gibi yollara başvurularak, kişi, durum ya da nesnelerin eleştirici bir biçimde değerlendirilmesi.?";
                button23.BackColor = Color.Yellow;
            }

            if (soruno == 24)
            {
                richTextBox1.Text = "Bir kimsenin hakkını zorla elinden alan, haksızlık yapan, merhametsiz ve gaddar kimse.?";
                button24.BackColor = Color.Yellow;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
