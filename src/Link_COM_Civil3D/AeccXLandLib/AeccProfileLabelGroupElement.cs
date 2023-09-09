namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLabelGroupElement 
	{
		public AeccXLandLib.IAeccProfileLabelGroupElement _i;
		internal AeccProfileLabelGroupElement(object AeccProfileLabelGroupElement_object) 
		{
			this._i = AeccProfileLabelGroupElement_object as AeccXLandLib.IAeccProfileLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
