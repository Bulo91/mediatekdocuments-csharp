namespace MediaTekDocuments.view
{
    partial class FrmAlertAbonnementsRevues
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.dgvAlertes = new System.Windows.Forms.DataGridView();
            this.colTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).BeginInit();
            this.SuspendLayout();
            //
            // lblMessage
            //
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 12);
            this.lblMessage.MaximumSize = new System.Drawing.Size(460, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(420, 26);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Les abonnements suivants se terminent dans moins de 30 jours :";
            //
            // dgvAlertes
            //
            this.dgvAlertes.AllowUserToAddRows = false;
            this.dgvAlertes.AllowUserToDeleteRows = false;
            this.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitre,
            this.colDateFin});
            this.dgvAlertes.Location = new System.Drawing.Point(12, 45);
            this.dgvAlertes.Name = "dgvAlertes";
            this.dgvAlertes.ReadOnly = true;
            this.dgvAlertes.Size = new System.Drawing.Size(460, 220);
            this.dgvAlertes.TabIndex = 1;
            //
            // colTitre
            //
            this.colTitre.HeaderText = "Titre";
            this.colTitre.Name = "colTitre";
            this.colTitre.ReadOnly = true;
            this.colTitre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // colDateFin
            //
            this.colDateFin.HeaderText = "Fin d\'abonnement";
            this.colDateFin.Name = "colDateFin";
            this.colDateFin.ReadOnly = true;
            this.colDateFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // btnOk
            //
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(397, 278);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            //
            // FrmAlertAbonnementsRevues
            //
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgvAlertes);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlertAbonnementsRevues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abonnements de revues";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dgvAlertes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateFin;
        private System.Windows.Forms.Button btnOk;
    }
}
