namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateParcelROW 
	{
		public AeccXLandLib.IAeccSettingsCreateParcelROW _i;
		internal AeccSettingsCreateParcelROW(object AeccSettingsCreateParcelROW_object) 
		{
			this._i = AeccSettingsCreateParcelROW_object as AeccXLandLib.IAeccSettingsCreateParcelROW;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic OffsetFromAlignment => this._i.OffsetFromAlignment;

		///<summary>
		///
		///</summary>
		public dynamic FilletRadiusAtBoundaryIntersections => this._i.FilletRadiusAtBoundaryIntersections;

		///<summary>
		///
		///</summary>
		public dynamic FilletRadiusAtAlignIntersections => this._i.FilletRadiusAtAlignIntersections;

		///<summary>
		///
		///</summary>
		public dynamic ParcelCleanupMethod => this._i.ParcelCleanupMethod;

		///<summary>
		///
		///</summary>
		public dynamic AlignmentCleanupMethod => this._i.AlignmentCleanupMethod;
	}
}
