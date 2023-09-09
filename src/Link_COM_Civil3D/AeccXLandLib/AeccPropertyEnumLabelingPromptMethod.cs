namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLabelingPromptMethod 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumLabelingPromptMethod _i;
		internal AeccPropertyEnumLabelingPromptMethod(object AeccPropertyEnumLabelingPromptMethod_object) 
		{
			this._i = AeccPropertyEnumLabelingPromptMethod_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumLabelingPromptMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccLabelingPromptMethodType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
