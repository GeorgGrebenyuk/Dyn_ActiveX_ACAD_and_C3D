namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AxDbDocument 
	{
		public AXDBLib.IAxDbDocument _i;
		internal AxDbDocument(object AxDbDocument_object) 
		{
			this._i = AxDbDocument_object as AXDBLib.IAxDbDocument;
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
		public void Open(string FileName,object Password) 
		{
			this._i.Open(FileName,Password);
		}

		///<summary>
		///
		///</summary>
		public void Save() 
		{
			this._i.Save();
		}

		///<summary>
		///
		///</summary>
		public void SaveAs(string FileName,object vSecurityParams) 
		{
			this._i.SaveAs(FileName,vSecurityParams);
		}

		///<summary>
		///
		///</summary>
		public void DxfIn(string FileName,object LogFileName) 
		{
			this._i.DxfIn(FileName,LogFileName);
		}

		///<summary>
		///
		///</summary>
		public void DxfOut(string FileName,object precision,object SaveThumbnailImage) 
		{
			this._i.DxfOut(FileName,precision,SaveThumbnailImage);
		}

		///<summary>
		///
		///</summary>
		public dynamic Application => this._i.Application;

		///<summary>
		///
		///</summary>
		public dynamic Database => this._i.Database;
	}
}
