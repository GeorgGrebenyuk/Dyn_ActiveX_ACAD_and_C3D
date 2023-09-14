using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPViewport 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadPViewport _i;
		internal AcadPViewport(object AcadPViewport_object) 
		{
			this._i = AcadPViewport_object as Autodesk.AutoCAD.Interop.Common.IAcadPViewport;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Center => this._i.Center;

		///<summary>
		///
		///</summary>
		public void Set_Center(object CenterPoint) 
		{
			this._i.Center = CenterPoint;
		}

		///<summary>
		///
		///</summary>
		public object Direction => this._i.Direction;

		///<summary>
		///
		///</summary>
		public void Set_Direction(object dirVector) 
		{
			this._i.Direction = dirVector;
		}

		///<summary>
		///
		///</summary>
		public bool GridOn => this._i.GridOn;

		///<summary>
		///
		///</summary>
		public void Set_GridOn(bool bGridOn) 
		{
			this._i.GridOn = bGridOn;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double Height) 
		{
			this._i.Height = Height;
		}

		///<summary>
		///
		///</summary>
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void Set_Width(double Width) 
		{
			this._i.Width = Width;
		}

		///<summary>
		///
		///</summary>
		public bool ViewportOn => this._i.ViewportOn;

		///<summary>
		///
		///</summary>
		public void Set_ViewportOn(bool bOn) 
		{
			this._i.ViewportOn = bOn;
		}

		///<summary>
		///
		///</summary>
		public bool Clipped => this._i.Clipped;

		///<summary>
		///
		///</summary>
		public bool DisplayLocked => this._i.DisplayLocked;

		///<summary>
		///
		///</summary>
		public void Set_DisplayLocked(bool bLocked) 
		{
			this._i.DisplayLocked = bLocked;
		}

		///<summary>
		///
		///</summary>
		public dynamic StandardScale => this._i.StandardScale;

		///<summary>
		///
		///</summary>
		public void Set_StandardScale(Autodesk.AutoCAD.Interop.Common.AcViewportScale scale) 
		{
			this._i.StandardScale = scale;
		}

		///<summary>
		///
		///</summary>
		public double CustomScale => this._i.CustomScale;

		///<summary>
		///
		///</summary>
		public void Set_CustomScale(double scale) 
		{
			this._i.CustomScale = scale;
		}

		///<summary>
		///
		///</summary>
		public string StyleSheet => this._i.StyleSheet;

		///<summary>
		///
		///</summary>
		public void Set_StyleSheet(string pName) 
		{
			this._i.StyleSheet = pName;
		}

		///<summary>
		///
		///</summary>
		public bool UCSPerViewport => this._i.UCSPerViewport;

		///<summary>
		///
		///</summary>
		public void Set_UCSPerViewport(bool UCSSaved) 
		{
			this._i.UCSPerViewport = UCSSaved;
		}

		///<summary>
		///
		///</summary>
		public object SnapBasePoint => this._i.SnapBasePoint;

		///<summary>
		///
		///</summary>
		public void Set_SnapBasePoint(object lowLeft) 
		{
			this._i.SnapBasePoint = lowLeft;
		}

		///<summary>
		///
		///</summary>
		public bool SnapOn => this._i.SnapOn;

		///<summary>
		///
		///</summary>
		public void Set_SnapOn(bool bSnapOn) 
		{
			this._i.SnapOn = bSnapOn;
		}

		///<summary>
		///
		///</summary>
		public double SnapRotationAngle => this._i.SnapRotationAngle;

		///<summary>
		///
		///</summary>
		public void Set_SnapRotationAngle(double Angle) 
		{
			this._i.SnapRotationAngle = Angle;
		}

		///<summary>
		///
		///</summary>
		public bool UCSIconOn => this._i.UCSIconOn;

		///<summary>
		///
		///</summary>
		public void Set_UCSIconOn(bool bIconOn) 
		{
			this._i.UCSIconOn = bIconOn;
		}

		///<summary>
		///
		///</summary>
		public bool UCSIconAtOrigin => this._i.UCSIconAtOrigin;

		///<summary>
		///
		///</summary>
		public void Set_UCSIconAtOrigin(bool bIconAtOrigin) 
		{
			this._i.UCSIconAtOrigin = bIconAtOrigin;
		}

		///<summary>
		///
		///</summary>
        public List<double> GetGridSpacing()
        {
            double XSpacing;
            double YSpacing;

            this._i.GetGridSpacing(out XSpacing, out YSpacing);
            return new List<double> { XSpacing, YSpacing };
        }

        ///<summary>
        ///
        ///</summary>
        public void SetGridSpacing(double XSpacing,double YSpacing) 
		{
			this._i.SetGridSpacing(XSpacing,YSpacing);
		}

		///<summary>
		///
		///</summary>
        public List<double> GetSnapSpacing()
        {
            double XSpacing;
            double YSpacing;

            this._i.GetSnapSpacing(out XSpacing, out YSpacing);
            return new List<double> { XSpacing, YSpacing };
        }

        ///<summary>
        ///
        ///</summary>
        public void SetSnapSpacing(double XSpacing,double YSpacing) 
		{
			this._i.SetSnapSpacing(XSpacing,YSpacing);
		}

		///<summary>
		///
		///</summary>
		public void Display(bool bStatus) 
		{
			this._i.Display(bStatus);
		}

		///<summary>
		///
		///</summary>
		public dynamic TwistAngle => this._i.TwistAngle;

		///<summary>
		///
		///</summary>
		public void Set_TwistAngle(dynamic Angle) 
		{
			this._i.TwistAngle = Angle;
		}

		///<summary>
		///
		///</summary>
		public double LensLength => this._i.LensLength;

		///<summary>
		///
		///</summary>
		public void Set_LensLength(double Length) 
		{
			this._i.LensLength = Length;
		}

		///<summary>
		///
		///</summary>
		public bool RemoveHiddenLines => this._i.RemoveHiddenLines;

		///<summary>
		///
		///</summary>
		public void Set_RemoveHiddenLines(bool bRemoval) 
		{
			this._i.RemoveHiddenLines = bRemoval;
		}

		///<summary>
		///
		///</summary>
		public object Target => this._i.Target;

		///<summary>
		///
		///</summary>
		public void Set_Target(object targetPoint) 
		{
			this._i.Target = targetPoint;
		}

		///<summary>
		///
		///</summary>
		public dynamic ArcSmoothness => this._i.ArcSmoothness;

		///<summary>
		///
		///</summary>
		public void Set_ArcSmoothness(dynamic arcSmooth) 
		{
			this._i.ArcSmoothness = arcSmooth;
		}

		///<summary>
		///
		///</summary>
		public int VisualStyle => this._i.VisualStyle;

		///<summary>
		///
		///</summary>
		public void Set_VisualStyle(int pVisualStyleIndex) 
		{
			this._i.VisualStyle = pVisualStyleIndex;
		}

		///<summary>
		///
		///</summary>
		public int ShadePlot => this._i.ShadePlot;

		///<summary>
		///
		///</summary>
		public void Set_ShadePlot(int pShadePlotIndex) 
		{
			this._i.ShadePlot = pShadePlotIndex;
		}

		///<summary>
		///
		///</summary>
		public dynamic ModelView => this._i.ModelView;

		///<summary>
		///
		///</summary>
		public void Set_ModelView(dynamic View) 
		{
			this._i.ModelView = View;
		}

		///<summary>
		///
		///</summary>
		public dynamic SheetView => this._i.SheetView;

		///<summary>
		///
		///</summary>
		public void Set_SheetView(dynamic View) 
		{
			this._i.SheetView = View;
		}

		///<summary>
		///
		///</summary>
		public bool HasSheetView => this._i.HasSheetView;

		///<summary>
		///
		///</summary>
		public void SyncModelView() 
		{
			this._i.SyncModelView();
		}

		///<summary>
		///
		///</summary>
		public int StandardScale2 => this._i.StandardScale2;

		///<summary>
		///
		///</summary>
		public void Set_StandardScale2(int scale) 
		{
			this._i.StandardScale2 = scale;
		}

		///<summary>
		///
		///</summary>
		public bool LayerPropertyOverrides => this._i.LayerPropertyOverrides;
	}
}
