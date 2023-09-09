namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureStyleModelOption 
	{
		public AeccXPipeLib.IAeccStructureStyleModelOption _i;
		internal AeccStructureStyleModelOption(object AeccStructureStyleModelOption_object) 
		{
			this._i = AeccStructureStyleModelOption_object as AeccXPipeLib.IAeccStructureStyleModelOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ModelViewOptions => this._i.ModelViewOptions;

		///<summary>
		///
		///</summary>
		public void Set_ModelViewOptions(AeccXPipeLib.AeccStructureModelOptions pnModeViewOptions) 
		{
			this._i.ModelViewOptions = pnModeViewOptions;
		}

		///<summary>
		///
		///</summary>
		public dynamic SimpleSolidType => this._i.SimpleSolidType;

		///<summary>
		///
		///</summary>
		public void Set_SimpleSolidType(AeccXPipeLib.AeccStructureSimpleSolidType pnSimpleSolidType) 
		{
			this._i.SimpleSolidType = pnSimpleSolidType;
		}
	}
}
