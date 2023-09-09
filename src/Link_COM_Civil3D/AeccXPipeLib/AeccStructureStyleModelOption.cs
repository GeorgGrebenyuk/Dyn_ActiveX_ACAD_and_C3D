namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureStyleModelOption 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccStructureStyleModelOption _i;
		internal AeccStructureStyleModelOption(object AeccStructureStyleModelOption_object) 
		{
			this._i = AeccStructureStyleModelOption_object as Autodesk.AECC.Interop.Pipe.IAeccStructureStyleModelOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ModelViewOptions => this._i.ModelViewOptions;

		///<summary>
		///
		///</summary>
		public void Set_ModelViewOptions(Autodesk.AECC.Interop.Pipe.AeccStructureModelOptions pnModeViewOptions) 
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
		public void Set_SimpleSolidType(Autodesk.AECC.Interop.Pipe.AeccStructureSimpleSolidType pnSimpleSolidType) 
		{
			this._i.SimpleSolidType = pnSimpleSolidType;
		}
	}
}
