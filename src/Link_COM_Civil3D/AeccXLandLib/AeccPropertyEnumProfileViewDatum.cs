namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewDatum 
	{
		public AeccXLandLib.IAeccPropertyEnumProfileViewDatum _i;
		internal AeccPropertyEnumProfileViewDatum(object AeccPropertyEnumProfileViewDatum_object) 
		{
			this._i = AeccPropertyEnumProfileViewDatum_object as AeccXLandLib.IAeccPropertyEnumProfileViewDatum;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccProfileViewDatumType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
