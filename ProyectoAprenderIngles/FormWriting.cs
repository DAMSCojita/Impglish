using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAprenderIngles
{
    public partial class FormWriting : Form
    {
        // Lista de preguntas
        private List<Question> questions;
        private int currentQuestionIndex; // Índice de la pregunta actual

        public FormWriting()
        {
            InitializeComponent();
           
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;


            // Inicializar las preguntas
            questions = new List<Question>
            {
                new Question
                {
                    QuestionText = "¿Cómo se escribe el verbo comer en inglés?",
                    Answers = new string[] { "Eat", "Ate", "Eaten" },
                    CorrectAnswer = "Eat"
                },
                new Question
                {
                    QuestionText = "¿Cómo se escribe el verbo beber en inglés?",
                    Answers = new string[] { "Drink", "Drove", "Drank" },
                    CorrectAnswer = "Drink"
                },
                new Question
                {
                    QuestionText = "¿Cómo se escribe el verbo cantar en inglés?",
                    Answers = new string[] { "Sing", "Sang", "Song" },  
                    CorrectAnswer = "Sing"  
                },
                new Question
                {
                    QuestionText = "¿Cómo se escribe el verbo correr en inglés?",
                    Answers = new string[] { "Run", "Ran", "Runn" },  
                    CorrectAnswer = "Run"  
                },
                new Question
                {
                    QuestionText = "¿Cómo se escribe el verbo leer en inglés?",
                    Answers = new string[] { "Read", "Red", "Reed" }, 
                    CorrectAnswer = "Read"  
                }
                
            };

            currentQuestionIndex = 0; // Comenzamos con la primera pregunta

            // Llamar al método CenterControls para centrar los controles al cargar el formulario
            CenterControls();

            this.Resize += Form2_Resize;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NextQuestionB.Enabled = false; // Deshabilitar el botón "Next Question" inicialmente
            LoadQuestion(); // Cargar la primera pregunta
        }

        // Método para cargar una nueva pregunta
        private void LoadQuestion()
        {
            var currentQuestion = questions[currentQuestionIndex];

            // Actualizar la etiqueta de la pregunta
            label2.Text = currentQuestion.QuestionText;

            // Actualizar las opciones de respuesta
            answerA1.Text = currentQuestion.Answers[0];
            AnswerA2.Text = currentQuestion.Answers[1];
            AnswerA3.Text = currentQuestion.Answers[2];

            // Limpiar el TextBox de respuestas
            textBox1.Clear();
            CorrectAnswerA1.Text = string.Empty; // Limpiar el texto de la respuesta correcta
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterControls(); // Recalcular las posiciones de los controles
        }

        private void CenterControls()
        {
            // Centrar la etiqueta de título (label1)
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 30;

            // Centrar la pregunta (label2)
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            label2.Top = 130;

            // Centrar las opciones de respuesta (answerA1, AnswerA2, AnswerA3)
            answerA1.Left = (this.ClientSize.Width - 3 * answerA1.Width - 20) / 2;
            answerA1.Top = 200;

            AnswerA2.Left = answerA1.Left + answerA1.Width + 10;
            AnswerA2.Top = answerA1.Top;

            AnswerA3.Left = AnswerA2.Left + AnswerA2.Width + 10;
            AnswerA3.Top = answerA1.Top;

            // Centrar el cuadro de texto de respuesta (textBox1)
            textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
            textBox1.Top = 160;

            // Centrar el botón "Comprobar respuesta" (button1)
            button1.Left = textBox1.Right + 10;
            button1.Top = textBox1.Top;

            // Centrar la etiqueta de respuesta correcta (label4)
            label4.Left = (this.ClientSize.Width - label4.Width) / 2;
            label4.Top = 240;

            // Centrar el cuadro de texto de la respuesta correcta (CorrectAnswerA1)
            CorrectAnswerA1.Left = (this.ClientSize.Width - CorrectAnswerA1.Width) / 2;
            CorrectAnswerA1.Top = 270;

            // Centrar el botón de siguiente pregunta (NextQuestionB)
            NextQuestionB.Left = (this.ClientSize.Width - NextQuestionB.Width) / 2;
            NextQuestionB.Top = 320;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la respuesta correcta de la pregunta actual
            string correctAnswer = questions[currentQuestionIndex].CorrectAnswer;

            // Obtener la respuesta del usuario desde el TextBox
            string userAnswer = textBox1.Text.Trim();

            // Comprobar si la respuesta del usuario es correcta
            if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                // Si la respuesta es correcta, mostrarla en el TextBox CorrectAnswerA1
                CorrectAnswerA1.Text = "You have put the correct answer: " + correctAnswer;

                // Habilitar el botón de "Next question"
                NextQuestionB.Enabled = true;
            }
            else
            {
                // Si la respuesta es incorrecta, mostrar un mensaje en el TextBox CorrectAnswerA1
                CorrectAnswerA1.Text = "Incorrect, try again.";
            }
        }

        // Clase para almacenar la información de una pregunta
        public class Question
        {
            public string QuestionText { get; set; } // Texto de la pregunta
            public string[] Answers { get; set; }    // Opciones de respuesta
            public string CorrectAnswer { get; set; } // Respuesta correcta
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CorrectAnswerA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextQuestionB_Click(object sender, EventArgs e)
        {
            // Avanzar al siguiente índice de pregunta
            currentQuestionIndex++;

            // Verificar si hay más preguntas
            if (currentQuestionIndex < questions.Count)
            {
                // Cargar la siguiente pregunta
                LoadQuestion();

                // Deshabilitar el botón de "Next question" para que se habilite solo después de responder correctamente
                NextQuestionB.Enabled = false;
            }
            else
            {
                // No hay más preguntas, terminar el quiz o mostrar un mensaje
                MessageBox.Show("Quiz complete!");
            }
        }
    }
}
