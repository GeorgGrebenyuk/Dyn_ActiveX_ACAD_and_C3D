namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileStationLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileStationLabelGroup _i;
		internal AeccProfileStationLabelGroup(object AeccProfileStationLabelGroup_object) 
		{
			this._i = AeccProfileStationLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccProfileStationLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Increment => this._i.Increment;

		///<summary>
		///
		///</summary>
		public void Set_Increment(double pVal) 
		{
			this._i.Increment = pVal;
		}
	}
}
