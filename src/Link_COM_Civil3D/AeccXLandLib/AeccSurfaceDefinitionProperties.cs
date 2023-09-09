namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceDefinitionProperties 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceDefinitionProperties _i;
		internal AeccSurfaceDefinitionProperties(object AeccSurfaceDefinitionProperties_object) 
		{
			this._i = AeccSurfaceDefinitionProperties_object as Autodesk.AECC.Interop.Land.IAeccSurfaceDefinitionProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool CopyDeletedDependentObjects => this._i.CopyDeletedDependentObjects;

		///<summary>
		///
		///</summary>
		public void Set_CopyDeletedDependentObjects(bool pVal) 
		{
			this._i.CopyDeletedDependentObjects = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ExcludeElevationsLessThan => this._i.ExcludeElevationsLessThan;

		///<summary>
		///
		///</summary>
		public void Set_ExcludeElevationsLessThan(bool pVal) 
		{
			this._i.ExcludeElevationsLessThan = pVal;
		}

		///<summary>
		///
		///</summary>
		public double LowerElevation => this._i.LowerElevation;

		///<summary>
		///
		///</summary>
		public void Set_LowerElevation(double pVal) 
		{
			this._i.LowerElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ExcludeElevationsGreaterThan => this._i.ExcludeElevationsGreaterThan;

		///<summary>
		///
		///</summary>
		public void Set_ExcludeElevationsGreaterThan(bool pVal) 
		{
			this._i.ExcludeElevationsGreaterThan = pVal;
		}

		///<summary>
		///
		///</summary>
		public double UpperElevation => this._i.UpperElevation;

		///<summary>
		///
		///</summary>
		public void Set_UpperElevation(double pVal) 
		{
			this._i.UpperElevation = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseBoundaries => this._i.UseBoundaries;

		///<summary>
		///
		///</summary>
		public void Set_UseBoundaries(bool pVal) 
		{
			this._i.UseBoundaries = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseAddPoint => this._i.UseAddPoint;

		///<summary>
		///
		///</summary>
		public void Set_UseAddPoint(bool pVal) 
		{
			this._i.UseAddPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseDeletePoint => this._i.UseDeletePoint;

		///<summary>
		///
		///</summary>
		public void Set_UseDeletePoint(bool pVal) 
		{
			this._i.UseDeletePoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseModifyPoint => this._i.UseModifyPoint;

		///<summary>
		///
		///</summary>
		public void Set_UseModifyPoint(bool pVal) 
		{
			this._i.UseModifyPoint = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseDeleteLine => this._i.UseDeleteLine;

		///<summary>
		///
		///</summary>
		public void Set_UseDeleteLine(bool pVal) 
		{
			this._i.UseDeleteLine = pVal;
		}
	}
}
