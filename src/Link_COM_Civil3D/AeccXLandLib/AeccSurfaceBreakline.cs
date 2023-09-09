namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceBreakline 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceBreakline _i;
		internal AeccSurfaceBreakline(object AeccSurfaceBreakline_object) 
		{
			this._i = AeccSurfaceBreakline_object as Autodesk.AECC.Interop.Land.IAeccSurfaceBreakline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pVal) 
		{
			this._i.Description = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public object BreaklineEntities => this._i.BreaklineEntities;

		///<summary>
		///
		///</summary>
		public double MidOrdinateDistance => this._i.MidOrdinateDistance;

		///<summary>
		///
		///</summary>
		public object Elevations => this._i.Elevations;

		///<summary>
		///
		///</summary>
		public object Offsets => this._i.Offsets;
	}
}
