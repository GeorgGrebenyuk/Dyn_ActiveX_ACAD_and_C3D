namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaces 
	{
		public Autodesk.AECC.Interop.Land.IAeccSurfaces _i;
		internal AeccSurfaces(object AeccSurfaces_object) 
		{
			this._i = AeccSurfaces_object as Autodesk.AECC.Interop.Land.IAeccSurfaces;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic AddGridSurface(dynamic GridCreationData) 
		{
			return this._i.AddGridSurface(GridCreationData);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddTinSurface(dynamic TinCreationData) 
		{
			return this._i.AddTinSurface(TinCreationData);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddGridVolumeSurface(dynamic GridVolumeCreationData) 
		{
			return this._i.AddGridVolumeSurface(GridVolumeCreationData);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddTinVolumeSurface(dynamic TinVolumeCreationData) 
		{
			return this._i.AddTinVolumeSurface(TinVolumeCreationData);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndex) 
		{
			this._i.Remove(varIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic ImportXML(string FileName) 
		{
			return this._i.ImportXML(FileName);
		}

		///<summary>
		///
		///</summary>
		public dynamic ImportTIN(string FileName) 
		{
			return this._i.ImportTIN(FileName);
		}

		///<summary>
		///
		///</summary>
		public dynamic ImportDEM(string FileName) 
		{
			return this._i.ImportDEM(FileName);
		}
	}
}
