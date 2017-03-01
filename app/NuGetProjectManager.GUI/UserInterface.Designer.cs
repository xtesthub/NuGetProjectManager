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
            this.clbAssemblySelect = new System.Windows.Forms.CheckedListBox();
            this.btnFillProjectList = new System.Windows.Forms.Button();
            this.btnCreateNuspec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProjectList
            // 
            this.lbProjectList.FormattingEnabled = true;
            this.lbProjectList.Location = new System.Drawing.Point(12, 41);
            this.lbProjectList.Name = "lbProjectList";
            this.lbProjectList.Size = new System.Drawing.Size(200, 264);
            this.lbProjectList.TabIndex = 0;
            this.lbProjectList.SelectedIndexChanged += new System.EventHandler(this.lbProjectList_SelectedIndexChanged);
            // 
            // clbAssemblySelect
            // 
            this.clbAssemblySelect.FormattingEnabled = true;
            this.clbAssemblySelect.Location = new System.Drawing.Point(229, 40);
            this.clbAssemblySelect.Name = "clbAssemblySelect";
            this.clbAssemblySelect.Size = new System.Drawing.Size(200, 259);
            this.clbAssemblySelect.TabIndex = 1;
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
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCreateNuspec);
            this.Controls.Add(this.btnFillProjectList);
            this.Controls.Add(this.clbAssemblySelect);
            this.Controls.Add(this.lbProjectList);
            this.Name = "UserInterface";
            this.Text = "NuGetProjectManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProjectList;
        private System.Windows.Forms.CheckedListBox clbAssemblySelect;
        private System.Windows.Forms.Button btnFillProjectList;
        private System.Windows.Forms.Button btnCreateNuspec;
    }
}

