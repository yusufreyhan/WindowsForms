using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2._2_passaparolla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        int soruno = 0, doğru = 0, yanlış = 0, sure = 300;
        bool aktif = true;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {




            if (e.KeyCode == Keys.Enter && aktif == true)
            {

                switch (soruno)
                {
                    //cvpa
                    case 1:

                        if (textBox1.Text == "almanya")
                        {
                            btna.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btna.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : ALMANYA");
                        }
                        break;
                    //cvpb
                    case 2:

                        if (textBox1.Text == "buse")
                        {
                            btnb.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnb.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : BUSE");
                        }
                        break;
                    //cvpc
                    case 3:

                        if (textBox1.Text == "chp")
                        {
                            btnc.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnc.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : CHP");
                        }
                        break;
                    //cvpç
                    case 4:

                        if (textBox1.Text == "çıra")
                        {
                            btnç.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnç.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : ÇIRA");
                        }
                        break;
                    //cvpd
                    case 5:

                        if (textBox1.Text == "dadaş")
                        {
                            btnd.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnd.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : DADAŞ");
                        }
                        break;
                    //cvpe
                    case 6:

                        if (textBox1.Text == "egoist")
                        {
                            btne.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btne.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : EGOİST");
                        }
                        break;
                    //cvpf
                    case 7:

                        if (textBox1.Text == "fetva")
                        {
                            btnf.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnf.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : FETVA");
                        }
                        break;
                    //cvpg
                    case 8:

                        if (textBox1.Text == "ganyan")
                        {
                            btng.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btng.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : GANYAN");
                        }
                        break;
                    //cvph
                    case 9:

                        if (textBox1.Text == "hakikat")
                        {
                            btnh.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnh.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : HAKİKAT");
                        }
                        break;
                    //cvpı
                    case 10:

                        if (textBox1.Text == "ırmak")
                        {
                            btnı.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnı.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : IRMAK");
                        }
                        break;
                    //cvpi
                    case 11:

                        if (textBox1.Text == "iris")
                        {
                            btni.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btni.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : İRİS");
                        }
                        break;
                    //cvpj
                    case 12:

                        if (textBox1.Text == "jeoloji")
                        {
                            btnj.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnj.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : JEOLOJİ");
                        }
                        break;
                    //cvpk
                    case 13:

                        if (textBox1.Text == "kgb")
                        {
                            btnk.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnk.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : KGB");
                        }
                        break;
                    //cvpl
                    case 14:

                        if (textBox1.Text == "lama")
                        {
                            btnl.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnl.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : LAMA");
                        }
                        break;
                    //cvpm
                    case 15:

                        if (textBox1.Text == "malt")
                        {
                            btnm.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnm.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : MALT");
                        }
                        break;
                    //cvpn
                    case 16:

                        if (textBox1.Text == "nafaka")
                        {
                            btnn.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnn.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : NAFAKA");
                        }
                        break;
                    //cvpo
                    case 17:

                        if (textBox1.Text == "okçuluk")
                        {
                            btno.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btno.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : OKÇULUK");
                        }
                        break;
                    //cvpö
                    case 18:

                        if (textBox1.Text == "ödenek")
                        {
                            btnö.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnö.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : ÖDENEK");
                        }
                        break;
                    //cvpp
                    case 19:

                        if (textBox1.Text == "palavra")
                        {
                            btnp.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnp.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : PALAVRA");
                        }
                        break;
                    //cvpr
                    case 20:

                        if (textBox1.Text == "rimel")
                        {
                            btnr.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString(); doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnr.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : RİMEL");
                        }
                        break;
                    //cvps
                    case 21:

                        if (textBox1.Text == "sağanak")
                        {
                            btns.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btns.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : SAĞANAK");
                        }
                        break;
                    //cvpş
                    case 22:

                        if (textBox1.Text == "şeref")
                        {
                            btnş.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnş.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : ŞEREF");
                        }
                        break;
                    //cvpt
                    case 23:

                        if (textBox1.Text == "tabut")
                        {
                            btnt.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnt.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : TABUT");
                        }
                        break;
                    //cvpu
                    case 24:

                        if (textBox1.Text == "ucube")
                        {
                            btnu.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnu.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : UCUBE");
                        }
                        break;
                    //cvpü
                    case 25:

                        if (textBox1.Text == "üslup")
                        {
                            btnü.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnü.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : ÜSLUP");
                        }
                        break;
                    //cvpv
                    case 26:

                        if (textBox1.Text == "vapur")
                        {
                            btnv.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnv.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : VAPUR");
                        }
                        break;
                    //cvpy
                    case 27:

                        if (textBox1.Text == "yas")
                        {
                            btny.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btny.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : YAS");
                        }
                        break;
                    //cvpz
                    case 28:

                        if (textBox1.Text == "zerzevat")
                        {
                            btnz.BackColor = Color.Green;
                            doğru++;
                            label3.Text = doğru.ToString();
                        }
                        else
                        {
                            btnz.BackColor = Color.Red;
                            yanlış++;
                            label4.Text = yanlış.ToString();
                            MessageBox.Show("CEVAP : ZERZAVAT");
                        }
                        break;


                }

                aktif = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                timer1.Stop();
                textBox1.Enabled = false;
                linkLabel1.Enabled = false;
                MessageBox.Show("SÜRENİZ BİTTİ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aktif = true;
            linkLabel1.Text = "Sonraki";
            timer1.Start();
            textBox1.Clear();
            textBox1.Focus();
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Başkenti Berlin olan ülke";
                btna.BackColor = Color.Gold;
                btn.Text = "A";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Günümüzde kadın ismi olarak da kullanılan eski dilde öpücük ";
                btnb.BackColor = Color.Gold;
                btn.Text = "B";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "1923 yılında Ulu Önder Mustafa Kemal Atatürk tarafından kurulan partinin kısa adı";
                btnc.BackColor = Color.Gold;
                btn.Text = "C";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Çam ve benzeri reçineli ağaçların yağlı ve yanmaya elverişli bölümü";
                btnç.BackColor = Color.Gold;
                btn.Text = "Ç";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Erzurumda sıkça kullanılan ve erkek kardeş, yiğit, delikanlı anlamlarına gelen kelime";
                btnd.BackColor = Color.Gold;
                btn.Text = "D";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Bireysel çıkarlarını toplumun, başkalarını çıkarlarından önde tutan ben merkezli kimse";
                btne.BackColor = Color.Gold;
                btn.Text = "E";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "İslam hukuunda şeyhüislam ya da mütfü tarafından verilen emir ya da yargı";
                btnf.BackColor = Color.Gold;
                btn.Text = "F";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "At yarışlarında kazanan at";
                btng.BackColor = Color.Gold;
                btn.Text = "G";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Bir işin doğrusu, gerçek";
                btnh.BackColor = Color.Gold;
                btn.Text = "H";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "genellikle bir denize dökülen, genişliği, uzunluğu ve taşıdığı su yönünden en büyük akarsu";
                btnı.BackColor = Color.Gold;
                btn.Text = "I";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Gözün renki kısmı";
                btni.BackColor = Color.Gold;
                btn.Text = "İ";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Yerbilimi";
                btnj.BackColor = Color.Gold;
                btn.Text = "J";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Rus istihbarat örgütünün kısa adı";
                btnk.BackColor = Color.Gold;
                btn.Text = "K";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Tükürmesi ile ünlü hayvan";
                btnl.BackColor = Color.Gold;
                btn.Text = "L";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Bira yapıında kullanılan çimlenmiş ve kavrulmuş arpa";
                btnm.BackColor = Color.Gold;
                btn.Text = "M";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Bir kimsenin geçindirmekle, bakıp gözetmekle yükümlü bulunduğu kimseye, mahkeme kararıyla verdiği aylık";
                btnn.BackColor = Color.Gold;
                btn.Text = "N";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Milli gururumuz Mete Gazoz'un dünya şampiyonu olduğu spor dalı";
                btno.BackColor = Color.Gold;
                btn.Text = "O";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Bir iş için ayrılan belli para";
                btnö.BackColor = Color.Gold;
                btn.Text = "Ö";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Gerçeğe aykırı, uzun ve boş söz";
                btnp.BackColor = Color.Gold;
                btn.Text = "P";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Kadınların, kirpiklerini kıvırmak, daha uzun ve renkli göstermek için fırçayla sürdükleri yağlı sürme";
                btnr.BackColor = Color.Gold;
                btn.Text = "R";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Birdenbire başlayan, çok sulu olarak yağan kısa süreli yağmur";
                btns.BackColor = Color.Gold;
                btn.Text = "S";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Onur";
                btnş.BackColor = Color.Gold;
                btn.Text = "Ş";
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Ölünün, mezarlığa götürülürken içine konulduğu bir tür sandık";
                btnt.BackColor = Color.Gold;
                btn.Text = "T";
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Şaşılacak denli çirkin olan, çok acayip şey";
                btnu.BackColor = Color.Gold;
                btn.Text = "U";
            }
            if (soruno == 25)
            {
                richTextBox1.Text = "anlatma biçimi, deyiş ya da yapış biçimi";
                btnü.BackColor = Color.Gold;
                btn.Text = "Ü";
            }
            if (soruno == 26)
            {
                richTextBox1.Text = "Buhar gücüyle işleyen gemi";
                btnv.BackColor = Color.Gold;
                btn.Text = "V";
            }
            if (soruno == 27)
            {
                richTextBox1.Text = "Sevilen birinin ölümünden ya da yurdun, ulusun uğradığı bir felaketten duyulan derin acı";
                btny.BackColor = Color.Gold;
                btn.Text = "Y";
            }
            if (soruno == 28)
            {
                richTextBox1.Text = "sebze, küçük önemsiz nesne";
                btnz.BackColor = Color.Gold;
                btn.Text = "Z";
            }
        }
    }
}
