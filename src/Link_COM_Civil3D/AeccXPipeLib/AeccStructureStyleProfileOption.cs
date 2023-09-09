namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureStyleProfileOption 
	{
		public AeccXPipeLib.IAeccStructureStyleProfileOption _i;
		internal AeccStructureStyleProfileOption(object AeccStructureStyleProfileOption_object) 
		{
			this._i = AeccStructureStyleProfileOption_object as AeccXPipeLib.IAeccStructureStyleProfileOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ProfileViewOptions => this._i.ProfileViewOptions;

		///<summary>
		///
		///</summary>
		public void Set_ProfileViewOptions(AeccXPipeLib.AeccStructureViewOptions pnProfileViewOptions) 
		{
			this._i.ProfileViewOptions = pnProfileViewOptions;
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
		public void Set_SizeType(AeccXPipeLib.AeccStructureDisplayOptions pnSizeType) 
		{
			this._i.SizeType = pnSizeType;
		}

		///<summary>
		///
		///</summary>
		public double XSize => this._i.XSize;

		///<summary>
		///
		///</summary>
		public void Set_XSize(double pVal) 
		{
			this._i.XSize = pVal;
		}

		///<summary>
		///
		///</summary>
		public double XSizePercent => this._i.XSizePercent;

		///<summary>
		///
		///</summary>
		public void Set_XSizePercent(double pVal) 
		{
			this._i.XSizePercent = pVal;
		}

		///<summary>
		///
		///</summary>
		public double YSize => this._i.YSize;

		///<summary>
		///
		///</summary>
		public void Set_YSize(double pVal) 
		{
			this._i.YSize = pVal;
		}

		///<summary>
		///
		///</summary>
		public double YSizePercent => this._i.YSizePercent;

		///<summary>
		///
		///</summary>
		public void Set_YSizePercent(double pVal) 
		{
			this._i.YSizePercent = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic BlockInsertLocation => this._i.BlockInsertLocation;

		///<summary>
		///
		///</summary>
		public void Set_BlockInsertLocation(AeccXPipeLib.AeccStructureInsertionLocation pnBlockInsertLocation) 
		{
			this._i.BlockInsertLocation = pnBlockInsertLocation;
		}
	}
}
