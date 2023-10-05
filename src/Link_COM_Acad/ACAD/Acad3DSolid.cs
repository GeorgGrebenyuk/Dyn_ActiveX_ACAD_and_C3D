using Autodesk.DesignScript.Geometry;
using System.Reflection;

namespace DynAXDBLib 
{

    ///<summary>
    /// A solid object with free-form surface support
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

        /// <summary>
        /// Creates a sphere given the center and radius
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="Center">The 3D WCS coordinates specifying the sphere center point</param>
        /// <param name="Radius">The radius of the sphere. Must be a positive number</param>
        /// <returns></returns>
        public static Acad3DSolid CreateSphere (AcadBlock AcadBlock, Point Center, double Radius)
        {
            return new Acad3DSolid(AcadBlock._i.AddSphere(Technical.PointByDynPoint(Center), Radius));
        }

        /// <summary>
        /// Creates a torus at the given location
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="Center">The 3D WCS coordinates in the drawing around which the torus is centered</param>
        /// <param name="TorusRadius">The distance from the center of the torus to the center of the tube. Must be a positive number</param>
        /// <param name="TubeRadius">The radius of the tube. Must be a positive number</param>
        /// <returns></returns>
        public static Acad3DSolid CreateTorus (AcadBlock AcadBlock, Point Center, double TorusRadius, double TubeRadius)
        {
            return new Acad3DSolid(AcadBlock._i.AddTorus(Center, TorusRadius, TubeRadius));
        }

