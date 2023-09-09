namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumLabelingPromptMethod 
	{
		public AeccXLandLib.IAeccPropertyEnumLabelingPromptMethod _i;
		internal AeccPropertyEnumLabelingPromptMethod(object AeccPropertyEnumLabelingPromptMethod_object) 
		{
			this._i = AeccPropertyEnumLabelingPromptMethod_object as AeccXLandLib.IAeccPropertyEnumLabelingPromptMethod;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccLabelingPromptMethodType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
