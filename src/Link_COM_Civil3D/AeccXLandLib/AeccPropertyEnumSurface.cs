namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSurface 
	{
		public AeccXLandLib.IAeccPropertyEnumSurface _i;
		internal AeccPropertyEnumSurface(object AeccPropertyEnumSurface_object) 
		{
			this._i = AeccPropertyEnumSurface_object as AeccXLandLib.IAeccPropertyEnumSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccSurfaceType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
