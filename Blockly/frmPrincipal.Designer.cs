
namespace Blockly
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnExecutar = new System.Windows.Forms.ToolStripButton();
            this.divisor01 = new System.Windows.Forms.ToolStripSeparator();
            this.lblAVariavel = new System.Windows.Forms.ToolStripLabel();
            this.txtAVariavel = new System.Windows.Forms.ToolStripTextBox();
            this.lblBVariavel = new System.Windows.Forms.ToolStripLabel();
            this.txtBVariavel = new System.Windows.Forms.ToolStripTextBox();
            this.lblCVariavel = new System.Windows.Forms.ToolStripLabel();
            this.txtCVariavel = new System.Windows.Forms.ToolStripTextBox();
            this.divisor02 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDisplayS = new System.Windows.Forms.ToolStripLabel();
            this.lblSVariavel = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(0, 37);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(800, 396);
            this.webView.Source = new System.Uri("http://localhost:9090/", System.UriKind.Absolute);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Verdana", 12F);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExecutar,
            this.divisor01,
            this.lblAVariavel,
            this.txtAVariavel,
            this.lblBVariavel,
            this.txtBVariavel,
            this.lblCVariavel,
            this.txtCVariavel,
            this.divisor02,
            this.lblDisplayS,
            this.lblSVariavel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 39);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnExecutar
            // 
            this.btnExecutar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExecutar.Image = ((System.Drawing.Image)(resources.GetObject("btnExecutar.Image")));
            this.btnExecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(36, 36);
            this.btnExecutar.Text = "btnExecutar";
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // divisor01
            // 
            this.divisor01.Name = "divisor01";
            this.divisor01.Size = new System.Drawing.Size(6, 39);
            // 
            // lblAVariavel
            // 
            this.lblAVariavel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVariavel.Name = "lblAVariavel";
            this.lblAVariavel.Size = new System.Drawing.Size(19, 36);
            this.lblAVariavel.Text = "A";
            // 
            // txtAVariavel
            // 
            this.txtAVariavel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAVariavel.Name = "txtAVariavel";
            this.txtAVariavel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAVariavel.Size = new System.Drawing.Size(100, 39);
            this.txtAVariavel.Text = "0";
            // 
            // lblBVariavel
            // 
            this.lblBVariavel.Name = "lblBVariavel";
            this.lblBVariavel.Size = new System.Drawing.Size(19, 36);
            this.lblBVariavel.Text = "B";
            // 
            // txtBVariavel
            // 
            this.txtBVariavel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBVariavel.Name = "txtBVariavel";
            this.txtBVariavel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBVariavel.Size = new System.Drawing.Size(100, 39);
            this.txtBVariavel.Text = "0";
            // 
            // lblCVariavel
            // 
            this.lblCVariavel.Name = "lblCVariavel";
            this.lblCVariavel.Size = new System.Drawing.Size(19, 36);
            this.lblCVariavel.Text = "C";
            // 
            // txtCVariavel
            // 
            this.txtCVariavel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCVariavel.Name = "txtCVariavel";
            this.txtCVariavel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCVariavel.Size = new System.Drawing.Size(100, 39);
            this.txtCVariavel.Text = "0";
            // 
            // divisor02
            // 
            this.divisor02.Name = "divisor02";
            this.divisor02.Size = new System.Drawing.Size(6, 39);
            // 
            // lblDisplayS
            // 
            this.lblDisplayS.Name = "lblDisplayS";
            this.lblDisplayS.Size = new System.Drawing.Size(31, 36);
            this.lblDisplayS.Text = "S=";
            // 
            // lblSVariavel
            // 
            this.lblSVariavel.Name = "lblSVariavel";
            this.lblSVariavel.Size = new System.Drawing.Size(18, 36);
            this.lblSVariavel.Text = "0";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.webView);
            this.Name = "frmPrincipal";
            this.Text = "Blockly";
            this.SizeChanged += new System.EventHandler(this.frmPrincipal_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnExecutar;
        private System.Windows.Forms.ToolStripSeparator divisor01;
        private System.Windows.Forms.ToolStripLabel lblAVariavel;
        private System.Windows.Forms.ToolStripTextBox txtAVariavel;
        private System.Windows.Forms.ToolStripLabel lblBVariavel;
        private System.Windows.Forms.ToolStripTextBox txtBVariavel;
        private System.Windows.Forms.ToolStripLabel lblCVariavel;
        private System.Windows.Forms.ToolStripTextBox txtCVariavel;
        private System.Windows.Forms.ToolStripSeparator divisor02;
        private System.Windows.Forms.ToolStripLabel lblDisplayS;
        private System.Windows.Forms.ToolStripLabel lblSVariavel;
    }
}

