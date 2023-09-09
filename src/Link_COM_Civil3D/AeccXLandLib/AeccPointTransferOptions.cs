namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPointTransferOptions 
	{
		public AeccXLandLib.IAeccPointTransferOptions _i;
		internal AeccPointTransferOptions(object AeccPointTransferOptions_object) 
		{
			this._i = AeccPointTransferOptions_object as AeccXLandLib.IAeccPointTransferOptions;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_AdjustElevation(bool AdjustElev) 
		{
			this._i.AdjustElevation = AdjustElev;
		}

		///<summary>
		///
		///</summary>
		public bool AdjustElevation => this._i.AdjustElevation;

		///<summary>
		///
		///</summary>
		public void Set_TransformCoordinate(bool TransfCoord) 
		{
			this._i.TransformCoordinate = TransfCoord;
		}

		///<summary>
		///
		///</summary>
		public bool TransformCoordinate => this._i.TransformCoordinate;

		///<summary>
		///
		///</summary>
		public void Set_ExpandCoordinateData(bool ExpandCoord) 
		{
			this._i.ExpandCoordinateData = ExpandCoord;
		}

		///<summary>
		///
		///</summary>
		public bool ExpandCoordinateData => this._i.ExpandCoordinateData;
	}
}
