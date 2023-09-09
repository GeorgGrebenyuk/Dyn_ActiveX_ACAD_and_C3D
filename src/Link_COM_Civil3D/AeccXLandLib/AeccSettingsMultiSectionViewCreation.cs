namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMultiSectionViewCreation 
	{
		public AeccXLandLib.IAeccSettingsMultiSectionViewCreation _i;
		internal AeccSettingsMultiSectionViewCreation(object AeccSettingsMultiSectionViewCreation_object) 
		{
			this._i = AeccSettingsMultiSectionViewCreation_object as AeccXLandLib.IAeccSettingsMultiSectionViewCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpecifyStationRange => this._i.SpecifyStationRange;

		///<summary>
		///
		///</summary>
		public dynamic DefaultHeight => this._i.DefaultHeight;
	}
}
