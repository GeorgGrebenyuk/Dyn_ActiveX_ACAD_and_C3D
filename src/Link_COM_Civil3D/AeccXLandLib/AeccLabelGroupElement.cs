namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGroupElement 
	{
		public AeccXLandLib.IAeccLabelGroupElement _i;
		internal AeccLabelGroupElement(object AeccLabelGroupElement_object) 
		{
			this._i = AeccLabelGroupElement_object as AeccXLandLib.IAeccLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
