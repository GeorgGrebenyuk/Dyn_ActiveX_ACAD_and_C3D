namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsShowGeodeticCalculator 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsShowGeodeticCalculator _i;
		internal AeccSettingsShowGeodeticCalculator(object AeccSettingsShowGeodeticCalculator_object) 
		{
			this._i = AeccSettingsShowGeodeticCalculator_object as Autodesk.AECC.Interop.Land.IAeccSettingsShowGeodeticCalculator;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
