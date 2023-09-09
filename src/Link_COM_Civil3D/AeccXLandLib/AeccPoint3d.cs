namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPoint3d 
	{
		public AeccXLandLib.IAeccPoint3d _i;
		internal AeccPoint3d(object AeccPoint3d_object) 
		{
			this._i = AeccPoint3d_object as AeccXLandLib.IAeccPoint3d;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double X => this._i.X;

		///<summary>
		///
		///</summary>
		public void Set_X(double pdX) 
		{
			this._i.X = pdX;
		}

		///<summary>
		///
		///</summary>
		public double Y => this._i.Y;

		///<summary>
		///
		///</summary>
		public void Set_Y(double pdY) 
		{
			this._i.Y = pdY;
		}

		///<summary>
		///
		///</summary>
		public double Z => this._i.Z;

		///<summary>
		///
		///</summary>
		public void Set_Z(double pdZ) 
		{
			this._i.Z = pdZ;
		}

		///<summary>
		///
		///</summary>
		public void SetPoint(double dX,double dY,double dZ) 
		{
			this._i.SetPoint(dX,dY,dZ);
		}

		///<summary>
		///
		///</summary>
		public void GetPoint(out double pdX,out double pdY,out double pdZ) 
		{
			this._i.GetPoint(out pdX,out pdY,out pdZ);
		}
	}
}
