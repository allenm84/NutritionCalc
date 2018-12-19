namespace NutritionCalc
{
  partial class SelectableIngredientEdit
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.gridItems = new DevExpress.XtraGrid.GridControl();
      this.selectableIngredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
      this.chkIsSelected = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.txtUnit = new DevExpress.XtraEditors.TextEdit();
      this.txtAmount = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.selectableIngredientBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkIsSelected)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.gridItems);
      this.layoutControl1.Controls.Add(this.txtUnit);
      this.layoutControl1.Controls.Add(this.txtAmount);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(639, 27, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(286, 159);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // gridItems
      // 
      this.gridItems.DataSource = this.selectableIngredientBindingSource;
      this.gridItems.Location = new System.Drawing.Point(14, 98);
      this.gridItems.MainView = this.gridViewItems;
      this.gridItems.Name = "gridItems";
      this.gridItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkIsSelected});
      this.gridItems.Size = new System.Drawing.Size(258, 47);
      this.gridItems.TabIndex = 6;
      this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
      // 
      // selectableIngredientBindingSource
      // 
      this.selectableIngredientBindingSource.DataSource = typeof(NutritionCalc.SelectableIngredient);
      this.selectableIngredientBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.selectableIngredientBindingSource_ListChanged);
      // 
      // gridViewItems
      // 
      this.gridViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colName});
      this.gridViewItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewItems.GridControl = this.gridItems;
      this.gridViewItems.Name = "gridViewItems";
      this.gridViewItems.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewItems.OptionsView.ShowColumnHeaders = false;
      this.gridViewItems.OptionsView.ShowGroupPanel = false;
      this.gridViewItems.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewItems.OptionsView.ShowIndicator = false;
      this.gridViewItems.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewItems.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colIsSelected
      // 
      this.colIsSelected.Caption = "IsSelected";
      this.colIsSelected.ColumnEdit = this.chkIsSelected;
      this.colIsSelected.FieldName = "IsSelected";
      this.colIsSelected.MaxWidth = 30;
      this.colIsSelected.MinWidth = 30;
      this.colIsSelected.Name = "colIsSelected";
      this.colIsSelected.Visible = true;
      this.colIsSelected.VisibleIndex = 0;
      this.colIsSelected.Width = 30;
      // 
      // chkIsSelected
      // 
      this.chkIsSelected.AutoHeight = false;
      this.chkIsSelected.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
      this.chkIsSelected.Name = "chkIsSelected";
      this.chkIsSelected.EditValueChanged += new System.EventHandler(this.chkIsSelected_EditValueChanged);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.OptionsColumn.AllowEdit = false;
      this.colName.OptionsColumn.ReadOnly = true;
      this.colName.Visible = true;
      this.colName.VisibleIndex = 1;
      // 
      // txtUnit
      // 
      this.txtUnit.Location = new System.Drawing.Point(189, 32);
      this.txtUnit.Name = "txtUnit";
      this.txtUnit.Properties.ReadOnly = true;
      this.txtUnit.Size = new System.Drawing.Size(83, 20);
      this.txtUnit.StyleController = this.layoutControl1;
      this.txtUnit.TabIndex = 5;
      // 
      // txtAmount
      // 
      this.txtAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.txtAmount.Location = new System.Drawing.Point(58, 32);
      this.txtAmount.Name = "txtAmount";
      this.txtAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
      this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
      this.txtAmount.Properties.ReadOnly = true;
      this.txtAmount.Size = new System.Drawing.Size(83, 20);
      this.txtAmount.StyleController = this.layoutControl1;
      this.txtAmount.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup1.Size = new System.Drawing.Size(286, 159);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(286, 66);
      this.layoutControlGroup2.Text = "Amount and Units";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.txtUnit;
      this.layoutControlItem2.Location = new System.Drawing.Point(131, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(131, 24);
      this.layoutControlItem2.Text = "Units:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(41, 13);
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtAmount;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(131, 24);
      this.layoutControlItem1.Text = "Amount:";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(41, 13);
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 66);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(286, 93);
      this.layoutControlGroup3.Text = "Matching Items";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.gridItems;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(262, 51);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // RecipeItemParseResultEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "RecipeItemParseResultEdit";
      this.Size = new System.Drawing.Size(286, 159);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.selectableIngredientBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkIsSelected)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.TextEdit txtUnit;
    private DevExpress.XtraEditors.TextEdit txtAmount;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraGrid.GridControl gridItems;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkIsSelected;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private System.Windows.Forms.BindingSource selectableIngredientBindingSource;
  }
}
