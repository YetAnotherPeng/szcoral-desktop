
namespace CoralDesktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxCoral = new System.Windows.Forms.PictureBox();
            this.buttonCoralBaike = new System.Windows.Forms.Button();
            this.buttonCoralAR = new System.Windows.Forms.Button();
            this.buttonCoralMap = new System.Windows.Forms.Button();
            this.buttonCoralVR = new System.Windows.Forms.Button();
            this.labelCO2Decrease = new System.Windows.Forms.Label();
            this.labelCO2DereaseValue = new System.Windows.Forms.Label();
            this.labelWanlitong = new System.Windows.Forms.Label();
            this.labelWanlitongValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoral)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCoral
            // 
            this.pictureBoxCoral.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoral.InitialImage")));
            this.pictureBoxCoral.Location = new System.Drawing.Point(873, 355);
            this.pictureBoxCoral.Name = "pictureBoxCoral";
            this.pictureBoxCoral.Size = new System.Drawing.Size(159, 124);
            this.pictureBoxCoral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoral.TabIndex = 0;
            this.pictureBoxCoral.TabStop = false;
            // 
            // buttonCoralBaike
            // 
            this.buttonCoralBaike.BackColor = System.Drawing.Color.Cyan;
            this.buttonCoralBaike.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCoralBaike.Location = new System.Drawing.Point(79, 162);
            this.buttonCoralBaike.Name = "buttonCoralBaike";
            this.buttonCoralBaike.Size = new System.Drawing.Size(75, 43);
            this.buttonCoralBaike.TabIndex = 1;
            this.buttonCoralBaike.Text = "珊瑚百科";
            this.buttonCoralBaike.UseVisualStyleBackColor = false;
            this.buttonCoralBaike.Click += new System.EventHandler(this.buttonCoralBaike_Click);
            // 
            // buttonCoralAR
            // 
            this.buttonCoralAR.BackColor = System.Drawing.Color.Cyan;
            this.buttonCoralAR.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCoralAR.Location = new System.Drawing.Point(271, 152);
            this.buttonCoralAR.Name = "buttonCoralAR";
            this.buttonCoralAR.Size = new System.Drawing.Size(75, 43);
            this.buttonCoralAR.TabIndex = 2;
            this.buttonCoralAR.Text = "珊瑚AR";
            this.buttonCoralAR.UseVisualStyleBackColor = false;
            this.buttonCoralAR.Click += new System.EventHandler(this.buttonCoralAR_Click);
            // 
            // buttonCoralMap
            // 
            this.buttonCoralMap.BackColor = System.Drawing.Color.Cyan;
            this.buttonCoralMap.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCoralMap.Location = new System.Drawing.Point(599, 217);
            this.buttonCoralMap.Name = "buttonCoralMap";
            this.buttonCoralMap.Size = new System.Drawing.Size(75, 43);
            this.buttonCoralMap.TabIndex = 3;
            this.buttonCoralMap.Text = "珊瑚地图";
            this.buttonCoralMap.UseVisualStyleBackColor = false;
            // 
            // buttonCoralVR
            // 
            this.buttonCoralVR.BackColor = System.Drawing.Color.Cyan;
            this.buttonCoralVR.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCoralVR.Location = new System.Drawing.Point(338, 297);
            this.buttonCoralVR.Name = "buttonCoralVR";
            this.buttonCoralVR.Size = new System.Drawing.Size(75, 43);
            this.buttonCoralVR.TabIndex = 4;
            this.buttonCoralVR.Text = "珊瑚VR";
            this.buttonCoralVR.UseVisualStyleBackColor = false;
            this.buttonCoralVR.Click += new System.EventHandler(this.buttonCoralVR_Click);
            // 
            // labelCO2Decrease
            // 
            this.labelCO2Decrease.BackColor = System.Drawing.Color.SteelBlue;
            this.labelCO2Decrease.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCO2Decrease.Location = new System.Drawing.Point(749, 101);
            this.labelCO2Decrease.Name = "labelCO2Decrease";
            this.labelCO2Decrease.Size = new System.Drawing.Size(102, 29);
            this.labelCO2Decrease.TabIndex = 5;
            this.labelCO2Decrease.Text = "CO2减少量";
            // 
            // labelCO2DereaseValue
            // 
            this.labelCO2DereaseValue.BackColor = System.Drawing.Color.SteelBlue;
            this.labelCO2DereaseValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCO2DereaseValue.Location = new System.Drawing.Point(878, 101);
            this.labelCO2DereaseValue.Name = "labelCO2DereaseValue";
            this.labelCO2DereaseValue.Size = new System.Drawing.Size(70, 29);
            this.labelCO2DereaseValue.TabIndex = 6;
            this.labelCO2DereaseValue.Text = "0g";
            // 
            // labelWanlitong
            // 
            this.labelWanlitong.BackColor = System.Drawing.Color.SteelBlue;
            this.labelWanlitong.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWanlitong.Location = new System.Drawing.Point(749, 152);
            this.labelWanlitong.Name = "labelWanlitong";
            this.labelWanlitong.Size = new System.Drawing.Size(102, 29);
            this.labelWanlitong.TabIndex = 7;
            this.labelWanlitong.Text = "万里通积分";
            // 
            // labelWanlitongValue
            // 
            this.labelWanlitongValue.BackColor = System.Drawing.Color.SteelBlue;
            this.labelWanlitongValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWanlitongValue.Location = new System.Drawing.Point(878, 152);
            this.labelWanlitongValue.Name = "labelWanlitongValue";
            this.labelWanlitongValue.Size = new System.Drawing.Size(70, 29);
            this.labelWanlitongValue.TabIndex = 8;
            this.labelWanlitongValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoralDesktop.Properties.Resources.coral_reef_3;
            this.ClientSize = new System.Drawing.Size(1059, 544);
            this.Controls.Add(this.labelWanlitongValue);
            this.Controls.Add(this.labelWanlitong);
            this.Controls.Add(this.labelCO2DereaseValue);
            this.Controls.Add(this.labelCO2Decrease);
            this.Controls.Add(this.buttonCoralVR);
            this.Controls.Add(this.buttonCoralMap);
            this.Controls.Add(this.buttonCoralAR);
            this.Controls.Add(this.buttonCoralBaike);
            this.Controls.Add(this.pictureBoxCoral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "守瑚者联盟";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCoral;
        private System.Windows.Forms.Button buttonCoralBaike;
        private System.Windows.Forms.Button buttonCoralAR;
        private System.Windows.Forms.Button buttonCoralMap;
        private System.Windows.Forms.Button buttonCoralVR;
        private System.Windows.Forms.Label labelCO2Decrease;
        private System.Windows.Forms.Label labelCO2DereaseValue;
        private System.Windows.Forms.Label labelWanlitong;
        private System.Windows.Forms.Label labelWanlitongValue;
    }
}

