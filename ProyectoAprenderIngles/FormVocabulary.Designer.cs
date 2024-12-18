namespace ProyectoAprenderIngles
{
    partial class FormVocabulary
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            answerA1 = new Label();
            AnswerA2 = new Label();
            AnswerA3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            CorrectAnswerA1 = new TextBox();
            label4 = new Label();
            NextQuestionB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(269, 34);
            label1.Name = "label1";
            label1.Size = new Size(248, 45);
            label1.TabIndex = 0;
            label1.Text = "Vocabulary Quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 130);
            label2.Name = "label2";
            label2.Size = new Size(236, 15);
            label2.TabIndex = 1;
            label2.Text = "¿Cómo se escribe el verbo comer en inglés?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 205);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // answerA1
            // 
            answerA1.AutoSize = true;
            answerA1.Location = new Point(250, 206);
            answerA1.Name = "answerA1";
            answerA1.Size = new Size(23, 15);
            answerA1.TabIndex = 3;
            answerA1.Text = "Eat";
            // 
            // AnswerA2
            // 
            AnswerA2.AutoSize = true;
            AnswerA2.Location = new Point(342, 206);
            AnswerA2.Name = "AnswerA2";
            AnswerA2.Size = new Size(25, 15);
            AnswerA2.TabIndex = 4;
            AnswerA2.Text = "Ate";
            // 
            // AnswerA3
            // 
            AnswerA3.AutoSize = true;
            AnswerA3.Location = new Point(437, 206);
            AnswerA3.Name = "AnswerA3";
            AnswerA3.Size = new Size(30, 15);
            AnswerA3.TabIndex = 5;
            AnswerA3.Text = "Ouit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(510, 161);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 7;
            button1.Text = "Comprobar respuesta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CorrectAnswerA1
            // 
            CorrectAnswerA1.Location = new Point(236, 271);
            CorrectAnswerA1.Name = "CorrectAnswerA1";
            CorrectAnswerA1.Size = new Size(247, 23);
            CorrectAnswerA1.TabIndex = 8;
            CorrectAnswerA1.TextChanged += CorrectAnswerA1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 243);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 9;
            label4.Text = "Respuesta correcta:";
            label4.Click += label4_Click;
            // 
            // NextQuestionB
            // 
            NextQuestionB.Location = new Point(510, 271);
            NextQuestionB.Name = "NextQuestionB";
            NextQuestionB.Size = new Size(125, 23);
            NextQuestionB.TabIndex = 10;
            NextQuestionB.Text = "Siguiente pregunta";
            NextQuestionB.UseVisualStyleBackColor = true;
            NextQuestionB.Click += NextQuestionB_Click;
            // 
            // FormVocabulary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NextQuestionB);
            Controls.Add(label4);
            Controls.Add(CorrectAnswerA1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(AnswerA3);
            Controls.Add(AnswerA2);
            Controls.Add(answerA1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVocabulary";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label answerA1;
        private Label AnswerA2;
        private Label AnswerA3;
        private TextBox textBox1;
        private Button button1;
        private TextBox CorrectAnswerA1;
        private Label label4;
        private Button NextQuestionB;
    }
}