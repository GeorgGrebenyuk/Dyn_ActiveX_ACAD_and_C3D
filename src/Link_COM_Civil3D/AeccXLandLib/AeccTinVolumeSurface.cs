﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinVolumeSurface 
	{
		public AeccXLandLib.IAeccTinVolumeSurface _i;
		internal AeccTinVolumeSurface(object AeccTinVolumeSurface_object) 
		{
			this._i = AeccTinVolumeSurface_object as AeccXLandLib.IAeccTinVolumeSurface;
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
		public object OutputTriangles => this._i.OutputTriangles;
	}
}
