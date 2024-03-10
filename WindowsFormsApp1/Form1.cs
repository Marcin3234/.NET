using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> OriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
    
        public Form1() // deklaracja do mapy bitowej 3x3 - 9 obrazkow + 1 pusty(czarny)
        {
            InitializeComponent();
            OriginalPictureList.AddRange(new Bitmap[]
      {
        Resources._1,
        Resources._2,
        Resources._3,
        Resources._4,
        Resources._5,
        Resources._6,
        Resources._7,
        Resources._8,
        Resources._9,
        Resources._null
      });
            ruchy.Text += inmoves;
            czas.Text = "00:00:00";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            przetasuje();
        }

        void przetasuje()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 }); // 9 - pozycja null 8-- usunięte bo w jego miejsce wchodzi puste pole
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)groupBox1.Controls[i]).Image = OriginalPictureList[j];
                    if (j == 9) inNullSliceIndex = i;
                }
            } while (sprawdz());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void czas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void przetasuj_Click(object sender, EventArgs e) // reset gry - rozpoczecie gry
        {
            DialogResult taknie = new DialogResult();
            if (czas.Text != "00:00:00")
            {
                taknie = MessageBox.Show("Jesteś pewny, że chcesz zrestartować grę?", "Kwieciste puzzle", MessageBoxButtons.YesNoCancel);
            }
            if (taknie == DialogResult.Yes || czas.Text == "00:00:00")
            {
                przetasuje();
                timer.Reset();
                czas.Text = "00:00:00";
                if (czas.Text == "00:00:00")
                    timer.Start();
                inmoves = 0;
                ruchy.Text = "Ilość ruchów:  0 ";
                sprawdz();
            }
        }

        private void ZmianaPictureBox(object sender, EventArgs e) // funckja do zmiany obrazka
        { 
       if (czas.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = groupBox1.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex)) // zamienie obrazkow o wektory lewo prawo gora dol w zaleznosci pozycji obrazka w kątach jak i bokach
                {
                    ((PictureBox)groupBox1.Controls[inNullSliceIndex]).Image = ((PictureBox)groupBox1.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)groupBox1.Controls[inPictureBoxIndex]).Image = OriginalPictureList[9];
                    inNullSliceIndex = inPictureBoxIndex;
                    ruchy.Text = "Ilość ruchów:  " + (++inmoves);
                    if (sprawdz())
                    {
                        timer.Stop();
                        (groupBox1.Controls[8] as PictureBox).Image = OriginalPictureList[8];
                        MessageBox.Show("Brawo! \n Udało Ci się ułożyć! \n Ukończyłeś układankę w : " 
                        + timer.Elapsed.ToString().Remove(8) + "\nWykonałeś: " + inmoves + " ruchów!", "Kwieciste Puzzle");
                        inmoves = 0;
                        ruchy.Text = "Ilość ruchów:  0 ";
                        czas.Text = "00:00:00";
                        timer.Reset();
                        przetasuje();
    }
}
            }
        }
        // Te zmiany powinny sprawić, że sprawdzenie wygranej będzie działać poprawnie po każdej zamianie puzzli.



        bool sprawdz() // sprawdzanie wygranej
        {
            int i;
            for (i = 0; i < 8; i++) // warunek do 8 poniewaz tablica zaczyna sie od 0
            {
                if ((groupBox1.Controls[i] as PictureBox).Image != OriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reset_czasu(object sender, EventArgs e) // funkcja do resetowania czasu, gdy uzytkownik wygra lub skonczy sie czas
        {
            if (timer.Elapsed.ToString() != "00:00:00")
                czas.Text = timer.Elapsed.ToString().Remove(8);
            if (timer.Elapsed.ToString() == "00:00:00")
                button1.Enabled = false;
            else
                button1.Enabled = true;
            if (timer.Elapsed.Minutes.ToString() == "3")
            {
                timer.Reset();
                ruchy.Text = "Ilość ruchów:  0 ";
                czas.Text = "00:00:00";
                inmoves = 0;
                button1.Enabled = false;
                MessageBox.Show("Czas minął\n Spróbuj jeszcze raz!", "Kwieciste puzzle");
                przetasuje();
            }
        }
        private void zamknac(object sender, CancelEventArgs e) // funkcja do wyswietlania okienka zamknienia aplikacji
        {
            DialogResult taknie = MessageBox.Show("Czy na pewno chcesz wyjść?", "Kwieciste puzzle", MessageBoxButtons.YesNo);
            if (sender as Button != button3 && taknie == DialogResult.No) e.Cancel = true;
            if (sender as Button == button3 && taknie == DialogResult.Yes) Environment.Exit(0);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            zamknac(sender, e as CancelEventArgs); // przycisk do wylaczania gry
        }
        private void wznowienie(object sender, EventArgs e) // przycisk na wznowienie i zapauzowanie gry
        {
            if (button1.Text == "Pauza")
            {
                timer.Stop();
                groupBox1.Visible = false;
                button1.Text = "Wznów";
            }
            else
            {
                timer.Start();
                groupBox1.Visible = true;
                button1.Text = "Pauza";
            }
        }
        private void pbx7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}