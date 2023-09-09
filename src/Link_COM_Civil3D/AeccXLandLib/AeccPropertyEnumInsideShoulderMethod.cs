namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumInsideShoulderMethod 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumInsideShoulderMethod _i;
		internal AeccPropertyEnumInsideShoulderMethod(object AeccPropertyEnumInsideShoulderMethod_object) 
		{
			this._i = AeccPropertyEnumInsideShoulderMethod_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumInsideShoulderMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccInsideShoulderMethodType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
