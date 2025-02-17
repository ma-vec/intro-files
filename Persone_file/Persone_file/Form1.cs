namespace Persone_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void scriviAppend(string filename, string content)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(textBoxID.Text, textBoxN.Text, textBoxS.Text);
            scriviAppend(@"./elenco_persone.txt", persona.Id+" - "+persona.Name+" - "+persona.Surname);
        }
    }
}