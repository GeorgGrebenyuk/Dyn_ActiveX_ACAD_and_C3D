namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccIntersection 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccIntersection _i;
		internal AeccIntersection(object AeccIntersection_object) 
		{
			this._i = AeccIntersection_object as Autodesk.AECC.Interop.Roadway.IAeccIntersection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
