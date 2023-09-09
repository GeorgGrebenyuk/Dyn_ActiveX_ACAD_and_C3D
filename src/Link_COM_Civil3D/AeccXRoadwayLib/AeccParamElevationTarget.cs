namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamElevationTarget 
	{
		public AeccXRoadwayLib.IAeccParamElevationTarget _i;
		internal AeccParamElevationTarget(object AeccParamElevationTarget_object) 
		{
			this._i = AeccParamElevationTarget_object as AeccXRoadwayLib.IAeccParamElevationTarget;
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
