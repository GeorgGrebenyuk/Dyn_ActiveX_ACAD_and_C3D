namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamDouble 
	{
		public AeccXLandLib.IAeccParamDouble _i;
		internal AeccParamDouble(object AeccParamDouble_object) 
		{
			this._i = AeccParamDouble_object as AeccXLandLib.IAeccParamDouble;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(double pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic TypeInfo => this._i.TypeInfo;

		///<summary>
		///
		///</summary>
		public void Set_TypeInfo(AeccXLandLib.AeccTypeInfoDouble pVal) 
		{
			this._i.TypeInfo = pVal;
		}
	}
}
