
namespace WinFormEmailWriter
{
  partial class FrmDataEditor
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
      this.BtnInitialize = new System.Windows.Forms.Button();
      this.BtnChangePath = new System.Windows.Forms.Button();
      this.LblPath = new System.Windows.Forms.Label();
      this.TabTable = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.tabPage6 = new System.Windows.Forms.TabPage();
      this.tabPage7 = new System.Windows.Forms.TabPage();
      this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
      this.dataGridViewManager = new System.Windows.Forms.DataGridView();
      this.dataGridViewTemplateGroup = new System.Windows.Forms.DataGridView();
      this.dataGridViewTemplate = new System.Windows.Forms.DataGridView();
      this.dataGridViewReplacer = new System.Windows.Forms.DataGridView();
      this.dataGridViewFileName = new System.Windows.Forms.DataGridView();
      this.TabTable.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.tabPage6.SuspendLayout();
      this.tabPage7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplateGroup)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReplacer)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileName)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnInitialize
      // 
      this.BtnInitialize.Location = new System.Drawing.Point(13, 13);
      this.BtnInitialize.Name = "BtnInitialize";
      this.BtnInitialize.Size = new System.Drawing.Size(75, 23);
      this.BtnInitialize.TabIndex = 0;
      this.BtnInitialize.Text = "DB 초기화";
      this.BtnInitialize.UseVisualStyleBackColor = true;
      // 
      // BtnChangePath
      // 
      this.BtnChangePath.Location = new System.Drawing.Point(110, 13);
      this.BtnChangePath.Name = "BtnChangePath";
      this.BtnChangePath.Size = new System.Drawing.Size(94, 23);
      this.BtnChangePath.TabIndex = 1;
      this.BtnChangePath.Text = "DB 경로 변경";
      this.BtnChangePath.UseVisualStyleBackColor = true;
      // 
      // LblPath
      // 
      this.LblPath.AutoSize = true;
      this.LblPath.Location = new System.Drawing.Point(221, 13);
      this.LblPath.Name = "LblPath";
      this.LblPath.Size = new System.Drawing.Size(51, 15);
      this.LblPath.TabIndex = 2;
      this.LblPath.Text = "DB 경로";
      // 
      // TabTable
      // 
      this.TabTable.Controls.Add(this.tabPage1);
      this.TabTable.Controls.Add(this.tabPage2);
      this.TabTable.Controls.Add(this.tabPage3);
      this.TabTable.Controls.Add(this.tabPage4);
      this.TabTable.Controls.Add(this.tabPage5);
      this.TabTable.Controls.Add(this.tabPage6);
      this.TabTable.Controls.Add(this.tabPage7);
      this.TabTable.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabTable.Location = new System.Drawing.Point(0, 0);
      this.TabTable.Name = "TabTable";
      this.TabTable.SelectedIndex = 0;
      this.TabTable.Size = new System.Drawing.Size(800, 450);
      this.TabTable.TabIndex = 4;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dataGridViewCompany);
      this.tabPage1.Location = new System.Drawing.Point(4, 24);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(792, 422);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "회사";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dataGridViewDepartment);
      this.tabPage2.Location = new System.Drawing.Point(4, 24);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(792, 422);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "부서";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // dataGridViewDepartment
      // 
      this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewDepartment.Location = new System.Drawing.Point(3, 3);
      this.dataGridViewDepartment.Name = "dataGridViewDepartment";
      this.dataGridViewDepartment.RowTemplate.Height = 25;
      this.dataGridViewDepartment.Size = new System.Drawing.Size(786, 416);
      this.dataGridViewDepartment.TabIndex = 0;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.dataGridViewManager);
      this.tabPage3.Location = new System.Drawing.Point(4, 24);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(792, 422);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "담당자";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.dataGridViewTemplateGroup);
      this.tabPage4.Location = new System.Drawing.Point(4, 24);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(792, 422);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "템플릿그룹";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.dataGridViewTemplate);
      this.tabPage5.Location = new System.Drawing.Point(4, 24);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Size = new System.Drawing.Size(792, 422);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "템플릿";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // tabPage6
      // 
      this.tabPage6.Controls.Add(this.dataGridViewReplacer);
      this.tabPage6.Location = new System.Drawing.Point(4, 24);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Size = new System.Drawing.Size(792, 422);
      this.tabPage6.TabIndex = 5;
      this.tabPage6.Text = "대체텍스트";
      this.tabPage6.UseVisualStyleBackColor = true;
      // 
      // tabPage7
      // 
      this.tabPage7.Controls.Add(this.dataGridViewFileName);
      this.tabPage7.Location = new System.Drawing.Point(4, 24);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Size = new System.Drawing.Size(792, 422);
      this.tabPage7.TabIndex = 6;
      this.tabPage7.Text = "첨부파일명";
      this.tabPage7.UseVisualStyleBackColor = true;
      // 
      // dataGridViewCompany
      // 
      this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewCompany.Location = new System.Drawing.Point(3, 3);
      this.dataGridViewCompany.Name = "dataGridViewCompany";
      this.dataGridViewCompany.RowTemplate.Height = 25;
      this.dataGridViewCompany.Size = new System.Drawing.Size(786, 416);
      this.dataGridViewCompany.TabIndex = 0;
      // 
      // dataGridViewManager
      // 
      this.dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewManager.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewManager.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewManager.Name = "dataGridViewManager";
      this.dataGridViewManager.RowTemplate.Height = 25;
      this.dataGridViewManager.Size = new System.Drawing.Size(792, 422);
      this.dataGridViewManager.TabIndex = 0;
      // 
      // dataGridViewTemplateGroup
      // 
      this.dataGridViewTemplateGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTemplateGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewTemplateGroup.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewTemplateGroup.Name = "dataGridViewTemplateGroup";
      this.dataGridViewTemplateGroup.RowTemplate.Height = 25;
      this.dataGridViewTemplateGroup.Size = new System.Drawing.Size(792, 422);
      this.dataGridViewTemplateGroup.TabIndex = 0;
      // 
      // dataGridViewTemplate
      // 
      this.dataGridViewTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewTemplate.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewTemplate.Name = "dataGridViewTemplate";
      this.dataGridViewTemplate.RowTemplate.Height = 25;
      this.dataGridViewTemplate.Size = new System.Drawing.Size(792, 422);
      this.dataGridViewTemplate.TabIndex = 0;
      // 
      // dataGridViewReplacer
      // 
      this.dataGridViewReplacer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewReplacer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewReplacer.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewReplacer.Name = "dataGridViewReplacer";
      this.dataGridViewReplacer.RowTemplate.Height = 25;
      this.dataGridViewReplacer.Size = new System.Drawing.Size(792, 422);
      this.dataGridViewReplacer.TabIndex = 0;
      // 
      // dataGridViewFileName
      // 
      this.dataGridViewFileName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewFileName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewFileName.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewFileName.Name = "dataGridViewFileName";
      this.dataGridViewFileName.RowTemplate.Height = 25;
      this.dataGridViewFileName.Size = new System.Drawing.Size(792, 422);
      this.dataGridViewFileName.TabIndex = 0;
      // 
      // FrmDataEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.TabTable);
      this.Controls.Add(this.LblPath);
      this.Controls.Add(this.BtnChangePath);
      this.Controls.Add(this.BtnInitialize);
      this.Name = "FrmDataEditor";
      this.Text = "FrmDataEditor";
      this.TabTable.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      this.tabPage6.ResumeLayout(false);
      this.tabPage7.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplateGroup)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReplacer)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileName)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnInitialize;
    private System.Windows.Forms.Button BtnChangePath;
    private System.Windows.Forms.Label LblPath;
    private System.Windows.Forms.TabControl TabTable;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.TabPage tabPage6;
    private System.Windows.Forms.TabPage tabPage7;
    private System.Windows.Forms.DataGridView dataGridViewDepartment;
    private System.Windows.Forms.DataGridView dataGridViewCompany;
    private System.Windows.Forms.DataGridView dataGridViewManager;
    private System.Windows.Forms.DataGridView dataGridViewTemplateGroup;
    private System.Windows.Forms.DataGridView dataGridViewTemplate;
    private System.Windows.Forms.DataGridView dataGridViewReplacer;
    private System.Windows.Forms.DataGridView dataGridViewFileName;
  }
}