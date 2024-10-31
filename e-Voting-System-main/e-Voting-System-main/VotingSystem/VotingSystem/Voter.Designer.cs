namespace VotingSystem
{
    partial class Voter
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonPalette3 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.firstName_box = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lastName_box = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.username_box1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.password_box1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.program_cb = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.year_box = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.deleteButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.backButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.updateButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.program_cb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName_box
            // 
            this.firstName_box.Location = new System.Drawing.Point(44, 136);
            this.firstName_box.Name = "firstName_box";
            this.firstName_box.Size = new System.Drawing.Size(472, 37);
            this.firstName_box.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.firstName_box.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.firstName_box.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.firstName_box.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstName_box.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.firstName_box.StateCommon.Border.Rounding = 12;
            this.firstName_box.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_box.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.firstName_box.TabIndex = 6;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(44, 179);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 26);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "Username:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(553, 179);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(87, 26);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 11;
            this.kryptonLabel2.Values.Text = "Password:";
            // 
            // lastName_box
            // 
            this.lastName_box.Location = new System.Drawing.Point(553, 136);
            this.lastName_box.Name = "lastName_box";
            this.lastName_box.Size = new System.Drawing.Size(472, 37);
            this.lastName_box.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.lastName_box.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.lastName_box.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.lastName_box.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lastName_box.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.lastName_box.StateCommon.Border.Rounding = 12;
            this.lastName_box.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_box.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.lastName_box.TabIndex = 10;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(44, 104);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(97, 26);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "First Name:";
            // 
            // username_box1
            // 
            this.username_box1.Location = new System.Drawing.Point(44, 211);
            this.username_box1.Name = "username_box1";
            this.username_box1.Size = new System.Drawing.Size(472, 37);
            this.username_box1.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.username_box1.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.username_box1.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.username_box1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.username_box1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.username_box1.StateCommon.Border.Rounding = 12;
            this.username_box1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box1.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.username_box1.TabIndex = 12;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(553, 104);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(95, 26);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 15;
            this.kryptonLabel4.Values.Text = "Last Name:";
            // 
            // password_box1
            // 
            this.password_box1.Location = new System.Drawing.Point(553, 211);
            this.password_box1.Name = "password_box1";
            this.password_box1.Size = new System.Drawing.Size(472, 37);
            this.password_box1.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.password_box1.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.password_box1.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.password_box1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password_box1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.password_box1.StateCommon.Border.Rounding = 12;
            this.password_box1.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box1.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.password_box1.TabIndex = 14;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(553, 254);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(81, 26);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 17;
            this.kryptonLabel5.Values.Text = "Program:";
            // 
            // program_cb
            // 
            this.program_cb.DropDownWidth = 464;
            this.program_cb.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.program_cb.Location = new System.Drawing.Point(554, 290);
            this.program_cb.Name = "program_cb";
            this.program_cb.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.program_cb.Size = new System.Drawing.Size(472, 29);
            this.program_cb.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.program_cb.StateCommon.ComboBox.Border.Rounding = 12;
            this.program_cb.StateCommon.DropBack.Color1 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateCommon.DropBack.Color2 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateCommon.Item.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateCommon.Item.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateCommon.Item.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateCommon.Item.Border.Color2 = System.Drawing.Color.DimGray;
            this.program_cb.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.program_cb.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_cb.StateDisabled.ComboBox.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateDisabled.Item.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateDisabled.Item.Back.Color2 = System.Drawing.Color.Gainsboro;
            this.program_cb.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_cb.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_cb.TabIndex = 18;
            this.program_cb.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            // 
            // year_box
            // 
            this.year_box.Location = new System.Drawing.Point(44, 286);
            this.year_box.Name = "year_box";
            this.year_box.Size = new System.Drawing.Size(472, 37);
            this.year_box.StateCommon.Back.Color1 = System.Drawing.Color.Gainsboro;
            this.year_box.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.year_box.StateCommon.Border.Color2 = System.Drawing.Color.Gainsboro;
            this.year_box.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.year_box.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.year_box.StateCommon.Border.Rounding = 12;
            this.year_box.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_box.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.year_box.TabIndex = 20;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(44, 254);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(49, 26);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel6.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 19;
            this.kryptonLabel6.Values.Text = "Year:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VotingSystem.Properties.Resources.Systems_Technology_Institute;
            this.pictureBox1.Location = new System.Drawing.Point(467, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(44, 595);
            this.addButton.Name = "addButton";
            this.addButton.OverrideDefault.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.addButton.OverrideDefault.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.addButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Silver;
            this.addButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Silver;
            this.addButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.OverrideDefault.Border.Rounding = 12;
            this.addButton.Size = new System.Drawing.Size(152, 41);
            this.addButton.StateCommon.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.addButton.StateCommon.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.addButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.StateCommon.Border.Rounding = 12;
            this.addButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.addButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.StateDisabled.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.addButton.StateDisabled.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.addButton.StateNormal.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.addButton.StateNormal.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.addButton.StateNormal.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.addButton.StateNormal.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.addButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addButton.StateNormal.Border.Rounding = 12;
            this.addButton.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.addButton.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.addButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.RoyalBlue;
            this.addButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.RoyalBlue;
            this.addButton.TabIndex = 22;
            this.addButton.Values.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(202, 595);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OverrideDefault.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.OverrideDefault.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Silver;
            this.deleteButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Silver;
            this.deleteButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteButton.OverrideDefault.Border.Rounding = 12;
            this.deleteButton.Size = new System.Drawing.Size(152, 41);
            this.deleteButton.StateCommon.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StateCommon.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteButton.StateCommon.Border.Rounding = 12;
            this.deleteButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.deleteButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.StateDisabled.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StateDisabled.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StateNormal.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StateNormal.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StateNormal.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StateNormal.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.deleteButton.StateNormal.Border.Rounding = 12;
            this.deleteButton.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.deleteButton.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.deleteButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.RoyalBlue;
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Values.Text = "Delete";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(716, 595);
            this.backButton.Name = "backButton";
            this.backButton.OverrideDefault.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.backButton.OverrideDefault.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.backButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Silver;
            this.backButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Silver;
            this.backButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.OverrideDefault.Border.Rounding = 12;
            this.backButton.Size = new System.Drawing.Size(152, 41);
            this.backButton.StateCommon.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.backButton.StateCommon.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.backButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.StateCommon.Border.Rounding = 12;
            this.backButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.backButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.StateDisabled.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.backButton.StateDisabled.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.backButton.StateNormal.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.backButton.StateNormal.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.backButton.StateNormal.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.backButton.StateNormal.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.backButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.StateNormal.Border.Rounding = 12;
            this.backButton.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.backButton.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.backButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.RoyalBlue;
            this.backButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.RoyalBlue;
            this.backButton.TabIndex = 24;
            this.backButton.Values.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(874, 595);
            this.updateButton.Name = "updateButton";
            this.updateButton.OverrideDefault.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.updateButton.OverrideDefault.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.updateButton.OverrideDefault.Border.Color1 = System.Drawing.Color.Silver;
            this.updateButton.OverrideDefault.Border.Color2 = System.Drawing.Color.Silver;
            this.updateButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateButton.OverrideDefault.Border.Rounding = 12;
            this.updateButton.Size = new System.Drawing.Size(152, 41);
            this.updateButton.StateCommon.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StateCommon.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateButton.StateCommon.Border.Rounding = 12;
            this.updateButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.updateButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.StateDisabled.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StateDisabled.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StateNormal.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StateNormal.Back.Color2 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StateNormal.Border.Color1 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StateNormal.Border.Color2 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.updateButton.StateNormal.Border.Rounding = 12;
            this.updateButton.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.updateButton.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.updateButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.RoyalBlue;
            this.updateButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.RoyalBlue;
            this.updateButton.TabIndex = 25;
            this.updateButton.Values.Text = "Update";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(45, 347);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(981, 222);
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Rounding = 12;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.Rounding = 12;
            this.kryptonDataGridView1.StateNormal.Background.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonDataGridView1.StateNormal.Background.Color2 = System.Drawing.Color.Gainsboro;
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateNormal.HeaderColumn.Border.Rounding = 12;
            this.kryptonDataGridView1.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateNormal.HeaderRow.Border.Rounding = 12;
            this.kryptonDataGridView1.TabIndex = 26;
            // 
            // Voter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 698);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.year_box);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.program_cb);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.password_box1);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.username_box1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lastName_box);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.firstName_box);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 737);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 737);
            this.Name = "Voter";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.StateActive.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Yellow;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.Yellow;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.StateInactive.Back.Color1 = System.Drawing.Color.White;
            this.StateInactive.Back.Color2 = System.Drawing.Color.White;
            this.StateInactive.Border.Color1 = System.Drawing.Color.White;
            this.StateInactive.Border.Color2 = System.Drawing.Color.White;
            this.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "STI COLLEGE";
            ((System.ComponentModel.ISupportInitialize)(this.program_cb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox firstName_box;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox lastName_box;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox username_box1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox password_box1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox program_cb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox year_box;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton deleteButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton backButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton updateButton;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
    }
}