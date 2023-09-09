namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionCorridorPointLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccSectionCorridorPointLabelGroupElement _i;
		internal AeccSectionCorridorPointLabelGroupElement(object AeccSectionCorridorPointLabelGroupElement_object) 
		{
			this._i = AeccSectionCorridorPointLabelGroupElement_object as Autodesk.AECC.Interop.Roadway.IAeccSectionCorridorPointLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
