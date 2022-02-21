using System.Windows.Forms;
using MVCDesignPattern.Interfaces;
using MVCDesignPattern.Models;

namespace MVCDesignPattern
{
    partial class AutoView: IVehicleView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// private IVehicleControl Control;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnDecelerate;
        private IVehicleControl Control;
        private IVehicleModel Model;
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

        public void WireUp(IVehicleControl paramControl, IVehicleModel paramModel)
        {
            if (Model != null)
            {
                Model.RemoveObserver(this);
            }

            Model = paramModel;
            Control = paramControl;

            Control.SetModel(Model);
            Control.SetView(this);
            Model.AddObserver(this);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnDecelerate = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(92, 403);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(228, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(71, 144);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(409, 23);
            this.pBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(68, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 23);
            this.label1.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(119, 83);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(294, 20);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.Text = "10";
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(442, 83);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 23);
            this.btnAccelerate.TabIndex = 8;
            this.btnAccelerate.Text = ">>";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnDecelerate
            // 
            this.btnDecelerate.Location = new System.Drawing.Point(24, 80);
            this.btnDecelerate.Name = "btnDecelerate";
            this.btnDecelerate.Size = new System.Drawing.Size(75, 23);
            this.btnDecelerate.TabIndex = 9;
            this.btnDecelerate.Text = "<<";
            this.btnDecelerate.UseVisualStyleBackColor = true;
            this.btnDecelerate.Click += new System.EventHandler(this.btnDecelerate_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(361, 54);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = "Turn Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(100, 54);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "Turn Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // AutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 195);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDecelerate);
            this.Controls.Add(this.btnAccelerate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.progressBar1);
            this.Name = "AutoView";
            this.Text = "AutoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public void UpdateInterface(IVehicleModel auto)
        {
            this.label1.Text = auto.Name + " heading " + auto.Direction.ToString() + " at speed: " + auto.Speed.ToString();
            this.pBar.Value = (auto.Speed > 0) ? auto.Speed * 100 / auto.MaxSpeed : auto.Speed * 100 / auto.MaxReverseSpeed;

        }

        public void DisableAcceleration()
        {
            this.btnAccelerate.Enabled = false;
        }

        public void EnableAcceleration()
        {
            this.btnAccelerate.Enabled = true;
        }

        public void DisableDeceleration()
        {
            this.btnDecelerate.Enabled = false;
        }

        public void EnableDeceleration()
        {
            this.btnDecelerate.Enabled = true;
        }

        public void DisableTurning()
        {
            this.btnRight.Enabled = this.btnLeft.Enabled = true;
        }

        public void EnableTurning()
        {
            this.btnRight.Enabled = this.btnLeft.Enabled = true;
        }

        public void Update(AutoMobile paramModel)
        {
            this.UpdateInterface(paramModel);
        }

        private Button btnRight;
        private Button btnLeft;
    }
}