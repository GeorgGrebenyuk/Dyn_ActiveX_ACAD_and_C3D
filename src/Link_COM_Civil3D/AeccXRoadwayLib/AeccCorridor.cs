namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCorridor 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccCorridor _i;
		internal AeccCorridor(object AeccCorridor_object) 
		{
			this._i = AeccCorridor_object as Autodesk.AECC.Interop.Roadway.IAeccCorridor;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_MaximumTriangleSideLength(double pVal) 
		{
			this._i.MaximumTriangleSideLength = pVal;
		}

		///<summary>
		///
		///</summary>
		public double MaximumTriangleSideLength => this._i.MaximumTriangleSideLength;

		///<summary>
		///
		///</summary>
		public string CodeSetStyleName => this._i.CodeSetStyleName;

		///<summary>
		///
		///</summary>
		public void Set_CodeSetStyleName(string pbstrName) 
		{
			this._i.CodeSetStyleName = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public dynamic Baselines => this._i.Baselines;

		///<summary>
		///
		///</summary>
		public dynamic FeatureLineCodeInfos => this._i.FeatureLineCodeInfos;

		///<summary>
		///
		///</summary>
		public dynamic CorridorSurfaces => this._i.CorridorSurfaces;

		///<summary>
		///
		///</summary>
		public void Set_RebuildAutomatic(bool pVal) 
		{
			this._i.RebuildAutomatic = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool RebuildAutomatic => this._i.RebuildAutomatic;

		///<summary>
		///
		///</summary>
		public void Rebuild() 
		{
			this._i.Rebuild();
		}

		///<summary>
		///
		///</summary>
		public dynamic AddBaseline(string bstrAlignmentName,string bstrProfileName,string bstrAssemblyName) 
		{
			return this._i.AddBaseline(bstrAlignmentName,bstrProfileName,bstrAssemblyName);
		}

		///<summary>
		///
		///</summary>
		public bool OutOfDate => this._i.OutOfDate;
	}
}
