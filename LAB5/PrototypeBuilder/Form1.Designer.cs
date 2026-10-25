namespace PrototypeBuilder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.lblOutfitType = new System.Windows.Forms.Label();
            this.cmbOutfitType = new System.Windows.Forms.ComboBox();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnBuildAll = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.rtbDetails = new System.Windows.Forms.RichTextBox();
            this.grpPrototype = new System.Windows.Forms.GroupBox();
            this.lblClones = new System.Windows.Forms.Label();
            this.lstClones = new System.Windows.Forms.ListBox();
            this.rtbCloneDetails = new System.Windows.Forms.RichTextBox();
            this.grpControl.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpPrototype.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.btnClone);
            this.grpControl.Controls.Add(this.btnBuildAll);
            this.grpControl.Controls.Add(this.btnNextStep);
            this.grpControl.Controls.Add(this.cmbOutfitType);
            this.grpControl.Controls.Add(this.lblOutfitType);
            this.grpControl.Location = new System.Drawing.Point(12, 12);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(300, 180);
            this.grpControl.TabIndex = 0;
            this.grpControl.TabStop = false;
            this.grpControl.Text = "Керування";
            // 
            // lblOutfitType
            // 
            this.lblOutfitType.Location = new System.Drawing.Point(12, 25);
            this.lblOutfitType.Name = "lblOutfitType";
            this.lblOutfitType.Size = new System.Drawing.Size(100, 20);
            this.lblOutfitType.TabIndex = 0;
            this.lblOutfitType.Text = "Тип комплекту:";
            // 
            // cmbOutfitType
            // 
            this.cmbOutfitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutfitType.FormattingEnabled = true;
            this.cmbOutfitType.Items.AddRange(new object[] {
            "Повсякденний",
            "Діловий",
            "Спортивний"});
            this.cmbOutfitType.Location = new System.Drawing.Point(120, 22);
            this.cmbOutfitType.Name = "cmbOutfitType";
            this.cmbOutfitType.Size = new System.Drawing.Size(160, 21);
            this.cmbOutfitType.TabIndex = 1;
            this.cmbOutfitType.SelectedIndexChanged += new System.EventHandler(this.cmbOutfitType_SelectedIndexChanged);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(12, 60);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(260, 28);
            this.btnNextStep.TabIndex = 2;
            this.btnNextStep.Text = "Наступний крок";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnBuildAll
            // 
            this.btnBuildAll.Location = new System.Drawing.Point(12, 95);
            this.btnBuildAll.Name = "btnBuildAll";
            this.btnBuildAll.Size = new System.Drawing.Size(260, 28);
            this.btnBuildAll.TabIndex = 3;
            this.btnBuildAll.Text = "Зібрати повністю";
            this.btnBuildAll.UseVisualStyleBackColor = true;
            this.btnBuildAll.Click += new System.EventHandler(this.btnBuildAll_Click);
            // 
            // btnClone
            // 
            this.btnClone.Enabled = false;
            this.btnClone.Location = new System.Drawing.Point(12, 130);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(260, 28);
            this.btnClone.TabIndex = 4;
            this.btnClone.Text = "Клонувати комплект";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // grpLog
            // 
            this.grpLog.Controls.Add(this.rtbLog);
            this.grpLog.Location = new System.Drawing.Point(325, 12);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(560, 180);
            this.grpLog.TabIndex = 1;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Журнал дій";
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(3, 16);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(554, 161);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.rtbDetails);
            this.grpDetails.Location = new System.Drawing.Point(12, 200);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(420, 380);
            this.grpDetails.TabIndex = 2;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Деталі комплекту";
            // 
            // rtbDetails
            // 
            this.rtbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDetails.Location = new System.Drawing.Point(3, 16);
            this.rtbDetails.Name = "rtbDetails";
            this.rtbDetails.ReadOnly = true;
            this.rtbDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDetails.Size = new System.Drawing.Size(414, 361);
            this.rtbDetails.TabIndex = 0;
            this.rtbDetails.Text = "";
            // 
            // grpPrototype
            // 
            this.grpPrototype.Controls.Add(this.rtbCloneDetails);
            this.grpPrototype.Controls.Add(this.lstClones);
            this.grpPrototype.Controls.Add(this.lblClones);
            this.grpPrototype.Location = new System.Drawing.Point(445, 200);
            this.grpPrototype.Name = "grpPrototype";
            this.grpPrototype.Size = new System.Drawing.Size(440, 380);
            this.grpPrototype.TabIndex = 3;
            this.grpPrototype.TabStop = false;
            this.grpPrototype.Text = "Прототип (копії)";
            // 
            // lblClones
            // 
            this.lblClones.Location = new System.Drawing.Point(10, 20);
            this.lblClones.Name = "lblClones";
            this.lblClones.Size = new System.Drawing.Size(100, 20);
            this.lblClones.TabIndex = 0;
            this.lblClones.Text = "Список копій:";
            // 
            // lstClones
            // 
            this.lstClones.FormattingEnabled = true;
            this.lstClones.Location = new System.Drawing.Point(10, 45);
            this.lstClones.Name = "lstClones";
            this.lstClones.Size = new System.Drawing.Size(420, 147);
            this.lstClones.TabIndex = 1;
            this.lstClones.SelectedIndexChanged += new System.EventHandler(this.lstClones_SelectedIndexChanged);
            // 
            // rtbCloneDetails
            // 
            this.rtbCloneDetails.Location = new System.Drawing.Point(10, 205);
            this.rtbCloneDetails.Name = "rtbCloneDetails";
            this.rtbCloneDetails.ReadOnly = true;
            this.rtbCloneDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbCloneDetails.Size = new System.Drawing.Size(420, 165);
            this.rtbCloneDetails.TabIndex = 2;
            this.rtbCloneDetails.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.grpPrototype);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комплекти одягу";
            this.grpControl.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpPrototype.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.Label lblOutfitType;
        private System.Windows.Forms.ComboBox cmbOutfitType;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnBuildAll;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.RichTextBox rtbDetails;
        private System.Windows.Forms.GroupBox grpPrototype;
        private System.Windows.Forms.Label lblClones;
        private System.Windows.Forms.ListBox lstClones;
        private System.Windows.Forms.RichTextBox rtbCloneDetails;
    }
}