using System.Collections.Generic;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadViewport 
	{
		public AXDBLib.IAcadViewport _i;
		internal AcadViewport(object AcadViewport_object) 
		{
			this._i = AcadViewport_object as AXDBLib.IAcadViewport;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Center => this._i.Center;

		///<summary>
		///
		///</summary>
		public void Set_Center(object Center) 
		{
			this._i.Center = Center;
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
		public object Direction => this._i.Direction;

		///<summary>
		///
		///</summary>
		public void Set_Direction(object dirVec) 
		{
			this._i.Direction = dirVec;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string bstrName) 
		{
			this._i.Name = bstrName;
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
		public bool OrthoOn => this._i.OrthoOn;

		///<summary>
		///
		///</summary>
		public void Set_OrthoOn(bool bOrthoOn) 
		{
			this._i.OrthoOn = bOrthoOn;
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
		public dynamic SnapRotationAngle => this._i.SnapRotationAngle;

		///<summary>
		///
		///</summary>
		public void Set_SnapRotationAngle(dynamic Angle) 
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
		public object LowerLeftCorner => this._i.LowerLeftCorner;

		///<summary>
		///
		///</summary>
		public object UpperRightCorner => this._i.UpperRightCorner;

		///<summary>
		///
		///</summary>
		public void Split(AXDBLib.AcViewportSplitType NumWins) 
		{
			this._i.Split(NumWins);
		}

		///<summary>
		///
		///</summary>
		public List<double> GetGridSpacing()
        {
			double XSpacing;
			double YSpacing;

            this._i.GetGridSpacing(out XSpacing,out YSpacing);
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
		public void SetView(dynamic View) 
		{
			this._i.SetView(View);
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
	}
}
