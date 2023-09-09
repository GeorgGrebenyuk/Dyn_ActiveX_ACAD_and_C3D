namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileVerticalConstraint 
	{
		public AeccXLandLib.IAeccPropertyEnumProfileVerticalConstraint _i;
		internal AeccPropertyEnumProfileVerticalConstraint(object AeccPropertyEnumProfileVerticalConstraint_object) 
		{
			this._i = AeccPropertyEnumProfileVerticalConstraint_object as AeccXLandLib.IAeccPropertyEnumProfileVerticalConstraint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccProfileVerticalConstraintType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
