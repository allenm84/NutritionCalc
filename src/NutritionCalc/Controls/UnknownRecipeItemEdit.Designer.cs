namespace NutritionCalc
{
  partial class UnknownRecipeItemEdit
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
      DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
      this.gridItems = new DevExpress.XtraGrid.GridControl();
      this.recipeItemParseResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAddIngredient = new DevExpress.XtraGrid.Columns.GridColumn();
      this.btnAddIngredient = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipeItemParseResultBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnAddIngredient)).BeginInit();
      this.SuspendLayout();
      // 
      // gridItems
      // 
      this.gridItems.DataSource = this.recipeItemParseResultBindingSource;
      this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridItems.Location = new System.Drawing.Point(0, 0);
      this.gridItems.MainView = this.gridViewItems;
      this.gridItems.Name = "gridItems";
      this.gridItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAddIngredient});
      this.gridItems.Size = new System.Drawing.Size(366, 308);
      this.gridItems.TabIndex = 0;
      this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
      // 
      // recipeItemParseResultBindingSource
      // 
      this.recipeItemParseResultBindingSource.DataSource = typeof(NutritionCalc.RecipeItemParseResult);
      // 
      // gridViewItems
      // 
      this.gridViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colText,
            this.colAddIngredient});
      this.gridViewItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewItems.GridControl = this.gridItems;
      this.gridViewItems.Name = "gridViewItems";
      this.gridViewItems.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewItems.OptionsView.ShowColumnHeaders = false;
      this.gridViewItems.OptionsView.ShowGroupPanel = false;
      this.gridViewItems.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewItems.OptionsView.ShowIndicator = false;
      this.gridViewItems.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewItems.RowHeight = 22;
      this.gridViewItems.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colText, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colText
      // 
      this.colText.FieldName = "Text";
      this.colText.Name = "colText";
      this.colText.OptionsColumn.AllowEdit = false;
      this.colText.OptionsColumn.ReadOnly = true;
      this.colText.Visible = true;
      this.colText.VisibleIndex = 0;
      // 
      // colAddIngredient
      // 
      this.colAddIngredient.Caption = "Add Ingredient";
      this.colAddIngredient.ColumnEdit = this.btnAddIngredient;
      this.colAddIngredient.FieldName = "colAddIngredient";
      this.colAddIngredient.MaxWidth = 82;
      this.colAddIngredient.MinWidth = 82;
      this.colAddIngredient.Name = "colAddIngredient";
      this.colAddIngredient.UnboundType = DevExpress.Data.UnboundColumnType.Object;
      this.colAddIngredient.Visible = true;
      this.colAddIngredient.VisibleIndex = 1;
      this.colAddIngredient.Width = 82;
      // 
      // btnAddIngredient
      // 
      this.btnAddIngredient.AutoHeight = false;
      this.btnAddIngredient.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Add Ingredient", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
      this.btnAddIngredient.Name = "btnAddIngredient";
      this.btnAddIngredient.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      this.btnAddIngredient.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAddIngredient_ButtonClick);
      // 
      // UnknownRecipeItemEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridItems);
      this.Name = "UnknownRecipeItemEdit";
      this.Size = new System.Drawing.Size(366, 308);
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipeItemParseResultBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnAddIngredient)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridItems;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
    private System.Windows.Forms.BindingSource recipeItemParseResultBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colText;
    private DevExpress.XtraGrid.Columns.GridColumn colAddIngredient;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAddIngredient;
  }
}
