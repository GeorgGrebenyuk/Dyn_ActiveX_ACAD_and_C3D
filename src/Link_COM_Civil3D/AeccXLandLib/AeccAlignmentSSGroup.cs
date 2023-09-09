﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSSGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSSGroup _i;
		internal AeccAlignmentSSGroup(object AeccAlignmentSSGroup_object) 
		{
			this._i = AeccAlignmentSSGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSSGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Spiral1 => this._i.Spiral1;

		///<summary>
		///
		///</summary>
		public dynamic Spiral2 => this._i.Spiral2;
	}
}
