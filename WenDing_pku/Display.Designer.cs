namespace WenDingpku
{
    partial class Display
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
            this.mapControl1 = new MapObject.MapControl();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Location = new System.Drawing.Point(68, 37);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(707, 421);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.Load += new System.EventHandler(this.Display_Load);
            this.mapControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);

            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 499);
            this.Controls.Add(this.mapControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Display";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MapObject.MapControl mapControl1;
    }
}

