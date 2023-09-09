namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStationOffsetLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccStationOffsetLabel _i;
		internal AeccStationOffsetLabel(object AeccStationOffsetLabel_object) 
		{
			this._i = AeccStationOffsetLabel_object as Autodesk.AECC.Interop.Land.IAeccStationOffsetLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_AtFixedXY(bool pVal) 
		{
			this._i.AtFixedXY = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool AtFixedXY => this._i.AtFixedXY;

		///<summary>
		///
		///</summary>
		public dynamic Alignment => this._i.Alignment;

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyle => this._i.MarkerStyle;

		///<summary>
		///
		///</summary>
		public void Set_MarkerStyle(object ppVal) 
		{
			this._i.MarkerStyle = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LeaderAttachmentOption => this._i.LeaderAttachmentOption;

		///<summary>
		///
		///</summary>
		public void Set_LeaderAttachmentOption(Autodesk.AECC.Interop.Land.AeccLabelLeaderAttachmentType pVal) 
		{
			this._i.LeaderAttachmentOption = pVal;
		}
	}
}
