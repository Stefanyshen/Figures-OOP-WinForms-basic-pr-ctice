namespace FiguresWindow
{
    public partial class Form1 : Form
    {
        private string[] commands;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                commands = File.ReadAllLines(openFileDialog.FileName);
                textBox1.Text = "File was success opened.";
                button2.Enabled = true;
                button3.Enabled = false;
            }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            try
            {
                var figures = new Figure[int.Parse(commands[0])];
                for (int i = 1; i <= int.Parse(commands[0]); i++)
                {
                    var temp = commands[i].Split();
                    figures[i - 1] = Program.Dict[temp[0]](temp);
                }
                textBox1.Clear();
                foreach (var item in figures)
                    textBox1.Text += item.ToString() + "\r\n\t" + "P = " + item.Perimeter() + ", S = " + item.Square() + "\r\n";
                button3.Enabled = true;
            }
            catch
            {
                InvalidFileContains();
            }
        }

        private void Button3Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var sw = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < textBox1.Lines.Length; i++)
                    sw.WriteLine(textBox1.Lines[i]);
                sw.Close();
            }
        }
        private void Button4Click(object sender, EventArgs e)
        {

            button4.Visible = false;
            label1.Visible = false;
            button1.Enabled = true;
            textBox1.Visible = true;
            textBox1.Text = "Program has started.";
        }

        private void Form1Load(object sender, EventArgs e)
        {

        }

        private void TextBox1TextChanged(object sender, EventArgs e)
        {

        }

        private void InvalidFileContains()
        {
            textBox1.Visible = false;
            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Visible = true;
            label1.Visible = true;
        }
    }
}