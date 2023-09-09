namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateSampleLines 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateSampleLines _i;
		internal AeccSettingsCreateSampleLines(object AeccSettingsCreateSampleLines_object) 
		{
			this._i = AeccSettingsCreateSampleLines_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateSampleLines;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SwathWidthsSettings => this._i.SwathWidthsSettings;

		///<summary>
		///
		///</summary>
		public dynamic IncrementsSettings => this._i.IncrementsSettings;

		///<summary>
		///
		///</summary>
		public dynamic AdditionalControlsSettings => this._i.AdditionalControlsSettings;

		///<summary>
		///
		///</summary>
		public dynamic LockStation => this._i.LockStation;
	}
}
