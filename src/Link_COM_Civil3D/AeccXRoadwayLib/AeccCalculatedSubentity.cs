namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCalculatedSubentity 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCalculatedSubentity _i;
		internal AeccCalculatedSubentity(object AeccCalculatedSubentity_object) 
		{
			this._i = AeccCalculatedSubentity_object as Autodesk.AECC.Interop.Roadway.IAeccCalculatedSubentity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public dynamic CorridorCodes => this._i.CorridorCodes;

		///<summary>
		///
		///</summary>
		public dynamic SubassemblyBelongedTo => this._i.SubassemblyBelongedTo;
	}
}
