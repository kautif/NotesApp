namespace NotesApp
{
    partial class NoteTaker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textboxTitle = new TextBox();
            textboxNotes = new TextBox();
            Title = new Label();
            Notes = new Label();
            previousNotes = new DataGridView();
            btnNewNote = new Button();
            btnSaveNote = new Button();
            btnLoadNote = new Button();
            btnDeleteNote = new Button();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // textboxTitle
            // 
            textboxTitle.Location = new Point(401, 18);
            textboxTitle.Name = "textboxTitle";
            textboxTitle.Size = new Size(387, 23);
            textboxTitle.TabIndex = 0;
            // 
            // textboxNotes
            // 
            textboxNotes.Location = new Point(401, 78);
            textboxNotes.Multiline = true;
            textboxNotes.Name = "textboxNotes";
            textboxNotes.Size = new Size(387, 347);
            textboxNotes.TabIndex = 1;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(401, 0);
            Title.Name = "Title";
            Title.Size = new Size(32, 15);
            Title.TabIndex = 2;
            Title.Text = "Title";
            Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Notes
            // 
            Notes.AutoSize = true;
            Notes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Notes.Location = new Point(401, 58);
            Notes.Name = "Notes";
            Notes.Size = new Size(40, 15);
            Notes.TabIndex = 3;
            Notes.Text = "Notes";
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.White;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(12, 18);
            previousNotes.Name = "previousNotes";
            previousNotes.RowTemplate.Height = 25;
            previousNotes.Size = new Size(366, 314);
            previousNotes.TabIndex = 4;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            previousNotes.Layout += previousNotes_Layout;
            // 
            // btnNewNote
            // 
            btnNewNote.BackColor = SystemColors.Control;
            btnNewNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewNote.Location = new Point(12, 347);
            btnNewNote.Name = "btnNewNote";
            btnNewNote.Size = new Size(185, 44);
            btnNewNote.TabIndex = 5;
            btnNewNote.Text = "New Note";
            btnNewNote.UseVisualStyleBackColor = false;
            btnNewNote.Click += btnNewNote_Click;
            // 
            // btnSaveNote
            // 
            btnSaveNote.BackColor = SystemColors.Control;
            btnSaveNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveNote.Location = new Point(203, 347);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(175, 44);
            btnSaveNote.TabIndex = 6;
            btnSaveNote.Text = "Save";
            btnSaveNote.UseVisualStyleBackColor = false;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // btnLoadNote
            // 
            btnLoadNote.BackColor = SystemColors.Control;
            btnLoadNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadNote.Location = new Point(12, 397);
            btnLoadNote.Name = "btnLoadNote";
            btnLoadNote.Size = new Size(185, 44);
            btnLoadNote.TabIndex = 7;
            btnLoadNote.Text = "Load";
            btnLoadNote.UseVisualStyleBackColor = false;
            btnLoadNote.Click += btnLoadNote_Click;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.BackColor = SystemColors.Control;
            btnDeleteNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteNote.Location = new Point(203, 397);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(175, 44);
            btnDeleteNote.TabIndex = 8;
            btnDeleteNote.Text = "Delete";
            btnDeleteNote.UseVisualStyleBackColor = false;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // NoteTaker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteNote);
            Controls.Add(btnLoadNote);
            Controls.Add(btnSaveNote);
            Controls.Add(btnNewNote);
            Controls.Add(previousNotes);
            Controls.Add(Notes);
            Controls.Add(Title);
            Controls.Add(textboxNotes);
            Controls.Add(textboxTitle);
            Name = "NoteTaker";
            Text = "NoteTaker";
            Load += NoteTaker_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxTitle;
        private TextBox textboxNotes;
        private Label Title;
        private Label Notes;
        private DataGridView previousNotes;
        private Button btnNewNote;
        private Button btnSaveNote;
        private Button btnLoadNote;
        private Button btnDeleteNote;
    }
}