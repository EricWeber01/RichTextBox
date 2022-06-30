namespace RichTextBox
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.считатьСФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатьВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копирлватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль1ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.стильШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стильToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.стильШрифтаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стильФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.стиль1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.стильToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.считатьСФайлаToolStripMenuItem,
            this.записатьВФайлToolStripMenuItem,
            this.toolStripMenuItem1,
            this.новоеОкноToolStripMenuItem,
            this.закрытьОкноToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // считатьСФайлаToolStripMenuItem
            // 
            this.считатьСФайлаToolStripMenuItem.Name = "считатьСФайлаToolStripMenuItem";
            this.считатьСФайлаToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.считатьСФайлаToolStripMenuItem.Text = "Считать с файла";
            this.считатьСФайлаToolStripMenuItem.Click += new System.EventHandler(this.Open);
            // 
            // записатьВФайлToolStripMenuItem
            // 
            this.записатьВФайлToolStripMenuItem.Name = "записатьВФайлToolStripMenuItem";
            this.записатьВФайлToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.записатьВФайлToolStripMenuItem.Text = "Записать в файл";
            this.записатьВФайлToolStripMenuItem.Click += new System.EventHandler(this.Seiv);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // новоеОкноToolStripMenuItem
            // 
            this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
            this.новоеОкноToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.новоеОкноToolStripMenuItem.Text = "Новое окно";
            // 
            // закрытьОкноToolStripMenuItem
            // 
            this.закрытьОкноToolStripMenuItem.Name = "закрытьОкноToolStripMenuItem";
            this.закрытьОкноToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.закрытьОкноToolStripMenuItem.Text = "Закрыть окно";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копирлватьToolStripMenuItem,
            this.вставитьToolStripMenuItem1,
            this.вырезатьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копирлватьToolStripMenuItem
            // 
            this.копирлватьToolStripMenuItem.Name = "копирлватьToolStripMenuItem";
            this.копирлватьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.копирлватьToolStripMenuItem.Text = "Копирлвать";
            this.копирлватьToolStripMenuItem.Click += new System.EventHandler(this.Copi);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem1.Text = "Вставить";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.Vstav);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.Cat);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.SelectAll);
            // 
            // стильToolStripMenuItem
            // 
            this.стильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стиль1ToolStripMenuItem4,
            this.стиль2ToolStripMenuItem1,
            this.стиль3ToolStripMenuItem1});
            this.стильToolStripMenuItem.Name = "стильToolStripMenuItem";
            this.стильToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.стильToolStripMenuItem.Text = "Стиль";
            // 
            // стиль1ToolStripMenuItem4
            // 
            this.стиль1ToolStripMenuItem4.Name = "стиль1ToolStripMenuItem4";
            this.стиль1ToolStripMenuItem4.Size = new System.Drawing.Size(129, 22);
            this.стиль1ToolStripMenuItem4.Text = "Стиль №1";
            this.стиль1ToolStripMenuItem4.Click += new System.EventHandler(this.stil1);
            // 
            // стиль2ToolStripMenuItem1
            // 
            this.стиль2ToolStripMenuItem1.Name = "стиль2ToolStripMenuItem1";
            this.стиль2ToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.стиль2ToolStripMenuItem1.Text = "Стиль №2";
            this.стиль2ToolStripMenuItem1.Click += new System.EventHandler(this.stil2);
            // 
            // стиль3ToolStripMenuItem1
            // 
            this.стиль3ToolStripMenuItem1.Name = "стиль3ToolStripMenuItem1";
            this.стиль3ToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.стиль3ToolStripMenuItem1.Text = "Стиль №3";
            this.стиль3ToolStripMenuItem1.Click += new System.EventHandler(this.stil3);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.вставитьToolStripMenuItem,
            this.копироватьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            this.contextMenuStrip1.Text = "cont";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "выделить все";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SelectAll);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem3.Text = "вырезать";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Cat);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.вставитьToolStripMenuItem.Text = "вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.Vstav);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.копироватьToolStripMenuItem.Text = "копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.Copi);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(538, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WINDOW_2.Properties.Resources.ec06293b_e995_4015_ba13_3f2916bea285;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.Open);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::WINDOW_2.Properties.Resources.disketa_2;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.Seiv);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::WINDOW_2.Properties.Resources._1455554314_line_15_icon_icons_com_53330;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.Copi);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::WINDOW_2.Properties.Resources.Paste_icon;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.Cat);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::WINDOW_2.Properties.Resources.Turn_Curved_Arrow_PNG_High_Quality_Image;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.Vstav);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стильШрифтаToolStripMenuItem,
            this.стильToolStripMenuItem1,
            this.стильШрифтаToolStripMenuItem1,
            this.стильФонаToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::WINDOW_2.Properties.Resources.letter_a_PNG6;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // стильШрифтаToolStripMenuItem
            // 
            this.стильШрифтаToolStripMenuItem.Image = global::WINDOW_2.Properties.Resources.letter_a_PNG6;
            this.стильШрифтаToolStripMenuItem.Name = "стильШрифтаToolStripMenuItem";
            this.стильШрифтаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.стильШрифтаToolStripMenuItem.Text = "Шрифт";
            this.стильШрифтаToolStripMenuItem.Click += new System.EventHandler(this.стильШрифтаToolStripMenuItem_Click);
            // 
            // стильToolStripMenuItem1
            // 
            this.стильToolStripMenuItem1.Image = global::WINDOW_2.Properties.Resources._200px_Rgb_colorwheel_svg;
            this.стильToolStripMenuItem1.Name = "стильToolStripMenuItem1";
            this.стильToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.стильToolStripMenuItem1.Text = "Цвет";
            this.стильToolStripMenuItem1.Click += new System.EventHandler(this.стильToolStripMenuItem1_Click);
            // 
            // стильШрифтаToolStripMenuItem1
            // 
            this.стильШрифтаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стиль1ToolStripMenuItem3,
            this.стиль2ToolStripMenuItem,
            this.стиль3ToolStripMenuItem});
            this.стильШрифтаToolStripMenuItem1.Name = "стильШрифтаToolStripMenuItem1";
            this.стильШрифтаToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.стильШрифтаToolStripMenuItem1.Text = "Стиль шрифта";
            // 
            // стиль1ToolStripMenuItem3
            // 
            this.стиль1ToolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стиль1ToolStripMenuItem3.Name = "стиль1ToolStripMenuItem3";
            this.стиль1ToolStripMenuItem3.Size = new System.Drawing.Size(180, 30);
            this.стиль1ToolStripMenuItem3.Text = "Стиль №1";
            this.стиль1ToolStripMenuItem3.Click += new System.EventHandler(this.stilsh1);
            // 
            // стиль2ToolStripMenuItem
            // 
            this.стиль2ToolStripMenuItem.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.стиль2ToolStripMenuItem.Name = "стиль2ToolStripMenuItem";
            this.стиль2ToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.стиль2ToolStripMenuItem.Text = "Стиль №2";
            this.стиль2ToolStripMenuItem.Click += new System.EventHandler(this.stilsh2);
            // 
            // стиль3ToolStripMenuItem
            // 
            this.стиль3ToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стиль3ToolStripMenuItem.Name = "стиль3ToolStripMenuItem";
            this.стиль3ToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.стиль3ToolStripMenuItem.Text = "Стиль №3";
            this.стиль3ToolStripMenuItem.Click += new System.EventHandler(this.stilsh3);
            // 
            // стильФонаToolStripMenuItem
            // 
            this.стильФонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стиль1ToolStripMenuItem,
            this.стиль1ToolStripMenuItem1,
            this.стиль1ToolStripMenuItem2});
            this.стильФонаToolStripMenuItem.Name = "стильФонаToolStripMenuItem";
            this.стильФонаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.стильФонаToolStripMenuItem.Text = "Стиль окна";
            // 
            // стиль1ToolStripMenuItem
            // 
            this.стиль1ToolStripMenuItem.Name = "стиль1ToolStripMenuItem";
            this.стиль1ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.стиль1ToolStripMenuItem.Text = "Стиль №1";
            this.стиль1ToolStripMenuItem.Click += new System.EventHandler(this.stil1);
            // 
            // стиль1ToolStripMenuItem1
            // 
            this.стиль1ToolStripMenuItem1.Name = "стиль1ToolStripMenuItem1";
            this.стиль1ToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.стиль1ToolStripMenuItem1.Text = "Стиль №2";
            this.стиль1ToolStripMenuItem1.Click += new System.EventHandler(this.stil2);
            // 
            // стиль1ToolStripMenuItem2
            // 
            this.стиль1ToolStripMenuItem2.Name = "стиль1ToolStripMenuItem2";
            this.стиль1ToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.стиль1ToolStripMenuItem2.Text = "Стиль №3";
            this.стиль1ToolStripMenuItem2.Click += new System.EventHandler(this.stil3);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(538, 315);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(538, 364);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Textovic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стильToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem стильШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стильToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стильШрифтаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стильФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стиль1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стиль1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стиль1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem считатьСФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатьВФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копирлватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стиль1ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem стиль2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стиль3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стиль1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem стиль2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стиль3ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

