namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadDwfUnderlay 
	{
		public AXDBLib.IAcadDwfUnderlay _i;
		internal AcadDwfUnderlay(object AcadDwfUnderlay_object) 
		{
			this._i = AcadDwfUnderlay_object as AXDBLib.IAcadDwfUnderlay;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string DWFFormat => this._i.DWFFormat;

		///<summary>
		///
		///</summary>
		public void Set_DWFFormat(string Name) 
		{
			this._i.DWFFormat = Name;
		}
	}
}
