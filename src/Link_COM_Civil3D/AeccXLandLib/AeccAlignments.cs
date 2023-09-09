namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignments 
	{
		public AeccXLandLib.IAeccAlignments _i;
		internal AeccAlignments(object AeccAlignments_object) 
		{
			this._i = AeccAlignments_object as AeccXLandLib.IAeccAlignments;
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
		public dynamic Add(string Name,string Layer,object AlignmentStyle,object AlignmentLabelStyleSet) 
		{
			return this._i.Add(Name,Layer,AlignmentStyle,AlignmentLabelStyleSet);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFromPolyline(string Name,string Layer,dynamic PolylineObjectId,object AlignmentStyle,object AlignmentLabelStyleSet,bool AddCurvesBetweenTangents,bool EraseExistingEntities) 
		{
			return this._i.AddFromPolyline(Name,Layer,PolylineObjectId,AlignmentStyle,AlignmentLabelStyleSet,AddCurvesBetweenTangents,EraseExistingEntities);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddFromPolylineEx(string Name,string Layer,dynamic Polyline,object AlignmentStyle,object AlignmentLabelStyleSet,bool AddCurvesBetweenTangents,bool EraseExistingEntities) 
		{
			return this._i.AddFromPolylineEx(Name,Layer,Polyline,AlignmentStyle,AlignmentLabelStyleSet,AddCurvesBetweenTangents,EraseExistingEntities);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Name) 
		{
			this._i.Remove(Name);
		}
	}
}
