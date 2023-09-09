namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccIntersection 
	{
		public AeccXRoadwayLib.IAeccIntersection _i;
		internal AeccIntersection(object AeccIntersection_object) 
		{
			this._i = AeccIntersection_object as AeccXRoadwayLib.IAeccIntersection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
