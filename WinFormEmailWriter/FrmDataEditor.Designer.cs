
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
      this.BtnDeleteCompanyRow = new System.Windows.Forms.Button();
      this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.BtnDeleteDepartmentRow = new System.Windows.Forms.Button();
      this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.BtnDeleteManagerRow = new System.Windows.Forms.Button();
      this.dataGridViewManager = new System.Windows.Forms.DataGridView();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.BtnDeleteTemplateRow = new System.Windows.Forms.Button();
      this.dataGridViewTemplate = new System.Windows.Forms.DataGridView();
      this.tabPage6 = new System.Windows.Forms.TabPage();
      this.BtnDeleteReplacerRow = new System.Windows.Forms.Button();
      this.dataGridViewReplacer = new System.Windows.Forms.DataGridView();
      this.tabPage7 = new System.Windows.Forms.TabPage();
      this.BtnDeleteFileNameRow = new System.Windows.Forms.Button();
      this.dataGridViewFileName = new System.Windows.Forms.DataGridView();
      this.BtnSave = new System.Windows.Forms.Button();
      this.BtnDeleteTemplateGroupRow = new System.Windows.Forms.Button();
      this.dataGridViewTemplateGroup = new System.Windows.Forms.DataGridView();
      this.TabTable.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).BeginInit();
      this.tabPage4.SuspendLayout();
      this.tabPage5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).BeginInit();
      this.tabPage6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReplacer)).BeginInit();
      this.tabPage7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileName)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplateGroup)).BeginInit();
      this.SuspendLayout();
      // 
      // BtnInitialize
      // 
      this.BtnInitialize.Location = new System.Drawing.Point(15, 12);
      this.BtnInitialize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnInitialize.Name = "BtnInitialize";
      this.BtnInitialize.Size = new System.Drawing.Size(86, 22);
      this.BtnInitialize.TabIndex = 0;
      this.BtnInitialize.Text = "DB 초기화";
      this.BtnInitialize.UseVisualStyleBackColor = true;
      // 
      // BtnChangePath
      // 
      this.BtnChangePath.Location = new System.Drawing.Point(126, 12);
      this.BtnChangePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnChangePath.Name = "BtnChangePath";
      this.BtnChangePath.Size = new System.Drawing.Size(107, 22);
      this.BtnChangePath.TabIndex = 1;
      this.BtnChangePath.Text = "DB 경로 변경";
      this.BtnChangePath.UseVisualStyleBackColor = true;
      // 
      // LblPath
      // 
      this.LblPath.AutoSize = true;
      this.LblPath.Location = new System.Drawing.Point(253, 12);
      this.LblPath.Name = "LblPath";
      this.LblPath.Size = new System.Drawing.Size(62, 15);
      this.LblPath.TabIndex = 2;
      this.LblPath.Text = "DB 경로";
      // 
      // TabTable
      // 
      this.TabTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.TabTable.Controls.Add(this.tabPage1);
      this.TabTable.Controls.Add(this.tabPage2);
      this.TabTable.Controls.Add(this.tabPage3);
      this.TabTable.Controls.Add(this.tabPage4);
      this.TabTable.Controls.Add(this.tabPage5);
      this.TabTable.Controls.Add(this.tabPage6);
      this.TabTable.Controls.Add(this.tabPage7);
      this.TabTable.Location = new System.Drawing.Point(0, 42);
      this.TabTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.TabTable.Name = "TabTable";
      this.TabTable.SelectedIndex = 0;
      this.TabTable.Size = new System.Drawing.Size(914, 408);
      this.TabTable.TabIndex = 4;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.BtnDeleteCompanyRow);
      this.tabPage1.Controls.Add(this.dataGridViewCompany);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage1.Size = new System.Drawing.Size(906, 379);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "회사";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // BtnDeleteCompanyRow
      // 
      this.BtnDeleteCompanyRow.Location = new System.Drawing.Point(10, 2);
      this.BtnDeleteCompanyRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnDeleteCompanyRow.Name = "BtnDeleteCompanyRow";
      this.BtnDeleteCompanyRow.Size = new System.Drawing.Size(86, 22);
      this.BtnDeleteCompanyRow.TabIndex = 1;
      this.BtnDeleteCompanyRow.Text = "행 삭제";
      this.BtnDeleteCompanyRow.UseVisualStyleBackColor = true;
      this.BtnDeleteCompanyRow.Click += new System.EventHandler(this.BtnDeleteCompanyRow_Click);
      // 
      // dataGridViewCompany
      // 
      this.dataGridViewCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewCompany.Location = new System.Drawing.Point(3, 30);
      this.dataGridViewCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewCompany.Name = "dataGridViewCompany";
      this.dataGridViewCompany.RowHeadersWidth = 51;
      this.dataGridViewCompany.RowTemplate.Height = 25;
      this.dataGridViewCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewCompany.Size = new System.Drawing.Size(898, 348);
      this.dataGridViewCompany.TabIndex = 0;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.BtnDeleteDepartmentRow);
      this.tabPage2.Controls.Add(this.dataGridViewDepartment);
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage2.Size = new System.Drawing.Size(906, 379);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "부서";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // BtnDeleteDepartmentRow
      // 
      this.BtnDeleteDepartmentRow.Location = new System.Drawing.Point(10, 5);
      this.BtnDeleteDepartmentRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnDeleteDepartmentRow.Name = "BtnDeleteDepartmentRow";
      this.BtnDeleteDepartmentRow.Size = new System.Drawing.Size(86, 22);
      this.BtnDeleteDepartmentRow.TabIndex = 2;
      this.BtnDeleteDepartmentRow.Text = "행 삭제";
      this.BtnDeleteDepartmentRow.UseVisualStyleBackColor = true;
      this.BtnDeleteDepartmentRow.Click += new System.EventHandler(this.BtnDeleteDepartmentRow_Click);
      // 
      // dataGridViewDepartment
      // 
      this.dataGridViewDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDepartment.Location = new System.Drawing.Point(3, 34);
      this.dataGridViewDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewDepartment.Name = "dataGridViewDepartment";
      this.dataGridViewDepartment.RowHeadersWidth = 51;
      this.dataGridViewDepartment.RowTemplate.Height = 25;
      this.dataGridViewDepartment.Size = new System.Drawing.Size(898, 340);
      this.dataGridViewDepartment.TabIndex = 0;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.BtnDeleteManagerRow);
      this.tabPage3.Controls.Add(this.dataGridViewManager);
      this.tabPage3.Location = new System.Drawing.Point(4, 25);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(906, 379);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "담당자";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // BtnDeleteManagerRow
      // 
      this.BtnDeleteManagerRow.Location = new System.Drawing.Point(10, 6);
      this.BtnDeleteManagerRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnDeleteManagerRow.Name = "BtnDeleteManagerRow";
      this.BtnDeleteManagerRow.Size = new System.Drawing.Size(86, 22);
      this.BtnDeleteManagerRow.TabIndex = 2;
      this.BtnDeleteManagerRow.Text = "행 삭제";
      this.BtnDeleteManagerRow.UseVisualStyleBackColor = true;
      this.BtnDeleteManagerRow.Click += new System.EventHandler(this.BtnDeleteManagerRow_Click);
      // 
      // dataGridViewManager
      // 
      this.dataGridViewManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewManager.Location = new System.Drawing.Point(-9, 35);
      this.dataGridViewManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewManager.Name = "dataGridViewManager";
      this.dataGridViewManager.RowHeadersWidth = 51;
      this.dataGridViewManager.RowTemplate.Height = 25;
      this.dataGridViewManager.Size = new System.Drawing.Size(905, 345);
      this.dataGridViewManager.TabIndex = 0;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.BtnDeleteTemplateGroupRow);
      this.tabPage4.Controls.Add(this.dataGridViewTemplateGroup);
      this.tabPage4.Location = new System.Drawing.Point(4, 25);
      this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(906, 379);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "템플릿그룹";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.BtnDeleteTemplateRow);
      this.tabPage5.Controls.Add(this.dataGridViewTemplate);
      this.tabPage5.Location = new System.Drawing.Point(4, 25);
      this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Size = new System.Drawing.Size(906, 379);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "템플릿";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // BtnDeleteTemplateRow
      // 
      this.BtnDeleteTemplateRow.Location = new System.Drawing.Point(3, 8);
      this.BtnDeleteTemplateRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnDeleteTemplateRow.Name = "BtnDeleteTemplateRow";
      this.BtnDeleteTemplateRow.Size = new System.Drawing.Size(86, 22);
      this.BtnDeleteTemplateRow.TabIndex = 2;
      this.BtnDeleteTemplateRow.Text = "행 삭제";
      this.BtnDeleteTemplateRow.UseVisualStyleBackColor = true;
      this.BtnDeleteTemplateRow.Click += new System.EventHandler(this.BtnDeleteTemplateRow_Click);
      // 
      // dataGridViewTemplate
      // 
      this.dataGridViewTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTemplate.Location = new System.Drawing.Point(0, 36);
      this.dataGridViewTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewTemplate.Name = "dataGridViewTemplate";
      this.dataGridViewTemplate.RowHeadersWidth = 51;
      this.dataGridViewTemplate.RowTemplate.Height = 25;
      this.dataGridViewTemplate.Size = new System.Drawing.Size(905, 344);
      this.dataGridViewTemplate.TabIndex = 0;
      // 
      // tabPage6
      // 
      this.tabPage6.Controls.Add(this.BtnDeleteReplacerRow);
      this.tabPage6.Controls.Add(this.dataGridViewReplacer);
      this.tabPage6.Location = new System.Drawing.Point(4, 25);
      this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Size = new System.Drawing.Size(906, 379);
      this.tabPage6.TabIndex = 5;
      this.tabPage6.Text = "대체텍스트";
      this.tabPage6.UseVisualStyleBackColor = true;
      // 
      // BtnDeleteReplacerRow
      // 
      this.BtnDeleteReplacerRow.Location = new System.Drawing.Point(10, 5);
      this.BtnDeleteReplacerRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnDeleteReplacerRow.Name = "BtnDeleteReplacerRow";
      this.BtnDeleteReplacerRow.Size = new System.Drawing.Size(86, 22);
      this.BtnDeleteReplacerRow.TabIndex = 2;
      this.BtnDeleteReplacerRow.Text = "행 삭제";
      this.BtnDeleteReplacerRow.UseVisualStyleBackColor = true;
      this.BtnDeleteReplacerRow.Click += new System.EventHandler(this.BtnDeleteReplacerRow_Click);
      // 
      // dataGridViewReplacer
      // 
      this.dataGridViewReplacer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewReplacer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewReplacer.Location = new System.Drawing.Point(0, 34);
      this.dataGridViewReplacer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewReplacer.Name = "dataGridViewReplacer";
      this.dataGridViewReplacer.RowHeadersWidth = 51;
      this.dataGridViewReplacer.RowTemplate.Height = 25;
      this.dataGridViewReplacer.Size = new System.Drawing.Size(905, 346);
      this.dataGridViewReplacer.TabIndex = 0;
      // 
      // tabPage7
      // 
      this.tabPage7.Controls.Add(this.BtnDeleteFileNameRow);
      this.tabPage7.Controls.Add(this.dataGridViewFileName);
      this.tabPage7.Location = new System.Drawing.Point(4, 25);
      this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Size = new System.Drawing.Size(906, 379);
      this.tabPage7.TabIndex = 6;
      this.tabPage7.Text = "첨부파일명";
      this.tabPage7.UseVisualStyleBackColor = true;
      // 
      // BtnDeleteFileNameRow
      // 
      this.BtnDeleteFileNameRow.Location = new System.Drawing.Point(10, 2);
      this.BtnDeleteFileNameRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnDeleteFileNameRow.Name = "BtnDeleteFileNameRow";
      this.BtnDeleteFileNameRow.Size = new System.Drawing.Size(86, 22);
      this.BtnDeleteFileNameRow.TabIndex = 2;
      this.BtnDeleteFileNameRow.Text = "행 삭제";
      this.BtnDeleteFileNameRow.UseVisualStyleBackColor = true;
      this.BtnDeleteFileNameRow.Click += new System.EventHandler(this.BtnDeleteFileNameRow_Click);
      // 
      // dataGridViewFileName
      // 
      this.dataGridViewFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewFileName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewFileName.Location = new System.Drawing.Point(0, 32);
      this.dataGridViewFileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewFileName.Name = "dataGridViewFileName";
      this.dataGridViewFileName.RowHeadersWidth = 51;
      this.dataGridViewFileName.RowTemplate.Height = 25;
      this.dataGridViewFileName.Size = new System.Drawing.Size(905, 348);
      this.dataGridViewFileName.TabIndex = 0;
      // 
      // BtnSave
      // 
      this.BtnSave.Location = new System.Drawing.Point(378, 12);
      this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnSave.Name = "BtnSave";
      this.BtnSave.Size = new System.Drawing.Size(121, 22);
      this.BtnSave.TabIndex = 5;
      this.BtnSave.Text = "변경사항 저장";
      this.BtnSave.UseVisualStyleBackColor = true;
      this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
      // 
      // BtnDeleteTemplateGroupRow
      // 
      this.BtnDeleteTemplateGroupRow.Location = new System.Drawing.Point(10, 2);
      this.BtnDeleteTemplateGroupRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.BtnDeleteTemplateGroupRow.Name = "BtnDeleteTemplateGroupRow";
      this.BtnDeleteTemplateGroupRow.Size = new System.Drawing.Size(86, 22);
      this.BtnDeleteTemplateGroupRow.TabIndex = 2;
      this.BtnDeleteTemplateGroupRow.Text = "행 삭제";
      this.BtnDeleteTemplateGroupRow.UseVisualStyleBackColor = true;
      this.BtnDeleteTemplateGroupRow.Click += new System.EventHandler(this.BtnDeleteTemplateGroupRow_Click);
      // 
      // dataGridViewTemplateGroup
      // 
      this.dataGridViewTemplateGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewTemplateGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTemplateGroup.Location = new System.Drawing.Point(0, 30);
      this.dataGridViewTemplateGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridViewTemplateGroup.Name = "dataGridViewTemplateGroup";
      this.dataGridViewTemplateGroup.RowHeadersWidth = 51;
      this.dataGridViewTemplateGroup.RowTemplate.Height = 25;
      this.dataGridViewTemplateGroup.Size = new System.Drawing.Size(905, 350);
      this.dataGridViewTemplateGroup.TabIndex = 0;
      // 
      // FrmDataEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(914, 450);
      this.Controls.Add(this.BtnSave);
      this.Controls.Add(this.TabTable);
      this.Controls.Add(this.LblPath);
      this.Controls.Add(this.BtnChangePath);
      this.Controls.Add(this.BtnInitialize);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "FrmDataEditor";
      this.Text = "데이터베이스 편집기";
      this.TabTable.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManager)).EndInit();
      this.tabPage4.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplate)).EndInit();
      this.tabPage6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReplacer)).EndInit();
      this.tabPage7.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileName)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemplateGroup)).EndInit();
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
    private System.Windows.Forms.DataGridView dataGridViewTemplate;
    private System.Windows.Forms.DataGridView dataGridViewReplacer;
    private System.Windows.Forms.DataGridView dataGridViewFileName;
    private System.Windows.Forms.Button BtnSave;
    private System.Windows.Forms.Button BtnDeleteCompanyRow;
    private System.Windows.Forms.Button BtnDeleteDepartmentRow;
    private System.Windows.Forms.Button BtnDeleteManagerRow;
    private System.Windows.Forms.Button BtnDeleteTemplateRow;
    private System.Windows.Forms.Button BtnDeleteReplacerRow;
    private System.Windows.Forms.Button BtnDeleteFileNameRow;
    private System.Windows.Forms.Button BtnDeleteTemplateGroupRow;
    private System.Windows.Forms.DataGridView dataGridViewTemplateGroup;
  }
}