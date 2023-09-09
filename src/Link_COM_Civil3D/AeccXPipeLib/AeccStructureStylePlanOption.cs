namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureStylePlanOption 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccStructureStylePlanOption _i;
		internal AeccStructureStylePlanOption(object AeccStructureStylePlanOption_object) 
		{
			this._i = AeccStructureStylePlanOption_object as Autodesk.AECC.Interop.Pipe.IAeccStructureStylePlanOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PlanViewOptions => this._i.PlanViewOptions;

		///<summary>
		///
		///</summary>
		public void Set_PlanViewOptions(Autodesk.AECC.Interop.Pipe.AeccStructureViewOptions pnPlanViewOptions) 
		{
			this._i.PlanViewOptions = pnPlanViewOptions;
		}

		///<summary>
		///
		///</summary>
		public string SymbolBlockName => this._i.SymbolBlockName;

		///<summary>
		///
		///</summary>
		public void Set_SymbolBlockName(string pName) 
		{
			this._i.SymbolBlockName = pName;
		}

		///<summary>
		///
		///</summary>
		public double SymbolBlockXScale => this._i.SymbolBlockXScale;

		///<summary>
		///
		///</summary>
		public void Set_SymbolBlockXScale(double pVal) 
		{
			this._i.SymbolBlockXScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SymbolBlockYScale => this._i.SymbolBlockYScale;

		///<summary>
		///
		///</summary>
		public void Set_SymbolBlockYScale(double pVal) 
		{
			this._i.SymbolBlockYScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SymbolBlockZScale => this._i.SymbolBlockZScale;

		///<summary>
		///
		///</summary>
		public void Set_SymbolBlockZScale(double pVal) 
		{
			this._i.SymbolBlockZScale = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool MaskConnectedObjects => this._i.MaskConnectedObjects;

		///<summary>
		///
		///</summary>
		public void Set_MaskConnectedObjects(bool pVal) 
		{
			this._i.MaskConnectedObjects = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic SizeType => this._i.SizeType;

		///<summary>
		///
		///</summary>
		public void Set_SizeType(Autodesk.AECC.Interop.Pipe.AeccStructureDisplayOptions pnSizeType) 
		{
			this._i.SizeType = pnSizeType;
		}

		///<summary>
		///
		///</summary>
		public double Size => this._i.Size;

		///<summary>
		///
		///</summary>
		public void Set_Size(double pVal) 
		{
			this._i.Size = pVal;
		}

		///<summary>
		///
		///</summary>
		public double SizePercent => this._i.SizePercent;

		///<summary>
		///
		///</summary>
		public void Set_SizePercent(double pVal) 
		{
			this._i.SizePercent = pVal;
		}
	}
}
