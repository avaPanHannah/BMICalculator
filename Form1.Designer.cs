namespace BMI計算機NEWNEWNEW
{
    partial class BMI計算機
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
            this.輸入 = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.strResult = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.輸入.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // 輸入
            // 
            this.輸入.Controls.Add(this.btnRun);
            this.輸入.Controls.Add(this.txtWeight);
            this.輸入.Controls.Add(this.txtHeight);
            this.輸入.Controls.Add(this.lblWeight);
            this.輸入.Controls.Add(this.lblHight);
            this.輸入.Controls.Add(this.label1);
            this.輸入.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.輸入.Location = new System.Drawing.Point(49, 22);
            this.輸入.Name = "輸入";
            this.輸入.Size = new System.Drawing.Size(379, 139);
            this.輸入.TabIndex = 0;
            this.輸入.TabStop = false;
            this.輸入.Text = "輸入";
            this.輸入.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.strResult);
            this.grpOutput.Controls.Add(this.lblResult);
            this.grpOutput.Controls.Add(this.lblBmi);
            this.grpOutput.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOutput.Location = new System.Drawing.Point(50, 172);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(377, 146);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "計算結果";
            this.grpOutput.Enter += new System.EventHandler(this.grpOutput_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHight
            // 
            this.lblHight.AutoSize = true;
            this.lblHight.Location = new System.Drawing.Point(20, 41);
            this.lblHight.Name = "lblHight";
            this.lblHight.Size = new System.Drawing.Size(97, 27);
            this.lblHight.TabIndex = 1;
            this.lblHight.Text = "身高(cm)";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(20, 91);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(92, 27);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "體重(kg)";
            this.lblWeight.Click += new System.EventHandler(this.lblWeight_Click);
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Location = new System.Drawing.Point(19, 40);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(191, 27);
            this.lblBmi.TabIndex = 3;
            this.lblBmi.Text = "身體質量指數(BMI)";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(118, 44);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(177, 35);
            this.txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(118, 88);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(177, 35);
            this.txtWeight.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(31, 84);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 27);
            this.lblResult.TabIndex = 4;
            // 
            // strResult
            // 
            this.strResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.strResult.Location = new System.Drawing.Point(216, 40);
            this.strResult.Name = "strResult";
            this.strResult.Size = new System.Drawing.Size(149, 29);
            this.strResult.TabIndex = 5;
            this.strResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(306, 44);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(60, 82);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "計算";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // BMI計算機
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 345);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.輸入);
            this.Name = "BMI計算機";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.輸入.ResumeLayout(false);
            this.輸入.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 輸入;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.Label strResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRun;
    }
}

