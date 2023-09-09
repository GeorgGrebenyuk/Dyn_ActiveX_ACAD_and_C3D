namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceBoundaries 
	{
		public AeccXLandLib.IAeccSurfaceBoundaries _i;
		internal AeccSurfaceBoundaries(object AeccSurfaceBoundaries_object) 
		{
			this._i = AeccSurfaceBoundaries_object as AeccXLandLib.IAeccSurfaceBoundaries;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(dynamic pBoundaryEntity,string Name,AeccXLandLib.AeccBoundaryType Type,bool Nondestructive,double MidOrdDistance) 
		{
			return this._i.Add(pBoundaryEntity,Name,Type,Nondestructive,MidOrdDistance);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndex,AeccXLandLib.AeccDeleteDefinitionFromType DeleteFrom) 
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
