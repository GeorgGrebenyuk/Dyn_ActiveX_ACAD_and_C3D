namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccInterferenceCheck 
	{
		public AeccXPipeLib.IAeccInterferenceCheck _i;
		internal AeccInterferenceCheck(object AeccInterferenceCheck_object) 
		{
			this._i = AeccInterferenceCheck_object as AeccXPipeLib.IAeccInterferenceCheck;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SourceNetwork => this._i.SourceNetwork;

		///<summary>
		///
		///</summary>
		public dynamic TargetNetwork => this._i.TargetNetwork;

		///<summary>
		///
		///</summary>
		public object GetExtents => this._i.GetExtents;

		///<summary>
		///
		///</summary>
		public bool IsOutOfDate => this._i.IsOutOfDate;

		///<summary>
		///
		///</summary>
		public void UpdateInterferenceCheck() 
		{
			this._i.UpdateInterferenceCheck();
		}

		///<summary>
		///
		///</summary>
		public dynamic RenderMaterialStyle => this._i.RenderMaterialStyle;

		///<summary>
		///
		///</summary>
		public void Put_RenderMaterialStyle(dynamic ppiStyle) 
		{
			this._i.RenderMaterialStyle = ppiStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic Criteria => this._i.Criteria;

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndexOrName) 
		{
			return this._i.Item(varIndexOrName);
		}
	}
}
