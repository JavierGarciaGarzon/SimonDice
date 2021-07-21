using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonDice
{
    public partial class FormJuego : Form
    {
        MenuPrincipal MenuPrincipal;
        
        int ControlSencuencia = 0;                //contador de Secuencia
        Random NumeroAleatorio;                  //Random   
        int tiempo=300;                         //tiempo de reproducción de los sonidos
        List<int> SimonDice = new List<int>(); //Secuencia de números
        bool Hablando = false;

        public FormJuego(MenuPrincipal Menu)
        {
            InitializeComponent();
            NumeroAleatorio = new Random();
            MenuPrincipal = Menu;
        }
        public void IniciarJuego() { // reproduce la secuencia actual de SIMON

            Hablando = true;
            foreach (int ParteActiva in SimonDice)
            {

                switch (ParteActiva)
                {
                    case 0:
                        p_0.Image = Properties.Resources.a_on;
                        ReproducirMusica("0");
                        p_0.Image = Properties.Resources.a;

                        break;
                    case 1:
                        p_1.Image = Properties.Resources.b_on;
                        ReproducirMusica("1");
                        p_1.Image = Properties.Resources.b;
                        break;
                    case 2:
                        p_2.Image = Properties.Resources.c_on;
                        ReproducirMusica("2");
                        p_2.Image = Properties.Resources.c;
                        break;
                    case 3:
                        p_3.Image = Properties.Resources.d_on;
                        ReproducirMusica("3");
                        p_3.Image = Properties.Resources.d;
                        break;
                }
              
                
            }
            Thread.Sleep(tiempo);
            Hablando = false;
            
        }
        public void VerificarBotonPresionado(int ValorBoton) { //comprobamos cada boton es el correcto de la secuencia
            if (Hablando || SimonDice.Count == 0) return;
            if (SimonDice[ControlSencuencia] == ValorBoton) ControlSencuencia++;
            else {  //en caso de que no coincida mostramos Resultado final
                MessageBox.Show("Tu Puntuación Final es:" + SimonDice.Count);
                ControlSencuencia = 0;
                SimonDice.Clear();
                SimonDice = new List<int>();
                Hablando = false;
               
            }
            if(ControlSencuencia>=SimonDice.Count){ //si acertamos añadimos un nuevo sonido a la secuencia e iniciamos la reproducción
                
                ControlSencuencia = 0;
                SimonDice.Add(NumeroAleatorio.Next(0, 4));
                Thread.Sleep(tiempo*2);
                new Thread(IniciarJuego).Start();
            }
            lbl_puntaje.Text = SimonDice.Count.ToString();
        }

        private void btn_iniciar_Click(object sender, EventArgs e) //Sirve para iniciar el juego la primera vez
        {
            if (!Hablando && SimonDice.Count==0)
            {
                SimonDice.Add(NumeroAleatorio.Next(0, 4));
                new Thread(IniciarJuego).Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
           
           
        }

        private void p_0_Click(object sender, EventArgs e)
        {
            String Presionado = ((PictureBox)sender).Name;
            string[] NumeroBoton = Presionado.Split('_');
            VerificarBotonPresionado(Convert.ToInt32( NumeroBoton[1]));
        }

        private void p_0_MouseDown(object sender, MouseEventArgs e) //Siempre que presionemos un botón cambiamos su imagen por la de presionado y reproducimos el sonido correspondiente
        {
            if (!Hablando)
            {
                p_0.Image = Properties.Resources.a_on;
                ReproducirMusica("0");
            }
        }

        private void p_0_MouseUp(object sender, MouseEventArgs e) //Restauramos la imagen inicial una vez hayamos terminado de presionar
        {
            p_0.Image = Properties.Resources.a;
        }

        private void p_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Hablando)
            {
                p_1.Image = Properties.Resources.b_on;
                 ReproducirMusica("1");
            }
        }

        private void p_1_MouseUp(object sender, MouseEventArgs e)
        {
            p_1.Image = Properties.Resources.b;   
        }

        private void p_2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Hablando)
            {
                p_2.Image = Properties.Resources.c_on;
                ReproducirMusica("2");
            }
        }

        private void p_2_MouseUp(object sender, MouseEventArgs e)
        {
            p_2.Image = Properties.Resources.c;
        }

        private void p_3_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Hablando)
            {
                p_3.Image = Properties.Resources.d_on;
                ReproducirMusica("3");
            }
        }

        private void p_3_MouseUp(object sender, MouseEventArgs e)
        {
            p_3.Image = Properties.Resources.d;
        }
        public void ReproducirMusica(String cancion) { //función para reproducir el sonido dependiendo del botón
            Hablando = true;
            switch (cancion)
            {
                case "0":
                    
                    SoundPlayer sndplayr = new SoundPlayer(Properties.Resources.Button1);
                    sndplayr.Play();
                    Thread.Sleep(tiempo);
                    sndplayr.Stop();
                    break;
                case "1":
                    SoundPlayer sndplayr2 = new SoundPlayer(Properties.Resources.Button2);
                    sndplayr2.Play();
                    Thread.Sleep(tiempo);
                    sndplayr2.Stop();
                    break;
                case "2":
                    SoundPlayer sndplayr3 = new SoundPlayer(Properties.Resources.Button3);
                    sndplayr3.Play();
                    Thread.Sleep(tiempo);
                    sndplayr3.Stop();
                    break;
                case "3":
                    SoundPlayer sndplayr4 = new SoundPlayer(Properties.Resources.Button4);
                    sndplayr4.Play();
                    Thread.Sleep(tiempo);
                    sndplayr4.Stop();
                    break;
            }
            Hablando = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //Si cerramos la ventana abrimos el menu
        {
            this.Hide();
            MenuPrincipal.Show();
        }

        private void FormJuego_VisibleChanged(object sender, EventArgs e) //Siempre comprobamos los parametros una vez la pantalla este activa para ver si han cambiado.
        {
            if (MenuPrincipal.PantallaCompleta1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }
    }
}
