namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionCorridorPointLabelGroup 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSectionCorridorPointLabelGroup _i;
		internal AeccSectionCorridorPointLabelGroup(object AeccSectionCorridorPointLabelGroup_object) 
		{
			this._i = AeccSectionCorridorPointLabelGroup_object as Autodesk.AECC.Interop.Roadway.IAeccSectionCorridorPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
