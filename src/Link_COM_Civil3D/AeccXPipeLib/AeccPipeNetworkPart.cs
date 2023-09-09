namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeNetworkPart 
	{
		public AeccXPipeLib.IAeccPipeNetworkPart _i;
		internal AeccPipeNetworkPart(object AeccPipeNetworkPart_object) 
		{
			this._i = AeccPipeNetworkPart_object as AeccXPipeLib.IAeccPipeNetworkPart;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Connectors => this._i.Connectors;

		///<summary>
		///
		///</summary>
		public dynamic PartDataRecord => this._i.PartDataRecord;

		///<summary>
		///
		///</summary>
		public void Put_PartDataRecord(dynamic ppPartDataRecord) 
		{
			this._i.PartDataRecord = ppPartDataRecord;
		}

		///<summary>
		///
		///</summary>
		public int PartType => this._i.PartType;

		///<summary>
		///
		///</summary>
		public dynamic ParamsBool => this._i.ParamsBool;

		///<summary>
		///
		///</summary>
		public dynamic ParamsLong => this._i.ParamsLong;

		///<summary>
		///
		///</summary>
		public dynamic ParamsDouble => this._i.ParamsDouble;

		///<summary>
		///
		///</summary>
		public dynamic ParamsString => this._i.ParamsString;

		///<summary>
		///
		///</summary>
		public dynamic PartFamily => this._i.PartFamily;

		///<summary>
		///
		///</summary>
		public dynamic ProfileNetworkParts => this._i.ProfileNetworkParts;

		///<summary>
		///
		///</summary>
		public string PartSizeName => this._i.PartSizeName;

		///<summary>
		///
		///</summary>
		public void SwapPartFamilyAndSize(string csPartFamilyGuid,dynamic piPartSizeFilter) 
		{
			this._i.SwapPartFamilyAndSize(csPartFamilyGuid,piPartSizeFilter);
		}
	}
}
