﻿namespace Steganografia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalitàDiSalvataggioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DecodificaButton = new System.Windows.Forms.Button();
            this.testoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InserisciButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.testToolStripMenuItem.Text = "Inserimento da File";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // impostazioniToolStripMenuItem
            // 
            this.impostazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modalitàDiSalvataggioToolStripMenuItem});
            this.impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            this.impostazioniToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.impostazioniToolStripMenuItem.Text = "Impostazioni";
            // 
            // modalitàDiSalvataggioToolStripMenuItem
            // 
            this.modalitàDiSalvataggioToolStripMenuItem.Name = "modalitàDiSalvataggioToolStripMenuItem";
            this.modalitàDiSalvataggioToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.modalitàDiSalvataggioToolStripMenuItem.Text = "Modalità di salvataggio";
            this.modalitàDiSalvataggioToolStripMenuItem.ToolTipText = "Salva solo pixel modificati o intera immagine, default intera";
            this.modalitàDiSalvataggioToolStripMenuItem.Click += new System.EventHandler(this.modalitàDiSalvataggioToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impostazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 276);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 90);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Testo Desteganografato";
            // 
            // DecodificaButton
            // 
            this.DecodificaButton.Location = new System.Drawing.Point(25, 192);
            this.DecodificaButton.Name = "DecodificaButton";
            this.DecodificaButton.Size = new System.Drawing.Size(117, 46);
            this.DecodificaButton.TabIndex = 4;
            this.DecodificaButton.Text = "Decodifica";
            this.DecodificaButton.UseVisualStyleBackColor = true;
            this.DecodificaButton.Click += new System.EventHandler(this.DecodificaButton_Click);
            // 
            // testoTextBox
            // 
            this.testoTextBox.Location = new System.Drawing.Point(25, 142);
            this.testoTextBox.Multiline = true;
            this.testoTextBox.Name = "testoTextBox";
            this.testoTextBox.Size = new System.Drawing.Size(117, 35);
            this.testoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserire il testo da camuffare";
            // 
            // InserisciButton
            // 
            this.InserisciButton.ContextMenuStrip = this.contextMenuStrip1;
            this.InserisciButton.Location = new System.Drawing.Point(25, 48);
            this.InserisciButton.Name = "InserisciButton";
            this.InserisciButton.Size = new System.Drawing.Size(117, 64);
            this.InserisciButton.TabIndex = 1;
            this.InserisciButton.Text = "Inserisci immagine\r\nClick destro per inserimento da file";
            this.InserisciButton.UseVisualStyleBackColor = true;
            this.InserisciButton.Click += new System.EventHandler(this.InserisciButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(705, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DecodificaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testoTextBox);
            this.Controls.Add(this.InserisciButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem impostazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalitàDiSalvataggioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DecodificaButton;
        private System.Windows.Forms.TextBox testoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InserisciButton;
    }
}

