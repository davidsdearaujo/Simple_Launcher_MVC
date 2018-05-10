namespace Launcher.View
{
    partial class frmPrincipal<TPresenter>
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarInfo = new System.Windows.Forms.ProgressBar();
            this.progressBarPrincipal = new System.Windows.Forms.ProgressBar();
            this.picBanner02 = new System.Windows.Forms.PictureBox();
            this.buttonGO = new System.Windows.Forms.Button();
            this.picBanner01 = new System.Windows.Forms.PictureBox();
            this.labelProgressPrincipal = new System.Windows.Forms.Label();
            this.labelProgressInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanelProgresso = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBanner2 = new System.Windows.Forms.Label();
            this.labelBanner1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner01)).BeginInit();
            this.flowLayoutPanelProgresso.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarInfo
            // 
            this.progressBarInfo.Location = new System.Drawing.Point(3, 68);
            this.progressBarInfo.Name = "progressBarInfo";
            this.progressBarInfo.Size = new System.Drawing.Size(854, 23);
            this.progressBarInfo.TabIndex = 0;
            // 
            // progressBarPrincipal
            // 
            this.progressBarPrincipal.Location = new System.Drawing.Point(3, 39);
            this.progressBarPrincipal.Name = "progressBarPrincipal";
            this.progressBarPrincipal.Size = new System.Drawing.Size(854, 23);
            this.progressBarPrincipal.TabIndex = 1;
            // 
            // picBanner02
            // 
            this.picBanner02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBanner02.Location = new System.Drawing.Point(615, 12);
            this.picBanner02.Name = "picBanner02";
            this.picBanner02.Size = new System.Drawing.Size(251, 332);
            this.picBanner02.TabIndex = 2;
            this.picBanner02.TabStop = false;
            // 
            // buttonGO
            // 
            this.buttonGO.Enabled = false;
            this.buttonGO.Location = new System.Drawing.Point(615, 360);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(251, 55);
            this.buttonGO.TabIndex = 3;
            this.buttonGO.Text = "buttonGO";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBanner01
            // 
            this.picBanner01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBanner01.Location = new System.Drawing.Point(13, 13);
            this.picBanner01.Name = "picBanner01";
            this.picBanner01.Size = new System.Drawing.Size(586, 401);
            this.picBanner01.TabIndex = 4;
            this.picBanner01.TabStop = false;
            // 
            // labelProgressPrincipal
            // 
            this.labelProgressPrincipal.Location = new System.Drawing.Point(3, 0);
            this.labelProgressPrincipal.Name = "labelProgressPrincipal";
            this.labelProgressPrincipal.Size = new System.Drawing.Size(853, 18);
            this.labelProgressPrincipal.TabIndex = 5;
            this.labelProgressPrincipal.Text = "labelProgressPrincipal";
            this.labelProgressPrincipal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelProgressInfo
            // 
            this.labelProgressInfo.Location = new System.Drawing.Point(3, 18);
            this.labelProgressInfo.Name = "labelProgressInfo";
            this.labelProgressInfo.Size = new System.Drawing.Size(853, 18);
            this.labelProgressInfo.TabIndex = 6;
            this.labelProgressInfo.Text = "labelProgressInfo";
            this.labelProgressInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanelProgresso
            // 
            this.flowLayoutPanelProgresso.AutoSize = true;
            this.flowLayoutPanelProgresso.Controls.Add(this.labelProgressPrincipal);
            this.flowLayoutPanelProgresso.Controls.Add(this.labelProgressInfo);
            this.flowLayoutPanelProgresso.Controls.Add(this.progressBarPrincipal);
            this.flowLayoutPanelProgresso.Controls.Add(this.progressBarInfo);
            this.flowLayoutPanelProgresso.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelProgresso.Location = new System.Drawing.Point(11, 420);
            this.flowLayoutPanelProgresso.Name = "flowLayoutPanelProgresso";
            this.flowLayoutPanelProgresso.Size = new System.Drawing.Size(864, 99);
            this.flowLayoutPanelProgresso.TabIndex = 7;
            // 
            // labelBanner2
            // 
            this.labelBanner2.BackColor = System.Drawing.Color.Transparent;
            this.labelBanner2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBanner2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanner2.Location = new System.Drawing.Point(615, 12);
            this.labelBanner2.Name = "labelBanner2";
            this.labelBanner2.Size = new System.Drawing.Size(251, 332);
            this.labelBanner2.TabIndex = 9;
            this.labelBanner2.Text = "labelBanner2";
            this.labelBanner2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBanner2.Visible = false;
            // 
            // labelBanner1
            // 
            this.labelBanner1.BackColor = System.Drawing.Color.Transparent;
            this.labelBanner1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBanner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanner1.Location = new System.Drawing.Point(13, 13);
            this.labelBanner1.Name = "labelBanner1";
            this.labelBanner1.Size = new System.Drawing.Size(586, 401);
            this.labelBanner1.TabIndex = 10;
            this.labelBanner1.Text = "labelBanner1";
            this.labelBanner1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBanner1.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 528);
            this.Controls.Add(this.labelBanner1);
            this.Controls.Add(this.labelBanner2);
            this.Controls.Add(this.flowLayoutPanelProgresso);
            this.Controls.Add(this.picBanner01);
            this.Controls.Add(this.buttonGO);
            this.Controls.Add(this.picBanner02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner01)).EndInit();
            this.flowLayoutPanelProgresso.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarInfo;
        private System.Windows.Forms.ProgressBar progressBarPrincipal;
        private System.Windows.Forms.PictureBox picBanner02;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.PictureBox picBanner01;
        private System.Windows.Forms.Label labelProgressPrincipal;
        private System.Windows.Forms.Label labelProgressInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProgresso;
        private System.Windows.Forms.Label labelBanner2;
        private System.Windows.Forms.Label labelBanner1;
    }
}