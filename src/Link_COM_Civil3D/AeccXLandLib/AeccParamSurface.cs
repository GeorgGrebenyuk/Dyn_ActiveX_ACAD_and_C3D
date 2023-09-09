namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamSurface 
	{
		public AeccXLandLib.IAeccParamSurface _i;
		internal AeccParamSurface(object AeccParamSurface_object) 
		{
			this._i = AeccParamSurface_object as AeccXLandLib.IAeccParamSurface;
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
