namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumDirection 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumDirection _i;
		internal AeccPropertyEnumDirection(object AeccPropertyEnumDirection_object) 
		{
			this._i = AeccPropertyEnumDirection_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumDirection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccDirectionType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
