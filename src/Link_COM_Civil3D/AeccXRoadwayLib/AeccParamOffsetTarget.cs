namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamOffsetTarget 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccParamOffsetTarget _i;
		internal AeccParamOffsetTarget(object AeccParamOffsetTarget_object) 
		{
			this._i = AeccParamOffsetTarget_object as Autodesk.AECC.Interop.Roadway.IAeccParamOffsetTarget;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(dynamic ppVal) 
		{
			this._i.Value = ppVal;
		}
	}
}
