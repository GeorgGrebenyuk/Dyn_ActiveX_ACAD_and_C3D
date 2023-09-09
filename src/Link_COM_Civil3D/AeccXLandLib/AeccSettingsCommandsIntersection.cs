﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCommandsIntersection 
	{
		public AeccXLandLib.IAeccSettingsCommandsIntersection _i;
		internal AeccSettingsCommandsIntersection(object AeccSettingsCommandsIntersection_object) 
		{
			this._i = AeccSettingsCommandsIntersection_object as AeccXLandLib.IAeccSettingsCommandsIntersection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddIntersectionLabel => this._i.AddIntersectionLabel;

		///<summary>
		///
		///</summary>
		public dynamic CreateIntersection => this._i.CreateIntersection;
	}
}
