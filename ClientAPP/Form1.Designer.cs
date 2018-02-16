namespace ClientAPP
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            this.ReceiveTextBox = new System.Windows.Forms.TextBox();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.发送 = new System.Windows.Forms.Button();
            this.Updatetime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.Location = new System.Drawing.Point(12, 12);
            this.ReceiveTextBox.Multiline = true;
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.Size = new System.Drawing.Size(260, 320);
            this.ReceiveTextBox.TabIndex = 0;
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(12, 338);
            this.SendTextBox.Multiline = true;
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(260, 88);
            this.SendTextBox.TabIndex = 1;
            // 
            // 发送
            // 
            this.发送.Location = new System.Drawing.Point(197, 403);
            this.发送.Name = "发送";
            this.发送.Size = new System.Drawing.Size(75, 23);
            this.发送.TabIndex = 2;
            this.发送.Text = "发送";
            this.发送.UseVisualStyleBackColor = true;
            this.发送.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // Updatetime
            // 
            this.Updatetime.Enabled = true;
            this.Updatetime.Tick += new System.EventHandler(this.Updatetime_Tick);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 438);
            this.Controls.Add(this.发送);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.ReceiveTextBox);
            this.Name = "ChatForm";
            this.Text = "XXXX";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceiveTextBox;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Button 发送;
        private System.Windows.Forms.Timer Updatetime;
    }
}

