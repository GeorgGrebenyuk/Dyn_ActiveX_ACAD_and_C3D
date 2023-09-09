namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStructureStyle 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccStructureStyle _i;
		internal AeccStructureStyle(object AeccStructureStyle_object) 
		{
			this._i = AeccStructureStyle_object as Autodesk.AECC.Interop.Pipe.IAeccStructureStyle;
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
		public dynamic DisplayStyle2d(Autodesk.AECC.Interop.Pipe.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyle2d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyle3d(Autodesk.AECC.Interop.Pipe.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyle3d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyle2d(Autodesk.AECC.Interop.Pipe.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStyle2d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyle3d(Autodesk.AECC.Interop.Pipe.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStyle3d(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStylePlan(Autodesk.AECC.Interop.Pipe.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStylePlan(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleModel(Autodesk.AECC.Interop.Pipe.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleModel(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleProfile(Autodesk.AECC.Interop.Pipe.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleProfile(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayStyleSection(Autodesk.AECC.Interop.Pipe.AeccStructureDisplayComponents nComponent) 
		{
			return this._i.DisplayStyleSection(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStylePlan(Autodesk.AECC.Interop.Pipe.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStylePlan(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyleProfile(Autodesk.AECC.Interop.Pipe.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStyleProfile(nComponent);
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchStyleSection(Autodesk.AECC.Interop.Pipe.AeccStructureHatchComponents nComponent) 
		{
			return this._i.HatchStyleSection(nComponent);
		}
	}
}
