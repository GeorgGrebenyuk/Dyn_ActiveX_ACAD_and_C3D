namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumForcedInsertion 
	{
		public AeccXLandLib.IAeccPropertyEnumForcedInsertion _i;
		internal AeccPropertyEnumForcedInsertion(object AeccPropertyEnumForcedInsertion_object) 
		{
			this._i = AeccPropertyEnumForcedInsertion_object as AeccXLandLib.IAeccPropertyEnumForcedInsertion;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccForcedInsertionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
