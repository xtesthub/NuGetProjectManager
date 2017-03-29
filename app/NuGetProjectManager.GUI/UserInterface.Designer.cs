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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.newListBoxProjectDir = new System.Windows.Forms.ListBox();
            this.newListBoxVersionList = new System.Windows.Forms.ListBox();
            this.newCheckedListBoxDllList = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProjectList
            // 
            this.lbProjectList.FormattingEnabled = true;
            this.lbProjectList.Location = new System.Drawing.Point(12, 41);
            this.lbProjectList.Name = "lbProjectList";
            this.lbProjectList.Size = new System.Drawing.Size(200, 82);
            this.lbProjectList.TabIndex = 0;
            this.lbProjectList.SelectedIndexChanged += new System.EventHandler(this.lbProjectList_SelectedIndexChanged);
            // 
            // clbAssemblySelect
            // 
            this.clbAssemblySelect.FormattingEnabled = true;
            this.clbAssemblySelect.Location = new System.Drawing.Point(218, 41);
            this.clbAssemblySelect.Name = "clbAssemblySelect";
            this.clbAssemblySelect.Size = new System.Drawing.Size(200, 79);
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
            // newListBoxProjectDir
            // 
            this.newListBoxProjectDir.Location = new System.Drawing.Point(22, 317);
            this.newListBoxProjectDir.Name = "newListBoxProjectDir";
            this.newListBoxProjectDir.Size = new System.Drawing.Size(142, 121);
            this.newListBoxProjectDir.TabIndex = 5;
            this.newListBoxProjectDir.SelectedIndexChanged += new System.EventHandler(this.newListBoxProjectDir_SelectedIndexChanged);
            // 
            // newListBoxVersionList
            // 
            this.newListBoxVersionList.FormattingEnabled = true;
            this.newListBoxVersionList.Location = new System.Drawing.Point(181, 317);
            this.newListBoxVersionList.Name = "newListBoxVersionList";
            this.newListBoxVersionList.Size = new System.Drawing.Size(117, 121);
            this.newListBoxVersionList.TabIndex = 6;
            // 
            // newCheckedListBoxDllList
            // 
            this.newCheckedListBoxDllList.FormattingEnabled = true;
            this.newCheckedListBoxDllList.Location = new System.Drawing.Point(313, 317);
            this.newCheckedListBoxDllList.Name = "newCheckedListBoxDllList";
            this.newCheckedListBoxDllList.Size = new System.Drawing.Size(120, 124);
            this.newCheckedListBoxDllList.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newCheckedListBoxDllList);
            this.Controls.Add(this.newListBoxVersionList);
            this.Controls.Add(this.newListBoxProjectDir);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox newListBoxProjectDir;
        private System.Windows.Forms.ListBox newListBoxVersionList;
        private System.Windows.Forms.CheckedListBox newCheckedListBoxDllList;
        private System.Windows.Forms.Button button1;
    }
}

