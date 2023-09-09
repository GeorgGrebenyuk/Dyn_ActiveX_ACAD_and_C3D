namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAppliedAssembly 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccAppliedAssembly _i;
		internal AeccAppliedAssembly(object AeccAppliedAssembly_object) 
		{
			this._i = AeccAppliedAssembly_object as Autodesk.AECC.Interop.Roadway.IAeccAppliedAssembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Corridor => this._i.Corridor;

		///<summary>
		///
		///</summary>
		public dynamic AppliedSubassemblies => this._i.AppliedSubassemblies;

		///<summary>
		///
		///</summary>
		public dynamic GetPoints => this._i.GetPoints;

		///<summary>
		///
		///</summary>
		public dynamic GetPointsByCode(string bstrCode) 
		{
			return this._i.GetPointsByCode(bstrCode);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetLinks => this._i.GetLinks;

		///<summary>
		///
		///</summary>
		public dynamic GetLinksByCode(string bstrCode) 
		{
			return this._i.GetLinksByCode(bstrCode);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetShapes => this._i.GetShapes;

		///<summary>
		///
		///</summary>
		public dynamic GetShapesByCode(string bstrCode) 
		{
			return this._i.GetShapesByCode(bstrCode);
		}
	}
}
