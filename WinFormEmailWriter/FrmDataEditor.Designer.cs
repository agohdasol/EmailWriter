
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
      this.dataGridView = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
      // dataGridView
      // 
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Location = new System.Drawing.Point(13, 55);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowTemplate.Height = 25;
      this.dataGridView.Size = new System.Drawing.Size(748, 150);
      this.dataGridView.TabIndex = 3;
      // 
      // FrmDataEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.LblPath);
      this.Controls.Add(this.BtnChangePath);
      this.Controls.Add(this.BtnInitialize);
      this.Name = "FrmDataEditor";
      this.Text = "FrmDataEditor";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnInitialize;
    private System.Windows.Forms.Button BtnChangePath;
    private System.Windows.Forms.Label LblPath;
    private System.Windows.Forms.DataGridView dataGridView;
  }
}