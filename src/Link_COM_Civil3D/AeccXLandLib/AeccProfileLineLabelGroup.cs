namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileLineLabelGroup 
	{
		public AeccXLandLib.IAeccProfileLineLabelGroup _i;
		internal AeccProfileLineLabelGroup(object AeccProfileLineLabelGroup_object) 
		{
			this._i = AeccProfileLineLabelGroup_object as AeccXLandLib.IAeccProfileLineLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double WeedingValue => this._i.WeedingValue;

		///<summary>
		///
		///</summary>
		public void Set_WeedingValue(double pVal) 
		{
			this._i.WeedingValue = pVal;
		}
	}
}
