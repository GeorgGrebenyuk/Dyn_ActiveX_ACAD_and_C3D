﻿namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class Acad3DSolid 
	{
		public AXDBLib.IAcad3DSolid _i;
		internal Acad3DSolid(object Acad3DSolid_object) 
		{
			this._i = Acad3DSolid_object as AXDBLib.IAcad3DSolid;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object Centroid => this._i.Centroid;

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
		public void Boolean(AXDBLib.AcBoolean Operation,dynamic SolidObject) 
		{
			this._i.Boolean(Operation,SolidObject);
		}

		///<summary>
		///
		///</summary>
		public dynamic CheckInterference(dynamic Object,bool CreateInterferenceSolid,out bool SolidsInterfere) 
		{
			return this._i.CheckInterference(Object,CreateInterferenceSolid,out SolidsInterfere);
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
