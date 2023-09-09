namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumProfileViewPlot 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewPlot _i;
		internal AeccPropertyEnumProfileViewPlot(object AeccPropertyEnumProfileViewPlot_object) 
		{
			this._i = AeccPropertyEnumProfileViewPlot_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumProfileViewPlot;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccProfileViewPlotType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
