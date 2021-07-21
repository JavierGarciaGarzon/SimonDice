namespace SimonDice
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.Button_play = new System.Windows.Forms.Button();
            this.Button_Opciones = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_play
            // 
            this.Button_play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_play.AutoSize = true;
            this.Button_play.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_play.Location = new System.Drawing.Point(128, 108);
            this.Button_play.Name = "Button_play";
            this.Button_play.Size = new System.Drawing.Size(353, 85);
            this.Button_play.TabIndex = 0;
            this.Button_play.Text = "Jugar";
            this.Button_play.UseVisualStyleBackColor = true;
            this.Button_play.Click += new System.EventHandler(this.Button_play_Click);
            // 
            // Button_Opciones
            // 
            this.Button_Opciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Opciones.AutoSize = true;
            this.Button_Opciones.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Opciones.Location = new System.Drawing.Point(128, 227);
            this.Button_Opciones.Name = "Button_Opciones";
            this.Button_Opciones.Size = new System.Drawing.Size(353, 85);
            this.Button_Opciones.TabIndex = 1;
            this.Button_Opciones.Text = "Opciones";
            this.Button_Opciones.UseVisualStyleBackColor = true;
            this.Button_Opciones.Click += new System.EventHandler(this.Button_Opciones_Click);
            // 
            // Button_exit
            // 
            this.Button_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_exit.AutoSize = true;
            this.Button_exit.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_exit.Location = new System.Drawing.Point(128, 339);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(353, 85);
            this.Button_exit.TabIndex = 2;
            this.Button_exit.Text = "Salir";
            this.Button_exit.UseVisualStyleBackColor = true;
            this.Button_exit.Click += new System.EventHandler(this.Button3_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SimonDice.Properties.Resources.retro_hd_wallpapers_For_desktop_Wallpaper;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.Button_Opciones);
            this.Controls.Add(this.Button_play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.VisibleChanged += new System.EventHandler(this.MenuPrincipal_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_play;
        private System.Windows.Forms.Button Button_Opciones;
        private System.Windows.Forms.Button Button_exit;
    }
}