namespace Textquest
{
    partial class Cave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cave));
            this.Option1 = new System.Windows.Forms.Button();
            this.Option2 = new System.Windows.Forms.Button();
            this.Option3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Option1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Option1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Option1.Location = new System.Drawing.Point(26, 276);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(237, 50);
            this.Option1.TabIndex = 0;
            this.Option1.Text = "Зажечь факел";
            this.Option1.UseVisualStyleBackColor = false;
            this.Option1.Click += new System.EventHandler(this.Option1_Click);
            // 
            // Option2
            // 
            this.Option2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Option2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Option2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Option2.Location = new System.Drawing.Point(26, 332);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(237, 44);
            this.Option2.TabIndex = 2;
            this.Option2.UseVisualStyleBackColor = false;
            this.Option2.Click += new System.EventHandler(this.Option2_Click);
            // 
            // Option3
            // 
            this.Option3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Option3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Option3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Option3.Location = new System.Drawing.Point(26, 382);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(237, 44);
            this.Option3.TabIndex = 3;
            this.Option3.UseVisualStyleBackColor = false;
            this.Option3.Click += new System.EventHandler(this.Option3_Click);
            // 
            // Cave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Textquest.Properties.Resources._1_начало_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Cave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Пещера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Option1;
        private System.Windows.Forms.Button Option2;
        private System.Windows.Forms.Button Option3;
    }
}

