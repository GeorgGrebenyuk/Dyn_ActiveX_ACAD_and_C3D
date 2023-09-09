namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureStyle 
	{
		public AeccXPipeLib.IAeccStructureStyle _i;
		internal AeccStructureStyle(object AeccStructureStyle_object) 
		{
			this._i = AeccStructureStyle_object as AeccXPipeLib.IAeccStructureStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic ModelOption => this._i.ModelOption;

		///<summary>
		///
		///</summary>
		public dynamic PlanOption => this._i.PlanOption;

		///<summary>
		///
		///</summary>
		public dynamic ProfileOption => this._i.ProfileOption;

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d(AeccXPipeLib.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyle2d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d(AeccXPipeLib.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyle3d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyle2d(AeccXPipeLib.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStyle2d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyle3d(AeccXPipeLib.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStyle3d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan(AeccXPipeLib.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStylePlan(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel(AeccXPipeLib.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleModel(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleProfile(AeccXPipeLib.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleProfile(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleSection(AeccXPipeLib.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleSection(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStylePlan(AeccXPipeLib.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStylePlan(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyleProfile(AeccXPipeLib.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStyleProfile(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyleSection(AeccXPipeLib.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStyleSection(nComponent);
		}
	}
}
