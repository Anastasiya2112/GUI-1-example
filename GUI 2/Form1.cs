namespace GUI_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var persant = this.Stroka.Text;
            var result_program_logic = Logic.program_logic(persant);
            // выведем сообщение о сравнимости заработка
            var g = Logic.vichis(persant, result_program_logic);
            MessageBox.Show("Доля в % букв в предложении = " + g);
        }
        public class Logic
        {

            public static int program_logic(string TextLine)
            {
                int number = 0;
                for (int j = 0; j < TextLine.Length; j++)//лог
                {
                    //symbols++;
                    if ((TextLine[j] >= '0') & (TextLine[j] <= '9'))
                    {
                        number++;
                    }
                }
                return number;
            }
            public static int vichis(string TextLine, int number)
            {
                int size, p, b;
                size = TextLine.Length;
                p = size - number;
                b = ((100 * p) / size);
                /*if (b==100 & number==0)
                {
                    b = 0;
                }*/
                return b;
            }
        }
        class Program
        {
            static void Mai(string[] args)
            {
                int size, p, symbols;
                string TextLine = Console.ReadLine();//поль
                var number = Logic.program_logic(TextLine);
                var d = Logic.vichis(TextLine, number);
                Console.WriteLine("Доля в % букв в предложении = " + d);//поль
            }
        }

        private void Stroka_TextChanged(object sender, EventArgs e)
        {

        }
    }

}