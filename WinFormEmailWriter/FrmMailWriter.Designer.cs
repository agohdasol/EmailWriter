
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
      this.FLPAttachedFiles = new System.Windows.Forms.FlowLayoutPanel();
      this.BtnRemoveAllFiles = new System.Windows.Forms.Button();
      this.BtnAddFile = new System.Windows.Forms.Button();
      this.GrpPreview = new System.Windows.Forms.GroupBox();
      this.BtnCreateMail = new System.Windows.Forms.Button();
      this.PreviewWebBrowser = new System.Windows.Forms.WebBrowser();
      this.LblTemplateGroup = new System.Windows.Forms.Label();
      this.CboTemplateGroup = new System.Windows.Forms.ComboBox();
      this.BtnWriteMail = new System.Windows.Forms.Button();
      this.GrpAttachedFile.SuspendLayout();
      this.GrpPreview.SuspendLayout();
      this.SuspendLayout();
      // 
      // LblCompany
      // 
      this.LblCompany.AutoSize = true;
      this.LblCompany.Location = new System.Drawing.Point(15, 12);
      this.LblCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblCompany.Name = "LblCompany";
      this.LblCompany.Size = new System.Drawing.Size(54, 20);
      this.LblCompany.TabIndex = 0;
      this.LblCompany.Text = "회사명";
      // 
      // CboCompany
      // 
      this.CboCompany.FormattingEnabled = true;
      this.CboCompany.Location = new System.Drawing.Point(78, 8);
      this.CboCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CboCompany.Name = "CboCompany";
      this.CboCompany.Size = new System.Drawing.Size(154, 28);
      this.CboCompany.TabIndex = 1;
      this.CboCompany.SelectedIndexChanged += new System.EventHandler(this.CboCompany_SelectedIndexChanged);
      // 
      // LblManager
      // 
      this.LblManager.AutoSize = true;
      this.LblManager.Location = new System.Drawing.Point(534, 12);
      this.LblManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblManager.Name = "LblManager";
      this.LblManager.Size = new System.Drawing.Size(69, 20);
      this.LblManager.TabIndex = 0;
      this.LblManager.Text = "담당자명";
      // 
      // CboManager
      // 
      this.CboManager.FormattingEnabled = true;
      this.CboManager.Location = new System.Drawing.Point(612, 8);
      this.CboManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CboManager.Name = "CboManager";
      this.CboManager.Size = new System.Drawing.Size(154, 28);
      this.CboManager.TabIndex = 1;
      this.CboManager.SelectedIndexChanged += new System.EventHandler(this.CboManager_SelectedIndexChanged);
      // 
      // LblTemplate
      // 
      this.LblTemplate.AutoSize = true;
      this.LblTemplate.Location = new System.Drawing.Point(1146, 12);
      this.LblTemplate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblTemplate.Name = "LblTemplate";
      this.LblTemplate.Size = new System.Drawing.Size(39, 20);
      this.LblTemplate.TabIndex = 0;
      this.LblTemplate.Text = "양식";
      // 
      // CboTemplate
      // 
      this.CboTemplate.FormattingEnabled = true;
      this.CboTemplate.Location = new System.Drawing.Point(1193, 8);
      this.CboTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CboTemplate.Name = "CboTemplate";
      this.CboTemplate.Size = new System.Drawing.Size(154, 28);
      this.CboTemplate.TabIndex = 1;
      this.CboTemplate.SelectedIndexChanged += new System.EventHandler(this.CboTemplate_SelectedIndexChanged);
      // 
      // LblDepartment
      // 
      this.LblDepartment.AutoSize = true;
      this.LblDepartment.Location = new System.Drawing.Point(264, 12);
      this.LblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblDepartment.Name = "LblDepartment";
      this.LblDepartment.Size = new System.Drawing.Size(54, 20);
      this.LblDepartment.TabIndex = 0;
      this.LblDepartment.Text = "부서명";
      // 
      // CboDepartment
      // 
      this.CboDepartment.FormattingEnabled = true;
      this.CboDepartment.Location = new System.Drawing.Point(342, 8);
      this.CboDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CboDepartment.Name = "CboDepartment";
      this.CboDepartment.Size = new System.Drawing.Size(154, 28);
      this.CboDepartment.TabIndex = 1;
      this.CboDepartment.SelectedIndexChanged += new System.EventHandler(this.CboDepartment_SelectedIndexChanged);
      // 
      // GrpAttachedFile
      // 
      this.GrpAttachedFile.Controls.Add(this.FLPAttachedFiles);
      this.GrpAttachedFile.Controls.Add(this.BtnRemoveAllFiles);
      this.GrpAttachedFile.Controls.Add(this.BtnAddFile);
      this.GrpAttachedFile.Location = new System.Drawing.Point(15, 59);
      this.GrpAttachedFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.GrpAttachedFile.Name = "GrpAttachedFile";
      this.GrpAttachedFile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.GrpAttachedFile.Size = new System.Drawing.Size(1364, 117);
      this.GrpAttachedFile.TabIndex = 3;
      this.GrpAttachedFile.TabStop = false;
      this.GrpAttachedFile.Text = "첨부파일";
      // 
      // FLPAttachedFiles
      // 
      this.FLPAttachedFiles.AutoScroll = true;
      this.FLPAttachedFiles.Location = new System.Drawing.Point(9, 31);
      this.FLPAttachedFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.FLPAttachedFiles.Name = "FLPAttachedFiles";
      this.FLPAttachedFiles.Size = new System.Drawing.Size(1347, 79);
      this.FLPAttachedFiles.TabIndex = 1;
      // 
      // BtnRemoveAllFiles
      // 
      this.BtnRemoveAllFiles.Location = new System.Drawing.Point(207, 0);
      this.BtnRemoveAllFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.BtnRemoveAllFiles.Name = "BtnRemoveAllFiles";
      this.BtnRemoveAllFiles.Size = new System.Drawing.Size(96, 31);
      this.BtnRemoveAllFiles.TabIndex = 0;
      this.BtnRemoveAllFiles.Text = "모두제거";
      this.BtnRemoveAllFiles.UseVisualStyleBackColor = true;
      this.BtnRemoveAllFiles.Click += new System.EventHandler(this.BtnRemoveAllFiles_Click);
      // 
      // BtnAddFile
      // 
      this.BtnAddFile.Location = new System.Drawing.Point(87, 0);
      this.BtnAddFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.BtnAddFile.Name = "BtnAddFile";
      this.BtnAddFile.Size = new System.Drawing.Size(96, 31);
      this.BtnAddFile.TabIndex = 0;
      this.BtnAddFile.Text = "파일추가";
      this.BtnAddFile.UseVisualStyleBackColor = true;
      this.BtnAddFile.Click += new System.EventHandler(this.BtnAddFile_Click);
      // 
      // GrpPreview
      // 
      this.GrpPreview.Controls.Add(this.BtnWriteMail);
      this.GrpPreview.Controls.Add(this.BtnCreateMail);
      this.GrpPreview.Controls.Add(this.PreviewWebBrowser);
      this.GrpPreview.Location = new System.Drawing.Point(15, 199);
      this.GrpPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.GrpPreview.Name = "GrpPreview";
      this.GrpPreview.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.GrpPreview.Size = new System.Drawing.Size(1364, 385);
      this.GrpPreview.TabIndex = 3;
      this.GrpPreview.TabStop = false;
      this.GrpPreview.Text = "미리보기";
      // 
      // BtnCreateMail
      // 
      this.BtnCreateMail.Location = new System.Drawing.Point(87, 0);
      this.BtnCreateMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.BtnCreateMail.Name = "BtnCreateMail";
      this.BtnCreateMail.Size = new System.Drawing.Size(96, 31);
      this.BtnCreateMail.TabIndex = 0;
      this.BtnCreateMail.Text = "메일생성";
      this.BtnCreateMail.UseVisualStyleBackColor = true;
      this.BtnCreateMail.Click += new System.EventHandler(this.BtnCreateMail_Click);
      // 
      // PreviewWebBrowser
      // 
      this.PreviewWebBrowser.Location = new System.Drawing.Point(0, 33);
      this.PreviewWebBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.PreviewWebBrowser.Name = "PreviewWebBrowser";
      this.PreviewWebBrowser.Size = new System.Drawing.Size(998, 385);
      this.PreviewWebBrowser.TabIndex = 1;
      // 
      // LblTemplateGroup
      // 
      this.LblTemplateGroup.AutoSize = true;
      this.LblTemplateGroup.Location = new System.Drawing.Point(833, 12);
      this.LblTemplateGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblTemplateGroup.Name = "LblTemplateGroup";
      this.LblTemplateGroup.Size = new System.Drawing.Size(54, 20);
      this.LblTemplateGroup.TabIndex = 0;
      this.LblTemplateGroup.Text = "그룹명";
      // 
      // CboTemplateGroup
      // 
      this.CboTemplateGroup.FormattingEnabled = true;
      this.CboTemplateGroup.Location = new System.Drawing.Point(912, 8);
      this.CboTemplateGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CboTemplateGroup.Name = "CboTemplateGroup";
      this.CboTemplateGroup.Size = new System.Drawing.Size(154, 28);
      this.CboTemplateGroup.TabIndex = 1;
      this.CboTemplateGroup.SelectedIndexChanged += new System.EventHandler(this.CboTemplateGroup_SelectedIndexChanged);
      // 
      // BtnWriteMail
      // 
      this.BtnWriteMail.Location = new System.Drawing.Point(207, 0);
      this.BtnWriteMail.Name = "BtnWriteMail";
      this.BtnWriteMail.Size = new System.Drawing.Size(94, 29);
      this.BtnWriteMail.TabIndex = 2;
      this.BtnWriteMail.Text = "메일쓰기";
      this.BtnWriteMail.UseVisualStyleBackColor = true;
      this.BtnWriteMail.Click += new System.EventHandler(this.BtnWriteMail_Click);
      // 
      // FrmMailWriter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1395, 600);
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
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    private System.Windows.Forms.Button BtnCreateMail;
    private System.Windows.Forms.WebBrowser PreviewWebBrowser;
    private System.Windows.Forms.Label LblTemplateGroup;
    private System.Windows.Forms.ComboBox CboTemplateGroup;
    private System.Windows.Forms.FlowLayoutPanel FLPAttachedFiles;
    private System.Windows.Forms.Button BtnRemoveAllFiles;
    private System.Windows.Forms.Button BtnWriteMail;
  }
}

