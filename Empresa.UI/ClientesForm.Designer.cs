namespace Empresa.UI.Windows
{
    partial class ClientesForm
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            novoButton = new Button();
            alterarButton = new Button();
            excluirButton = new Button();
            sairbutton = new Button();
            confirmarInclusaoButton = new Button();
            confirmarAlteracaoButton = new Button();
            confirmarExclusaoButton = new Button();
            voltarButton = new Button();
            conteudoPanel = new Panel();
            fichaPanel = new Panel();
            telefoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            nomeTextBox = new TextBox();
            idTextBox = new TextBox();
            telefoneLabel = new Label();
            emailLabel = new Label();
            nomeLabel = new Label();
            idLabel = new Label();
            listaDataGridView = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            conteudoPanel.SuspendLayout();
            fichaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 358);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 92);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(novoButton);
            flowLayoutPanel1.Controls.Add(alterarButton);
            flowLayoutPanel1.Controls.Add(excluirButton);
            flowLayoutPanel1.Controls.Add(sairbutton);
            flowLayoutPanel1.Controls.Add(confirmarInclusaoButton);
            flowLayoutPanel1.Controls.Add(confirmarAlteracaoButton);
            flowLayoutPanel1.Controls.Add(confirmarExclusaoButton);
            flowLayoutPanel1.Controls.Add(voltarButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(824, 92);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // novoButton
            // 
            novoButton.Location = new Point(13, 23);
            novoButton.Name = "novoButton";
            novoButton.Size = new Size(94, 29);
            novoButton.TabIndex = 0;
            novoButton.Text = "Novo";
            novoButton.UseVisualStyleBackColor = true;
            novoButton.Click += novoButton_Click;
            // 
            // alterarButton
            // 
            alterarButton.Location = new Point(113, 23);
            alterarButton.Name = "alterarButton";
            alterarButton.Size = new Size(94, 29);
            alterarButton.TabIndex = 1;
            alterarButton.Text = "Alterar";
            alterarButton.UseVisualStyleBackColor = true;
            alterarButton.Click += alterarButton_Click;
            // 
            // excluirButton
            // 
            excluirButton.Location = new Point(213, 23);
            excluirButton.Name = "excluirButton";
            excluirButton.Size = new Size(94, 29);
            excluirButton.TabIndex = 2;
            excluirButton.Text = "Excluir";
            excluirButton.UseVisualStyleBackColor = true;
            excluirButton.Click += excluirButton_Click;
            // 
            // sairbutton
            // 
            sairbutton.Location = new Point(313, 23);
            sairbutton.Name = "sairbutton";
            sairbutton.Size = new Size(94, 29);
            sairbutton.TabIndex = 3;
            sairbutton.Text = "Sair";
            sairbutton.UseVisualStyleBackColor = true;
            sairbutton.Click += sairbutton_Click;
            // 
            // confirmarInclusaoButton
            // 
            confirmarInclusaoButton.Location = new Point(413, 23);
            confirmarInclusaoButton.Name = "confirmarInclusaoButton";
            confirmarInclusaoButton.Size = new Size(94, 29);
            confirmarInclusaoButton.TabIndex = 4;
            confirmarInclusaoButton.Text = "Gravar";
            confirmarInclusaoButton.UseVisualStyleBackColor = true;
            confirmarInclusaoButton.Click += confirmarInclusaoButton_Click;
            // 
            // confirmarAlteracaoButton
            // 
            confirmarAlteracaoButton.Location = new Point(513, 23);
            confirmarAlteracaoButton.Name = "confirmarAlteracaoButton";
            confirmarAlteracaoButton.Size = new Size(94, 29);
            confirmarAlteracaoButton.TabIndex = 5;
            confirmarAlteracaoButton.Text = "Alterar";
            confirmarAlteracaoButton.UseVisualStyleBackColor = true;
            confirmarAlteracaoButton.Click += confirmarAlteracaoButton_Click;
            // 
            // confirmarExclusaoButton
            // 
            confirmarExclusaoButton.Location = new Point(613, 23);
            confirmarExclusaoButton.Name = "confirmarExclusaoButton";
            confirmarExclusaoButton.Size = new Size(94, 29);
            confirmarExclusaoButton.TabIndex = 6;
            confirmarExclusaoButton.Text = "Excluir";
            confirmarExclusaoButton.UseVisualStyleBackColor = true;
            confirmarExclusaoButton.Click += confirmarExclusaoButton_Click;
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(713, 23);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(94, 29);
            voltarButton.TabIndex = 7;
            voltarButton.Text = "Voltar";
            voltarButton.UseVisualStyleBackColor = true;
            voltarButton.Click += voltarButton_Click;
            // 
            // conteudoPanel
            // 
            conteudoPanel.Controls.Add(fichaPanel);
            conteudoPanel.Controls.Add(listaDataGridView);
            conteudoPanel.Dock = DockStyle.Fill;
            conteudoPanel.Location = new Point(0, 0);
            conteudoPanel.Name = "conteudoPanel";
            conteudoPanel.Padding = new Padding(10);
            conteudoPanel.Size = new Size(824, 358);
            conteudoPanel.TabIndex = 1;
            // 
            // fichaPanel
            // 
            fichaPanel.Controls.Add(telefoneTextBox);
            fichaPanel.Controls.Add(emailTextBox);
            fichaPanel.Controls.Add(nomeTextBox);
            fichaPanel.Controls.Add(idTextBox);
            fichaPanel.Controls.Add(telefoneLabel);
            fichaPanel.Controls.Add(emailLabel);
            fichaPanel.Controls.Add(nomeLabel);
            fichaPanel.Controls.Add(idLabel);
            fichaPanel.Location = new Point(12, 12);
            fichaPanel.Name = "fichaPanel";
            fichaPanel.Size = new Size(384, 333);
            fichaPanel.TabIndex = 1;
            // 
            // telefoneTextBox
            // 
            telefoneTextBox.Location = new Point(107, 159);
            telefoneTextBox.Name = "telefoneTextBox";
            telefoneTextBox.Size = new Size(233, 27);
            telefoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(107, 119);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(233, 27);
            emailTextBox.TabIndex = 6;
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(107, 79);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(233, 27);
            nomeTextBox.TabIndex = 5;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(107, 40);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(233, 27);
            idTextBox.TabIndex = 4;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new Point(22, 156);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Padding = new Padding(5);
            telefoneLabel.Size = new Size(79, 30);
            telefoneLabel.TabIndex = 3;
            telefoneLabel.Text = "Telefone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(22, 116);
            emailLabel.Name = "emailLabel";
            emailLabel.Padding = new Padding(5);
            emailLabel.Size = new Size(59, 30);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(22, 76);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Padding = new Padding(5);
            nomeLabel.Size = new Size(63, 30);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(22, 37);
            idLabel.Name = "idLabel";
            idLabel.Padding = new Padding(5);
            idLabel.Size = new Size(35, 30);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // listaDataGridView
            // 
            listaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaDataGridView.Location = new Point(402, 13);
            listaDataGridView.Name = "listaDataGridView";
            listaDataGridView.RowHeadersWidth = 51;
            listaDataGridView.Size = new Size(405, 332);
            listaDataGridView.TabIndex = 0;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(conteudoPanel);
            Controls.Add(panel1);
            Name = "ClientesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += ClientesForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            conteudoPanel.ResumeLayout(false);
            fichaPanel.ResumeLayout(false);
            fichaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button novoButton;
        private Button alterarButton;
        private Button excluirButton;
        private Button sairbutton;
        private Button confirmarInclusaoButton;
        private Button confirmarAlteracaoButton;
        private Button confirmarExclusaoButton;
        private Panel conteudoPanel;
        private Panel fichaPanel;
        private Label telefoneLabel;
        private Label emailLabel;
        private Label nomeLabel;
        private Label idLabel;
        private DataGridView listaDataGridView;
        private TextBox telefoneTextBox;
        private TextBox emailTextBox;
        private TextBox nomeTextBox;
        private TextBox idTextBox;
        private Button voltarButton;
    }
}