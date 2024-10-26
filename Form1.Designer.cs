namespace Atividade_7___Calculado__RadioButton_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rbDivisao = new RadioButton();
            rbMultiplicacao = new RadioButton();
            rbSubtracao = new RadioButton();
            rbAdicao = new RadioButton();
            btnCalcular = new Button();
            lblResultado = new Label();
            txtValor2 = new TextBox();
            label2 = new Label();
            txtValor1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbDivisao);
            groupBox1.Controls.Add(rbMultiplicacao);
            groupBox1.Controls.Add(rbSubtracao);
            groupBox1.Controls.Add(rbAdicao);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(txtValor2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtValor1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 306);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbDivisao
            // 
            rbDivisao.AutoSize = true;
            rbDivisao.Location = new Point(124, 196);
            rbDivisao.Name = "rbDivisao";
            rbDivisao.Size = new Size(59, 19);
            rbDivisao.TabIndex = 9;
            rbDivisao.TabStop = true;
            rbDivisao.Text = "Dividir";
            rbDivisao.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacao
            // 
            rbMultiplicacao.AutoSize = true;
            rbMultiplicacao.Location = new Point(25, 196);
            rbMultiplicacao.Name = "rbMultiplicacao";
            rbMultiplicacao.Size = new Size(82, 19);
            rbMultiplicacao.TabIndex = 8;
            rbMultiplicacao.TabStop = true;
            rbMultiplicacao.Text = "Multiplicar";
            rbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbSubtracao
            // 
            rbSubtracao.AutoSize = true;
            rbSubtracao.Location = new Point(124, 147);
            rbSubtracao.Name = "rbSubtracao";
            rbSubtracao.Size = new Size(66, 19);
            rbSubtracao.TabIndex = 7;
            rbSubtracao.TabStop = true;
            rbSubtracao.Text = "Subtrair";
            rbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbAdicao
            // 
            rbAdicao.AutoSize = true;
            rbAdicao.Location = new Point(25, 147);
            rbAdicao.Name = "rbAdicao";
            rbAdicao.Size = new Size(59, 19);
            rbAdicao.TabIndex = 6;
            rbAdicao.TabStop = true;
            rbAdicao.Text = "Somar";
            rbAdicao.UseVisualStyleBackColor = true;
            rbAdicao.CheckedChanged += rbAdicao_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(38, 267);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(131, 271);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(90, 55);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 58);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Digite Valor 2";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(90, 8);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite Valor 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 330);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculadora (RadioButton)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private RadioButton rbDivisao;
        private RadioButton rbMultiplicacao;
        private RadioButton rbSubtracao;
        private RadioButton rbAdicao;
        private Button btnCalcular;
        private Label lblResultado;
        private TextBox txtValor2;
        private Label label2;
        private TextBox txtValor1;
    }
}
