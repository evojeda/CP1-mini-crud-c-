namespace MiniCRUDProdutosUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            btnCadastrar = new Button();
            lstProdutos = new ListBox();
            btnBuscar = new Button();
            btnAtualizar = new Button();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 84);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Preço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 113);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantidade:";
            // 
            // txtId
            // 
            txtId.Location = new Point(61, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(129, 23);
            txtId.TabIndex = 4;
            txtId.Text = "T";
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(61, 52);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(129, 23);
            txtNome.TabIndex = 5;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(61, 81);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(129, 23);
            txtPreco.TabIndex = 6;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(90, 110);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.GradientInactiveCaption;
            btnCadastrar.Location = new Point(12, 139);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(178, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar Produto";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Location = new Point(12, 180);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(345, 139);
            lstProdutos.TabIndex = 9;
            lstProdutos.SelectedIndexChanged += lstProdutos_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(242, 81);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "🔍 Buscar Produto";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(242, 110);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(115, 23);
            btnAtualizar.TabIndex = 11;
            btnAtualizar.Text = "Atualizar Estoque";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(242, 139);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(115, 23);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular Total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(btnAtualizar);
            Controls.Add(btnBuscar);
            Controls.Add(lstProdutos);
            Controls.Add(btnCadastrar);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mini CRUD de Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private Button btnCadastrar;
        private ListBox lstProdutos;
        private Button btnBuscar;
        private Button btnAtualizar;
        private Button btnCalcular;
    }
}