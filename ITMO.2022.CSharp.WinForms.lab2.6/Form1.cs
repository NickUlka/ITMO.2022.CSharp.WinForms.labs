using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClass;




namespace ITMO._2022.CSharp.WinForms.lab2._6
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
        List<Item> its = new List<Item>();
        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //создайте объект класса Book, передав в конструктор свойства 
        //формы:

            Book b = new Book(Author, Title, PublishHouse,
             Page, Year, InvNumber, Existence);

            // реализуйте проверку возврата книги в срок:
            if (ReturnTime)
                b.ReturnSrok();

            //И расчет стоимости с учетом срока пользования книгой
            b.PriceBook(PeriodUse);


            //добавьте книгу в список
            its.Add(b);

            //очистите поля ввода для новой информации
            //(будьте внимательны, укажите значения, входящие в допустимый диапазон, 
            //который вы настраивали ранее)
            Author = Title = PublishHouse = "";
            Page = 4;
            InvNumber = 1;
            PeriodUse = 1;
            Year = 1900;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверьте состояние флажка сортировки и в
            //случае его установки отсортируйте список:
            if (SortInvNumber)
                its.Sort();

            //Для вывода информации создайте строку класса StringBuilder и с 
            // помощью цикла постройте строку и информацией о единице хранения:
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }

            //После построения строки выведете ее в элемент richTextBox1:
             richTextBox1.Text = sb.ToString();
        }
    }
}
