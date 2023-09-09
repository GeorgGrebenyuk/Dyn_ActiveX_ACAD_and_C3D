namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAssemblyStyle 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccAssemblyStyle _i;
		internal AeccAssemblyStyle(object AeccAssemblyStyle_object) 
		{
			this._i = AeccAssemblyStyle_object as Autodesk.AECC.Interop.Roadway.IAeccAssemblyStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleAtAssemblyOrigin => this._i.MarkerStyleAtAssemblyOrigin;

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleAtMainBaseline => this._i.MarkerStyleAtMainBaseline;

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleAtMainBaselineOrigin => this._i.MarkerStyleAtMainBaselineOrigin;

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleAtOffsetBaseline => this._i.MarkerStyleAtOffsetBaseline;

		///<summary>
		///
		///</summary>
		public dynamic MarkerStyleAtOffsetBaselineOrigin => this._i.MarkerStyleAtOffsetBaselineOrigin;
	}
}
