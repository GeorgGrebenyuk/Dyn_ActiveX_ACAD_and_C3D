namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGridVolumeSurfaceDefinitionProperties 
	{
		public Autodesk.AECC.Interop.Land.IAeccGridVolumeSurfaceDefinitionProperties _i;
		internal AeccGridVolumeSurfaceDefinitionProperties(object AeccGridVolumeSurfaceDefinitionProperties_object) 
		{
			this._i = AeccGridVolumeSurfaceDefinitionProperties_object as Autodesk.AECC.Interop.Land.IAeccGridVolumeSurfaceDefinitionProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
