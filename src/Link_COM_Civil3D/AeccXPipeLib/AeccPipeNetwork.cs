namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPipeNetwork 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPipeNetwork _i;
		internal AeccPipeNetwork(object AeccPipeNetwork_object) 
		{
			this._i = AeccPipeNetwork_object as Autodesk.AECC.Interop.Pipe.IAeccPipeNetwork;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Pipes => this._i.Pipes;

		///<summary>
		///
		///</summary>
		public dynamic Structures => this._i.Structures;

		///<summary>
		///
		///</summary>
		public dynamic ReferenceSurface => this._i.ReferenceSurface;

		///<summary>
		///
		///</summary>
		public void Set_ReferenceSurface(dynamic ppiSurface) 
		{
			this._i.ReferenceSurface = ppiSurface;
		}

		///<summary>
		///
		///</summary>
		public dynamic ReferenceAlignment => this._i.ReferenceAlignment;

		///<summary>
		///
		///</summary>
		public void Set_ReferenceAlignment(dynamic ppiAlignment) 
		{
			this._i.ReferenceAlignment = ppiAlignment;
		}

		///<summary>
		///
		///</summary>
		public dynamic ReferencePartList => this._i.ReferencePartList;

		///<summary>
		///
		///</summary>
		public void Set_ReferencePartList(dynamic ppiPartList) 
		{
			this._i.ReferencePartList = ppiPartList;
		}

		///<summary>
		///
		///</summary>
		public void Redraw() 
		{
			this._i.Redraw();
		}

		///<summary>
		///
		///</summary>
		public void FindShortestNetworkPath(dynamic pStartPart,dynamic pEndPart) 
		{
			this._i.FindShortestNetworkPath(pStartPart,pEndPart);
		}

		///<summary>
		///
		///</summary>
		public dynamic SpanningPipeLabels => this._i.SpanningPipeLabels;
	}
}
