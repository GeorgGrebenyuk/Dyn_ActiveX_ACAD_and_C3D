namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLineVertices 
	{
		public Autodesk.AECC.Interop.Land.IAeccSampleLineVertices _i;
		internal AeccSampleLineVertices(object AeccSampleLineVertices_object) 
		{
			this._i = AeccSampleLineVertices_object as Autodesk.AECC.Interop.Land.IAeccSampleLineVertices;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic CountLeft => this._i.CountLeft;

		///<summary>
		///
		///</summary>
		public dynamic CountRight => this._i.CountRight;

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
		public dynamic Add(object Location,Autodesk.AECC.Interop.Land.AeccAlignmentSideType AlignmentSide,Autodesk.AECC.Interop.Land.AeccDirectionFromType DirectionFrom) 
		{
			return this._i.Add(Location,AlignmentSide,DirectionFrom);
		}

		///<summary>
		///
		///</summary>
		public dynamic Insert(dynamic Index,object Location,Autodesk.AECC.Interop.Land.AeccAlignmentSideType AlignmentSide,Autodesk.AECC.Interop.Land.AeccDirectionFromType DirectionFrom) 
		{
			return this._i.Insert(Index,Location,AlignmentSide,DirectionFrom);
		}

		///<summary>
		///
		///</summary>
		public void Remove(dynamic Index) 
		{
			this._i.Remove(Index);
		}
	}
}
