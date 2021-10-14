
namespace Coursework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.забронироватьБилетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.УзнатьФильмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьБроньToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторМестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМестоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьМестоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonAddPlace = new System.Windows.Forms.Button();
            this.ButtonDelPlace = new System.Windows.Forms.Button();
            this.labelOutputFilm = new System.Windows.Forms.Label();
            this.labelFilms = new System.Windows.Forms.Label();
            this.buttonDeleteReservation = new System.Windows.Forms.Button();
            this.textBoxFilms = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxHallRes = new System.Windows.Forms.ComboBox();
            this.comboBoxHallPD = new System.Windows.Forms.ComboBox();
            this.labelHall = new System.Windows.Forms.Label();
            this.textBoxHall = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxRowRes = new System.Windows.Forms.ComboBox();
            this.comboBoxRowPD = new System.Windows.Forms.ComboBox();
            this.labelRow = new System.Windows.Forms.Label();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxPlaceRes = new System.Windows.Forms.ComboBox();
            this.comboBoxPlacePD = new System.Windows.Forms.ComboBox();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.забронироватьБилетToolStripMenuItem,
            this.УзнатьФильмToolStripMenuItem,
            this.удалитьБроньToolStripMenuItem1,
            this.редакторМестToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // забронироватьБилетToolStripMenuItem
            // 
            this.забронироватьБилетToolStripMenuItem.Name = "забронироватьБилетToolStripMenuItem";
            resources.ApplyResources(this.забронироватьБилетToolStripMenuItem, "забронироватьБилетToolStripMenuItem");
            this.забронироватьБилетToolStripMenuItem.Click += new System.EventHandler(this.забронироватьБилетToolStripMenuItem_Click);
            // 
            // УзнатьФильмToolStripMenuItem
            // 
            this.УзнатьФильмToolStripMenuItem.Name = "УзнатьФильмToolStripMenuItem";
            resources.ApplyResources(this.УзнатьФильмToolStripMenuItem, "УзнатьФильмToolStripMenuItem");
            this.УзнатьФильмToolStripMenuItem.Click += new System.EventHandler(this.УзнатьБроньНаФильмToolStripMenuItem_Click);
            // 
            // удалитьБроньToolStripMenuItem1
            // 
            this.удалитьБроньToolStripMenuItem1.Name = "удалитьБроньToolStripMenuItem1";
            resources.ApplyResources(this.удалитьБроньToolStripMenuItem1, "удалитьБроньToolStripMenuItem1");
            this.удалитьБроньToolStripMenuItem1.Click += new System.EventHandler(this.удалитьБроньToolStripMenuItem1_Click);
            // 
            // редакторМестToolStripMenuItem
            // 
            this.редакторМестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьМестоToolStripMenuItem,
            this.удалитьМестоToolStripMenuItem});
            this.редакторМестToolStripMenuItem.Name = "редакторМестToolStripMenuItem";
            resources.ApplyResources(this.редакторМестToolStripMenuItem, "редакторМестToolStripMenuItem");
            // 
            // добавитьМестоToolStripMenuItem
            // 
            this.добавитьМестоToolStripMenuItem.Name = "добавитьМестоToolStripMenuItem";
            resources.ApplyResources(this.добавитьМестоToolStripMenuItem, "добавитьМестоToolStripMenuItem");
            this.добавитьМестоToolStripMenuItem.Click += new System.EventHandler(this.добавитьМестоToolStripMenuItem_Click);
            // 
            // удалитьМестоToolStripMenuItem
            // 
            this.удалитьМестоToolStripMenuItem.Name = "удалитьМестоToolStripMenuItem";
            resources.ApplyResources(this.удалитьМестоToolStripMenuItem, "удалитьМестоToolStripMenuItem");
            this.удалитьМестоToolStripMenuItem.Click += new System.EventHandler(this.удалитьМестоToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            resources.ApplyResources(this.сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ButtonAddPlace);
            this.panel1.Controls.Add(this.ButtonDelPlace);
            this.panel1.Controls.Add(this.labelOutputFilm);
            this.panel1.Controls.Add(this.labelFilms);
            this.panel1.Controls.Add(this.buttonDeleteReservation);
            this.panel1.Controls.Add(this.textBoxFilms);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ButtonAddPlace
            // 
            this.ButtonAddPlace.BackColor = System.Drawing.Color.PaleGreen;
            resources.ApplyResources(this.ButtonAddPlace, "ButtonAddPlace");
            this.ButtonAddPlace.Name = "ButtonAddPlace";
            this.ButtonAddPlace.UseVisualStyleBackColor = false;
            this.ButtonAddPlace.Click += new System.EventHandler(this.ButtonAddPlace_Click);
            // 
            // ButtonDelPlace
            // 
            this.ButtonDelPlace.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.ButtonDelPlace, "ButtonDelPlace");
            this.ButtonDelPlace.Name = "ButtonDelPlace";
            this.ButtonDelPlace.UseVisualStyleBackColor = false;
            this.ButtonDelPlace.Click += new System.EventHandler(this.ButtonDelPlace_Click);
            // 
            // labelOutputFilm
            // 
            resources.ApplyResources(this.labelOutputFilm, "labelOutputFilm");
            this.labelOutputFilm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOutputFilm.Name = "labelOutputFilm";
            // 
            // labelFilms
            // 
            resources.ApplyResources(this.labelFilms, "labelFilms");
            this.labelFilms.Name = "labelFilms";
            // 
            // buttonDeleteReservation
            // 
            this.buttonDeleteReservation.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.buttonDeleteReservation, "buttonDeleteReservation");
            this.buttonDeleteReservation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDeleteReservation.Name = "buttonDeleteReservation";
            this.buttonDeleteReservation.UseVisualStyleBackColor = false;
            this.buttonDeleteReservation.Click += new System.EventHandler(this.buttonDeleteReservation_Click);
            // 
            // textBoxFilms
            // 
            resources.ApplyResources(this.textBoxFilms, "textBoxFilms");
            this.textBoxFilms.Name = "textBoxFilms";
            this.textBoxFilms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFilms_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxHallRes);
            this.panel2.Controls.Add(this.comboBoxHallPD);
            this.panel2.Controls.Add(this.labelHall);
            this.panel2.Controls.Add(this.textBoxHall);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // comboBoxHallRes
            // 
            this.comboBoxHallRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxHallRes, "comboBoxHallRes");
            this.comboBoxHallRes.FormattingEnabled = true;
            this.comboBoxHallRes.Name = "comboBoxHallRes";
            // 
            // comboBoxHallPD
            // 
            this.comboBoxHallPD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxHallPD, "comboBoxHallPD");
            this.comboBoxHallPD.FormattingEnabled = true;
            this.comboBoxHallPD.Name = "comboBoxHallPD";
            // 
            // labelHall
            // 
            resources.ApplyResources(this.labelHall, "labelHall");
            this.labelHall.Name = "labelHall";
            // 
            // textBoxHall
            // 
            resources.ApplyResources(this.textBoxHall, "textBoxHall");
            this.textBoxHall.Name = "textBoxHall";
            this.textBoxHall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHall_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBoxRowRes);
            this.panel3.Controls.Add(this.comboBoxRowPD);
            this.panel3.Controls.Add(this.labelRow);
            this.panel3.Controls.Add(this.textBoxRow);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // comboBoxRowRes
            // 
            this.comboBoxRowRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxRowRes, "comboBoxRowRes");
            this.comboBoxRowRes.FormattingEnabled = true;
            this.comboBoxRowRes.Name = "comboBoxRowRes";
            // 
            // comboBoxRowPD
            // 
            this.comboBoxRowPD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxRowPD, "comboBoxRowPD");
            this.comboBoxRowPD.FormattingEnabled = true;
            this.comboBoxRowPD.Name = "comboBoxRowPD";
            // 
            // labelRow
            // 
            resources.ApplyResources(this.labelRow, "labelRow");
            this.labelRow.Name = "labelRow";
            // 
            // textBoxRow
            // 
            resources.ApplyResources(this.textBoxRow, "textBoxRow");
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRow_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.comboBoxPlaceRes);
            this.panel4.Controls.Add(this.comboBoxPlacePD);
            this.panel4.Controls.Add(this.buttonReservation);
            this.panel4.Controls.Add(this.buttonSearch);
            this.panel4.Controls.Add(this.labelPlace);
            this.panel4.Controls.Add(this.textBoxPlace);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // comboBoxPlaceRes
            // 
            this.comboBoxPlaceRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxPlaceRes, "comboBoxPlaceRes");
            this.comboBoxPlaceRes.FormattingEnabled = true;
            this.comboBoxPlaceRes.Name = "comboBoxPlaceRes";
            // 
            // comboBoxPlacePD
            // 
            this.comboBoxPlacePD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxPlacePD, "comboBoxPlacePD");
            this.comboBoxPlacePD.FormattingEnabled = true;
            this.comboBoxPlacePD.Name = "comboBoxPlacePD";
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.buttonReservation, "buttonReservation");
            this.buttonReservation.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Turquoise;
            resources.ApplyResources(this.buttonSearch, "buttonSearch");
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelPlace
            // 
            resources.ApplyResources(this.labelPlace, "labelPlace");
            this.labelPlace.Name = "labelPlace";
            // 
            // textBoxPlace
            // 
            resources.ApplyResources(this.textBoxPlace, "textBoxPlace");
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPlace_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem забронироватьБилетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem УзнатьФильмToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFilms;
        private System.Windows.Forms.Label labelFilms;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelHall;
        private System.Windows.Forms.TextBox textBoxHall;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelRow;
        private System.Windows.Forms.TextBox textBoxRow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.ToolStripMenuItem удалитьБроньToolStripMenuItem1;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Label labelOutputFilm;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDeleteReservation;
        private System.Windows.Forms.ComboBox comboBoxHallPD;
        private System.Windows.Forms.ComboBox comboBoxRowPD;
        private System.Windows.Forms.ComboBox comboBoxPlacePD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редакторМестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМестоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьМестоToolStripMenuItem;
        private System.Windows.Forms.Button ButtonDelPlace;
        private System.Windows.Forms.Button ButtonAddPlace;
        private System.Windows.Forms.ComboBox comboBoxHallRes;
        private System.Windows.Forms.ComboBox comboBoxRowRes;
        private System.Windows.Forms.ComboBox comboBoxPlaceRes;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}

