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
            this.ContactosGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBoxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactosGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloContacts
            // 
            this.TituloContacts.AutoSize = true;
            this.TituloContacts.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloContacts.Location = new System.Drawing.Point(12, 9);
            this.TituloContacts.Name = "TituloContacts";
            this.TituloContacts.Size = new System.Drawing.Size(165, 59);
            this.TituloContacts.TabIndex = 1;
            this.TituloContacts.Text = "Contacts";
            // 
            // NombreAgregar
            // 
            this.NombreAgregar.AutoSize = true;
            this.NombreAgregar.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreAgregar.Location = new System.Drawing.Point(5, 32);
            this.NombreAgregar.Name = "NombreAgregar";
            this.NombreAgregar.Size = new System.Drawing.Size(156, 18);
            this.NombreAgregar.TabIndex = 3;
            this.NombreAgregar.Text = "Nombre de la persona";
            // 
            // BusquedaContantoCB
            // 
            this.BusquedaContantoCB.FormattingEnabled = true;
            this.BusquedaContantoCB.Location = new System.Drawing.Point(167, 33);
            this.BusquedaContantoCB.Name = "BusquedaContantoCB";
            this.BusquedaContantoCB.Size = new System.Drawing.Size(163, 21);
            this.BusquedaContantoCB.TabIndex = 4;
            // 
            // GroupBoxBusqueda
            // 
            this.GroupBoxBusqueda.Controls.Add(this.BotonBusqueda);
            this.GroupBoxBusqueda.Controls.Add(this.BusquedaContantoCB);
            this.GroupBoxBusqueda.Controls.Add(this.NombreAgregar);
            this.GroupBoxBusqueda.Location = new System.Drawing.Point(14, 77);
            this.GroupBoxBusqueda.Name = "GroupBoxBusqueda";
            this.GroupBoxBusqueda.Size = new System.Drawing.Size(462, 80);
            this.GroupBoxBusqueda.TabIndex = 6;
            this.GroupBoxBusqueda.TabStop = false;
            this.GroupBoxBusqueda.Enter += new System.EventHandler(this.g_Enter);
            // 
            // BotonBusqueda
            // 
            this.BotonBusqueda.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBusqueda.Location = new System.Drawing.Point(336, 32);
            this.BotonBusqueda.Name = "BotonBusqueda";
            this.BotonBusqueda.Size = new System.Drawing.Size(98, 22);
            this.BotonBusqueda.TabIndex = 32;
            this.BotonBusqueda.Text = "Buscar";
            this.BotonBusqueda.UseVisualStyleBackColor = true;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BotonAgregar.Location = new System.Drawing.Point(14, 163);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(98, 22);
            this.BotonAgregar.TabIndex = 33;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BotonCancelar.Location = new System.Drawing.Point(118, 163);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(98, 22);
            this.BotonCancelar.TabIndex = 34;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // ContactosGridView1
            // 
            this.ContactosGridView1.AllowUserToOrderColumns = true;
            this.ContactosGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactosGridView1.Location = new System.Drawing.Point(12, 191);
            this.ContactosGridView1.Name = "ContactosGridView1";
            this.ContactosGridView1.Size = new System.Drawing.Size(464, 312);
            this.ContactosGridView1.TabIndex = 35;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 515);
            this.Controls.Add(this.ContactosGridView1);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.GroupBoxBusqueda);
            this.Controls.Add(this.TituloContacts);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.GroupBoxBusqueda.ResumeLayout(false);
            this.GroupBoxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactosGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView ContactosGridView1;
    }
}