namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPoints 
	{
		public Autodesk.AECC.Interop.Land.IAeccPoints _i;
		internal AeccPoints(object AeccPoints_object) 
		{
			this._i = AeccPoints_object as Autodesk.AECC.Interop.Land.IAeccPoints;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(object Location) 
		{
			return this._i.Add(Location);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Find(dynamic PointNumber) 
		{
			return this._i.Find(PointNumber);
		}

		///<summary>
		///
		///</summary>
		public void Remove(dynamic PointNumber) 
		{
			this._i.Remove(PointNumber);
		}

		///<summary>
		///
		///</summary>
		public dynamic ImportPoints(string FileName,string FileFormatName,dynamic ImportOptions) 
		{
			return this._i.ImportPoints(FileName,FileFormatName,ImportOptions);
		}

		///<summary>
		///
		///</summary>
		public void ExportPoints(string FileName,string FileFormatName,dynamic ExportOptions) 
		{
			this._i.ExportPoints(FileName,FileFormatName,ExportOptions);
		}

		///<summary>
		///
		///</summary>
		public void TransferPoints(string SourceFileName,string SourceFileFormatName,string DestinationFileName,string DestinationFileFormatName,dynamic TransferOptions) 
		{
			this._i.TransferPoints(SourceFileName,SourceFileFormatName,DestinationFileName,DestinationFileFormatName,TransferOptions);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddMultiple(dynamic PointCount,object Location,out dynamic StartIndex) 
		{
			return this._i.AddMultiple(PointCount,Location,out StartIndex);
		}
	}
}
