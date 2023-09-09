namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumOrientationReference 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumOrientationReference _i;
		internal AeccPropertyEnumOrientationReference(object AeccPropertyEnumOrientationReference_object) 
		{
			this._i = AeccPropertyEnumOrientationReference_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumOrientationReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccOrientationReferenceType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
