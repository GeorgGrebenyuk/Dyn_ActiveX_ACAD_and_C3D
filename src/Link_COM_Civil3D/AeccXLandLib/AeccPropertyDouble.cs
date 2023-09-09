namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyDouble 
	{
		public AeccXLandLib.IAeccPropertyDouble _i;
		internal AeccPropertyDouble(object AeccPropertyDouble_object) 
		{
			this._i = AeccPropertyDouble_object as AeccXLandLib.IAeccPropertyDouble;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(double pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Value => this._i.Value;
	}
}
