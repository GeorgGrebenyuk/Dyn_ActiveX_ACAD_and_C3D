namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceBreaklines 
	{
		public AeccXLandLib.IAeccSurfaceBreaklines _i;
		internal AeccSurfaceBreaklines(object AeccSurfaceBreaklines_object) 
		{
			this._i = AeccSurfaceBreaklines_object as AeccXLandLib.IAeccSurfaceBreaklines;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic AddNonDestructiveBreakline(object pBreaklineEntities,string Description,double MidOrdinateDistance) 
		{
			return this._i.AddNonDestructiveBreakline(pBreaklineEntities,Description,MidOrdinateDistance);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddStandardBreakline(object pBreaklineEntities,string Description,double MidOrdinateDistance) 
		{
			return this._i.AddStandardBreakline(pBreaklineEntities,Description,MidOrdinateDistance);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddStandardBreaklineWithSuppAndWeed(object pBreaklineEntities,string Description,double MidOrdinateDistance,double SuppDist,double weeDist,double weedAngle) 
		{
			return this._i.AddStandardBreaklineWithSuppAndWeed(pBreaklineEntities,Description,MidOrdinateDistance,SuppDist,weeDist,weedAngle);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddProximityBreakline(object pBreaklineEntities,string Description,double MidOrdinateDistance) 
		{
			return this._i.AddProximityBreakline(pBreaklineEntities,Description,MidOrdinateDistance);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddWallBreakline(object pBreaklineEntities,string Description,double MidOrdinateDistance,object ElevationsArray,object OffsetsArray) 
		{
			return this._i.AddWallBreakline(pBreaklineEntities,Description,MidOrdinateDistance,ElevationsArray,OffsetsArray);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddWallBreaklineWithSuppAndWeed(object pBreaklineEntities,string Description,double MidOrdinateDistance,object ElevationsArray,object OffsetsArray,double SuppDist,double weeDist,double weedAngle) 
		{
			return this._i.AddWallBreaklineWithSuppAndWeed(pBreaklineEntities,Description,MidOrdinateDistance,ElevationsArray,OffsetsArray,SuppDist,weeDist,weedAngle);
		}

		///<summary>
		///
		///</summary>
		public object AddBreaklineFromFile(string Description,string Filname,double MidOrdinateDistance,AeccXLandLib.AeccBreaklineFileLinkageType FileLinkageType) 
		{
			return this._i.AddBreaklineFromFile(Description,Filname,MidOrdinateDistance,FileLinkageType);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object varIndex) 
		{
			this._i.Remove(varIndex);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object varIndex) 
		{
			return this._i.Item(varIndex);
		}
	}
}
