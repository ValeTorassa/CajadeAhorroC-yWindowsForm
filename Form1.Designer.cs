
namespace Valentin.Torassa.Colombero_CajaDeAhorro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datosdgtv = new System.Windows.Forms.DataGridView();
            this.nroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.monedacmb = new System.Windows.Forms.ComboBox();
            this.saldotxt = new System.Windows.Forms.TextBox();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.errorlbl = new System.Windows.Forms.Label();
            this.extraerbtn = new System.Windows.Forms.Button();
            this.depositarbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.extracDepositxt = new System.Windows.Forms.TextBox();
            this.extraclbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.eliminarlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosdgtv)).BeginInit();
            this.SuspendLayout();
            // 
            // datosdgtv
            // 
            this.datosdgtv.AllowUserToAddRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datosdgtv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datosdgtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosdgtv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroCuenta,
            this.titular,
            this.saldo,
            this.moneda});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datosdgtv.DefaultCellStyle = dataGridViewCellStyle12;
            this.datosdgtv.Location = new System.Drawing.Point(30, 104);
            this.datosdgtv.Name = "datosdgtv";
            this.datosdgtv.Size = new System.Drawing.Size(794, 243);
            this.datosdgtv.TabIndex = 0;
            // 
            // nroCuenta
            // 
            this.nroCuenta.HeaderText = "Num de Cuenta";
            this.nroCuenta.Name = "nroCuenta";
            this.nroCuenta.Width = 200;
            // 
            // titular
            // 
            this.titular.HeaderText = "Titular";
            this.titular.Name = "titular";
            this.titular.Width = 200;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "Saldo";
            this.saldo.Name = "saldo";
            this.saldo.Width = 200;
            // 
            // moneda
            // 
            this.moneda.HeaderText = "Tipo Moneda";
            this.moneda.Name = "moneda";
            this.moneda.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Moneda:";
            // 
            // agregarbtn
            // 
            this.agregarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarbtn.Location = new System.Drawing.Point(369, 60);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(115, 38);
            this.agregarbtn.TabIndex = 4;
            this.agregarbtn.Text = "Agregar";
            this.agregarbtn.UseVisualStyleBackColor = true;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // monedacmb
            // 
            this.monedacmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monedacmb.FormattingEnabled = true;
            this.monedacmb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monedacmb.Items.AddRange(new object[] {
            "Peso Argentino",
            "Dolar"});
            this.monedacmb.Location = new System.Drawing.Point(711, 24);
            this.monedacmb.Name = "monedacmb";
            this.monedacmb.Size = new System.Drawing.Size(127, 21);
            this.monedacmb.TabIndex = 5;
            // 
            // saldotxt
            // 
            this.saldotxt.Location = new System.Drawing.Point(414, 25);
            this.saldotxt.Name = "saldotxt";
            this.saldotxt.Size = new System.Drawing.Size(110, 20);
            this.saldotxt.TabIndex = 6;
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(154, 24);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(110, 20);
            this.nombretxt.TabIndex = 7;
            // 
            // errorlbl
            // 
            this.errorlbl.AutoSize = true;
            this.errorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlbl.Location = new System.Drawing.Point(310, 49);
            this.errorlbl.Name = "errorlbl";
            this.errorlbl.Size = new System.Drawing.Size(0, 16);
            this.errorlbl.TabIndex = 8;
            // 
            // extraerbtn
            // 
            this.extraerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraerbtn.Location = new System.Drawing.Point(120, 365);
            this.extraerbtn.Name = "extraerbtn";
            this.extraerbtn.Size = new System.Drawing.Size(115, 45);
            this.extraerbtn.TabIndex = 9;
            this.extraerbtn.Text = "Extraer";
            this.extraerbtn.UseVisualStyleBackColor = true;
            this.extraerbtn.Click += new System.EventHandler(this.extraerbtn_Click);
            // 
            // depositarbtn
            // 
            this.depositarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositarbtn.Location = new System.Drawing.Point(650, 365);
            this.depositarbtn.Name = "depositarbtn";
            this.depositarbtn.Size = new System.Drawing.Size(115, 45);
            this.depositarbtn.TabIndex = 10;
            this.depositarbtn.Text = "Depositar";
            this.depositarbtn.UseVisualStyleBackColor = true;
            this.depositarbtn.Click += new System.EventHandler(this.depositarbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione un usuario y escriba su deposito o extraccion";
            // 
            // extracDepositxt
            // 
            this.extracDepositxt.Location = new System.Drawing.Point(341, 374);
            this.extracDepositxt.Name = "extracDepositxt";
            this.extracDepositxt.Size = new System.Drawing.Size(170, 20);
            this.extracDepositxt.TabIndex = 12;
            // 
            // extraclbl
            // 
            this.extraclbl.AutoSize = true;
            this.extraclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraclbl.Location = new System.Drawing.Point(290, 394);
            this.extraclbl.Name = "extraclbl";
            this.extraclbl.Size = new System.Drawing.Size(0, 16);
            this.extraclbl.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seleccione a un usuario y delo de baja";
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarbtn.Location = new System.Drawing.Point(369, 438);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(115, 38);
            this.eliminarbtn.TabIndex = 15;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // eliminarlbl
            // 
            this.eliminarlbl.AutoSize = true;
            this.eliminarlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarlbl.Location = new System.Drawing.Point(324, 483);
            this.eliminarlbl.Name = "eliminarlbl";
            this.eliminarlbl.Size = new System.Drawing.Size(0, 16);
            this.eliminarlbl.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 508);
            this.Controls.Add(this.eliminarlbl);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.extraclbl);
            this.Controls.Add(this.extracDepositxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depositarbtn);
            this.Controls.Add(this.extraerbtn);
            this.Controls.Add(this.errorlbl);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.saldotxt);
            this.Controls.Add(this.monedacmb);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datosdgtv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Caja de Ahorros";
            ((System.ComponentModel.ISupportInitialize)(this.datosdgtv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datosdgtv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.ComboBox monedacmb;
        private System.Windows.Forms.TextBox saldotxt;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label errorlbl;
        private System.Windows.Forms.Button extraerbtn;
        private System.Windows.Forms.Button depositarbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox extracDepositxt;
        private System.Windows.Forms.Label extraclbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Label eliminarlbl;
    }
}

