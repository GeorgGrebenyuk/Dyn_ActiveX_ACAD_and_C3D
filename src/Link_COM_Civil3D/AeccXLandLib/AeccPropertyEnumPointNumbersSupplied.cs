namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPointNumbersSupplied 
	{
		public AeccXLandLib.IAeccPropertyEnumPointNumbersSupplied _i;
		internal AeccPropertyEnumPointNumbersSupplied(object AeccPropertyEnumPointNumbersSupplied_object) 
		{
			this._i = AeccPropertyEnumPointNumbersSupplied_object as AeccXLandLib.IAeccPropertyEnumPointNumbersSupplied;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccPointNumbersSuppliedType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
