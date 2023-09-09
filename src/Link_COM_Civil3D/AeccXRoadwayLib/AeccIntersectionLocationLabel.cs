namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccIntersectionLocationLabel 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccIntersectionLocationLabel _i;
		internal AeccIntersectionLocationLabel(object AeccIntersectionLocationLabel_object) 
		{
			this._i = AeccIntersectionLocationLabel_object as Autodesk.AECC.Interop.Roadway.IAeccIntersectionLocationLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
