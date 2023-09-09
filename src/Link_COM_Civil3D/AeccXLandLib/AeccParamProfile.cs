namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamProfile 
	{
		public Autodesk.AECC.Interop.Land.IAeccParamProfile _i;
		internal AeccParamProfile(object AeccParamProfile_object) 
		{
			this._i = AeccParamProfile_object as Autodesk.AECC.Interop.Land.IAeccParamProfile;
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
