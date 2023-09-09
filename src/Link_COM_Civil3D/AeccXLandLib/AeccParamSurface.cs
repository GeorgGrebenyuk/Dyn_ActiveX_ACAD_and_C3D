namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamSurface 
	{
		public Autodesk.AECC.Interop.Land.IAeccParamSurface _i;
		internal AeccParamSurface(object AeccParamSurface_object) 
		{
			this._i = AeccParamSurface_object as Autodesk.AECC.Interop.Land.IAeccParamSurface;
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
