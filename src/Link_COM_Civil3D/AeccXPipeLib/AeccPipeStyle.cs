namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeStyle 
	{
		public AeccXPipeLib.IAeccPipeStyle _i;
		internal AeccPipeStyle(object AeccPipeStyle_object) 
		{
			this._i = AeccPipeStyle_object as AeccXPipeLib.IAeccPipeStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		public dynamic SectionCrossingHatch => this._i.SectionCrossingHatch;

		///<summary>
		///
		///</summary>
		public void Set_SectionCrossingHatch(AeccXPipeLib.AeccPipeHatchOptions pnHatchOptions) 
		{
			this._i.SectionCrossingHatch = pnHatchOptions;
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d(AeccXPipeLib.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyle2d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d(AeccXPipeLib.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyle3d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyle2d(AeccXPipeLib.AeccPipeHatchComponents nComponent) 
		{
			return this._i.HatchStyle2d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan(AeccXPipeLib.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStylePlan(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel(AeccXPipeLib.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleModel(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleProfile(AeccXPipeLib.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleProfile(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleSection(AeccXPipeLib.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleSection(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStylePlan(AeccXPipeLib.AeccPipeHatchComponents nComponent) 
		{
			return this._i.HatchStylePlan(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyleProfile(AeccXPipeLib.AeccPipeHatchComponents nComponent) 
		{
			return this._i.HatchStyleProfile(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyleSection(AeccXPipeLib.AeccPipeHatchComponents nComponent) 
		{
			return this._i.HatchStyleSection(nComponent);
		}
	}
}
