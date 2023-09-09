namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsWeedFeatures 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsWeedFeatures _i;
		internal AeccSettingsWeedFeatures(object AeccSettingsWeedFeatures_object) 
		{
			this._i = AeccSettingsWeedFeatures_object as Autodesk.AECC.Interop.Land.IAeccSettingsWeedFeatures;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic WeedOptions => this._i.WeedOptions;
	}
}
