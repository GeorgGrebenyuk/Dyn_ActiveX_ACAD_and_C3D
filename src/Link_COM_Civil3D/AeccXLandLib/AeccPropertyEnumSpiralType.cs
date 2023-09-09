namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumSpiralType 
	{
		public AeccXLandLib.IAeccPropertyEnumSpiralType _i;
		internal AeccPropertyEnumSpiralType(object AeccPropertyEnumSpiralType_object) 
		{
			this._i = AeccPropertyEnumSpiralType_object as AeccXLandLib.IAeccPropertyEnumSpiralType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccAlignmentSpiralType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
