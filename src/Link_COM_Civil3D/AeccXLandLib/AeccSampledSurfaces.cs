namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampledSurfaces 
	{
		public Autodesk.AECC.Interop.Land.IAeccSampledSurfaces _i;
		internal AeccSampledSurfaces(object AeccSampledSurfaces_object) 
		{
			this._i = AeccSampledSurfaces_object as Autodesk.AECC.Interop.Land.IAeccSampledSurfaces;
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
		public dynamic Add(dynamic Surface,dynamic SectionStyle) 
		{
			return this._i.Add(Surface,SectionStyle);
		}

		///<summary>
		///
		///</summary>
		public void AddAllSurfaces(dynamic SectionStyle) 
		{
			this._i.AddAllSurfaces(SectionStyle);
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
	}
}
