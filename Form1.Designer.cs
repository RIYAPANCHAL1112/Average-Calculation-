
namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.textBoxRegion1 = new System.Windows.Forms.TextBox();
            this.textBoxRegion2 = new System.Windows.Forms.TextBox();
            this.textBoxRegion3 = new System.Windows.Forms.TextBox();
            this.labelRegion1Average = new System.Windows.Forms.Label();
            this.labelRegion2Average = new System.Windows.Forms.Label();
            this.labelRegion3Average = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.labelRegion3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Location = new System.Drawing.Point(35, 23);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(34, 15);
            this.labelUnits.TabIndex = 0;
            this.labelUnits.Text = "Units";
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(79, 20);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(100, 23);
            this.textBoxUnits.TabIndex = 1;
            // 
            // textBoxRegion1
            // 
            this.textBoxRegion1.Location = new System.Drawing.Point(35, 86);
            this.textBoxRegion1.Multiline = true;
            this.textBoxRegion1.Name = "textBoxRegion1";
            this.textBoxRegion1.ReadOnly = true;
            this.textBoxRegion1.Size = new System.Drawing.Size(128, 211);
            this.textBoxRegion1.TabIndex = 3;
            this.textBoxRegion1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxRegion2
            // 
            this.textBoxRegion2.Location = new System.Drawing.Point(242, 86);
            this.textBoxRegion2.Multiline = true;
            this.textBoxRegion2.Name = "textBoxRegion2";
            this.textBoxRegion2.ReadOnly = true;
            this.textBoxRegion2.Size = new System.Drawing.Size(128, 211);
            this.textBoxRegion2.TabIndex = 6;
            // 
            // textBoxRegion3
            // 
            this.textBoxRegion3.Location = new System.Drawing.Point(448, 86);
            this.textBoxRegion3.Multiline = true;
            this.textBoxRegion3.Name = "textBoxRegion3";
            this.textBoxRegion3.ReadOnly = true;
            this.textBoxRegion3.Size = new System.Drawing.Size(128, 211);
            this.textBoxRegion3.TabIndex = 9;
            // 
            // labelRegion1Average
            // 
            this.labelRegion1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion1Average.Location = new System.Drawing.Point(35, 314);
            this.labelRegion1Average.Name = "labelRegion1Average";
            this.labelRegion1Average.Size = new System.Drawing.Size(128, 45);
            this.labelRegion1Average.TabIndex = 4;
            // 
            // labelRegion2Average
            // 
            this.labelRegion2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion2Average.Location = new System.Drawing.Point(242, 314);
            this.labelRegion2Average.Name = "labelRegion2Average";
            this.labelRegion2Average.Size = new System.Drawing.Size(128, 45);
            this.labelRegion2Average.TabIndex = 7;
            // 
            // labelRegion3Average
            // 
            this.labelRegion3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion3Average.Location = new System.Drawing.Point(448, 314);
            this.labelRegion3Average.Name = "labelRegion3Average";
            this.labelRegion3Average.Size = new System.Drawing.Size(128, 45);
            this.labelRegion3Average.TabIndex = 10;
            // 
            // labelAverage
            // 
            this.labelAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverage.Location = new System.Drawing.Point(35, 381);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(541, 66);
            this.labelAverage.TabIndex = 11;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(35, 467);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(154, 23);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "&Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(232, 467);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(154, 23);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(422, 467);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(154, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegion1.Location = new System.Drawing.Point(68, 68);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(53, 15);
            this.labelRegion1.TabIndex = 2;
            this.labelRegion1.Text = "Region1";
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegion2.Location = new System.Drawing.Point(278, 68);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(53, 15);
            this.labelRegion2.TabIndex = 5;
            this.labelRegion2.Text = "Region2";
            // 
            // labelRegion3
            // 
            this.labelRegion3.AutoSize = true;
            this.labelRegion3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegion3.Location = new System.Drawing.Point(485, 68);
            this.labelRegion3.Name = "labelRegion3";
            this.labelRegion3.Size = new System.Drawing.Size(53, 15);
            this.labelRegion3.TabIndex = 8;
            this.labelRegion3.Text = "Region3";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(627, 507);
            this.Controls.Add(this.labelRegion3);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelRegion3Average);
            this.Controls.Add(this.labelRegion2Average);
            this.Controls.Add(this.labelRegion1Average);
            this.Controls.Add(this.textBoxRegion3);
            this.Controls.Add(this.textBoxRegion2);
            this.Controls.Add(this.textBoxRegion1);
            this.Controls.Add(this.textBoxUnits);
            this.Controls.Add(this.labelUnits);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units By Region";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.TextBox textBoxRegion1;
        private System.Windows.Forms.TextBox textBoxRegion2;
        private System.Windows.Forms.TextBox textBoxRegion3;
        private System.Windows.Forms.Label labelRegion1Average;
        private System.Windows.Forms.Label labelRegion2Average;
        private System.Windows.Forms.Label labelRegion3Average;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.Label labelRegion3;
    }
}

