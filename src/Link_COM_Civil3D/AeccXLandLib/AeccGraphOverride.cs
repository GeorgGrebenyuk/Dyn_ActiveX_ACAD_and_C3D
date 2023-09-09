namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGraphOverride 
	{
		public Autodesk.AECC.Interop.Land.IAeccGraphOverride _i;
		internal AeccGraphOverride(object AeccGraphOverride_object) 
		{
			this._i = AeccGraphOverride_object as Autodesk.AECC.Interop.Land.IAeccGraphOverride;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool Draw => this._i.Draw;

		///<summary>
		///
		///</summary>
		public void Set_Draw(bool pVal) 
		{
			this._i.Draw = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool ClipGrid => this._i.ClipGrid;

		///<summary>
		///
		///</summary>
		public void Set_ClipGrid(bool pVal) 
		{
			this._i.ClipGrid = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool OverrideStyle => this._i.OverrideStyle;

		///<summary>
		///
		///</summary>
		public void Set_OverrideStyle(bool pVal) 
		{
			this._i.OverrideStyle = pVal;
		}
	}
}
