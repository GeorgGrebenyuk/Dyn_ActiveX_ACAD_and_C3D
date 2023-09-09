namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsShowGeodeticCalculator 
	{
		public AeccXLandLib.IAeccSettingsShowGeodeticCalculator _i;
		internal AeccSettingsShowGeodeticCalculator(object AeccSettingsShowGeodeticCalculator_object) 
		{
			this._i = AeccSettingsShowGeodeticCalculator_object as AeccXLandLib.IAeccSettingsShowGeodeticCalculator;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
