
namespace PenisLerningWinforms
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
            this.LogConsole = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableGridView = new System.Windows.Forms.DataGridView();
            this.MainTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.TablePage = new System.Windows.Forms.TabPage();
            this.PoopingMode = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneImageButton1 = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.TableSelectComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.Hui = new System.Windows.Forms.TabPage();
            this.ScalarValueExecuteButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ScalarColumnComboxBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.ScalarCommandComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Insert = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneTextBox2 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.poopingPage = new System.Windows.Forms.TabPage();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            this.MainTabControl1.SuspendLayout();
            this.TablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.Hui.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.poopingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogConsole
            // 
            this.LogConsole.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LogConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogConsole.Location = new System.Drawing.Point(0, 2);
            this.LogConsole.Margin = new System.Windows.Forms.Padding(2);
            this.LogConsole.Name = "LogConsole";
            this.LogConsole.Size = new System.Drawing.Size(1090, 675);
            this.LogConsole.TabIndex = 1;
            this.LogConsole.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // TableGridView
            // 
            this.TableGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGridView.Location = new System.Drawing.Point(6, 41);
            this.TableGridView.Margin = new System.Windows.Forms.Padding(2);
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.RowHeadersWidth = 51;
            this.TableGridView.RowTemplate.Height = 24;
            this.TableGridView.Size = new System.Drawing.Size(1064, 624);
            this.TableGridView.TabIndex = 0;
            this.TableGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.TableGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // MainTabControl1
            // 
            this.MainTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MainTabControl1.Controls.Add(this.TablePage);
            this.MainTabControl1.Controls.Add(this.Hui);
            this.MainTabControl1.Controls.Add(this.tabPage2);
            this.MainTabControl1.Controls.Add(this.tabPage1);
            this.MainTabControl1.Controls.Add(this.poopingPage);
            this.MainTabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.MainTabControl1.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl1.Name = "MainTabControl1";
            this.MainTabControl1.SelectedIndex = 0;
            this.MainTabControl1.Size = new System.Drawing.Size(1280, 720);
            this.MainTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.MainTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.MainTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.MainTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MainTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.MainTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MainTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.MainTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.MainTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.MainTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.MainTabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.MainTabControl1.TabIndex = 5;
            this.MainTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // TablePage
            // 
            this.TablePage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TablePage.Controls.Add(this.PoopingMode);
            this.TablePage.Controls.Add(this.siticonePictureBox1);
            this.TablePage.Controls.Add(this.siticoneImageButton1);
            this.TablePage.Controls.Add(this.TableGridView);
            this.TablePage.Controls.Add(this.TableSelectComboBox);
            this.TablePage.Location = new System.Drawing.Point(184, 4);
            this.TablePage.Name = "TablePage";
            this.TablePage.Padding = new System.Windows.Forms.Padding(3);
            this.TablePage.Size = new System.Drawing.Size(1092, 712);
            this.TablePage.TabIndex = 1;
            this.TablePage.Text = "Table";
            // 
            // PoopingMode
            // 
            this.PoopingMode.AutoSize = true;
            this.PoopingMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PoopingMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PoopingMode.CheckedState.BorderRadius = 0;
            this.PoopingMode.CheckedState.BorderThickness = 0;
            this.PoopingMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PoopingMode.ForeColor = System.Drawing.Color.White;
            this.PoopingMode.Location = new System.Drawing.Point(152, 0);
            this.PoopingMode.Name = "PoopingMode";
            this.PoopingMode.Size = new System.Drawing.Size(95, 17);
            this.PoopingMode.TabIndex = 9;
            this.PoopingMode.Text = "Pooping Mode";
            this.PoopingMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.PoopingMode.UncheckedState.BorderRadius = 0;
            this.PoopingMode.UncheckedState.BorderThickness = 0;
            this.PoopingMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.PoopingMode.UseVisualStyleBackColor = false;
            this.PoopingMode.CheckedChanged += new System.EventHandler(this.PoopingMode_CheckedChanged);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::PenisLerningWinforms.Properties.Resources.neco_arc_taunt;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(699, 265);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(293, 407);
            this.siticonePictureBox1.TabIndex = 8;
            this.siticonePictureBox1.TabStop = false;
            // 
            // siticoneImageButton1
            // 
            this.siticoneImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton1.CheckedState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton1.HoverState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.Image = global::PenisLerningWinforms.Properties.Resources.database;
            this.siticoneImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.siticoneImageButton1.ImageRotate = 0F;
            this.siticoneImageButton1.ImageSize = new System.Drawing.Size(36, 36);
            this.siticoneImageButton1.Location = new System.Drawing.Point(1034, 0);
            this.siticoneImageButton1.Name = "siticoneImageButton1";
            this.siticoneImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.siticoneImageButton1.PressedState.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.ShadowDecoration.Parent = this.siticoneImageButton1;
            this.siticoneImageButton1.Size = new System.Drawing.Size(36, 36);
            this.siticoneImageButton1.TabIndex = 7;
            // 
            // TableSelectComboBox
            // 
            this.TableSelectComboBox.BackColor = System.Drawing.Color.Transparent;
            this.TableSelectComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TableSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableSelectComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TableSelectComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TableSelectComboBox.FocusedState.Parent = this.TableSelectComboBox;
            this.TableSelectComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TableSelectComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TableSelectComboBox.HoverState.Parent = this.TableSelectComboBox;
            this.TableSelectComboBox.ItemHeight = 30;
            this.TableSelectComboBox.ItemsAppearance.Parent = this.TableSelectComboBox;
            this.TableSelectComboBox.Location = new System.Drawing.Point(6, 0);
            this.TableSelectComboBox.Name = "TableSelectComboBox";
            this.TableSelectComboBox.ShadowDecoration.Parent = this.TableSelectComboBox;
            this.TableSelectComboBox.Size = new System.Drawing.Size(140, 36);
            this.TableSelectComboBox.TabIndex = 6;
            this.TableSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.TableSelectComboBox_SelectedIndexChanged);
            // 
            // Hui
            // 
            this.Hui.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Hui.Controls.Add(this.ScalarValueExecuteButton);
            this.Hui.Controls.Add(this.ScalarColumnComboxBox);
            this.Hui.Controls.Add(this.ScalarCommandComboBox);
            this.Hui.Location = new System.Drawing.Point(184, 4);
            this.Hui.Name = "Hui";
            this.Hui.Padding = new System.Windows.Forms.Padding(3);
            this.Hui.Size = new System.Drawing.Size(1092, 712);
            this.Hui.TabIndex = 0;
            this.Hui.Text = "Скалярные значения";
            // 
            // ScalarValueExecuteButton
            // 
            this.ScalarValueExecuteButton.CheckedState.Parent = this.ScalarValueExecuteButton;
            this.ScalarValueExecuteButton.CustomImages.Parent = this.ScalarValueExecuteButton;
            this.ScalarValueExecuteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ScalarValueExecuteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ScalarValueExecuteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ScalarValueExecuteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ScalarValueExecuteButton.DisabledState.Parent = this.ScalarValueExecuteButton;
            this.ScalarValueExecuteButton.FillColor = System.Drawing.SystemColors.Control;
            this.ScalarValueExecuteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ScalarValueExecuteButton.ForeColor = System.Drawing.Color.Black;
            this.ScalarValueExecuteButton.HoverState.Parent = this.ScalarValueExecuteButton;
            this.ScalarValueExecuteButton.Location = new System.Drawing.Point(6, 49);
            this.ScalarValueExecuteButton.Name = "ScalarValueExecuteButton";
            this.ScalarValueExecuteButton.ShadowDecoration.Parent = this.ScalarValueExecuteButton;
            this.ScalarValueExecuteButton.Size = new System.Drawing.Size(286, 36);
            this.ScalarValueExecuteButton.TabIndex = 3;
            this.ScalarValueExecuteButton.Text = "Execute";
            this.ScalarValueExecuteButton.Click += new System.EventHandler(this.ScalarValueExecuteButton_Click);
            // 
            // ScalarColumnComboxBox
            // 
            this.ScalarColumnComboxBox.BackColor = System.Drawing.Color.Transparent;
            this.ScalarColumnComboxBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ScalarColumnComboxBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScalarColumnComboxBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScalarColumnComboxBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScalarColumnComboxBox.FocusedState.Parent = this.ScalarColumnComboxBox;
            this.ScalarColumnComboxBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ScalarColumnComboxBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ScalarColumnComboxBox.HoverState.Parent = this.ScalarColumnComboxBox;
            this.ScalarColumnComboxBox.ItemHeight = 30;
            this.ScalarColumnComboxBox.ItemsAppearance.Parent = this.ScalarColumnComboxBox;
            this.ScalarColumnComboxBox.Location = new System.Drawing.Point(152, 7);
            this.ScalarColumnComboxBox.Name = "ScalarColumnComboxBox";
            this.ScalarColumnComboxBox.ShadowDecoration.Parent = this.ScalarColumnComboxBox;
            this.ScalarColumnComboxBox.Size = new System.Drawing.Size(140, 36);
            this.ScalarColumnComboxBox.TabIndex = 2;
            // 
            // ScalarCommandComboBox
            // 
            this.ScalarCommandComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ScalarCommandComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ScalarCommandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScalarCommandComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScalarCommandComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScalarCommandComboBox.FocusedState.Parent = this.ScalarCommandComboBox;
            this.ScalarCommandComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ScalarCommandComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ScalarCommandComboBox.HoverState.Parent = this.ScalarCommandComboBox;
            this.ScalarCommandComboBox.ItemHeight = 30;
            this.ScalarCommandComboBox.Items.AddRange(new object[] {
            "Min",
            "Max",
            "Count",
            "Sum"});
            this.ScalarCommandComboBox.ItemsAppearance.Parent = this.ScalarCommandComboBox;
            this.ScalarCommandComboBox.Location = new System.Drawing.Point(6, 7);
            this.ScalarCommandComboBox.Name = "ScalarCommandComboBox";
            this.ScalarCommandComboBox.ShadowDecoration.Parent = this.ScalarCommandComboBox;
            this.ScalarCommandComboBox.Size = new System.Drawing.Size(140, 36);
            this.ScalarCommandComboBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage2.Controls.Add(this.Insert);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.siticoneTextBox2);
            this.tabPage2.Controls.Add(this.siticoneTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(184, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1092, 712);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Параметрезированый запрос";
            // 
            // Insert
            // 
            this.Insert.CheckedState.Parent = this.Insert;
            this.Insert.CustomImages.Parent = this.Insert;
            this.Insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Insert.DisabledState.Parent = this.Insert;
            this.Insert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Insert.ForeColor = System.Drawing.Color.White;
            this.Insert.HoverState.Parent = this.Insert;
            this.Insert.Location = new System.Drawing.Point(4, 84);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.ShadowDecoration.Parent = this.Insert;
            this.Insert.Size = new System.Drawing.Size(135, 37);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "siticoneButton1";
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // siticoneTextBox2
            // 
            this.siticoneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox2.DefaultText = "";
            this.siticoneTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.DisabledState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.FocusedState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox2.HoverState.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Location = new System.Drawing.Point(159, 30);
            this.siticoneTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneTextBox2.Name = "siticoneTextBox2";
            this.siticoneTextBox2.PasswordChar = '\0';
            this.siticoneTextBox2.PlaceholderText = "";
            this.siticoneTextBox2.SelectedText = "";
            this.siticoneTextBox2.ShadowDecoration.Parent = this.siticoneTextBox2;
            this.siticoneTextBox2.Size = new System.Drawing.Size(150, 29);
            this.siticoneTextBox2.TabIndex = 1;
            this.siticoneTextBox2.TextChanged += new System.EventHandler(this.siticoneTextBox2_TextChanged);
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.HoverState.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Location = new System.Drawing.Point(4, 30);
            this.siticoneTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.ShadowDecoration.Parent = this.siticoneTextBox1;
            this.siticoneTextBox1.Size = new System.Drawing.Size(150, 29);
            this.siticoneTextBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogConsole);
            this.tabPage1.Location = new System.Drawing.Point(184, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1092, 712);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // poopingPage
            // 
            this.poopingPage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.poopingPage.Controls.Add(this.siticoneHtmlLabel1);
            this.poopingPage.Controls.Add(this.pictureBox1);
            this.poopingPage.Location = new System.Drawing.Point(184, 4);
            this.poopingPage.Name = "poopingPage";
            this.poopingPage.Size = new System.Drawing.Size(1092, 712);
            this.poopingPage.TabIndex = 4;
            this.poopingPage.Text = "Насрать в бд";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(374, 292);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(369, 82);
            this.siticoneHtmlLabel1.TabIndex = 3;
            this.siticoneHtmlLabel1.Text = "НАСРАТЬ В БД";
            this.siticoneHtmlLabel1.Click += new System.EventHandler(this.siticoneHtmlLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PenisLerningWinforms.Properties.Resources.rat_spinning__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1089, 685);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Penis Lerning";
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            this.MainTabControl1.ResumeLayout(false);
            this.TablePage.ResumeLayout(false);
            this.TablePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.Hui.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.poopingPage.ResumeLayout(false);
            this.poopingPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox LogConsole;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.DataGridView TableGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl MainTabControl1;
        private System.Windows.Forms.TabPage Hui;
        private System.Windows.Forms.TabPage TablePage;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox TableSelectComboBox;
        private System.Windows.Forms.TabPage tabPage1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton siticoneImageButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ScalarCommandComboBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ScalarColumnComboxBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ScalarValueExecuteButton;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Insert;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox PoopingMode;
        private System.Windows.Forms.TabPage poopingPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

