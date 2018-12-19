namespace NutritionCalc
{
  partial class EditIngredientDialog
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
      DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.cboCategory = new DevExpress.XtraEditors.LookUpEdit();
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.nutritionInfoEdit = new NutritionCalc.NutritionInfoEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnDelete);
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.cboCategory);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Controls.Add(this.nutritionInfoEdit);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(686, 200, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(350, 466);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnDelete
      // 
      this.btnDelete.AutoWidthInLayoutControl = true;
      this.btnDelete.Location = new System.Drawing.Point(12, 429);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(93, 22);
      this.btnDelete.StyleController = this.layoutControl1;
      this.btnDelete.TabIndex = 9;
      this.btnDelete.Text = "Delete Ingredient";
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(262, 429);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(76, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(182, 429);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(76, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 7;
      this.btnOK.Text = "OK";
      // 
      // cboCategory
      // 
      this.cboCategory.Location = new System.Drawing.Point(113, 36);
      this.cboCategory.Name = "cboCategory";
      this.cboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboCategory.Properties.NullText = "[Select a category]";
      this.cboCategory.Size = new System.Drawing.Size(225, 20);
      this.cboCategory.StyleController = this.layoutControl1;
      this.cboCategory.TabIndex = 6;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(12, 12);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(326, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 5;
      // 
      // nutritionInfoEdit
      // 
      this.nutritionInfoEdit.Location = new System.Drawing.Point(24, 90);
      this.nutritionInfoEdit.Name = "nutritionInfoEdit";
      this.nutritionInfoEdit.Size = new System.Drawing.Size(302, 323);
      this.nutritionInfoEdit.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlGroup2,
            this.layoutControlItem3,
            this.layoutControlGroup3});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(350, 466);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.txtName;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(330, 24);
      this.layoutControlItem2.Text = "Ingredient Name";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 48);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(330, 369);
      this.layoutControlGroup2.Text = "Nutrition Info";
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.nutritionInfoEdit;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(306, 327);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.cboCategory;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(330, 24);
      this.layoutControlItem3.Text = "Ingredient Category";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(98, 13);
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.GroupBordersVisible = false;
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
      this.layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 417);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      columnDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      columnDefinition1.Width = 97D;
      columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
      columnDefinition2.Width = 100D;
      columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition3.Width = 80D;
      columnDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
      columnDefinition4.Width = 80D;
      this.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4});
      rowDefinition1.Height = 100D;
      rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
      this.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
      this.layoutControlGroup3.Size = new System.Drawing.Size(330, 29);
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnOK;
      this.layoutControlItem4.Location = new System.Drawing.Point(170, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 2;
      this.layoutControlItem4.Size = new System.Drawing.Size(80, 29);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnCancel;
      this.layoutControlItem5.Location = new System.Drawing.Point(250, 0);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 3;
      this.layoutControlItem5.Size = new System.Drawing.Size(80, 29);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnDelete;
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(97, 29);
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      // 
      // EditIngredientDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(350, 466);
      this.Controls.Add(this.layoutControl1);
      this.Name = "EditIngredientDialog";
      this.Text = "Edit Ingredient";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private NutritionInfoEdit nutritionInfoEdit;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.TextEdit txtName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraEditors.LookUpEdit cboCategory;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraEditors.SimpleButton btnDelete;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
  }
}