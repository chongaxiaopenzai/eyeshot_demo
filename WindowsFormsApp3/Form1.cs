using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Labels;
using devDept.Eyeshot.Translators;
using devDept.Geometry;
using devDept.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Import STL
            model1.WorkCompleted += model1_WorkCompleted;
           // ReadSTL ro = new ReadSTL("F:\\car\\1-2_shift_collar_fork_-_Scaled.stl");
          //  model1.StartWork(ro);

            //Export STL
            //WriteParamsWithMaterials wpwm = new WriteParamsWithMaterials(model1);
            //WriteSTL ws = new WriteSTL(wpwm, "fileName.stl");
            //ws.DoWork();
        }

        private void model1_WorkCompleted(object sender, devDept.Eyeshot.WorkCompletedEventArgs e)
        {
            if (e.WorkUnit is ReadFileAsync)
            {

                ReadFileAsync ra = (ReadFileAsync)e.WorkUnit;
                ra.AddToScene(model1, new RegenOptions() { Async = true });
            }
        }



        //线框视图
        private void wireframeButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(model1, displayType.Wireframe);
        }
        private void shadedButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(model1, displayType.Shaded);
        }
        //渲染视图
        private void renderedButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(model1, displayType.Rendered);
        }
        private void hiddenLinesButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(model1, displayType.HiddenLines);
        }
        private void flatButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(model1, displayType.Flat);
        }
        public static void SetDisplayMode(Model model, displayType displayType)
        {
            model.DisplayMode = displayType;
            SetBackgroundStyleAndColor(model);
            model.Entities.UpdateBoundingBox(); // Updates simplified representation (when available)
            model.Invalidate();
        }
        public static void SetBackgroundStyleAndColor(Model model)
        {
            model.CoordinateSystemIcon.Lighting = false;
            model.ViewCubeIcon.Lighting = false;

            switch (model.DisplayMode)
            {

                case displayType.HiddenLines:
                    model.Background.TopColor = Color.FromArgb(0xD2, 0xD0, 0xB9);

                    model.CoordinateSystemIcon.Lighting = true;
                    model.ViewCubeIcon.Lighting = true;

                    break;

                default:
                    model.Background.TopColor = Color.Snow;
                    break;
            }

            model.CompileUserInterfaceElements();
        }
        private void frontViewButton_Click(object sender, EventArgs e)
        {
            model1.SetView(viewType.Front, true, model1.AnimateCamera);
            model1.Invalidate();
        }

        private void sideViewButton_Click(object sender, EventArgs e)
        {
            model1.SetView(viewType.Right, true, model1.AnimateCamera);
            model1.Invalidate();
        }

        private void topViewButton_Click(object sender, EventArgs e)
        {
            model1.SetView(viewType.Top, true, model1.AnimateCamera);
            model1.Invalidate();
        }

        private void isoViewButton_Click(object sender, EventArgs e)
        {
            model1.SetView(viewType.Isometric, true, model1.AnimateCamera);
            model1.Invalidate();
        }
        private void statisticsButton_Click(object sender, EventArgs e)
        {
            DetailsForm rf = new DetailsForm();

            rf.Text = "Statistics";

            rf.textBox1.Text = model1.Entities.GetStats(model1.Blocks, true);

            rf.Show();
        }

        private void generatebotton_click(object sender, EventArgs e)
        {

        }

        //导入文件
        private void importButton_Click(object sender, EventArgs e)
        {
            using (var importFileDialog1 = new OpenFileDialog())
            //using (var importFileAddOn = new ImportFileAddOn())
            {
                string filter = "All compatible file types (*.*)|*.stl;*.obj;*.3ds"
#if NURBS 
                               + ";*.igs;*.iges;*.stp;*.step"
#endif

#if SOLID
                               + ";*.ifc;*.ifczip"
#endif
                               + "|WaveFront OBJ (*.obj)|*.obj|" + "Stereolithography (*.stl)|*.stl|" + "3D Studio Max (*.3ds)|*.3ds";
#if NURBS
                filter += "|IGES (*.igs; *.iges)|*.igs; *.iges|" + "STEP (*.stp; *.step)|*.stp; *.step";
#endif

#if SOLID
                filter += "|IFC (*.ifc; *.ifczip)|*.ifc; *.ifczip";
#endif

                importFileDialog1.Filter = filter;

                importFileDialog1.Multiselect = true;
                importFileDialog1.AddExtension = true;
                importFileDialog1.CheckFileExists = true;
                importFileDialog1.CheckPathExists = true;

                if (importFileDialog1.ShowDialog() == DialogResult.OK)
                {
                   
                    model1.Clear();
                    ReadFileAsync rfa = GetReader(importFileDialog1.FileName);

                    if (rfa != null)
                    {
                        model1.StartWork(rfa);

                        model1.SetView(viewType.Trimetric, true, model1.AnimateCamera);

                    }
                }
            }
        }
        private ReadFileAsync GetReader(string fileName)
        {
            string ext = System.IO.Path.GetExtension(fileName);

            if (ext != null)
            {
                ext = ext.TrimStart('.').ToLower();

                switch (ext)
                {
                    case "stl":
                        return new ReadSTL(fileName);
                    case "obj":
                        return new ReadOBJ(fileName);
                    case "3ds":
                        return new Read3DS(fileName);
#if NURBS
                    case "igs":
                    case "iges":
                        return new ReadIGES(fileName);
                    case "stp":
                    case "step":
                        return new ReadSTEP(fileName);
#endif
#if SOLID
                    case "ifc":
                    case "ifczip":
                        return new ReadIFC(fileName);
#endif
                }
            }

            return null;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            string filter = "WaveFront OBJ (*.obj)|*.obj|" + "Stereolithography (*.stl)|*.stl|" + "WebGL (*.html)|*.html";

            filter += "|STandard for the Exchange of Product (*.step)|*.step|" + "Initial Graphics Exchange Specification (*.iges)|*.iges";

            saveFileDialog1.Filter = filter;

            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CheckPathExists = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WriteFileAsync wfa = null;
                WriteParams dataParams = null;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        dataParams = new WriteParamsWithMaterials(model1);
                        wfa = new WriteOBJ((WriteParamsWithMaterials)dataParams, saveFileDialog1.FileName);
                        break;

                    case 2:
                        dataParams = new WriteParams(model1);
                        wfa = new WriteSTL(dataParams, saveFileDialog1.FileName);
                        break;
                    case 3:
                        dataParams = new WriteParamsWithMaterials(model1);
                        wfa = new WriteWebGL((WriteParamsWithMaterials)dataParams, model1.DefaultMaterial, saveFileDialog1.FileName);
                        break;

                    case 4:
                        dataParams = new WriteParamsWithUnits(model1);
                        wfa = new WriteSTEP((WriteParamsWithUnits)dataParams, saveFileDialog1.FileName);
                        break;

                    case 5:
                        dataParams = new WriteParamsWithUnits(model1);
                        wfa = new WriteIGES((WriteParamsWithUnits)dataParams, saveFileDialog1.FileName);
                        break;
          
                }

                model1.StartWork(wfa);
            }
        }
        private int AddVolumeProperty(VolumeProperties vp, Entity ent, out bool blockReferenceNotScaled, bool isParentSelected = false)
        {
            int count = 0;
            blockReferenceNotScaled = true;

            if (ent.Selected || isParentSelected)
            {
                if (ent is IFace)
                {
                    IFace itfFace = (IFace)ent;

                    Mesh[] meshes = itfFace.GetPolygonMeshes();

                    foreach (Mesh mesh in meshes)
                    {
                        vp.Add(mesh.Vertices, mesh.Triangles);
                    }
                    count++;
                }
                else if (ent is BlockReference)
                {
                    var br = (BlockReference)ent;

                    if (br.GetScaleFactorX() != 1 &&
                         br.GetScaleFactorY() != 1 &&
                         br.GetScaleFactorZ() != 1)
                    {
                        blockReferenceNotScaled = false;
                        return count;
                    }

                    foreach (var e in br.GetEntities(model1.Blocks))
                    {
                        count += AddVolumeProperty(vp, e, out blockReferenceNotScaled, true);

                        if (!blockReferenceNotScaled) return count;
                    }
                }

            }

            return count;
        }

        private void volumeButton_Click(object sender, EventArgs e)
        {
            VolumeProperties vp = new VolumeProperties();

            int count = 0;
            var blockReferenceNotScaled = true;

            for (int i = 0; i < model1.Entities.Count && blockReferenceNotScaled; i++)
            {
                Entity ent = model1.Entities[i];

                count += AddVolumeProperty(vp, ent, out blockReferenceNotScaled);
            }

            StringBuilder text = new StringBuilder();

            if (blockReferenceNotScaled)
            {
                text.AppendLine(count + " entity(ies) selected");
                text.AppendLine("---------------------");

                if (vp.Centroid != null)
                {

                    double x, y, z;
                    double xx, yy, zz, xy, zx, yz;
                    MomentOfInertia world, centroid;

                    vp.GetResults(vp.Volume, vp.Centroid, out x, out y, out z, out xx, out yy, out zz, out xy, out zx, out yz, out world, out centroid);

                    text.AppendLine("Cumulative volume: " + vp.Volume + " cubic " + model1.Units.ToString().ToLower());
                    text.AppendLine("Cumulative centroid: " + vp.Centroid);
                    text.AppendLine("Cumulative volume moments:");
                    text.AppendLine(" First moments");
                    text.AppendLine("  x: " + x.ToString("g6"));
                    text.AppendLine("  y: " + y.ToString("g6"));
                    text.AppendLine("  z: " + z.ToString("g6"));
                    text.AppendLine(" Second moments");
                    text.AppendLine("  xx: " + xx.ToString("g6"));
                    text.AppendLine("  yy: " + yy.ToString("g6"));
                    text.AppendLine("  zz: " + zz.ToString("g6"));
                    text.AppendLine(" Product moments");
                    text.AppendLine("  xy: " + xx.ToString("g6"));
                    text.AppendLine("  yz: " + yy.ToString("g6"));
                    text.AppendLine("  zx: " + zz.ToString("g6"));
                    text.AppendLine(" Volume Moments of Inertia about World Coordinate Axes");
                    text.AppendLine("  Ix: " + world.Ix.ToString("g6"));
                    text.AppendLine("  Iy: " + world.Iy.ToString("g6"));
                    text.AppendLine("  Iz: " + world.Iz.ToString("g6"));
                    text.AppendLine(" Volume Radii of Gyration about World Coordinate Axes");
                    text.AppendLine("  Rx: " + world.Rx.ToString("g6"));
                    text.AppendLine("  Ry: " + world.Ry.ToString("g6"));
                    text.AppendLine("  Rz: " + world.Rz.ToString("g6"));
                    text.AppendLine(" Volume Moments of Inertia about Centroid Coordinate Axes:");
                    text.AppendLine("  Ix: " + centroid.Ix.ToString("g6"));
                    text.AppendLine("  Iy: " + centroid.Iy.ToString("g6"));
                    text.AppendLine("  Iz: " + centroid.Iz.ToString("g6"));
                    text.AppendLine(" Volume Radii of Gyration about Centroid Coordinate Axes");
                    text.AppendLine("  Rx: " + centroid.Rx.ToString("g6"));
                    text.AppendLine("  Ry: " + centroid.Ry.ToString("g6"));
                    text.AppendLine("  Rz: " + centroid.Rz.ToString("g6"));
                }
            }
            else
            {
                text.AppendLine("Error: scaled BlockReference not supported.");
                text.AppendLine("---------------------");
            }

            DetailsForm rf = new DetailsForm();

            rf.Text = "Volume Properties";

            rf.textBox1.Text = text.ToString();

            rf.Show();
        }
        private int AddAreaProperty(AreaProperties ap, Entity ent, out bool blockReferenceNotScaled, bool isParentSelected = false)
        {
            int count = 0;
            blockReferenceNotScaled = true;

            if (ent.Selected || isParentSelected)
            {
                if (ent is IFace)
                {
                    IFace itfFace = (IFace)ent;

                    Mesh[] meshes = itfFace.GetPolygonMeshes();

                    foreach (Mesh mesh in meshes)
                    {
                        ap.Add(mesh.Vertices, mesh.Triangles);
                    }
                    count++;
                }
                else if (ent is BlockReference)
                {
                    var br = (BlockReference)ent;

                    if (br.GetScaleFactorX() != 1 &&
                         br.GetScaleFactorY() != 1 &&
                         br.GetScaleFactorZ() != 1)
                    {
                        blockReferenceNotScaled = false;
                        return count;
                    }

                    foreach (var e in br.GetEntities(model1.Blocks))
                    {
                        count += AddAreaProperty(ap, e, out blockReferenceNotScaled, true);

                        if (!blockReferenceNotScaled) return count;
                    }
                }
                else
                {
                    ICurve itfCurve = (ICurve)ent;

                    if (itfCurve.IsClosed)
                        ap.Add(ent.Vertices);

                    count++;
                }

            }
#if NURBS
            else if (ent is Brep)
            {
                Brep brep = (Brep)ent;

                for (int j = 0; j < brep.Faces.Length; j++)
                {
                    Brep.Face sf = brep.Faces[j];
                    Mesh[] faceTessellation = sf.Tessellation;

                    if (brep.GetFaceSelection(j))
                    {
                        foreach (Mesh m in faceTessellation)
                            ap.Add(m.Vertices, m.Triangles);

                        count++;
                    }
                }
            }
#endif
            return count;
        }
        private void areaButton_Click(object sender, EventArgs e)
        {
            AreaProperties ap = new AreaProperties();

            int count = 0;

            var blockReferenceNotScaled = true;
            for (int i = 0; i < model1.Entities.Count && blockReferenceNotScaled; i++)
            {

                Entity ent = model1.Entities[i];

                count += AddAreaProperty(ap, ent, out blockReferenceNotScaled);
            }

            StringBuilder text = new StringBuilder();

            if (blockReferenceNotScaled)
            {
                text.AppendLine(count + " entity(ies) selected");
                text.AppendLine("---------------------");

                if (ap.Centroid != null)
                {

                    double x, y, z;
                    double xx, yy, zz, xy, zx, yz;
                    MomentOfInertia world, centroid;

                    ap.GetResults(ap.Area, ap.Centroid, out x, out y, out z, out xx, out yy, out zz, out xy, out zx, out yz, out world, out centroid);

                    text.AppendLine("Cumulative area: " + ap.Area + " square " + model1.Units.ToString().ToLower());
                    text.AppendLine("Cumulative centroid: " + ap.Centroid);
                    text.AppendLine("Cumulative area moments:");
                    text.AppendLine(" First moments");
                    text.AppendLine("  x: " + x.ToString("g6"));
                    text.AppendLine("  y: " + y.ToString("g6"));
                    text.AppendLine("  z: " + z.ToString("g6"));
                    text.AppendLine(" Second moments");
                    text.AppendLine("  xx: " + xx.ToString("g6"));
                    text.AppendLine("  yy: " + yy.ToString("g6"));
                    text.AppendLine("  zz: " + zz.ToString("g6"));
                    text.AppendLine(" Product moments");
                    text.AppendLine("  xy: " + xx.ToString("g6"));
                    text.AppendLine("  yz: " + yy.ToString("g6"));
                    text.AppendLine("  zx: " + zz.ToString("g6"));
                    text.AppendLine(" Area Moments of Inertia about World Coordinate Axes");
                    text.AppendLine("  Ix: " + world.Ix.ToString("g6"));
                    text.AppendLine("  Iy: " + world.Iy.ToString("g6"));
                    text.AppendLine("  Iz: " + world.Iz.ToString("g6"));
                    text.AppendLine(" Area Radii of Gyration about World Coordinate Axes");
                    text.AppendLine("  Rx: " + world.Rx.ToString("g6"));
                    text.AppendLine("  Ry: " + world.Ry.ToString("g6"));
                    text.AppendLine("  Rz: " + world.Rz.ToString("g6"));
                    text.AppendLine(" Area Moments of Inertia about Centroid Coordinate Axes:");
                    text.AppendLine("  Ix: " + centroid.Ix.ToString("g6"));
                    text.AppendLine("  Iy: " + centroid.Iy.ToString("g6"));
                    text.AppendLine("  Iz: " + centroid.Iz.ToString("g6"));
                    text.AppendLine(" Area Radii of Gyration about Centroid Coordinate Axes");
                    text.AppendLine("  Rx: " + centroid.Rx.ToString("g6"));
                    text.AppendLine("  Ry: " + centroid.Ry.ToString("g6"));
                    text.AppendLine("  Rz: " + centroid.Rz.ToString("g6"));

                }
            }
            else
            {
                text.AppendLine("Error: scaled BlockReference is not supported.");

                text.AppendLine("---------------------");
            }

            DetailsForm rf = new DetailsForm();

            rf.Text = "Area Properties";

            rf.textBox1.Text = text.ToString();

            rf.Show();
        }
        private void Selection()
        {
            switch (selectionComboBox.SelectedIndex)
            {
                case 0: // by pick
                    model1.ActionMode = actionType.SelectByPick;
                    break;

                case 1: // by box
                    model1.ActionMode = actionType.SelectByBox;
                    break;

                case 2: // by poly
                    model1.ActionMode = actionType.SelectByPolygon;
                    break;

                case 3: // by box enclosed
                    model1.ActionMode = actionType.SelectByBoxEnclosed;
                    break;

                case 4: // by poly enclosed
                    model1.ActionMode = actionType.SelectByPolygonEnclosed;
                    break;

                case 5: // visible by pick
                    model1.ActionMode = actionType.SelectVisibleByPick;
                    break;

                case 6: // visible by box
                    model1.ActionMode = actionType.SelectVisibleByBox;
                    break;

                case 7: // visible by poly
                    model1.ActionMode = actionType.SelectVisibleByPolygon;
                    break;

                case 8: // visible by pick dynamic
                    model1.ActionMode = actionType.SelectVisibleByPickDynamic;
                    break;

                case 9: // visible by pick label
                    model1.ActionMode = actionType.SelectVisibleByPickLabel;
                    groupButton.Enabled = false;
                    break;

                default:
                    model1.ActionMode = actionType.None;
                    break;
            }
        }
        private void selectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            groupButton.Enabled = true;

            if (selectCheckBox.Checked)

                Selection();

            else

                model1.ActionMode = actionType.None;
        }

        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            if (model1.ActionMode == actionType.SelectVisibleByPickLabel)

                model1.Viewports[0].Labels.ClearSelection();

            else

                model1.Entities.ClearSelection();

            model1.Invalidate();
        }
        private void invertSelectionButton_Click(object sender, EventArgs e)
        {
            if (model1.ActionMode == actionType.SelectVisibleByPickLabel)

                model1.Viewports[0].Labels.InvertSelection();

            else

                model1.Entities.InvertSelection();

            model1.Invalidate();
        }
        private void groupButton_Click(object sender, EventArgs e)
        {
            model1.GroupSelection();
        }
    }
    
}
