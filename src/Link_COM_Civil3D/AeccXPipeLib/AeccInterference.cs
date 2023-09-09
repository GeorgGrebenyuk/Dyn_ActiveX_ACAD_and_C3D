namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccInterference 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccInterference _i;
		internal AeccInterference(object AeccInterference_object) 
		{
			this._i = AeccInterference_object as Autodesk.AECC.Interop.Pipe.IAeccInterference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Style => this._i.Style;

		///<summary>
		///
		///</summary>
		public void Put_Style(dynamic ppiStyle) 
		{
			this._i.Style = ppiStyle;
		}

		///<summary>
		///
		///</summary>
		public dynamic SourceNetworkPart => this._i.SourceNetworkPart;

		///<summary>
		///
		///</summary>
		public dynamic TargetNetworkPart => this._i.TargetNetworkPart;

		///<summary>
		///
		///</summary>
		public object GetExtents => this._i.GetExtents;

		///<summary>
		///
		///</summary>
		public object Location => this._i.Location;

		///<summary>
		///
		///</summary>
		public bool IsBoundingBodyCheck => this._i.IsBoundingBodyCheck;

		///<summary>
		///
		///</summary>
		public void Set_IsBoundingBodyCheck(bool pbIsBoundingBodyCheck) 
		{
			this._i.IsBoundingBodyCheck = pbIsBoundingBodyCheck;
		}

		///<summary>
		///
		///</summary>
		public dynamic RenderMaterialStyle => this._i.RenderMaterialStyle;

		///<summary>
		///
		///</summary>
		public void Put_RenderMaterialStyle(dynamic ppiStyle) 
		{
			this._i.RenderMaterialStyle = ppiStyle;
		}
	}
}
