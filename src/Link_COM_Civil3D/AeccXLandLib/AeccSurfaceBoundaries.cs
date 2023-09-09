namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceBoundaries 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaceBoundaries _i;
		internal AeccSurfaceBoundaries(object AeccSurfaceBoundaries_object) 
		{
			this._i = AeccSurfaceBoundaries_object as Autodesk.AECC.Interop.Land.IAeccSurfaceBoundaries;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(dynamic pBoundaryEntity,string Name,Autodesk.AECC.Interop.Land.AeccBoundaryType Type,bool Nondestructive,double MidOrdDistance) 
		{
			return this._i.Add(pBoundaryEntity,Name,Type,Nondestructive,MidOrdDistance);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndex,Autodesk.AECC.Interop.Land.AeccDeleteDefinitionFromType DeleteFrom) 
		{
			this._i.Remove(varIndex,DeleteFrom);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}
	}
}
