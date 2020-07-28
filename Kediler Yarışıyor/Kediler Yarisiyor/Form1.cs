// Ekrem Yorulmaz 
// ilk oyun denemesi 
// 
using System;
using System.Windows.Forms;

namespace Kediler_Yarisiyor
{
    public partial class Form1 : Form
    {
        int uzaklık1, uzaklık2, uzaklık3;
        Random rastgelesayi = new Random();


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, System.EventArgs e)
        {
            uzaklık1 = Picboxkedi1.Left;
            uzaklık2 = Picboxkedi2.Left;
            uzaklık3 = Picboxkedi3.Left;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Picboxkedi1.Left = uzaklık1;
            Picboxkedi2.Left = uzaklık2;
            Picboxkedi3.Left = uzaklık3;
            lblsonuc.Text = "Yarış Sonucu";
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Picboxkedi1.Left < Picboxkedi2.Left && Picboxkedi2.Left > Picboxkedi3.Left)
            {
                lblsonuc.Text = "2. kedi yarışı önde götürüyor değerli seyirciler.";
            }
            if (Picboxkedi3.Left > Picboxkedi1.Left && Picboxkedi3.Left > Picboxkedi2.Left)
            {
                lblsonuc.Text = "3. kedi yarışı önde götürüyor değerli seyirciler";
            }
            if (Picboxkedi1.Left > Picboxkedi2.Left && Picboxkedi1.Left > Picboxkedi3.Left)
            {
                lblsonuc.Text = "1. kedi yarışı önde götürüyor değerli seyirciler";
            }

            int birincikedigenislik = Picboxkedi1.Width;
            int ikincikedigenislik = Picboxkedi2.Width;
            int ucuncukedigenislik = Picboxkedi3.Width;
            int bitisuzakligi = lblfinish.Left;

            Picboxkedi1.Left += rastgelesayi.Next(2, 15);
            Picboxkedi2.Left += rastgelesayi.Next(2, 15);
            Picboxkedi3.Left += rastgelesayi.Next(2, 15);

            if (Picboxkedi1.Left + Picboxkedi1.Width > bitisuzakligi)
            {
                timer1.Stop();
                MessageBox.Show("birinci kedi yarışı kazandı");
            }
            else if (Picboxkedi2.Left + Picboxkedi2.Width > bitisuzakligi)
            {
                timer1.Stop();
                MessageBox.Show("ikinci kedi yarışı kazandı");
            }
            else if (Picboxkedi3.Left + Picboxkedi3.Width > bitisuzakligi)
            {
                timer1.Stop();
                MessageBox.Show("üçüncü kedi yarışı kazandık");
            }
        }



    }
}
