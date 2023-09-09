namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateFeatureLines 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateFeatureLines _i;
		internal AeccSettingsCreateFeatureLines(object AeccSettingsCreateFeatureLines_object) 
		{
			this._i = AeccSettingsCreateFeatureLines_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateFeatureLines;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCreation => this._i.FeatureLineCreation;
	}
}
