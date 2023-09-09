namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMatchLine 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMatchLine _i;
		internal AeccSettingsMatchLine(object AeccSettingsMatchLine_object) 
		{
			this._i = AeccSettingsMatchLine_object as Autodesk.AECC.Interop.Land.IAeccSettingsMatchLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
