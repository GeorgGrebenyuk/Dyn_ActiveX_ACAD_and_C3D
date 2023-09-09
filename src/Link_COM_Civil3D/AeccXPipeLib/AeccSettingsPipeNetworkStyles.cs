namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsPipeNetworkStyles 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccSettingsPipeNetworkStyles _i;
		internal AeccSettingsPipeNetworkStyles(object AeccSettingsPipeNetworkStyles_object) 
		{
			this._i = AeccSettingsPipeNetworkStyles_object as Autodesk.AECC.Interop.Pipe.IAeccSettingsPipeNetworkStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic StructureDefaultStyle => this._i.StructureDefaultStyle;

		///<summary>
		///
		///</summary>
		public dynamic PipeDefaultStyle => this._i.PipeDefaultStyle;

		///<summary>
		///
		///</summary>
		public dynamic RenderMaterialStyle => this._i.RenderMaterialStyle;

		///<summary>
		///
		///</summary>
		public dynamic StructurePlanLabelStyle => this._i.StructurePlanLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic PipePlanLabelStyle => this._i.PipePlanLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic StructureProfileLabelStyle => this._i.StructureProfileLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic PipeProfileLabelStyle => this._i.PipeProfileLabelStyle;

		///<summary>
		///
		///</summary>
		public dynamic DefaultPartsList => this._i.DefaultPartsList;

		///<summary>
		///
		///</summary>
		public dynamic ImportPartsList => this._i.ImportPartsList;
	}
}
