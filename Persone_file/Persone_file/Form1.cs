namespace Persone_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Persona> lista = new List<Persona>();
        public static void scriviAppend(string filename, string content)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }
        private void AggiornaInterfaccia()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lista;
            listBox1.DisplayMember = "listtext";

        }
        public static void cerca(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('-'); // Dividi la stringa usando '-'
                    if (parts.Length > 0)
                    {
                        string id = parts[0].Trim(); // Prendi l'ID e rimuovi eventuali spazi
                        
                    }
                    //Aggiungi cerca
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(textBoxID.Text, textBoxN.Text, textBoxS.Text);

            lista.Add(persona);
            scriviAppend(@"./elenco_persone.txt", persona.Id + " - " + persona.Name + " - " + persona.Surname);
            persona.OttieniLista();
            AggiornaInterfaccia();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}