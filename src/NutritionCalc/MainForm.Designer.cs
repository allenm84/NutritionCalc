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
      this.btnAddRecipe = new DevExpress.XtraEditors.SimpleButton();
      this.btnAddBaseRecipe = new DevExpress.XtraEditors.SimpleButton();
      this.btnAddIngredient = new DevExpress.XtraEditors.SimpleButton();
      this.lstRecipes = new DevExpress.XtraEditors.ListBoxControl();
      this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.lstBaseRecipes = new DevExpress.XtraEditors.ListBoxControl();
      this.templateRecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.grpIngredients = new NutritionCalc.GroupedItemView();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstRecipes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lstBaseRecipes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.templateRecipeBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnAddRecipe);
      this.layoutControl1.Controls.Add(this.btnAddBaseRecipe);
      this.layoutControl1.Controls.Add(this.btnAddIngredient);
      this.layoutControl1.Controls.Add(this.lstRecipes);
      this.layoutControl1.Controls.Add(this.lstBaseRecipes);
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
      // lstRecipes
      // 
      this.lstRecipes.DataSource = this.recipeBindingSource;
      this.lstRecipes.DisplayMember = "Name";
      this.lstRecipes.Location = new System.Drawing.Point(24, 46);
      this.lstRecipes.Name = "lstRecipes";
      this.lstRecipes.Size = new System.Drawing.Size(526, 315);
      this.lstRecipes.SortOrder = System.Windows.Forms.SortOrder.Ascending;
      this.lstRecipes.StyleController = this.layoutControl1;
      this.lstRecipes.TabIndex = 6;
      this.lstRecipes.ValueMember = "Id";
      this.lstRecipes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRecipes_MouseDoubleClick);
      // 
      // recipeBindingSource
      // 
      this.recipeBindingSource.DataSource = typeof(NutritionCalc.Recipe);
      // 
      // lstBaseRecipes
      // 
      this.lstBaseRecipes.DataSource = this.templateRecipeBindingSource;
      this.lstBaseRecipes.DisplayMember = "Name";
      this.lstBaseRecipes.Location = new System.Drawing.Point(24, 46);
      this.lstBaseRecipes.Name = "lstBaseRecipes";
      this.lstBaseRecipes.Size = new System.Drawing.Size(526, 315);
      this.lstBaseRecipes.SortOrder = System.Windows.Forms.SortOrder.Ascending;
      this.lstBaseRecipes.StyleController = this.layoutControl1;
      this.lstBaseRecipes.TabIndex = 5;
      this.lstBaseRecipes.ValueMember = "Id";
      this.lstBaseRecipes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBaseRecipes_MouseDoubleClick);
      // 
      // templateRecipeBindingSource
      // 
      this.templateRecipeBindingSource.DataSource = typeof(NutritionCalc.TemplateRecipe);
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
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem2});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(530, 345);
      this.layoutControlGroup3.Text = "Base Recipes";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.lstBaseRecipes;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(530, 319);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
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
      this.emptySpaceItem2.Size = new System.Drawing.Size(437, 26);
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlGroup4
      // 
      this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.emptySpaceItem3});
      this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new System.Drawing.Size(530, 345);
      this.layoutControlGroup4.Text = "Recipes";
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.lstRecipes;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(530, 319);
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
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
      this.emptySpaceItem3.Size = new System.Drawing.Size(463, 26);
      this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
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
            this.tbbSave});
      this.barManager1.MaxItemId = 1;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
      ((System.ComponentModel.ISupportInitialize)(this.lstRecipes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lstBaseRecipes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.templateRecipeBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
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
    private DevExpress.XtraEditors.ListBoxControl lstBaseRecipes;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
    private DevExpress.XtraEditors.ListBoxControl lstRecipes;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
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
  }
}

