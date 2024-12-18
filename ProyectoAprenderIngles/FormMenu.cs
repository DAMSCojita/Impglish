using ProyectoAprenderIngles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wirframe
{
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
            panel1.MouseMove += pictureBox1_MouseMove;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private int clickX, clickY;

        private void button5_Click(object sender, EventArgs e)
        {
            FormWriting writting = new FormWriting();
            AbrirFormhijo(writting);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Quizz
            FormVocabulary vocabulary = new FormVocabulary();
            AbrirFormhijo(vocabulary);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Grammar
            FormGrammar grammar = new FormGrammar();
            AbrirFormhijo(grammar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Listening
            //FormListening listening = new FormListening();
            //AbrirFormhijo(listening);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reading
            //FormReading reading = new FormReading();
            //AbrirFormhijo(reading);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                clickX = e.X;
                clickY = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - clickX);
                this.Top = this.Top + (e.Y - clickY);
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormhijo(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            System.Windows.Forms.Form fh = formhijo as System.Windows.Forms.Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }

    }
}
