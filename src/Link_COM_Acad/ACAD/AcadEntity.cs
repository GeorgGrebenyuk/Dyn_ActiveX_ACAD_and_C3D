using Autodesk.DesignScript.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadEntity 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadEntity _i;
        
        internal AcadEntity(object AcadEntity_object, int i = 0) 
		{
			this._i = AcadEntity_object as Autodesk.AutoCAD.Interop.Common.AcadEntity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
        /// <summary>
        /// Cast to AcadEntity from any object
        /// </summary>
        /// <param name="AnyModelObject"></param>
        public static AcadEntity CastFromAnyObject (dynamic AnyModelObject)
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
			foreach (var e in acadDocument._i.ActiveSelectionSet)
			{
				es.Add(new AcadEntity(e));
			}

            return es;
        }

        ///<summary>
        ///
        ///</summary>
        public object TrueColor => this._i.TrueColor;

		///<summary>
		///
		///</summary>
		public void Set_TrueColor(object pColor) 
		{
			this._i.TrueColor =(Autodesk.AutoCAD.Interop.Common.AcadAcCmColor)pColor;
		}

		///<summary>
		///
		///</summary>
		public string Layer => this._i.Layer;

		///<summary>
		///
		///</summary>
		public void Set_Layer(string Layer) 
		{
			this._i.Layer = Layer;
		}

		///<summary>
		///
		///</summary>
		public string Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public void Set_Linetype(string Linetype)
		{
			this._i.Linetype = Linetype;
		}

		///<summary>
		///
		///</summary>
		public double LinetypeScale => this._i.LinetypeScale;

		///<summary>
		///
		///</summary>
		public void Set_LinetypeScale(double ltScale)
		{
			this._i.LinetypeScale = ltScale;
		}

		///<summary>
		///
		///</summary>
		public bool Visible => this._i.Visible;

		///<summary>
		///
		///</summary>
		public void Set_Visible(bool bVisible)
		{
			this._i.Visible = bVisible;
		}

		///<summary>
		///
		///</summary>
		public List<AcadEntity> ArrayPolar(int NumberOfObjects, double AngleToFill, Point CenterPoint)
		{
            var objects = this._i.ArrayPolar(NumberOfObjects, AngleToFill, Technical.PointByDynPoint(CenterPoint));
			return ((Array)objects).Cast<object>().Select(a => new AcadEntity(a)).ToList();

        }

		///<summary>
		///
		///</summary>
		public List<AcadEntity> ArrayRectangular(int NumberOfRows, int NumberOfColumns, 
			int NumberOfLevels, double DistBetweenRows, double DistBetweenCols, double DistBetweenLevels)
		{
            var objects = this._i.ArrayRectangular(NumberOfRows, NumberOfColumns, 
				NumberOfLevels, DistBetweenRows, DistBetweenCols, DistBetweenLevels);
            return ((Array)objects).Cast<object>().Select(a => new AcadEntity(a)).ToList();
        }

		///<summary>
		///
		///</summary>
		public void Highlight(bool HighlightFlag)
		{
			this._i.Highlight(HighlightFlag);
		}

		///<summary>
		///
		///</summary>
		public AcadEntity Copy => new AcadEntity(this._i.Copy());

		///<summary>
		///
		///</summary>
		public void Move(Point FromPoint, Point ToPoint)
		{
			this._i.Move(Technical.PointByDynPoint(FromPoint), ToPoint);
		}

		///<summary>
		///
		///</summary>
		public void Rotate(Point BasePoint, double RotationAngle)
		{
			this._i.Rotate(Technical.PointByDynPoint(BasePoint), RotationAngle);
		}

		///<summary>
		///
		///</summary>
		public void Rotate3D(Point Point1, Point Point2, double RotationAngle)
		{
			this._i.Rotate3D(Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2), RotationAngle);
		}

		///<summary>
		///
		///</summary>
		public AcadEntity Mirror(Point Point1, Point Point2)
		{
			return new AcadEntity(this._i.Mirror(Technical.PointByDynPoint(Point1), Technical.PointByDynPoint(Point2)));
		}

		///<summary>
		///
		///</summary>
		public AcadEntity Mirror3D(Point Point1, Point Point2, Point point3)
		{
			return new AcadEntity(this._i.Mirror3D(Technical.PointByDynPoint(Point1),
                Technical.PointByDynPoint(Point2), Technical.PointByDynPoint(point3)));
		}

		///<summary>
		///
		///</summary>
		public void ScaleEntity(Point BasePoint, double ScaleFactor)
		{
			this._i.ScaleEntity(BasePoint, ScaleFactor);
		}

		///<summary>
		///
		///</summary>
		public void TransformBy(object TransformationMatrix)
		{
			this._i.TransformBy(TransformationMatrix);
		}

		///<summary>
		///
		///</summary>
		public void Update()
		{
			this._i.Update();
		}

		///<summary>
		///
		///</summary>
		public List<double[]> GetBoundingBox()
		{
			object MinPoint;
			object MaxPoint;

			this._i.GetBoundingBox(out MinPoint, out MaxPoint);
			List<double[]> ps = new List<double[]>() { (double[])MinPoint, (double[])MaxPoint };
			return ps;

		}

		///<summary>
		///
		///</summary>
		public object IntersectWith(AcadEntity IntersectObject, Autodesk.AutoCAD.Interop.Common.AcExtendOption option)
		{
			return this._i.IntersectWith(IntersectObject._i, option);
		}

		///<summary>
		///
		///</summary>
		public string PlotStyleName => this._i.PlotStyleName;

		///<summary>
		///
		///</summary>
		public void Set_PlotStyleName(string plotStyle)
		{
			this._i.PlotStyleName = plotStyle;
		}

		///<summary>
		///
		///</summary>
		public object Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public void Set_Lineweight(object Lineweight)
		{
			this._i.Lineweight = (Autodesk.AutoCAD.Interop.Common.ACAD_LWEIGHT)Lineweight;
		}

		///<summary>
		///
		///</summary>
		public string EntityTransparency => this._i.EntityTransparency;

		///<summary>
		///
		///</summary>
		public void Set_EntityTransparency(string transparency)
		{
			this._i.EntityTransparency = transparency;
		}

		///<summary>
		///
		///</summary>
		public AcadHyperlinks Hyperlinks => new AcadHyperlinks(this._i.Hyperlinks);

		///<summary>
		///
		///</summary>
		public string Material => this._i.Material;

		///<summary>
		///
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
