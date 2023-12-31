﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSuperimposeProfile 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSuperimposeProfile _i;
		internal AeccSettingsSuperimposeProfile(object AeccSettingsSuperimposeProfile_object) 
		{
			this._i = AeccSettingsSuperimposeProfile_object as Autodesk.AECC.Interop.Land.IAeccSettingsSuperimposeProfile;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic MidOridinateDistH => this._i.MidOridinateDistH;

		///<summary>
		///
		///</summary>
		public dynamic MidOridinateDistV => this._i.MidOridinateDistV;
	}
}
