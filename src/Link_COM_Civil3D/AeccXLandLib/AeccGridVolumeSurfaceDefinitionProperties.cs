namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridVolumeSurfaceDefinitionProperties 
	{
		public AeccXLandLib.IAeccGridVolumeSurfaceDefinitionProperties _i;
		internal AeccGridVolumeSurfaceDefinitionProperties(object AeccGridVolumeSurfaceDefinitionProperties_object) 
		{
			this._i = AeccGridVolumeSurfaceDefinitionProperties_object as AeccXLandLib.IAeccGridVolumeSurfaceDefinitionProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
