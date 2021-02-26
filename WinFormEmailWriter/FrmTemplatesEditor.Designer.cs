﻿
namespace WinFormEmailWriter
{
  partial class FrmTemplatesEditor
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
      this.BtnLoad = new System.Windows.Forms.Button();
      this.BtnSave = new System.Windows.Forms.Button();
      this.templateEditorWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
      ((System.ComponentModel.ISupportInitialize)(this.templateEditorWebView)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnLoad
      // 
      this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.BtnLoad.Location = new System.Drawing.Point(12, 421);
      this.BtnLoad.Name = "BtnLoad";
      this.BtnLoad.Size = new System.Drawing.Size(109, 23);
      this.BtnLoad.TabIndex = 1;
      this.BtnLoad.Text = "템플릿 불러오기";
      this.BtnLoad.UseVisualStyleBackColor = true;
      // 
      // BtnSave
      // 
      this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.BtnSave.Location = new System.Drawing.Point(127, 421);
      this.BtnSave.Name = "BtnSave";
      this.BtnSave.Size = new System.Drawing.Size(108, 23);
      this.BtnSave.TabIndex = 2;
      this.BtnSave.Text = "템플릿 저장하기";
      this.BtnSave.UseVisualStyleBackColor = true;
      // 
      // templateEditorWebView
      // 
      this.templateEditorWebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.templateEditorWebView.CreationProperties = null;
      this.templateEditorWebView.Location = new System.Drawing.Point(13, 13);
      this.templateEditorWebView.Name = "templateEditorWebView";
      this.templateEditorWebView.Size = new System.Drawing.Size(775, 402);
      this.templateEditorWebView.Source = new System.Uri(@"C:\EmailWriter\WinFormEmailWriter\summernote\htmleditor.html", System.UriKind.Absolute);
      //Need Edge Beta Channel
      this.templateEditorWebView.TabIndex = 3;
      this.templateEditorWebView.ZoomFactor = 1D;
      // 
      // FrmTemplatesEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.templateEditorWebView);
      this.Controls.Add(this.BtnSave);
      this.Controls.Add(this.BtnLoad);
      this.Name = "FrmTemplatesEditor";
      this.Text = "템플릿 편집기";
      ((System.ComponentModel.ISupportInitialize)(this.templateEditorWebView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button BtnLoad;
    private System.Windows.Forms.Button BtnSave;
    private Microsoft.Web.WebView2.WinForms.WebView2 templateEditorWebView;
  }
}