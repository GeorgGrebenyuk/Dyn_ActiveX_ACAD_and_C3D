namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceBoundary 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceBoundary _i;
		internal AeccSurfaceBoundary(object AeccSurfaceBoundary_object) 
		{
			this._i = AeccSurfaceBoundary_object as Autodesk.AECC.Interop.Land.IAeccSurfaceBoundary;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public bool Nondestructive => this._i.Nondestructive;

		///<summary>
		///
		///</summary>
		public dynamic BoundaryEntity => this._i.BoundaryEntity;

		///<summary>
		///
		///</summary>
		public double MidOrdinateDistance => this._i.MidOrdinateDistance;
	}
}
