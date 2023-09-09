namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSamplingIncrements 
	{
		public AeccXLandLib.IAeccSettingsSamplingIncrements _i;
		internal AeccSettingsSamplingIncrements(object AeccSettingsSamplingIncrements_object) 
		{
			this._i = AeccSettingsSamplingIncrements_object as AeccXLandLib.IAeccSettingsSamplingIncrements;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic UseSamplingIncrements => this._i.UseSamplingIncrements;

		///<summary>
		///
		///</summary>
		public dynamic AlongTangents => this._i.AlongTangents;

		///<summary>
		///
		///</summary>
		public dynamic AlongSpirals => this._i.AlongSpirals;

		///<summary>
		///
		///</summary>
		public dynamic AlongCurves => this._i.AlongCurves;
	}
}
