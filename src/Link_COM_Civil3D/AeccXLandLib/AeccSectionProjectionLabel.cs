﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionProjectionLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionProjectionLabel _i;
		internal AeccSectionProjectionLabel(object AeccSectionProjectionLabel_object) 
		{
			this._i = AeccSectionProjectionLabel_object as Autodesk.AECC.Interop.Land.IAeccSectionProjectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
