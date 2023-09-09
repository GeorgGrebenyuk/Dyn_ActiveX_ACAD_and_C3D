namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccEntity 
	{
		public AeccXLandLib.IAeccEntity _i;
		internal AeccEntity(object AeccEntity_object) 
		{
			this._i = AeccEntity_object as AeccXLandLib.IAeccEntity;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public string DisplayName => this._i.DisplayName;

		///<summary>
		///
		///</summary>
		public void Set_ShowToolTip(bool pVal) 
		{
			this._i.ShowToolTip = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ShowToolTip => this._i.ShowToolTip;

		///<summary>
		///
		///</summary>
		public bool IsReferenceObject => this._i.IsReferenceObject;

		///<summary>
		///
		///</summary>
		public bool IsReferenceSubObject => this._i.IsReferenceSubObject;

		///<summary>
		///
		///</summary>
		public bool IsReferenceValid => this._i.IsReferenceValid;

		///<summary>
		///
		///</summary>
		public bool IsReferenceStale => this._i.IsReferenceStale;
	}
}
