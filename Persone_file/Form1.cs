using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DB_people
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Read("persons.txt"); // Load existing data when the form starts
        }

        // Add a new person to the list and file
        private void add_Click(object sender, EventArgs e)
        {
            string id = ID_TB.Text;
            string name = nam_TB.Text;
            string surname = sur_TB.Text;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("inserisci i dati.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Person person = new Person(id, name, surname);
            string personSTR = person.DataString();
            listPeople.Items.Add(personSTR); // Add to ListBox
            WriteAppend("persons.txt", personSTR); // Append to file

            // Clear input fields
            ID_TB.Text = "";
            nam_TB.Text = "";
            sur_TB.Text = "";
        }

        // Append a line to the file
        private void WriteAppend(string fileName, string content)
        {
            try
            {
                File.AppendAllText(fileName, content + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search for a person by ID
        private void Find(string id)
        {
            try
            {
                bool found = false;

                foreach (var line in File.ReadAllLines("persons.txt"))
                {
                    string[] parts = line.Split(';');
                    if (parts[0] == id)
                    {
                        sur_TB.Text = parts[1];
                        nam_TB.Text = parts[2];
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    sur_TB.Text = "";
                    nam_TB.Text = "";
                    MessageBox.Show("Nessuna corrispondenza.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle search button click
        private void search_Click(object sender, EventArgs e)
        {
            Find(ID_TB.Text);
        }

        // Read data from file and populate the ListBox
        private void Read(string fileName)
        {
            try
            {
                listPeople.Items.Clear(); // Clear existing items

                if (File.Exists(fileName))
                {
                    foreach (var line in File.ReadAllLines(fileName))
                    {
                        listPeople.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Remove a person by ID
        private void buttonRM_Click(object sender, EventArgs e)
        {
            string id = ID_TB.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Inserisci ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var lines = File.ReadAllLines("persons.txt").ToList();
                bool removed = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    string[] parts = lines[i].Split(';');
                    if (parts[0] == id)
                    {
                        lines.RemoveAt(i);
                        removed = true;
                        break;
                    }
                }

                if (removed)
                {
                    File.WriteAllLines("persons.txt", lines); // Overwrite file with updated data
                    Read("persons.txt"); // Refresh ListBox
                    MessageBox.Show("Rimozione eseguita.", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Errore", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
