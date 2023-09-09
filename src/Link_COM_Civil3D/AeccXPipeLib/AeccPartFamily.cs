namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartFamily 
	{
		public AeccXPipeLib.IAeccPartFamily _i;
		internal AeccPartFamily(object AeccPartFamily_object) 
		{
			this._i = AeccPartFamily_object as AeccXPipeLib.IAeccPartFamily;
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
		public string Guid => this._i.Guid;

		///<summary>
		///
		///</summary>
		public void Set_Guid(string pbstrGuid) 
		{
			this._i.Guid = pbstrGuid;
		}

		///<summary>
		///
		///</summary>
		public dynamic Domain => this._i.Domain;

		///<summary>
		///
		///</summary>
		public void Set_Domain(AeccXPipeLib.AeccPipeNetworkDomain pnDomain) 
		{
			this._i.Domain = pnDomain;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Type(dynamic pnType) 
		{
			this._i.Type = pnType;
		}

		///<summary>
		///
		///</summary>
		public dynamic SizeFilters => this._i.SizeFilters;
	}
}
