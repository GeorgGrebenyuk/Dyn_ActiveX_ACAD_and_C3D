namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsMassHaulView 
	{
		public AeccXLandLib.IAeccSettingsCommandsMassHaulView _i;
		internal AeccSettingsCommandsMassHaulView(object AeccSettingsCommandsMassHaulView_object) 
		{
			this._i = AeccSettingsCommandsMassHaulView_object as AeccXLandLib.IAeccSettingsCommandsMassHaulView;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreateMassHaulDiagramSettings => this._i.CreateMassHaulDiagramSettings;
	}
}
