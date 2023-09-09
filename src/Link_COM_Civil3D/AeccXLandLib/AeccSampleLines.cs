namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLines 
	{
		public Autodesk.AECC.Interop.Land.IAeccSampleLines _i;
		internal AeccSampleLines(object AeccSampleLines_object) 
		{
			this._i = AeccSampleLines_object as Autodesk.AECC.Interop.Land.IAeccSampleLines;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}

		///<summary>
		///
		///</summary>
		public void RemoveAll() 
		{
			this._i.RemoveAll();
		}

		///<summary>
		///
		///</summary>
		public void Sort() 
		{
			this._i.Sort();
		}

		///<summary>
		///
		///</summary>
		public dynamic AddByPolyline(string bstrName,dynamic Polyline,bool ErasePolyline) 
		{
			return this._i.AddByPolyline(bstrName,Polyline,ErasePolyline);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddByStation(string bstrName,double Station,double LeftSwathLength,double RightSwathLength) 
		{
			return this._i.AddByStation(bstrName,Station,LeftSwathLength,RightSwathLength);
		}

		///<summary>
		///
		///</summary>
		public void AddByStationRange(string bstrName,Autodesk.AECC.Interop.Land.AeccSampleLineDuplicateActionType DuplicateActionType,dynamic StationRangeParameters) 
		{
			this._i.AddByStationRange(bstrName,DuplicateActionType,StationRangeParameters);
		}
	}
}
