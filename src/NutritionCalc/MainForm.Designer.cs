namespace NutritionCalc
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.gridRecipes = new DevExpress.XtraGrid.GridControl();
      this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewRecipes = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colRecipeName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.gridBaseRecipes = new DevExpress.XtraGrid.GridControl();
      this.templateRecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewBaseRecipes = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colBaseRecipeName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.btnDeleteRecipe = new DevExpress.XtraEditors.SimpleButton();
      this.btnDeleteBaseRecipe = new DevExpress.XtraEditors.SimpleButton();
      this.btnAddRecipe = new DevExpress.XtraEditors.SimpleButton();
      this.btnAddBaseRecipe = new DevExpress.XtraEditors.SimpleButton();
      this.btnAddIngredient = new DevExpress.XtraEditors.SimpleButton();
      this.grpIngredients = new NutritionCalc.GroupedItemView();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridRecipes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewRecipes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridBaseRecipes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.templateRecipeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewBaseRecipes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.gridRecipes);
      this.layoutControl1.Controls.Add(this.gridBaseRecipes);
      this.layoutControl1.Controls.Add(this.btnDeleteRecipe);
      this.layoutControl1.Controls.Add(this.btnDeleteBaseRecipe);
      this.layoutControl1.Controls.Add(this.btnAddRecipe);
      this.layoutControl1.Controls.Add(this.btnAddBaseRecipe);
      this.layoutControl1.Controls.Add(this.btnAddIngredient);
      this.layoutControl1.Controls.Add(this.grpIngredients);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 31);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(910, 161, 650, 400);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(574, 411);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // gridRecipes
      // 
      this.gridRecipes.DataSource = this.recipeBindingSource;
      this.gridRecipes.Location = new System.Drawing.Point(24, 46);
      this.gridRecipes.MainView = this.gridViewRecipes;
      this.gridRecipes.MenuManager = this.barManager1;
      this.gridRecipes.Name = "gridRecipes";
      this.gridRecipes.Size = new System.Drawing.Size(526, 315);
      this.gridRecipes.TabIndex = 13;
      this.gridRecipes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecipes});
      this.gridRecipes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridRecipes_MouseDoubleClick);
      // 
      // recipeBindingSource
      // 
      this.recipeBindingSource.DataSource = typeof(NutritionCalc.Recipe);
      this.recipeBindingSource.Sort = "";
      // 
      // gridViewRecipes
      // 
      this.gridViewRecipes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRecipeName});
      this.gridViewRecipes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewRecipes.GridControl = this.gridRecipes;
      this.gridViewRecipes.Name = "gridViewRecipes";
      this.gridViewRecipes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewRecipes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewRecipes.OptionsBehavior.Editable = false;
      this.gridViewRecipes.OptionsBehavior.ReadOnly = true;
      this.gridViewRecipes.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewRecipes.OptionsView.ShowColumnHeaders = false;
      this.gridViewRecipes.OptionsView.ShowDetailButtons = false;
      this.gridViewRecipes.OptionsView.ShowGroupPanel = false;
      this.gridViewRecipes.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewRecipes.OptionsView.ShowIndicator = false;
      this.gridViewRecipes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRecipeName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colRecipeName
      // 
      this.colRecipeName.FieldName = "Name";
      this.colRecipeName.Name = "colRecipeName";
      this.colRecipeName.Visible = true;
      this.colRecipeName.VisibleIndex = 0;
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tbbSave,
            this.skinBarSubItem1});
      this.barManager1.MaxItemId = 2;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.skinBarSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // tbbSave
      // 
      this.tbbSave.Caption = "Save";
      this.tbbSave.Id = 0;
      this.tbbSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tbbSave.ImageOptions.Image")));
      this.tbbSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("tbbSave.ImageOptions.LargeImage")));
      this.tbbSave.Name = "tbbSave";
      this.tbbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSave_ItemClick);
      // 
      // skinBarSubItem1
      // 
      this.skinBarSubItem1.Caption = "Skins";
      this.skinBarSubItem1.Id = 1;
      this.skinBarSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.Image")));
      this.skinBarSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.LargeImage")));
      this.skinBarSubItem1.Name = "skinBarSubItem1";
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new System.Drawing.Size(574, 31);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 442);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new System.Drawing.Size(574, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 411);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(574, 31);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 411);
      // 
      // gridBaseRecipes
      // 
      this.gridBaseRecipes.DataSource = this.templateRecipeBindingSource;
      this.gridBaseRecipes.Location = new System.Drawing.Point(24, 46);
      this.gridBaseRecipes.MainView = this.gridViewBaseRecipes;
      this.gridBaseRecipes.MenuManager = this.barManager1;
      this.gridBaseRecipes.Name = "gridBaseRecipes";
      this.gridBaseRecipes.Size = new System.Drawing.Size(526, 315);
      this.gridBaseRecipes.TabIndex = 12;
      this.gridBaseRecipes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBaseRecipes});
      this.gridBaseRecipes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridBaseRecipes_MouseDoubleClick);
      // 
      // templateRecipeBindingSource
      // 
      this.templateRecipeBindingSource.DataSource = typeof(NutritionCalc.TemplateRecipe);
      this.templateRecipeBindingSource.Sort = "";
      // 
      // gridViewBaseRecipes
      // 
      this.gridViewBaseRecipes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBaseRecipeName});
      this.gridViewBaseRecipes.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewBaseRecipes.GridControl = this.gridBaseRecipes;
      this.gridViewBaseRecipes.Name = "gridViewBaseRecipes";
      this.gridViewBaseRecipes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewBaseRecipes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewBaseRecipes.OptionsBehavior.Editable = false;
      this.gridViewBaseRecipes.OptionsBehavior.ReadOnly = true;
      this.gridViewBaseRecipes.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewBaseRecipes.OptionsView.ShowColumnHeaders = false;
      this.gridViewBaseRecipes.OptionsView.ShowDetailButtons = false;
      this.gridViewBaseRecipes.OptionsView.ShowGroupPanel = false;
      this.gridViewBaseRecipes.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewBaseRecipes.OptionsView.ShowIndicator = false;
      this.gridViewBaseRecipes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBaseRecipeName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colBaseRecipeName
      // 
      this.colBaseRecipeName.FieldName = "Name";
      this.colBaseRecipeName.Name = "colBaseRecipeName";
      this.colBaseRecipeName.Visible = true;
      this.colBaseRecipeName.VisibleIndex = 0;
      // 
      // btnDeleteRecipe
      // 
      this.btnDeleteRecipe.AutoWidthInLayoutControl = true;
      this.btnDeleteRecipe.Location = new System.Drawing.Point(475, 365);
      this.btnDeleteRecipe.Name = "btnDeleteRecipe";
      this.btnDeleteRecipe.Size = new System.Drawing.Size(75, 22);
      this.btnDeleteRecipe.StyleController = this.layoutControl1;
      this.btnDeleteRecipe.TabIndex = 11;
      this.btnDeleteRecipe.Text = "Delete Recipe";
      this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
      // 
      // btnDeleteBaseRecipe
      // 
      this.btnDeleteBaseRecipe.AutoWidthInLayoutControl = true;
      this.btnDeleteBaseRecipe.Location = new System.Drawing.Point(449, 365);
      this.btnDeleteBaseRecipe.Name = "btnDeleteBaseRecipe";
      this.btnDeleteBaseRecipe.Size = new System.Drawing.Size(101, 22);
      this.btnDeleteBaseRecipe.StyleController = this.layoutControl1;
      this.btnDeleteBaseRecipe.TabIndex = 10;
      this.btnDeleteBaseRecipe.Text = "Delete Base Recipe";
      this.btnDeleteBaseRecipe.Click += new System.EventHandler(this.btnDeleteBaseRecipe_Click);
      // 
      // btnAddRecipe
      // 
      this.btnAddRecipe.AutoWidthInLayoutControl = true;
      this.btnAddRecipe.Location = new System.Drawing.Point(24, 365);
      this.btnAddRecipe.Name = "btnAddRecipe";
      this.btnAddRecipe.Size = new System.Drawing.Size(63, 22);
      this.btnAddRecipe.StyleController = this.layoutControl1;
      this.btnAddRecipe.TabIndex = 9;
      this.btnAddRecipe.Text = "Add Recipe";
      this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
      // 
      // btnAddBaseRecipe
      // 
      this.btnAddBaseRecipe.AutoWidthInLayoutControl = true;
      this.btnAddBaseRecipe.Location = new System.Drawing.Point(24, 365);
      this.btnAddBaseRecipe.Name = "btnAddBaseRecipe";
      this.btnAddBaseRecipe.Size = new System.Drawing.Size(89, 22);
      this.btnAddBaseRecipe.StyleController = this.layoutControl1;
      this.btnAddBaseRecipe.TabIndex = 8;
      this.btnAddBaseRecipe.Text = "Add Base Recipe";
      this.btnAddBaseRecipe.Click += new System.EventHandler(this.btnAddBaseRecipe_Click);
      // 
      // btnAddIngredient
      // 
      this.btnAddIngredient.AutoWidthInLayoutControl = true;
      this.btnAddIngredient.Location = new System.Drawing.Point(24, 365);
      this.btnAddIngredient.Name = "btnAddIngredient";
      this.btnAddIngredient.Size = new System.Drawing.Size(81, 22);
      this.btnAddIngredient.StyleController = this.layoutControl1;
      this.btnAddIngredient.TabIndex = 7;
      this.btnAddIngredient.Text = "Add Ingredient";
      this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
      // 
      // grpIngredients
      // 
      this.grpIngredients.Location = new System.Drawing.Point(24, 46);
      this.grpIngredients.Name = "grpIngredients";
      this.grpIngredients.Size = new System.Drawing.Size(526, 315);
      this.grpIngredients.TabIndex = 4;
      this.grpIngredients.ItemClicked += new System.EventHandler<NutritionCalc.GroupedItemViewEventArgs>(this.grpIngredients_ItemClicked);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(574, 411);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // tabbedControlGroup1
      // 
      this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.tabbedControlGroup1.Name = "tabbedControlGroup1";
      this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
      this.tabbedControlGroup1.SelectedTabPageIndex = 0;
      this.tabbedControlGroup1.Size = new System.Drawing.Size(554, 391);
      this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4});
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.layoutControlItem7,
            this.layoutControlItem2});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(530, 345);
      this.layoutControlGroup3.Text = "Base Recipes";
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnAddBaseRecipe;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 319);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(93, 26);
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new System.Drawing.Point(93, 319);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(332, 26);
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.btnDeleteBaseRecipe;
      this.layoutControlItem7.Location = new System.Drawing.Point(425, 319);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(105, 26);
      this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.gridBaseRecipes;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(530, 319);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.emptySpaceItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(530, 345);
      this.layoutControlGroup2.Text = "Ingredients";
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.grpIngredients;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(530, 319);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnAddIngredient;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 319);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(85, 26);
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(85, 319);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(445, 26);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlGroup4
      // 
      this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.emptySpaceItem3,
            this.layoutControlItem8,
            this.layoutControlItem3});
      this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new System.Drawing.Size(530, 345);
      this.layoutControlGroup4.Text = "Recipes";
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnAddRecipe;
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 319);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(67, 26);
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      // 
      // emptySpaceItem3
      // 
      this.emptySpaceItem3.AllowHotTrack = false;
      this.emptySpaceItem3.Location = new System.Drawing.Point(67, 319);
      this.emptySpaceItem3.Name = "emptySpaceItem3";
      this.emptySpaceItem3.Size = new System.Drawing.Size(384, 26);
      this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem8
      // 
      this.layoutControlItem8.Control = this.btnDeleteRecipe;
      this.layoutControlItem8.Location = new System.Drawing.Point(451, 319);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new System.Drawing.Size(79, 26);
      this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem8.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.gridRecipes;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(530, 319);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(574, 442);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Nutrition Calc";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridRecipes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewRecipes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridBaseRecipes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.templateRecipeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewBaseRecipes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private GroupedItemView grpIngredients;
    private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
    private DevExpress.XtraEditors.SimpleButton btnAddIngredient;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraEditors.SimpleButton btnAddRecipe;
    private DevExpress.XtraEditors.SimpleButton btnAddBaseRecipe;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    private System.Windows.Forms.BindingSource templateRecipeBindingSource;
    private DevExpress.XtraBars.BarButtonItem tbbSave;
    private System.Windows.Forms.BindingSource recipeBindingSource;
    private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
    private DevExpress.XtraEditors.SimpleButton btnDeleteBaseRecipe;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraEditors.SimpleButton btnDeleteRecipe;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    private DevExpress.XtraGrid.GridControl gridBaseRecipes;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewBaseRecipes;
    private DevExpress.XtraGrid.Columns.GridColumn colBaseRecipeName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraGrid.GridControl gridRecipes;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecipes;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraGrid.Columns.GridColumn colRecipeName;
  }
}

