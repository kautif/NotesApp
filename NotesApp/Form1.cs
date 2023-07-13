using System.Data;
using System.Net.Http.Headers;

namespace NotesApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Notes");

            previousNotes.DataSource = notes;
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            textboxTitle.Text = "";
            textboxNotes.Text = "";
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = textboxTitle.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Notes"] = textboxNotes.Text;
            }
            else
            {
                notes.Rows.Add(textboxTitle.Text, textboxNotes.Text);
            }

            textboxTitle.Text = "";
            textboxNotes.Text = "";
            editing = false;
        }

        private void btnLoadNote_Click(object sender, EventArgs e)
        {
            textboxTitle.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            textboxNotes.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) { Console.WriteLine("not a valid note"); }
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxTitle.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            textboxNotes.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void previousNotes_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}