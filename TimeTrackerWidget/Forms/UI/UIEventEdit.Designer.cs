namespace TimeTrackerWidget.Forms.UI
{
    partial class UIEventEdit
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Wymagana metoda Wsparcia projektanta - nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIEventEdit));
            this.panelPaymoWidget = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPaymoProjects = new System.Windows.Forms.ComboBox();
            this.comboBoxPaymoTasks = new System.Windows.Forms.ComboBox();
            this.panelComment = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNowTo = new System.Windows.Forms.Button();
            this.buttonNowFrom = new System.Windows.Forms.Button();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorkerPaymoProjects = new System.ComponentModel.BackgroundWorker();
            this.panelPaymoWidget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelComment.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPaymoWidget
            // 
            this.panelPaymoWidget.BackColor = System.Drawing.Color.LawnGreen;
            this.panelPaymoWidget.Controls.Add(this.pictureBox1);
            this.panelPaymoWidget.Controls.Add(this.comboBoxPaymoProjects);
            this.panelPaymoWidget.Controls.Add(this.comboBoxPaymoTasks);
            this.panelPaymoWidget.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaymoWidget.Location = new System.Drawing.Point(0, 0);
            this.panelPaymoWidget.Name = "panelPaymoWidget";
            this.panelPaymoWidget.Size = new System.Drawing.Size(340, 36);
            this.panelPaymoWidget.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxPaymoProjects
            // 
            this.comboBoxPaymoProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymoProjects.Enabled = false;
            this.comboBoxPaymoProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPaymoProjects.Location = new System.Drawing.Point(41, 5);
            this.comboBoxPaymoProjects.Name = "comboBoxPaymoProjects";
            this.comboBoxPaymoProjects.Size = new System.Drawing.Size(120, 28);
            this.comboBoxPaymoProjects.TabIndex = 19;
            this.comboBoxPaymoProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymoProjects_SelectedIndexChanged);
            // 
            // comboBoxPaymoTasks
            // 
            this.comboBoxPaymoTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymoTasks.Enabled = false;
            this.comboBoxPaymoTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPaymoTasks.Location = new System.Drawing.Point(167, 5);
            this.comboBoxPaymoTasks.Name = "comboBoxPaymoTasks";
            this.comboBoxPaymoTasks.Size = new System.Drawing.Size(166, 28);
            this.comboBoxPaymoTasks.TabIndex = 18;
            this.comboBoxPaymoTasks.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymoTasks_SelectedIndexChanged);
            // 
            // panelComment
            // 
            this.panelComment.BackColor = System.Drawing.Color.White;
            this.panelComment.Controls.Add(this.label6);
            this.panelComment.Controls.Add(this.commentTextBox);
            this.panelComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelComment.Location = new System.Drawing.Point(0, 117);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(340, 233);
            this.panelComment.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(7, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Komentarz";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.commentTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.commentTextBox.Location = new System.Drawing.Point(10, 20);
            this.commentTextBox.MaxLength = 255;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.commentTextBox.Size = new System.Drawing.Size(321, 207);
            this.commentTextBox.TabIndex = 9;
            this.commentTextBox.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSave, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(340, 50);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Image = global::TimeTrackerWidget.Properties.Resources._1420417370_checkmark_rounded_32;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(170, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(170, 50);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonNowTo);
            this.panel1.Controls.Add(this.buttonNowFrom);
            this.panel1.Controls.Add(this.datePickerTo);
            this.panel1.Controls.Add(this.datePickerFrom);
            this.panel1.Controls.Add(this.timePickerTo);
            this.panel1.Controls.Add(this.timePickerFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 81);
            this.panel1.TabIndex = 14;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Image = global::TimeTrackerWidget.Properties.Resources._1420417374_bin_32;
            this.buttonDelete.Location = new System.Drawing.Point(275, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(65, 81);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNowTo
            // 
            this.buttonNowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNowTo.Location = new System.Drawing.Point(197, 47);
            this.buttonNowTo.Name = "buttonNowTo";
            this.buttonNowTo.Size = new System.Drawing.Size(75, 26);
            this.buttonNowTo.TabIndex = 5;
            this.buttonNowTo.Text = "Teraz";
            this.buttonNowTo.UseVisualStyleBackColor = true;
            this.buttonNowTo.Click += new System.EventHandler(this.buttonNowTo_Click);
            // 
            // buttonNowFrom
            // 
            this.buttonNowFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNowFrom.Location = new System.Drawing.Point(197, 6);
            this.buttonNowFrom.Name = "buttonNowFrom";
            this.buttonNowFrom.Size = new System.Drawing.Size(75, 26);
            this.buttonNowFrom.TabIndex = 4;
            this.buttonNowFrom.Text = "Teraz";
            this.buttonNowFrom.UseVisualStyleBackColor = true;
            this.buttonNowFrom.Click += new System.EventHandler(this.buttonNowFrom_Click);
            // 
            // datePickerTo
            // 
            this.datePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTo.Location = new System.Drawing.Point(10, 47);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(108, 26);
            this.datePickerTo.TabIndex = 3;
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFrom.Location = new System.Drawing.Point(10, 6);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(108, 26);
            this.datePickerFrom.TabIndex = 2;
            // 
            // timePickerTo
            // 
            this.timePickerTo.CustomFormat = "HH:mm";
            this.timePickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerTo.Location = new System.Drawing.Point(124, 47);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.ShowUpDown = true;
            this.timePickerTo.Size = new System.Drawing.Size(67, 26);
            this.timePickerTo.TabIndex = 1;
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.CustomFormat = "HH:mm";
            this.timePickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerFrom.Location = new System.Drawing.Point(124, 6);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.ShowUpDown = true;
            this.timePickerFrom.Size = new System.Drawing.Size(67, 26);
            this.timePickerFrom.TabIndex = 0;
            // 
            // backgroundWorkerPaymoProjects
            // 
            this.backgroundWorkerPaymoProjects.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorkerPaymoProjects.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // UIEventEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelPaymoWidget);
            this.Name = "UIEventEdit";
            this.Size = new System.Drawing.Size(340, 400);
            this.panelPaymoWidget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPaymoWidget;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxPaymoProjects;
        private System.Windows.Forms.ComboBox comboBoxPaymoTasks;
        private System.Windows.Forms.Panel panelComment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox commentTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.DateTimePicker timePickerTo;
        private System.Windows.Forms.DateTimePicker timePickerFrom;
        private System.Windows.Forms.Button buttonNowTo;
        private System.Windows.Forms.Button buttonNowFrom;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPaymoProjects;
    }
}
