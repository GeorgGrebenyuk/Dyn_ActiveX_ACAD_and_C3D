namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeStyle 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeStyle _i;
		internal AeccPipeStyle(object AeccPipeStyle_object) 
		{
			this._i = AeccPipeStyle_object as Autodesk.AECC.Interop.Pipe.IAeccPipeStyle;
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
		public void Set_SectionCrossingHatch(Autodesk.AECC.Interop.Pipe.AeccPipeHatchOptions pnHatchOptions) 
		{
			this._i.SectionCrossingHatch = pnHatchOptions;
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle2d(Autodesk.AECC.Interop.Pipe.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyle2d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d(Autodesk.AECC.Interop.Pipe.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyle3d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyle2d(Autodesk.AECC.Interop.Pipe.AeccPipeHatchComponents nComponent) 
		{
			return this._i.HatchStyle2d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan(Autodesk.AECC.Interop.Pipe.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStylePlan(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel(Autodesk.AECC.Interop.Pipe.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleModel(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleProfile(Autodesk.AECC.Interop.Pipe.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleProfile(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleSection(Autodesk.AECC.Interop.Pipe.AeccPipeDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleSection(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStylePlan(Autodesk.AECC.Interop.Pipe.AeccPipeHatchComponents nComponent) 
		{
			return this._i.HatchStylePlan(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyleProfile(Autodesk.AECC.Interop.Pipe.AeccPipeHatchComponents nComponent) 
		{
			return this._i.HatchStyleProfile(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyleSection(Autodesk.AECC.Interop.Pipe.AeccPipeHatchComponents nComponent) 
		{
			return this._i.HatchStyleSection(nComponent);
		}
	}
}
