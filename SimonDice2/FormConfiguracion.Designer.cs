namespace SimonDice
{
    partial class FormConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            this.checkBoxPantallaC = new System.Windows.Forms.CheckBox();
            this.checkBoxMusica = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxPantallaC
            // 
            this.checkBoxPantallaC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxPantallaC.Location = new System.Drawing.Point(106, 23);
            this.checkBoxPantallaC.Name = "checkBoxPantallaC";
            this.checkBoxPantallaC.Size = new System.Drawing.Size(113, 17);
            this.checkBoxPantallaC.TabIndex = 0;
            this.checkBoxPantallaC.Text = "Pantalla Completa";
            this.checkBoxPantallaC.UseVisualStyleBackColor = true;
            // 
            // checkBoxMusica
            // 
            this.checkBoxMusica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxMusica.Location = new System.Drawing.Point(106, 58);
            this.checkBoxMusica.Name = "checkBoxMusica";
            this.checkBoxMusica.Size = new System.Drawing.Size(59, 17);
            this.checkBoxMusica.TabIndex = 1;
            this.checkBoxMusica.Text = "Música";
            this.checkBoxMusica.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Underline);
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuración";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(106, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxPantallaC);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBoxMusica);
            this.panel1.Location = new System.Drawing.Point(37, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 159);
            this.panel1.TabIndex = 4;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SimonDice.Properties.Resources.retro_hd_wallpapers_For_desktop_Wallpaper;
            this.ClientSize = new System.Drawing.Size(433, 256);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Leelawadee UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfiguracion";
            this.Text = "Configuración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfiguracion_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FormConfiguracion_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPantallaC;
        private System.Windows.Forms.CheckBox checkBoxMusica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}