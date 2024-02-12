namespace app_Numero_ingresado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxCalculaer = new System.Windows.Forms.TextBox();
            this.listResultado = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNmultiplicar = new System.Windows.Forms.Button();
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxCalculaer
            // 
            this.TxCalculaer.Location = new System.Drawing.Point(116, 85);
            this.TxCalculaer.Name = "TxCalculaer";
            this.TxCalculaer.Size = new System.Drawing.Size(187, 20);
            this.TxCalculaer.TabIndex = 0;
            this.TxCalculaer.TextChanged += new System.EventHandler(this.TxCalculaer_TextChanged);
            // 
            // listResultado
            // 
            this.listResultado.FormattingEnabled = true;
            this.listResultado.Location = new System.Drawing.Point(116, 127);
            this.listResultado.Name = "listResultado";
            this.listResultado.Size = new System.Drawing.Size(187, 147);
            this.listResultado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calcular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            // 
            // BTNmultiplicar
            // 
            this.BTNmultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNmultiplicar.Location = new System.Drawing.Point(346, 69);
            this.BTNmultiplicar.Name = "BTNmultiplicar";
            this.BTNmultiplicar.Size = new System.Drawing.Size(98, 32);
            this.BTNmultiplicar.TabIndex = 4;
            this.BTNmultiplicar.Text = "Multiplicar";
            this.BTNmultiplicar.UseVisualStyleBackColor = true;
            this.BTNmultiplicar.Click += new System.EventHandler(this.BTNmultiplicar_Click);
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNlimpiar.Location = new System.Drawing.Point(346, 152);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(85, 32);
            this.BTNlimpiar.TabIndex = 5;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = true;
            this.BTNlimpiar.Click += new System.EventHandler(this.BTNlimpiar_Click);
            // 
            // BTNsalir
            // 
            this.BTNsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsalir.Location = new System.Drawing.Point(346, 218);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(85, 32);
            this.BTNsalir.TabIndex = 6;
            this.BTNsalir.Text = "Salir";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tabla De Multiplicacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(480, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.BTNmultiplicar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listResultado);
            this.Controls.Add(this.TxCalculaer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxCalculaer;
        private System.Windows.Forms.ListBox listResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNmultiplicar;
        private System.Windows.Forms.Button BTNlimpiar;
        private System.Windows.Forms.Button BTNsalir;
        private System.Windows.Forms.Label label3;
    }
}

