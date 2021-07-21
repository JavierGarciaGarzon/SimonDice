using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SimonDice
{
    public partial class MenuPrincipal : Form
    {
        bool musicaM;
        bool PantallaCompleta;
        FormJuego PantallaSimon;
        SoundPlayer MusicaMenu;
        FormConfiguracion PantallaConfiguracion;
        public bool PantallaCompleta1 { get => PantallaCompleta; set => PantallaCompleta = GetValue(value); }
        public bool MusicaM { get => musicaM; set => musicaM = value; }

        private static bool GetValue(bool value)
        {
            return value;
        }

        public MenuPrincipal()
        {
            MusicaMenu = new SoundPlayer(Properties.Resources.main);
            this.musicaM = true;
            this.PantallaCompleta = false;
            PantallaSimon = new FormJuego(this);
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MusicaMenu.Stop();
            PantallaSimon.Close();
            this.Close();
        }

        private void Button_Opciones_Click(object sender, EventArgs e) //Creamos la ventana de configuracion con las opciones pertinentes
        {
           PantallaConfiguracion= new FormConfiguracion(this, MusicaMenu,musicaM,PantallaCompleta);
            PantallaConfiguracion.Show();
            if (PantallaCompleta1){
                PantallaConfiguracion.WindowState = FormWindowState.Maximized;
            }
            else
            {
                PantallaConfiguracion.WindowState = FormWindowState.Normal;
            }

            this.Hide();
        }

        

        private void Button_play_Click(object sender, EventArgs e) //Iniciamos la pantalla del juego y ocultamos la actual
        {
            MusicaMenu.Stop();
            PantallaSimon.Show();
            this.Hide();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (PantallaCompleta)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
            if (musicaM)
            {
                MusicaMenu.Play();

            }
            else
            {
                MusicaMenu.Stop();
            }

        }

        private void MenuPrincipal_VisibleChanged(object sender, EventArgs e) //cada vez que activemos la ventana comprobamos los parámetros
        {
            if (PantallaCompleta)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
            if (musicaM)
            {
                MusicaMenu.Play();

            }
            else
            {
                MusicaMenu.Stop();
            }
        }
    }
}
