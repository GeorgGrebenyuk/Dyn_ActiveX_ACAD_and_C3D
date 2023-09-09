namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewDatum 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewDatum _i;
		internal AeccPropertyEnumProfileViewDatum(object AeccPropertyEnumProfileViewDatum_object) 
		{
			this._i = AeccPropertyEnumProfileViewDatum_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewDatum;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccProfileViewDatumType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
