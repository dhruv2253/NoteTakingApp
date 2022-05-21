namespace NoteTakingApp
{
    partial class Notetaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.loadButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(375, 24);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(413, 20);
            this.titleBox.TabIndex = 0;
            this.titleBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(375, 75);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(413, 363);
            this.noteBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // previousNotes
            // 
            this.previousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousNotes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(12, 12);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.Size = new System.Drawing.Size(357, 331);
            this.previousNotes.TabIndex = 4;
            this.previousNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.previousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellDoubleClick);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(12, 349);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(167, 33);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(202, 349);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(167, 33);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(202, 388);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(167, 33);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.newNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNoteButton.Location = new System.Drawing.Point(12, 388);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(167, 33);
            this.newNoteButton.TabIndex = 8;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = false;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // Notetaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "Notetaker";
            this.Text = "Notetaker";
            this.Load += new System.EventHandler(this.Notetaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView previousNotes;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newNoteButton;
    }
}

