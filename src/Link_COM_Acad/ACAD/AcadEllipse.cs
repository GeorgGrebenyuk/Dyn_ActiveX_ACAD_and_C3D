using Autodesk.DesignScript.Geometry;
namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadEllipse 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadEllipse _i;
		internal AcadEllipse(object AcadEllipse_object) 
		{
			this._i = AcadEllipse_object as Autodesk.AutoCAD.Interop.Common.AcadEllipse;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadEllipse(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadEllipse;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        ///Create new Ellipse
        ///</summary>
        public AcadEllipse (AcadBlock AcadBlock, Point Center, object MajorAxis, double RadiusRatio)
        {
            this._i = AcadBlock._i.AddEllipse(Technical.PointByDynPoint(Center), MajorAxis, RadiusRatio);
        }

        ///<summary>
        ///
        ///</summary>
        public Point StartPoint => Technical.PointByDoubleArray(this._i.StartPoint);

		///<summary>
		///
		///</summary>
		public Point Center => Technical.PointByDoubleArray(this._i.Center);

		///<summary>
		///
		///</summary>
		public void Set_Center(Point Center) 
		{
			this._i.Center = Technical.PointByDynPoint(Center);
		}

		///<summary>
		///
		///</summary>
		public Point EndPoint => Technical.PointByDoubleArray(this._i.EndPoint);

		///<summary>
		///
		///</summary>
		public double MajorRadius => this._i.MajorRadius;

		///<summary>
		///
		///</summary>
		public void Set_MajorRadius(double MajorRadius) 
		{
			this._i.MajorRadius = MajorRadius;
		}

		///<summary>
		///
		///</summary>
		public double MinorRadius => this._i.MinorRadius;

		///<summary>
		///
		///</summary>
		public void Set_MinorRadius(double MinorRadius) 
		{
			this._i.MinorRadius = MinorRadius;
		}

		///<summary>
		///
		///</summary>
		public double RadiusRatio => this._i.RadiusRatio;

		///<summary>
		///
		///</summary>
		public void Set_RadiusRatio(double RadiusRatio) 
		{
			this._i.RadiusRatio = RadiusRatio;
		}

		///<summary>
		///
		///</summary>
		public dynamic StartAngle => this._i.StartAngle;

		///<summary>
		///
		///</summary>
		public void Set_StartAngle(dynamic StartAngle) 
		{
			this._i.StartAngle = StartAngle;
		}

		///<summary>
		///
		///</summary>
		public dynamic EndAngle => this._i.EndAngle;

		///<summary>
		///
		///</summary>
		public void Set_EndAngle(dynamic EndAngle) 
		{
			this._i.EndAngle = EndAngle;
		}

		///<summary>
		///
		///</summary>
		public double StartParameter => this._i.StartParameter;

		///<summary>
		///
		///</summary>
		public void Set_StartParameter(double StartParameter) 
		{
			this._i.StartParameter = StartParameter;
		}

		///<summary>
		///
		///</summary>
		public double EndParameter => this._i.EndParameter;

		///<summary>
		///
		///</summary>
		public void Set_EndParameter(double EndParameter) 
		{
			this._i.EndParameter = EndParameter;
		}

		///<summary>
		///
		///</summary>
		public object MajorAxis => this._i.MajorAxis;

		///<summary>
		///
		///</summary>
		public void Set_MajorAxis(object MajorAxis) 
		{
			this._i.MajorAxis = MajorAxis;
		}

		///<summary>
		///
		///</summary>
		public object MinorAxis => this._i.MinorAxis;

		///<summary>
		///
		///</summary>
		public object Normal => this._i.Normal;

		///<summary>
		///
		///</summary>
		public void Set_Normal(object Normal) 
		{
			this._i.Normal = Normal;
		}

		///<summary>
		///
		///</summary>
		public double Area => this._i.Area;

		///<summary>
		///
		///</summary>
		public object Offset(double Distance) 
		{
			return this._i.Offset(Distance);
		}
	}
}
