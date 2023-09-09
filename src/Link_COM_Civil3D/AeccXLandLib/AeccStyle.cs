namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccStyle _i;
		internal AeccStyle(object AeccStyle_object) 
		{
			this._i = AeccStyle_object as Autodesk.AECC.Interop.Land.IAeccStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string CreatedBy => this._i.CreatedBy;

		///<summary>
		///
		///</summary>
		public void Set_CreatedBy(string pVal) 
		{
			this._i.CreatedBy = pVal;
		}

		///<summary>
		///
		///</summary>
		public string ModifiedBy => this._i.ModifiedBy;

		///<summary>
		///
		///</summary>
		public string DateCreated => this._i.DateCreated;

		///<summary>
		///
		///</summary>
		public string DateModified => this._i.DateModified;

		///<summary>
		///
		///</summary>
		public void ExportTo(object destDb,Autodesk.AECC.Interop.Land.AeccStyleExportConflictResolutionMethod conflictResolution) 
		{
			this._i.ExportTo(destDb,conflictResolution);
		}
	}
}
