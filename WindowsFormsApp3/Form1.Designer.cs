namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar1 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton1, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45.000000000000007D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 3.2779790972610585D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar1 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton1))});
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(515, 454), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, true);
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.model1 = new devDept.Eyeshot.Model();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.selectionComboBox = new System.Windows.Forms.ComboBox();
            this.selectionFilterComboBox = new System.Windows.Forms.ComboBox();
            this.selectCheckBox = new System.Windows.Forms.CheckBox();
            this.invertSelectionButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.SuspendLayout();
            // 
            // model1
            // 
            this.model1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.model1.Location = new System.Drawing.Point(0, 0);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar1;
            this.model1.Size = new System.Drawing.Size(515, 454);
            this.model1.TabIndex = 0;
            this.model1.Text = "model1";
            coordinateSystemIcon1.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport1.CoordinateSystemIcon = coordinateSystemIcon1;
            viewport1.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol1.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport1.OriginSymbol = originSymbol1;
            viewCubeIcon1.Font = null;
            viewCubeIcon1.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport1.ViewCubeIcon = viewCubeIcon1;
            this.model1.Viewports.Add(viewport1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Front";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.frontViewButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Side";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sideViewButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(683, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Top";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.topViewButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(764, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Iso";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.isoViewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shading";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(521, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Wireframe";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.wireframeButton_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(602, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Shaded";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.shadedButton_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(683, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Rendered";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.renderedButton_CheckedChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(764, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Hidden Lines";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.hiddenLinesButton_CheckedChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(521, 57);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Flat";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.flatButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inspection";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(521, 296);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Statistics";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(521, 396);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "Import";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.importButton_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(603, 395);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 16;
            this.button13.Text = "Export";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(603, 295);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 17;
            this.button11.Text = "Volume";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.volumeButton_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(685, 296);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 18;
            this.button14.Text = "Area";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "Selection";
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.FormattingEnabled = true;
            this.selectionComboBox.Items.AddRange(new object[] {
            "by Pick",
            "by Box",
            "by Polygon",
            "by Box Enclosed",
            "by Polygon Enclosed",
            "Visible by Pick",
            "Visible by Box",
            "Visible by Polygon",
            "Visible by Pick Dynamic",
            "Visible by Pick Label"});
            this.selectionComboBox.Location = new System.Drawing.Point(521, 121);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(156, 20);
            this.selectionComboBox.TabIndex = 22;
            // 
            // selectionFilterComboBox
            // 
            this.selectionFilterComboBox.FormattingEnabled = true;
            this.selectionFilterComboBox.Items.AddRange(new object[] {
            "Vertex",
            "Edge",
            "Face",
            "Entity"});
            this.selectionFilterComboBox.Location = new System.Drawing.Point(521, 147);
            this.selectionFilterComboBox.Name = "selectionFilterComboBox";
            this.selectionFilterComboBox.Size = new System.Drawing.Size(156, 20);
            this.selectionFilterComboBox.TabIndex = 23;
            // 
            // selectCheckBox
            // 
            this.selectCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectCheckBox.AutoSize = true;
            this.selectCheckBox.Location = new System.Drawing.Point(695, 123);
            this.selectCheckBox.Name = "selectCheckBox";
            this.selectCheckBox.Size = new System.Drawing.Size(51, 22);
            this.selectCheckBox.TabIndex = 24;
            this.selectCheckBox.Text = "Select";
            this.selectCheckBox.UseVisualStyleBackColor = true;
            this.selectCheckBox.CheckedChanged += new System.EventHandler(this.selectCheckBox_CheckedChanged);
            // 
            // invertSelectionButton
            // 
            this.invertSelectionButton.Location = new System.Drawing.Point(695, 147);
            this.invertSelectionButton.Name = "invertSelectionButton";
            this.invertSelectionButton.Size = new System.Drawing.Size(51, 23);
            this.invertSelectionButton.TabIndex = 26;
            this.invertSelectionButton.Text = "Invert";
            this.invertSelectionButton.UseVisualStyleBackColor = true;
            this.invertSelectionButton.Click += new System.EventHandler(this.invertSelectionButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(761, 147);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(45, 23);
            this.groupButton.TabIndex = 27;
            this.groupButton.Text = "Group";
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Location = new System.Drawing.Point(761, 123);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(45, 23);
            this.clearSelectionButton.TabIndex = 28;
            this.clearSelectionButton.Text = "Clear";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.clearSelectionButton);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.invertSelectionButton);
            this.Controls.Add(this.selectCheckBox);
            this.Controls.Add(this.selectionFilterComboBox);
            this.Controls.Add(this.selectionComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.model1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private devDept.Eyeshot.Model model1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectionComboBox;
        private System.Windows.Forms.ComboBox selectionFilterComboBox;
        private System.Windows.Forms.CheckBox selectCheckBox;
        private System.Windows.Forms.Button invertSelectionButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button clearSelectionButton;
    }
}

