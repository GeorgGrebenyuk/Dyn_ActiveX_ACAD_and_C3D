using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPointCloud 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadPointCloud _i;
		internal AcadPointCloud(object AcadPointCloud_object) 
		{
			this._i = AcadPointCloud_object as Autodesk.AutoCAD.Interop.Common.AcadPointCloud;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Try cast from AcadEntity
        /// </summary>
        /// <param name="AcadEntity"></param>
        /// <exception cref="System.Exception"></exception>
        public AcadPointCloud(AcadEntity AcadEntity)
        {
            this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.AcadPointCloud;
            if (this._i == null) throw new System.Exception("Invalid casting");
        }
        ///<summary>
        ///
        ///</summary>
        public object UseEntityColor => this._i.UseEntityColor;

		///<summary>
		///
		///</summary>
		public void Set_UseEntityColor(Autodesk.AutoCAD.Interop.Common.AcPointCloudColorType val) 
		{
			this._i.UseEntityColor = val;
		}

		///<summary>
		///
		///</summary>
		public bool ShowIntensity => this._i.ShowIntensity;

		///<summary>
		///
		///</summary>
		public void Set_ShowIntensity(bool val) 
		{
			this._i.ShowIntensity = val;
		}

		///<summary>
		///
		///</summary>
		public object IntensityColorScheme => this._i.IntensityColorScheme;

		///<summary>
		///
		///</summary>
		public void Set_IntensityColorScheme(Autodesk.AutoCAD.Interop.Common.AcPointCloudIntensityStyle val) 
		{
			this._i.IntensityColorScheme = val;
		}

		///<summary>
		///
		///</summary>
		public Point InsertionPoint => Technical.PointByDoubleArray(this._i.InsertionPoint);

		///<summary>
		///
		///</summary>
		public void Set_InsertionPoint(Point EndPoint) 
		{
			this._i.InsertionPoint = Technical.PointByDynPoint(EndPoint);
		}

		///<summary>
		///
		///</summary>
		public double Rotation => this._i.Rotation;

		///<summary>
		///
		///</summary>
		public void Set_Rotation(double val) 
		{
			this._i.Rotation = val;
		}

		///<summary>
		///
		///</summary>
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void Set_Width(double val) 
		{
			this._i.Width = val;
		}

		///<summary>
		///
		///</summary>
		public double Length => this._i.Length;

		///<summary>
		///
		///</summary>
		public void Set_Length(double val) 
		{
			this._i.Length = val;
		}

		///<summary>
		///
		///</summary>
		public double Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public void Set_Height(double val) 
		{
			this._i.Height = val;
		}

		///<summary>
		///
		///</summary>
		public double scale => this._i.scale;

		///<summary>
		///
		///</summary>
		public void Set_scale(double val) 
		{
			this._i.scale = val;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public string Path => this._i.Path;

		///<summary>
		///
		///</summary>
		public bool ShowClipped => this._i.ShowClipped;

		///<summary>
		///
		///</summary>
		public void Set_ShowClipped(bool val) 
		{
			this._i.ShowClipped = val;
		}

		///<summary>
		///
		///</summary>
		public bool Locked => this._i.Locked;

		///<summary>
		///
		///</summary>
		public void Set_Locked(bool val) 
		{
			this._i.Locked = val;
		}

		///<summary>
		///
		///</summary>
		public object Stylization => this._i.Stylization;

		///<summary>
		///
		///</summary>
		public void Set_Stylization(Autodesk.AutoCAD.Interop.Common.AcPointCloudStylizationType val) 
		{
			this._i.Stylization = val;
		}

		///<summary>
		///
		///</summary>
		public string Unit => this._i.Unit;

		///<summary>
		///
		///</summary>
		public double UnitFactor => this._i.UnitFactor;
	}
}
