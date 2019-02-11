namespace NutritionCalc
{
  partial class NutritionCalculatorDialog
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
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
      DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.btnClose = new DevExpress.XtraEditors.SimpleButton();
      this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
      this.cboUnits = new DevExpress.XtraEditors.LookUpEdit();
      this.numServingAmount = new DevExpress.XtraEditors.TextEdit();
      this.cboItems = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.baseIngredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.nutritionInfoEdit = new NutritionCalc.NutritionInfoEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.lcgNutritionInfo = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboUnits.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numServingAmount.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboItems.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.baseIngredientBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lcgNutritionInfo)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnClose);
      this.layoutControl1.Controls.Add(this.btnCalculate);
      this.layoutControl1.Controls.Add(this.cboUnits);
      this.layoutControl1.Controls.Add(this.numServingAmount);
      this.layoutControl1.Controls.Add(this.cboItems);
      this.layoutControl1.Controls.Add(this.nutritionInfoEdit);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(724, 165, 560, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(308, 480);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnClose.Location = new System.Drawing.Point(220, 442);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(76, 22);
      this.btnClose.StyleController = this.layoutControl1;
      this.btnClose.TabIndex = 9;
      this.btnClose.Text = "Close";
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(140, 442);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(76, 22);
      this.btnCalculate.StyleController = this.layoutControl1;
      this.btnCalculate.TabIndex = 8;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // cboUnits
      // 
      this.cboUnits.Location = new System.Drawing.Point(128, 406);
      this.cboUnits.Name = "cboUnits";
      this.cboUnits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboUnits.Properties.NullText = "[Select Unit]";
      this.cboUnits.Size = new System.Drawing.Size(156, 20);
      this.cboUnits.StyleController = this.layoutControl1;
      this.cboUnits.TabIndex = 7;
      // 
      // numServingAmount
      // 
      this.numServingAmount.Location = new System.Drawing.Point(24, 406);
      this.numServingAmount.Name = "numServingAmount";
      this.numServingAmount.Size = new System.Drawing.Size(100, 20);
      this.numServingAmount.StyleController = this.layoutControl1;
      this.numServingAmount.TabIndex = 6;
      // 
      // cboItems
      // 
      this.cboItems.EditValue = "[Ingredient / Base Recipe / Recipe]";
      this.cboItems.Location = new System.Drawing.Point(86, 12);
      this.cboItems.Name = "cboItems";
      this.cboItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboItems.Properties.DataSource = this.baseIngredientBindingSource;
      this.cboItems.Properties.DisplayMember = "Name";
      this.cboItems.Properties.NullText = "[Ingredient / Base Recipe / Recipe]";
      this.cboItems.Properties.PopupView = this.searchLookUpEdit1View;
      this.cboItems.Size = new System.Drawing.Size(210, 20);
      this.cboItems.StyleController = this.layoutControl1;
      this.cboItems.TabIndex = 5;
      this.cboItems.EditValueChanged += new System.EventHandler(this.cboItems_EditValueChanged);
      // 
      // baseIngredientBindingSource
      // 
      this.baseIngredientBindingSource.DataSource = typeof(NutritionCalc.BaseIngredient);
      // 
      // searchLookUpEdit1View
      // 
      this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
      this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.searchLookUpEdit1View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.searchLookUpEdit1View.OptionsView.ShowIndicator = false;
      this.searchLookUpEdit1View.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
      this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // nutritionInfoEdit
      // 
      this.nutritionInfoEdit.Enabled = false;
      this.nutritionInfoEdit.Location = new System.Drawing.Point(24, 66);
      this.nutritionInfoEdit.Name = "nutritionInfoEdit";
      this.nutritionInfoEdit.Size = new System.Drawing.Size(260, 294);
      this.nutritionInfoEdit.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgNutritionInfo,
            this.layoutControlItem2,
            this.layoutControlGroup3,
            this.layoutControlItem5,
            this.layoutControlItem6});
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
      rowDefinition1.Height = 24D;
      rowDefinition1.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition2.Height = 100D;
      rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
      rowDefinition3.Height = 66D;
      rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
      rowDefinition4.Height = 30D;
      rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
      this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
      this.layoutControlGroup1.Size = new System.Drawing.Size(308, 480);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // lcgNutritionInfo
      // 
      this.lcgNutritionInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.lcgNutritionInfo.Location = new System.Drawing.Point(0, 24);
      this.lcgNutritionInfo.Name = "lcgNutritionInfo";
      this.lcgNutritionInfo.OptionsTableLayoutItem.ColumnSpan = 3;
      this.lcgNutritionInfo.OptionsTableLayoutItem.RowIndex = 1;
      this.lcgNutritionInfo.Size = new System.Drawing.Size(288, 340);
      this.lcgNutritionInfo.Text = "{0}\'s Nutrition";
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.nutritionInfoEdit;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(264, 298);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.cboItems;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 3;
      this.layoutControlItem2.Size = new System.Drawing.Size(288, 24);
      this.layoutControlItem2.Text = "Select an item:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 364);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.OptionsTableLayoutItem.ColumnSpan = 3;
      this.layoutControlGroup3.OptionsTableLayoutItem.RowIndex = 2;
      this.layoutControlGroup3.Size = new System.Drawing.Size(288, 66);
      this.layoutControlGroup3.Text = "Desired Serving Size";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.numServingAmount;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(104, 24);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.cboUnits;
      this.layoutControlItem4.Location = new System.Drawing.Point(104, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(160, 24);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnCalculate;
      this.layoutControlItem5.Location = new System.Drawing.Point(128, 430);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1;
      this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 3;
      this.layoutControlItem5.Size = new System.Drawing.Size(80, 30);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnClose;
      this.layoutControlItem6.Location = new System.Drawing.Point(208, 430);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 2;
      this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 3;
      this.layoutControlItem6.Size = new System.Drawing.Size(80, 30);
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      // 
      // dxErrorProvider1
      // 
      this.dxErrorProvider1.ContainerControl = this;
      // 
      // NutritionCalculatorDialog
      // 
      this.AcceptButton = this.btnClose;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(308, 480);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NutritionCalculatorDialog";
      this.Text = "Calculator";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboUnits.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numServingAmount.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboItems.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.baseIngredientBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lcgNutritionInfo)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private NutritionInfoEdit nutritionInfoEdit;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.SearchLookUpEdit cboItems;
    private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    private DevExpress.XtraLayout.LayoutControlGroup lcgNutritionInfo;
    private DevExpress.XtraEditors.TextEdit numServingAmount;
    private DevExpress.XtraEditors.LookUpEdit cboUnits;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraEditors.SimpleButton btnClose;
    private DevExpress.XtraEditors.SimpleButton btnCalculate;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private System.Windows.Forms.BindingSource baseIngredientBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
  }
}