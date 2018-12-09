namespace WizardDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.advancedWizard1 = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.advancedWizardPage1 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.advancedWizardPage2 = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.advancedWizard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedWizard1
            // 
            this.advancedWizard1.BackButtonEnabled = true;
            this.advancedWizard1.BackButtonText = "< Back";
            this.advancedWizard1.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Default;
            this.advancedWizard1.ButtonsVisible = true;
            this.advancedWizard1.CancelButtonText = "&Cancel";
            this.advancedWizard1.Controls.Add(this.advancedWizardPage2);
            this.advancedWizard1.Controls.Add(this.advancedWizardPage1);
            this.advancedWizard1.CurrentPageIsFinishPage = false;
            this.advancedWizard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizard1.FinishButton = true;
            this.advancedWizard1.FinishButtonEnabled = true;
            this.advancedWizard1.FinishButtonText = "&Finish";
            this.advancedWizard1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.advancedWizard1.HelpButton = true;
            this.advancedWizard1.HelpButtonText = "&Help";
            this.advancedWizard1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizard1.Name = "advancedWizard1";
            this.advancedWizard1.NextButtonEnabled = false;
            this.advancedWizard1.NextButtonText = "Next >";
            this.advancedWizard1.ProcessKeys = false;
            this.advancedWizard1.Size = new System.Drawing.Size(503, 315);
            this.advancedWizard1.TabIndex = 0;
            this.advancedWizard1.TouchScreen = false;
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage1);
            this.advancedWizard1.WizardPages.Add(this.advancedWizardPage2);
            // 
            // advancedWizardPage1
            // 
            this.advancedWizardPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage1.Header = true;
            this.advancedWizardPage1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage1.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage1.HeaderImage")));
            this.advancedWizardPage1.HeaderImageVisible = true;
            this.advancedWizardPage1.HeaderTitle = "Step 1:";
            this.advancedWizardPage1.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage1.Name = "advancedWizardPage1";
            this.advancedWizardPage1.PreviousPage = 0;
            this.advancedWizardPage1.Size = new System.Drawing.Size(503, 275);
            this.advancedWizardPage1.SubTitle = "Your page description goes here";
            this.advancedWizardPage1.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage1.TabIndex = 1;
            // 
            // advancedWizardPage2
            // 
            this.advancedWizardPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedWizardPage2.Header = true;
            this.advancedWizardPage2.HeaderBackgroundColor = System.Drawing.Color.White;
            this.advancedWizardPage2.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.advancedWizardPage2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("advancedWizardPage2.HeaderImage")));
            this.advancedWizardPage2.HeaderImageVisible = true;
            this.advancedWizardPage2.HeaderTitle = "Step 2:";
            this.advancedWizardPage2.Location = new System.Drawing.Point(0, 0);
            this.advancedWizardPage2.Name = "advancedWizardPage2";
            this.advancedWizardPage2.PreviousPage = 0;
            this.advancedWizardPage2.Size = new System.Drawing.Size(503, 275);
            this.advancedWizardPage2.SubTitle = "Your page description goes here";
            this.advancedWizardPage2.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.advancedWizardPage2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 315);
            this.Controls.Add(this.advancedWizard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.advancedWizard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedWizardControl.Wizard.AdvancedWizard advancedWizard1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage1;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage advancedWizardPage2;
    }
}

