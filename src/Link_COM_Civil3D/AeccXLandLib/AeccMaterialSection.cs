namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMaterialSection 
	{
		public AeccXLandLib.IAeccMaterialSection _i;
		internal AeccMaterialSection(object AeccMaterialSection_object) 
		{
			this._i = AeccMaterialSection_object as AeccXLandLib.IAeccMaterialSection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string MappingName => this._i.MappingName;

		///<summary>
		///
		///</summary>
		public string MaterialName => this._i.MaterialName;
	}
}
