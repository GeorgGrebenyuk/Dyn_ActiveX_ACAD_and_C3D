namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileStationLabelGroupElement 
	{
		public AeccXLandLib.IAeccProfileStationLabelGroupElement _i;
		internal AeccProfileStationLabelGroupElement(object AeccProfileStationLabelGroupElement_object) 
		{
			this._i = AeccProfileStationLabelGroupElement_object as AeccXLandLib.IAeccProfileStationLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
