namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPointNumbersAssigned 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumPointNumbersAssigned _i;
		internal AeccPropertyEnumPointNumbersAssigned(object AeccPropertyEnumPointNumbersAssigned_object) 
		{
			this._i = AeccPropertyEnumPointNumbersAssigned_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumPointNumbersAssigned;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccPointNumbersAssignedType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
