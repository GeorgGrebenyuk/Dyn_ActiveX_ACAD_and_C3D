namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccColumnStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccColumnStyle _i;
		internal AeccColumnStyle(object AeccColumnStyle_object) 
		{
			this._i = AeccColumnStyle_object as Autodesk.AECC.Interop.Land.IAeccColumnStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Header(string pVal) 
		{
			this._i.Header = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Header => this._i.Header;

		///<summary>
		///
		///</summary>
		public void Set_HeaderUnformatted(string pVal) 
		{
			this._i.HeaderUnformatted = pVal;
		}

		///<summary>
		///
		///</summary>
		public string HeaderUnformatted => this._i.HeaderUnformatted;

		///<summary>
		///
		///</summary>
		public dynamic HeaderJustification => this._i.HeaderJustification;

		///<summary>
		///
		///</summary>
		public void Set_HeaderJustification(Autodesk.AECC.Interop.Land.AeccTableTitleJustificationType pVal) 
		{
			this._i.HeaderJustification = pVal;
		}

		///<summary>
		///
		///</summary>
		public void Set_Width(double pVal) 
		{
			this._i.Width = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Width => this._i.Width;

		///<summary>
		///
		///</summary>
		public void SetData(string newVal,object DataType) 
		{
			this._i.SetData(newVal,DataType);
		}

		///<summary>
		///
		///</summary>
		public void GetData(out string pVal,object DataType) 
		{
			this._i.GetData(out pVal,DataType);
		}

		///<summary>
		///
		///</summary>
		public void SetDataUnformatted(string newVal,object DataType) 
		{
			this._i.SetDataUnformatted(newVal,DataType);
		}

		///<summary>
		///
		///</summary>
		public void GetDataUnformatted(out string pVal,object DataType) 
		{
			this._i.GetDataUnformatted(out pVal,DataType);
		}

		///<summary>
		///
		///</summary>
		public dynamic DataJustification => this._i.DataJustification;

		///<summary>
		///
		///</summary>
		public void Set_DataJustification(Autodesk.AECC.Interop.Land.AeccTableTitleJustificationType pVal) 
		{
			this._i.DataJustification = pVal;
		}
	}
}
