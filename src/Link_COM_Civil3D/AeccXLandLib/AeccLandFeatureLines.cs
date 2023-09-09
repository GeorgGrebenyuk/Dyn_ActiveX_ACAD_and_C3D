namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLandFeatureLines 
	{
		public Autodesk.AECC.Interop.Land.IAeccLandFeatureLines _i;
		internal AeccLandFeatureLines(object AeccLandFeatureLines_object) 
		{
			this._i = AeccLandFeatureLines_object as Autodesk.AECC.Interop.Land.IAeccLandFeatureLines;
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
		public void Remove(object Name) 
		{
			this._i.Remove(Name);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFromPolyline(dynamic PolylineObjectId,object FeatureLineStyle) 
		{
			return this._i.AddFromPolyline(PolylineObjectId,FeatureLineStyle);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFromPolylineEx(dynamic Polyline,object FeatureLineStyle) 
		{
			return this._i.AddFromPolylineEx(Polyline,FeatureLineStyle);
		}
	}
}
