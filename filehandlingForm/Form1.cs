namespace filehandlingForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //write button
            FileStream fs = new FileStream(textBox1.Text, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(richTextBox1.Text);
            sw.Flush();
            fs.Close();
            MessageBox.Show("Content is written in file successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Read the file
            try
            {
                FileStream fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox2.Text = sr.ReadToEnd();
                fs.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not found");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //finding words in file
            FileStream fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            String str= sr.ReadToEnd();
            int i=str.IndexOf(richTextBox3.Text,0);

            if(i > -1)
            {
                MessageBox.Show("Word exist in the file");
            }
            else
            {
                MessageBox.Show("Word Not found");
            }

        }
    }
}