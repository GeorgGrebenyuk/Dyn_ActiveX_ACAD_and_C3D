namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAddContourLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsAddContourLabeling _i;
		internal AeccSettingsAddContourLabeling(object AeccSettingsAddContourLabeling_object) 
		{
			this._i = AeccSettingsAddContourLabeling_object as Autodesk.AECC.Interop.Land.IAeccSettingsAddContourLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
