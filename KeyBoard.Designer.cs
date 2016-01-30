namespace virtualKeyBoard
{
    partial class KeyBoard
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
            this.wkey = new System.Windows.Forms.Button();
            this.space = new System.Windows.Forms.Button();
            this.upkey = new System.Windows.Forms.Button();
            this.ctrl = new System.Windows.Forms.Button();
            this.ckey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wkey
            // 
            this.wkey.BackColor = System.Drawing.SystemColors.Control;
            this.wkey.Location = new System.Drawing.Point(748, 227);
            this.wkey.Name = "wkey";
            this.wkey.Size = new System.Drawing.Size(67, 63);
            this.wkey.TabIndex = 0;
            this.wkey.Text = "W키";
            this.wkey.UseVisualStyleBackColor = false;
            // 
            // space
            // 
            this.space.Location = new System.Drawing.Point(414, 127);
            this.space.Name = "space";
            this.space.Size = new System.Drawing.Size(67, 63);
            this.space.TabIndex = 1;
            this.space.Text = "Space";
            this.space.UseVisualStyleBackColor = true;
            // 
            // upkey
            // 
            this.upkey.Location = new System.Drawing.Point(659, 38);
            this.upkey.Name = "upkey";
            this.upkey.Size = new System.Drawing.Size(67, 63);
            this.upkey.TabIndex = 2;
            this.upkey.Text = "UP";
            this.upkey.UseVisualStyleBackColor = true;
            // 
            // ctrl
            // 
            this.ctrl.Location = new System.Drawing.Point(170, 38);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(67, 63);
            this.ctrl.TabIndex = 3;
            this.ctrl.Text = "Ctrl";
            this.ctrl.UseVisualStyleBackColor = true;
            // 
            // ckey
            // 
            this.ckey.Location = new System.Drawing.Point(190, 174);
            this.ckey.Name = "ckey";
            this.ckey.Size = new System.Drawing.Size(67, 63);
            this.ckey.TabIndex = 4;
            this.ckey.Text = "C";
            this.ckey.UseVisualStyleBackColor = true;
            this.ckey.Click += new System.EventHandler(this.ckey_Click);
            // 
            // KeyBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 316);
            this.Controls.Add(this.ckey);
            this.Controls.Add(this.ctrl);
            this.Controls.Add(this.upkey);
            this.Controls.Add(this.space);
            this.Controls.Add(this.wkey);
            this.Name = "KeyBoard";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wkey;
        private System.Windows.Forms.Button space;
        private System.Windows.Forms.Button upkey;
        private System.Windows.Forms.Button ctrl;
        private System.Windows.Forms.Button ckey;
    }
}