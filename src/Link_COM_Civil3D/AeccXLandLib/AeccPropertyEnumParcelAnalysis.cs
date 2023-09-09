namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumParcelAnalysis 
	{
		public AeccXLandLib.IAeccPropertyEnumParcelAnalysis _i;
		internal AeccPropertyEnumParcelAnalysis(object AeccPropertyEnumParcelAnalysis_object) 
		{
			this._i = AeccPropertyEnumParcelAnalysis_object as AeccXLandLib.IAeccPropertyEnumParcelAnalysis;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccParcelAnalysisType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
