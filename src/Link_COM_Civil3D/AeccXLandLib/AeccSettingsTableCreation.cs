namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsTableCreation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsTableCreation _i;
		internal AeccSettingsTableCreation(object AeccSettingsTableCreation_object) 
		{
			this._i = AeccSettingsTableCreation_object as Autodesk.AECC.Interop.Land.IAeccSettingsTableCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public dynamic SplitTable => this._i.SplitTable;

		///<summary>
		///
		///</summary>
		public dynamic MaxRows => this._i.MaxRows;

		///<summary>
		///
		///</summary>
		public dynamic MaxTableStackSize => this._i.MaxTableStackSize;

		///<summary>
		///
		///</summary>
		public dynamic TableSpacing => this._i.TableSpacing;

		///<summary>
		///
		///</summary>
		public dynamic TitleDirection => this._i.TitleDirection;
	}
}
