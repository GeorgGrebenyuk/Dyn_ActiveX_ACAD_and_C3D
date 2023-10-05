using Autodesk.AutoCAD.Interop.Common;
using Autodesk.DesignScript.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DynAXDBLib 
{

    ///<summary>
    /// The standard interface for a basic AutoCAD entity
    ///</summary>
    public class AcadEntity 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadEntity _i;
        
        internal AcadEntity(object AcadEntity_object) 
		{
			this._i = AcadEntity_object as Autodesk.AutoCAD.Interop.Common.AcadEntity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Cast to AcadEntity from any object
        /// </summary>
        /// <param name="AnyModelObject"></param>
        public static AcadEntity ByAnyObject (dynamic AnyModelObject)
		{
			try
			{
				var casted_interface = AnyModelObject._i as Autodesk.AutoCAD.Interop.Common.AcadEntity;
				if (casted_interface == null) throw new Exception("Invalid castings");
                return new AcadEntity(casted_interface);
			}
			catch { }
            throw new Exception("Invalid castings");
        }
		/// <summary>
		/// Get entities that select in AutoCAD drawing
		/// </summary>
		/// <param name="acadDocument"></param>
		/// <returns></returns>
		public static List<AcadEntity> SelectEntities (AcadDocument acadDocument)
		{
			List<AcadEntity> es = new List<AcadEntity>();
			foreach (AcadEntity e in acadDocument._i.ActiveSelectionSet)
			{
				es.Add(new AcadEntity(e));
			}

            return es;
        }

        ///<summary>
        ///Specifies the True Color of an object
        ///</summary>
        public AcadAcCmColor TrueColor => new AcadAcCmColor(this._i.TrueColor);

        ///<summary>
        ///Specifies the True Color of an object
        ///</summary>
        public void Set_TrueColor(AcadAcCmColor pColor) 
		{
			this._i.TrueColor =pColor._i;
		}

        ///<summary>
        ///Specifies the layer for an object
        ///</summary>
        public string Layer => this._i.Layer;

        /// <summary>
		/// Specifies the layer for an object
		/// </summary>
		/// <param name="Layer">The name of the layer. </param>
        public void Set_Layer(string Layer) 
		{
			this._i.Layer = Layer;
		}

        ///<summary>
        ///Specifies the linetype of an object
        ///</summary>
        public string Linetype => this._i.Linetype;

        /// <summary>
        /// Specifies the linetype of an object
        /// </summary>
        /// <param name="Linetype">The linetype of an object. The default linetype is the linetype of the layer (ByLayer). </param>
        public void Set_Linetype(string Linetype)
		{
			this._i.Linetype = Linetype;
		}

        ///<summary>
        ///Specifies the linetype scale of an object
        ///</summary>
        public double LinetypeScale => this._i.LinetypeScale;

        ///<summary>
        ///Specifies the linetype scale of an object
        ///</summary>
        public void Set_LinetypeScale(double ltScale)
		{
			this._i.LinetypeScale = ltScale;
		}

        ///<summary>
        ///Specifies the visibility of an object or the application
        ///</summary>
        public bool Visible => this._i.Visible;

        ///<summary>
        ///Specifies the visibility of an object or the application
        ///</summary>
        public void Set_Visible(bool bVisible)
		{
			this._i.Visible = bVisible;
		}

        ///<summary>
        ///Creates a polar array of objects given a NumberOfObjects, AngleToFill, and CenterPoint
        ///</summary>
        public List<AcadEntity> ArrayPolar(int NumberOfObjects, double AngleToFill, Point CenterPoint)
		{
            var objects = this._i.ArrayPolar(NumberOfObjects, AngleToFill, Technical.PointByDynPoint(CenterPoint));
			return ((Array)objects).Cast<object>().Select(a => new AcadEntity(a)).ToList();

        }

        ///<summary>
        ///Creates a 2D or 3D rectangular array of objects
        ///</summary>
        public List<AcadEntity> ArrayRectangular(int NumberOfRows, int NumberOfColumns, 
			int NumberOfLevels, double DistBetweenRows, double DistBetweenCols, double DistBetweenLevels)
		{
            var objects = this._i.ArrayRectangular(NumberOfRows, NumberOfColumns, 
				NumberOfLevels, DistBetweenRows, DistBetweenCols, DistBetweenLevels);
            return ((Array)objects).Cast<object>().Select(a => new AcadEntity(a)).ToList();
        }

        ///<summary>
        ///Sets the highlight status for the given object, or for all objects in a given selection set
        ///</summary>
        public void Highlight(bool HighlightFlag)
		{
			this._i.Highlight(HighlightFlag);
		}

        ///<summary>
        ///Duplicates the given object to the same location
        ///</summary>
        public AcadEntity Copy => new AcadEntity(this._i.Copy());

        ///<summary>
        ///Moves an object along a vector
        ///</summary>
        public void Move(Point FromPoint, Point ToPoint)
		{
			this._i.Move(Technical.PointByDynPoint(FromPoint), ToPoint);
		}

        /// <summary>
        /// Rotates an object around a base point
        /// </summary>
        /// <param name="BasePoint">The 3D WCS coordinates specifying the point through which the axis of rotation is defined as parallel to the Z axis of the UCS.</param>
        /// <param name="RotationAngle">The angle in radians to rotate the object. This angle determines how far an object rotates around the base point relative to its current location.</param>
        public void Rotate(Point BasePoint, double RotationAngle)
		{
			this._i.Rotate(Technical.PointByDynPoint(BasePoint), RotationAngle);
		}

        /// <summary>
        /// Rotates an object around a 3D axis. Point1 and Point2 define the line that becomes the axis of rotation
        /// </summary>
        /// <param name="Point1">The 3D WCS coordinates specifying the first point of the axis line</param>
        /// <param name="Point2">The 3D WCS coordinates specifying the second point of the axis line</param>
        /// <param name="RotationAngle">The angle in radians to rotate the object about the selected axis</param>
        public void Rotate3D(Point Point1, Point Point2, double RotationAngle)
		{
			this._i.Rotate3D(Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2), RotationAngle);
		}

        /// <summary>
        /// Creates a mirror-image copy of a planar object around an axis
        /// </summary>
        /// <param name="Point1">The 3D WCS coordinates specifying the first point of the mirror axis</param>
        /// <param name="Point2">The 3D WCS coordinates specifying the second point of the mirror axis</param>
        /// <returns></returns>
        public AcadEntity Mirror(Point Point1, Point Point2)
		{
			return new AcadEntity(this._i.Mirror(Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2)));
		}

        /// <summary>
        /// Creates a mirror image of the given object about a plane
        /// </summary>
        /// <param name="Point1">The 3D WCS coordinates specifying the first point of the mirror plane</param>
        /// <param name="Point2">The 3D WCS coordinates specifying the second point of the mirror plane</param>
        /// <param name="point3">The 3D WCS coordinates specifying the third point of the mirror plane</param>
        /// <returns></returns>
        public AcadEntity Mirror3D(Point Point1, Point Point2, Point point3)
		{
			return new AcadEntity(this._i.Mirror3D(Technical.PointByDynPoint(Point1),
                Technical.PointByDynPoint(Point2), Technical.PointByDynPoint(point3)));
		}

        /// <summary>
        /// Scales an object equally in the X, Y, and Z directions
        /// </summary>
        /// <param name="BasePoint">The 3D WCS coordinates specifying the base point</param>
        /// <param name="ScaleFactor">The factor by which to scale the object. The dimensions of the object are multiplied by the scale factor. A scale factor greater than 1 enlarges the object. A scale factor between 0 and 1 reduces the object. The scale factor must be greater than 0.0</param>
        public void ScaleEntity(Point BasePoint, double ScaleFactor)
		{
			this._i.ScaleEntity(BasePoint, ScaleFactor);
		}

        /// <summary>
        /// Moves, scales, or rotates an object given a 4x4 transformation matrix
        /// </summary>
        /// <param name="TransformationMatrix">A 4x4 (double) matrix specifying the transformation to perform</param>
        public void TransformBy(object TransformationMatrix)
		{
			this._i.TransformBy(TransformationMatrix);
		}

        ///<summary>
        ///Updates the object to the drawing screen
        ///</summary>
        public void Update()
		{
			this._i.Update();
		}

        ///<summary>
        ///Gets two points of a box enclosing the specified object
        ///</summary>
        public List<double[]> GetBoundingBox()
		{
			object MinPoint;
			object MaxPoint;

			this._i.GetBoundingBox(out MinPoint, out MaxPoint);
			List<double[]> ps = new List<double[]>() { (double[])MinPoint, (double[])MaxPoint };
			return ps;

		}

        /// <summary>
		/// Gets the points where one object intersects another object in the drawing
		/// </summary>
		/// <param name="IntersectObject">The object can be one of the supported drawing objects or an AttributeReference</param>
		/// <param name="option">AcExtendOption enum </param>
		/// <returns>The array of points where one object intersects another object in the drawing</returns>
        public object IntersectWith(AcadEntity IntersectObject, Autodesk.AutoCAD.Interop.Common.AcExtendOption option)
		{
			return this._i.IntersectWith(IntersectObject._i, option);
		}

        ///<summary>
        ///Specifies the plot style name for an object, group of objects, or layer
        ///</summary>
        public string PlotStyleName => this._i.PlotStyleName;

        ///<summary>
        ///Specifies the plot style name for an object, group of objects, or layer
        ///</summary>
        public void Set_PlotStyleName(string plotStyle)
		{
			this._i.PlotStyleName = plotStyle;
		}

        ///<summary>
        ///Specifies the lineweight of an individual object or the default lineweight for the drawing
        ///</summary>
        public object Lineweight => this._i.Lineweight;

        ///<summary>
        ///Specifies the lineweight of an individual object or the default lineweight for the drawing
        ///</summary>
        public void Set_Lineweight(object Lineweight)
		{
			this._i.Lineweight = (Autodesk.AutoCAD.Interop.Common.ACAD_LWEIGHT)Lineweight;
		}

        ///<summary>
        ///Specifies the transparency value for the entity
        ///</summary>
        public string EntityTransparency => this._i.EntityTransparency;

        ///<summary>
        ///Specifies the transparency value for the entity
        ///</summary>
        public void Set_EntityTransparency(string transparency)
		{
			this._i.EntityTransparency = transparency;
		}

        ///<summary>
        /// Gets the Hyperlinks collection for an entity
        ///</summary>
        public AcadHyperlinks Hyperlinks => new AcadHyperlinks(this._i.Hyperlinks);

        ///<summary>
        ///Specifies the name of the material
        ///</summary>
        public string Material => this._i.Material;

        ///<summary>
        ///Specifies the name of the material
        ///</summary>
        public void Set_Material(string Material)
		{
			this._i.Material = Material;
		}

		///<summary>
		///
		///</summary>
		public string EntityName => this._i.EntityName;

		///<summary>
		///
		///</summary>
		public int EntityType => this._i.EntityType;

		///<summary>
		///
		///</summary>
		public object color => this._i.color;

		///<summary>
		///
		///</summary>
		public void Set_color(object color)
		{
			this._i.color = (Autodesk.AutoCAD.Interop.Common.ACAD_COLOR)color;
		}
	}
}
