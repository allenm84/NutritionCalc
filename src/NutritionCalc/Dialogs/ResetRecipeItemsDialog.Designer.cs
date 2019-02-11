namespace NutritionCalc
{
  partial class ResetRecipeItemsDialog
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
      DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
      this.lstItems = new DevExpress.XtraEditors.CheckedListBoxControl();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.lstItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      this.SuspendLayout();
      // 
      // lstItems
      // 
      this.lstItems.CheckOnClick = true;
      this.lstItems.Location = new System.Drawing.Point(12, 55);
      this.lstItems.Name = "lstItems";
      this.lstItems.Size = new System.Drawing.Size(284, 196);
      this.lstItems.StyleController = this.layoutControl1;
      this.lstItems.TabIndex = 0;
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.labelControl1);
      this.layoutControl1.Controls.Add(this.lstItems);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(908, 149, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(308, 289);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(220, 255);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(76, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(140, 255);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(76, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 5;
      this.btnOK.Text = "OK";
      // 
      // labelControl1
      // 
      this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
      this.labelControl1.Location = new System.Drawing.Point(12, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(284, 39);
      this.labelControl1.StyleController = this.layoutControl1;
      this.labelControl1.TabIndex = 4;
      this.labelControl1.Text = "Select which items to reset. \r\nResetting an item will remove the ingredient / bas" +
    "e recipe that you found.";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
      this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
      this.layoutControlGroup1.Name = "Root";
      columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
      columnDefinition1.Width = 100D;
      columnDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition2.Width = 80D;
      columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition3.Width = 80D;
      this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
      rowDefinition1.Height = 43D;
      rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition2.Height = 100D;
      rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
      rowDefinition3.Height = 26D;
      rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
      this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3});
      this.layoutControlGroup1.Size = new System.Drawing.Size(308, 289);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.lstItems;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 43);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 3;
      this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
      this.layoutControlItem1.Size = new System.Drawing.Size(288, 200);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.labelControl1;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
      this.layoutControlItem2.Size = new System.Drawing.Size(288, 43);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.btnOK;
      this.layoutControlItem3.Location = new System.Drawing.Point(128, 243);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 2;
      this.layoutControlItem3.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnCancel;
      this.layoutControlItem4.Location = new System.Drawing.Point(208, 243);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2;
      this.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 2;
      this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // ResetRecipeItemsDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(308, 289);
      this.Controls.Add(this.layoutControl1);
      this.Name = "ResetRecipeItemsDialog";
      this.Text = "Reset Ingredients/Base Recipes";
      ((System.ComponentModel.ISupportInitialize)(this.lstItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.CheckedListBoxControl lstItems;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
  }
}