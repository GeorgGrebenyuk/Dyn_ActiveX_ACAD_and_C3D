namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridCreationData 
	{
		public AeccXLandLib.IAeccGridCreationData _i;
		internal AeccGridCreationData(object AeccGridCreationData_object) 
		{
			this._i = AeccGridCreationData_object as AeccXLandLib.IAeccGridCreationData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double XSpacing => this._i.XSpacing;

		///<summary>
		///
		///</summary>
		public void Set_XSpacing(double pVal) 
		{
			this._i.XSpacing = pVal;
		}

		///<summary>
		///
		///</summary>
		public double YSpacing => this._i.YSpacing;

		///<summary>
		///
		///</summary>
		public void Set_YSpacing(double pVal) 
		{
			this._i.YSpacing = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Orientation => this._i.Orientation;

		///<summary>
		///
		///</summary>
		public void Set_Orientation(double pVal) 
		{
			this._i.Orientation = pVal;
		}
	}
}
