namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionCorridorPointLabelGroupElement 
	{
		public AeccXRoadwayLib.IAeccSectionCorridorPointLabelGroupElement _i;
		internal AeccSectionCorridorPointLabelGroupElement(object AeccSectionCorridorPointLabelGroupElement_object) 
		{
			this._i = AeccSectionCorridorPointLabelGroupElement_object as AeccXRoadwayLib.IAeccSectionCorridorPointLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
