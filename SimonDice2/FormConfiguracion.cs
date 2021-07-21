using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice
{

    public partial class FormConfiguracion : Form
    {

        bool musicaM;
        MenuPrincipal menuPrincipal;
        SoundPlayer MusicaMenu;

        bool PantallaCompleta;

        public FormConfiguracion(MenuPrincipal menu,SoundPlayer MusicaMenu,bool MusicaM,bool PantallaCompleta)
        {
            this.musicaM = MusicaM;
            this.PantallaCompleta = PantallaCompleta;
            this.menuPrincipal = menu;
            this.MusicaMenu = MusicaMenu;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) // si guardamos los parámetros de configuración aplicamos los cambios
        {
            if (checkBoxPantallaC.CheckState==CheckState.Checked)
            {
                
                PantallaCompleta = true;
                menuPrincipal.PantallaCompleta1 = PantallaCompleta;
                menuPrincipal.WindowState = FormWindowState.Maximized;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                PantallaCompleta = false;
                menuPrincipal.PantallaCompleta1 = PantallaCompleta;
                menuPrincipal.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Normal;
                
            }
            if (!checkBoxMusica.Checked)
            {
                musicaM = false;
                menuPrincipal.MusicaM=musicaM;
                MusicaMenu.Stop();

            }
            else
            {
                musicaM = true;
                menuPrincipal.MusicaM = musicaM;
                MusicaMenu.Play();
            }
            

        }


        private void FormConfiguracion_FormClosing(object sender, FormClosingEventArgs e)// si cerramos la ventana volvemos al menú Principal con los nuevos cambios
        {
            this.Hide();
            menuPrincipal.Show();
            if (PantallaCompleta)
            {
                menuPrincipal.WindowState = FormWindowState.Maximized;
            }else
            {
                menuPrincipal.WindowState = FormWindowState.Normal;
            }
        }


        private void FormConfiguracion_VisibleChanged(object sender, EventArgs e) //esto es para asegurarnos de que los checkBox esten activados o no dependiendo de la configuración
        {
            if (PantallaCompleta)
            {
                checkBoxPantallaC.Checked = true;
            }
            else
            {
                checkBoxPantallaC.Checked = false;
            }
            if (musicaM)
            {
                checkBoxMusica.Checked = true;
            }
            else
            {
                checkBoxPantallaC.Checked = false;
            }
        }

    }
}
