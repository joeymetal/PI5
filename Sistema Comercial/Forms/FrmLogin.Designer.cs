namespace Sistema_Comercial
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tipoUsuarioLabel;
            System.Windows.Forms.Label senhaUsuarioLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label codigoUsuarioLabel;
            System.Windows.Forms.Label nomeUsuarioLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tblUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblUsuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tipoUsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.senhaUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nomeUsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.codigoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            tipoUsuarioLabel = new System.Windows.Forms.Label();
            senhaUsuarioLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            codigoUsuarioLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingNavigator)).BeginInit();
            this.tblUsuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoUsuarioLabel
            // 
            tipoUsuarioLabel.AutoSize = true;
            tipoUsuarioLabel.Location = new System.Drawing.Point(56, 85);
            tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            tipoUsuarioLabel.Size = new System.Drawing.Size(70, 13);
            tipoUsuarioLabel.TabIndex = 21;
            tipoUsuarioLabel.Text = "Tipo Usuario:";
            // 
            // senhaUsuarioLabel
            // 
            senhaUsuarioLabel.AutoSize = true;
            senhaUsuarioLabel.Location = new System.Drawing.Point(55, 47);
            senhaUsuarioLabel.Name = "senhaUsuarioLabel";
            senhaUsuarioLabel.Size = new System.Drawing.Size(80, 13);
            senhaUsuarioLabel.TabIndex = 19;
            senhaUsuarioLabel.Text = "Senha Usuario:";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(56, 14);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(77, 13);
            nomeUsuarioLabel.TabIndex = 17;
            nomeUsuarioLabel.Text = "Nome Usuario:";
            // 
            // codigoUsuarioLabel
            // 
            codigoUsuarioLabel.AutoSize = true;
            codigoUsuarioLabel.Location = new System.Drawing.Point(15, 29);
            codigoUsuarioLabel.Name = "codigoUsuarioLabel";
            codigoUsuarioLabel.Size = new System.Drawing.Size(82, 13);
            codigoUsuarioLabel.TabIndex = 1;
            codigoUsuarioLabel.Text = "Codigo Usuario:";
            // 
            // nomeUsuarioLabel1
            // 
            nomeUsuarioLabel1.AutoSize = true;
            nomeUsuarioLabel1.Location = new System.Drawing.Point(20, 62);
            nomeUsuarioLabel1.Name = "nomeUsuarioLabel1";
            nomeUsuarioLabel1.Size = new System.Drawing.Size(77, 13);
            nomeUsuarioLabel1.TabIndex = 3;
            nomeUsuarioLabel1.Text = "Nome Usuario:";
            // 
            // tblUsuarioBindingSource
            // 
            this.tblUsuarioBindingSource.DataMember = "tblUsuario";
            // 
            // tblUsuarioBindingNavigator
            // 
            this.tblUsuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblUsuarioBindingNavigator.BindingSource = this.tblUsuarioBindingSource;
            this.tblUsuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblUsuarioBindingNavigator.CountItemFormat = "de {0}";
            this.tblUsuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblUsuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblUsuarioBindingNavigatorSaveItem,
            this.toolStripProgressBar1});
            this.tblUsuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblUsuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblUsuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblUsuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblUsuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblUsuarioBindingNavigator.Name = "tblUsuarioBindingNavigator";
            this.tblUsuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblUsuarioBindingNavigator.Size = new System.Drawing.Size(580, 25);
            this.tblUsuarioBindingNavigator.TabIndex = 0;
            this.tblUsuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Inicio";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Proximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover para ultimo";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblUsuarioBindingNavigatorSaveItem
            // 
            this.tblUsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblUsuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblUsuarioBindingNavigatorSaveItem.Image")));
            this.tblUsuarioBindingNavigatorSaveItem.Name = "tblUsuarioBindingNavigatorSaveItem";
            this.tblUsuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblUsuarioBindingNavigatorSaveItem.Text = "Salvar";
            this.tblUsuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblUsuarioBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // tblUsuarioDataGridView
            // 
            this.tblUsuarioDataGridView.AutoGenerateColumns = false;
            this.tblUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblUsuarioDataGridView.DataSource = this.tblUsuarioBindingSource;
            this.tblUsuarioDataGridView.Location = new System.Drawing.Point(70, 234);
            this.tblUsuarioDataGridView.Name = "tblUsuarioDataGridView";
            this.tblUsuarioDataGridView.Size = new System.Drawing.Size(445, 220);
            this.tblUsuarioDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoUsuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeUsuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomeUsuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SenhaUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "SenhaUsuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoUsuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoUsuario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(tipoUsuarioLabel);
            this.groupBox1.Controls.Add(this.tipoUsuarioComboBox);
            this.groupBox1.Controls.Add(senhaUsuarioLabel);
            this.groupBox1.Controls.Add(this.senhaUsuarioTextBox);
            this.groupBox1.Controls.Add(nomeUsuarioLabel);
            this.groupBox1.Controls.Add(this.nomeUsuarioTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 174);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Usuario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tipoUsuarioComboBox
            // 
            this.tipoUsuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "TipoUsuario", true));
            this.tipoUsuarioComboBox.FormattingEnabled = true;
            this.tipoUsuarioComboBox.Location = new System.Drawing.Point(139, 77);
            this.tipoUsuarioComboBox.Name = "tipoUsuarioComboBox";
            this.tipoUsuarioComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoUsuarioComboBox.TabIndex = 22;
            // 
            // senhaUsuarioTextBox
            // 
            this.senhaUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "SenhaUsuario", true));
            this.senhaUsuarioTextBox.Location = new System.Drawing.Point(141, 44);
            this.senhaUsuarioTextBox.Name = "senhaUsuarioTextBox";
            this.senhaUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaUsuarioTextBox.TabIndex = 20;
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "NomeUsuario", true));
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(139, 11);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeUsuarioTextBox.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nomeUsuarioLabel1);
            this.groupBox2.Controls.Add(this.nomeUsuarioTextBox1);
            this.groupBox2.Controls.Add(codigoUsuarioLabel);
            this.groupBox2.Controls.Add(this.codigoUsuarioTextBox);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(333, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 147);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // nomeUsuarioTextBox1
            // 
            this.nomeUsuarioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsuarioBindingSource, "NomeUsuario", true));
            this.nomeUsuarioTextBox1.Location = new System.Drawing.Point(103, 59);
            this.nomeUsuarioTextBox1.Name = "nomeUsuarioTextBox1";
            this.nomeUsuarioTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nomeUsuarioTextBox1.TabIndex = 4;
            // 
            // codigoUsuarioTextBox
            // 
            this.codigoUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsuarioBindingSource, "CodigoUsuario", true));
            this.codigoUsuarioTextBox.Location = new System.Drawing.Point(103, 26);
            this.codigoUsuarioTextBox.Name = "codigoUsuarioTextBox";
            this.codigoUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoUsuarioTextBox.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblUsuarioDataGridView);
            this.Controls.Add(this.tblUsuarioBindingNavigator);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioBindingNavigator)).EndInit();
            this.tblUsuarioBindingNavigator.ResumeLayout(false);
            this.tblUsuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsuarioDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblUsuarioBindingSource;
        private System.Windows.Forms.BindingNavigator tblUsuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblUsuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView tblUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tipoUsuarioComboBox;
        private System.Windows.Forms.TextBox senhaUsuarioTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox1;
        private System.Windows.Forms.TextBox codigoUsuarioTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;

    }
}