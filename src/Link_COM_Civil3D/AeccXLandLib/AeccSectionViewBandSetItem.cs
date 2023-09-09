namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewBandSetItem 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionViewBandSetItem _i;
		internal AeccSectionViewBandSetItem(object AeccSectionViewBandSetItem_object) 
		{
			this._i = AeccSectionViewBandSetItem_object as Autodesk.AECC.Interop.Land.IAeccSectionViewBandSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Section1 => this._i.Section1;

		///<summary>
		///
		///</summary>
		public void Put_Section1(dynamic pVal) 
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
		public void Put_Section2(dynamic pVal) 
		{
			this._i.Section2 = pVal;
		}
	}
}
