namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsTransformationPoint 
	{
		public AeccXLandLib.IAeccSettingsTransformationPoint _i;
		internal AeccSettingsTransformationPoint(object AeccSettingsTransformationPoint_object) 
		{
			this._i = AeccSettingsTransformationPoint_object as AeccXLandLib.IAeccSettingsTransformationPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic PointNumber => this._i.PointNumber;

		///<summary>
		///
		///</summary>
		public void Set_PointNumber(dynamic pVal) 
		{
			this._i.PointNumber = pVal;
		}

		///<summary>
		///
		///</summary>
		public double LocalNorthing => this._i.LocalNorthing;

		///<summary>
		///
		///</summary>
		public void Set_LocalNorthing(double pVal) 
		{
			this._i.LocalNorthing = pVal;
		}

		///<summary>
		///
		///</summary>
		public double LocalEasting => this._i.LocalEasting;

		///<summary>
		///
		///</summary>
		public void Set_LocalEasting(double pVal) 
		{
			this._i.LocalEasting = pVal;
		}

		///<summary>
		///
		///</summary>
		public double GridNorthing => this._i.GridNorthing;

		///<summary>
		///
		///</summary>
		public void Set_GridNorthing(double pVal) 
		{
			this._i.GridNorthing = pVal;
		}

		///<summary>
		///
		///</summary>
		public double GridEasting => this._i.GridEasting;

		///<summary>
		///
		///</summary>
		public void Set_GridEasting(double pVal) 
		{
			this._i.GridEasting = pVal;
		}
	}
}
