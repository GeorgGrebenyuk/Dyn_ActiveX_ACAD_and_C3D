namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLabelGroupElement 
	{
		public AeccXLandLib.IAeccSectionLabelGroupElement _i;
		internal AeccSectionLabelGroupElement(object AeccSectionLabelGroupElement_object) 
		{
			this._i = AeccSectionLabelGroupElement_object as AeccXLandLib.IAeccSectionLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
