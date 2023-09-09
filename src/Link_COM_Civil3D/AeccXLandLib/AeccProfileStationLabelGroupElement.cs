namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileStationLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileStationLabelGroupElement _i;
		internal AeccProfileStationLabelGroupElement(object AeccProfileStationLabelGroupElement_object) 
		{
			this._i = AeccProfileStationLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccProfileStationLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
