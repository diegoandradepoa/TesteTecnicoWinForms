namespace TesteTecnicoWinForms
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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAdicionar = new Button();
            gridViewProdutos = new DataGridView();
            txtPreco = new TextBox();
            btnListar = new Button();
            btnCalcularTotal = new Button();
            btnEditar = new Button();
            btnRemover_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 43);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 106);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Preço do Produto";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(46, 165);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // gridViewProdutos
            // 
            gridViewProdutos.AllowUserToAddRows = false;
            gridViewProdutos.AllowUserToDeleteRows = false;
            gridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProdutos.Location = new Point(46, 241);
            gridViewProdutos.Name = "gridViewProdutos";
            gridViewProdutos.ReadOnly = true;
            gridViewProdutos.Size = new Size(262, 150);
            gridViewProdutos.TabIndex = 5;
            gridViewProdutos.CellClick += gridViewProdutos_CellClick;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(44, 129);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 6;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(285, 59);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(171, 23);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar produtos cadastrados";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.Location = new Point(285, 98);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(101, 23);
            btnCalcularTotal.TabIndex = 8;
            btnCalcularTotal.Text = "Calcular total ";
            btnCalcularTotal.UseVisualStyleBackColor = true;
            btnCalcularTotal.Click += btnCalcularTotal_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(142, 165);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover_Click
            // 
            btnRemover_Click.Location = new Point(233, 165);
            btnRemover_Click.Name = "btnRemover_Click";
            btnRemover_Click.Size = new Size(75, 23);
            btnRemover_Click.TabIndex = 10;
            btnRemover_Click.Text = "Remover";
            btnRemover_Click.UseVisualStyleBackColor = true;
            btnRemover_Click.Click += btnRemover_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover_Click);
            Controls.Add(btnEditar);
            Controls.Add(btnCalcularTotal);
            Controls.Add(btnListar);
            Controls.Add(txtPreco);
            Controls.Add(gridViewProdutos);
            Controls.Add(btnAdicionar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private Button btnAdicionar;
        private DataGridView gridViewProdutos;
        private TextBox txtPreco;
        private Button btnListar;
        private Button btnCalcularTotal;
        private Button btnEditar;
        private Button btnRemover_Click;
    }
}
