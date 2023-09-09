namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParam 
	{
		public AeccXLandLib.IAeccParam _i;
		internal AeccParam(object AeccParam_object) 
		{
			this._i = AeccParam_object as AeccXLandLib.IAeccParam;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Key => this._i.Key;

		///<summary>
		///
		///</summary>
		public dynamic Access => this._i.Access;

		///<summary>
		///
		///</summary>
		public void Set_Access(AeccXLandLib.AeccParamAccessType pVal) 
		{
			this._i.Access = pVal;
		}

		///<summary>
		///
		///</summary>
		public string DisplayName => this._i.DisplayName;

		///<summary>
		///
		///</summary>
		public void Set_DisplayName(string pVal) 
		{
			this._i.DisplayName = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pVal) 
		{
			this._i.Description = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Comment => this._i.Comment;

		///<summary>
		///
		///</summary>
		public void Set_Comment(string pVal) 
		{
			this._i.Comment = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic DisplayOrder => this._i.DisplayOrder;

		///<summary>
		///
		///</summary>
		public void Set_DisplayOrder(dynamic short) 
		{
			this._i.DisplayOrder = short;
		}

		///<summary>
		///
		///</summary>
		public bool ReadOnly => this._i.ReadOnly;

		///<summary>
		///
		///</summary>
		public void Set_ReadOnly(bool pVal) 
		{
			this._i.ReadOnly = pVal;
		}
	}
}
