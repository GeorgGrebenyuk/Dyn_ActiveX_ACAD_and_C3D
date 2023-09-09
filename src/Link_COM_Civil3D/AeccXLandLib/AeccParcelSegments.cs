namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelSegments 
	{
		public AeccXLandLib.IAeccParcelSegments _i;
		internal AeccParcelSegments(object AeccParcelSegments_object) 
		{
			this._i = AeccParcelSegments_object as AeccXLandLib.IAeccParcelSegments;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddLine(double StartX,double StartY,double EndX,double EndY) 
		{
			return this._i.AddLine(StartX,StartY,EndX,EndY);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddCurve(double StartX,double StartY,double Bulge,double EndX,double EndY) 
		{
			return this._i.AddCurve(StartX,StartY,Bulge,EndX,EndY);
		}

		///<summary>
		///
		///</summary>
		public dynamic AddCurve2(double StartX,double StartY,double MiddleX,double MiddleY,double EndX,double EndY) 
		{
			return this._i.AddCurve2(StartX,StartY,MiddleX,MiddleY,EndX,EndY);
		}

		///<summary>
		///
		///</summary>
		public void AddFromEntity(dynamic entity,dynamic pVal) 
		{
			this._i.AddFromEntity(entity,pVal);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;
	}
}
