namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMatchLine 
	{
		public AeccXLandLib.IAeccSettingsMatchLine _i;
		internal AeccSettingsMatchLine(object AeccSettingsMatchLine_object) 
		{
			this._i = AeccSettingsMatchLine_object as AeccXLandLib.IAeccSettingsMatchLine;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AmbientSettings => this._i.AmbientSettings;
	}
}
