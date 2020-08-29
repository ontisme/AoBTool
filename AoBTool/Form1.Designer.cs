namespace AoBTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_aob1 = new System.Windows.Forms.TextBox();
            this.txt_aob2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_aob1
            // 
            this.txt_aob1.Location = new System.Drawing.Point(12, 12);
            this.txt_aob1.Multiline = true;
            this.txt_aob1.Name = "txt_aob1";
            this.txt_aob1.Size = new System.Drawing.Size(350, 193);
            this.txt_aob1.TabIndex = 0;
            this.txt_aob1.Text = resources.GetString("txt_aob1.Text");
            // 
            // txt_aob2
            // 
            this.txt_aob2.Location = new System.Drawing.Point(12, 212);
            this.txt_aob2.Multiline = true;
            this.txt_aob2.Name = "txt_aob2";
            this.txt_aob2.Size = new System.Drawing.Size(350, 192);
            this.txt_aob2.TabIndex = 0;
            this.txt_aob2.Text = resources.GetString("txt_aob2.Text");
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(368, 12);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(349, 363);
            this.txt_result.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(368, 381);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(349, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 413);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_aob2);
            this.Controls.Add(this.txt_aob1);
            this.Name = "Form1";
            this.Text = "特徵碼分析";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_aob1;
        private System.Windows.Forms.TextBox txt_aob2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_ok;
    }
}

