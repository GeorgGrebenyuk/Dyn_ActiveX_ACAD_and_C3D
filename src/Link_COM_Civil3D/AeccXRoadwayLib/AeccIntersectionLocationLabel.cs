namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccIntersectionLocationLabel 
	{
		public AeccXRoadwayLib.IAeccIntersectionLocationLabel _i;
		internal AeccIntersectionLocationLabel(object AeccIntersectionLocationLabel_object) 
		{
			this._i = AeccIntersectionLocationLabel_object as AeccXRoadwayLib.IAeccIntersectionLocationLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
