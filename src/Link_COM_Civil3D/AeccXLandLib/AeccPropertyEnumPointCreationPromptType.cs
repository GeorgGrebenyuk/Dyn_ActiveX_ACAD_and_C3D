namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumPointCreationPromptType 
	{
		public AeccXLandLib.IAeccPropertyEnumPointCreationPromptType _i;
		internal AeccPropertyEnumPointCreationPromptType(object AeccPropertyEnumPointCreationPromptType_object) 
		{
			this._i = AeccPropertyEnumPointCreationPromptType_object as AeccXLandLib.IAeccPropertyEnumPointCreationPromptType;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccPointCreationPromptType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
