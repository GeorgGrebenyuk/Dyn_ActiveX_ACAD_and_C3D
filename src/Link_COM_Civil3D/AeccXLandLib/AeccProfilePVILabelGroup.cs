namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfilePVILabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfilePVILabelGroup _i;
		internal AeccProfilePVILabelGroup(object AeccProfilePVILabelGroup_object) 
		{
			this._i = AeccProfilePVILabelGroup_object as Autodesk.AECC.Interop.Land.IAeccProfilePVILabelGroup;
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
