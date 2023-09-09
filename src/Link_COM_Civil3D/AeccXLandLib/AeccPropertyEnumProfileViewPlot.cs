namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewPlot 
	{
		public AeccXLandLib.IAeccPropertyEnumProfileViewPlot _i;
		internal AeccPropertyEnumProfileViewPlot(object AeccPropertyEnumProfileViewPlot_object) 
		{
			this._i = AeccPropertyEnumProfileViewPlot_object as AeccXLandLib.IAeccPropertyEnumProfileViewPlot;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccProfileViewPlotType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
