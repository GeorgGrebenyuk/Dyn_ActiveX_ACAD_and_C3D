namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPointNumbersSupplied 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumPointNumbersSupplied _i;
		internal AeccPropertyEnumPointNumbersSupplied(object AeccPropertyEnumPointNumbersSupplied_object) 
		{
			this._i = AeccPropertyEnumPointNumbersSupplied_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumPointNumbersSupplied;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccPointNumbersSuppliedType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
