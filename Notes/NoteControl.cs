using System;
using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using quickmimo.Entities;


namespace quickmimo.Notes
{
    public partial class NoteControl : Panel
    {
        public event EventHandler EditClicked;
        public event EventHandler DeleteClicked;

        public Note Note { get; }

        public NoteControl(Note note, Color pastelColor)
        {
            Note = note ?? throw new ArgumentNullException(nameof(note));
            BackColor = pastelColor;

            DoubleBuffered = true;
            Cursor = Cursors.Hand;
            Padding = new Padding(12);
            Margin = new Padding(25);
            MaximumSize = new Size(330, 300);
            BorderStyle = BorderStyle.None;

            InitializeUI();
        }

        private void InitializeUI()
        {
            // Épingle (icône en haut à droite)
            var pinIcon = new Label
            {
                Text = "📌",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(Width - 30, 10),
                BackColor = Color.Transparent,
                ForeColor = Color.Orange // Changer la couleur de l'épingle ici
            };
            Controls.Add(pinIcon);

            // Titre
            var lblTitle = new Label
            {
                Text = Note.Title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                Dock = DockStyle.Top,
                Height = 35,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(6, 0, 0, 0)
            };

            // Contenu élargi
            var lblContent = new Label
            {
                Text = Note.Content.Length > 300 ? Note.Content.Substring(0, 300) + "..." : Note.Content,
                Font = new Font("Segoe UI", 10),
                Dock = DockStyle.Fill,
                AutoSize = false,
                ForeColor = Color.DimGray,
                Padding = new Padding(6),
                MaximumSize = new Size(240, 200)
            };

            // Panneau boutons
            var btnPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Dock = DockStyle.Bottom,
                Height = 55,
                Padding = new Padding(6),
                BackColor = Color.Transparent,
                WrapContents = false
            };

            var btnEdit = CreateFancyButton("✏️ ", Color.FromArgb(230, 245, 255), Color.FromArgb(200, 230, 250));
            btnEdit.Click += (s, e) => EditClicked?.Invoke(this, EventArgs.Empty);

            var btnDelete = CreateFancyButton("🗑️ ", Color.FromArgb(255, 230, 230), Color.FromArgb(250, 200, 200));
            btnDelete.Click += (s, e) => DeleteClicked?.Invoke(this, EventArgs.Empty);

            btnPanel.Controls.Add(btnEdit);
            btnPanel.Controls.Add(btnDelete);

            Controls.Add(lblContent);
            Controls.Add(btnPanel);
            Controls.Add(lblTitle);
        }

        private Button CreateFancyButton(string text, Color baseColor, Color hoverColor)
        {
            var btn = new Button
            {
                Text = text,
                AutoSize = true,
                FlatStyle = FlatStyle.Flat,
                BackColor = baseColor,
                ForeColor = Color.Black,
                Padding = new Padding(12, 6, 12, 6),
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                Margin = new Padding(6),
                Cursor = Cursors.Hand
            };

            btn.FlatAppearance.BorderSize = 0;

            btn.MouseEnter += (s, e) => btn.BackColor = hoverColor;
            btn.MouseLeave += (s, e) => btn.BackColor = baseColor;

            btn.Region = Region.FromHrgn(
                NativeMethods.CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 12, 12));

            btn.Resize += (s, e) =>
            {
                btn.Region = Region.FromHrgn(
                    NativeMethods.CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 12, 12));
            };

            return btn;
        }

        private static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            public static extern nint CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
                int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        }

    }
}
