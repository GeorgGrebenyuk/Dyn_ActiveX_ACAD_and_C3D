namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceCreationData 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceCreationData _i;
		internal AeccSurfaceCreationData(object AeccSurfaceCreationData_object) 
		{
			this._i = AeccSurfaceCreationData_object as Autodesk.AECC.Interop.Land.IAeccSurfaceCreationData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pVal) 
		{
			this._i.Name = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pVal) 
		{
			this._i.Description = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Set_Style(string pVal) 
		{
			this._i.Style = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Layer => this._i.Layer;

		///<summary>
		///
		///</summary>
		public void Set_Layer(string pVal) 
		{
			this._i.Layer = pVal;
		}

		///<summary>
		///
		///</summary>
		public string BaseLayer => this._i.BaseLayer;

		///<summary>
		///
		///</summary>
		public void Set_BaseLayer(string pVal) 
		{
			this._i.BaseLayer = pVal;
		}
	}
}
