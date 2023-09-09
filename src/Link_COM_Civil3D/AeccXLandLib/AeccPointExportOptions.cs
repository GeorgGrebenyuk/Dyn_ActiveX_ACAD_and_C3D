namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointExportOptions 
	{
		public Autodesk.AECC.Interop.Land.IAeccPointExportOptions _i;
		internal AeccPointExportOptions(object AeccPointExportOptions_object) 
		{
			this._i = AeccPointExportOptions_object as Autodesk.AECC.Interop.Land.IAeccPointExportOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_UsePointGroup(bool UsePointGroup) 
		{
			this._i.UsePointGroup = UsePointGroup;
		}

		///<summary>
		///
		///</summary>
		public bool UsePointGroup => this._i.UsePointGroup;

		///<summary>
		///
		///</summary>
		public void Set_PointGroup(string PointGroup) 
		{
			this._i.PointGroup = PointGroup;
		}

		///<summary>
		///
		///</summary>
		public string PointGroup => this._i.PointGroup;
	}
}