        /// <summary>
		/// Creates a wedge with edges parallel to the axes given the length, width, and height
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="Center">The 3D WCS coordinates specifying the center of the wedge face</param>
		/// <param name="Length">The length of the wedge corresponding to the X axis. Must be a positive number</param>
		/// <param name="Width">The width of the wedge corresponding to the Y axis. Must be a positive number</param>
		/// <param name="Height">The height of the wedge corresponding to the Z axis. Must be a positive number</param>
		/// <returns></returns>
        public static Acad3DSolid CreateWedge (AcadBlock AcadBlock, Point Center, double Length, double Width, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddWedge(Technical.PointByDynPoint(Center), Length, Width, Height));
        }

        /// <summary>
		/// A 3D WCS coordinates specifying the center of the bounding box
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="Center">A 3D WCS coordinates specifying the center of the bounding box</param>
		/// <param name="Radius">The cylinder radius. Must be a positive number</param>
		/// <param name="Height">The cylinder height. Must be a positive number</param>
		/// <returns></returns>
        public static Acad3DSolid CreateCylinder( AcadBlock AcadBlock, Point Center, double Radius, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddCylinder(Technical.PointByDynPoint(Center), Radius, Height));
        }

        /// <summary>
		/// The 3D WCS coordinates specifying the center of the bounding box
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="Center">The 3D WCS coordinates specifying the center of the bounding box</param>
		/// <param name="BaseRadius">The radius of the cone base. Must be a positive number</param>
		/// <param name="Height">The height of the cone. Must be a positive number</param>
		/// <returns></returns>
        public static Acad3DSolid CreateCone(AcadBlock AcadBlock, Point Center, double BaseRadius, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddCone(Technical.PointByDynPoint(Center), BaseRadius, Height));
        }

        /// <summary>
        /// Creates a 3D solid box with edges parallel to the axes of the WCS
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="Origin">The 3D WCS coordinates specifying the origin of the box. This coordinate represents the center of the bounding box for the object, not a corner</param>
        /// <param name="Length">The length of the box. Must be a positive number</param>
        /// <param name="Width">The width of the box. Must be a positive number</param>
        /// <param name="Height">The height of the box. Must be a positive number</param>
        /// <returns></returns>
        public static Acad3DSolid CreateBox(AcadBlock AcadBlock, Point Origin, 
			double Length, double Width, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddBox(Technical.PointByDynPoint(Origin), Length, Width, Height));
        }

        /// <summary>
		/// Creates a 3D solid elliptical cone on the XY plane of the WCS given the Center, MajorRadius, MinorRadius, and Height
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="Center">The 3D WCS coordinates specifying the center of the bounding box</param>
		/// <param name="MajorRadius">The length of the major radius for the ellipse base. Must be a positive number</param>
		/// <param name="MinorRadius">The length of the minor radius for the ellipse base. Must be a positive number</param>
		/// <param name="Height">The height of the cone. Must be a positive number</param>
		/// <returns></returns>
        public static Acad3DSolid AddEllipticalCone(AcadBlock AcadBlock, Point Center,
			double MajorRadius, double MinorRadius, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddEllipticalCone(Technical.PointByDynPoint(Center),
				MajorRadius, MinorRadius, Height));
        }

        /// <summary>
		/// Creates a 3D solid elliptical cylinder whose base is on the XY plane of the WCS, given the Center, MajorRadius, MinorRadius, and Height
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="Center">The 3D WCS coordinates specifying the center of the bounding box</param>
		/// <param name="MajorRadius">The length of the major radius for the ellipse base. Must be a positive number</param>
		/// <param name="MinorRadius">The length of the minor radius for the ellipse base. Must be a positive number</param>
		/// <param name="Height">The height of the cylinder. Must be a positive number</param>
		/// <returns></returns>
        public static Acad3DSolid AddEllipticalCylinder(AcadBlock AcadBlock,
            Point Center, double MajorRadius, double MinorRadius, double Height)
        {
            return new Acad3DSolid(AcadBlock._i.AddEllipticalCylinder(Technical.PointByDynPoint(Center),
				MajorRadius, MinorRadius, Height));
        }

        /// <summary>
        /// Creates an extruded solid given the profile, height, and taper angle
        /// </summary>
        /// <param name="AcadBlock"></param>
        /// <param name="Profile">A profile can only be a Region object</param>
        /// <param name="Height">The height of the extrusion along the Z axis of the object's coordinate system. If you enter a positive number, AutoCAD extrudes the object along the positive Z axis. If you enter a negative number, AutoCAD extrudes the object along the negative Z axis</param>
        /// <param name="TaperAngle">The taper angle of the extrusion must be provided in radians. The range of the taper angle is from -90 to +90 degrees. Positive angles taper in from the base, negative angles taper out. The default angle, 0, extrudes a 2D object perpendicular to its plane
		/// </param>
		/// <returns></returns>
        public static Acad3DSolid AddExtrudedSolid(AcadBlock AcadBlock, AcadRegion Profile,
			double Height, double TaperAngle)
        {
            return new Acad3DSolid(AcadBlock._i.AddExtrudedSolid(Profile._i, Height, TaperAngle));
        }

        /// <summary>
		/// Creates an extruded solid given the profile and an extrusion path
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="Profile">A profile can only be a Region object</param>
		/// <param name="Path">The path can only be a Polyline, Circle, Ellipse, Spline, or Arc object</param>
		/// <returns></returns>
        public static Acad3DSolid AddExtrudedSolidAlongPath(AcadBlock AcadBlock, AcadRegion Profile, dynamic Path)
        {
            return new Acad3DSolid(AcadBlock._i.AddExtrudedSolidAlongPath(Profile._i, Path));
        }

        /// <summary>
		/// Creates a revolved solid, given the region around an axis
		/// </summary>
		/// <param name="AcadBlock"></param>
		/// <param name="Profile">A profile can only a Region object</param>
		/// <param name="AxisPoint">The 3D WCS coordinates specifying the start point of the axis of revolution</param>
		/// <param name="AxisDir">A 3D vector specifying the direction of the axis of revolution</param>
		/// <param name="Angle"></param>
		/// <returns></returns>
        public static Acad3DSolid AddRevolvedSolid(AcadBlock AcadBlock, AcadRegion Profile,
			Point AxisPoint, Vector AxisDir, double Angle)
        {
            return new Acad3DSolid(AcadBlock._i.AddRevolvedSolid(Profile._i, Technical.PointByDynPoint(AxisPoint),
			 Technical.VectorByDynVector(AxisDir), Angle));
        }

        ///<summary>
        /// Gets the center of area or mass for a solid
        ///</summary>
        public Point Centroid => Technical.PointByDoubleArray(this._i.Centroid);

        ///<summary>
        /// Gets the moment of inertia for the solid
        ///</summary>
        public object MomentOfInertia => this._i.MomentOfInertia;

        ///<summary>
        /// Gets the principal directions of the solid
        ///</summary>
        public object PrincipalDirections => this._i.PrincipalDirections;

        ///<summary>
        ///Gets the principal moments property of the solid
        ///</summary>
        public object PrincipalMoments => this._i.PrincipalMoments;

        ///<summary>
        ///Gets the product of inertia of the solid 
        ///</summary>
        public object ProductOfInertia => this._i.ProductOfInertia;

        ///<summary>
        ///Gets the radius of gyration of the solid 
        ///</summary>
        public object RadiiOfGyration => this._i.RadiiOfGyration;

        ///<summary>
        ///Gets the volume of the solid
        ///</summary>
        public double Volume => this._i.Volume;

        ///<summary>
        ///Performs a Boolean operation (union, intersect, or subtract) between the object and another 3DSolid or Region object
        ///</summary>
        public void Boolean(Autodesk.AutoCAD.Interop.Common.AcBooleanType Operation,dynamic SolidObject) 
		{
			this._i.Boolean(Operation,SolidObject._i);
		}

        /// <summary>
		/// Checks for interference between two solids and, if specified, creates a solid from the interference
		/// </summary>
		/// <param name="Object">The object to check against</param>
		/// <param name="CreateInterferenceSolid">True: Creates the interference solid; False: Does not create the interference solid</param>
		/// <returns>The solids do interfere; The solids do not interfere</returns>
        public Acad3DSolid CheckInterference(dynamic Object,bool CreateInterferenceSolid) 
		{
			bool SolidsInterfere;
			var data = this._i.CheckInterference(Object._i, CreateInterferenceSolid, out SolidsInterfere);
			return new Acad3DSolid(data);

        }

        /// <summary>
		/// Creates a region that represents the intersection of a plane defined by three points and the solid
		/// </summary>
		/// <param name="Point1">The 3D WCS coordinates specifying the first point</param>
		/// <param name="Point2">The 3D WCS coordinates specifying the second point</param>
		/// <param name="Point3">The 3D WCS coordinates specifying the third point</param>
		/// <returns>The resulting section as a region</returns>
        public AcadRegion SectionSolid(Point Point1, Point Point2, Point Point3) 
		{
			return new AcadRegion(this._i.SectionSolid(Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2), Technical.PointByDynPoint(Point3)));
		}

        /// <summary>
        /// Creates a slice of the 3DSolid object given three points that define the plane
        /// </summary>
        /// <param name="Point1">The 3D WCS coordinates specifying the first point</param>
        /// <param name="Point2">The 3D WCS coordinates specifying the second point</param>
        /// <param name="Point3"></param>
        /// <param name="Negative">This specifies whether to return the part of the solid that is on the negative side of the plane. If True, then AutoCAD creates a new 3DSolid object that contains the portion of the original solid that is on the negative normal side of the plane</param>
        /// <returns></returns>
        public Acad3DSolid SliceSolid(Point Point1, Point Point2, Point Point3, bool Negative)
        {
			return new Acad3DSolid(this._i.SliceSolid(Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2), Technical.PointByDynPoint(Point3), Negative));
		}

        ///<summary>
        ///Indicates the type of solid
        ///</summary>
        public string SolidType => this._i.SolidType;

        ///<summary>
        /// Specifies the X, Y, Z coordinate for center of the base or center of the solid
        ///</summary>
        public Point Position => this._i.Position;

        ///<summary>
        ///Specifies the X, Y, Z coordinate for center of the base or center of the solid
        ///</summary>
        public void Set_Position(Point Position) 
		{
			this._i.Position = Technical.PointByDynPoint(Position);
		}

        ///<summary>
        ///Specifies whether history is saved
        ///</summary>
        public bool History => this._i.History;

        ///<summary>
        ///Specifies whether history is saved
        ///</summary>
        public void Set_History(bool bHistory) 
		{
			this._i.History = bHistory;
		}

        ///<summary>
        ///Specifies whether to show history of the solid
        ///</summary>
        public bool ShowHistory => this._i.ShowHistory;

        ///<summary>
        ///Specifies whether to show history of the solid
        ///</summary>
        public void Set_ShowHistory(bool Position) 
		{
			this._i.ShowHistory = Position;
		}
	}
}
