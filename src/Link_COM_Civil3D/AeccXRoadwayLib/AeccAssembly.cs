namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAssembly 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccAssembly _i;
		internal AeccAssembly(object AeccAssembly_object) 
		{
			this._i = AeccAssembly_object as Autodesk.AECC.Interop.Roadway.IAeccAssembly;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

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
		public string ExternalDrawing => this._i.ExternalDrawing;

		///<summary>
		///
		///</summary>
		public void Set_ExternalDrawing(string pbstrDrawingName) 
		{
			this._i.ExternalDrawing = pbstrDrawingName;
		}
	}
}
