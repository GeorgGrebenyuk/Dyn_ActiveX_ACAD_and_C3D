namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccOffsetElevationLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccOffsetElevationLabel _i;
		internal AeccOffsetElevationLabel(object AeccOffsetElevationLabel_object) 
		{
			this._i = AeccOffsetElevationLabel_object as Autodesk.AECC.Interop.Land.IAeccOffsetElevationLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Section1 => this._i.Section1;

		///<summary>
		///
		///</summary>
		public void Set_Section1(dynamic pVal) 
		{
			this._i.Section1 = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Section2 => this._i.Section2;

		///<summary>
		///
		///</summary>
		public void Set_Section2(dynamic pVal) 
		{
			this._i.Section2 = pVal;
		}
	}
}
