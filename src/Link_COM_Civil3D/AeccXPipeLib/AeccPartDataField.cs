namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPartDataField 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPartDataField _i;
		internal AeccPartDataField(object AeccPartDataField_object) 
		{
			this._i = AeccPartDataField_object as Autodesk.AECC.Interop.Pipe.IAeccPartDataField;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Name => this._i.Name;

		///<summary>
		///
		///</summary>
		public void Set_Name(string pbstrName) 
		{
			this._i.Name = pbstrName;
		}

		///<summary>
		///
		///</summary>
		public string Description => this._i.Description;

		///<summary>
		///
		///</summary>
		public void Set_Description(string pbstrDescription) 
		{
			this._i.Description = pbstrDescription;
		}

		///<summary>
		///
		///</summary>
		public dynamic Context => this._i.Context;

		///<summary>
		///
		///</summary>
		public void Set_Context(dynamic pnContext) 
		{
			this._i.Context = pnContext;
		}

		///<summary>
		///
		///</summary>
		public string ContextString => this._i.ContextString;

		///<summary>
		///
		///</summary>
		public void Set_ContextString(string pbstrContext) 
		{
			this._i.ContextString = pbstrContext;
		}

		///<summary>
		///
		///</summary>
		public dynamic Index => this._i.Index;

		///<summary>
		///
		///</summary>
		public void Set_Index(dynamic pnIndex) 
		{
			this._i.Index = pnIndex;
		}

		///<summary>
		///
		///</summary>
		public dynamic Usage => this._i.Usage;

		///<summary>
		///
		///</summary>
		public void Set_Usage(Autodesk.AECC.Interop.Pipe.AeccPipeNetworkUsage pnUsage) 
		{
			this._i.Usage = pnUsage;
		}

		///<summary>
		///
		///</summary>
		public string Units => this._i.Units;

		///<summary>
		///
		///</summary>
		public void Set_Units(string pbstrUnits) 
		{
			this._i.Units = pbstrUnits;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic CalculatedType => this._i.CalculatedType;

		///<summary>
		///
		///</summary>
		public void Set_CalculatedType(Autodesk.AECC.Interop.Pipe.AeccPartDataFieldType pnType) 
		{
			this._i.CalculatedType = pnType;
		}

		///<summary>
		///
		///</summary>
		public dynamic RawDataSource => this._i.RawDataSource;

		///<summary>
		///
		///</summary>
		public void Set_RawDataSource(Autodesk.AECC.Interop.Pipe.AeccPipeNetworkDataSource pnDataSource) 
		{
			this._i.RawDataSource = pnDataSource;
		}

		///<summary>
		///
		///</summary>
		public dynamic RefLookupPosition => this._i.RefLookupPosition;

		///<summary>
		///
		///</summary>
		public void Set_RefLookupPosition(dynamic pnRefLookupPosition) 
		{
			this._i.RefLookupPosition = pnRefLookupPosition;
		}

		///<summary>
		///
		///</summary>
		public dynamic SortData => this._i.SortData;

		///<summary>
		///
		///</summary>
		public void Set_SortData(dynamic ppiPartDataFieldSortData) 
		{
			this._i.SortData = ppiPartDataFieldSortData;
		}

		///<summary>
		///
		///</summary>
		public object Tag => this._i.Tag;

		///<summary>
		///
		///</summary>
		public void CopyTo(dynamic pField) 
		{
			this._i.CopyTo(pField);
		}

		///<summary>
		///
		///</summary>
		private void HiddenField_GetIdentity(out dynamic pObjectId,out dynamic pnContext,out dynamic pnIndex) 
		{
			
		}

		///<summary>
		///
		///</summary>
		private void HiddenField_SetIdentity(dynamic ObjectId,dynamic nContext,dynamic nIndex) 
		{
			
		}

		///<summary>
		///
		///</summary>
		private void HiddenField_Clean() 
		{
			
		}

		///<summary>
		///
		///</summary>
		public bool Visible => this._i.Visible;

		///<summary>
		///
		///</summary>
		public void Set_Visible(bool pbVisible) 
		{
			this._i.Visible = pbVisible;
		}

		///<summary>
		///
		///</summary>
		public bool QuerySizeAsWildcard => this._i.QuerySizeAsWildcard;

		///<summary>
		///
		///</summary>
		public void Set_QuerySizeAsWildcard(bool pbQuerySizeAsWildcard) 
		{
			this._i.QuerySizeAsWildcard = pbQuerySizeAsWildcard;
		}

		///<summary>
		///
		///</summary>
		public bool QueryMatch => this._i.QueryMatch;

		///<summary>
		///
		///</summary>
		public void Set_QueryMatch(bool pbQueryMatch) 
		{
			this._i.QueryMatch = pbQueryMatch;
		}

		///<summary>
		///
		///</summary>
		public bool DirtyState => this._i.DirtyState;

		///<summary>
		///
		///</summary>
		public void Set_DirtyState(bool pbDirtyState) 
		{
			this._i.DirtyState = pbDirtyState;
		}
	}
}
