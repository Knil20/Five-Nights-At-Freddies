namespace Five_Nights_At_Freddies
{
    partial class CameraScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cameraTimer = new System.Windows.Forms.Timer(this.components);
            this.cameraButton = new System.Windows.Forms.Button();
            this.camMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.camMap)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraTimer
            // 
            this.cameraTimer.Interval = 20;
            this.cameraTimer.Tick += new System.EventHandler(this.cameraTimer_Tick);
            // 
            // cameraButton
            // 
            this.cameraButton.BackgroundImage = global::Five_Nights_At_Freddies.Properties.Resources.output_onlinepngtools__1_;
            this.cameraButton.FlatAppearance.BorderSize = 0;
            this.cameraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraButton.Location = new System.Drawing.Point(50, 79);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(50, 24);
            this.cameraButton.TabIndex = 5;
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.MouseLeave += new System.EventHandler(this.cameraButton_MouseLeave);
            this.cameraButton.MouseHover += new System.EventHandler(this.cameraButton_MouseHover);
            // 
            // camMap
            // 
            this.camMap.BackgroundImage = global::Five_Nights_At_Freddies.Properties.Resources.Cam_Map;
            this.camMap.Location = new System.Drawing.Point(50, 47);
            this.camMap.Name = "camMap";
            this.camMap.Size = new System.Drawing.Size(50, 26);
            this.camMap.TabIndex = 4;
            this.camMap.TabStop = false;
            // 
            // CameraScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cameraButton);
            this.Controls.Add(this.camMap);
            this.Name = "CameraScreen1";
            ((System.ComponentModel.ISupportInitialize)(this.camMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer cameraTimer;
        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.PictureBox camMap;
    }
}
