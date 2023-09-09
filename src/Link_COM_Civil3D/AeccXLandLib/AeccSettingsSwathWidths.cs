namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSwathWidths 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSwathWidths _i;
		internal AeccSettingsSwathWidths(object AeccSettingsSwathWidths_object) 
		{
			this._i = AeccSettingsSwathWidths_object as Autodesk.AECC.Interop.Land.IAeccSettingsSwathWidths;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LeftWidth => this._i.LeftWidth;

		///<summary>
		///
		///</summary>
		public dynamic RightWidth => this._i.RightWidth;
	}
}
