
namespace ShellShockProjectileMotion
{
	partial class MainForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

      


        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.angleVisualizer = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.bumperModeButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bumperLabel = new System.Windows.Forms.Label();
            this.bumperTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.setBumperButton = new System.Windows.Forms.Button();
            this.bumperPanel = new System.Windows.Forms.Panel();
            this.bumperLabel2 = new System.Windows.Forms.Label();
            this.redrawAndClearTable = new ShellShockProjectileMotion.CustomTableLayoutPanel();
            this.redrawButton = new System.Windows.Forms.Button();
            this.clearScreenButton = new System.Windows.Forms.Button();
            this.tableAngle = new ShellShockProjectileMotion.CustomTableLayoutPanel();
            this.buttonAngle1 = new System.Windows.Forms.Button();
            this.quickAnglesLable = new System.Windows.Forms.Label();
            this.buttonAngle2 = new System.Windows.Forms.Button();
            this.buttonAngle3 = new System.Windows.Forms.Button();
            this.buttonAngle4 = new System.Windows.Forms.Button();
            this.buttonAngle7 = new System.Windows.Forms.Button();
            this.buttonAngle8 = new System.Windows.Forms.Button();
            this.buttonAngle6 = new System.Windows.Forms.Button();
            this.buttonAngle5 = new System.Windows.Forms.Button();
            this.optionalSettingsLayout = new ShellShockProjectileMotion.CustomTableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.showTracerCheck = new System.Windows.Forms.CheckBox();
            this.keepOpenCheck = new System.Windows.Forms.CheckBox();
            this.themeCheck = new System.Windows.Forms.CheckBox();
            this.showLinearCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new ShellShockProjectileMotion.CustomTableLayoutPanel();
            this.labelAngle2 = new System.Windows.Forms.Label();
            this.labelAngle1 = new System.Windows.Forms.Label();
            this.labelPower2 = new System.Windows.Forms.Label();
            this.labelPower1 = new System.Windows.Forms.Label();
            this.yourAnglePanel = new ShellShockProjectileMotion.CustomTableLayoutPanel();
            this.textAngle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new ShellShockProjectileMotion.CustomTableLayoutPanel();
            this.setOnePosButton = new System.Windows.Forms.Button();
            this.setBothPosButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.bumperTableLayoutPanel.SuspendLayout();
            this.redrawAndClearTable.SuspendLayout();
            this.tableAngle.SuspendLayout();
            this.optionalSettingsLayout.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.yourAnglePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 23);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(744, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "By Mat";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(24, 9);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 18;
            this.labelError.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelError_Paint);
            // 
            // angleVisualizer
            // 
            this.angleVisualizer.Location = new System.Drawing.Point(564, 152);
            this.angleVisualizer.Name = "angleVisualizer";
            this.angleVisualizer.Size = new System.Drawing.Size(93, 100);
            this.angleVisualizer.TabIndex = 20;
            this.angleVisualizer.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // bumperModeButton
            // 
            this.bumperModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bumperModeButton.Location = new System.Drawing.Point(150, 374);
            this.bumperModeButton.Name = "bumperModeButton";
            this.bumperModeButton.Size = new System.Drawing.Size(103, 48);
            this.bumperModeButton.TabIndex = 28;
            this.bumperModeButton.Tag = "BUMPER";
            this.bumperModeButton.Text = "Bumper Mode";
            this.bumperModeButton.UseVisualStyleBackColor = true;
            this.bumperModeButton.Click += new System.EventHandler(this.bumperModeButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // bumperLabel
            // 
            this.bumperLabel.AutoSize = true;
            this.bumperLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bumperLabel.Location = new System.Drawing.Point(229, 72);
            this.bumperLabel.Name = "bumperLabel";
            this.bumperLabel.Size = new System.Drawing.Size(63, 119);
            this.bumperLabel.TabIndex = 31;
            this.bumperLabel.Text = "Circle Scale";
            this.bumperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bumperTableLayoutPanel
            // 
            this.bumperTableLayoutPanel.ColumnCount = 3;
            this.bumperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.23423F));
            this.bumperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.63363F));
            this.bumperTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.83183F));
            this.bumperTableLayoutPanel.Controls.Add(this.bumperLabel2, 0, 2);
            this.bumperTableLayoutPanel.Controls.Add(this.setBumperButton, 0, 0);
            this.bumperTableLayoutPanel.Controls.Add(this.bumperLabel, 2, 2);
            this.bumperTableLayoutPanel.Controls.Add(this.bumperPanel, 1, 2);
            this.bumperTableLayoutPanel.Location = new System.Drawing.Point(36, 177);
            this.bumperTableLayoutPanel.Name = "bumperTableLayoutPanel";
            this.bumperTableLayoutPanel.RowCount = 3;
            this.bumperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.13253F));
            this.bumperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.918033F));
            this.bumperTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.29508F));
            this.bumperTableLayoutPanel.Size = new System.Drawing.Size(333, 191);
            this.bumperTableLayoutPanel.TabIndex = 32;
            // 
            // setBumperButton
            // 
            this.bumperTableLayoutPanel.SetColumnSpan(this.setBumperButton, 3);
            this.setBumperButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setBumperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setBumperButton.Location = new System.Drawing.Point(3, 3);
            this.setBumperButton.Name = "setBumperButton";
            this.setBumperButton.Size = new System.Drawing.Size(327, 57);
            this.setBumperButton.TabIndex = 27;
            this.setBumperButton.Tag = "BUMPER";
            this.setBumperButton.Text = "Mark Bumper";
            this.setBumperButton.UseVisualStyleBackColor = true;
            this.setBumperButton.Click += new System.EventHandler(this.SetBumperButton_Click);
            // 
            // bumperPanel
            // 
            this.bumperPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bumperPanel.Location = new System.Drawing.Point(117, 75);
            this.bumperPanel.Name = "bumperPanel";
            this.bumperPanel.Size = new System.Drawing.Size(106, 113);
            this.bumperPanel.TabIndex = 30;
            this.bumperPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bumperPanel_Paint);
            // 
            // bumperLabel2
            // 
            this.bumperLabel2.AutoSize = true;
            this.bumperLabel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bumperLabel2.Location = new System.Drawing.Point(13, 72);
            this.bumperLabel2.Name = "bumperLabel2";
            this.bumperLabel2.Size = new System.Drawing.Size(98, 119);
            this.bumperLabel2.TabIndex = 32;
            this.bumperLabel2.Text = "Accepted Hit Circle";
            this.bumperLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redrawAndClearTable
            // 
            this.redrawAndClearTable.ColumnCount = 2;
            this.redrawAndClearTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.redrawAndClearTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.redrawAndClearTable.Controls.Add(this.redrawButton, 0, 0);
            this.redrawAndClearTable.Controls.Add(this.clearScreenButton, 1, 0);
            this.redrawAndClearTable.Location = new System.Drawing.Point(27, 105);
            this.redrawAndClearTable.Name = "redrawAndClearTable";
            this.redrawAndClearTable.RowCount = 1;
            this.redrawAndClearTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.redrawAndClearTable.Size = new System.Drawing.Size(356, 52);
            this.redrawAndClearTable.TabIndex = 26;
            // 
            // redrawButton
            // 
            this.redrawButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redrawButton.Location = new System.Drawing.Point(3, 3);
            this.redrawButton.Name = "redrawButton";
            this.redrawButton.Size = new System.Drawing.Size(172, 46);
            this.redrawButton.TabIndex = 25;
            this.redrawButton.Text = "Redraw ";
            this.redrawButton.UseVisualStyleBackColor = true;
            // 
            // clearScreenButton
            // 
            this.clearScreenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearScreenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearScreenButton.Location = new System.Drawing.Point(181, 3);
            this.clearScreenButton.Name = "clearScreenButton";
            this.clearScreenButton.Size = new System.Drawing.Size(172, 46);
            this.clearScreenButton.TabIndex = 20;
            this.clearScreenButton.Tag = "DELETE";
            this.clearScreenButton.Text = "Clear Screen";
            this.clearScreenButton.UseVisualStyleBackColor = true;
            this.clearScreenButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tableAngle
            // 
            this.tableAngle.ColumnCount = 4;
            this.tableAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableAngle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableAngle.Controls.Add(this.buttonAngle1, 0, 1);
            this.tableAngle.Controls.Add(this.quickAnglesLable, 0, 0);
            this.tableAngle.Controls.Add(this.buttonAngle2, 1, 1);
            this.tableAngle.Controls.Add(this.buttonAngle3, 2, 1);
            this.tableAngle.Controls.Add(this.buttonAngle4, 3, 1);
            this.tableAngle.Controls.Add(this.buttonAngle7, 2, 2);
            this.tableAngle.Controls.Add(this.buttonAngle8, 3, 2);
            this.tableAngle.Controls.Add(this.buttonAngle6, 1, 2);
            this.tableAngle.Controls.Add(this.buttonAngle5, 0, 2);
            this.tableAngle.Location = new System.Drawing.Point(30, 241);
            this.tableAngle.Name = "tableAngle";
            this.tableAngle.RowCount = 3;
            this.tableAngle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.81203F));
            this.tableAngle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.59399F));
            this.tableAngle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.59399F));
            this.tableAngle.Size = new System.Drawing.Size(353, 102);
            this.tableAngle.TabIndex = 19;
            // 
            // buttonAngle1
            // 
            this.buttonAngle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAngle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle1.Location = new System.Drawing.Point(3, 28);
            this.buttonAngle1.Name = "buttonAngle1";
            this.buttonAngle1.Size = new System.Drawing.Size(82, 32);
            this.buttonAngle1.TabIndex = 0;
            this.buttonAngle1.Text = "10";
            this.buttonAngle1.UseVisualStyleBackColor = true;
            // 
            // quickAnglesLable
            // 
            this.quickAnglesLable.AutoSize = true;
            this.tableAngle.SetColumnSpan(this.quickAnglesLable, 4);
            this.quickAnglesLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickAnglesLable.Location = new System.Drawing.Point(3, 0);
            this.quickAnglesLable.Name = "quickAnglesLable";
            this.quickAnglesLable.Size = new System.Drawing.Size(347, 25);
            this.quickAnglesLable.TabIndex = 10;
            this.quickAnglesLable.Text = "Quick Angles";
            this.quickAnglesLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAngle2
            // 
            this.buttonAngle2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAngle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle2.Location = new System.Drawing.Point(91, 28);
            this.buttonAngle2.Name = "buttonAngle2";
            this.buttonAngle2.Size = new System.Drawing.Size(82, 32);
            this.buttonAngle2.TabIndex = 1;
            this.buttonAngle2.Text = "20";
            this.buttonAngle2.UseVisualStyleBackColor = true;
            // 
            // buttonAngle3
            // 
            this.buttonAngle3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAngle3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle3.Location = new System.Drawing.Point(179, 28);
            this.buttonAngle3.Name = "buttonAngle3";
            this.buttonAngle3.Size = new System.Drawing.Size(82, 32);
            this.buttonAngle3.TabIndex = 2;
            this.buttonAngle3.Text = "30";
            this.buttonAngle3.UseVisualStyleBackColor = true;
            // 
            // buttonAngle4
            // 
            this.buttonAngle4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAngle4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle4.Location = new System.Drawing.Point(267, 28);
            this.buttonAngle4.Name = "buttonAngle4";
            this.buttonAngle4.Size = new System.Drawing.Size(83, 32);
            this.buttonAngle4.TabIndex = 3;
            this.buttonAngle4.Text = "40";
            this.buttonAngle4.UseVisualStyleBackColor = true;
            // 
            // buttonAngle7
            // 
            this.buttonAngle7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAngle7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle7.Location = new System.Drawing.Point(179, 66);
            this.buttonAngle7.Name = "buttonAngle7";
            this.buttonAngle7.Size = new System.Drawing.Size(82, 33);
            this.buttonAngle7.TabIndex = 6;
            this.buttonAngle7.Text = "70";
            this.buttonAngle7.UseVisualStyleBackColor = true;
            // 
            // buttonAngle8
            // 
            this.buttonAngle8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAngle8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle8.Location = new System.Drawing.Point(267, 66);
            this.buttonAngle8.Name = "buttonAngle8";
            this.buttonAngle8.Size = new System.Drawing.Size(83, 33);
            this.buttonAngle8.TabIndex = 7;
            this.buttonAngle8.Text = "80";
            this.buttonAngle8.UseVisualStyleBackColor = true;
            // 
            // buttonAngle6
            // 
            this.buttonAngle6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAngle6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle6.Location = new System.Drawing.Point(91, 66);
            this.buttonAngle6.Name = "buttonAngle6";
            this.buttonAngle6.Size = new System.Drawing.Size(82, 33);
            this.buttonAngle6.TabIndex = 5;
            this.buttonAngle6.Text = "60";
            this.buttonAngle6.UseVisualStyleBackColor = true;
            // 
            // buttonAngle5
            // 
            this.buttonAngle5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAngle5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAngle5.Location = new System.Drawing.Point(3, 66);
            this.buttonAngle5.Name = "buttonAngle5";
            this.buttonAngle5.Size = new System.Drawing.Size(82, 33);
            this.buttonAngle5.TabIndex = 4;
            this.buttonAngle5.Text = "50";
            this.buttonAngle5.UseVisualStyleBackColor = true;
            // 
            // optionalSettingsLayout
            // 
            this.optionalSettingsLayout.ColumnCount = 2;
            this.optionalSettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionalSettingsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionalSettingsLayout.Controls.Add(this.label4, 0, 0);
            this.optionalSettingsLayout.Controls.Add(this.showTracerCheck, 0, 1);
            this.optionalSettingsLayout.Controls.Add(this.keepOpenCheck, 0, 2);
            this.optionalSettingsLayout.Controls.Add(this.themeCheck, 1, 2);
            this.optionalSettingsLayout.Controls.Add(this.showLinearCheck, 1, 1);
            this.optionalSettingsLayout.Location = new System.Drawing.Point(478, 332);
            this.optionalSettingsLayout.Name = "optionalSettingsLayout";
            this.optionalSettingsLayout.RowCount = 3;
            this.optionalSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.66667F));
            this.optionalSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this.optionalSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.optionalSettingsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionalSettingsLayout.Size = new System.Drawing.Size(274, 79);
            this.optionalSettingsLayout.TabIndex = 17;
            // 
            // label4
            // 
            this.optionalSettingsLayout.SetColumnSpan(this.label4, 2);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Optional  settings";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showTracerCheck
            // 
            this.showTracerCheck.AutoSize = true;
            this.showTracerCheck.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.showTracerCheck.Checked = true;
            this.showTracerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTracerCheck.ForeColor = System.Drawing.SystemColors.Desktop;
            this.showTracerCheck.Location = new System.Drawing.Point(3, 31);
            this.showTracerCheck.Name = "showTracerCheck";
            this.showTracerCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.showTracerCheck.Size = new System.Drawing.Size(93, 17);
            this.showTracerCheck.TabIndex = 18;
            this.showTracerCheck.Text = "Show tracer";
            this.showTracerCheck.UseVisualStyleBackColor = false;
            this.showTracerCheck.CheckedChanged += new System.EventHandler(this.ShowTracerToggleCheck_CheckedChanged);
            // 
            // keepOpenCheck
            // 
            this.keepOpenCheck.AutoSize = true;
            this.keepOpenCheck.Location = new System.Drawing.Point(3, 55);
            this.keepOpenCheck.Name = "keepOpenCheck";
            this.keepOpenCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.keepOpenCheck.Size = new System.Drawing.Size(88, 17);
            this.keepOpenCheck.TabIndex = 14;
            this.keepOpenCheck.Text = "Keep open";
            this.keepOpenCheck.UseVisualStyleBackColor = true;
            this.keepOpenCheck.CheckedChanged += new System.EventHandler(this.KeepOpenToggleCheck_CheckedChanged);
            // 
            // themeCheck
            // 
            this.themeCheck.AutoSize = true;
            this.themeCheck.Location = new System.Drawing.Point(140, 55);
            this.themeCheck.Name = "themeCheck";
            this.themeCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.themeCheck.Size = new System.Drawing.Size(121, 17);
            this.themeCheck.TabIndex = 3;
            this.themeCheck.Text = "Toggle Lightmode";
            this.themeCheck.UseVisualStyleBackColor = true;
            this.themeCheck.CheckedChanged += new System.EventHandler(this.ThemeToggleCheck_CheckedChanged);
            // 
            // showLinearCheck
            // 
            this.showLinearCheck.AutoSize = true;
            this.showLinearCheck.Location = new System.Drawing.Point(140, 31);
            this.showLinearCheck.Name = "showLinearCheck";
            this.showLinearCheck.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.showLinearCheck.Size = new System.Drawing.Size(121, 17);
            this.showLinearCheck.TabIndex = 21;
            this.showLinearCheck.Text = "Show linear tracer";
            this.showLinearCheck.UseVisualStyleBackColor = true;
            this.showLinearCheck.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelAngle2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelAngle1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelPower2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPower1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(450, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(323, 105);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // labelAngle2
            // 
            this.labelAngle2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAngle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelAngle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelAngle2.Location = new System.Drawing.Point(164, 54);
            this.labelAngle2.Name = "labelAngle2";
            this.labelAngle2.Size = new System.Drawing.Size(156, 51);
            this.labelAngle2.TabIndex = 20;
            this.labelAngle2.Text = "N/A";
            this.labelAngle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAngle1
            // 
            this.labelAngle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAngle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelAngle1.Location = new System.Drawing.Point(3, 54);
            this.labelAngle1.Name = "labelAngle1";
            this.labelAngle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.labelAngle1.Size = new System.Drawing.Size(155, 51);
            this.labelAngle1.TabIndex = 19;
            this.labelAngle1.Text = "ANGLE:";
            this.labelAngle1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelAngle1.Paint += new System.Windows.Forms.PaintEventHandler(this.labelAngle1_Paint);
            // 
            // labelPower2
            // 
            this.labelPower2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPower2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelPower2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelPower2.Location = new System.Drawing.Point(164, 3);
            this.labelPower2.Name = "labelPower2";
            this.labelPower2.Size = new System.Drawing.Size(156, 51);
            this.labelPower2.TabIndex = 18;
            this.labelPower2.Text = "N/A";
            this.labelPower2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPower2.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelPower2_Paint);
            // 
            // labelPower1
            // 
            this.labelPower1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPower1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelPower1.Location = new System.Drawing.Point(3, 0);
            this.labelPower1.Name = "labelPower1";
            this.labelPower1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.labelPower1.Size = new System.Drawing.Size(155, 54);
            this.labelPower1.TabIndex = 17;
            this.labelPower1.Text = "POWER:";
            this.labelPower1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // yourAnglePanel
            // 
            this.yourAnglePanel.ColumnCount = 2;
            this.yourAnglePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.yourAnglePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.yourAnglePanel.Controls.Add(this.textAngle, 1, 0);
            this.yourAnglePanel.Controls.Add(this.label3, 0, 0);
            this.yourAnglePanel.Location = new System.Drawing.Point(73, 177);
            this.yourAnglePanel.Name = "yourAnglePanel";
            this.yourAnglePanel.RowCount = 1;
            this.yourAnglePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.yourAnglePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.yourAnglePanel.Size = new System.Drawing.Size(286, 47);
            this.yourAnglePanel.TabIndex = 16;
            // 
            // textAngle
            // 
            this.textAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAngle.Location = new System.Drawing.Point(146, 13);
            this.textAngle.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.textAngle.Name = "textAngle";
            this.textAngle.Size = new System.Drawing.Size(137, 20);
            this.textAngle.TabIndex = 1;
            this.textAngle.Text = "45";
            this.textAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textAngle.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your Angle:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.setOnePosButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.setBothPosButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 70);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // setOnePosButton
            // 
            this.setOnePosButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setOnePosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setOnePosButton.Location = new System.Drawing.Point(181, 3);
            this.setOnePosButton.Name = "setOnePosButton";
            this.setOnePosButton.Size = new System.Drawing.Size(172, 64);
            this.setOnePosButton.TabIndex = 12;
            this.setOnePosButton.Text = "Set Only Target Pos";
            this.setOnePosButton.UseVisualStyleBackColor = true;
            this.setOnePosButton.Click += new System.EventHandler(this.SetOnePosButton_Click);
            // 
            // setBothPosButton
            // 
            this.setBothPosButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setBothPosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setBothPosButton.Location = new System.Drawing.Point(3, 3);
            this.setBothPosButton.Name = "setBothPosButton";
            this.setBothPosButton.Size = new System.Drawing.Size(172, 64);
            this.setBothPosButton.TabIndex = 9;
            this.setBothPosButton.Text = "Set Own + Target Pos";
            this.setBothPosButton.UseVisualStyleBackColor = true;
            this.setBothPosButton.Click += new System.EventHandler(this.OwnPosButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bumperTableLayoutPanel);
            this.Controls.Add(this.bumperModeButton);
            this.Controls.Add(this.redrawAndClearTable);
            this.Controls.Add(this.angleVisualizer);
            this.Controls.Add(this.tableAngle);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.optionalSettingsLayout);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.yourAnglePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShellShockProjectiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bumperTableLayoutPanel.ResumeLayout(false);
            this.bumperTableLayoutPanel.PerformLayout();
            this.redrawAndClearTable.ResumeLayout(false);
            this.tableAngle.ResumeLayout(false);
            this.tableAngle.PerformLayout();
            this.optionalSettingsLayout.ResumeLayout(false);
            this.optionalSettingsLayout.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.yourAnglePanel.ResumeLayout(false);
            this.yourAnglePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox themeCheck;
        private System.Windows.Forms.Button setBothPosButton;
        private System.Windows.Forms.CheckBox keepOpenCheck;
        private System.Windows.Forms.Button setOnePosButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAngle;
        private System.Windows.Forms.Label labelPower1;
        private System.Windows.Forms.Label labelPower2;
        private System.Windows.Forms.CheckBox showTracerCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonAngle1;
        private System.Windows.Forms.Button buttonAngle8;
        private System.Windows.Forms.Button buttonAngle7;
        private System.Windows.Forms.Button buttonAngle6;
        private System.Windows.Forms.Button buttonAngle2;
        private System.Windows.Forms.Button buttonAngle3;
        private System.Windows.Forms.Button buttonAngle4;
        private System.Windows.Forms.Button buttonAngle5;
        private System.Windows.Forms.Label quickAnglesLable;
        private System.Windows.Forms.Button clearScreenButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel angleVisualizer;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.CheckBox showLinearCheck;
        private CustomTableLayoutPanel tableLayoutPanel1;
        private CustomTableLayoutPanel yourAnglePanel;
        private CustomTableLayoutPanel tableLayoutPanel3;
        private CustomTableLayoutPanel optionalSettingsLayout;
        private CustomTableLayoutPanel tableAngle;
        private System.Windows.Forms.Button redrawButton;
        private CustomTableLayoutPanel redrawAndClearTable;
        private System.Windows.Forms.Button setBumperButton;
        private System.Windows.Forms.Label labelAngle2;
        private System.Windows.Forms.Label labelAngle1;
        private System.Windows.Forms.Button bumperModeButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel bumperPanel;
        private System.Windows.Forms.Label bumperLabel;
        private System.Windows.Forms.Label bumperLabel2;
        private System.Windows.Forms.TableLayoutPanel bumperTableLayoutPanel;
    }
}

