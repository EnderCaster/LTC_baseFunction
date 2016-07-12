namespace LTC_baseFunction
{
    partial class TheOnlyOne
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.text_Main = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.TrackBar();
            this.submit = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(151, 21);
            this.Title.TabIndex = 0;
            this.Title.Text = "长期提醒-Alpha";
            // 
            // text_Main
            // 
            this.text_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_Main.Location = new System.Drawing.Point(0, 80);
            this.text_Main.Margin = new System.Windows.Forms.Padding(0);
            this.text_Main.Multiline = true;
            this.text_Main.Name = "text_Main";
            this.text_Main.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_Main.Size = new System.Drawing.Size(300, 300);
            this.text_Main.TabIndex = 1;
            this.text_Main.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(0, 380);
            this.capacity.Maximum = 100;
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(300, 45);
            this.capacity.TabIndex = 2;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(151, 30);
            this.submit.Margin = new System.Windows.Forms.Padding(0);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(150, 50);
            this.submit.TabIndex = 3;
            this.submit.Text = "确认";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Enabled = false;
            this.Edit.Location = new System.Drawing.Point(0, 30);
            this.Edit.Margin = new System.Windows.Forms.Padding(0);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(150, 50);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "编辑";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Visible = false;
            // 
            // TheOnlyOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.text_Main);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TheOnlyOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "提醒";
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox text_Main;
        private System.Windows.Forms.TrackBar capacity;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button Edit;
    }
}

