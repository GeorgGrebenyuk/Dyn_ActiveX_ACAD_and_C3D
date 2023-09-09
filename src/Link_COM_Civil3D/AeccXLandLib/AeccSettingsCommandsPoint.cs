namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsPoint 
	{
		public AeccXLandLib.IAeccSettingsCommandsPoint _i;
		internal AeccSettingsCommandsPoint(object AeccSettingsCommandsPoint_object) 
		{
			this._i = AeccSettingsCommandsPoint_object as AeccXLandLib.IAeccSettingsCommandsPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddPointTableSettings => this._i.AddPointTableSettings;

		///<summary>
		///
		///</summary>
		public dynamic AddToProjectSettings => this._i.AddToProjectSettings;

		///<summary>
		///
		///</summary>
		public dynamic ConvertPointsToSdskPointsSettings => this._i.ConvertPointsToSdskPointsSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreatePointGroupSettings => this._i.CreatePointGroupSettings;

		///<summary>
		///
		///</summary>
		public dynamic CreatePointsSettings => this._i.CreatePointsSettings;

		///<summary>
		///
		///</summary>
		public dynamic ShowGeodeticCalculatorSettings => this._i.ShowGeodeticCalculatorSettings;

		///<summary>
		///
		///</summary>
		public dynamic ShowPointGroupPropertiesSettings => this._i.ShowPointGroupPropertiesSettings;
	}
}
