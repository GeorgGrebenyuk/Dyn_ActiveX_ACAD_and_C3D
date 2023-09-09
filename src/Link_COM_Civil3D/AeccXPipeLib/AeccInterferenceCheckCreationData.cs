namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccInterferenceCheckCreationData 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccInterferenceCheckCreationData _i;
		internal AeccInterferenceCheckCreationData(object AeccInterferenceCheckCreationData_object) 
		{
			this._i = AeccInterferenceCheckCreationData_object as Autodesk.AECC.Interop.Pipe.IAeccInterferenceCheckCreationData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pbstrName) 
		{
			this._i.Name = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pbstrDescription) 
		{
			this._i.Description = pbstrDescription;
		}

		///<summary>
		///
		///</summary>
		public string LayerName => this._i.LayerName;

		///<summary>
		///
		///</summary>
		public void Set_LayerName(string pbstrLayerName) 
		{
			this._i.LayerName = pbstrLayerName;
		}

		///<summary>
		///
		///</summary>
		public string BaseLayerName => this._i.BaseLayerName;

		///<summary>
		///
		///</summary>
		public void Set_BaseLayerName(string pbstrBaseLayerName) 
		{
			this._i.BaseLayerName = pbstrBaseLayerName;
		}

		///<summary>
		///
		///</summary>
		public bool ShowTooltips => this._i.ShowTooltips;

		///<summary>
		///
		///</summary>
		public void Set_ShowTooltips(bool pbShowTooltips) 
		{
			this._i.ShowTooltips = pbShowTooltips;
		}

		///<summary>
		///
		///</summary>
		public dynamic SourceNetwork => this._i.SourceNetwork;

		///<summary>
		///
		///</summary>
		public void Put_SourceNetwork(dynamic ppiSourceNetwork) 
		{
			this._i.SourceNetwork = ppiSourceNetwork;
		}

		///<summary>
		///
		///</summary>
		public dynamic TargetNetwork => this._i.TargetNetwork;

		///<summary>
		///
		///</summary>
		public void Put_TargetNetwork(dynamic ppiTargetNetwork) 
		{
			this._i.TargetNetwork = ppiTargetNetwork;
		}

		///<summary>
		///
		///</summary>
		public dynamic Criteria => this._i.Criteria;

		///<summary>
		///
		///</summary>
		public dynamic InterferenceStyle => this._i.InterferenceStyle;

		///<summary>
		///
		///</summary>
		public void Put_InterferenceStyle(dynamic ppiStyle) 
		{
			this._i.InterferenceStyle = ppiStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic InterferenceRenderMaterialStyle => this._i.InterferenceRenderMaterialStyle;

		///<summary>
		///
		///</summary>
		public void Put_InterferenceRenderMaterialStyle(dynamic ppiStyle) 
		{
			this._i.InterferenceRenderMaterialStyle = ppiStyle;
		}
	}
}
