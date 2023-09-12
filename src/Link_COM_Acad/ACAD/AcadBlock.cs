using System.CodeDom;
using System.Collections.Generic;
using dg = Autodesk.DesignScript.Geometry;

namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadBlock 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadBlock _i;
		internal AcadBlock(object AcadBlock_object) 
		{
			this._i = AcadBlock_object as Autodesk.AutoCAD.Interop.Common.AcadBlock;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public AcadEntity Item(object Index) 
		{
			return new AcadEntity( this._i.Item(Index));
		}
		public List<AcadEntity> GetAll()
		{
			List<AcadEntity> es = new List<AcadEntity>();
			foreach (var ent in this._i)
			{
				es.Add(new AcadEntity(ent));
			}
			return es;
		}
		///<summary>
		///
		///</summary>
		public int Count => this._i.Count;

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
		public object Origin => this._i.Origin;

		///<summary>
		///
		///</summary>
		public void Set_Origin(object Origin) 
		{
			this._i.Origin = Origin;
		}

		///<summary>
		///
		///</summary>
		public AcadEntity AddCustomObject(string ClassName) 
		{
			return new AcadEntity(this._i.AddCustomObject(ClassName));
		}

		///<summary>
		///
		///</summary>
		public dynamic AddAttribute(double Height, Autodesk.AutoCAD.Interop.Common.AcAttributeMode Mode, string Prompt, object InsertionPoint, string Tag, string Value)
		{
			return this._i.AddAttribute(Height, Mode, Prompt, InsertionPoint, Tag, Value);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddDimAligned(object ExtLine1Point, object ExtLine2Point, object TextPosition)
		{
			return this._i.AddDimAligned(ExtLine1Point, ExtLine2Point, TextPosition);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddDimAngular(object AngleVertex, object FirstEndPoint, object SecondEndPoint, object TextPoint)
		{
			return this._i.AddDimAngular(AngleVertex, FirstEndPoint, SecondEndPoint, TextPoint);
		}
		//
		///<summary>
		///
		///</summary>
		public dynamic AddDimDiametric(object ChordPoint, object FarChordPoint, double LeaderLength)
		{
			return this._i.AddDimDiametric(ChordPoint, FarChordPoint, LeaderLength);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddDimRotated(object ExtLine1Point, object ExtLine2Point, object DimLineLocation, double RotationAngle)
		{
			return this._i.AddDimRotated(ExtLine1Point, ExtLine2Point, DimLineLocation, RotationAngle);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddDimOrdinate(object DefinitionPoint, object LeaderEndPoint, int UseXAxis)
		{
			return this._i.AddDimOrdinate(DefinitionPoint, LeaderEndPoint, UseXAxis);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddDimRadial(object Center, object ChordPoint, double LeaderLength)
		{
			return this._i.AddDimRadial(Center, ChordPoint, LeaderLength);
		}

		

		///<summary>
		///
		///</summary>
		public dynamic AddEllipticalCone(object Center, double MajorRadius, double MinorRadius, double Height)
		{
			return this._i.AddEllipticalCone(Center, MajorRadius, MinorRadius, Height);
		}

		//
		///<summary>
		///
		///</summary>
		public dynamic AddEllipticalCylinder(object Center, double MajorRadius, double MinorRadius, double Height)
		{
			return this._i.AddEllipticalCylinder(Center, MajorRadius, MinorRadius, Height);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddExtrudedSolid(dynamic Profile, double Height, double TaperAngle)
		{
			return this._i.AddExtrudedSolid(Profile, Height, TaperAngle);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddExtrudedSolidAlongPath(dynamic Profile, dynamic Path)
		{
			return this._i.AddExtrudedSolidAlongPath(Profile, Path);
		}



		///<summary>
		///
		///</summary>
		public dynamic AddRay(object Point1, object Point2)
		{
			return this._i.AddRay(Point1, Point2);
		}

		///<summary>
		///
		///</summary>
		public object AddRegion(object ObjectList)
		{
			return this._i.AddRegion(ObjectList);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddRevolvedSolid(dynamic Profile, object AxisPoint, object AxisDir, double Angle)
		{
			return this._i.AddRevolvedSolid(Profile, AxisPoint, AxisDir, Angle);
		}

		

		


		///<summary>
		///
		///</summary>
		public dynamic AddTolerance(string Text, object InsertionPoint, object Direction)
		{
			return this._i.AddTolerance(Text, InsertionPoint, Direction);
		}

		

		///<summary>
		///
		///</summary>
		public dynamic AddTrace(object PointsArray)
		{
			return this._i.AddTrace(PointsArray);
		}

		

		///<summary>
		///
		///</summary>
		public dynamic AddXline(object Point1, object Point2)
		{
			return this._i.AddXline(Point1, Point2);
		}

		



		

		///<summary>
		///
		///</summary>
		public bool IsLayout => this._i.IsLayout;

		///<summary>
		///
		///</summary>
		public dynamic Layout => this._i.Layout;

		///<summary>
		///
		///</summary>
		public bool IsXRef => this._i.IsXRef;

		/////<summary>
		/////
		/////</summary>
		//public dynamic AddMInsertBlock(object InsertionPoint, string Name, double Xscale, double Yscale, double Zscale, double Rotation, dynamic NumRows, dynamic NumColumns, dynamic RowSpacing, dynamic ColumnSpacing, object Password)
		//{
		//	return this._i.AddMInsertBlock(InsertionPoint, Name, Xscale, Yscale, Zscale, Rotation, NumRows, NumColumns, RowSpacing, ColumnSpacing, Password);
		//}

		

		///<summary>
		///
		///</summary>
		public dynamic AddMLine(object VertexList)
		{
			return this._i.AddMLine(VertexList);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddDim3PointAngular(object AngleVertex, object FirstEndPoint, object SecondEndPoint, object TextPoint)
		{
			return this._i.AddDim3PointAngular(AngleVertex, FirstEndPoint, SecondEndPoint, TextPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic XRefDatabase => this._i.XRefDatabase;

		/////<summary>
		/////
		/////</summary>
		//public dynamic AttachExternalReference(string PathName, string Name, object InsertionPoint, double Xscale, double Yscale, double Zscale, double Rotation, bool bOverlay, object Password)
		//{
		//	return this._i.AttachExternalReference(PathName, Name, InsertionPoint, Xscale, Yscale, Zscale, Rotation, bOverlay, Password);
		//}

		///<summary>
		///
		///</summary>
		public void Unload()
		{
			this._i.Unload();
		}

		///<summary>
		///
		///</summary>
		public void Reload()
		{
			this._i.Reload();
		}

		///<summary>
		///
		///</summary>
		public void Bind(bool bPrefixName)
		{
			this._i.Bind(bPrefixName);
		}

		///<summary>
		///
		///</summary>
		public void Detach()
		{
			this._i.Detach();
		}

		///<summary>
		///
		///</summary>
		public dynamic AddTable(object InsertionPoint, int NumRows, int NumColumns, double RowHeight, double ColWidth)
		{
			return this._i.AddTable(InsertionPoint, NumRows, NumColumns, RowHeight, ColWidth);
		}

		///<summary>
		///
		///</summary>
		public string Path => this._i.Path;

		///<summary>
		///
		///</summary>
		public void Set_Path(string bstrName)
		{
			this._i.Path = bstrName;
		}

		///<summary>
		///
		///</summary>
		public string Comments => this._i.Comments;

		///<summary>
		///
		///</summary>
		public void Set_Comments(string bstrName)
		{
			this._i.Comments = bstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic Units => this._i.Units;

		///<summary>
		///
		///</summary>
		public void Set_Units(Autodesk.AutoCAD.Interop.Common.AcInsertUnits pIU)
		{
			this._i.Units = pIU;
		}

		///<summary>
		///
		///</summary>
		public bool Explodable => this._i.Explodable;

		///<summary>
		///
		///</summary>
		public void Set_Explodable(bool bExplodable)
		{
			this._i.Explodable = bExplodable;
		}

		///<summary>
		///
		///</summary>
		public dynamic BlockScaling => this._i.BlockScaling;

		///<summary>
		///
		///</summary>
		public void Set_BlockScaling(Autodesk.AutoCAD.Interop.Common.AcBlockScaling pBS)
		{
			this._i.BlockScaling = pBS;
		}

		///<summary>
		///
		///</summary>
		public bool IsDynamicBlock => this._i.IsDynamicBlock;

		///<summary>
		///
		///</summary>
		public dynamic AddDimArc(object ArcCenter, object FirstEndPoint, object SecondEndPoint, object ArcPoint)
		{
			return this._i.AddDimArc(ArcCenter, FirstEndPoint, SecondEndPoint, ArcPoint);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddDimRadialLarge(object Center, object ChordPoint, object OverrideCenter, object JogPoint, double JogAngle)
		{
			return this._i.AddDimRadialLarge(Center, ChordPoint, OverrideCenter, JogPoint, JogAngle);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddSection(object FromPoint, object ToPoint, object planeVector)
		{
			return this._i.AddSection(FromPoint, ToPoint, planeVector);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddMLeader(object PointsArray)
		{
			int leaderLineIndex;
			var data = this._i.AddMLeader(PointsArray, out leaderLineIndex);
			return data;
		}
	}
}
