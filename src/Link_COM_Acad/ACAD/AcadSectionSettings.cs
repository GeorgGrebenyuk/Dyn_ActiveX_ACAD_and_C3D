namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSectionSettings 
	{
		public AXDBLib.IAcadSectionSettings _i;
		internal AcadSectionSettings(object AcadSectionSettings_object) 
		{
			this._i = AcadSectionSettings_object as AXDBLib.IAcadSectionSettings;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CurrentSectionType => this._i.CurrentSectionType;

		///<summary>
		///
		///</summary>
		public void Set_CurrentSectionType(AXDBLib.AcSectionType pVal) 
		{
			this._i.CurrentSectionType = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic GetSectionTypeSettings(AXDBLib.AcSectionType secType) 
		{
			return this._i.GetSectionTypeSettings(secType);
		}
	}
}
