namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumForcedInsertion 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumForcedInsertion _i;
		internal AeccPropertyEnumForcedInsertion(object AeccPropertyEnumForcedInsertion_object) 
		{
			this._i = AeccPropertyEnumForcedInsertion_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumForcedInsertion;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccForcedInsertionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
