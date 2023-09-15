namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadSectionSettings 
	{
		public Autodesk.AutoCAD.Interop.Common.AcadSectionSettings _i;
		internal AcadSectionSettings(object AcadSectionSettings_object) 
		{
			this._i = AcadSectionSettings_object as Autodesk.AutoCAD.Interop.Common.AcadSectionSettings;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public object CurrentSectionType => this._i.CurrentSectionType;

		///<summary>
		///
		///</summary>
		public void Set_CurrentSectionType(Autodesk.AutoCAD.Interop.Common.AcSectionType pVal) 
		{
			this._i.CurrentSectionType = pVal;
		}

		///<summary>
		///
		///</summary>
		public AcadSectionTypeSettings GetSectionTypeSettings(Autodesk.AutoCAD.Interop.Common.AcSectionType secType) 
		{
			return new AcadSectionTypeSettings(this._i.GetSectionTypeSettings(secType));
		}
	}
}
