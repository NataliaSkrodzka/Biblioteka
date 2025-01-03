using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
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
        private Node head;
        private string wyswietl;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            string nazwaKsiazki = textBox1.Text.ToString();
            DodajKsiazke(nazwaKsiazki);
            MessageBox.Show("dodano");
            textBox1.Clear();
        }
        public void DodajKsiazke(string nazwaKsiazki)
        {
            Node newNode = new Node(nazwaKsiazki);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Prev = temp;
        }

        private void wyswietl_Click(object sender, EventArgs e)
        {
            WyswietlKsiazki();
            MessageBox.Show(wyswietl);
        }
        public string WyswietlKsiazki()
            
        {

            Node temp = head;
            if (temp == null)
            {
                wyswietl = "Biblioteka jest pusta";
                return wyswietl;
            }
            wyswietl = "Lista ksiazek w bibliotece:";
            int i = 1;
            while(temp != null)
            {
                wyswietl +="\n"+i+" "+temp.Data;
                temp = temp.Next;
                i++;
            }
            return wyswietl;


        }

        private void usun_Click(object sender, EventArgs e)
        {
            string nazwaKsiazki = textBox2.Text.ToString();
            string wiadomosc = UsunKsiazke(nazwaKsiazki);
            MessageBox.Show(wiadomosc);
            textBox2.Clear();
        }
        public string UsunKsiazke(string nazwaKsiazki)
        {
            string wiadomosc;
            Node temp = head;
            while( temp != null && temp.Data !=nazwaKsiazki) {
            temp = temp.Next;
            }
            if(temp == null) {
                wiadomosc= nazwaKsiazki +" nie zostala znaleziona";
                return wiadomosc;
            }
            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
            else
            {
                head = temp.Next;

                //jesli to pierwszy element
            }
            if(temp.Next != null)
            {  temp.Next.Prev = temp.Prev;
            }
            wiadomosc = $"Książka '{nazwaKsiazki}' została usunięta";
            return wiadomosc;
        }
    }
}
