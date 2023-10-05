using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

    ///<summary>
    /// A source of point cloud content
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
        /// Specifies the color source for the point cloud
        ///</summary>
        public object UseEntityColor => this._i.UseEntityColor;

        ///<summary>
        ///Specifies the color source for the point cloud
        ///</summary>
        public void Set_UseEntityColor(Autodesk.AutoCAD.Interop.Common.AcPointCloudColorType val) 
		{
			this._i.UseEntityColor = val;
		}

        ///<summary>
        ///Specifies if the point cloud is displayed using a shaded color scheme
        ///</summary>
        public bool ShowIntensity => this._i.ShowIntensity;

        ///<summary>
        ///Specifies if the point cloud is displayed using a shaded color scheme
        ///</summary>
        public void Set_ShowIntensity(bool val) 
		{
			this._i.ShowIntensity = val;
		}

        ///<summary>
        ///Specifies the color scheme to use for displaying intensity values
        ///</summary>
        public object IntensityColorScheme => this._i.IntensityColorScheme;

        ///<summary>
        ///Specifies the color scheme to use for displaying intensity values
        ///</summary>
        public void Set_IntensityColorScheme(Autodesk.AutoCAD.Interop.Common.AcPointCloudIntensityStyle val) 
		{
			this._i.IntensityColorScheme = val;
		}

        ///<summary>
        ///Insertion point for a  object
        ///</summary>
        public Point InsertionPoint => Technical.PointByDoubleArray(this._i.InsertionPoint);

        ///<summary>
        ///Insertion point for a  object
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
        ///Specifies the width of the object
        ///</summary>
        public double Width => this._i.Width;

        ///<summary>
        ///Specifies the width of the object
        ///</summary>
        public void Set_Width(double val) 
		{
			this._i.Width = val;
		}

        ///<summary>
        ///Gets the length of an object
        ///</summary>
        public double Length => this._i.Length;

        ///<summary>
        ///Sets the length of an object
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
        ///Specifies the scale factor from start to the end of the sweep path
        ///</summary>
        public double scale => this._i.scale;

        ///<summary>
        ///Specifies the scale factor from start to the end of the sweep path
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
        ///Gets the path of the block, document, application, or external reference
        ///</summary>
        public string Path => this._i.Path;

        ///<summary>
        ///Enables or disables the clipping boundary
        ///</summary>
        public bool ShowClipped => this._i.ShowClipped;

        ///<summary>
        ///Enables or disables the clipping boundary
        ///</summary>
        public void Set_ShowClipped(bool val) 
		{
			this._i.ShowClipped = val;
		}

        ///<summary>
        ///Specifies if the point cloud is locked
        ///</summary>
        public bool Locked => this._i.Locked;

        ///<summary>
        ///Specifies if the point cloud is locked
        ///</summary>
        public void Set_Locked(bool val) 
		{
			this._i.Locked = val;
		}

        ///<summary>
        ///Specifies color stylization for selected point cloud
        ///</summary>
        public object Stylization => this._i.Stylization;

        ///<summary>
        ///Specifies color stylization for selected point cloud
        ///</summary>
        public void Set_Stylization(Autodesk.AutoCAD.Interop.Common.AcPointCloudStylizationType val) 
		{
			this._i.Stylization = val;
		}

        ///<summary>
        ///Gets the unit of the point cloud file
        ///</summary>
        public string Unit => this._i.Unit;

        ///<summary>
        ///Gets the insertion unit factor of the point cloud file
        ///</summary>
        public double UnitFactor => this._i.UnitFactor;
	}
}
