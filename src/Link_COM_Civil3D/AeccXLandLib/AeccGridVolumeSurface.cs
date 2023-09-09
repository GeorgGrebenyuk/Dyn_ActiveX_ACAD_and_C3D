namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridVolumeSurface 
	{
		public AeccXLandLib.IAeccGridVolumeSurface _i;
		internal AeccGridVolumeSurface(object AeccGridVolumeSurface_object) 
		{
			this._i = AeccGridVolumeSurface_object as AeccXLandLib.IAeccGridVolumeSurface;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Statistics => this._i.Statistics;

		///<summary>
		///
		///</summary>
		public dynamic DefinitionProperties => this._i.DefinitionProperties;

		///<summary>
		///
		///</summary>
		public object OutputCells => this._i.OutputCells;
	}
}
