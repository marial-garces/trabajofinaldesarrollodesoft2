namespace proyecto_final
{
    partial class Entrada
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
            this.TituloContacts = new System.Windows.Forms.Label();
            this.NombreAgregar = new System.Windows.Forms.Label();
            this.BusquedaContantoCB = new System.Windows.Forms.ComboBox();
            this.GroupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.BotonBusqueda = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.GroupBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // TituloContacts
            // 
            this.TituloContacts.AutoSize = true;
            this.TituloContacts.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloContacts.Location = new System.Drawing.Point(130, 46);
            this.TituloContacts.Name = "TituloContacts";
            this.TituloContacts.Size = new System.Drawing.Size(229, 59);
            this.TituloContacts.TabIndex = 1;
            this.TituloContacts.Text = "Contacts List";
            // 
            // NombreAgregar
            // 
            this.NombreAgregar.AutoSize = true;
            this.NombreAgregar.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAgregar.Location = new System.Drawing.Point(91, 62);
            this.NombreAgregar.Name = "NombreAgregar";
            this.NombreAgregar.Size = new System.Drawing.Size(277, 42);
            this.NombreAgregar.TabIndex = 3;
            this.NombreAgregar.Text = "Nombre de la persona";
            // 
            // BusquedaContantoCB
            // 
            this.BusquedaContantoCB.FormattingEnabled = true;
            this.BusquedaContantoCB.Location = new System.Drawing.Point(136, 118);
            this.BusquedaContantoCB.Name = "BusquedaContantoCB";
            this.BusquedaContantoCB.Size = new System.Drawing.Size(163, 21);
            this.BusquedaContantoCB.TabIndex = 4;
            this.BusquedaContantoCB.SelectedIndexChanged += new System.EventHandler(this.BusquedaContantoCB_SelectedIndexChanged);
            // 
            // GroupBoxBusqueda
            // 
            this.GroupBoxBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupBoxBusqueda.Controls.Add(this.BotonBusqueda);
            this.GroupBoxBusqueda.Controls.Add(this.BusquedaContantoCB);
            this.GroupBoxBusqueda.Controls.Add(this.NombreAgregar);
            this.GroupBoxBusqueda.Location = new System.Drawing.Point(16, 108);
            this.GroupBoxBusqueda.Name = "GroupBoxBusqueda";
            this.GroupBoxBusqueda.Size = new System.Drawing.Size(462, 278);
            this.GroupBoxBusqueda.TabIndex = 6;
            this.GroupBoxBusqueda.TabStop = false;
            this.GroupBoxBusqueda.Enter += new System.EventHandler(this.g_Enter);
            // 
            // BotonBusqueda
            // 
            this.BotonBusqueda.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BotonBusqueda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBusqueda.Location = new System.Drawing.Point(124, 156);
            this.BotonBusqueda.Name = "BotonBusqueda";
            this.BotonBusqueda.Size = new System.Drawing.Size(186, 46);
            this.BotonBusqueda.TabIndex = 32;
            this.BotonBusqueda.Text = "Buscar";
            this.BotonBusqueda.UseVisualStyleBackColor = false;
            this.BotonBusqueda.Click += new System.EventHandler(this.BotonBusqueda_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.BotonAgregar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.Location = new System.Drawing.Point(22, 408);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(207, 58);
            this.BotonAgregar.TabIndex = 33;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.BackColor = System.Drawing.Color.LightGreen;
            this.BotonCancelar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCancelar.Location = new System.Drawing.Point(253, 408);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(211, 58);
            this.BotonCancelar.TabIndex = 34;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = false;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(490, 515);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.GroupBoxBusqueda);
            this.Controls.Add(this.TituloContacts);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.GroupBoxBusqueda.ResumeLayout(false);
            this.GroupBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloContacts;
        private System.Windows.Forms.Label NombreAgregar;
        private System.Windows.Forms.ComboBox BusquedaContantoCB;
        private System.Windows.Forms.GroupBox GroupBoxBusqueda;
        private System.Windows.Forms.Button BotonBusqueda;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonCancelar;
    }
}