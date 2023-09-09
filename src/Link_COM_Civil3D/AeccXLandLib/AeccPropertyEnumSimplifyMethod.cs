namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSimplifyMethod 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumSimplifyMethod _i;
		internal AeccPropertyEnumSimplifyMethod(object AeccPropertyEnumSimplifyMethod_object) 
		{
			this._i = AeccPropertyEnumSimplifyMethod_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumSimplifyMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccSimplifySurfaceMethodType pValue) 
		{
			this._i.Value = pValue;
		}
	}
}
