using DmitryBrant.CustomControls;

namespace VectonSensingDemo2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.zed1 = new ZedGraph.ZedGraphControl();
            this.ssData = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Khaki;
            this.btnPause.Location = new System.Drawing.Point(270, 16);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(88, 41);
            this.btnPause.TabIndex = 181;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(139, 15);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 41);
            this.btnStop.TabIndex = 180;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Location = new System.Drawing.Point(11, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 41);
            this.btnStart.TabIndex = 179;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // zed1
            // 
            this.zed1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.zed1.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zed1.Location = new System.Drawing.Point(12, 101);
            this.zed1.Name = "zed1";
            this.zed1.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.zed1.ScrollGrace = 0D;
            this.zed1.ScrollMaxX = 0D;
            this.zed1.ScrollMaxY = 0D;
            this.zed1.ScrollMaxY2 = 0D;
            this.zed1.ScrollMinX = 0D;
            this.zed1.ScrollMinY = 0D;
            this.zed1.ScrollMinY2 = 0D;
            this.zed1.Size = new System.Drawing.Size(636, 461);
            this.zed1.TabIndex = 182;
            // 
            // ssData
            // 
            this.ssData.ArrayCount = 4;
            this.ssData.ColorBackground = System.Drawing.Color.Black;
            this.ssData.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ssData.ColorLight = System.Drawing.Color.Red;
            this.ssData.DecimalShow = true;
            this.ssData.ElementPadding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.ssData.ElementWidth = 12;
            this.ssData.ItalicFactor = -0.1F;
            this.ssData.Location = new System.Drawing.Point(415, 25);
            this.ssData.Name = "ssData";
            this.ssData.Size = new System.Drawing.Size(125, 31);
            this.ssData.TabIndex = 172;
            this.ssData.TabStop = false;
            this.ssData.Value = "0000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 183;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zed1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ssData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SevenSegmentArray ssData;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private ZedGraph.ZedGraphControl zed1;
        private System.Windows.Forms.Button button1;
    }
}

