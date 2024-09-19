namespace pointSalesv1.Views
{
    partial class SaludoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaludoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.circuleProgressBar = new CircularProgressBar.CircularProgressBar();
            this.labelUser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 284);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(418, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido al sistema";
            // 
            // circuleProgressBar
            // 
            this.circuleProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circuleProgressBar.AnimationSpeed = 500;
            this.circuleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circuleProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuleProgressBar.ForeColor = System.Drawing.Color.DimGray;
            this.circuleProgressBar.InnerColor = System.Drawing.Color.Transparent;
            this.circuleProgressBar.InnerMargin = 2;
            this.circuleProgressBar.InnerWidth = -1;
            this.circuleProgressBar.Location = new System.Drawing.Point(418, 83);
            this.circuleProgressBar.MarqueeAnimationSpeed = 2000;
            this.circuleProgressBar.Name = "circuleProgressBar";
            this.circuleProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.circuleProgressBar.OuterMargin = -25;
            this.circuleProgressBar.OuterWidth = 26;
            this.circuleProgressBar.ProgressColor = System.Drawing.Color.White;
            this.circuleProgressBar.ProgressWidth = 25;
            this.circuleProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuleProgressBar.Size = new System.Drawing.Size(176, 153);
            this.circuleProgressBar.StartAngle = 250;
            this.circuleProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circuleProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circuleProgressBar.SubscriptText = "";
            this.circuleProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circuleProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circuleProgressBar.SuperscriptText = "%";
            this.circuleProgressBar.TabIndex = 5;
            this.circuleProgressBar.Text = "0";
            this.circuleProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circuleProgressBar.Value = 60;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.DimGray;
            this.labelUser.Location = new System.Drawing.Point(349, 72);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(40, 20);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "user";
            // 
            // SaludoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 284);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.circuleProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaludoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaludoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar circuleProgressBar;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}