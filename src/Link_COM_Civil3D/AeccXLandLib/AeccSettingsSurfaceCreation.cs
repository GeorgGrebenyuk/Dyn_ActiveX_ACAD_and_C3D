namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSurfaceCreation 
	{
		public AeccXLandLib.IAeccSettingsSurfaceCreation _i;
		internal AeccSettingsSurfaceCreation(object AeccSettingsSurfaceCreation_object) 
		{
			this._i = AeccSettingsSurfaceCreation_object as AeccXLandLib.IAeccSettingsSurfaceCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic GridSurfaceXSpacing => this._i.GridSurfaceXSpacing;

		///<summary>
		///
		///</summary>
		public dynamic GridSurfaceYSpacing => this._i.GridSurfaceYSpacing;

		///<summary>
		///
		///</summary>
		public dynamic GridSurfaceOrientation => this._i.GridSurfaceOrientation;

		///<summary>
		///
		///</summary>
		public dynamic CutFactor => this._i.CutFactor;

		///<summary>
		///
		///</summary>
		public dynamic FillFactor => this._i.FillFactor;
	}
}
