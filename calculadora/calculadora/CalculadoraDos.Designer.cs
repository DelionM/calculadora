namespace calculadora
{
    partial class CalculadoraDos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraDos));
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblEstatico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Items.AddRange(new object[] {
            "Multiplicación",
            "Suma",
            "Resta",
            "División"});
            this.cmbFigura.Location = new System.Drawing.Point(142, 40);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 21);
            this.cmbFigura.TabIndex = 0;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.cmbFigura_SelectedIndexChanged);
            // 
            // txtPantalla
            // 
            this.txtPantalla.Location = new System.Drawing.Point(13, 40);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(100, 20);
            this.txtPantalla.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(78, 129);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "0";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // lblEstatico
            // 
            this.lblEstatico.AutoSize = true;
            this.lblEstatico.Location = new System.Drawing.Point(28, 94);
            this.lblEstatico.Name = "lblEstatico";
            this.lblEstatico.Size = new System.Drawing.Size(155, 13);
            this.lblEstatico.TabIndex = 3;
            this.lblEstatico.Text = "El resultado de la operación es:";
            // 
            // CalculadoraDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblEstatico);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.cmbFigura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculadoraDos";
            this.Text = "CalculadoraDos";
            this.Load += new System.EventHandler(this.CalculadoraDos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblEstatico;
    }
}