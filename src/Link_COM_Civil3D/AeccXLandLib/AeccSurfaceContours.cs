namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceContours 
	{
		public AeccXLandLib.IAeccSurfaceContours _i;
		internal AeccSurfaceContours(object AeccSurfaceContours_object) 
		{
			this._i = AeccSurfaceContours_object as AeccXLandLib.IAeccSurfaceContours;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(object pContourEntities,string Description,double WeedingDistance,double WeedingAngle,double Distance,double MidOrdDistance) 
		{
			return this._i.Add(pContourEntities,Description,WeedingDistance,WeedingAngle,Distance,MidOrdDistance);
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
