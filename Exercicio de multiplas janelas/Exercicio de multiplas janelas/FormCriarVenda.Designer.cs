﻿namespace Exercicio_de_multiplas_janelas
{
    partial class FormCriarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCriarVenda));
            textBoxTotalComDesconto = new TextBox();
            textBoxValorTotal = new TextBox();
            textBoxPrecoUnitario = new TextBox();
            comboBoxCliente = new ComboBox();
            comboBoxProduto = new ComboBox();
            numericUpDownDesconto = new NumericUpDown();
            numericUpDownQuantidade = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // textBoxTotalComDesconto
            // 
            textBoxTotalComDesconto.BackColor = SystemColors.ControlDarkDark;
            textBoxTotalComDesconto.ForeColor = Color.White;
            textBoxTotalComDesconto.Location = new Point(181, 241);
            textBoxTotalComDesconto.Name = "textBoxTotalComDesconto";
            textBoxTotalComDesconto.ReadOnly = true;
            textBoxTotalComDesconto.Size = new Size(200, 23);
            textBoxTotalComDesconto.TabIndex = 6;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.BackColor = SystemColors.ControlDarkDark;
            textBoxValorTotal.ForeColor = Color.White;
            textBoxValorTotal.Location = new Point(181, 204);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.ReadOnly = true;
            textBoxValorTotal.Size = new Size(200, 23);
            textBoxValorTotal.TabIndex = 5;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.BackColor = SystemColors.ControlDarkDark;
            textBoxPrecoUnitario.ForeColor = Color.White;
            textBoxPrecoUnitario.Location = new Point(181, 165);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.ReadOnly = true;
            textBoxPrecoUnitario.Size = new Size(200, 23);
            textBoxPrecoUnitario.TabIndex = 4;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(181, 58);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(200, 23);
            comboBoxCliente.TabIndex = 1;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(181, 12);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(200, 23);
            comboBoxProduto.TabIndex = 0;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDownDesconto.Location = new Point(181, 125);
            numericUpDownDesconto.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(200, 23);
            numericUpDownDesconto.TabIndex = 3;
            numericUpDownDesconto.ValueChanged += numericUpDownDesconto_ValueChanged;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDownQuantidade.Location = new Point(181, 93);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(200, 23);
            numericUpDownQuantidade.TabIndex = 2;
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 249);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 10;
            label6.Text = "Total Com Desconto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 173);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 11;
            label7.Text = "Preço Unitário:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 212);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 12;
            label5.Text = "Valor Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 133);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 13;
            label4.Text = "Desconto (%):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 14;
            label3.Text = "Quantidade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 58);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 15;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 9;
            label1.Text = "Produto:";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(290, 281);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(131, 281);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormCriarVenda
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = buttonCancelar;
            ClientSize = new Size(393, 316);
            Controls.Add(textBoxTotalComDesconto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(comboBoxCliente);
            Controls.Add(comboBoxProduto);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Name = "FormCriarVenda";
            Text = "FormCriarVenda";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTotalComDesconto;
        private TextBox textBoxValorTotal;
        private TextBox textBoxPrecoUnitario;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxProduto;
        private NumericUpDown numericUpDownDesconto;
        private NumericUpDown numericUpDownQuantidade;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonOk;
    }
}