namespace NuGetProjectManager.GUI
{
    partial class UserInterface
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
            this.lbProjectList = new System.Windows.Forms.ListBox();
            this.clbAssemblieSelect = new System.Windows.Forms.CheckedListBox();
            this.btnFillProjectList = new System.Windows.Forms.Button();
            this.btnFillAssembleList = new System.Windows.Forms.Button();
            this.btnCreateNuspec = new System.Windows.Forms.Button();
            this.lNuspecOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbProjectList
            // 
            this.lbProjectList.FormattingEnabled = true;
            this.lbProjectList.Location = new System.Drawing.Point(12, 41);
            this.lbProjectList.Name = "lbProjectList";
            this.lbProjectList.Size = new System.Drawing.Size(200, 264);
            this.lbProjectList.TabIndex = 0;
            // 
            // clbAssemblieSelect
            // 
            this.clbAssemblieSelect.FormattingEnabled = true;
            this.clbAssemblieSelect.Location = new System.Drawing.Point(229, 40);
            this.clbAssemblieSelect.Name = "clbAssemblieSelect";
            this.clbAssemblieSelect.Size = new System.Drawing.Size(200, 259);
            this.clbAssemblieSelect.TabIndex = 1;
            // 
            // btnFillProjectList
            // 
            this.btnFillProjectList.Location = new System.Drawing.Point(12, 12);
            this.btnFillProjectList.Name = "btnFillProjectList";
            this.btnFillProjectList.Size = new System.Drawing.Size(75, 23);
            this.btnFillProjectList.TabIndex = 2;
            this.btnFillProjectList.Text = "Fill Projectlist";
            this.btnFillProjectList.UseVisualStyleBackColor = true;
            this.btnFillProjectList.Click += new System.EventHandler(this.btnFillProjectList_Click);
            // 
            // btnFillAssembleList
            // 
            this.btnFillAssembleList.Location = new System.Drawing.Point(116, 12);
            this.btnFillAssembleList.Name = "btnFillAssembleList";
            this.btnFillAssembleList.Size = new System.Drawing.Size(96, 23);
            this.btnFillAssembleList.TabIndex = 3;
            this.btnFillAssembleList.Text = "Load Project Info";
            this.btnFillAssembleList.UseVisualStyleBackColor = true;
            this.btnFillAssembleList.Click += new System.EventHandler(this.btnFillAssembleList_Click);
            // 
            // btnCreateNuspec
            // 
            this.btnCreateNuspec.Location = new System.Drawing.Point(229, 12);
            this.btnCreateNuspec.Name = "btnCreateNuspec";
            this.btnCreateNuspec.Size = new System.Drawing.Size(99, 23);
            this.btnCreateNuspec.TabIndex = 4;
            this.btnCreateNuspec.Text = "Create .nuspec";
            this.btnCreateNuspec.UseVisualStyleBackColor = true;
            this.btnCreateNuspec.Click += new System.EventHandler(this.btnCreateNuspec_Click);
            // 
            // lNuspecOutput
            // 
            this.lNuspecOutput.AutoSize = true;
            this.lNuspecOutput.Location = new System.Drawing.Point(435, 41);
            this.lNuspecOutput.Name = "lNuspecOutput";
            this.lNuspecOutput.Size = new System.Drawing.Size(39, 13);
            this.lNuspecOutput.TabIndex = 5;
            this.lNuspecOutput.Text = "Output";
            this.lNuspecOutput.Click += new System.EventHandler(this.lNuspecOutput_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lNuspecOutput);
            this.Controls.Add(this.btnCreateNuspec);
            this.Controls.Add(this.btnFillAssembleList);
            this.Controls.Add(this.btnFillProjectList);
            this.Controls.Add(this.clbAssemblieSelect);
            this.Controls.Add(this.lbProjectList);
            this.Name = "UserInterface";
            this.Text = "NuGetProjectManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProjectList;
        private System.Windows.Forms.CheckedListBox clbAssemblieSelect;
        private System.Windows.Forms.Button btnFillProjectList;
        private System.Windows.Forms.Button btnFillAssembleList;
        private System.Windows.Forms.Button btnCreateNuspec;
        private System.Windows.Forms.Label lNuspecOutput;
    }
}

