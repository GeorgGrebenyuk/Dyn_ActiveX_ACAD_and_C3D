namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsMultiSectionViewCreation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsMultiSectionViewCreation _i;
		internal AeccSettingsMultiSectionViewCreation(object AeccSettingsMultiSectionViewCreation_object) 
		{
			this._i = AeccSettingsMultiSectionViewCreation_object as Autodesk.AECC.Interop.Land.IAeccSettingsMultiSectionViewCreation;
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
