namespace KosChecker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browsefile = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.checktokens = new System.Windows.Forms.Button();
            this.programname = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browsefile
            // 
            this.browsefile.Location = new System.Drawing.Point(46, 142);
            this.browsefile.Name = "browsefile";
            this.browsefile.Size = new System.Drawing.Size(150, 30);
            this.browsefile.TabIndex = 0;
            this.browsefile.Text = "Browse";
            this.browsefile.UseVisualStyleBackColor = true;
            this.browsefile.Click += new System.EventHandler(this.browsefile_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(46, 116);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(150, 20);
            this.path.TabIndex = 2;
            // 
            // checktokens
            // 
            this.checktokens.Location = new System.Drawing.Point(46, 178);
            this.checktokens.Name = "checktokens";
            this.checktokens.Size = new System.Drawing.Size(150, 30);
            this.checktokens.TabIndex = 3;
            this.checktokens.Text = "Check";
            this.checktokens.UseVisualStyleBackColor = true;
            this.checktokens.Click += new System.EventHandler(this.checktokens_Click);
            // 
            // programname
            // 
            this.programname.AutoSize = true;
            this.programname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programname.Location = new System.Drawing.Point(40, 18);
            this.programname.Name = "programname";
            this.programname.Size = new System.Drawing.Size(163, 31);
            this.programname.TabIndex = 4;
            this.programname.Text = "KosChecker";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(165, 49);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(31, 13);
            this.version.TabIndex = 5;
            this.version.Text = "v 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 231);
            this.Controls.Add(this.version);
            this.Controls.Add(this.programname);
            this.Controls.Add(this.checktokens);
            this.Controls.Add(this.path);
            this.Controls.Add(this.browsefile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "2023. Koriss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browsefile;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button checktokens;
        private System.Windows.Forms.Label programname;
        private System.Windows.Forms.Label version;
    }
}

