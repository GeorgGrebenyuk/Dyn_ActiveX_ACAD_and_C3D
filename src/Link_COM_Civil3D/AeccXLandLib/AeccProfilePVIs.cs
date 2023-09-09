namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfilePVIs 
	{
		public AeccXLandLib.IAeccProfilePVIs _i;
		internal AeccProfilePVIs(object AeccProfilePVIs_object) 
		{
			this._i = AeccProfilePVIs_object as AeccXLandLib.IAeccProfilePVIs;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic PVIindex) 
		{
			return this._i.Item(PVIindex);
		}

		///<summary>
		///
		///</summary>
		public dynamic ItemAt(double Station,double Elevation) 
		{
			return this._i.ItemAt(Station,Elevation);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(double Station,double Elevation,AeccXLandLib.AeccProfilePVICurveType CurveType,object Param1,object Param2) 
		{
			return this._i.Add(Station,Elevation,CurveType,Param1,Param2);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object pvi) 
		{
			this._i.Remove(pvi);
		}

		///<summary>
		///
		///</summary>
		public void RemoveAt(double Station,double Elevation) 
		{
			this._i.RemoveAt(Station,Elevation);
		}

		///<summary>
		///
		///</summary>
		public void AddMultiple(dynamic PVICount,object PVIs) 
		{
			this._i.AddMultiple(PVICount,PVIs);
		}
	}
}
