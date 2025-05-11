using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using quickmimo;
using quickmimo.Calendrier;
using quickmimo.Entities;
using quickmimo.Notes;
using quickmimo.Repositories;
using quickmimo.statistique;

namespace stickeynotes
{
    public partial class NotesForm : Form
    {
        private readonly NoteRepository _noteRepo = new NoteRepository(Program.DbContext);
        private readonly CategoryRepository _categoryRepo = new CategoryRepository(Program.DbContext);

        public NotesForm()
        {

            InitializeComponent();
            SetupEvents();
            LoadNotes();
        }

        private void SetupEvents()
        {
            btnNewNote.Click += BtnNewNote_Click;
            //this.Resize += NotesForm_Resize;
        }

        private void LoadNotes()
        {
            flowLayoutNotes.Controls.Clear();
            var notes = _noteRepo.GetAllAsync().GetAwaiter().GetResult();
            var rand = new Random();
            Size noteSize = new Size(280, 280);

            foreach (var note in notes)
            {
                var pastelColor = Color.FromArgb(
                    rand.Next(180, 230),
                    rand.Next(180, 240),
                    rand.Next(180, 230));

                var noteControl = new NoteControl(note, pastelColor)
                {
                    Margin = new Padding(20),
                    Size = noteSize
                };

                noteControl.EditClicked += (s, e) => EditNote(note);
                noteControl.DeleteClicked += (s, e) => DeleteNote(note.Id);

                flowLayoutNotes.Controls.Add(noteControl);
            }
        }

        private void BtnNewNote_Click(object sender, EventArgs e)
        {
            using var editor = new NoteEditorForm(new Note { DateCreated = DateTime.Now }, _categoryRepo);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                _noteRepo.AddAsync(editor.Note).GetAwaiter().GetResult();
                LoadNotes();
            }
        }

        private void EditNote(Note note)
        {
            using var editor = new NoteEditorForm(note, _categoryRepo);
            if (editor.ShowDialog() == DialogResult.OK)
            {
                _noteRepo.UpdateAsync(editor.Note).GetAwaiter().GetResult();
                LoadNotes();
            }
        }

        private void DeleteNote(int id)
        {
            if (MessageBox.Show("Confirmer la suppression ?", "Suppression de note", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _noteRepo.DeleteAsync(id).GetAwaiter().GetResult();
                LoadNotes();
            }
        }

        private void BtnNotes_Click(object sender, EventArgs e)
        {
            var next = new NotesForm();
            next.Show();
            Hide();
        }

        private void BtnTasks_Click(object sender, EventArgs e)
        {
            var taches = new quickmimo.listeTaches();
            taches.Show();
            Hide();
        }

        //private void NotesForm_Resize(object sender, EventArgs e) => UpdateLayout();

        //private void UpdateLayout()
        //{
        //    flowLayoutNotes.SuspendLayout();

        //    int topMargin = 10;
        //    int sideMargin = 85;
        //    int availableWidth = ClientSize.Width - sidebarPanel.Width - sideMargin * 2;
        //    int availableHeight = ClientSize.Height - headerPanel.Height - topMargin * 2;

        //    flowLayoutNotes.Size = new Size(availableWidth, availableHeight);
        //    flowLayoutNotes.Location = new Point(sidebarPanel.Width + sideMargin, headerPanel.Height + topMargin);

        //    flowLayoutNotes.Padding = new Padding(10);
        //    flowLayoutNotes.Margin = new Padding(0);
        //    flowLayoutNotes.WrapContents = true;
        //    flowLayoutNotes.FlowDirection = FlowDirection.LeftToRight;
        //    flowLayoutNotes.AutoScroll = true;
        //    flowLayoutNotes.BackColor = Color.FromArgb(240, 240, 240);

        //    flowLayoutNotes.ResumeLayout();
        //}

        // Handlers vides pour le designer
        private void sidebarPanel_Paint(object sender, PaintEventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void flowLayoutNotes_Paint(object sender, PaintEventArgs e) { }
        private void NotesForm_Load(object sender, EventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            listeTaches note = new listeTaches();
            note.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calendar note = new Calendar();
            note.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Statistic note = new Statistic();
            note.Show();
            this.Close();
        }
    }
}
