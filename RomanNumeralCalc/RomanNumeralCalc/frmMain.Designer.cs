namespace RomanNumeralCalc
{
    partial class frmMain
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.grpCommands = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnToDec = new System.Windows.Forms.Button();
            this.btnToRom = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRom1 = new System.Windows.Forms.TextBox();
            this.txtRom2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.radSum = new System.Windows.Forms.RadioButton();
            this.radDiff = new System.Windows.Forms.RadioButton();
            this.grpInput.SuspendLayout();
            this.grpOperations.SuspendLayout();
            this.grpCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtResult);
            this.grpInput.Controls.Add(this.txtRom2);
            this.grpInput.Controls.Add(this.txtRom1);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(35, 34);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInput.Size = new System.Drawing.Size(637, 279);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.radDiff);
            this.grpOperations.Controls.Add(this.radSum);
            this.grpOperations.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperations.Location = new System.Drawing.Point(35, 340);
            this.grpOperations.Margin = new System.Windows.Forms.Padding(4);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Padding = new System.Windows.Forms.Padding(4);
            this.grpOperations.Size = new System.Drawing.Size(637, 105);
            this.grpOperations.TabIndex = 0;
            this.grpOperations.TabStop = false;
            this.grpOperations.Text = "Operations";
            // 
            // grpCommands
            // 
            this.grpCommands.Controls.Add(this.btnExit);
            this.grpCommands.Controls.Add(this.btnClear);
            this.grpCommands.Controls.Add(this.btnToRom);
            this.grpCommands.Controls.Add(this.btnToDec);
            this.grpCommands.Controls.Add(this.btnCalc);
            this.grpCommands.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCommands.Location = new System.Drawing.Point(35, 477);
            this.grpCommands.Margin = new System.Windows.Forms.Padding(4);
            this.grpCommands.Name = "grpCommands";
            this.grpCommands.Padding = new System.Windows.Forms.Padding(4);
            this.grpCommands.Size = new System.Drawing.Size(637, 169);
            this.grpCommands.TabIndex = 0;
            this.grpCommands.TabStop = false;
            this.grpCommands.Text = "Commands";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(17, 37);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(185, 41);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnToDec
            // 
            this.btnToDec.Enabled = false;
            this.btnToDec.Location = new System.Drawing.Point(225, 37);
            this.btnToDec.Name = "btnToDec";
            this.btnToDec.Size = new System.Drawing.Size(185, 41);
            this.btnToDec.TabIndex = 1;
            this.btnToDec.Text = "To Decimal";
            this.btnToDec.UseVisualStyleBackColor = true;
            this.btnToDec.Click += new System.EventHandler(this.btnToDec_Click);
            // 
            // btnToRom
            // 
            this.btnToRom.Enabled = false;
            this.btnToRom.Location = new System.Drawing.Point(433, 37);
            this.btnToRom.Name = "btnToRom";
            this.btnToRom.Size = new System.Drawing.Size(185, 41);
            this.btnToRom.TabIndex = 2;
            this.btnToRom.Text = "To Roman";
            this.btnToRom.UseVisualStyleBackColor = true;
            this.btnToRom.Click += new System.EventHandler(this.btnToRom_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 100);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 41);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(433, 100);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roman Numeral 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Roman Numeral 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Result:";
            // 
            // txtRom1
            // 
            this.txtRom1.Location = new System.Drawing.Point(199, 40);
            this.txtRom1.Name = "txtRom1";
            this.txtRom1.Size = new System.Drawing.Size(390, 27);
            this.txtRom1.TabIndex = 0;
            // 
            // txtRom2
            // 
            this.txtRom2.Location = new System.Drawing.Point(199, 76);
            this.txtRom2.Name = "txtRom2";
            this.txtRom2.Size = new System.Drawing.Size(390, 27);
            this.txtRom2.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(199, 112);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(390, 27);
            this.txtResult.TabIndex = 2;
            // 
            // radSum
            // 
            this.radSum.AutoSize = true;
            this.radSum.Location = new System.Drawing.Point(131, 50);
            this.radSum.Name = "radSum";
            this.radSum.Size = new System.Drawing.Size(56, 23);
            this.radSum.TabIndex = 0;
            this.radSum.TabStop = true;
            this.radSum.Text = "Sum";
            this.radSum.UseVisualStyleBackColor = true;
            // 
            // radDiff
            // 
            this.radDiff.AutoSize = true;
            this.radDiff.Location = new System.Drawing.Point(380, 50);
            this.radDiff.Name = "radDiff";
            this.radDiff.Size = new System.Drawing.Size(96, 23);
            this.radDiff.TabIndex = 1;
            this.radDiff.TabStop = true;
            this.radDiff.Text = "Difference";
            this.radDiff.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(710, 668);
            this.Controls.Add(this.grpCommands);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.grpInput);
            this.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roman Numeral Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.grpCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtRom2;
        private System.Windows.Forms.TextBox txtRom1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.GroupBox grpCommands;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnToRom;
        private System.Windows.Forms.Button btnToDec;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RadioButton radDiff;
        private System.Windows.Forms.RadioButton radSum;
    }
}

