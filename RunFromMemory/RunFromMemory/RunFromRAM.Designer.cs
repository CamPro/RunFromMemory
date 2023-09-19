
namespace RunFromMemory
{
    partial class RunFromRAM
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
            this.buttonLoadDllFromWeb = new System.Windows.Forms.Button();
            this.buttonLoadExeFromWeb = new System.Windows.Forms.Button();
            this.buttonLoadExeFromLocal = new System.Windows.Forms.Button();
            this.buttonLoadDllFromLocal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLoadStaticDllFromWeb = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLoadExeNoFormLocal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadDllFromWeb
            // 
            this.buttonLoadDllFromWeb.Location = new System.Drawing.Point(21, 38);
            this.buttonLoadDllFromWeb.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadDllFromWeb.Name = "buttonLoadDllFromWeb";
            this.buttonLoadDllFromWeb.Size = new System.Drawing.Size(250, 50);
            this.buttonLoadDllFromWeb.TabIndex = 0;
            this.buttonLoadDllFromWeb.Text = "Load and Run DLL from Web";
            this.buttonLoadDllFromWeb.UseVisualStyleBackColor = true;
            this.buttonLoadDllFromWeb.Click += new System.EventHandler(this.buttonLoadDllFromWeb_Click);
            // 
            // buttonLoadExeFromWeb
            // 
            this.buttonLoadExeFromWeb.Location = new System.Drawing.Point(21, 195);
            this.buttonLoadExeFromWeb.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadExeFromWeb.Name = "buttonLoadExeFromWeb";
            this.buttonLoadExeFromWeb.Size = new System.Drawing.Size(250, 50);
            this.buttonLoadExeFromWeb.TabIndex = 1;
            this.buttonLoadExeFromWeb.Text = "Load and Run EXE from Web";
            this.buttonLoadExeFromWeb.UseVisualStyleBackColor = true;
            this.buttonLoadExeFromWeb.Click += new System.EventHandler(this.buttonLoadExeFromWeb_Click);
            // 
            // buttonLoadExeFromLocal
            // 
            this.buttonLoadExeFromLocal.Location = new System.Drawing.Point(18, 171);
            this.buttonLoadExeFromLocal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadExeFromLocal.Name = "buttonLoadExeFromLocal";
            this.buttonLoadExeFromLocal.Size = new System.Drawing.Size(250, 50);
            this.buttonLoadExeFromLocal.TabIndex = 3;
            this.buttonLoadExeFromLocal.Text = "Load EXE have form Local";
            this.buttonLoadExeFromLocal.UseVisualStyleBackColor = true;
            this.buttonLoadExeFromLocal.Click += new System.EventHandler(this.buttonLoadExeFromLocal_Click);
            // 
            // buttonLoadDllFromLocal
            // 
            this.buttonLoadDllFromLocal.Location = new System.Drawing.Point(18, 36);
            this.buttonLoadDllFromLocal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadDllFromLocal.Name = "buttonLoadDllFromLocal";
            this.buttonLoadDllFromLocal.Size = new System.Drawing.Size(250, 50);
            this.buttonLoadDllFromLocal.TabIndex = 2;
            this.buttonLoadDllFromLocal.Text = "Load and Run DLL from Local";
            this.buttonLoadDllFromLocal.UseVisualStyleBackColor = true;
            this.buttonLoadDllFromLocal.Click += new System.EventHandler(this.buttonLoadDllFromLocal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLoadStaticDllFromWeb);
            this.groupBox1.Controls.Add(this.buttonLoadDllFromWeb);
            this.groupBox1.Controls.Add(this.buttonLoadExeFromWeb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Load from Web";
            // 
            // buttonLoadStaticDllFromWeb
            // 
            this.buttonLoadStaticDllFromWeb.Location = new System.Drawing.Point(21, 111);
            this.buttonLoadStaticDllFromWeb.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadStaticDllFromWeb.Name = "buttonLoadStaticDllFromWeb";
            this.buttonLoadStaticDllFromWeb.Size = new System.Drawing.Size(250, 50);
            this.buttonLoadStaticDllFromWeb.TabIndex = 2;
            this.buttonLoadStaticDllFromWeb.Text = "Load and Run Static DLL from Web";
            this.buttonLoadStaticDllFromWeb.UseVisualStyleBackColor = true;
            this.buttonLoadStaticDllFromWeb.Click += new System.EventHandler(this.buttonLoadStaticDllFromWeb_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLoadExeNoFormLocal);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.buttonLoadDllFromLocal);
            this.groupBox2.Controls.Add(this.buttonLoadExeFromLocal);
            this.groupBox2.Location = new System.Drawing.Point(338, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load from Local";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load and Run Static DLL from Local";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonLoadExeNoFormLocal
            // 
            this.buttonLoadExeNoFormLocal.Location = new System.Drawing.Point(18, 229);
            this.buttonLoadExeNoFormLocal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadExeNoFormLocal.Name = "buttonLoadExeNoFormLocal";
            this.buttonLoadExeNoFormLocal.Size = new System.Drawing.Size(250, 50);
            this.buttonLoadExeNoFormLocal.TabIndex = 5;
            this.buttonLoadExeNoFormLocal.Text = "Load EXE no form Local";
            this.buttonLoadExeNoFormLocal.UseVisualStyleBackColor = true;
            this.buttonLoadExeNoFormLocal.Click += new System.EventHandler(this.buttonLoadExeNoFormLocal_Click);
            // 
            // RunFromRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RunFromRAM";
            this.Text = "Run from Memory (RAM)";
            this.Load += new System.EventHandler(this.RunFromRAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadDllFromWeb;
        private System.Windows.Forms.Button buttonLoadExeFromWeb;
        private System.Windows.Forms.Button buttonLoadExeFromLocal;
        private System.Windows.Forms.Button buttonLoadDllFromLocal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLoadStaticDllFromWeb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonLoadExeNoFormLocal;
    }
}

