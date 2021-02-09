
namespace WinFormEmailWriter
{
  partial class FrmMailWriter
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
      this.LblCompany = new System.Windows.Forms.Label();
      this.CboCompany = new System.Windows.Forms.ComboBox();
      this.LblManager = new System.Windows.Forms.Label();
      this.CboManager = new System.Windows.Forms.ComboBox();
      this.LblTemplate = new System.Windows.Forms.Label();
      this.CboTemplate = new System.Windows.Forms.ComboBox();
      this.LblDepartment = new System.Windows.Forms.Label();
      this.CboDepartment = new System.Windows.Forms.ComboBox();
      this.GrpAttachedFile = new System.Windows.Forms.GroupBox();
      this.BtnAddFile = new System.Windows.Forms.Button();
      this.GrpPreview = new System.Windows.Forms.GroupBox();
      this.BtnWriteMail = new System.Windows.Forms.Button();
      this.PreviewWebBrowser = new System.Windows.Forms.WebBrowser();
      this.LblTemplateGroup = new System.Windows.Forms.Label();
      this.CboTemplateGroup = new System.Windows.Forms.ComboBox();
      this.FLPAttachedFiles = new System.Windows.Forms.FlowLayoutPanel();
      this.GrpAttachedFile.SuspendLayout();
      this.GrpPreview.SuspendLayout();
      this.SuspendLayout();
      // 
      // LblCompany
      // 
      this.LblCompany.AutoSize = true;
      this.LblCompany.Location = new System.Drawing.Point(12, 9);
      this.LblCompany.Name = "LblCompany";
      this.LblCompany.Size = new System.Drawing.Size(43, 15);
      this.LblCompany.TabIndex = 0;
      this.LblCompany.Text = "회사명";
      // 
      // CboCompany
      // 
      this.CboCompany.FormattingEnabled = true;
      this.CboCompany.Location = new System.Drawing.Point(61, 6);
      this.CboCompany.Name = "CboCompany";
      this.CboCompany.Size = new System.Drawing.Size(121, 23);
      this.CboCompany.TabIndex = 1;
      this.CboCompany.SelectedIndexChanged += new System.EventHandler(this.CboCompany_SelectedIndexChanged);
      // 
      // LblManager
      // 
      this.LblManager.AutoSize = true;
      this.LblManager.Location = new System.Drawing.Point(415, 9);
      this.LblManager.Name = "LblManager";
      this.LblManager.Size = new System.Drawing.Size(55, 15);
      this.LblManager.TabIndex = 0;
      this.LblManager.Text = "담당자명";
      // 
      // CboManager
      // 
      this.CboManager.FormattingEnabled = true;
      this.CboManager.Location = new System.Drawing.Point(476, 6);
      this.CboManager.Name = "CboManager";
      this.CboManager.Size = new System.Drawing.Size(121, 23);
      this.CboManager.TabIndex = 1;
      this.CboManager.SelectedIndexChanged += new System.EventHandler(this.CboManager_SelectedIndexChanged);
      // 
      // LblTemplate
      // 
      this.LblTemplate.AutoSize = true;
      this.LblTemplate.Location = new System.Drawing.Point(891, 9);
      this.LblTemplate.Name = "LblTemplate";
      this.LblTemplate.Size = new System.Drawing.Size(31, 15);
      this.LblTemplate.TabIndex = 0;
      this.LblTemplate.Text = "양식";
      // 
      // CboTemplate
      // 
      this.CboTemplate.FormattingEnabled = true;
      this.CboTemplate.Location = new System.Drawing.Point(928, 6);
      this.CboTemplate.Name = "CboTemplate";
      this.CboTemplate.Size = new System.Drawing.Size(121, 23);
      this.CboTemplate.TabIndex = 1;
      this.CboTemplate.SelectedIndexChanged += new System.EventHandler(this.CboTemplate_SelectedIndexChanged);
      // 
      // LblDepartment
      // 
      this.LblDepartment.AutoSize = true;
      this.LblDepartment.Location = new System.Drawing.Point(205, 9);
      this.LblDepartment.Name = "LblDepartment";
      this.LblDepartment.Size = new System.Drawing.Size(43, 15);
      this.LblDepartment.TabIndex = 0;
      this.LblDepartment.Text = "부서명";
      // 
      // CboDepartment
      // 
      this.CboDepartment.FormattingEnabled = true;
      this.CboDepartment.Location = new System.Drawing.Point(266, 6);
      this.CboDepartment.Name = "CboDepartment";
      this.CboDepartment.Size = new System.Drawing.Size(121, 23);
      this.CboDepartment.TabIndex = 1;
      this.CboDepartment.SelectedIndexChanged += new System.EventHandler(this.CboDepartment_SelectedIndexChanged);
      // 
      // GrpAttachedFile
      // 
      this.GrpAttachedFile.Controls.Add(this.FLPAttachedFiles);
      this.GrpAttachedFile.Controls.Add(this.BtnAddFile);
      this.GrpAttachedFile.Location = new System.Drawing.Point(12, 44);
      this.GrpAttachedFile.Name = "GrpAttachedFile";
      this.GrpAttachedFile.Size = new System.Drawing.Size(1061, 88);
      this.GrpAttachedFile.TabIndex = 3;
      this.GrpAttachedFile.TabStop = false;
      this.GrpAttachedFile.Text = "첨부파일";
      // 
      // BtnAddFile
      // 
      this.BtnAddFile.Location = new System.Drawing.Point(68, 0);
      this.BtnAddFile.Name = "BtnAddFile";
      this.BtnAddFile.Size = new System.Drawing.Size(75, 23);
      this.BtnAddFile.TabIndex = 0;
      this.BtnAddFile.Text = "파일추가";
      this.BtnAddFile.UseVisualStyleBackColor = true;
      this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
      // 
      // GrpPreview
      // 
      this.GrpPreview.Controls.Add(this.BtnWriteMail);
      this.GrpPreview.Controls.Add(this.PreviewWebBrowser);
      this.GrpPreview.Location = new System.Drawing.Point(12, 149);
      this.GrpPreview.Name = "GrpPreview";
      this.GrpPreview.Size = new System.Drawing.Size(1061, 289);
      this.GrpPreview.TabIndex = 3;
      this.GrpPreview.TabStop = false;
      this.GrpPreview.Text = "미리보기";
      // 
      // BtnWriteMail
      // 
      this.BtnWriteMail.Location = new System.Drawing.Point(68, 0);
      this.BtnWriteMail.Name = "BtnWriteMail";
      this.BtnWriteMail.Size = new System.Drawing.Size(75, 23);
      this.BtnWriteMail.TabIndex = 0;
      this.BtnWriteMail.Text = "메일작성";
      this.BtnWriteMail.UseVisualStyleBackColor = true;
      this.BtnWriteMail.Click += new System.EventHandler(this.BtnWriteMail_Click);
      // 
      // PreviewWebBrowser
      // 
      this.PreviewWebBrowser.Location = new System.Drawing.Point(0, 25);
      this.PreviewWebBrowser.Name = "PreviewWebBrowser";
      this.PreviewWebBrowser.Size = new System.Drawing.Size(776, 289);
      this.PreviewWebBrowser.TabIndex = 1;
      // 
      // LblTemplateGroup
      // 
      this.LblTemplateGroup.AutoSize = true;
      this.LblTemplateGroup.Location = new System.Drawing.Point(648, 9);
      this.LblTemplateGroup.Name = "LblTemplateGroup";
      this.LblTemplateGroup.Size = new System.Drawing.Size(43, 15);
      this.LblTemplateGroup.TabIndex = 0;
      this.LblTemplateGroup.Text = "그룹명";
      // 
      // CboTemplateGroup
      // 
      this.CboTemplateGroup.FormattingEnabled = true;
      this.CboTemplateGroup.Location = new System.Drawing.Point(709, 6);
      this.CboTemplateGroup.Name = "CboTemplateGroup";
      this.CboTemplateGroup.Size = new System.Drawing.Size(121, 23);
      this.CboTemplateGroup.TabIndex = 1;
      this.CboTemplateGroup.SelectedIndexChanged += new System.EventHandler(this.CboTemplateGroup_SelectedIndexChanged);
      // 
      // FLPAttachedFiles
      // 
      this.FLPAttachedFiles.Location = new System.Drawing.Point(7, 23);
      this.FLPAttachedFiles.Name = "FLPAttachedFiles";
      this.FLPAttachedFiles.Size = new System.Drawing.Size(1048, 76);
      this.FLPAttachedFiles.TabIndex = 1;
      // 
      // FrmMailWriter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1085, 450);
      this.Controls.Add(this.GrpPreview);
      this.Controls.Add(this.GrpAttachedFile);
      this.Controls.Add(this.CboTemplate);
      this.Controls.Add(this.CboDepartment);
      this.Controls.Add(this.CboTemplateGroup);
      this.Controls.Add(this.CboManager);
      this.Controls.Add(this.CboCompany);
      this.Controls.Add(this.LblTemplate);
      this.Controls.Add(this.LblDepartment);
      this.Controls.Add(this.LblTemplateGroup);
      this.Controls.Add(this.LblManager);
      this.Controls.Add(this.LblCompany);
      this.Name = "FrmMailWriter";
      this.Text = "메일 작성 프로그램";
      this.Load += new System.EventHandler(this.FrmMailWriter_Load);
      this.GrpAttachedFile.ResumeLayout(false);
      this.GrpPreview.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblCompany;
    private System.Windows.Forms.ComboBox CboCompany;
    private System.Windows.Forms.Label LblManager;
    private System.Windows.Forms.ComboBox CboManager;
    private System.Windows.Forms.Label LblTemplate;
    private System.Windows.Forms.ComboBox CboTemplate;
    private System.Windows.Forms.Label LblDepartment;
    private System.Windows.Forms.ComboBox CboDepartment;
    private System.Windows.Forms.GroupBox GrpAttachedFile;
    private System.Windows.Forms.Button BtnAddFile;
    private System.Windows.Forms.GroupBox GrpPreview;
    private System.Windows.Forms.Button BtnWriteMail;
    private System.Windows.Forms.WebBrowser PreviewWebBrowser;
    private System.Windows.Forms.Label LblTemplateGroup;
    private System.Windows.Forms.ComboBox CboTemplateGroup;
    private System.Windows.Forms.FlowLayoutPanel FLPAttachedFiles;
  }
}

