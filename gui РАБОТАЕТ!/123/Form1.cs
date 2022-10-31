namespace _123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1_first_number.Text = Properties.Settings.Default.first_number.ToString();
            textBox2_second_number.Text = Properties.Settings.Default.second_number.ToString();
            textBox3_therd_number.Text = Properties.Settings.Default.therd_number.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var first_number = int.Parse(this.textBox1_first_number.Text);          //ГОТОВО
            var second_number = int.Parse(this.textBox2_second_number.Text);
            var therd_number = int.Parse(this.textBox3_therd_number.Text);


            Properties.Settings.Default.first_number = first_number;
            Properties.Settings.Default.second_number = second_number;
            Properties.Settings.Default.therd_number = therd_number;
            Properties.Settings.Default.Save();

            // выведем сообщение о сравнимости заработка
            MessageBox.Show(Logic.construction(first_number, second_number, therd_number));
            //MessageBox.Show(this.textBox1_first_number.Text);
        }

        public class Logic
        {
            public static string construction(int a, int b, int c)
            {

                string result = "";
                ///Составить программу нахождения произведения двух наименьших из трех различных чисел
                int max;
                if (a > b)
                {
                    max = a;
                }
                else
                {
                    max = b; ;
                }
                if (c > max)
                {
                    max = c;
                }
                if (a == b || b == c || a == c)
                {
                    result = "Были введены одинаковые значения! Вычисление произведения не возможно";
                }
                else
                {
                    result = "Произведениe двух наименьших из трех чисел = " + a * b * c / max;
                }

                return result;

            }
            class Program
            {
                static void r(string[] args)
                {
                    int a, b, c, max;
                    Console.WriteLine("Введите a");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите b");
                    c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите c");
                    b = int.Parse(Console.ReadLine());
                }
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}