namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileViewBandSetItem 
	{
		public AeccXLandLib.IAeccProfileViewBandSetItem _i;
		internal AeccProfileViewBandSetItem(object AeccProfileViewBandSetItem_object) 
		{
			this._i = AeccProfileViewBandSetItem_object as AeccXLandLib.IAeccProfileViewBandSetItem;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;

		///<summary>
		///
		///</summary>
		public dynamic Profile1 => this._i.Profile1;

		///<summary>
		///
		///</summary>
		public void Put_Profile1(dynamic pVal) 
		{
			this._i.Profile1 = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Profile2 => this._i.Profile2;

		///<summary>
		///
		///</summary>
		public void Put_Profile2(dynamic pVal) 
		{
			this._i.Profile2 = pVal;
		}
	}
}
