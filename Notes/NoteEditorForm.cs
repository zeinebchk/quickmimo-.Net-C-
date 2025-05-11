using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using quickmimo.Entities;
using quickmimo.Repositories;

namespace quickmimo.Notes
{
    public partial class NoteEditorForm : Form
    {
        private readonly CategoryRepository _categoryRepo;
        private readonly Note _note;
        public Note Note => _note;

        private TextBox txtTitle;
        private RichTextBox txtContent;
        private ComboBox cmbCategory;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider;

        public NoteEditorForm(Note note, CategoryRepository categoryRepo)
        {
            _note = note ?? new Note();
            _categoryRepo = categoryRepo ?? throw new ArgumentNullException(nameof(categoryRepo));

            InitializeControls();
            SetupUI();
            SetupEvents();
            LoadCategories();
        }

        private void InitializeControls()
        {
            txtTitle = new TextBox { Location = new Point(20, 20), Size = new Size(360, 30) };
            // Label pour le titre
            Label lblTitle = new Label { Text = "Titre :", Location = new Point(20, 0), AutoSize = true };
            txtTitle = new TextBox { Location = new Point(20, 20), Size = new Size(360, 30) };
            txtTitle.PlaceholderText = "Titre";

            // Label pour le contenu
            Label lblContent = new Label { Text = "Contenu :", Location = new Point(20, 60), AutoSize = true };
            txtContent = new RichTextBox { Location = new Point(20, 80), Size = new Size(360, 180) };

            // Label pour la catégorie
            Label lblCategory = new Label { Text = "Catégorie :", Location = new Point(20, 265), AutoSize = true };
            cmbCategory = new ComboBox
            {
                Location = new Point(20, 285),
                Size = new Size(200, 30),
                DropDownStyle = ComboBoxStyle.DropDown // rend le champ éditable
            };

            // Boutons
            btnSave = new Button { Text = "Enregistrer", DialogResult = DialogResult.OK, Size = new Size(100, 35), Location = new Point(200, 330) };
            btnCancel = new Button { Text = "Annuler", DialogResult = DialogResult.Cancel, Size = new Size(100, 35), Location = new Point(300, 330) };

            // Erreur provider
            errorProvider = new ErrorProvider();

            // Ajout des contrôles à la forme
            Controls.AddRange(new Control[]
            {
        lblTitle, txtTitle,
        lblContent, txtContent,
        lblCategory, cmbCategory,
        btnSave, btnCancel
            });
        }

        private void SetupUI()
        {
            Text = "Éditeur de Note";
            ClientSize = new Size(410, 360);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;

            txtTitle.Text = _note.Title ?? "";
            txtContent.Text = _note.Content ?? "";
        }

        private void SetupEvents()
        {
            btnSave.Click += async (s, e) =>
            {
                if (ValidateChildren())
                {
                    // Mettre à jour les données de la note
                    _note.Title = txtTitle.Text.Trim();
                    _note.Content = txtContent.Text.Trim();

                    string enteredCategoryName = cmbCategory.Text.Trim();

                    if (!string.IsNullOrEmpty(enteredCategoryName))
                    {
                        // Vérifier si la catégorie existe déjà
                        var existingCategory = await _categoryRepo.GetByNameAsync(enteredCategoryName);

                        if (existingCategory != null)
                        {
                            // La catégorie existe déjà, on associe l'ID de la catégorie existante
                            _note.CategoryId = existingCategory.Id;
                        }
                        else
                        {
                            // Créer une nouvelle catégorie
                            var newCategory = new Category { Nom = enteredCategoryName };

                            // Ajouter la catégorie au DbContext
                            await _categoryRepo.AddAsync(newCategory);

                            // Sauvegarder les changements dans la base de données
                            await _categoryRepo.SaveAsync(); // Assurez-vous que SaveAsync() est bien défini dans votre repository

                            // Associer la nouvelle catégorie à la note
                            _note.CategoryId = newCategory.Id;
                        }
                    }
                    else
                    {
                        // Si aucune catégorie n'est sélectionnée, ne pas l'associer à la note
                        _note.CategoryId = null;
                    }

                    // Sauvegarder la note
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            };

            txtTitle.Validating += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    errorProvider.SetError(txtTitle, "Le titre est requis.");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(txtTitle, "");
                }
            };
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // NoteEditorForm
            // 
            ClientSize = new Size(752, 389);
            Name = "NoteEditorForm";
            Load += NoteEditorForm_Load;
            ResumeLayout(false);
        }

        private void LoadCategories()
        {
            var categories = _categoryRepo.GetAllAsync().GetAwaiter().GetResult();
            cmbCategory.Items.Clear();

            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category);
            }

            cmbCategory.DisplayMember = nameof(Category.Nom);

            if (_note.CategoryId.HasValue)
            {
                var existing = categories.FirstOrDefault(c => c.Id == _note.CategoryId.Value);
                cmbCategory.SelectedItem = existing;
            }
        }

        private void NoteEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
