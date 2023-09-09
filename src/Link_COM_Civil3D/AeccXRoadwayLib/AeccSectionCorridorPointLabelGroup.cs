namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionCorridorPointLabelGroup 
	{
		public AeccXRoadwayLib.IAeccSectionCorridorPointLabelGroup _i;
		internal AeccSectionCorridorPointLabelGroup(object AeccSectionCorridorPointLabelGroup_object) 
		{
			this._i = AeccSectionCorridorPointLabelGroup_object as AeccXRoadwayLib.IAeccSectionCorridorPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
