using Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class Acad3DSolid 
	{
		public Autodesk.AutoCAD.Interop.Common.Acad3DSolid _i;
		internal Acad3DSolid(object Acad3DSolid_object) 
		{
			this._i = Acad3DSolid_object as Autodesk.AutoCAD.Interop.Common.Acad3DSolid;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
		/// <summary>
		/// Try cast from AcadEntity
		/// </summary>
		/// <param name="AcadEntity"></param>
		/// <exception cref="System.Exception"></exception>
		public Acad3DSolid(AcadEntity AcadEntity)
		{
			this._i = AcadEntity._i as Autodesk.AutoCAD.Interop.Common.Acad3DSolid;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

        ///<summary>
        /// Create sphere
        ///</summary>
        public static Acad3DSolid CreateSphere (AcadBlock AcadBlock, Point Center, double Radius)
        {
			return new Acad3DSolid(AcadBlock._i.AddSphere(Technical.PointByDynPoint(Center), Radius));
        }
        ///<summary>
        ///Create Torus
        ///</summary>
        public static Acad3DSolid CreateTorus (AcadBlock AcadBlock, Point Center, double TorusRadius, double TubeRadius)
        {
            return new Acad3DSolid(AcadBlock._i.AddTorus(Center, TorusRadius, TubeRadius));
        }

        ///<summary>
        ///Create Wedge
        ///</summary>
        public static Acad3DSolid CreateWedge (AcadBlock AcadBlock, Point Center, double Length, double Width, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddWedge(Technical.PointByDynPoint(Center), Length, Width, Height));
        }
        ///<summary>
        ///Create Cylinder
        ///</summary>
        public static Acad3DSolid CreateCylinder( AcadBlock AcadBlock, Point Center, double Radius, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddCylinder(Technical.PointByDynPoint(Center), Radius, Height));
        }
        ///<summary>
        ///
        ///</summary>
        public static Acad3DSolid CreateCone(AcadBlock AcadBlock, Point Center, double BaseRadius, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddCone(Technical.PointByDynPoint(Center), BaseRadius, Height));
        }
        //
        ///<summary>
        /// Create Box
        ///</summary>
        public static Acad3DSolid CreateBox(AcadBlock AcadBlock, Point Origin, 
			double Length, double Width, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddBox(Technical.PointByDynPoint(Origin), Length, Width, Height));
        }
        ///<summary>
        /// Create Elliptical Cone
        ///</summary>
        public static Acad3DSolid AddEllipticalCone(AcadBlock AcadBlock, Point Center,
			double MajorRadius, double MinorRadius, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddEllipticalCone(Technical.PointByDynPoint(Center),
				MajorRadius, MinorRadius, Height));
        }

        //
        ///<summary>
        /// Create Elliptical Cylinder
        ///</summary>
        public static Acad3DSolid AddEllipticalCylinder(AcadBlock AcadBlock,
            Point Center, double MajorRadius, double MinorRadius, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddEllipticalCylinder(Technical.PointByDynPoint(Center),
				MajorRadius, MinorRadius, Height));
        }

        ///<summary>
        ///Create Extruded Solid
        ///</summary>
        public static Acad3DSolid AddExtrudedSolid(AcadBlock AcadBlock, AcadRegion Profile,
			double Height, double TaperAngle)
        {
            return new Acad3DSolid(AcadBlock._i.AddExtrudedSolid(Profile._i, Height, TaperAngle));
        }

        ///<summary>
        ///Create Extruded Solid Along Path
        ///</summary>
        public static Acad3DSolid AddExtrudedSolidAlongPath(AcadBlock AcadBlock, AcadRegion Profile, dynamic Path)
        {
            return new Acad3DSolid(AcadBlock._i.AddExtrudedSolidAlongPath(Profile._i, Path));
        }

        ///<summary>
        ///
        ///</summary>
        public static Acad3DSolid AddRevolvedSolid(AcadBlock AcadBlock, AcadRegion Profile,
			Point AxisPoint, object AxisDir, double Angle)
        {
            return new Acad3DSolid(AcadBlock._i.AddRevolvedSolid(Profile._i, Technical.PointByDynPoint(AxisPoint),
				AxisDir, Angle));
        }

        ///<summary>
        ///
        ///</summary>
        public Point Centroid => Technical.PointByDoubleArray(this._i.Centroid);

		///<summary>
		///
		///</summary>
		public object MomentOfInertia => this._i.MomentOfInertia;

		///<summary>
		///
		///</summary>
		public object PrincipalDirections => this._i.PrincipalDirections;

		///<summary>
		///
		///</summary>
		public object PrincipalMoments => this._i.PrincipalMoments;

		///<summary>
		///
		///</summary>
		public object ProductOfInertia => this._i.ProductOfInertia;

		///<summary>
		///
		///</summary>
		public object RadiiOfGyration => this._i.RadiiOfGyration;

		///<summary>
		///
		///</summary>
		public double Volume => this._i.Volume;

		///<summary>
		///
		///</summary>
		public void Boolean(Autodesk.AutoCAD.Interop.Common.AcBooleanType Operation,dynamic SolidObject) 
		{
			this._i.Boolean(Operation,SolidObject);
		}

		///<summary>
		///
		///</summary>
		public dynamic CheckInterference(dynamic Object,bool CreateInterferenceSolid) 
		{
			bool SolidsInterfere;
			var data = this._i.CheckInterference(Object, CreateInterferenceSolid, out SolidsInterfere);
			return data;

        }

		///<summary>
		///
		///</summary>
		public dynamic SectionSolid(object Point1,object Point2,object point3) 
		{
			return this._i.SectionSolid(Point1,Point2,point3);
		}

		///<summary>
		///
		///</summary>
		public dynamic SliceSolid(object Point1,object Point2,object point3,bool Negative) 
		{
			return this._i.SliceSolid(Point1,Point2,point3,Negative);
		}

		///<summary>
		///
		///</summary>
		public string SolidType => this._i.SolidType;

		///<summary>
		///
		///</summary>
		public object Position => this._i.Position;

		///<summary>
		///
		///</summary>
		public void Set_Position(object Position) 
		{
			this._i.Position = Position;
		}

		///<summary>
		///
		///</summary>
		public bool History => this._i.History;

		///<summary>
		///
		///</summary>
		public void Set_History(bool bHistory) 
		{
			this._i.History = bHistory;
		}

		///<summary>
		///
		///</summary>
		public bool ShowHistory => this._i.ShowHistory;

		///<summary>
		///
		///</summary>
		public void Set_ShowHistory(bool Position) 
		{
			this._i.ShowHistory = Position;
		}
	}
}
